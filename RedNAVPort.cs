
using System;
using System.Globalization;
using System.IO.Ports;
using System.Text;
using UCNLNMEA;

namespace RedNAVHost
{
    #region Extra classes

    public class TrackItem : GeoPoint3D
    {      
        public DateTime TimeStamp { get; private set; }

        public TrackItem(DateTime timeStamp, double lat, double lon, double dpt) : base(lat, lon, dpt)
        {
            TimeStamp = timeStamp;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

    public class GeoPoint2D
    {
        public double Latitude;
        public double Longitude;
        public int PType;

        public GeoPoint2D(double lat, double lon, int type)
        {
            Latitude = lat;
            Longitude = lon;
            PType = type;
        }

        public GeoPoint2D()
            : this(0, 0, 3)
        {
        }

        public static string DegressToString(double angle)
        {
            int degree = (int)Math.Floor(angle);
            int minutes = (int)Math.Floor((angle - degree) * 60.0);
            double seconds = (angle - degree) * 3600 - minutes * 60.0;

            return string.Format(CultureInfo.InvariantCulture, "{0}°{1}\'{2:F04}\"", degree, minutes, seconds);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (PType == 0)
                sb.Append("RedBASE ");
            else if (PType == 1)
                sb.Append("Marked point ");
            else if (PType == 2)
                sb.Append("Waypoint ");

            if (Latitude < 0)
                sb.Append('S');
            else
                sb.Append('N');

            sb.Append(DegressToString(Math.Abs(Latitude)));
            sb.Append(", ");

            if (Longitude < 0)
                sb.Append('W');
            else
                sb.Append('E');

            sb.Append(DegressToString(Math.Abs(Longitude)));

            return sb.ToString();
        }

    }

    public class GeoPoint3D : GeoPoint2D
    {
        public double Depth;

        public GeoPoint3D(double lat, double lon, double dpt) : base(lat, lon, 3)
        {
            Depth = dpt;
        }

        public override string ToString()
        {
            return string.Format("{0}, DPT: {1:F02} m", base.ToString(), Depth);
        }

    }


    #endregion


    #region Custom event args

    public class LocalDataEventArgs : EventArgs
    {
        public LocalDataIDs LocalDataID { get; private set; }
        public double Value { get; private set; }

        public LocalDataEventArgs(LocalDataIDs localDataID, double value)
        {
            LocalDataID = localDataID;
            Value = value;
        }
    }

    public class WaypointEventArgs : EventArgs
    {
        public int WaypointIdx { get; private set; }
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }
        public int WaypointType { get; private set; }

        public WaypointEventArgs(int wpIdx, double lat, double lon, int wpType)
        {
            WaypointIdx = wpIdx;
            Latitude = lat;
            Longitude = lon;
            WaypointType = wpType;
        }
    }

    public class TrackItemEventArgs : EventArgs
    {
        public int ItemIdx { get; private set; }
        public int TotalItems { get; private set; }
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }
        public double Depth { get; private set; }
        public DateTime TimeStamp { get; private set; }

        public TrackItemEventArgs(int cIdx, int total, int hr, int min, int sec, double lat, double lon, double dpt)
        {
            ItemIdx = cIdx;
            TotalItems = total;

            try
            {
                TimeStamp = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hr, min, sec);
            }
            catch (Exception)
            {
                TimeStamp = DateTime.Now;
            }

