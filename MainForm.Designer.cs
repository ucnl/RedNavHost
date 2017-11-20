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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.systemStateLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
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
            this.deviceVersionLblTitle = new System.Windows.Forms.Label();
            this.serialNumberLblTitle = new System.Windows.Forms.Label();
            this.serialNumberLbl = new System.Windows.Forms.Label();
            this.serialNumberContexMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.isFlipScreenChb = new System.Windows.Forms.CheckBox();
            this.salinitySearchLnk = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.salinityEdit = new System.Windows.Forms.NumericUpDown();
            this.applySettingsBtn = new System.Windows.Forms.Button();
            this.trackGroup = new System.Windows.Forms.GroupBox();
            this.trackCountLbl = new System.Windows.Forms.Label();
            this.downloadTrackBtn = new System.Windows.Forms.Button();
            this.redNodeInfoLblTitle = new System.Windows.Forms.Label();
            this.redNodeSerialLbl = new System.Windows.Forms.Label();
            this.rnSerialNumberContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.redNodeSerialNumberLblTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.deviceInfoGroup = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.redNodeInfoLbl = new System.Windows.Forms.Label();
            this.deviceVersionLbl = new System.Windows.Forms.Label();
            this.settingsGroup = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.routeGroup = new System.Windows.Forms.GroupBox();
            this.statusStrip.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.salinityEdit)).BeginInit();
            this.trackGroup.SuspendLayout();
            this.rnSerialNumberContextMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.deviceInfoGroup.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.settingsGroup.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.routeGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.systemStateLbl,
            this.progressBar});
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.Name = "statusStrip";
            // 
            // toolStripStatusLabel1
            // 
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            // 
            // systemStateLbl
            // 
            resources.ApplyResources(this.systemStateLbl, "systemStateLbl");
            this.systemStateLbl.Name = "systemStateLbl";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            resources.ApplyResources(this.progressBar, "progressBar");
            this.progressBar.Step = 1;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // changePntBtn
            // 
            resources.ApplyResources(this.changePntBtn, "changePntBtn");
            this.changePntBtn.Name = "changePntBtn";
            this.changePntBtn.UseVisualStyleBackColor = true;
            this.changePntBtn.Click += new System.EventHandler(this.changePntBtn_Click);
            // 
            // lonGroup
            // 
            resources.ApplyResources(this.lonGroup, "lonGroup");
            this.lonGroup.Controls.Add(this.label6);
            this.lonGroup.Controls.Add(this.lonSecEdit);
            this.lonGroup.Controls.Add(this.label7);
            this.lonGroup.Controls.Add(this.lonMinEdit);
            this.lonGroup.Controls.Add(this.label8);
            this.lonGroup.Controls.Add(this.lonDegEdit);
            this.lonGroup.Name = "lonGroup";
            this.lonGroup.TabStop = false;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // lonSecEdit
            // 
            this.lonSecEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lonSecEdit.DecimalPlaces = 3;
            resources.ApplyResources(this.lonSecEdit, "lonSecEdit");
            this.lonSecEdit.Maximum = new decimal(new int[] {
            2013265919,
            -720531959,
            -1096570888,
            1769472});
            this.lonSecEdit.Name = "lonSecEdit";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // lonMinEdit
            // 
            this.lonMinEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.lonMinEdit, "lonMinEdit");
            this.lonMinEdit.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.lonMinEdit.Name = "lonMinEdit";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // lonDegEdit
            // 
            this.lonDegEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.lonDegEdit, "lonDegEdit");
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
            this.lonDegEdit.Value = new decimal(new int[] {
            48,
            0,
            0,
            0});
            // 
            // latGroup
            // 
            resources.ApplyResources(this.latGroup, "latGroup");
            this.latGroup.Controls.Add(this.label5);
            this.latGroup.Controls.Add(this.latSecEdit);
            this.latGroup.Controls.Add(this.label4);
            this.latGroup.Controls.Add(this.latMinEdit);
            this.latGroup.Controls.Add(this.label3);
            this.latGroup.Controls.Add(this.latDegEdit);
            this.latGroup.Name = "latGroup";
            this.latGroup.TabStop = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // latSecEdit
            // 
            this.latSecEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.latSecEdit.DecimalPlaces = 3;
            resources.ApplyResources(this.latSecEdit, "latSecEdit");
            this.latSecEdit.Maximum = new decimal(new int[] {
            2013265919,
            -720531959,
            -1096570888,
            1769472});
            this.latSecEdit.Name = "latSecEdit";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // latMinEdit
            // 
            this.latMinEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.latMinEdit, "latMinEdit");
            this.latMinEdit.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.latMinEdit.Name = "latMinEdit";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // latDegEdit
            // 
            this.latDegEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.latDegEdit, "latDegEdit");
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
            this.latDegEdit.Value = new decimal(new int[] {
            44,
            0,
            0,
            0});
            // 
            // syncWaypointsBtn
            // 
            resources.ApplyResources(this.syncWaypointsBtn, "syncWaypointsBtn");
            this.syncWaypointsBtn.Name = "syncWaypointsBtn";
            this.syncWaypointsBtn.UseVisualStyleBackColor = true;
            this.syncWaypointsBtn.Click += new System.EventHandler(this.syncWaypointsBtn_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // waypointsLbx
            // 
            this.waypointsLbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.waypointsLbx.ContextMenuStrip = this.waypointsContexMenu;
            resources.ApplyResources(this.waypointsLbx, "waypointsLbx");
            this.waypointsLbx.FormattingEnabled = true;
            this.waypointsLbx.Name = "waypointsLbx";
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
            resources.ApplyResources(this.waypointsContexMenu, "waypointsContexMenu");
            // 
            // addWaypoint
            // 
            this.addWaypoint.Name = "addWaypoint";
            resources.ApplyResources(this.addWaypoint, "addWaypoint");
            this.addWaypoint.Click += new System.EventHandler(this.addWaypoint_Click);
            // 
            // deleteWaypoint
            // 
            this.deleteWaypoint.Name = "deleteWaypoint";
            resources.ApplyResources(this.deleteWaypoint, "deleteWaypoint");
            this.deleteWaypoint.Click += new System.EventHandler(this.deleteWaypoint_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // deleteAllPoints
            // 
            this.deleteAllPoints.Name = "deleteAllPoints";
            resources.ApplyResources(this.deleteAllPoints, "deleteAllPoints");
            this.deleteAllPoints.Click += new System.EventHandler(this.deleteAllPoints_Click);
            // 
            // weblinkLbl
            // 
            resources.ApplyResources(this.weblinkLbl, "weblinkLbl");
            this.weblinkLbl.Name = "weblinkLbl";
            this.weblinkLbl.TabStop = true;
            this.weblinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.weblinkLbl_LinkClicked);
            // 
            // deviceVersionLblTitle
            // 
            resources.ApplyResources(this.deviceVersionLblTitle, "deviceVersionLblTitle");
            this.deviceVersionLblTitle.Name = "deviceVersionLblTitle";
            // 
            // serialNumberLblTitle
            // 
            resources.ApplyResources(this.serialNumberLblTitle, "serialNumberLblTitle");
            this.serialNumberLblTitle.Name = "serialNumberLblTitle";
            // 
            // serialNumberLbl
            // 
            resources.ApplyResources(this.serialNumberLbl, "serialNumberLbl");
            this.serialNumberLbl.ContextMenuStrip = this.serialNumberContexMenu;
            this.serialNumberLbl.Name = "serialNumberLbl";
            // 
            // serialNumberContexMenu
            // 
            this.serialNumberContexMenu.AllowMerge = false;
            this.serialNumberContexMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToClipboardToolStripMenuItem});
            this.serialNumberContexMenu.Name = "serialNumberContexMenu";
            resources.ApplyResources(this.serialNumberContexMenu, "serialNumberContexMenu");
            // 
            // copyToClipboardToolStripMenuItem
            // 
            this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
            resources.ApplyResources(this.copyToClipboardToolStripMenuItem, "copyToClipboardToolStripMenuItem");
            this.copyToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyToClipboardToolStripMenuItem_Click);
            // 
            // isFlipScreenChb
            // 
            resources.ApplyResources(this.isFlipScreenChb, "isFlipScreenChb");
            this.isFlipScreenChb.Name = "isFlipScreenChb";
            this.isFlipScreenChb.UseVisualStyleBackColor = true;
            // 
            // salinitySearchLnk
            // 
            resources.ApplyResources(this.salinitySearchLnk, "salinitySearchLnk");
            this.salinitySearchLnk.Name = "salinitySearchLnk";
            this.salinitySearchLnk.TabStop = true;
            this.salinitySearchLnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.salinitySearchLnk_LinkClicked);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // salinityEdit
            // 
            this.salinityEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salinityEdit.DecimalPlaces = 1;
            resources.ApplyResources(this.salinityEdit, "salinityEdit");
            this.salinityEdit.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.salinityEdit.Name = "salinityEdit";
            // 
            // applySettingsBtn
            // 
            resources.ApplyResources(this.applySettingsBtn, "applySettingsBtn");
            this.applySettingsBtn.Name = "applySettingsBtn";
            this.applySettingsBtn.UseVisualStyleBackColor = true;
            this.applySettingsBtn.Click += new System.EventHandler(this.applySettingsBtn_Click);
            // 
            // trackGroup
            // 
            this.trackGroup.Controls.Add(this.trackCountLbl);
            this.trackGroup.Controls.Add(this.downloadTrackBtn);
            resources.ApplyResources(this.trackGroup, "trackGroup");
            this.trackGroup.Name = "trackGroup";
            this.trackGroup.TabStop = false;
            // 
            // trackCountLbl
            // 
            resources.ApplyResources(this.trackCountLbl, "trackCountLbl");
            this.trackCountLbl.Name = "trackCountLbl";
            // 
            // downloadTrackBtn
            // 
            resources.ApplyResources(this.downloadTrackBtn, "downloadTrackBtn");
            this.downloadTrackBtn.Name = "downloadTrackBtn";
            this.downloadTrackBtn.UseVisualStyleBackColor = true;
            this.downloadTrackBtn.Click += new System.EventHandler(this.downloadTrackBtn_Click);
            // 
            // redNodeInfoLblTitle
            // 
            resources.ApplyResources(this.redNodeInfoLblTitle, "redNodeInfoLblTitle");
            this.redNodeInfoLblTitle.Name = "redNodeInfoLblTitle";
            // 
            // redNodeSerialLbl
            // 
            resources.ApplyResources(this.redNodeSerialLbl, "redNodeSerialLbl");
            this.redNodeSerialLbl.ContextMenuStrip = this.rnSerialNumberContextMenu;
            this.redNodeSerialLbl.Name = "redNodeSerialLbl";
            // 
            // rnSerialNumberContextMenu
            // 
            this.rnSerialNumberContextMenu.AllowMerge = false;
            this.rnSerialNumberContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.rnSerialNumberContextMenu.Name = "serialNumberContexMenu";
            resources.ApplyResources(this.rnSerialNumberContextMenu, "rnSerialNumberContextMenu");
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // redNodeSerialNumberLblTitle
            // 
            resources.ApplyResources(this.redNodeSerialNumberLblTitle, "redNodeSerialNumberLblTitle");
            this.redNodeSerialNumberLblTitle.Name = "redNodeSerialNumberLblTitle";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.deviceInfoGroup, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.settingsGroup, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.trackGroup, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.routeGroup, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.weblinkLbl, 0, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // deviceInfoGroup
            // 
            this.deviceInfoGroup.Controls.Add(this.tableLayoutPanel2);
            resources.ApplyResources(this.deviceInfoGroup, "deviceInfoGroup");
            this.deviceInfoGroup.Name = "deviceInfoGroup";
            this.deviceInfoGroup.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.redNodeInfoLbl, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.deviceVersionLbl, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.deviceVersionLblTitle, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.serialNumberLblTitle, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.serialNumberLbl, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.redNodeInfoLblTitle, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.redNodeSerialLbl, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.redNodeSerialNumberLblTitle, 0, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // redNodeInfoLbl
            // 
            resources.ApplyResources(this.redNodeInfoLbl, "redNodeInfoLbl");
            this.redNodeInfoLbl.ContextMenuStrip = this.serialNumberContexMenu;
            this.redNodeInfoLbl.Name = "redNodeInfoLbl";
            // 
            // deviceVersionLbl
            // 
            resources.ApplyResources(this.deviceVersionLbl, "deviceVersionLbl");
            this.deviceVersionLbl.ContextMenuStrip = this.serialNumberContexMenu;
            this.deviceVersionLbl.Name = "deviceVersionLbl";
            // 
            // settingsGroup
            // 
            this.settingsGroup.Controls.Add(this.tableLayoutPanel3);
            resources.ApplyResources(this.settingsGroup, "settingsGroup");
            this.settingsGroup.Name = "settingsGroup";
            this.settingsGroup.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.isFlipScreenChb, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.salinitySearchLnk, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.salinityEdit, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.applySettingsBtn, 4, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // routeGroup
            // 
            this.routeGroup.Controls.Add(this.syncWaypointsBtn);
            this.routeGroup.Controls.Add(this.changePntBtn);
            this.routeGroup.Controls.Add(this.label1);
            this.routeGroup.Controls.Add(this.lonGroup);
            this.routeGroup.Controls.Add(this.waypointsLbx);
            this.routeGroup.Controls.Add(this.latGroup);
            resources.ApplyResources(this.routeGroup, "routeGroup");
            this.routeGroup.Name = "routeGroup";
            this.routeGroup.TabStop = false;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.salinityEdit)).EndInit();
            this.trackGroup.ResumeLayout(false);
            this.trackGroup.PerformLayout();
            this.rnSerialNumberContextMenu.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.deviceInfoGroup.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.settingsGroup.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.routeGroup.ResumeLayout(false);
            this.routeGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel systemStateLbl;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
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
        private System.Windows.Forms.Label deviceVersionLblTitle;
        private System.Windows.Forms.Label serialNumberLblTitle;
        private System.Windows.Forms.Label serialNumberLbl;
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
        private System.Windows.Forms.Label redNodeInfoLblTitle;
        private System.Windows.Forms.Label redNodeSerialLbl;
        private System.Windows.Forms.Label redNodeSerialNumberLblTitle;
        private System.Windows.Forms.ContextMenuStrip rnSerialNumberContextMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox deviceInfoGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label deviceVersionLbl;
        private System.Windows.Forms.Label redNodeInfoLbl;
        private System.Windows.Forms.GroupBox settingsGroup;
        private System.Windows.Forms.GroupBox routeGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}

