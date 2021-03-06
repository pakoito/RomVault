﻿namespace ROMVault2
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnFixFiles = new System.Windows.Forms.Button();
            this.btnFindFixes = new System.Windows.Forms.Button();
            this.btnScanRoms = new System.Windows.Forms.Button();
            this.btnUpdateDats = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.gbDatInfo = new System.Windows.Forms.GroupBox();
            this.lblDIRomsUnknown = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDITRomsUnknown = new System.Windows.Forms.Label();
            this.lblDITRomsFixable = new System.Windows.Forms.Label();
            this.lblDITRomsMissing = new System.Windows.Forms.Label();
            this.lblDITRomsGot = new System.Windows.Forms.Label();
            this.lblDITRomPath = new System.Windows.Forms.Label();
            this.lblDITPath = new System.Windows.Forms.Label();
            this.lblDIDate = new System.Windows.Forms.Label();
            this.lblDIAuthor = new System.Windows.Forms.Label();
            this.lblDITDate = new System.Windows.Forms.Label();
            this.lblDITAuthor = new System.Windows.Forms.Label();
            this.lblDIVersion = new System.Windows.Forms.Label();
            this.lblDICategory = new System.Windows.Forms.Label();
            this.lblDITVersion = new System.Windows.Forms.Label();
            this.lblDITCategory = new System.Windows.Forms.Label();
            this.lblDIDescription = new System.Windows.Forms.Label();
            this.lblDIName = new System.Windows.Forms.Label();
            this.lblDITDescription = new System.Windows.Forms.Label();
            this.lblDITName = new System.Windows.Forms.Label();
            this.lblDIRomsFixable = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DirTree = new ROMVault2.RvTree();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.btnColorKey = new System.Windows.Forms.Button();
            this.chkBoxShowMerged = new System.Windows.Forms.CheckBox();
            this.chkBoxShowFixed = new System.Windows.Forms.CheckBox();
            this.chkBoxShowMissing = new System.Windows.Forms.CheckBox();
            this.chkBoxShowCorrect = new System.Windows.Forms.CheckBox();
            this.gbSetInfo = new System.Windows.Forms.GroupBox();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.GameGrid = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewImageColumn();
            this.CGame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCorrect = new System.Windows.Forms.DataGridViewImageColumn();
            this.RomGrid = new System.Windows.Forms.DataGridView();
            this.CGot = new System.Windows.Forms.DataGridViewImageColumn();
            this.CRom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMerge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCRC32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSHA1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMD5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZipIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZipHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmUpdateDATs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmScanROMs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmScanLevel1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmScanLevel2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmScanLevel3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFindFixes = new System.Windows.Forms.ToolStripMenuItem();
            this.FixROMsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fixDatReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fixReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutRomVaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.gbDatInfo.SuspendLayout();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RomGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.btnReport);
            this.splitContainer1.Panel1.Controls.Add(this.btnFixFiles);
            this.splitContainer1.Panel1.Controls.Add(this.btnFindFixes);
            this.splitContainer1.Panel1.Controls.Add(this.btnScanRoms);
            this.splitContainer1.Panel1.Controls.Add(this.btnUpdateDats);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1264, 738);
            this.splitContainer1.SplitterDistance = 80;
            this.splitContainer1.TabIndex = 5;
            // 
            // btnReport
            // 
            this.btnReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReport.BackgroundImage")));
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReport.Location = new System.Drawing.Point(0, 320);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(80, 80);
            this.btnReport.TabIndex = 13;
            this.btnReport.Text = "Generate Reports";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.BtnReportClick);
            // 
            // btnFixFiles
            // 
            this.btnFixFiles.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFixFiles.BackgroundImage")));
            this.btnFixFiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFixFiles.Location = new System.Drawing.Point(0, 240);
            this.btnFixFiles.Name = "btnFixFiles";
            this.btnFixFiles.Size = new System.Drawing.Size(80, 80);
            this.btnFixFiles.TabIndex = 10;
            this.btnFixFiles.Text = "Fix ROMs";
            this.btnFixFiles.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFixFiles.UseVisualStyleBackColor = true;
            this.btnFixFiles.Click += new System.EventHandler(this.BtnFixFilesClick);
            // 
            // btnFindFixes
            // 
            this.btnFindFixes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFindFixes.BackgroundImage")));
            this.btnFindFixes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFindFixes.Location = new System.Drawing.Point(0, 160);
            this.btnFindFixes.Name = "btnFindFixes";
            this.btnFindFixes.Size = new System.Drawing.Size(80, 80);
            this.btnFindFixes.TabIndex = 9;
            this.btnFindFixes.Text = "Find Fixes";
            this.btnFindFixes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFindFixes.UseVisualStyleBackColor = true;
            this.btnFindFixes.Click += new System.EventHandler(this.BtnFindFixesClick);
            // 
            // btnScanRoms
            // 
            this.btnScanRoms.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnScanRoms.BackgroundImage")));
            this.btnScanRoms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScanRoms.Location = new System.Drawing.Point(0, 80);
            this.btnScanRoms.Name = "btnScanRoms";
            this.btnScanRoms.Size = new System.Drawing.Size(80, 80);
            this.btnScanRoms.TabIndex = 8;
            this.btnScanRoms.Text = "Scan ROMs";
            this.btnScanRoms.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnScanRoms.UseVisualStyleBackColor = true;
            this.btnScanRoms.Click += new System.EventHandler(this.BtnScanRomsClick);
            // 
            // btnUpdateDats
            // 
            this.btnUpdateDats.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateDats.BackgroundImage")));
            this.btnUpdateDats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateDats.Location = new System.Drawing.Point(0, 0);
            this.btnUpdateDats.Name = "btnUpdateDats";
            this.btnUpdateDats.Size = new System.Drawing.Size(80, 80);
            this.btnUpdateDats.TabIndex = 0;
            this.btnUpdateDats.Text = "Update DATs";
            this.btnUpdateDats.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdateDats.UseVisualStyleBackColor = true;
            this.btnUpdateDats.Click += new System.EventHandler(this.BtnUpdateDatsClick);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            this.splitContainer2.Panel1MinSize = 450;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer2.Size = new System.Drawing.Size(1180, 738);
            this.splitContainer2.SplitterDistance = 479;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.gbDatInfo);
            this.splitContainer3.Panel1.Resize += new System.EventHandler(this.splitContainer3_Panel1_Resize);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.DirTree);
            this.splitContainer3.Size = new System.Drawing.Size(479, 738);
            this.splitContainer3.SplitterDistance = 148;
            this.splitContainer3.TabIndex = 0;
            // 
            // gbDatInfo
            // 
            this.gbDatInfo.Controls.Add(this.lblDIRomsUnknown);
            this.gbDatInfo.Controls.Add(this.label9);
            this.gbDatInfo.Controls.Add(this.lblDITRomsUnknown);
            this.gbDatInfo.Controls.Add(this.lblDITRomsFixable);
            this.gbDatInfo.Controls.Add(this.lblDITRomsMissing);
            this.gbDatInfo.Controls.Add(this.lblDITRomsGot);
            this.gbDatInfo.Controls.Add(this.lblDITRomPath);
            this.gbDatInfo.Controls.Add(this.lblDITPath);
            this.gbDatInfo.Controls.Add(this.lblDIDate);
            this.gbDatInfo.Controls.Add(this.lblDIAuthor);
            this.gbDatInfo.Controls.Add(this.lblDITDate);
            this.gbDatInfo.Controls.Add(this.lblDITAuthor);
            this.gbDatInfo.Controls.Add(this.lblDIVersion);
            this.gbDatInfo.Controls.Add(this.lblDICategory);
            this.gbDatInfo.Controls.Add(this.lblDITVersion);
            this.gbDatInfo.Controls.Add(this.lblDITCategory);
            this.gbDatInfo.Controls.Add(this.lblDIDescription);
            this.gbDatInfo.Controls.Add(this.lblDIName);
            this.gbDatInfo.Controls.Add(this.lblDITDescription);
            this.gbDatInfo.Controls.Add(this.lblDITName);
            this.gbDatInfo.Controls.Add(this.lblDIRomsFixable);
            this.gbDatInfo.Controls.Add(this.label8);
            this.gbDatInfo.Location = new System.Drawing.Point(5, 0);
            this.gbDatInfo.Name = "gbDatInfo";
            this.gbDatInfo.Size = new System.Drawing.Size(468, 147);
            this.gbDatInfo.TabIndex = 3;
            this.gbDatInfo.TabStop = false;
            this.gbDatInfo.Text = "Dat Info :";
            this.gbDatInfo.Resize += new System.EventHandler(this.gbDatInfo_Resize);
            // 
            // lblDIRomsUnknown
            // 
            this.lblDIRomsUnknown.Location = new System.Drawing.Point(214, 121);
            this.lblDIRomsUnknown.Name = "lblDIRomsUnknown";
            this.lblDIRomsUnknown.Size = new System.Drawing.Size(92, 13);
            this.lblDIRomsUnknown.TabIndex = 26;
            this.lblDIRomsUnknown.Text = "ROMs Unknown :";
            this.lblDIRomsUnknown.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(10, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "ROMs Got :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDITRomsUnknown
            // 
            this.lblDITRomsUnknown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDITRomsUnknown.Location = new System.Drawing.Point(311, 120);
            this.lblDITRomsUnknown.Name = "lblDITRomsUnknown";
            this.lblDITRomsUnknown.Size = new System.Drawing.Size(120, 17);
            this.lblDITRomsUnknown.TabIndex = 21;
            // 
            // lblDITRomsFixable
            // 
            this.lblDITRomsFixable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDITRomsFixable.Location = new System.Drawing.Point(311, 104);
            this.lblDITRomsFixable.Name = "lblDITRomsFixable";
            this.lblDITRomsFixable.Size = new System.Drawing.Size(120, 17);
            this.lblDITRomsFixable.TabIndex = 20;
            // 
            // lblDITRomsMissing
            // 
            this.lblDITRomsMissing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDITRomsMissing.Location = new System.Drawing.Point(89, 120);
            this.lblDITRomsMissing.Name = "lblDITRomsMissing";
            this.lblDITRomsMissing.Size = new System.Drawing.Size(120, 17);
            this.lblDITRomsMissing.TabIndex = 19;
            // 
            // lblDITRomsGot
            // 
            this.lblDITRomsGot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDITRomsGot.Location = new System.Drawing.Point(89, 104);
            this.lblDITRomsGot.Name = "lblDITRomsGot";
            this.lblDITRomsGot.Size = new System.Drawing.Size(120, 17);
            this.lblDITRomsGot.TabIndex = 18;
            // 
            // lblDITRomPath
            // 
            this.lblDITRomPath.Location = new System.Drawing.Point(10, 79);
            this.lblDITRomPath.Name = "lblDITRomPath";
            this.lblDITRomPath.Size = new System.Drawing.Size(75, 13);
            this.lblDITRomPath.TabIndex = 15;
            this.lblDITRomPath.Text = "ROM Path:";
            this.lblDITRomPath.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDITPath
            // 
            this.lblDITPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDITPath.Location = new System.Drawing.Point(89, 78);
            this.lblDITPath.Name = "lblDITPath";
            this.lblDITPath.Size = new System.Drawing.Size(342, 17);
            this.lblDITPath.TabIndex = 13;
            // 
            // lblDIDate
            // 
            this.lblDIDate.Location = new System.Drawing.Point(214, 63);
            this.lblDIDate.Name = "lblDIDate";
            this.lblDIDate.Size = new System.Drawing.Size(92, 13);
            this.lblDIDate.TabIndex = 12;
            this.lblDIDate.Text = "Date :";
            this.lblDIDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDIAuthor
            // 
            this.lblDIAuthor.Location = new System.Drawing.Point(10, 63);
            this.lblDIAuthor.Name = "lblDIAuthor";
            this.lblDIAuthor.Size = new System.Drawing.Size(75, 13);
            this.lblDIAuthor.TabIndex = 11;
            this.lblDIAuthor.Text = "Author :";
            this.lblDIAuthor.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDITDate
            // 
            this.lblDITDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDITDate.Location = new System.Drawing.Point(311, 62);
            this.lblDITDate.Name = "lblDITDate";
            this.lblDITDate.Size = new System.Drawing.Size(120, 17);
            this.lblDITDate.TabIndex = 10;
            // 
            // lblDITAuthor
            // 
            this.lblDITAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDITAuthor.Location = new System.Drawing.Point(89, 62);
            this.lblDITAuthor.Name = "lblDITAuthor";
            this.lblDITAuthor.Size = new System.Drawing.Size(120, 17);
            this.lblDITAuthor.TabIndex = 9;
            // 
            // lblDIVersion
            // 
            this.lblDIVersion.Location = new System.Drawing.Point(214, 47);
            this.lblDIVersion.Name = "lblDIVersion";
            this.lblDIVersion.Size = new System.Drawing.Size(92, 13);
            this.lblDIVersion.TabIndex = 8;
            this.lblDIVersion.Text = "Version :";
            this.lblDIVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDICategory
            // 
            this.lblDICategory.Location = new System.Drawing.Point(10, 47);
            this.lblDICategory.Name = "lblDICategory";
            this.lblDICategory.Size = new System.Drawing.Size(75, 13);
            this.lblDICategory.TabIndex = 7;
            this.lblDICategory.Text = "Category :";
            this.lblDICategory.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDITVersion
            // 
            this.lblDITVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDITVersion.Location = new System.Drawing.Point(311, 46);
            this.lblDITVersion.Name = "lblDITVersion";
            this.lblDITVersion.Size = new System.Drawing.Size(120, 17);
            this.lblDITVersion.TabIndex = 6;
            // 
            // lblDITCategory
            // 
            this.lblDITCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDITCategory.Location = new System.Drawing.Point(89, 46);
            this.lblDITCategory.Name = "lblDITCategory";
            this.lblDITCategory.Size = new System.Drawing.Size(120, 17);
            this.lblDITCategory.TabIndex = 5;
            // 
            // lblDIDescription
            // 
            this.lblDIDescription.Location = new System.Drawing.Point(10, 31);
            this.lblDIDescription.Name = "lblDIDescription";
            this.lblDIDescription.Size = new System.Drawing.Size(75, 13);
            this.lblDIDescription.TabIndex = 4;
            this.lblDIDescription.Text = "Description :";
            this.lblDIDescription.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDIName
            // 
            this.lblDIName.Location = new System.Drawing.Point(10, 15);
            this.lblDIName.Name = "lblDIName";
            this.lblDIName.Size = new System.Drawing.Size(75, 13);
            this.lblDIName.TabIndex = 3;
            this.lblDIName.Text = "Name :";
            this.lblDIName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDITDescription
            // 
            this.lblDITDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDITDescription.Location = new System.Drawing.Point(89, 30);
            this.lblDITDescription.Name = "lblDITDescription";
            this.lblDITDescription.Size = new System.Drawing.Size(342, 17);
            this.lblDITDescription.TabIndex = 2;
            // 
            // lblDITName
            // 
            this.lblDITName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDITName.Location = new System.Drawing.Point(89, 14);
            this.lblDITName.Name = "lblDITName";
            this.lblDITName.Size = new System.Drawing.Size(342, 17);
            this.lblDITName.TabIndex = 1;
            // 
            // lblDIRomsFixable
            // 
            this.lblDIRomsFixable.Location = new System.Drawing.Point(214, 105);
            this.lblDIRomsFixable.Name = "lblDIRomsFixable";
            this.lblDIRomsFixable.Size = new System.Drawing.Size(92, 13);
            this.lblDIRomsFixable.TabIndex = 25;
            this.lblDIRomsFixable.Text = "ROMs Fixable :";
            this.lblDIRomsFixable.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(2, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "ROMs Missing :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // DirTree
            // 
            this.DirTree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DirTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DirTree.Location = new System.Drawing.Point(0, 0);
            this.DirTree.Name = "DirTree";
            this.DirTree.Size = new System.Drawing.Size(479, 586);
            this.DirTree.TabIndex = 2;
            this.DirTree.RvSelected += new System.Windows.Forms.MouseEventHandler(this.DirTreeRvSelected);
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.btnColorKey);
            this.splitContainer4.Panel1.Controls.Add(this.chkBoxShowMerged);
            this.splitContainer4.Panel1.Controls.Add(this.chkBoxShowFixed);
            this.splitContainer4.Panel1.Controls.Add(this.chkBoxShowMissing);
            this.splitContainer4.Panel1.Controls.Add(this.chkBoxShowCorrect);
            this.splitContainer4.Panel1.Controls.Add(this.gbSetInfo);
            this.splitContainer4.Panel1.Resize += new System.EventHandler(this.splitContainer4_Panel1_Resize);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer4.Size = new System.Drawing.Size(697, 738);
            this.splitContainer4.SplitterDistance = 148;
            this.splitContainer4.TabIndex = 0;
            // 
            // btnColorKey
            // 
            this.btnColorKey.Location = new System.Drawing.Point(547, 85);
            this.btnColorKey.Name = "btnColorKey";
            this.btnColorKey.Size = new System.Drawing.Size(89, 23);
            this.btnColorKey.TabIndex = 9;
            this.btnColorKey.Text = "Color Key";
            this.btnColorKey.UseVisualStyleBackColor = true;
            this.btnColorKey.Click += new System.EventHandler(this.BtnColorKeyClick);
            // 
            // chkBoxShowMerged
            // 
            this.chkBoxShowMerged.AutoSize = true;
            this.chkBoxShowMerged.Location = new System.Drawing.Point(547, 68);
            this.chkBoxShowMerged.Name = "chkBoxShowMerged";
            this.chkBoxShowMerged.Size = new System.Drawing.Size(125, 17);
            this.chkBoxShowMerged.TabIndex = 8;
            this.chkBoxShowMerged.Text = "Show Merged ROMs";
            this.chkBoxShowMerged.UseVisualStyleBackColor = true;
            this.chkBoxShowMerged.CheckedChanged += new System.EventHandler(this.ChkBoxShowMergedCheckedChanged);
            // 
            // chkBoxShowFixed
            // 
            this.chkBoxShowFixed.AutoSize = true;
            this.chkBoxShowFixed.Checked = true;
            this.chkBoxShowFixed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxShowFixed.Location = new System.Drawing.Point(547, 52);
            this.chkBoxShowFixed.Name = "chkBoxShowFixed";
            this.chkBoxShowFixed.Size = new System.Drawing.Size(102, 17);
            this.chkBoxShowFixed.TabIndex = 7;
            this.chkBoxShowFixed.Text = "Show Fix ROMs";
            this.chkBoxShowFixed.UseVisualStyleBackColor = true;
            this.chkBoxShowFixed.CheckedChanged += new System.EventHandler(this.ChkBoxShowFixedCheckedChanged);
            // 
            // chkBoxShowMissing
            // 
            this.chkBoxShowMissing.AutoSize = true;
            this.chkBoxShowMissing.Checked = true;
            this.chkBoxShowMissing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxShowMissing.Location = new System.Drawing.Point(547, 36);
            this.chkBoxShowMissing.Name = "chkBoxShowMissing";
            this.chkBoxShowMissing.Size = new System.Drawing.Size(124, 17);
            this.chkBoxShowMissing.TabIndex = 6;
            this.chkBoxShowMissing.Text = "Show Missing ROMs";
            this.chkBoxShowMissing.UseVisualStyleBackColor = true;
            this.chkBoxShowMissing.CheckedChanged += new System.EventHandler(this.ChkBoxShowMissingCheckedChanged);
            // 
            // chkBoxShowCorrect
            // 
            this.chkBoxShowCorrect.AutoSize = true;
            this.chkBoxShowCorrect.Checked = true;
            this.chkBoxShowCorrect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxShowCorrect.Location = new System.Drawing.Point(547, 20);
            this.chkBoxShowCorrect.Name = "chkBoxShowCorrect";
            this.chkBoxShowCorrect.Size = new System.Drawing.Size(123, 17);
            this.chkBoxShowCorrect.TabIndex = 5;
            this.chkBoxShowCorrect.Text = "Show Correct ROMs";
            this.chkBoxShowCorrect.UseVisualStyleBackColor = true;
            this.chkBoxShowCorrect.CheckedChanged += new System.EventHandler(this.ChkBoxShowCorrectCheckedChanged);
            // 
            // gbSetInfo
            // 
            this.gbSetInfo.Location = new System.Drawing.Point(5, 0);
            this.gbSetInfo.Name = "gbSetInfo";
            this.gbSetInfo.Size = new System.Drawing.Size(532, 147);
            this.gbSetInfo.TabIndex = 4;
            this.gbSetInfo.TabStop = false;
            this.gbSetInfo.Text = "Game Info :";
            this.gbSetInfo.Resize += new System.EventHandler(this.gbSetInfo_Resize);
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.GameGrid);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.RomGrid);
            this.splitContainer5.Size = new System.Drawing.Size(697, 586);
            this.splitContainer5.SplitterDistance = 267;
            this.splitContainer5.TabIndex = 0;
            // 
            // GameGrid
            // 
            this.GameGrid.AllowUserToAddRows = false;
            this.GameGrid.AllowUserToDeleteRows = false;
            this.GameGrid.AllowUserToResizeRows = false;
            this.GameGrid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GameGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GameGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GameGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.CGame,
            this.CDescription,
            this.CCorrect});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GameGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.GameGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GameGrid.Location = new System.Drawing.Point(0, 0);
            this.GameGrid.MultiSelect = false;
            this.GameGrid.Name = "GameGrid";
            this.GameGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GameGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GameGrid.RowHeadersVisible = false;
            this.GameGrid.RowTemplate.Height = 17;
            this.GameGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GameGrid.ShowCellErrors = false;
            this.GameGrid.ShowCellToolTips = false;
            this.GameGrid.ShowEditingIcon = false;
            this.GameGrid.ShowRowErrors = false;
            this.GameGrid.Size = new System.Drawing.Size(697, 267);
            this.GameGrid.TabIndex = 4;
            this.GameGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GameGrid_CellFormatting);
            this.GameGrid.SelectionChanged += new System.EventHandler(this.GameGridSelectionChanged);
            this.GameGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GameGridMouseDoubleClick);
            this.GameGrid.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GameGrid_MouseUp);
            // 
            // Type
            // 
            this.Type.FillWeight = 40F;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Type.Width = 40;
            // 
            // CGame
            // 
            this.CGame.HeaderText = "Game (Directory / Zip)";
            this.CGame.Name = "CGame";
            this.CGame.ReadOnly = true;
            this.CGame.Width = 220;
            // 
            // CDescription
            // 
            this.CDescription.HeaderText = "Description";
            this.CDescription.Name = "CDescription";
            this.CDescription.ReadOnly = true;
            this.CDescription.Width = 220;
            // 
            // CCorrect
            // 
            this.CCorrect.HeaderText = "ROM Status";
            this.CCorrect.Name = "CCorrect";
            this.CCorrect.ReadOnly = true;
            this.CCorrect.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CCorrect.Width = 500;
            // 
            // RomGrid
            // 
            this.RomGrid.AllowUserToAddRows = false;
            this.RomGrid.AllowUserToDeleteRows = false;
            this.RomGrid.AllowUserToResizeRows = false;
            this.RomGrid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RomGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.RomGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RomGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CGot,
            this.CRom,
            this.CSize,
            this.CMerge,
            this.CCRC32,
            this.CSHA1,
            this.CMD5,
            this.CStatus,
            this.ZipIndex,
            this.ZipHeader});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RomGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.RomGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RomGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RomGrid.Location = new System.Drawing.Point(0, 0);
            this.RomGrid.MultiSelect = false;
            this.RomGrid.Name = "RomGrid";
            this.RomGrid.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RomGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.RomGrid.RowHeadersVisible = false;
            this.RomGrid.RowTemplate.Height = 19;
            this.RomGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RomGrid.ShowCellErrors = false;
            this.RomGrid.ShowEditingIcon = false;
            this.RomGrid.ShowRowErrors = false;
            this.RomGrid.Size = new System.Drawing.Size(697, 315);
            this.RomGrid.TabIndex = 21;
            this.RomGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.RomGrid_CellFormatting);
            this.RomGrid.SelectionChanged += new System.EventHandler(this.RomGridSelectionChanged);
            this.RomGrid.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RomGridMouseUp);
            // 
            // CGot
            // 
            this.CGot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CGot.HeaderText = "Got";
            this.CGot.Name = "CGot";
            this.CGot.ReadOnly = true;
            this.CGot.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CGot.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CGot.Width = 65;
            // 
            // CRom
            // 
            this.CRom.HeaderText = "ROM (File)";
            this.CRom.Name = "CRom";
            this.CRom.ReadOnly = true;
            this.CRom.Width = 150;
            // 
            // CSize
            // 
            this.CSize.HeaderText = "Size";
            this.CSize.Name = "CSize";
            this.CSize.ReadOnly = true;
            this.CSize.Width = 60;
            // 
            // CMerge
            // 
            this.CMerge.HeaderText = "Merge";
            this.CMerge.Name = "CMerge";
            this.CMerge.ReadOnly = true;
            this.CMerge.Width = 60;
            // 
            // CCRC32
            // 
            this.CCRC32.HeaderText = "CRC32";
            this.CCRC32.Name = "CCRC32";
            this.CCRC32.ReadOnly = true;
            // 
            // CSHA1
            // 
            this.CSHA1.HeaderText = "SHA1";
            this.CSHA1.Name = "CSHA1";
            this.CSHA1.ReadOnly = true;
            this.CSHA1.Width = 150;
            // 
            // CMD5
            // 
            this.CMD5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CMD5.HeaderText = "MD5";
            this.CMD5.Name = "CMD5";
            this.CMD5.ReadOnly = true;
            this.CMD5.Width = 150;
            // 
            // CStatus
            // 
            this.CStatus.HeaderText = "Status";
            this.CStatus.Name = "CStatus";
            this.CStatus.ReadOnly = true;
            // 
            // ZipIndex
            // 
            this.ZipIndex.HeaderText = "ZipIndex";
            this.ZipIndex.Name = "ZipIndex";
            this.ZipIndex.ReadOnly = true;
            // 
            // ZipHeader
            // 
            this.ZipHeader.HeaderText = "ZipHeader";
            this.ZipHeader.Name = "ZipHeader";
            this.ZipHeader.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmUpdateDATs,
            this.tsmScanROMs,
            this.tsmFindFixes,
            this.FixROMsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmUpdateDATs
            // 
            this.tsmUpdateDATs.Name = "tsmUpdateDATs";
            this.tsmUpdateDATs.Size = new System.Drawing.Size(88, 20);
            this.tsmUpdateDATs.Text = "Update DATs";
            this.tsmUpdateDATs.Click += new System.EventHandler(this.TsmUpdateDaTsClick);
            // 
            // tsmScanROMs
            // 
            this.tsmScanROMs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmScanLevel1,
            this.tsmScanLevel2,
            this.tsmScanLevel3});
            this.tsmScanROMs.Name = "tsmScanROMs";
            this.tsmScanROMs.Size = new System.Drawing.Size(79, 20);
            this.tsmScanROMs.Text = "Scan ROMs";
            // 
            // tsmScanLevel1
            // 
            this.tsmScanLevel1.Name = "tsmScanLevel1";
            this.tsmScanLevel1.Size = new System.Drawing.Size(300, 22);
            this.tsmScanLevel1.Text = "Level 1: Scan ROMs";
            this.tsmScanLevel1.Click += new System.EventHandler(this.TsmScanLevel1Click);
            // 
            // tsmScanLevel2
            // 
            this.tsmScanLevel2.Name = "tsmScanLevel2";
            this.tsmScanLevel2.Size = new System.Drawing.Size(300, 22);
            this.tsmScanLevel2.Text = "Level 2: ReScan New ROMs";
            this.tsmScanLevel2.Click += new System.EventHandler(this.TsmScanLevel2Click);
            // 
            // tsmScanLevel3
            // 
            this.tsmScanLevel3.Name = "tsmScanLevel3";
            this.tsmScanLevel3.Size = new System.Drawing.Size(300, 22);
            this.tsmScanLevel3.Text = "Level 3: ReScan All ROMs (CRC,MD5,SHA1)";
            this.tsmScanLevel3.Click += new System.EventHandler(this.TsmScanLevel3Click);
            // 
            // tsmFindFixes
            // 
            this.tsmFindFixes.Name = "tsmFindFixes";
            this.tsmFindFixes.Size = new System.Drawing.Size(70, 20);
            this.tsmFindFixes.Text = "Find Fixes";
            this.tsmFindFixes.Click += new System.EventHandler(this.TsmFindFixesClick);
            // 
            // FixROMsToolStripMenuItem
            // 
            this.FixROMsToolStripMenuItem.Name = "FixROMsToolStripMenuItem";
            this.FixROMsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.FixROMsToolStripMenuItem.Text = "Fix ROMs";
            this.FixROMsToolStripMenuItem.Click += new System.EventHandler(this.FixFilesToolStripMenuItemClick);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItemClick);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fixDatReportToolStripMenuItem,
            this.fullReportToolStripMenuItem,
            this.fixReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // fixDatReportToolStripMenuItem
            // 
            this.fixDatReportToolStripMenuItem.Name = "fixDatReportToolStripMenuItem";
            this.fixDatReportToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.fixDatReportToolStripMenuItem.Text = "Fix Dat Report";
            this.fixDatReportToolStripMenuItem.Click += new System.EventHandler(this.fixDatReportToolStripMenuItem_Click);
            // 
            // fullReportToolStripMenuItem
            // 
            this.fullReportToolStripMenuItem.Name = "fullReportToolStripMenuItem";
            this.fullReportToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.fullReportToolStripMenuItem.Text = "Full Report";
            this.fullReportToolStripMenuItem.Click += new System.EventHandler(this.fullReportToolStripMenuItem_Click);
            // 
            // fixReportToolStripMenuItem
            // 
            this.fixReportToolStripMenuItem.Name = "fixReportToolStripMenuItem";
            this.fixReportToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.fixReportToolStripMenuItem.Text = "Fix Report";
            this.fixReportToolStripMenuItem.Click += new System.EventHandler(this.fixReportToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutRomVaultToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutRomVaultToolStripMenuItem
            // 
            this.aboutRomVaultToolStripMenuItem.Name = "aboutRomVaultToolStripMenuItem";
            this.aboutRomVaultToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.aboutRomVaultToolStripMenuItem.Text = "About RomVault";
            this.aboutRomVaultToolStripMenuItem.Click += new System.EventHandler(this.AboutRomVaultToolStripMenuItemClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 40F;
            this.dataGridViewImageColumn1.HeaderText = "Type";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 40;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "ROM Status";
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn2.Width = 300;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn3.HeaderText = "Got";
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn3.Width = 65;
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1264, 762);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "RomVault (V2.0)";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            this.gbDatInfo.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GameGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RomGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnFixFiles;
        private System.Windows.Forms.Button btnFindFixes;
        private System.Windows.Forms.Button btnScanRoms;
        private System.Windows.Forms.Button btnUpdateDats;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox gbDatInfo;
        private System.Windows.Forms.Label lblDIRomsUnknown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDITRomsUnknown;
        private System.Windows.Forms.Label lblDITRomsMissing;
        private System.Windows.Forms.Label lblDITRomsGot;
        private System.Windows.Forms.Label lblDITRomPath;
        private System.Windows.Forms.Label lblDITPath;
        private System.Windows.Forms.Label lblDIDate;
        private System.Windows.Forms.Label lblDIAuthor;
        private System.Windows.Forms.Label lblDITDate;
        private System.Windows.Forms.Label lblDITAuthor;
        private System.Windows.Forms.Label lblDIVersion;
        private System.Windows.Forms.Label lblDICategory;
        private System.Windows.Forms.Label lblDITVersion;
        private System.Windows.Forms.Label lblDITCategory;
        private System.Windows.Forms.Label lblDIDescription;
        private System.Windows.Forms.Label lblDIName;
        private System.Windows.Forms.Label lblDITDescription;
        private System.Windows.Forms.Label lblDITName;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Button btnColorKey;
        private System.Windows.Forms.CheckBox chkBoxShowMerged;
        private System.Windows.Forms.CheckBox chkBoxShowFixed;
        private System.Windows.Forms.CheckBox chkBoxShowMissing;
        private System.Windows.Forms.CheckBox chkBoxShowCorrect;
        private System.Windows.Forms.GroupBox gbSetInfo;
       
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.DataGridView GameGrid;
        private System.Windows.Forms.DataGridView RomGrid;
        private RvTree DirTree;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmUpdateDATs;
        private System.Windows.Forms.ToolStripMenuItem tsmScanROMs;
        private System.Windows.Forms.ToolStripMenuItem tsmScanLevel1;
        private System.Windows.Forms.ToolStripMenuItem tsmScanLevel3;
        private System.Windows.Forms.ToolStripMenuItem tsmFindFixes;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutRomVaultToolStripMenuItem;
        private System.Windows.Forms.DataGridViewImageColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGame;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescription;
        private System.Windows.Forms.DataGridViewImageColumn CCorrect;
        private System.Windows.Forms.ToolStripMenuItem FixROMsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmScanLevel2;
        private System.Windows.Forms.DataGridViewImageColumn CGot;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRom;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMerge;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCRC32;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSHA1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMD5;
        private System.Windows.Forms.DataGridViewTextBoxColumn CStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZipIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZipHeader;
        private System.Windows.Forms.Label lblDITRomsFixable;
        private System.Windows.Forms.Label lblDIRomsFixable;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fixDatReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fixReportToolStripMenuItem;
    }
}

