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
            this.rnSerialNumberContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label12 = new System.Windows.Forms.Label();
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
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.systemStateLbl,
            this.progressBar});
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
            resources.ApplyResources(this.progressBar, "progressBar");
            this.progressBar.Name = "progressBar";
            this.progressBar.Step = 1;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // wpPanel
            // 
            resources.ApplyResources(this.wpPanel, "wpPanel");
            this.wpPanel.Controls.Add(this.changePntBtn);
            this.wpPanel.Controls.Add(this.lonGroup);
            this.wpPanel.Controls.Add(this.latGroup);
            this.wpPanel.Controls.Add(this.syncWaypointsBtn);
            this.wpPanel.Controls.Add(this.label1);
            this.wpPanel.Controls.Add(this.waypointsLbx);
            this.wpPanel.Controls.Add(this.weblinkLbl);
            this.wpPanel.Name = "wpPanel";
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
            resources.ApplyResources(this.lonSecEdit, "lonSecEdit");
            this.lonSecEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lonSecEdit.DecimalPlaces = 3;
            this.lonSecEdit.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.lonSecEdit.Name = "lonSecEdit";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // lonMinEdit
            // 
            resources.ApplyResources(this.lonMinEdit, "lonMinEdit");
            this.lonMinEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            resources.ApplyResources(this.lonDegEdit, "lonDegEdit");
            this.lonDegEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            resources.ApplyResources(this.latSecEdit, "latSecEdit");
            this.latSecEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.latSecEdit.DecimalPlaces = 3;
            this.latSecEdit.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.latSecEdit.Name = "latSecEdit";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // latMinEdit
            // 
            resources.ApplyResources(this.latMinEdit, "latMinEdit");
            this.latMinEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            resources.ApplyResources(this.latDegEdit, "latDegEdit");
            this.latDegEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            resources.ApplyResources(this.waypointsLbx, "waypointsLbx");
            this.waypointsLbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.waypointsLbx.ContextMenuStrip = this.waypointsContexMenu;
            this.waypointsLbx.FormattingEnabled = true;
            this.waypointsLbx.Name = "waypointsLbx";
            this.waypointsLbx.SelectedIndexChanged += new System.EventHandler(this.waypointsLbx_SelectedIndexChanged);
            // 
            // waypointsContexMenu
            // 
            resources.ApplyResources(this.waypointsContexMenu, "waypointsContexMenu");
            this.waypointsContexMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addWaypoint,
            this.deleteWaypoint,
            this.toolStripSeparator1,
            this.deleteAllPoints});
            this.waypointsContexMenu.Name = "waypointsContexMenu";
            // 
            // addWaypoint
            // 
            resources.ApplyResources(this.addWaypoint, "addWaypoint");
            this.addWaypoint.Name = "addWaypoint";
            this.addWaypoint.Click += new System.EventHandler(this.addWaypoint_Click);
            // 
            // deleteWaypoint
            // 
            resources.ApplyResources(this.deleteWaypoint, "deleteWaypoint");
            this.deleteWaypoint.Name = "deleteWaypoint";
            this.deleteWaypoint.Click += new System.EventHandler(this.deleteWaypoint_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // deleteAllPoints
            // 
            resources.ApplyResources(this.deleteAllPoints, "deleteAllPoints");
            this.deleteAllPoints.Name = "deleteAllPoints";
            this.deleteAllPoints.Click += new System.EventHandler(this.deleteAllPoints_Click);
            // 
            // weblinkLbl
            // 
            resources.ApplyResources(this.weblinkLbl, "weblinkLbl");
            this.weblinkLbl.Name = "weblinkLbl";
            this.weblinkLbl.TabStop = true;
            this.weblinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.weblinkLbl_LinkClicked);
            // 
            // deviceVersionLabel
            // 
            resources.ApplyResources(this.deviceVersionLabel, "deviceVersionLabel");
            this.deviceVersionLabel.Name = "deviceVersionLabel";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // serialNumberLbl
            // 
            resources.ApplyResources(this.serialNumberLbl, "serialNumberLbl");
            this.serialNumberLbl.ContextMenuStrip = this.serialNumberContexMenu;
            this.serialNumberLbl.Name = "serialNumberLbl";
            // 
            // serialNumberContexMenu
            // 
            resources.ApplyResources(this.serialNumberContexMenu, "serialNumberContexMenu");
            this.serialNumberContexMenu.AllowMerge = false;
            this.serialNumberContexMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToClipboardToolStripMenuItem});
            this.serialNumberContexMenu.Name = "serialNumberContexMenu";
            // 
            // copyToClipboardToolStripMenuItem
            // 
            resources.ApplyResources(this.copyToClipboardToolStripMenuItem, "copyToClipboardToolStripMenuItem");
            this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
            this.copyToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyToClipboardToolStripMenuItem_Click);
            // 
            // settingsGroup
            // 
            resources.ApplyResources(this.settingsGroup, "settingsGroup");
            this.settingsGroup.Controls.Add(this.isFlipScreenChb);
            this.settingsGroup.Controls.Add(this.salinitySearchLnk);
            this.settingsGroup.Controls.Add(this.label10);
            this.settingsGroup.Controls.Add(this.salinityEdit);
            this.settingsGroup.Name = "settingsGroup";
            this.settingsGroup.TabStop = false;
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
            resources.ApplyResources(this.salinityEdit, "salinityEdit");
            this.salinityEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salinityEdit.DecimalPlaces = 1;
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
            resources.ApplyResources(this.trackGroup, "trackGroup");
            this.trackGroup.Controls.Add(this.trackCountLbl);
            this.trackGroup.Controls.Add(this.downloadTrackBtn);
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
            // redNodeInfoLbl
            // 
            resources.ApplyResources(this.redNodeInfoLbl, "redNodeInfoLbl");
            this.redNodeInfoLbl.Name = "redNodeInfoLbl";
            // 
            // redNodeSerialLbl
            // 
            resources.ApplyResources(this.redNodeSerialLbl, "redNodeSerialLbl");
            this.redNodeSerialLbl.ContextMenuStrip = this.rnSerialNumberContextMenu;
            this.redNodeSerialLbl.Name = "redNodeSerialLbl";
            // 
            // rnSerialNumberContextMenu
            // 
            resources.ApplyResources(this.rnSerialNumberContextMenu, "rnSerialNumberContextMenu");
            this.rnSerialNumberContextMenu.AllowMerge = false;
            this.rnSerialNumberContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.rnSerialNumberContextMenu.Name = "serialNumberContexMenu";
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
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

