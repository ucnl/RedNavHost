namespace RedNAVHost
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.systemStateLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.wpPanel = new System.Windows.Forms.Panel();
            this.changePntBtn = new System.Windows.Forms.Button();
            this.lonGroup = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lonSecEdit = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.lonMinEdit = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.lonDegEdit = new System.Windows.Forms.NumericUpDown();
            this.latGroup = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.latSecEdit = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.latMinEdit = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.latDegEdit = new System.Windows.Forms.NumericUpDown();
            this.syncWaypointsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.waypointsLbx = new System.Windows.Forms.ListBox();
            this.waypointsContexMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addWaypoint = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteWaypoint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteAllPoints = new System.Windows.Forms.ToolStripMenuItem();
            this.weblinkLbl = new System.Windows.Forms.LinkLabel();
            this.deviceVersionLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.serialNumberLbl = new System.Windows.Forms.Label();
            this.serialNumberContexMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsGroup = new System.Windows.Forms.GroupBox();
            this.isFlipScreenChb = new System.Windows.Forms.CheckBox();
            this.salinitySearchLnk = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.salinityEdit = new System.Windows.Forms.NumericUpDown();
            this.applySettingsBtn = new System.Windows.Forms.Button();
            this.trackGroup = new System.Windows.Forms.GroupBox();
            this.trackCountLbl = new System.Windows.Forms.Label();
            this.downloadTrackBtn = new System.Windows.Forms.Button();
            this.redNodeInfoLbl = new System.Windows.Forms.Label();
            this.redNodeSerialLbl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.rnSerialNumberContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.wpPanel.SuspendLayout();
            this.lonGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lonSecEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lonMinEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lonDegEdit)).BeginInit();
            this.latGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.latSecEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.latMinEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.latDegEdit)).BeginInit();
            this.waypointsContexMenu.SuspendLayout();
            this.serialNumberContexMenu.SuspendLayout();
            this.settingsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salinityEdit)).BeginInit();
            this.trackGroup.SuspendLayout();
            this.rnSerialNumberContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.systemStateLbl,
            this.progressBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 781);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(652, 30);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(109, 25);
            this.toolStripStatusLabel1.Text = "Состояние:";
            // 
            // systemStateLbl
            // 
            this.systemStateLbl.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.systemStateLbl.Name = "systemStateLbl";
            this.systemStateLbl.Size = new System.Drawing.Size(129, 25);
            this.systemStateLbl.Text = "ОТКЛЮЧЕНО";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(200, 24);
            this.progressBar.Step = 1;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // wpPanel
            // 
            this.wpPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wpPanel.Controls.Add(this.changePntBtn);
            this.wpPanel.Controls.Add(this.lonGroup);
            this.wpPanel.Controls.Add(this.latGroup);
            this.wpPanel.Controls.Add(this.syncWaypointsBtn);
            this.wpPanel.Controls.Add(this.label1);
            this.wpPanel.Controls.Add(this.waypointsLbx);
            this.wpPanel.Controls.Add(this.weblinkLbl);
            this.wpPanel.Location = new System.Drawing.Point(12, 382);
            this.wpPanel.Name = "wpPanel";
            this.wpPanel.Size = new System.Drawing.Size(628, 368);
            this.wpPanel.TabIndex = 2;
            // 
            // changePntBtn
            // 
            this.changePntBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePntBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changePntBtn.Location = new System.Drawing.Point(442, 177);
            this.changePntBtn.Name = "changePntBtn";
            this.changePntBtn.Size = new System.Drawing.Size(171, 44);
            this.changePntBtn.TabIndex = 31;
            this.changePntBtn.Text = "Изменить точку";
            this.changePntBtn.UseVisualStyleBackColor = true;
            this.changePntBtn.Visible = false;
            this.changePntBtn.Click += new System.EventHandler(this.changePntBtn_Click);
            // 
            // lonGroup
            // 
            this.lonGroup.Controls.Add(this.label6);
            this.lonGroup.Controls.Add(this.lonSecEdit);
            this.lonGroup.Controls.Add(this.label7);
            this.lonGroup.Controls.Add(this.lonMinEdit);
            this.lonGroup.Controls.Add(this.label8);
            this.lonGroup.Controls.Add(this.lonDegEdit);
            this.lonGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lonGroup.Location = new System.Drawing.Point(300, 92);
            this.lonGroup.Name = "lonGroup";
            this.lonGroup.Size = new System.Drawing.Size(313, 79);
            this.lonGroup.TabIndex = 27;
            this.lonGroup.TabStop = false;
            this.lonGroup.Text = "Долгота";
            this.lonGroup.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(288, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "\'\'";
            // 
            // lonSecEdit
            // 
            this.lonSecEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lonSecEdit.DecimalPlaces = 3;
            this.lonSecEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lonSecEdit.Location = new System.Drawing.Point(190, 33);
            this.lonSecEdit.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.lonSecEdit.Name = "lonSecEdit";
            this.lonSecEdit.Size = new System.Drawing.Size(92, 27);
            this.lonSecEdit.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(160, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "\'";
            // 
            // lonMinEdit
            // 
            this.lonMinEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lonMinEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lonMinEdit.Location = new System.Drawing.Point(101, 31);
            this.lonMinEdit.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.lonMinEdit.Name = "lonMinEdit";
            this.lonMinEdit.Size = new System.Drawing.Size(53, 27);
            this.lonMinEdit.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(74, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "°";
            // 
            // lonDegEdit
            // 
            this.lonDegEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lonDegEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lonDegEdit.Location = new System.Drawing.Point(15, 31);
            this.lonDegEdit.Maximum = new decimal(new int[] {
            179,
            0,
            0,
            0});
            this.lonDegEdit.Minimum = new decimal(new int[] {
            179,
            0,
            0,
            -2147483648});
            this.lonDegEdit.Name = "lonDegEdit";
            this.lonDegEdit.Size = new System.Drawing.Size(53, 27);
            this.lonDegEdit.TabIndex = 21;
            this.lonDegEdit.Value = new decimal(new int[] {
            48,
            0,
            0,
            0});
            // 
            // latGroup
            // 
            this.latGroup.Controls.Add(this.label5);
            this.latGroup.Controls.Add(this.latSecEdit);
            this.latGroup.Controls.Add(this.label4);
            this.latGroup.Controls.Add(this.latMinEdit);
            this.latGroup.Controls.Add(this.label3);
            this.latGroup.Controls.Add(this.latDegEdit);
            this.latGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.latGroup.Location = new System.Drawing.Point(300, 13);
            this.latGroup.Name = "latGroup";
            this.latGroup.Size = new System.Drawing.Size(313, 73);
            this.latGroup.TabIndex = 4;
            this.latGroup.TabStop = false;
            this.latGroup.Text = "Широта";
            this.latGroup.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(288, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "\'\'";
            // 
            // latSecEdit
            // 
            this.latSecEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.latSecEdit.DecimalPlaces = 3;
            this.latSecEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.latSecEdit.Location = new System.Drawing.Point(190, 31);
            this.latSecEdit.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.latSecEdit.Name = "latSecEdit";
            this.latSecEdit.Size = new System.Drawing.Size(92, 27);
            this.latSecEdit.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(160, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "\'";
            // 
            // latMinEdit
            // 
            this.latMinEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.latMinEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.latMinEdit.Location = new System.Drawing.Point(101, 31);
            this.latMinEdit.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.latMinEdit.Name = "latMinEdit";
            this.latMinEdit.Size = new System.Drawing.Size(53, 27);
            this.latMinEdit.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(74, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "°";
            // 
            // latDegEdit
            // 
            this.latDegEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.latDegEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.latDegEdit.Location = new System.Drawing.Point(15, 31);
            this.latDegEdit.Maximum = new decimal(new int[] {
            89,
            0,
            0,
            0});
            this.latDegEdit.Minimum = new decimal(new int[] {
            89,
            0,
            0,
            -2147483648});
            this.latDegEdit.Name = "latDegEdit";
            this.latDegEdit.Size = new System.Drawing.Size(53, 27);
            this.latDegEdit.TabIndex = 20;
            this.latDegEdit.Value = new decimal(new int[] {
            44,
            0,
            0,
            0});
            // 
            // syncWaypointsBtn
            // 
            this.syncWaypointsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.syncWaypointsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.syncWaypointsBtn.Location = new System.Drawing.Point(379, 274);
            this.syncWaypointsBtn.Name = "syncWaypointsBtn";
            this.syncWaypointsBtn.Size = new System.Drawing.Size(234, 44);
            this.syncWaypointsBtn.TabIndex = 3;
            this.syncWaypointsBtn.Text = "Загрузить в устройство";
            this.syncWaypointsBtn.UseVisualStyleBackColor = true;
            this.syncWaypointsBtn.Click += new System.EventHandler(this.syncWaypointsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Путевые точки";
            // 
            // waypointsLbx
            // 
            this.waypointsLbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.waypointsLbx.ContextMenuStrip = this.waypointsContexMenu;
            this.waypointsLbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.waypointsLbx.FormattingEnabled = true;
            this.waypointsLbx.HorizontalScrollbar = true;
            this.waypointsLbx.ItemHeight = 20;
            this.waypointsLbx.Location = new System.Drawing.Point(7, 36);
            this.waypointsLbx.Name = "waypointsLbx";
            this.waypointsLbx.Size = new System.Drawing.Size(276, 282);
            this.waypointsLbx.TabIndex = 0;
            this.waypointsLbx.SelectedIndexChanged += new System.EventHandler(this.waypointsLbx_SelectedIndexChanged);
            // 
            // waypointsContexMenu
            // 
            this.waypointsContexMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addWaypoint,
            this.deleteWaypoint,
            this.toolStripSeparator1,
            this.deleteAllPoints});
            this.waypointsContexMenu.Name = "waypointsContexMenu";
            this.waypointsContexMenu.Size = new System.Drawing.Size(281, 82);
            // 
            // addWaypoint
            // 
            this.addWaypoint.Name = "addWaypoint";
            this.addWaypoint.Size = new System.Drawing.Size(280, 24);
            this.addWaypoint.Text = "Добавить маршрутную точку";
            this.addWaypoint.Click += new System.EventHandler(this.addWaypoint_Click);
            // 
            // deleteWaypoint
            // 
            this.deleteWaypoint.Name = "deleteWaypoint";
            this.deleteWaypoint.Size = new System.Drawing.Size(280, 24);
            this.deleteWaypoint.Text = "Удалиить выделенную точку";
            this.deleteWaypoint.Click += new System.EventHandler(this.deleteWaypoint_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(277, 6);
            // 
            // deleteAllPoints
            // 
            this.deleteAllPoints.Name = "deleteAllPoints";
            this.deleteAllPoints.Size = new System.Drawing.Size(280, 24);
            this.deleteAllPoints.Text = "Удалить все точки";
            this.deleteAllPoints.Click += new System.EventHandler(this.deleteAllPoints_Click);
            // 
            // weblinkLbl
            // 
            this.weblinkLbl.AutoSize = true;
            this.weblinkLbl.Location = new System.Drawing.Point(261, 339);
            this.weblinkLbl.Name = "weblinkLbl";
            this.weblinkLbl.Size = new System.Drawing.Size(119, 17);
            this.weblinkLbl.TabIndex = 3;
            this.weblinkLbl.TabStop = true;
            this.weblinkLbl.Text = "www.unavlab.com";
            this.weblinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.weblinkLbl_LinkClicked);
            // 
            // deviceVersionLabel
            // 
            this.deviceVersionLabel.AutoSize = true;
            this.deviceVersionLabel.Location = new System.Drawing.Point(16, 26);
            this.deviceVersionLabel.Name = "deviceVersionLabel";
            this.deviceVersionLabel.Size = new System.Drawing.Size(165, 17);
            this.deviceVersionLabel.TabIndex = 4;
            this.deviceVersionLabel.Text = "Версия устройства: - - -";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Серийный номер:";
            // 
            // serialNumberLbl
            // 
            this.serialNumberLbl.AutoSize = true;
            this.serialNumberLbl.ContextMenuStrip = this.serialNumberContexMenu;
            this.serialNumberLbl.Location = new System.Drawing.Point(146, 52);
            this.serialNumberLbl.Name = "serialNumberLbl";
            this.serialNumberLbl.Size = new System.Drawing.Size(31, 17);
            this.serialNumberLbl.TabIndex = 6;
            this.serialNumberLbl.Text = "- - -";
            // 
            // serialNumberContexMenu
            // 
            this.serialNumberContexMenu.AllowMerge = false;
            this.serialNumberContexMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToClipboardToolStripMenuItem});
            this.serialNumberContexMenu.Name = "serialNumberContexMenu";
            this.serialNumberContexMenu.Size = new System.Drawing.Size(199, 28);
            // 
            // copyToClipboardToolStripMenuItem
            // 
            this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
            this.copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.copyToClipboardToolStripMenuItem.Text = "Copy to clipboard";
            this.copyToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyToClipboardToolStripMenuItem_Click);
            // 
            // settingsGroup
            // 
            this.settingsGroup.Controls.Add(this.isFlipScreenChb);
            this.settingsGroup.Controls.Add(this.salinitySearchLnk);
            this.settingsGroup.Controls.Add(this.label10);
            this.settingsGroup.Controls.Add(this.salinityEdit);
            this.settingsGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsGroup.Location = new System.Drawing.Point(12, 156);
            this.settingsGroup.Name = "settingsGroup";
            this.settingsGroup.Size = new System.Drawing.Size(420, 108);
            this.settingsGroup.TabIndex = 7;
            this.settingsGroup.TabStop = false;
            this.settingsGroup.Text = "Настройки";
            // 
            // isFlipScreenChb
            // 
            this.isFlipScreenChb.AutoSize = true;
            this.isFlipScreenChb.Location = new System.Drawing.Point(10, 77);
            this.isFlipScreenChb.Name = "isFlipScreenChb";
            this.isFlipScreenChb.Size = new System.Drawing.Size(188, 24);
            this.isFlipScreenChb.TabIndex = 29;
            this.isFlipScreenChb.Text = "Переворот экрана";
            this.isFlipScreenChb.UseVisualStyleBackColor = true;
            // 
            // salinitySearchLnk
            // 
            this.salinitySearchLnk.AutoSize = true;
            this.salinitySearchLnk.Location = new System.Drawing.Point(259, 38);
            this.salinitySearchLnk.Name = "salinitySearchLnk";
            this.salinitySearchLnk.Size = new System.Drawing.Size(121, 20);
            this.salinitySearchLnk.TabIndex = 8;
            this.salinitySearchLnk.TabStop = true;
            this.salinitySearchLnk.Text = "Найти в базе";
            this.salinitySearchLnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.salinitySearchLnk_LinkClicked);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(6, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "Соленость, PPM";
            // 
            // salinityEdit
            // 
            this.salinityEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salinityEdit.DecimalPlaces = 1;
            this.salinityEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salinityEdit.Location = new System.Drawing.Point(167, 36);
            this.salinityEdit.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.salinityEdit.Name = "salinityEdit";
            this.salinityEdit.Size = new System.Drawing.Size(69, 27);
            this.salinityEdit.TabIndex = 27;
            // 
            // applySettingsBtn
            // 
            this.applySettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applySettingsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.applySettingsBtn.Location = new System.Drawing.Point(454, 220);
            this.applySettingsBtn.Name = "applySettingsBtn";
            this.applySettingsBtn.Size = new System.Drawing.Size(171, 44);
            this.applySettingsBtn.TabIndex = 29;
            this.applySettingsBtn.Text = "Сохранить";
            this.applySettingsBtn.UseVisualStyleBackColor = true;
            this.applySettingsBtn.Click += new System.EventHandler(this.applySettingsBtn_Click);
            // 
            // trackGroup
            // 
            this.trackGroup.Controls.Add(this.trackCountLbl);
            this.trackGroup.Controls.Add(this.downloadTrackBtn);
            this.trackGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trackGroup.Location = new System.Drawing.Point(12, 270);
            this.trackGroup.Name = "trackGroup";
            this.trackGroup.Size = new System.Drawing.Size(628, 95);
            this.trackGroup.TabIndex = 30;
            this.trackGroup.TabStop = false;
            this.trackGroup.Text = "Трек";
            // 
            // trackCountLbl
            // 
            this.trackCountLbl.AutoSize = true;
            this.trackCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trackCountLbl.Location = new System.Drawing.Point(19, 47);
            this.trackCountLbl.Name = "trackCountLbl";
            this.trackCountLbl.Size = new System.Drawing.Size(191, 20);
            this.trackCountLbl.TabIndex = 31;
            this.trackCountLbl.Text = "Трек устройства пуст";
            // 
            // downloadTrackBtn
            // 
            this.downloadTrackBtn.Enabled = false;
            this.downloadTrackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadTrackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downloadTrackBtn.Location = new System.Drawing.Point(442, 35);
            this.downloadTrackBtn.Name = "downloadTrackBtn";
            this.downloadTrackBtn.Size = new System.Drawing.Size(171, 44);
            this.downloadTrackBtn.TabIndex = 30;
            this.downloadTrackBtn.Text = "Выгрузить";
            this.downloadTrackBtn.UseVisualStyleBackColor = true;
            this.downloadTrackBtn.Click += new System.EventHandler(this.downloadTrackBtn_Click);
            // 
            // redNodeInfoLbl
            // 
            this.redNodeInfoLbl.AutoSize = true;
            this.redNodeInfoLbl.Location = new System.Drawing.Point(16, 95);
            this.redNodeInfoLbl.Name = "redNodeInfoLbl";
            this.redNodeInfoLbl.Size = new System.Drawing.Size(211, 17);
            this.redNodeInfoLbl.TabIndex = 31;
            this.redNodeInfoLbl.Text = "Навигационный приемник: - - -";
            // 
            // redNodeSerialLbl
            // 
            this.redNodeSerialLbl.AutoSize = true;
            this.redNodeSerialLbl.ContextMenuStrip = this.rnSerialNumberContextMenu;
            this.redNodeSerialLbl.Location = new System.Drawing.Point(146, 121);
            this.redNodeSerialLbl.Name = "redNodeSerialLbl";
            this.redNodeSerialLbl.Size = new System.Drawing.Size(31, 17);
            this.redNodeSerialLbl.TabIndex = 33;
            this.redNodeSerialLbl.Text = "- - -";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 17);
            this.label12.TabIndex = 32;
            this.label12.Text = "Серийный номер:";
            // 
            // rnSerialNumberContextMenu
            // 
            this.rnSerialNumberContextMenu.AllowMerge = false;
            this.rnSerialNumberContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.rnSerialNumberContextMenu.Name = "serialNumberContexMenu";
            this.rnSerialNumberContextMenu.Size = new System.Drawing.Size(199, 50);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(198, 24);
            this.toolStripMenuItem1.Text = "Copy to clipboard";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(652, 811);
            this.Controls.Add(this.redNodeSerialLbl);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.redNodeInfoLbl);
            this.Controls.Add(this.trackGroup);
            this.Controls.Add(this.applySettingsBtn);
            this.Controls.Add(this.settingsGroup);
            this.Controls.Add(this.serialNumberLbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.deviceVersionLabel);
            this.Controls.Add(this.wpPanel);
            this.Controls.Add(this.statusStrip);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "RedNAV Host";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.wpPanel.ResumeLayout(false);
            this.wpPanel.PerformLayout();
            this.lonGroup.ResumeLayout(false);
            this.lonGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lonSecEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lonMinEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lonDegEdit)).EndInit();
            this.latGroup.ResumeLayout(false);
            this.latGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.latSecEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.latMinEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.latDegEdit)).EndInit();
            this.waypointsContexMenu.ResumeLayout(false);
            this.serialNumberContexMenu.ResumeLayout(false);
            this.settingsGroup.ResumeLayout(false);
            this.settingsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salinityEdit)).EndInit();
            this.trackGroup.ResumeLayout(false);
            this.trackGroup.PerformLayout();
            this.rnSerialNumberContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel systemStateLbl;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.Panel wpPanel;
        private System.Windows.Forms.GroupBox lonGroup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown lonSecEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown lonMinEdit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown lonDegEdit;
        private System.Windows.Forms.GroupBox latGroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown latSecEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown latMinEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown latDegEdit;
        private System.Windows.Forms.Button syncWaypointsBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox waypointsLbx;
        private System.Windows.Forms.LinkLabel weblinkLbl;
        private System.Windows.Forms.Label deviceVersionLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label serialNumberLbl;
        private System.Windows.Forms.GroupBox settingsGroup;
        private System.Windows.Forms.CheckBox isFlipScreenChb;
        private System.Windows.Forms.LinkLabel salinitySearchLnk;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown salinityEdit;
        private System.Windows.Forms.Button applySettingsBtn;
        private System.Windows.Forms.GroupBox trackGroup;
        private System.Windows.Forms.Label trackCountLbl;
        private System.Windows.Forms.Button downloadTrackBtn;
        private System.Windows.Forms.Button changePntBtn;
        private System.Windows.Forms.ContextMenuStrip waypointsContexMenu;
        private System.Windows.Forms.ToolStripMenuItem addWaypoint;
        private System.Windows.Forms.ToolStripMenuItem deleteWaypoint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteAllPoints;
        private System.Windows.Forms.ContextMenuStrip serialNumberContexMenu;
        private System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem;
        private System.Windows.Forms.Label redNodeInfoLbl;
        private System.Windows.Forms.Label redNodeSerialLbl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ContextMenuStrip rnSerialNumberContextMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