            Latitude = lat;
            Longitude = lon;
            Depth = dpt;
        }
    }

    public class FieldValueEventArgs : EventArgs
    {
        public FieldIDs FieldID { get; private set; }
        public int FieldValue { get; private set; }

        public FieldValueEventArgs(FieldIDs fieldID, int fieldValue)
        {
            FieldID = fieldID;
            FieldValue = fieldValue;
        }
    }

    #endregion

    #region Custom enums
   
    public enum DeviceTypes
    {
        DEVICE_REDBASE = 0,
        DEVICE_REDNODE = 1,
        DEVICE_REDNAV = 2,
        DEVICE_REDGTR = 3,
        DEVICE_INVALID
    }

    public enum LocalDataIDs
    {
        LOC_DATA_DEVICE_INFO        = 0,
        LOC_DATA_MAX_REMOTE_TIMEOUT = 1,
        LOC_DATA_MAX_SUBSCRIBERS    = 2,
        LOC_DATA_DEPTH              = 3,
        LOC_DATA_TEMPERATURE        = 4,
        LOC_DATA_BAT_CHARGE         = 5,

        LOC_DATA_PRESSURE_RATING    = 6,
        LOC_DATA_ZERO_PRESSURE      = 7,
        LOC_DATA_1M_PRESSURE        = 8,
        LOC_DATA_SALINITY           = 9,
        LOC_DATA_SOUNDSPEED         = 10,

        LOC_DATA_TRACK_SIZE         = 11,
        LOC_DATA_WAYPOINTS_NUMBER   = 12,
        LOC_DATA_WAYPOINT           = 13,

        LOC_DATA_REDNODE_DEV_INFO   = 14,

        LOC_DATA_UNKNOWN
    }

    public enum InvokeIDs
    {
        LOC_INVOKE_FLASH_WRITE     = 0,
        LOC_INVOKE_CLEAR_WAYPOINTS = 1,
        LOC_INVOKE_CLEAR_TRACK     = 2,
        LOC_INVOKE_WRITE_NDTABLE   = 3,
        LOC_INVOKE_DPT_ZERO_ADJUST = 4,
        LOC_INVOKE_UNKNOWN
    }

    public enum ErrorIDs
    {
        LOC_ERR_NO_ERROR = 0,
        LOC_ERR_INVALID_SYNTAX = 1,
        LOC_ERR_UNSUPPORTED = 2,
        LOC_ERR_TRANSMITTER_BUSY = 3,
        LOC_ERR_ARGUMENT_OUT_OF_RANGE = 4,
        LOC_ERR_INVALID_OPERATION = 5,
        LOC_ERR_UNKNOWN_FIELD_ID = 6,
        LOC_ERR_VALUE_UNAVAILIBLE = 7,
        LOC_ERR_RECEIVER_BUSY = 8,
        LOC_ERR_INVALID
    }

    public enum FieldIDs
    {
        FLD_IS_MIRROR_SCREEN = 0,
        FLD_UNKNOWN
    }

    #endregion

    public class RedNavPort : IDisposable
    {
        #region Properties

        NMEASerialPort port;
        SerialPortSettings portSettings;
        PrecisionTimer timer;

        string[] portNames;
        int curPortIdx = -1;
        bool isEnumerating = false;        
        bool disposed = false;
        bool isDefined = false;

        int timCnt = 0;
        int timCntTimeout = 5;


        EventHandler<NewNMEAMessageEventArgs> port_NewNMEAMessage_Handler;
        EventHandler<SerialErrorReceivedEventArgs> port_PortError_Handler;

        public string SerialNumber { get; private set; }
        public string CoreMoniker { get; private set; }
        public string CoreVersion { get; private set; }
        public string SystemMoniker { get; private set; }
        public string SystemVersion { get; private set; }

        public string rn_SerialNumber { get; private set; }
        public string rn_CoreMoniker { get; private set; }
        public string rn_CoreVersion { get; private set; }
        public string rn_SystemMoniker { get; private set; }
        public string rn_SystemVersion { get; private set; }

        #region Public

        public bool IsStarted { get; private set; }

        public string PortName
        {
            get
            {
                return portSettings.PortName;
            }
        }
       
        #endregion

        #endregion

        #region Constrcuctor

        public RedNavPort()
        {
            portSettings = new SerialPortSettings("COM1", BaudRate.baudRate115200, Parity.None, DataBits.dataBits8, StopBits.One, Handshake.None);
           
            #region timers

            timer = new PrecisionTimer();
            timer.Mode = Mode.Periodic;
            timer.Period = 5000;
            timer.Tick += new EventHandler(timer_Tick);

            #endregion

            #region Handlers

            port_NewNMEAMessage_Handler = new EventHandler<NewNMEAMessageEventArgs>(port_NewNMEAMessage);
            port_PortError_Handler = new EventHandler<SerialErrorReceivedEventArgs>(port_PortError);

            #endregion

            #region NMEA

            NMEAInit();

            #endregion
        }

        #endregion

        #region Methods

        #region Private

        private static string BCDVersionToStr(int versionData)
        {
            return string.Format("{0}.{1}", (versionData >> 0x08).ToString(), (versionData & 0xff).ToString("X2"));
        }

        private void NMEAInit()
        {
            NMEAParser.AddManufacturerToProprietarySentencesBase(ManufacturerCodes.TNT);

            NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.TNT, "0", "x,x");                   // ACK
            NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.TNT, "1", "x,x");                   // FLD_SET
            NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.TNT, "2", "x,x");                   // FLD_GET
            NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.TNT, "3", "x,x");                   // FLD_VALUE
            NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.TNT, "4", "x,x");                   // LOC_DATA_GET
            NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.TNT, "5", "x,x.x");                 // LOC_DATA_VAL
            NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.TNT, "6", "x,x");                   // LOC_ACT_INVOKE
            NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.TNT, "!", "c--c,x,c--c,x,x,c--c");  // DEVICE_INFO
            NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.TNT, "!!", "c--c,x,c--c,x,x,c--c"); // RED_NODE_DEVICE_INFO
            NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.TNT, "H", "x,x");                   // GET_TRACK_ITEM
            NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.TNT, "I", "x,x,x,x,x,x.x,x.x,x.x"); // TRACK_POINT_VAL
            NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.TNT, "K", "x.x,x.x");               // SET_WAYPOINT
            NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.TNT, "L", "x,x.x,x.x,x");           // WAYPOINT_VAL
            NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.TNT, "P", "x,x.x");                 // SETVAL
        }
        
        private void UnsubscribePort()
        {
            if (port.NewNMEAMessage != null) port.NewNMEAMessage -= port_NewNMEAMessage_Handler;
            if (port.PortError != null) port.PortError -= port_PortError_Handler;

            SystemMoniker = string.Empty;
            SystemVersion = string.Empty;
            CoreMoniker = string.Empty;
            CoreVersion = string.Empty;
            SerialNumber = string.Empty;

        }

        private void InitPort()
        {
            port.NewNMEAMessage += port_NewNMEAMessage_Handler;
            port.PortError += port_PortError_Handler;
        }

        private void RestartPort()
        {
            try
            {
                if (port.IsOpen)
                    port.Close();

                UnsubscribePort();
                port.Dispose();
            }
            catch (Exception ex)
            {

            }

            StartEnumerate();
        }

        private void StartEnumerate()
        {
            isDefined = false;
            isEnumerating = true;
          
            if (ConnectionSearchingStarted != null)
                ConnectionSearchingStarted(this, new EventArgs());

            try
            {
                portNames = SerialPort.GetPortNames();                
            }
            catch (Exception ex)
            {

            }

            curPortIdx = 0;
            ContinueEnumerate();
        }

        private void ContinueEnumerate()
        {
            bool isStarted = false;

            if (portNames != null)
            {
                while ((!isStarted) && (curPortIdx < portNames.Length))
                {
                    isStarted = CheckNextPort();
                    curPortIdx++;
                }
            }

            timer.Start();
        }

        private bool CheckNextPort()
        {
            portSettings.PortName = portNames[curPortIdx];
            bool result = false;
            try
            {
                port = new NMEASerialPort(portSettings);
                port.NewNMEAMessage = new EventHandler<NewNMEAMessageEventArgs>(port_NewNMEAMessage);
                port.PortError = new EventHandler<SerialErrorReceivedEventArgs>(port_PortError);
                port.Open();

                var queryStr = NMEAParser.BuildProprietarySentence(ManufacturerCodes.TNT, "4", new object[] { (int)LocalDataIDs.LOC_DATA_DEVICE_INFO, 0 });
                port.SendData(queryStr);

                if (ConnectionEstablished != null) ConnectionEstablished(this, new EventArgs());

                timer.Start();
                                
                result = true;
            }
            catch (Exception ex)
            {
                if (port.IsOpen)
                    port.Close();

                UnsubscribePort();
                port.Dispose();
            }

            return result;
        }

        private void StopPort()
        {
            try
            {
                if ((port != null) && (port.IsOpen))
                    port.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (port != null)
                {
                    UnsubscribePort();
                    port.Dispose();
                }
            }
        }


        #region Custom sentences processors

        private void Process_ACK(object[] parameters)
        {
            if (timer.IsRunning) { timer.Stop(); timCnt = 0; }

            ErrorIDs errorID = (ErrorIDs)((int)parameters[0]);

            if (errorID == ErrorIDs.LOC_ERR_NO_ERROR)
                if (ACKReceived != null) ACKReceived(this, new EventArgs());
        }

        private void Process_FLD_Value(object[] parameters)
        {
            if (timer.IsRunning) { timer.Stop(); timCnt = 0; }

            FieldIDs fieldID = (FieldIDs)((int)(parameters[0]));
            int fldValue = (int)parameters[1];

            if (FieldValueReceived != null) FieldValueReceived(this, new FieldValueEventArgs(fieldID, fldValue)); 
        }

        private void Process_LOC_DATA(object[] parameters)
        {
            if (timer.IsRunning) { timer.Stop(); timCnt = 0; }

            LocalDataIDs localDataID = (LocalDataIDs)((int)(parameters[0]));
            double value = (double)parameters[1];

            if (LocalDataReceived != null) LocalDataReceived(this, new LocalDataEventArgs(localDataID, value));            
        }

        private void Process_DEVICE_INFO(object[] parameters)
        {
            var deviceType = (DeviceTypes)((int)parameters[4]);            

            if (deviceType == DeviceTypes.DEVICE_REDNAV)
            {
                isDefined = true;

                if (timer.IsRunning) { timer.Stop(); timCnt = 0; }
                isEnumerating = false;

                SystemMoniker = (string)parameters[0];
                SystemVersion = BCDVersionToStr((int)parameters[1]);
                CoreMoniker = (string)parameters[2];
                CoreVersion = BCDVersionToStr((int)parameters[3]);
                SerialNumber = (string)parameters[5];                

                if (PortReady != null) PortReady(this, new EventArgs());
            }
            else
            {
                ContinueEnumerate();
            }
        }

        private void Process_DEVICE_INFO_RN(object[] parameters)
        {
            if (timer.IsRunning) { timer.Stop(); timCnt = 0; }
            var deviceType = (DeviceTypes)((int)parameters[4]);
    
            rn_SystemMoniker = (string)parameters[0];
            rn_SystemVersion = BCDVersionToStr((int)parameters[1]);
            rn_CoreMoniker = (string)parameters[2];
            rn_CoreVersion = BCDVersionToStr((int)parameters[3]);
            rn_SerialNumber = (string)parameters[5];

            if (RNDeviceInfoUpdated != null) RNDeviceInfoUpdated(this, new EventArgs());
        }

        private void Process_TRACK_POINT_VAL(object[] parameters)
        {
            if (timer.IsRunning) { timer.Stop(); timCnt = 0; }

            // cIdx, totalNumber, hr, min, sec, lat, lon, dpt
            int cIdx = (int)parameters[0];
            int totalNumber = (int)parameters[1];
            int hr = (int)parameters[2];
            int min = (int)parameters[3];
            int sec = (int)parameters[4];
            double lat = (double)parameters[5];
            double lon = (double)parameters[6];
            double dpt = (double)parameters[7];
            
            if (TrackItemReceived != null)
                TrackItemReceived(this, new TrackItemEventArgs(cIdx, totalNumber, hr, min, sec, lat, lon, dpt));            
        }

        private void Process_WAYPOINT_VAL(object[] parameters)
        {
            if (timer.IsRunning) { timer.Stop(); timCnt = 0; }

            // wpIdx, lat, lon
            int wpIdx = (int)parameters[0];
            double lat = (double)parameters[1];
            double lon = (double)parameters[2];
            int wpType = (int)parameters[3];

            if (WaypointReceived != null)
                WaypointReceived(this, new WaypointEventArgs(wpIdx, lat, lon, wpType));            
        }

        #endregion

        private void SafelySend(string msg)
        {
            try
            {
                port.SendData(msg);
                timer.Start();
            }
            catch (Exception ex)
            {
                RestartPort();
            }
        }

        #endregion

        #region Public

        public void Start()
        {
            if (!IsStarted)
            {
                StartEnumerate();
            }
            else
            {
                throw new InvalidOperationException("Already running");
            }
        }

        public void Stop()
        {
            if (timer.IsRunning) { timer.Stop(); timCnt = 0; }

            if ((port != null) && (port.IsOpen))
            {
                port.Close();
                UnsubscribePort();
            }
        
            isDefined = false;
        }

        public void Restart()
        {
            RestartPort();
        }

        public string QueryMirroredSet(bool isMirrored)
        {
            int fldVal;
            if (isMirrored) fldVal = 1;
            else fldVal = 0;
            return NMEAParser.BuildProprietarySentence(ManufacturerCodes.TNT, "2", new object[] { (int)FieldIDs.FLD_IS_MIRROR_SCREEN, fldVal });
        }

        public string QueryMirroredGet()
        {            
            return NMEAParser.BuildProprietarySentence(ManufacturerCodes.TNT, "1", new object[] { (int)FieldIDs.FLD_IS_MIRROR_SCREEN, 0 });
        }

        public string QuerySalinitySet(double salinity)
        {
            return NMEAParser.BuildProprietarySentence(ManufacturerCodes.TNT, "P", new object[] { (int)LocalDataIDs.LOC_DATA_SALINITY, salinity });
        }

        public string QuerySalinityGet()
        {
            return NMEAParser.BuildProprietarySentence(ManufacturerCodes.TNT, "4", new object[] { (int)LocalDataIDs.LOC_DATA_SALINITY, 0 });
        }

        public string QueryWaypointSet(double lat, double lon)
        {
            return NMEAParser.BuildProprietarySentence(ManufacturerCodes.TNT, "K", new object[] { lat, lon });
        }

        public string QueryWaypointGet(int idx)
        {
            return NMEAParser.BuildProprietarySentence(ManufacturerCodes.TNT, "4", new object[] { (int)LocalDataIDs.LOC_DATA_WAYPOINT, idx });
        }

        public string QueryTrackSize()
        {
            return NMEAParser.BuildProprietarySentence(ManufacturerCodes.TNT, "4", new object[] { (int)LocalDataIDs.LOC_DATA_TRACK_SIZE, 0 });
        }

        public string QueryWaypointsCount()
        {
            return NMEAParser.BuildProprietarySentence(ManufacturerCodes.TNT, "4", new object[] { (int)LocalDataIDs.LOC_DATA_WAYPOINTS_NUMBER, 0 });
        }

        public string QueryTrackItem(int idx)
        {
            return NMEAParser.BuildProprietarySentence(ManufacturerCodes.TNT, "H", new object[] { idx, 0 });
        }

        public string QueryTrackClear()
        {
            return NMEAParser.BuildProprietarySentence(ManufacturerCodes.TNT, "6", new object[] { (int)InvokeIDs.LOC_INVOKE_CLEAR_TRACK, 0 });
        }

        public string QueryWaypointsClear()
        {
            return NMEAParser.BuildProprietarySentence(ManufacturerCodes.TNT, "6", new object[] { (int)InvokeIDs.LOC_INVOKE_CLEAR_WAYPOINTS, 0 });
        }

        public string QueryFlashWrite()
        {
            return NMEAParser.BuildProprietarySentence(ManufacturerCodes.TNT, "6", new object[] { (int)InvokeIDs.LOC_INVOKE_FLASH_WRITE, 0 });
        }

        public string QueryDeviceInfo()
        {
            return NMEAParser.BuildProprietarySentence(ManufacturerCodes.TNT, "4", new object[] { (int)LocalDataIDs.LOC_DATA_DEVICE_INFO, 0 });
        }

        public string QueryBatteryCharge()
        {
            return NMEAParser.BuildProprietarySentence(ManufacturerCodes.TNT, "4", new object[] { (int)LocalDataIDs.LOC_DATA_BAT_CHARGE, 0 });
        }

        public string QueryRedNodeDevInfo()
        {
            return NMEAParser.BuildProprietarySentence(ManufacturerCodes.TNT, "4", new object[] { (int)LocalDataIDs.LOC_DATA_REDNODE_DEV_INFO, 0 });
        }
       
        public void Send(string commands)
        {
            SafelySend(commands);
        }
       
        #endregion

        #endregion

        #region Handlers

        #region timer

        private void timer_Tick(object sender, EventArgs e)
        {
            if (isEnumerating)
            {
                timer.Stop(); 
                timCnt = 0;
                StopPort();

                if ((portNames == null) || (curPortIdx >= portNames.Length))
                    StartEnumerate();
                else
                    ContinueEnumerate();
            }
            else
            {
                if (++timCnt >= timCntTimeout)
                {
                    timCnt = 0;
                    RestartPort();
                }
            }
        }

        #endregion

        #region port

        private void port_NewNMEAMessage(object sender, NewNMEAMessageEventArgs e)
        {
            try
            {
                var sentence = NMEAParser.Parse(e.Message);

                if (sentence is NMEAProprietarySentence)
                {
                    NMEAProprietarySentence snt = ((NMEAProprietarySentence)(sentence));

                    if (snt.SentenceIDString == "0")
                    {
                        // ACK - analyze error code
                        Process_ACK(snt.parameters);
                    }                    
                    else if (snt.SentenceIDString == "5")
                    {
                        // local data value
                        Process_LOC_DATA(snt.parameters);
                    }
                    else if (snt.SentenceIDString == "3")
                    {
                        // settings field value
                        Process_FLD_Value(snt.parameters);
                    }
                    else if (snt.SentenceIDString == "!")
                    {
                        // device info
                        Process_DEVICE_INFO(snt.parameters);
                    }
                    else if (snt.SentenceIDString == "!!")
                    {
                        Process_DEVICE_INFO_RN(snt.parameters);
                    }
                    else if (snt.SentenceIDString == "I")
                    {
                        // track point val
                        Process_TRACK_POINT_VAL(snt.parameters);
                    }
                    else if (snt.SentenceIDString == "L")
                    {
                        // waypoint value
                        Process_WAYPOINT_VAL(snt.parameters);
                    }                   
                }
                else
                {
                    // TODO: write log
                }

            }
            catch (Exception ex)
            {
                // TODO: write log
            }
        }

        private void port_PortError(object sender, SerialErrorReceivedEventArgs e)
        {
            // TODO: write log
        }
       
        #endregion

        #endregion

        #region Events

        public EventHandler ConnectionSearchingStarted;
        public EventHandler ConnectionEstablished;
        public EventHandler PortReady;

        public EventHandler ACKReceived;
        public EventHandler<LocalDataEventArgs> LocalDataReceived;        
        public EventHandler<WaypointEventArgs> WaypointReceived;
        public EventHandler<TrackItemEventArgs> TrackItemReceived;
        public EventHandler<FieldValueEventArgs> FieldValueReceived;

        public EventHandler RNDeviceInfoUpdated;

        
        #endregion

        #region IDisposable

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    if (timer != null) timer.Dispose();
                    if (port != null) port.Dispose();
                }

                disposed = true;
            }
        }

        #endregion
    }

}
