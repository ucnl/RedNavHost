using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
//using UCNLGpx;
using UCNLKML;
using UCNLUI.Dialogs;
using System.Resources;

namespace RedNAVHost
{
    public partial class MainForm : Form
    {
        #region Invokers

        private void InvokeSetText(Control ctrl, string text)
        {
            if (ctrl.InvokeRequired)
                ctrl.Invoke((MethodInvoker)delegate { ctrl.Text = text; });
            else
                ctrl.Text = text;
        }

        private void InvokeSetText(StatusStrip sstrip, ToolStripStatusLabel slbl, string text)
        {
            if (sstrip.InvokeRequired)
                sstrip.Invoke((MethodInvoker)delegate { slbl.Text = text; });
            else
                slbl.Text = text;
        }

        private void InvokeSetProgress(StatusStrip sstrip, ToolStripProgressBar pbar, int value)
        {
            if (sstrip.InvokeRequired)
                sstrip.Invoke((MethodInvoker)delegate { pbar.Value = value; });
            else
                pbar.Value = value;
        }

        private void InvokeSetProgressType(StatusStrip sstrip, ToolStripProgressBar pbar, ProgressBarStyle pstyle)
        {
            if (sstrip.InvokeRequired)
                sstrip.Invoke((MethodInvoker)delegate { pbar.Style = pstyle; });
            else
                pbar.Style = pstyle;
        }

        private void InvokeSetEnabledState(Control ctrl, bool isEnabled)
        {
            if (ctrl.InvokeRequired)
                ctrl.Invoke((MethodInvoker)delegate { ctrl.Enabled = isEnabled; });
            else
                ctrl.Enabled = isEnabled;
        }

        private void InvokeAddListBoxItem(ListBox lbx, object item)
        {
            if (lbx.InvokeRequired)
                lbx.Invoke((MethodInvoker)delegate { lbx.Items.Add(item); });
            else
                lbx.Items.Add(item);
        }

        private void InvokeListBoxClear(ListBox lbx)
        {
            if (lbx.InvokeRequired)
                lbx.Invoke((MethodInvoker)delegate { lbx.Items.Clear(); });
            else
                lbx.Items.Clear();
        }

