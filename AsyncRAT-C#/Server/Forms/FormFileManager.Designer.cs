﻿namespace Server.Forms
{
    partial class FormFileManager
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Folders", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("File", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFileManager));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEFRESHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gOTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dESKTOPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aPPDATAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversListsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uPLOADToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXECUTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sevenZiplStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.installToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unzipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openClientFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.ForeColor = System.Drawing.Color.White;
            listViewGroup1.Header = "Folders";
            listViewGroup1.Name = "Folders";
            listViewGroup2.Header = "File";
            listViewGroup2.Name = "File";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(0, 1);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(705, 332);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.rEFRESHToolStripMenuItem,
            this.gOTOToolStripMenuItem,
            this.downloadToolStripMenuItem,
            this.uPLOADToolStripMenuItem,
            this.eXECUTEToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem1,
            this.pasteToolStripMenuItem,
            this.dELETEToolStripMenuItem,
            this.sevenZiplStripMenuItem1,
            this.createFolderToolStripMenuItem,
            this.openClientFolderToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(174, 312);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.backToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // rEFRESHToolStripMenuItem
            // 
            this.rEFRESHToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.rEFRESHToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.rEFRESHToolStripMenuItem.Name = "rEFRESHToolStripMenuItem";
            this.rEFRESHToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.rEFRESHToolStripMenuItem.Text = "Refresh";
            this.rEFRESHToolStripMenuItem.Click += new System.EventHandler(this.rEFRESHToolStripMenuItem_Click);
            // 
            // gOTOToolStripMenuItem
            // 
            this.gOTOToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gOTOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dESKTOPToolStripMenuItem,
            this.aPPDATAToolStripMenuItem,
            this.userProfileToolStripMenuItem,
            this.driversListsToolStripMenuItem});
            this.gOTOToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.gOTOToolStripMenuItem.Name = "gOTOToolStripMenuItem";
            this.gOTOToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.gOTOToolStripMenuItem.Text = "Go To";
            // 
            // dESKTOPToolStripMenuItem
            // 
            this.dESKTOPToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.dESKTOPToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.dESKTOPToolStripMenuItem.Name = "dESKTOPToolStripMenuItem";
            this.dESKTOPToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dESKTOPToolStripMenuItem.Text = "Desktop";
            this.dESKTOPToolStripMenuItem.Click += new System.EventHandler(this.DESKTOPToolStripMenuItem_Click);
            // 
            // aPPDATAToolStripMenuItem
            // 
            this.aPPDATAToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.aPPDATAToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aPPDATAToolStripMenuItem.Name = "aPPDATAToolStripMenuItem";
            this.aPPDATAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aPPDATAToolStripMenuItem.Text = "AppData";
            this.aPPDATAToolStripMenuItem.Click += new System.EventHandler(this.APPDATAToolStripMenuItem_Click);
            // 
            // userProfileToolStripMenuItem
            // 
            this.userProfileToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.userProfileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.userProfileToolStripMenuItem.Name = "userProfileToolStripMenuItem";
            this.userProfileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.userProfileToolStripMenuItem.Text = "User Profile";
            this.userProfileToolStripMenuItem.Click += new System.EventHandler(this.UserProfileToolStripMenuItem_Click);
            // 
            // driversListsToolStripMenuItem
            // 
            this.driversListsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.driversListsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.driversListsToolStripMenuItem.Name = "driversListsToolStripMenuItem";
            this.driversListsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.driversListsToolStripMenuItem.Text = "Drivers";
            this.driversListsToolStripMenuItem.Click += new System.EventHandler(this.DriversListsToolStripMenuItem_Click);
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.downloadToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.downloadToolStripMenuItem.Text = "Download";
            this.downloadToolStripMenuItem.Click += new System.EventHandler(this.downloadToolStripMenuItem_Click);
            // 
            // uPLOADToolStripMenuItem
            // 
            this.uPLOADToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.uPLOADToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.uPLOADToolStripMenuItem.Name = "uPLOADToolStripMenuItem";
            this.uPLOADToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.uPLOADToolStripMenuItem.Text = "Upload";
            this.uPLOADToolStripMenuItem.Click += new System.EventHandler(this.uPLOADToolStripMenuItem_Click);
            // 
            // eXECUTEToolStripMenuItem
            // 
            this.eXECUTEToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.eXECUTEToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.eXECUTEToolStripMenuItem.Name = "eXECUTEToolStripMenuItem";
            this.eXECUTEToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.eXECUTEToolStripMenuItem.Text = "Execute";
            this.eXECUTEToolStripMenuItem.Click += new System.EventHandler(this.eXECUTEToolStripMenuItem_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.renameToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.RenameToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.copyToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem1
            // 
            this.cutToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            this.cutToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
            this.cutToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.cutToolStripMenuItem1.Text = "Cut";
            this.cutToolStripMenuItem1.Click += new System.EventHandler(this.CutToolStripMenuItem1_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.pasteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click_1);
            // 
            // dELETEToolStripMenuItem
            // 
            this.dELETEToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.dELETEToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
            this.dELETEToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.dELETEToolStripMenuItem.Text = "Delete";
            this.dELETEToolStripMenuItem.Click += new System.EventHandler(this.dELETEToolStripMenuItem_Click);
            // 
            // sevenZiplStripMenuItem1
            // 
            this.sevenZiplStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.sevenZiplStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.installToolStripMenuItem,
            this.zipToolStripMenuItem,
            this.unzipToolStripMenuItem});
            this.sevenZiplStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.sevenZiplStripMenuItem1.Name = "sevenZiplStripMenuItem1";
            this.sevenZiplStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.sevenZiplStripMenuItem1.Text = "7-Zip";
            // 
            // installToolStripMenuItem
            // 
            this.installToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.installToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.installToolStripMenuItem.Name = "installToolStripMenuItem";
            this.installToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.installToolStripMenuItem.Text = "Hidden Installation";
            this.installToolStripMenuItem.Click += new System.EventHandler(this.InstallToolStripMenuItem_Click);
            // 
            // zipToolStripMenuItem
            // 
            this.zipToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.zipToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.zipToolStripMenuItem.Name = "zipToolStripMenuItem";
            this.zipToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zipToolStripMenuItem.Text = "Zip";
            this.zipToolStripMenuItem.Click += new System.EventHandler(this.ZipToolStripMenuItem_Click);
            // 
            // unzipToolStripMenuItem
            // 
            this.unzipToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.unzipToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.unzipToolStripMenuItem.Name = "unzipToolStripMenuItem";
            this.unzipToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.unzipToolStripMenuItem.Text = "Unzip";
            this.unzipToolStripMenuItem.Click += new System.EventHandler(this.UnzipToolStripMenuItem_Click);
            // 
            // createFolderToolStripMenuItem
            // 
            this.createFolderToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.createFolderToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.createFolderToolStripMenuItem.Name = "createFolderToolStripMenuItem";
            this.createFolderToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.createFolderToolStripMenuItem.Text = "Create Folder";
            this.createFolderToolStripMenuItem.Click += new System.EventHandler(this.CreateFolderToolStripMenuItem_Click);
            // 
            // openClientFolderToolStripMenuItem
            // 
            this.openClientFolderToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.openClientFolderToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.openClientFolderToolStripMenuItem.Name = "openClientFolderToolStripMenuItem";
            this.openClientFolderToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.openClientFolderToolStripMenuItem.Text = "Open Client Folder";
            this.openClientFolderToolStripMenuItem.Click += new System.EventHandler(this.OpenClientFolderToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "AsyncFolder.ico");
            this.imageList1.Images.SetKeyName(1, "AsyncHDDFixed.png");
            this.imageList1.Images.SetKeyName(2, "AsyncUSB.png");
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.Color.Gray;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 333);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(705, 21);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(13, 16);
            this.toolStripStatusLabel1.Text = "..";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(13, 16);
            this.toolStripStatusLabel2.Text = "..";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(13, 16);
            this.toolStripStatusLabel3.Text = "..";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // FormFileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 354);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormFileManager";
            this.Text = "FileManager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormFileManager_FormClosed);
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uPLOADToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEFRESHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXECUTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gOTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dESKTOPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aPPDATAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripMenuItem userProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversListsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openClientFolderToolStripMenuItem;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sevenZiplStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem installToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unzipToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}