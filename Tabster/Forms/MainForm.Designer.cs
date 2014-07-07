﻿using System.Windows.Forms;
using Tabster.Controls;
using DataGridViewExtended = Tabster.Controls.DataGridViewExtended;

namespace Tabster.Forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            this.deletePlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renamePlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.display_library = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.sidemenu = new Tabster.Controls.Sidebar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.librarySplitContainer = new System.Windows.Forms.SplitContainer();
            this.tablibrary = new Tabster.Controls.DataGridViewExtended();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblopenedexternally = new System.Windows.Forms.Label();
            this.previewToolStrip = new System.Windows.Forms.ToolStrip();
            this.lblpreviewtitle = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.detailsbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.printbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.offToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblcount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblplaylists = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.lbldisk = new System.Windows.Forms.ToolStripStatusLabel();
            this.display_search = new System.Windows.Forms.TabPage();
            this.searchSplitContainer = new System.Windows.Forms.SplitContainer();
            this.searchDisplay = new Tabster.Controls.DataGridViewExtended();
            this.searchcol_artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchcol_song = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchcol_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchcol_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSearchStatus = new System.Windows.Forms.Label();
            this.lblsearchresults = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.onlinesearchbtn = new System.Windows.Forms.Button();
            this.txtsearchartist = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsearchsong = new System.Windows.Forms.TextBox();
            this.txtsearchtype = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchPreviewEditor = new Tabster.Controls.TabEditor();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.addtolibrarybtn = new System.Windows.Forms.Button();
            this.downloadUrlsbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblprogress = new System.Windows.Forms.Label();
            this.txtDownloadURLs = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colDownloadURL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDownloadParser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDownloadStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDownloadArtist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDownloadTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDownloadType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabimagelist = new System.Windows.Forms.ImageList(this.components);
            this.SearchMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveTabToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.previewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshbtn = new System.Windows.Forms.ToolStripButton();
            this.LibraryMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.librarycontextdetails = new System.Windows.Forms.ToolStripMenuItem();
            this.librarycontextdelete = new System.Windows.Forms.ToolStripMenuItem();
            this.librarycontextexport = new System.Windows.Forms.ToolStripMenuItem();
            this.librarycontextbrowse = new System.Windows.Forms.ToolStripMenuItem();
            this.librarycontextsearch = new System.Windows.Forms.ToolStripMenuItem();
            this.librarycontextaddtoplaylist = new System.Windows.Forms.ToolStripMenuItem();
            this.librarycontextfavorites = new System.Windows.Forms.ToolStripMenuItem();
            this.PlaylistMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteplaylistcontextmenuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentlyViewedToolStripMenuItem = new Tabster.Controls.RecentToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sidebarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libraryPreviewPaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libraryhiddenpreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libraryhorizontalpreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libraryverticalpreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchPreviewPaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchhiddenpreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchhorizontalpreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchverticalpreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTabLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchUltimateGuitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearsearchbtn = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filtertext = new Tabster.Controls.SearchBox();
            this.PreviewDelay = new System.Windows.Forms.Timer(this.components);
            this.SearchPreviewBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SearchBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.DownloadBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.display_library.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.librarySplitContainer.Panel1.SuspendLayout();
            this.librarySplitContainer.Panel2.SuspendLayout();
            this.librarySplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablibrary)).BeginInit();
            this.previewToolStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.display_search.SuspendLayout();
            this.searchSplitContainer.Panel1.SuspendLayout();
            this.searchSplitContainer.Panel2.SuspendLayout();
            this.searchSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchDisplay)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SearchMenu.SuspendLayout();
            this.LibraryMenu.SuspendLayout();
            this.PlaylistMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deletePlaylistToolStripMenuItem
            // 
            this.deletePlaylistToolStripMenuItem.Name = "deletePlaylistToolStripMenuItem";
            this.deletePlaylistToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.deletePlaylistToolStripMenuItem.Text = "Delete Playlist";
            // 
            // renamePlaylistToolStripMenuItem
            // 
            this.renamePlaylistToolStripMenuItem.Name = "renamePlaylistToolStripMenuItem";
            this.renamePlaylistToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.renamePlaylistToolStripMenuItem.Text = "Rename Playlist";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.display_library);
            this.tabControl1.Controls.Add(this.display_search);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.tabimagelist;
            this.tabControl1.ItemSize = new System.Drawing.Size(80, 20);
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(15, 4);
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1034, 521);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // display_library
            // 
            this.display_library.BackColor = System.Drawing.SystemColors.Control;
            this.display_library.Controls.Add(this.splitContainer1);
            this.display_library.ImageIndex = 0;
            this.display_library.Location = new System.Drawing.Point(4, 24);
            this.display_library.Name = "display_library";
            this.display_library.Size = new System.Drawing.Size(1026, 493);
            this.display_library.TabIndex = 1;
            this.display_library.Text = "Library";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.sidemenu);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel1MinSize = 140;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.librarySplitContainer);
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel2MinSize = 0;
            this.splitContainer1.Size = new System.Drawing.Size(1026, 493);
            this.splitContainer1.SplitterDistance = 140;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 9;
            // 
            // sidemenu
            // 
            this.sidemenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidemenu.Location = new System.Drawing.Point(0, 0);
            this.sidemenu.Name = "sidemenu";
            this.sidemenu.Size = new System.Drawing.Size(140, 409);
            this.sidemenu.TabIndex = 0;
            this.sidemenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.sidemenu_AfterSelect);
            this.sidemenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sidemenu_MouseClick);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 409);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(140, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "New Tab...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NewTab);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 437);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(140, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "New Playlist...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.NewPlaylist);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 465);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(140, 28);
            this.button3.TabIndex = 3;
            this.button3.Text = "Browse...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BrowseTab);
            // 
            // librarySplitContainer
            // 
            this.librarySplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.librarySplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.librarySplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.librarySplitContainer.Location = new System.Drawing.Point(0, 0);
            this.librarySplitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.librarySplitContainer.Name = "librarySplitContainer";
            this.librarySplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // librarySplitContainer.Panel1
            // 
            this.librarySplitContainer.Panel1.Controls.Add(this.tablibrary);
            this.librarySplitContainer.Panel1MinSize = 140;
            // 
            // librarySplitContainer.Panel2
            // 
            this.librarySplitContainer.Panel2.Controls.Add(this.lblopenedexternally);
            this.librarySplitContainer.Panel2.Controls.Add(this.previewToolStrip);
            this.librarySplitContainer.Panel2MinSize = 140;
            this.librarySplitContainer.Size = new System.Drawing.Size(885, 470);
            this.librarySplitContainer.SplitterDistance = 276;
            this.librarySplitContainer.TabIndex = 25;
            // 
            // tablibrary
            // 
            this.tablibrary.AllowDrop = true;
            this.tablibrary.AllowUserToAddRows = false;
            this.tablibrary.AllowUserToDeleteRows = false;
            this.tablibrary.AllowUserToResizeColumns = false;
            this.tablibrary.AllowUserToResizeRows = false;
            this.tablibrary.BackgroundColor = System.Drawing.SystemColors.Window;
            this.tablibrary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablibrary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.tablibrary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablibrary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.title,
            this.artist,
            this.type,
            this.date,
            this.size,
            this.location});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablibrary.DefaultCellStyle = dataGridViewCellStyle15;
            this.tablibrary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablibrary.GridColor = System.Drawing.SystemColors.ControlLight;
            this.tablibrary.Location = new System.Drawing.Point(0, 0);
            this.tablibrary.MultiSelect = false;
            this.tablibrary.Name = "tablibrary";
            this.tablibrary.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablibrary.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.tablibrary.RowHeadersVisible = false;
            this.tablibrary.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            this.tablibrary.RowsDefaultCellStyle = dataGridViewCellStyle17;
            this.tablibrary.RowTemplate.Height = 18;
            this.tablibrary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablibrary.ShowCellErrors = false;
            this.tablibrary.ShowCellToolTips = false;
            this.tablibrary.ShowEditingIcon = false;
            this.tablibrary.ShowRowErrors = false;
            this.tablibrary.Size = new System.Drawing.Size(883, 274);
            this.tablibrary.TabIndex = 19;
            this.tablibrary.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewExtended2_CellDoubleClick);
            this.tablibrary.SelectionChanged += new System.EventHandler(this.dataGridViewExtended2_SelectionChanged);
            this.tablibrary.DragDrop += new System.Windows.Forms.DragEventHandler(this.tablibrary_DragDrop);
            this.tablibrary.DragEnter += new System.Windows.Forms.DragEventHandler(this.tablibrary_DragEnter);
            this.tablibrary.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tablibrary_MouseClick);
            // 
            // title
            // 
            this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.title.HeaderText = "Title";
            this.title.MinimumWidth = 250;
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Width = 250;
            // 
            // artist
            // 
            this.artist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.artist.HeaderText = "Artist";
            this.artist.MinimumWidth = 150;
            this.artist.Name = "artist";
            this.artist.ReadOnly = true;
            this.artist.Width = 150;
            // 
            // type
            // 
            this.type.HeaderText = "Type";
            this.type.MinimumWidth = 65;
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle13.Format = "d";
            dataGridViewCellStyle13.NullValue = null;
            this.date.DefaultCellStyle = dataGridViewCellStyle13;
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 65;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 65;
            // 
            // size
            // 
            this.size.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle14.Format = "N0";
            dataGridViewCellStyle14.NullValue = null;
            this.size.DefaultCellStyle = dataGridViewCellStyle14;
            this.size.HeaderText = "Size";
            this.size.MinimumWidth = 65;
            this.size.Name = "size";
            this.size.ReadOnly = true;
            this.size.Width = 65;
            // 
            // location
            // 
            this.location.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.location.HeaderText = "Location";
            this.location.MinimumWidth = 65;
            this.location.Name = "location";
            this.location.ReadOnly = true;
            // 
            // lblopenedexternally
            // 
            this.lblopenedexternally.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblopenedexternally.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblopenedexternally.Location = new System.Drawing.Point(0, 25);
            this.lblopenedexternally.Name = "lblopenedexternally";
            this.lblopenedexternally.Size = new System.Drawing.Size(883, 163);
            this.lblopenedexternally.TabIndex = 24;
            this.lblopenedexternally.Text = "Tab is open in external viewer.";
            this.lblopenedexternally.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblopenedexternally.Visible = false;
            // 
            // previewToolStrip
            // 
            this.previewToolStrip.Enabled = false;
            this.previewToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.previewToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblpreviewtitle,
            this.toolStripButton1,
            this.toolStripSeparator4,
            this.detailsbtn,
            this.toolStripSeparator5,
            this.printbtn,
            this.toolStripSeparator8,
            this.toolStripButton3});
            this.previewToolStrip.Location = new System.Drawing.Point(0, 0);
            this.previewToolStrip.Name = "previewToolStrip";
            this.previewToolStrip.Padding = new System.Windows.Forms.Padding(0);
            this.previewToolStrip.Size = new System.Drawing.Size(883, 25);
            this.previewToolStrip.TabIndex = 23;
            // 
            // lblpreviewtitle
            // 
            this.lblpreviewtitle.Name = "lblpreviewtitle";
            this.lblpreviewtitle.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.Image = global::Tabster.Properties.Resources.arrow_out;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(71, 22);
            this.toolStripButton1.Text = "Pop Out";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // detailsbtn
            // 
            this.detailsbtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.detailsbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.detailsbtn.Image = ((System.Drawing.Image)(resources.GetObject("detailsbtn.Image")));
            this.detailsbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.detailsbtn.Name = "detailsbtn";
            this.detailsbtn.Size = new System.Drawing.Size(85, 22);
            this.detailsbtn.Text = "Tab Details";
            this.detailsbtn.Click += new System.EventHandler(this.TabDetails);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // printbtn
            // 
            this.printbtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.printbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.printbtn.Image = global::Tabster.Properties.Resources.printer;
            this.printbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printbtn.Name = "printbtn";
            this.printbtn.Size = new System.Drawing.Size(52, 22);
            this.printbtn.Text = "Print";
            this.printbtn.Click += new System.EventHandler(this.printbtn_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.offToolStripMenuItem,
            this.onToolStripMenuItem});
            this.toolStripButton3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(96, 22);
            this.toolStripButton3.Text = "Auto-Scroll";
            // 
            // offToolStripMenuItem
            // 
            this.offToolStripMenuItem.Checked = true;
            this.offToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.offToolStripMenuItem.Name = "offToolStripMenuItem";
            this.offToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.offToolStripMenuItem.Text = "Off";
            this.offToolStripMenuItem.Click += new System.EventHandler(this.autoScrollChange);
            // 
            // onToolStripMenuItem
            // 
            this.onToolStripMenuItem.Name = "onToolStripMenuItem";
            this.onToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.onToolStripMenuItem.Text = "On";
            this.onToolStripMenuItem.Click += new System.EventHandler(this.autoScrollChange);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblcount,
            this.toolStripSeparator2,
            this.lblplaylists,
            this.toolStripSeparator3,
            this.lbldisk});
            this.statusStrip1.Location = new System.Drawing.Point(0, 470);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(885, 23);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblcount
            // 
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(74, 18);
            this.lblcount.Text = "Total Tabs: 0";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // lblplaylists
            // 
            this.lblplaylists.Name = "lblplaylists";
            this.lblplaylists.Size = new System.Drawing.Size(61, 18);
            this.lblplaylists.Text = "Playlists: 0";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // lbldisk
            // 
            this.lbldisk.Name = "lbldisk";
            this.lbldisk.Size = new System.Drawing.Size(124, 18);
            this.lbldisk.Text = "Disk Space: 0KB (0MB)";
            // 
            // display_search
            // 
            this.display_search.BackColor = System.Drawing.SystemColors.Control;
            this.display_search.Controls.Add(this.searchSplitContainer);
            this.display_search.ImageIndex = 1;
            this.display_search.Location = new System.Drawing.Point(4, 24);
            this.display_search.Name = "display_search";
            this.display_search.Size = new System.Drawing.Size(1026, 493);
            this.display_search.TabIndex = 5;
            this.display_search.Text = "Search";
            // 
            // searchSplitContainer
            // 
            this.searchSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.searchSplitContainer.Name = "searchSplitContainer";
            this.searchSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // searchSplitContainer.Panel1
            // 
            this.searchSplitContainer.Panel1.Controls.Add(this.searchDisplay);
            this.searchSplitContainer.Panel1.Controls.Add(this.panel1);
            this.searchSplitContainer.Panel1MinSize = 200;
            // 
            // searchSplitContainer.Panel2
            // 
            this.searchSplitContainer.Panel2.Controls.Add(this.searchPreviewEditor);
            this.searchSplitContainer.Panel2Collapsed = true;
            this.searchSplitContainer.Panel2MinSize = 100;
            this.searchSplitContainer.Size = new System.Drawing.Size(1026, 493);
            this.searchSplitContainer.SplitterDistance = 200;
            this.searchSplitContainer.TabIndex = 29;
            // 
            // searchDisplay
            // 
            this.searchDisplay.AllowDrop = true;
            this.searchDisplay.AllowUserToAddRows = false;
            this.searchDisplay.AllowUserToDeleteRows = false;
            this.searchDisplay.AllowUserToResizeColumns = false;
            this.searchDisplay.AllowUserToResizeRows = false;
            this.searchDisplay.BackgroundColor = System.Drawing.Color.White;
            this.searchDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchDisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.searchDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.searchDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.searchcol_artist,
            this.searchcol_song,
            this.searchcol_type,
            this.col_rating,
            this.searchcol_service});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.searchDisplay.DefaultCellStyle = dataGridViewCellStyle20;
            this.searchDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchDisplay.GridColor = System.Drawing.SystemColors.ControlLight;
            this.searchDisplay.Location = new System.Drawing.Point(0, 31);
            this.searchDisplay.MultiSelect = false;
            this.searchDisplay.Name = "searchDisplay";
            this.searchDisplay.ReadOnly = true;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchDisplay.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.searchDisplay.RowHeadersVisible = false;
            this.searchDisplay.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Black;
            this.searchDisplay.RowsDefaultCellStyle = dataGridViewCellStyle22;
            this.searchDisplay.RowTemplate.Height = 18;
            this.searchDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.searchDisplay.ShowCellErrors = false;
            this.searchDisplay.ShowCellToolTips = false;
            this.searchDisplay.ShowEditingIcon = false;
            this.searchDisplay.ShowRowErrors = false;
            this.searchDisplay.Size = new System.Drawing.Size(1024, 460);
            this.searchDisplay.TabIndex = 20;
            this.searchDisplay.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SaveSelectedTab);
            this.searchDisplay.SelectionChanged += new System.EventHandler(this.dataGridViewExtended1_SelectionChanged);
            this.searchDisplay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewExtended1_MouseClick);
            // 
            // searchcol_artist
            // 
            this.searchcol_artist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.searchcol_artist.HeaderText = "Artist";
            this.searchcol_artist.Name = "searchcol_artist";
            this.searchcol_artist.ReadOnly = true;
            this.searchcol_artist.Width = 185;
            // 
            // searchcol_song
            // 
            this.searchcol_song.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.searchcol_song.HeaderText = "Song";
            this.searchcol_song.Name = "searchcol_song";
            this.searchcol_song.ReadOnly = true;
            this.searchcol_song.Width = 225;
            // 
            // searchcol_type
            // 
            this.searchcol_type.HeaderText = "Type";
            this.searchcol_type.Name = "searchcol_type";
            this.searchcol_type.ReadOnly = true;
            // 
            // col_rating
            // 
            this.col_rating.HeaderText = "Rating";
            this.col_rating.Name = "col_rating";
            this.col_rating.ReadOnly = true;
            // 
            // searchcol_service
            // 
            this.searchcol_service.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle19.Format = "N0";
            this.searchcol_service.DefaultCellStyle = dataGridViewCellStyle19;
            this.searchcol_service.HeaderText = "Service";
            this.searchcol_service.Name = "searchcol_service";
            this.searchcol_service.ReadOnly = true;
            this.searchcol_service.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lblSearchStatus);
            this.panel1.Controls.Add(this.lblsearchresults);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.onlinesearchbtn);
            this.panel1.Controls.Add(this.txtsearchartist);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtsearchsong);
            this.panel1.Controls.Add(this.txtsearchtype);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 31);
            this.panel1.TabIndex = 28;
            // 
            // lblSearchStatus
            // 
            this.lblSearchStatus.AutoSize = true;
            this.lblSearchStatus.Location = new System.Drawing.Point(591, 8);
            this.lblSearchStatus.Name = "lblSearchStatus";
            this.lblSearchStatus.Size = new System.Drawing.Size(64, 13);
            this.lblSearchStatus.TabIndex = 31;
            this.lblSearchStatus.Text = "Searching...";
            this.lblSearchStatus.Visible = false;
            // 
            // lblsearchresults
            // 
            this.lblsearchresults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblsearchresults.AutoSize = true;
            this.lblsearchresults.Location = new System.Drawing.Point(943, 8);
            this.lblsearchresults.Name = "lblsearchresults";
            this.lblsearchresults.Size = new System.Drawing.Size(54, 13);
            this.lblsearchresults.TabIndex = 30;
            this.lblsearchresults.Text = "Results: 0";
            this.lblsearchresults.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(567, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(5, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Artist:";
            // 
            // onlinesearchbtn
            // 
            this.onlinesearchbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.onlinesearchbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.onlinesearchbtn.Location = new System.Drawing.Point(486, 3);
            this.onlinesearchbtn.Name = "onlinesearchbtn";
            this.onlinesearchbtn.Size = new System.Drawing.Size(75, 23);
            this.onlinesearchbtn.TabIndex = 27;
            this.onlinesearchbtn.Text = "Search";
            this.onlinesearchbtn.UseVisualStyleBackColor = true;
            this.onlinesearchbtn.Click += new System.EventHandler(this.onlinesearchbtn_Click);
            // 
            // txtsearchartist
            // 
            this.txtsearchartist.BackColor = System.Drawing.SystemColors.Window;
            this.txtsearchartist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsearchartist.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtsearchartist.Location = new System.Drawing.Point(44, 5);
            this.txtsearchartist.Name = "txtsearchartist";
            this.txtsearchartist.Size = new System.Drawing.Size(124, 20);
            this.txtsearchartist.TabIndex = 21;
            this.txtsearchartist.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsearchartist_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(345, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Type:";
            // 
            // txtsearchsong
            // 
            this.txtsearchsong.BackColor = System.Drawing.SystemColors.Window;
            this.txtsearchsong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsearchsong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtsearchsong.Location = new System.Drawing.Point(215, 5);
            this.txtsearchsong.Name = "txtsearchsong";
            this.txtsearchsong.Size = new System.Drawing.Size(124, 20);
            this.txtsearchsong.TabIndex = 22;
            this.txtsearchsong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsearchartist_KeyDown);
            // 
            // txtsearchtype
            // 
            this.txtsearchtype.BackColor = System.Drawing.SystemColors.Window;
            this.txtsearchtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtsearchtype.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtsearchtype.FormattingEnabled = true;
            this.txtsearchtype.ItemHeight = 13;
            this.txtsearchtype.Location = new System.Drawing.Point(385, 5);
            this.txtsearchtype.Name = "txtsearchtype";
            this.txtsearchtype.Size = new System.Drawing.Size(95, 21);
            this.txtsearchtype.TabIndex = 23;
            this.txtsearchtype.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsearchartist_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(174, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Song:";
            // 
            // searchPreviewEditor
            // 
            this.searchPreviewEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchPreviewEditor.Location = new System.Drawing.Point(0, 0);
            this.searchPreviewEditor.Margin = new System.Windows.Forms.Padding(0);
            this.searchPreviewEditor.Name = "searchPreviewEditor";
            this.searchPreviewEditor.ReadOnly = false;
            this.searchPreviewEditor.Size = new System.Drawing.Size(148, 23);
            this.searchPreviewEditor.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.addtolibrarybtn);
            this.tabPage1.Controls.Add(this.downloadUrlsbtn);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.lblprogress);
            this.tabPage1.Controls.Add(this.txtDownloadURLs);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.ImageIndex = 2;
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1026, 493);
            this.tabPage1.TabIndex = 6;
            this.tabPage1.Text = "Download";
            // 
            // addtolibrarybtn
            // 
            this.addtolibrarybtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addtolibrarybtn.Enabled = false;
            this.addtolibrarybtn.Location = new System.Drawing.Point(891, 462);
            this.addtolibrarybtn.Name = "addtolibrarybtn";
            this.addtolibrarybtn.Size = new System.Drawing.Size(127, 23);
            this.addtolibrarybtn.TabIndex = 19;
            this.addtolibrarybtn.Text = "Add to Library";
            this.addtolibrarybtn.UseVisualStyleBackColor = true;
            this.addtolibrarybtn.Click += new System.EventHandler(this.addtolibrarybtn_Click);
            // 
            // downloadUrlsbtn
            // 
            this.downloadUrlsbtn.Enabled = false;
            this.downloadUrlsbtn.Location = new System.Drawing.Point(602, 173);
            this.downloadUrlsbtn.Name = "downloadUrlsbtn";
            this.downloadUrlsbtn.Size = new System.Drawing.Size(127, 23);
            this.downloadUrlsbtn.TabIndex = 12;
            this.downloadUrlsbtn.Text = "Begin Download";
            this.downloadUrlsbtn.UseVisualStyleBackColor = true;
            this.downloadUrlsbtn.Click += new System.EventHandler(this.downloadUrlsbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Enter URLs (one per line) to scrape and parse.";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressBar1.Location = new System.Drawing.Point(8, 387);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(588, 14);
            this.progressBar1.TabIndex = 14;
            this.progressBar1.Visible = false;
            // 
            // lblprogress
            // 
            this.lblprogress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblprogress.AutoSize = true;
            this.lblprogress.Location = new System.Drawing.Point(8, 371);
            this.lblprogress.Name = "lblprogress";
            this.lblprogress.Size = new System.Drawing.Size(35, 13);
            this.lblprogress.TabIndex = 13;
            this.lblprogress.Text = "label1";
            this.lblprogress.Visible = false;
            // 
            // txtDownloadURLs
            // 
            this.txtDownloadURLs.Location = new System.Drawing.Point(8, 30);
            this.txtDownloadURLs.Multiline = true;
            this.txtDownloadURLs.Name = "txtDownloadURLs";
            this.txtDownloadURLs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDownloadURLs.Size = new System.Drawing.Size(588, 166);
            this.txtDownloadURLs.TabIndex = 11;
            this.txtDownloadURLs.TextChanged += new System.EventHandler(this.txtDownloadURLs_TextChanged);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDownloadURL,
            this.colDownloadParser,
            this.colDownloadStatus,
            this.colDownloadArtist,
            this.colDownloadTitle,
            this.colDownloadType});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(8, 202);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1010, 166);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colDownloadURL
            // 
            this.colDownloadURL.Text = "URL";
            this.colDownloadURL.Width = 271;
            // 
            // colDownloadParser
            // 
            this.colDownloadParser.Text = "Parser";
            this.colDownloadParser.Width = 133;
            // 
            // colDownloadStatus
            // 
            this.colDownloadStatus.Text = "Status";
            this.colDownloadStatus.Width = 132;
            // 
            // colDownloadArtist
            // 
            this.colDownloadArtist.Text = "Artist";
            this.colDownloadArtist.Width = 162;
            // 
            // colDownloadTitle
            // 
            this.colDownloadTitle.Text = "Title";
            this.colDownloadTitle.Width = 180;
            // 
            // colDownloadType
            // 
            this.colDownloadType.Text = "Type";
            this.colDownloadType.Width = 101;
            // 
            // tabimagelist
            // 
            this.tabimagelist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tabimagelist.ImageStream")));
            this.tabimagelist.TransparentColor = System.Drawing.Color.Transparent;
            this.tabimagelist.Images.SetKeyName(0, "application_view_detail.png");
            this.tabimagelist.Images.SetKeyName(1, "search_plus.png");
            this.tabimagelist.Images.SetKeyName(2, "download.png");
            // 
            // SearchMenu
            // 
            this.SearchMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveTabToolStripMenuItem1,
            this.previewToolStripMenuItem,
            this.copyURLToolStripMenuItem});
            this.SearchMenu.Name = "librarycontextmenu";
            this.SearchMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.SearchMenu.ShowImageMargin = false;
            this.SearchMenu.ShowItemToolTips = false;
            this.SearchMenu.Size = new System.Drawing.Size(102, 70);
            // 
            // saveTabToolStripMenuItem1
            // 
            this.saveTabToolStripMenuItem1.Enabled = false;
            this.saveTabToolStripMenuItem1.Name = "saveTabToolStripMenuItem1";
            this.saveTabToolStripMenuItem1.Size = new System.Drawing.Size(101, 22);
            this.saveTabToolStripMenuItem1.Text = "Save Tab";
            this.saveTabToolStripMenuItem1.Click += new System.EventHandler(this.SaveSelectedTab);
            // 
            // previewToolStripMenuItem
            // 
            this.previewToolStripMenuItem.Name = "previewToolStripMenuItem";
            this.previewToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.previewToolStripMenuItem.Text = "Preview";
            this.previewToolStripMenuItem.Click += new System.EventHandler(this.previewToolStripMenuItem_Click);
            // 
            // copyURLToolStripMenuItem
            // 
            this.copyURLToolStripMenuItem.Name = "copyURLToolStripMenuItem";
            this.copyURLToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.copyURLToolStripMenuItem.Text = "Copy URL";
            this.copyURLToolStripMenuItem.Click += new System.EventHandler(this.copyURLToolStripMenuItem_Click);
            // 
            // refreshbtn
            // 
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(23, 20);
            // 
            // LibraryMenu
            // 
            this.LibraryMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.librarycontextdetails,
            this.librarycontextdelete,
            this.librarycontextexport,
            this.librarycontextbrowse,
            this.librarycontextsearch,
            this.librarycontextaddtoplaylist,
            this.librarycontextfavorites});
            this.LibraryMenu.Name = "contextMenuStrip1";
            this.LibraryMenu.ShowImageMargin = false;
            this.LibraryMenu.ShowItemToolTips = false;
            this.LibraryMenu.Size = new System.Drawing.Size(152, 158);
            // 
            // librarycontextdetails
            // 
            this.librarycontextdetails.Name = "librarycontextdetails";
            this.librarycontextdetails.Size = new System.Drawing.Size(151, 22);
            this.librarycontextdetails.Text = "Details...";
            this.librarycontextdetails.Click += new System.EventHandler(this.TabDetails);
            // 
            // librarycontextdelete
            // 
            this.librarycontextdelete.Name = "librarycontextdelete";
            this.librarycontextdelete.Size = new System.Drawing.Size(151, 22);
            this.librarycontextdelete.Text = "Delete";
            this.librarycontextdelete.Click += new System.EventHandler(this.DeleteTab);
            // 
            // librarycontextexport
            // 
            this.librarycontextexport.Name = "librarycontextexport";
            this.librarycontextexport.Size = new System.Drawing.Size(151, 22);
            this.librarycontextexport.Text = "Export";
            this.librarycontextexport.Click += new System.EventHandler(this.ExportTab);
            // 
            // librarycontextbrowse
            // 
            this.librarycontextbrowse.Name = "librarycontextbrowse";
            this.librarycontextbrowse.Size = new System.Drawing.Size(151, 22);
            this.librarycontextbrowse.Text = "Open Tab Location";
            this.librarycontextbrowse.Click += new System.EventHandler(this.OpenTabLocation);
            // 
            // librarycontextsearch
            // 
            this.librarycontextsearch.Name = "librarycontextsearch";
            this.librarycontextsearch.Size = new System.Drawing.Size(151, 22);
            this.librarycontextsearch.Text = "Search Similar Tabs";
            this.librarycontextsearch.Click += new System.EventHandler(this.SearchSimilarTabs);
            // 
            // librarycontextaddtoplaylist
            // 
            this.librarycontextaddtoplaylist.Name = "librarycontextaddtoplaylist";
            this.librarycontextaddtoplaylist.Size = new System.Drawing.Size(151, 22);
            this.librarycontextaddtoplaylist.Text = "Add to Playlist...";
            // 
            // librarycontextfavorites
            // 
            this.librarycontextfavorites.Name = "librarycontextfavorites";
            this.librarycontextfavorites.Size = new System.Drawing.Size(151, 22);
            this.librarycontextfavorites.Text = "Add to Favorites...";
            this.librarycontextfavorites.Click += new System.EventHandler(this.ToggleFavorite);
            // 
            // PlaylistMenu
            // 
            this.PlaylistMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteplaylistcontextmenuitem,
            this.playlistInformationToolStripMenuItem});
            this.PlaylistMenu.Name = "librarycontextmenu";
            this.PlaylistMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.PlaylistMenu.ShowImageMargin = false;
            this.PlaylistMenu.ShowItemToolTips = false;
            this.PlaylistMenu.Size = new System.Drawing.Size(153, 48);
            // 
            // deleteplaylistcontextmenuitem
            // 
            this.deleteplaylistcontextmenuitem.Name = "deleteplaylistcontextmenuitem";
            this.deleteplaylistcontextmenuitem.Size = new System.Drawing.Size(152, 22);
            this.deleteplaylistcontextmenuitem.Text = "Delete Playlist";
            this.deleteplaylistcontextmenuitem.Click += new System.EventHandler(this.DeletePlaylist);
            // 
            // playlistInformationToolStripMenuItem
            // 
            this.playlistInformationToolStripMenuItem.Name = "playlistInformationToolStripMenuItem";
            this.playlistInformationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.playlistInformationToolStripMenuItem.Text = "Playlist Information";
            this.playlistInformationToolStripMenuItem.Click += new System.EventHandler(this.PlaylistDetails);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTabToolStripMenuItem,
            this.newPlaylistToolStripMenuItem,
            this.openTabToolStripMenuItem,
            this.recentlyViewedToolStripMenuItem,
            this.importToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newTabToolStripMenuItem
            // 
            this.newTabToolStripMenuItem.Name = "newTabToolStripMenuItem";
            this.newTabToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newTabToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.newTabToolStripMenuItem.Text = "&New Tab...";
            this.newTabToolStripMenuItem.Click += new System.EventHandler(this.NewTab);
            // 
            // newPlaylistToolStripMenuItem
            // 
            this.newPlaylistToolStripMenuItem.Name = "newPlaylistToolStripMenuItem";
            this.newPlaylistToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.newPlaylistToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.newPlaylistToolStripMenuItem.Text = "New &Playlist";
            this.newPlaylistToolStripMenuItem.Click += new System.EventHandler(this.NewPlaylist);
            // 
            // openTabToolStripMenuItem
            // 
            this.openTabToolStripMenuItem.Name = "openTabToolStripMenuItem";
            this.openTabToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openTabToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.openTabToolStripMenuItem.Text = "&Open...";
            this.openTabToolStripMenuItem.Click += new System.EventHandler(this.BrowseTab);
            // 
            // recentlyViewedToolStripMenuItem
            // 
            this.recentlyViewedToolStripMenuItem.Enabled = false;
            this.recentlyViewedToolStripMenuItem.FilePath = null;
            this.recentlyViewedToolStripMenuItem.MaxItems = 10;
            this.recentlyViewedToolStripMenuItem.Name = "recentlyViewedToolStripMenuItem";
            this.recentlyViewedToolStripMenuItem.ShowClear = true;
            this.recentlyViewedToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.recentlyViewedToolStripMenuItem.Text = "Open Recent";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.importToolStripMenuItem.Text = "Import...";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sidebarToolStripMenuItem,
            this.statusBarToolStripMenuItem,
            this.libraryPreviewPaneToolStripMenuItem,
            this.searchPreviewPaneToolStripMenuItem});
            this.viewToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // sidebarToolStripMenuItem
            // 
            this.sidebarToolStripMenuItem.Name = "sidebarToolStripMenuItem";
            this.sidebarToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.sidebarToolStripMenuItem.Text = "Sidebar";
            this.sidebarToolStripMenuItem.Click += new System.EventHandler(this.sidebarToolStripMenuItem_Click);
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.statusBarToolStripMenuItem.Text = "Status Bar";
            this.statusBarToolStripMenuItem.Click += new System.EventHandler(this.statusBarToolStripMenuItem_Click);
            // 
            // libraryPreviewPaneToolStripMenuItem
            // 
            this.libraryPreviewPaneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.libraryhiddenpreviewToolStripMenuItem,
            this.libraryhorizontalpreviewToolStripMenuItem,
            this.libraryverticalpreviewToolStripMenuItem});
            this.libraryPreviewPaneToolStripMenuItem.Name = "libraryPreviewPaneToolStripMenuItem";
            this.libraryPreviewPaneToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.libraryPreviewPaneToolStripMenuItem.Text = "Library Preview Pane";
            // 
            // libraryhiddenpreviewToolStripMenuItem
            // 
            this.libraryhiddenpreviewToolStripMenuItem.Name = "libraryhiddenpreviewToolStripMenuItem";
            this.libraryhiddenpreviewToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.libraryhiddenpreviewToolStripMenuItem.Text = "Hidden";
            this.libraryhiddenpreviewToolStripMenuItem.Click += new System.EventHandler(this.TogglePreviewPane);
            // 
            // libraryhorizontalpreviewToolStripMenuItem
            // 
            this.libraryhorizontalpreviewToolStripMenuItem.Name = "libraryhorizontalpreviewToolStripMenuItem";
            this.libraryhorizontalpreviewToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.libraryhorizontalpreviewToolStripMenuItem.Text = "Horizontal";
            this.libraryhorizontalpreviewToolStripMenuItem.Click += new System.EventHandler(this.TogglePreviewPane);
            // 
            // libraryverticalpreviewToolStripMenuItem
            // 
            this.libraryverticalpreviewToolStripMenuItem.Name = "libraryverticalpreviewToolStripMenuItem";
            this.libraryverticalpreviewToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.libraryverticalpreviewToolStripMenuItem.Text = "Vertical";
            this.libraryverticalpreviewToolStripMenuItem.Click += new System.EventHandler(this.TogglePreviewPane);
            // 
            // searchPreviewPaneToolStripMenuItem
            // 
            this.searchPreviewPaneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchhiddenpreviewToolStripMenuItem,
            this.searchhorizontalpreviewToolStripMenuItem,
            this.searchverticalpreviewToolStripMenuItem});
            this.searchPreviewPaneToolStripMenuItem.Name = "searchPreviewPaneToolStripMenuItem";
            this.searchPreviewPaneToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.searchPreviewPaneToolStripMenuItem.Text = "Search Preview Pane";
            // 
            // searchhiddenpreviewToolStripMenuItem
            // 
            this.searchhiddenpreviewToolStripMenuItem.Name = "searchhiddenpreviewToolStripMenuItem";
            this.searchhiddenpreviewToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.searchhiddenpreviewToolStripMenuItem.Text = "Hidden";
            this.searchhiddenpreviewToolStripMenuItem.Click += new System.EventHandler(this.TogglePreviewPane);
            // 
            // searchhorizontalpreviewToolStripMenuItem
            // 
            this.searchhorizontalpreviewToolStripMenuItem.Name = "searchhorizontalpreviewToolStripMenuItem";
            this.searchhorizontalpreviewToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.searchhorizontalpreviewToolStripMenuItem.Text = "Horizontal";
            this.searchhorizontalpreviewToolStripMenuItem.Click += new System.EventHandler(this.TogglePreviewPane);
            // 
            // searchverticalpreviewToolStripMenuItem
            // 
            this.searchverticalpreviewToolStripMenuItem.Name = "searchverticalpreviewToolStripMenuItem";
            this.searchverticalpreviewToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.searchverticalpreviewToolStripMenuItem.Text = "Vertical";
            this.searchverticalpreviewToolStripMenuItem.Click += new System.EventHandler(this.TogglePreviewPane);
            // 
            // libraryToolStripMenuItem
            // 
            this.libraryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewTabToolStripMenuItem,
            this.deleteTabToolStripMenuItem,
            this.detailsToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.openTabLocationToolStripMenuItem,
            this.searchUltimateGuitarToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.libraryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.libraryToolStripMenuItem.Name = "libraryToolStripMenuItem";
            this.libraryToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.libraryToolStripMenuItem.Text = "&Library";
            // 
            // viewTabToolStripMenuItem
            // 
            this.viewTabToolStripMenuItem.Enabled = false;
            this.viewTabToolStripMenuItem.Name = "viewTabToolStripMenuItem";
            this.viewTabToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.viewTabToolStripMenuItem.Text = "View Tab";
            this.viewTabToolStripMenuItem.Click += new System.EventHandler(this.viewTabToolStripMenuItem_Click);
            // 
            // deleteTabToolStripMenuItem
            // 
            this.deleteTabToolStripMenuItem.Enabled = false;
            this.deleteTabToolStripMenuItem.Name = "deleteTabToolStripMenuItem";
            this.deleteTabToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteTabToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.deleteTabToolStripMenuItem.Text = "Delete";
            this.deleteTabToolStripMenuItem.Click += new System.EventHandler(this.DeleteTab);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Enabled = false;
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.detailsToolStripMenuItem.Text = "Details";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.TabDetails);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Enabled = false;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.ExportTab);
            // 
            // openTabLocationToolStripMenuItem
            // 
            this.openTabLocationToolStripMenuItem.Enabled = false;
            this.openTabLocationToolStripMenuItem.Name = "openTabLocationToolStripMenuItem";
            this.openTabLocationToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.openTabLocationToolStripMenuItem.Text = "Open Tab Location";
            this.openTabLocationToolStripMenuItem.Click += new System.EventHandler(this.OpenTabLocation);
            // 
            // searchUltimateGuitarToolStripMenuItem
            // 
            this.searchUltimateGuitarToolStripMenuItem.Enabled = false;
            this.searchUltimateGuitarToolStripMenuItem.Name = "searchUltimateGuitarToolStripMenuItem";
            this.searchUltimateGuitarToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.searchUltimateGuitarToolStripMenuItem.Text = "Search Similar Tabs";
            this.searchUltimateGuitarToolStripMenuItem.Click += new System.EventHandler(this.SearchSimilarTabs);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.searchToolStripMenuItem.Text = "Search Library";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem});
            this.toolsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkForUpdatesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for Updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // clearsearchbtn
            // 
            this.clearsearchbtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.clearsearchbtn.AutoSize = false;
            this.clearsearchbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.clearsearchbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearsearchbtn.Margin = new System.Windows.Forms.Padding(-5, 0, 0, 0);
            this.clearsearchbtn.Name = "clearsearchbtn";
            this.clearsearchbtn.Size = new System.Drawing.Size(10, 17);
            this.clearsearchbtn.Text = "x";
            this.clearsearchbtn.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.libraryToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.clearsearchbtn,
            this.filtertext});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1034, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filtertext
            // 
            this.filtertext.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.filtertext.AutoSize = false;
            this.filtertext.BackColor = System.Drawing.SystemColors.Window;
            this.filtertext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filtertext.ClearButton = this.clearsearchbtn;
            this.filtertext.DefaultText = " Search Library";
            this.filtertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.filtertext.ForeColor = System.Drawing.Color.Gray;
            this.filtertext.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.filtertext.Name = "filtertext";
            this.filtertext.Size = new System.Drawing.Size(130, 20);
            this.filtertext.Text = " Search Library";
            this.filtertext.ToolTipText = "Filter through servers by name.";
            this.filtertext.OnNewSearch += new Tabster.Controls.SearchBox.NewSearchHandler(this.filtertext_OnNewSearch);
            // 
            // PreviewDelay
            // 
            this.PreviewDelay.Enabled = true;
            this.PreviewDelay.Tick += new System.EventHandler(this.PreviewDelay_Tick);
            // 
            // SearchPreviewBackgroundWorker
            // 
            this.SearchPreviewBackgroundWorker.WorkerSupportsCancellation = true;
            this.SearchPreviewBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SearchPreviewBackgroundWorker_DoWork);
            this.SearchPreviewBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.SearchPreviewBackgroundWorker_RunWorkerCompleted);
            // 
            // SearchBackgroundWorker
            // 
            this.SearchBackgroundWorker.WorkerReportsProgress = true;
            this.SearchBackgroundWorker.WorkerSupportsCancellation = true;
            this.SearchBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SearchBackgroundWorker_DoWork);
            this.SearchBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.SearchBackgroundWorker_ProgressChanged);
            this.SearchBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.SearchBackgroundWorker_RunWorkerCompleted);
            // 
            // DownloadBackgroundWorker
            // 
            this.DownloadBackgroundWorker.WorkerReportsProgress = true;
            this.DownloadBackgroundWorker.WorkerSupportsCancellation = true;
            this.DownloadBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DownloadBackgroundWorker_DoWork);
            this.DownloadBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.DownloadBackgroundWorker_ProgressChanged);
            this.DownloadBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.DownloadBackgroundWorker_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1034, 545);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(960, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabster";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tabControl1.ResumeLayout(false);
            this.display_library.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.librarySplitContainer.Panel1.ResumeLayout(false);
            this.librarySplitContainer.Panel2.ResumeLayout(false);
            this.librarySplitContainer.Panel2.PerformLayout();
            this.librarySplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablibrary)).EndInit();
            this.previewToolStrip.ResumeLayout(false);
            this.previewToolStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.display_search.ResumeLayout(false);
            this.searchSplitContainer.Panel1.ResumeLayout(false);
            this.searchSplitContainer.Panel2.ResumeLayout(false);
            this.searchSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchDisplay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.SearchMenu.ResumeLayout(false);
            this.LibraryMenu.ResumeLayout(false);
            this.PlaylistMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem deletePlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renamePlaylistToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage display_library;
        private System.Windows.Forms.ToolStripButton refreshbtn;
        private System.Windows.Forms.ContextMenuStrip LibraryMenu;
        private System.Windows.Forms.ToolStripMenuItem librarycontextaddtoplaylist;
        private System.Windows.Forms.ContextMenuStrip PlaylistMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteplaylistcontextmenuitem;
        private System.Windows.Forms.ImageList tabimagelist;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sidebarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTabLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton clearsearchbtn;
        private SearchBox filtertext;
        private System.Windows.Forms.TabPage display_search;
        private DataGridViewExtended searchDisplay;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox txtsearchtype;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtsearchsong;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtsearchartist;
        private System.Windows.Forms.Button onlinesearchbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip SearchMenu;
        private System.Windows.Forms.ToolStripMenuItem saveTabToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copyURLToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblcount;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel lbldisk;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripStatusLabel lblplaylists;
        private System.Windows.Forms.ToolStripMenuItem searchUltimateGuitarToolStripMenuItem;
        private ToolStripMenuItem librarycontextdetails;
        private ToolStripMenuItem librarycontextdelete;
        private ToolStripMenuItem librarycontextexport;
        private ToolStripMenuItem librarycontextbrowse;
        private ToolStripMenuItem librarycontextsearch;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private Sidebar sidemenu;
        private SplitContainer librarySplitContainer;
        private DataGridViewExtended tablibrary;
        private ToolStrip previewToolStrip;
        private ToolStripLabel lblpreviewtitle;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton detailsbtn;
        private ToolStripButton printbtn;
        private Label lblsearchresults;
        private Timer PreviewDelay;
        private RecentToolStripMenuItem recentlyViewedToolStripMenuItem;
        private ToolStripMenuItem previewToolStripMenuItem;
        private SplitContainer searchSplitContainer;
        private TabEditor searchPreviewEditor;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripDropDownButton toolStripButton3;
        private ToolStripMenuItem offToolStripMenuItem;
        private ToolStripMenuItem libraryPreviewPaneToolStripMenuItem;
        private ToolStripMenuItem libraryhiddenpreviewToolStripMenuItem;
        private ToolStripMenuItem libraryhorizontalpreviewToolStripMenuItem;
        private ToolStripMenuItem libraryverticalpreviewToolStripMenuItem;
        private ToolStripMenuItem searchPreviewPaneToolStripMenuItem;
        private ToolStripMenuItem searchhiddenpreviewToolStripMenuItem;
        private ToolStripMenuItem searchhorizontalpreviewToolStripMenuItem;
        private ToolStripMenuItem searchverticalpreviewToolStripMenuItem;
        private ToolStripMenuItem playlistInformationToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker SearchPreviewBackgroundWorker;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem librarycontextfavorites;
        private DataGridViewTextBoxColumn title;
        private DataGridViewTextBoxColumn artist;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn size;
        private DataGridViewTextBoxColumn location;
        private Label lblopenedexternally;
        private ToolStripMenuItem onToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker SearchBackgroundWorker;
        private Label lblSearchStatus;
        private DataGridViewTextBoxColumn searchcol_artist;
        private DataGridViewTextBoxColumn searchcol_song;
        private DataGridViewTextBoxColumn searchcol_type;
        private DataGridViewTextBoxColumn col_rating;
        private DataGridViewTextBoxColumn searchcol_service;
        private TabPage tabPage1;
        private Button addtolibrarybtn;
        private Button downloadUrlsbtn;
        private Label label4;
        private ProgressBar progressBar1;
        private Label lblprogress;
        private TextBox txtDownloadURLs;
        private ListView listView1;
        private ColumnHeader colDownloadArtist;
        private ColumnHeader colDownloadStatus;
        private ColumnHeader colDownloadURL;
        private System.ComponentModel.BackgroundWorker DownloadBackgroundWorker;
        private ColumnHeader colDownloadTitle;
        private ColumnHeader colDownloadType;
        private ColumnHeader colDownloadParser;
    }
}