        private void InvokeSetButtonsVisibleState(bool isVisible)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    applySettingsBtn.Visible = isVisible;
                    downloadTrackBtn.Visible = isVisible;
                    syncWaypointsBtn.Visible = isVisible;
                });
            }
            else
            {
                applySettingsBtn.Visible = isVisible;
                downloadTrackBtn.Visible = isVisible;
                syncWaypointsBtn.Visible = isVisible;
            }
        }

        #endregion

        #region Properties

        RedNavPort port;

        ThreadStart ts;
        Thread portThread;

        int waypointsCount = 0;
        int trackCount = 0;        
        double salinity
        {
            get
            {
                return Convert.ToDouble(salinityEdit.Value);
            }
            set
            {
                if (salinityEdit.InvokeRequired)
                    salinityEdit.Invoke((MethodInvoker)delegate { salinityEdit.Value = Convert.ToDecimal(value); });
                else
                    salinityEdit.Value = Convert.ToDecimal(value);
            }
        }

        bool isFlipScreen
        {
            get
            {
                return isFlipScreenChb.Checked;
            }
            set
            {
                if (isFlipScreenChb.InvokeRequired)
                    isFlipScreenChb.Invoke((MethodInvoker)delegate { isFlipScreenChb.Checked = value; });
                else
                    isFlipScreenChb.Checked = value;
            }
        }
       
        double latDeg
        {
            get { return Convert.ToDouble(latDegEdit.Value); }
            set { latDegEdit.Value = Convert.ToDecimal(value); }
        }

        double latMin
        {
            get { return Convert.ToDouble(latMinEdit.Value); }
            set { latMinEdit.Value = Convert.ToDecimal(value); }
        }

        double latSec
        {
            get { return Convert.ToDouble(latSecEdit.Value); }
            set { latSecEdit.Value = Convert.ToDecimal(value); }
        }
      
        double lonDeg
        {
            get { return Convert.ToDouble(lonDegEdit.Value); }
            set { lonDegEdit.Value = Convert.ToDecimal(value); }
        }

        double lonMin
        {
            get { return Convert.ToDouble(lonMinEdit.Value); }
            set { lonMinEdit.Value = Convert.ToDecimal(value); }
        }

        double lonSec
        {
            get { return Convert.ToDouble(lonSecEdit.Value); }
            set { lonSecEdit.Value = Convert.ToDecimal(value); }
        }

        bool isClearingWaypoints = false;
        bool isSavingFlash = false;
        bool isSavingSettings = false;
        bool isClearingTrack = false;

        List<TrackItem> track = new List<TrackItem>();
        List<GeoPoint2D> waypoints = new List<GeoPoint2D>();

        ResourceManager LocRM = new ResourceManager("RedNAVHost.MainFormStrings", typeof(MainForm).Assembly);

        #endregion

        #region Constructor

        public MainForm()
        {
            InitializeComponent();

            applySettingsBtn.Enabled = false;

            port = new RedNavPort();
            port.ConnectionSearchingStarted += new EventHandler(port_ConnectionSearchingStarted);
            port.ConnectionEstablished += new EventHandler(port_ConnectionEstablished);
            port.PortReady += new EventHandler(port_PortReady);
            port.LocalDataReceived += new EventHandler<LocalDataEventArgs>(port_LocalDataReceived);
            port.TrackItemReceived += new EventHandler<TrackItemEventArgs>(port_TrackItemReceived);
            port.WaypointReceived += new EventHandler<WaypointEventArgs>(port_WaypointReceived);
            port.ACKReceived += new EventHandler(port_ACKReceived);
            port.RNDeviceInfoUpdated += new EventHandler(port_RNDeviceInfoUpdated);
            port.FieldValueReceived += new EventHandler<FieldValueEventArgs>(port_FieldValueReceived);
        }

        #endregion

        #region Methods

        private string Get16Hash(string src)
        {
            var bytes = Encoding.ASCII.GetBytes(src);
            var crc16 = CRC.CRC_CRC16_Get(bytes);

            crc16 = (ushort)((ushort)((crc16 & 0xff) << 8) | ((crc16 >> 8) & 0xff));

            return crc16.ToString("X2");
        }

        private void SaveTrackXML(string fileName)
        {
            bool isSaved = false;

            KMLData data = new KMLData(fileName, "Generated by RedNavHost, www.unavlab.com");

            for (int i = 0; i < waypoints.Count; i++)
            {
                if (waypoints[i].PType == 0)
                    data.Add(new KMLPlacemark(LocRM.GetString("mfText_BuoyStr"), "", false, false, new KMLLocation(waypoints[i].Longitude, waypoints[i].Latitude, 0)));
                else if (waypoints[i].PType == 1)
                    data.Add(new KMLPlacemark(string.Format("{0} {1}", LocRM.GetString("mfText_WaypointStr"), i), "", false, false, new KMLLocation(waypoints[i].Longitude, waypoints[i].Latitude, 0)));
                else if (waypoints[i].PType == 2)
                    data.Add(new KMLPlacemark(string.Format("{0} {1}", LocRM.GetString("mfText_SavedPoint"), i), "", false, false, new KMLLocation(waypoints[i].Longitude, waypoints[i].Latitude, 0)));

            }

            List<KMLLocation> tPOwn = new List<KMLLocation>();

            for (int i = 0; i < track.Count; i++)
            {                
                tPOwn.Add(new KMLLocation(track[i].Longitude, track[i].Latitude, -track[i].Depth));
            }

            if (track.Count > 0)
            {
                data.Add(new KMLPlacemark(LocRM.GetString("mfText_OwnTrackStr"), string.Format("RedWave RedNav {0}", LocRM.GetString("mfText_TrackStr")), tPOwn.ToArray()));
            }

            try
            {
                TinyKML.Write(data, fileName);
                track = null;
                isSaved = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("{0} {1}: {2}", 
                    LocRM.GetString("mfText_ErrorSavingDataStr"),
                    fileName, 
                    ex.Message), 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }

            if (isSaved)
            {
                if (MessageBox.Show(LocRM.GetString("mfText_RemoveTrackFromDeviceStr"),
                    LocRM.GetString("mfText_QuestionStr"), MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    port.Send(port.QueryTrackClear());
                    this.UseWaitCursor = true;
                    Thread.Sleep(5000);
                    this.UseWaitCursor = false;

                    InvokeSetText(trackCountLbl, LocRM.GetString("mfText_DeviceTrackIsEmptyStr"));
                    InvokeSetEnabledState(downloadTrackBtn, false);
                }
            }
        }

        /*
        private void SaveTrackGPX(string fileName)
        {
            bool isSaved = false;

            GPXMetadata metadata = new GPXMetadata();
            metadata.Description = "Generated by RedNavHost, www.unavlab.com";

            List<BasicNamedPoint3D> wps = new List<BasicNamedPoint3D>();

            for (int i = 0; i < waypoints.Count; i++)
            {
                if (waypoints[i].PType == 0)
                    wps.Add(new BasicNamedPoint3D(string.Format("Буй #{0}", i), waypoints[i].Latitude, waypoints[i].Longitude, 0));
                else if (waypoints[i].PType == 1)
                    wps.Add(new BasicNamedPoint3D(string.Format("Путевая точка #{0}", i), waypoints[i].Latitude, waypoints[i].Longitude, 0));
                else if (waypoints[i].PType == 2)
                    wps.Add(new BasicNamedPoint3D(string.Format("Сохраненная точка #{0}", i), waypoints[i].Latitude, waypoints[i].Longitude, 0));

            }

                       List<List<BasicPoint3D>> trk = new List<List<BasicPoint3D>>();

            List<BasicPoint3D> ownTrack = new List<BasicPoint3D>();
          
            for (int i = 0; i < track.Count; i++)
            {
                // WARNING! Depth goes as a negative value!
                ownTrack.Add(new BasicPoint3D(track[i].Latitude, track[i].Longitude, -track[i].Depth));                
            }

            trk.Add(ownTrack);
        

            try
            {
                GPXProvider.Save(fileName, metadata, wps, trk);
                track = null;
                isSaved = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ошибка при сохранении трека в {0}: {1}", fileName, ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (isSaved)
            {
                if (MessageBox.Show("Удалить трек из устройства?",
                    "Question", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    port.Send(port.QueryTrackClear());
                    this.UseWaitCursor = true;
                    Thread.Sleep(5000);
                    this.UseWaitCursor = false;

                    InvokeSetText(trackCountLbl, "Трек устройства пуст");
                    InvokeSetEnabledState(downloadTrackBtn, false);
                }
            }
        }
        */

        private void SaveTrackCSV(string fileName)
        {
            bool isSaved = false;

            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine("str;lat;lon;dpt;hr;mn;sc");

            for (int i = 0; i < waypoints.Count; i++)
            {
                sb.AppendFormat("{0};{1:F06};{2:F06};{3:F03};{4};{5};{6}\r\n", 
                    waypoints[i].PType, 
                    waypoints[i].Latitude,
                    waypoints[i].Longitude,
                    0,
                    -1,
                    -1,
                    -1);                
            }

          

            for (int i = 0; i < track.Count; i++)
            {
                sb.AppendFormat("{0};{1:F06};{2:F06};{3:F03};{4};{5};{6}\r\n",
                    -1,
                    track[i].Latitude,
                    track[i].Longitude,
                    track[i].Depth,
                    track[i].TimeStamp.Hour,
                    track[i].TimeStamp.Minute,
                    track[i].TimeStamp.Second);
            }          

            try
            {
                File.WriteAllText(fileName, sb.ToString());
                track = null;
                isSaved = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("{0} {1}: {2}",
                    LocRM.GetString("mfText_ErrorSavingDataStr"),
                    fileName,
                    ex.Message),
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            if (isSaved)
            {
                if (MessageBox.Show(LocRM.GetString("mfText_RemoveTrackFromDeviceStr"),
                    LocRM.GetString("mfText_QuestionStr"), MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    port.Send(port.QueryTrackClear());
                    this.UseWaitCursor = true;
                    Thread.Sleep(5000);
                    this.UseWaitCursor = false;

                    InvokeSetText(trackCountLbl, LocRM.GetString("mfText_DeviceTrackIsEmptyStr"));
                    InvokeSetEnabledState(downloadTrackBtn, false);
                }
            }
        }


        public string GetTimeDateFileName()
        {
            return GetTimeDateFileName(DateTime.Now);
        }

        public string GetTimeDateFileName(DateTime dt)
        {
            return string.Format("{0}-{1}-{2}_{3}-{4}", dt.Day, dt.Month, dt.Year, dt.Hour, dt.Minute);
        }

        private void SaveTrackDialog()
        {
            using (SaveFileDialog sDialog = new SaveFileDialog())
            {
                sDialog.DefaultExt = "kml";
                sDialog.Filter = "Google KML (*.kml)|*.kml|*.gpx|CSV (*.csv)|*.csv";
                sDialog.FileName = GetTimeDateFileName();

                if (sDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (sDialog.FilterIndex == 1)
                        SaveTrackXML(sDialog.FileName);
                    //else if (sDialog.FilterIndex == 2)
                        //SaveTrackGPX(sDialog.FileName);                        
                    else if (sDialog.FilterIndex == 3)
                        SaveTrackCSV(sDialog.FileName);
                }
            }
        }

        #endregion

        #region Handlers

        #region Controls

        private void MainForm_Load(object sender, EventArgs e)
        {
            ts = new ThreadStart(port.Start);
            portThread = new Thread(ts);
            portThread.Start();            
        }

        private void waypointsLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (waypointsLbx.SelectedItem != null)
            {
                GeoPoint2D pnt = (GeoPoint2D)waypointsLbx.SelectedItem;

                if (pnt.PType == 2)
                {
                    latDeg = (int)Math.Floor(pnt.Latitude);
                    latMin = (int)Math.Floor((pnt.Latitude - latDeg) * 60.0);
                    latSec = (pnt.Latitude - latDeg) * 3600 - latMin * 60.0;

                    lonDeg = (int)Math.Floor(pnt.Longitude);
                    lonMin = (int)Math.Floor((pnt.Longitude - lonDeg) * 60.0);
                    lonSec = (pnt.Longitude - lonDeg) * 3600 - lonMin * 60.0;

                    latGroup.Visible = true;
                    lonGroup.Visible = true;
                    changePntBtn.Visible = true;
                }
                else
                {
                    latGroup.Visible = false;
                    lonGroup.Visible = false;
                    changePntBtn.Visible = false;
                }
            }
            else
            {
                latGroup.Visible = false;
                lonGroup.Visible = false;
                changePntBtn.Visible = false;
            }
        }

        private void changePntBtn_Click(object sender, EventArgs e)
        {
            if (waypointsLbx.SelectedItem != null)
            {
                GeoPoint2D pnt = new GeoPoint2D(latDeg + latMin / 60.0 + latSec / 3600.0, 
                lonDeg + lonMin / 60.0 + lonSec / 3600.0, 2);
                waypointsLbx.Items[waypointsLbx.SelectedIndex] = pnt;
            }
        }

        private void downloadTrackBtn_Click(object sender, EventArgs e)
        {
            track.Clear();
            InvokeSetButtonsVisibleState(false);
            progressBar.Maximum = trackCount;
            progressBar.Style = ProgressBarStyle.Continuous;
            port.Send(port.QueryTrackItem(0));
        }

        private void applySettingsBtn_Click(object sender, EventArgs e)
        {
            port.Send(string.Format("{0}..........................{1}...........................{2}.........................", port.QuerySalinitySet(salinity), port.QueryMirroredSet(isFlipScreen), port.QueryFlashWrite()));
            isSavingSettings = true;
            InvokeSetButtonsVisibleState(false);
        }


        private void syncWaypointsBtn_Click(object sender, EventArgs e)
        {
            if (waypointsLbx.Items.Count == 0)
            {
                if (MessageBox.Show(LocRM.GetString("mfText_ClearWaypointsAndContinueStr"),
                    LocRM.GetString("mfText_Question"),
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    isClearingWaypoints = true;
                    InvokeSetButtonsVisibleState(false);
                    port.Send(port.QueryWaypointsClear());
                }
            }
            else
            {
                isClearingWaypoints = true;
                InvokeSetButtonsVisibleState(false);
                port.Send(port.QueryWaypointsClear());                
            }
        }

        private void weblinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.unavlab.com");
        }

        private void deleteWaypoint_Click(object sender, EventArgs e)
        {
            if (waypointsLbx.SelectedItem != null)
            {
                waypointsLbx.Items.RemoveAt(waypointsLbx.SelectedIndex);
                waypointsLbx_SelectedIndexChanged(sender, e);
            }
        }

        private void deleteAllPoints_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(LocRM.GetString("mfText_ClearAllPointsStr"), LocRM.GetString("mfText_QuestionStr"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                waypointsLbx.Items.Clear();
                waypointsLbx_SelectedIndexChanged(sender, e);
            }
        }

        private void addWaypoint_Click(object sender, EventArgs e)
        {
            if (waypointsLbx.Items.Count < 20)
            {
                waypointsLbx.Items.Add(new GeoPoint2D(0, 0, 2));
                waypointsLbx.SelectedIndex = waypointsLbx.Items.Count - 1;
            }
        }

        private void copyToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(serialNumberLbl.Text);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(redNodeSerialLbl.Text);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show(string.Format("{0} RedNAVHost?", LocRM.GetString("mfText_CloseAppQuestionStr")),
                LocRM.GetString("mfText_QuestionStr"), 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                port.Stop();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                port.Dispose();
            }
        }

        private void salinitySearchLnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (SalinityDialog sDialog = new SalinityDialog())
            {
                sDialog.Text                = LocRM.GetString("mfText_SalinityAdjustStr");
                sDialog.LatCaption          = LocRM.GetString("mfText_LatitudeStr");
                sDialog.LonCaption          = LocRM.GetString("mfText_LongitudeStr");
                sDialog.SearchBtnCaption    = LocRM.GetString("mfText_FindStr");
                sDialog.SalinityCaption     = LocRM.GetString("mfText_SalinityPPMStr");
                sDialog.SalinityDefCaption  = LocRM.GetString("mfText_NoDataStr");
                sDialog.ErrorConnetingDBMsg = LocRM.GetString("mfText_DataBaseErrorStr");
                sDialog.NearestPntMsg       = LocRM.GetString("mfText_NearestStr");

                if (sDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    salinity = sDialog.Salinity;
                }
            }
        }

        #endregion

        #region port

        private void port_ConnectionSearchingStarted(object sender, EventArgs e)
        {
            InvokeSetText(this, string.Format("RedNAVHost - {0}", LocRM.GetString("mfText_SearchingForDeviceStr")));    // mfText_SearchingForDeviceStr
            InvokeSetText(statusStrip, systemStateLbl, LocRM.GetString("mfText_SearchingForDeviceStr"));                // mfText_SearchingForDeviceStr
            InvokeSetText(deviceVersionLabel, string.Format("{0}: ", LocRM.GetString("mfText_DeviceVersionStr")));      // mfText_DeviceVersionStr
            InvokeSetText(serialNumberLbl, "- - -");
            InvokeSetProgressType(statusStrip, progressBar, ProgressBarStyle.Marquee);

            InvokeSetEnabledState(applySettingsBtn, false);
            InvokeSetEnabledState(syncWaypointsBtn, false);
            InvokeSetEnabledState(downloadTrackBtn, false);

            salinity = 0.0;
            trackCount = 0;
            waypointsCount = 0;

            InvokeSetText(trackCountLbl, LocRM.GetString("mfText_NoTrackDataAvailible"));                               // mfText_NoTrackDataAvailible
            InvokeListBoxClear(waypointsLbx);
            this.Invoke((MethodInvoker)delegate { waypointsLbx_SelectedIndexChanged(new object(), new EventArgs()); });

            isClearingWaypoints = false;
            isSavingFlash = false;
            isSavingSettings = false;
        }

        private void port_ConnectionEstablished(object sender, EventArgs e)
        {
            InvokeSetText(this, string.Format("RedNAVHost - {0}", LocRM.GetString("mfText_CennectingStr")));         // mfText_CennectingStr
            InvokeSetText(statusStrip, systemStateLbl, LocRM.GetString("mfText_CennectingStr"));                     // mfText_CennectingStr
            InvokeSetProgressType(statusStrip, progressBar, ProgressBarStyle.Marquee);
        }

        private void port_PortReady(object sender, EventArgs e)
        {
            InvokeSetText(this, string.Format("RedNAVHost - RDNV-{0}", Get16Hash(port.SerialNumber)));
            InvokeSetText(statusStrip, systemStateLbl, LocRM.GetString("mfText_ConnectedStr"));                      // mfText_ConnectedStr

            InvokeSetText(deviceVersionLabel, string.Format("{0}: {1} v{2}, {3}: {4} v{5}",
                LocRM.GetString("mfText_DeviceVersionStr"),
                port.SystemMoniker, 
                port.SystemVersion, 
                LocRM.GetString("mfText_CoreStr"),
                port.CoreMoniker, 
                port.CoreVersion));

            InvokeSetText(serialNumberLbl, port.SerialNumber);
            InvokeSetProgressType(statusStrip, progressBar, ProgressBarStyle.Continuous);
            InvokeSetProgress(statusStrip, progressBar, 0);

            InvokeSetButtonsVisibleState(true);

            port.Send(string.Format("{0}............{1}............{2}..............{3}..............{4}",
                port.QuerySalinityGet(),
                port.QueryMirroredGet(),
                port.QueryTrackSize(),
                port.QueryWaypointsCount(),
                port.QueryRedNodeDevInfo()));
        }

        private void port_ACKReceived(object sender, EventArgs e)
        {
            if (isClearingWaypoints)
            {
                isClearingWaypoints = false;
                StringBuilder sb = new StringBuilder();

                if (waypointsLbx.Items.Count > 0)
                {
                    foreach (GeoPoint2D item in waypointsLbx.Items)
                    {
                        if (item.PType != 0)
                        {
                            sb.Append(port.QueryWaypointSet(item.Latitude, item.Longitude));
                            sb.Append("........................................");
                        }
                    }

                    sb.Append(port.QueryFlashWrite());

                    isSavingFlash = true;

                    InvokeListBoxClear(waypointsLbx);
                    this.Invoke((MethodInvoker)delegate { waypointsLbx_SelectedIndexChanged(new object(), new EventArgs()); });
                    port.Send(sb.ToString());
                }
                else
                {
                    InvokeSetButtonsVisibleState(true);
                }
            }
            else if (isSavingFlash)
            {
                isSavingFlash = false;
                waypointsCount = 0;
                port.Send(port.QueryWaypointsCount());
            }
            else if (isSavingSettings)
            {
                InvokeSetButtonsVisibleState(true);
            }
        }

        private void port_LocalDataReceived(object sender, LocalDataEventArgs e)
        {
            switch (e.LocalDataID)
            {
                case LocalDataIDs.LOC_DATA_BAT_CHARGE:
                {
                    break;
                }
                case LocalDataIDs.LOC_DATA_PRESSURE_RATING:
                {
                    break;
                }
                case LocalDataIDs.LOC_DATA_SALINITY:
                {
                    salinity = e.Value;                    
                    break;
                }
                case LocalDataIDs.LOC_DATA_TRACK_SIZE:
                {
                    trackCount = (int)e.Value;
                    if (trackCount > 0)
                    {
                        InvokeSetText(trackCountLbl, string.Format("{0} {1} {2}",
                            LocRM.GetString("mfText_DeviceTrackContainsStr"),
                            trackCount,
                            LocRM.GetString("mfText_pointsStr")));
                        InvokeSetEnabledState(downloadTrackBtn, true);
                    }
                    else
                    {
                        InvokeSetText(trackCountLbl, LocRM.GetString("mfText_DeviceTrackIsEmptyStr")); // mfText_DeviceTrackIsEmptyStr
                        InvokeSetEnabledState(downloadTrackBtn, false);
                    }
                    break;
                }
                case LocalDataIDs.LOC_DATA_WAYPOINTS_NUMBER:
                {
                    waypoints.Clear();
                    StringBuilder sb = new StringBuilder();
                    waypointsCount = (int)e.Value;

                    InvokeListBoxClear(waypointsLbx);
                    
                    for (int i = 0; i < waypointsCount; i++)
                    {
                        sb.Append(port.QueryWaypointGet(i));
                        sb.Append("........................................");
                    }

                    port.Send(sb.ToString());

                    break;
                }
            }
        }       

        private void port_TrackItemReceived(object sender, TrackItemEventArgs e)
        {
            if ((e.Latitude != 0.0) && (e.Longitude != 0.0))
            {
                track.Add(new TrackItem(e.TimeStamp, e.Latitude, e.Longitude, e.Depth));
            }

            if (e.ItemIdx != trackCount - 1)
            {
                port.Send(port.QueryTrackItem(e.ItemIdx + 1));
                InvokeSetProgress(statusStrip, progressBar, e.ItemIdx);
            }
            else
            {
                InvokeSetProgress(statusStrip, progressBar, 0);
                InvokeSetButtonsVisibleState(true);
                this.Invoke((MethodInvoker)delegate { SaveTrackDialog(); });
            }
        }

        private void port_WaypointReceived(object sender, WaypointEventArgs e)
        {

            GeoPoint2D pnt = new GeoPoint2D(e.Latitude, e.Longitude, e.WaypointType);

            if (!((e.Latitude == 0.0) && (e.Longitude == 0.0)))
            {
                InvokeAddListBoxItem(waypointsLbx, pnt);
                waypoints.Add(pnt);
            }
        
            if (e.WaypointIdx == waypointsCount - 1)
            {
                 InvokeSetEnabledState(syncWaypointsBtn, true);
                 InvokeSetButtonsVisibleState(true);
            }            
        }

        private void port_RNDeviceInfoUpdated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(port.rn_CoreMoniker))
            {
                InvokeSetText(redNodeInfoLbl, LocRM.GetString("mfText_NavigationalReceiverStr"));//"Навигационный приемник: нет данных");
                InvokeSetText(redNodeSerialLbl, LocRM.GetString("mfText_NoDataStr"));
            }
            else
            {
                InvokeSetText(redNodeInfoLbl, string.Format("{0}: {1} v{2}, {3}: {4} v{5}", 
                    LocRM.GetString("mfText_NavigationalReceiverStr"),
                    port.rn_SystemMoniker, 
                    port.rn_SystemVersion, 
                    LocRM.GetString("mfText_CoreStr"),
                    port.rn_CoreMoniker, 
                    port.rn_CoreVersion));

                InvokeSetText(redNodeSerialLbl, port.rn_SerialNumber);
            }
        }

        private void port_FieldValueReceived(object sender, FieldValueEventArgs e)
        {
            if (e.FieldID == FieldIDs.FLD_IS_MIRROR_SCREEN)
            {
                if (e.FieldValue == 0)
                    isFlipScreen = false;
                else
                    isFlipScreen = true;
            }

            InvokeSetEnabledState(applySettingsBtn, true);
        }

        #endregion                                                     
                                        
        #endregion                
    }
}
