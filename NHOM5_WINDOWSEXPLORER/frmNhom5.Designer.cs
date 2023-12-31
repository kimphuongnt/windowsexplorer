namespace NHOM5_WINDOWSEXPLORER
{
    partial class frmNhom5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhom5));
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.btncboNew = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnTaoFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTaoFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCat = new System.Windows.Forms.ToolStripButton();
            this.btnPaste = new System.Windows.Forms.ToolStripButton();
            this.btnRename = new System.Windows.Forms.ToolStripButton();
            this.btnShare = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnReload = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSort = new System.Windows.Forms.ToolStripDropDownButton();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnView = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnLargeIcons = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXemThem = new System.Windows.Forms.ToolStripDropDownButton();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlAddress = new System.Windows.Forms.Panel();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.trvDanhMuc = new System.Windows.Forms.TreeView();
            this.lstDanhMuc = new System.Windows.Forms.ListView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblDem = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlStatusBar = new System.Windows.Forms.Panel();
            this.tsMenu.SuspendLayout();
            this.pnlAddress.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.pnlStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.tsMenu.GripMargin = new System.Windows.Forms.Padding(5, 10, 10, 10);
            this.tsMenu.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btncboNew,
            this.toolStripButton2,
            this.btnCat,
            this.btnPaste,
            this.btnRename,
            this.btnShare,
            this.btnXoa,
            this.btnReload,
            this.toolStripButton1,
            this.btnSort,
            this.btnView,
            this.btnXemThem});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(800, 34);
            this.tsMenu.TabIndex = 3;
            this.tsMenu.Text = "toolStrip1";
            // 
            // btncboNew
            // 
            this.btncboNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTaoFolder,
            this.btnTaoFile});
            this.btncboNew.Image = ((System.Drawing.Image)(resources.GetObject("btncboNew.Image")));
            this.btncboNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btncboNew.Name = "btncboNew";
            this.btncboNew.Size = new System.Drawing.Size(90, 29);
            this.btncboNew.Text = "New";
            // 
            // btnTaoFolder
            // 
            this.btnTaoFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoFolder.Image")));
            this.btnTaoFolder.Name = "btnTaoFolder";
            this.btnTaoFolder.Size = new System.Drawing.Size(164, 34);
            this.btnTaoFolder.Text = "Folder";
            this.btnTaoFolder.Click += new System.EventHandler(this.btnTaoFolder_Click);
            // 
            // btnTaoFile
            // 
            this.btnTaoFile.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoFile.Image")));
            this.btnTaoFile.Name = "btnTaoFile";
            this.btnTaoFile.Size = new System.Drawing.Size(164, 34);
            this.btnTaoFile.Text = "File";
            this.btnTaoFile.Click += new System.EventHandler(this.btnTaoFile_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(6, 34);
            // 
            // btnCat
            // 
            this.btnCat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCat.Image = ((System.Drawing.Image)(resources.GetObject("btnCat.Image")));
            this.btnCat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCat.Margin = new System.Windows.Forms.Padding(10, 2, 10, 3);
            this.btnCat.Name = "btnCat";
            this.btnCat.Size = new System.Drawing.Size(34, 29);
            this.btnCat.Text = "Cut";
            this.btnCat.Click += new System.EventHandler(this.btnCat_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPaste.Image = ((System.Drawing.Image)(resources.GetObject("btnPaste.Image")));
            this.btnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPaste.Margin = new System.Windows.Forms.Padding(0, 2, 10, 3);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(34, 29);
            this.btnPaste.Text = "Paste";
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnRename
            // 
            this.btnRename.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRename.Image = ((System.Drawing.Image)(resources.GetObject("btnRename.Image")));
            this.btnRename.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRename.Margin = new System.Windows.Forms.Padding(0, 2, 10, 3);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(34, 29);
            this.btnRename.Text = "Rename";
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnShare
            // 
            this.btnShare.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnShare.Image = ((System.Drawing.Image)(resources.GetObject("btnShare.Image")));
            this.btnShare.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShare.Margin = new System.Windows.Forms.Padding(0, 2, 10, 3);
            this.btnShare.Name = "btnShare";
            this.btnShare.Size = new System.Drawing.Size(34, 29);
            this.btnShare.Text = "Share";
            this.btnShare.Click += new System.EventHandler(this.btnShare_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnXoa.Image = global::NHOM5_WINDOWSEXPLORER.Properties.Resources.icons8_recycle_bin_64;
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Margin = new System.Windows.Forms.Padding(0, 2, 10, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(34, 29);
            this.btnXoa.Text = "Delete";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnReload
            // 
            this.btnReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(34, 29);
            this.btnReload.Text = "Refresh";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(6, 34);
            // 
            // btnSort
            // 
            this.btnSort.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripMenuItem,
            this.dateToolStripMenuItem,
            this.toolStripSeparator1,
            this.aToolStripMenuItem,
            this.descendingToolStripMenuItem});
            this.btnSort.Image = ((System.Drawing.Image)(resources.GetObject("btnSort.Image")));
            this.btnSort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSort.Margin = new System.Windows.Forms.Padding(0, 2, 10, 3);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(88, 29);
            this.btnSort.Text = "Sort";
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(207, 34);
            this.nameToolStripMenuItem.Text = "Name";
            this.nameToolStripMenuItem.Click += new System.EventHandler(this.nameToolStripMenuItem_Click);
            // 
            // dateToolStripMenuItem
            // 
            this.dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            this.dateToolStripMenuItem.Size = new System.Drawing.Size(207, 34);
            this.dateToolStripMenuItem.Text = "Date";
            this.dateToolStripMenuItem.Click += new System.EventHandler(this.dateToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(204, 6);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(207, 34);
            this.aToolStripMenuItem.Text = "Ascending";
            // 
            // descendingToolStripMenuItem
            // 
            this.descendingToolStripMenuItem.Name = "descendingToolStripMenuItem";
            this.descendingToolStripMenuItem.Size = new System.Drawing.Size(207, 34);
            this.descendingToolStripMenuItem.Text = "Descending";
            // 
            // btnView
            // 
            this.btnView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLargeIcons,
            this.smallIconsToolStripMenuItem,
            this.listToolStripMenuItem,
            this.detailsToolStripMenuItem});
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnView.Margin = new System.Windows.Forms.Padding(0, 2, 10, 3);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(92, 29);
            this.btnView.Text = "View";
            // 
            // btnLargeIcons
            // 
            this.btnLargeIcons.Image = ((System.Drawing.Image)(resources.GetObject("btnLargeIcons.Image")));
            this.btnLargeIcons.Name = "btnLargeIcons";
            this.btnLargeIcons.Size = new System.Drawing.Size(203, 34);
            this.btnLargeIcons.Text = "Large icons";
            this.btnLargeIcons.Click += new System.EventHandler(this.btnLargeIcons_Click);
            // 
            // smallIconsToolStripMenuItem
            // 
            this.smallIconsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("smallIconsToolStripMenuItem.Image")));
            this.smallIconsToolStripMenuItem.Name = "smallIconsToolStripMenuItem";
            this.smallIconsToolStripMenuItem.Size = new System.Drawing.Size(203, 34);
            this.smallIconsToolStripMenuItem.Text = "Small icons";
            this.smallIconsToolStripMenuItem.Click += new System.EventHandler(this.smallIconsToolStripMenuItem_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listToolStripMenuItem.Image")));
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(203, 34);
            this.listToolStripMenuItem.Text = "List";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("detailsToolStripMenuItem.Image")));
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(203, 34);
            this.detailsToolStripMenuItem.Text = "Details";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.detailsToolStripMenuItem_Click);
            // 
            // btnXemThem
            // 
            this.btnXemThem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnXemThem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem});
            this.btnXemThem.Image = ((System.Drawing.Image)(resources.GetObject("btnXemThem.Image")));
            this.btnXemThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXemThem.Name = "btnXemThem";
            this.btnXemThem.Size = new System.Drawing.Size(43, 29);
            this.btnXemThem.Text = "Xem thêm";
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(187, 34);
            this.selectToolStripMenuItem.Text = "Select all ";
            this.selectToolStripMenuItem.Click += new System.EventHandler(this.selectToolStripMenuItem_Click);
            // 
            // pnlAddress
            // 
            this.pnlAddress.Controls.Add(this.txtPath);
            this.pnlAddress.Controls.Add(this.btnNext);
            this.pnlAddress.Controls.Add(this.btnBack);
            this.pnlAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAddress.Location = new System.Drawing.Point(0, 34);
            this.pnlAddress.Name = "pnlAddress";
            this.pnlAddress.Size = new System.Drawing.Size(800, 51);
            this.pnlAddress.TabIndex = 5;
            // 
            // txtPath
            // 
            this.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPath.Location = new System.Drawing.Point(140, 8);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(648, 34);
            this.txtPath.TabIndex = 3;
            this.txtPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPath_KeyDown);
            // 
            // btnNext
            // 
            this.btnNext.ImageKey = "icons8-next-96.png";
            this.btnNext.ImageList = this.imageList1;
            this.btnNext.Location = new System.Drawing.Point(76, 8);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(58, 34);
            this.btnNext.TabIndex = 2;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-next-96.png");
            this.imageList1.Images.SetKeyName(1, "icons8-back-50.png");
            this.imageList1.Images.SetKeyName(2, "icons8-folder-96.png");
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBack.ImageKey = "icons8-back-50.png";
            this.btnBack.ImageList = this.imageList1;
            this.btnBack.Location = new System.Drawing.Point(12, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(46, 33);
            this.btnBack.TabIndex = 0;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AllowDrop = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.35883F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.64117F));
            this.tableLayoutPanel1.Controls.Add(this.trvDanhMuc, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lstDanhMuc, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 85);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 330);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // trvDanhMuc
            // 
            this.trvDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.trvDanhMuc.Margin = new System.Windows.Forms.Padding(0);
            this.trvDanhMuc.Name = "trvDanhMuc";
            this.trvDanhMuc.Size = new System.Drawing.Size(234, 330);
            this.trvDanhMuc.TabIndex = 0;
            this.trvDanhMuc.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.trvDanhMuc_BeforeExpand);
            this.trvDanhMuc.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvDanhMuc_AfterSelect);
            // 
            // lstDanhMuc
            // 
            this.lstDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDanhMuc.HideSelection = false;
            this.lstDanhMuc.Location = new System.Drawing.Point(234, 0);
            this.lstDanhMuc.Margin = new System.Windows.Forms.Padding(0);
            this.lstDanhMuc.Name = "lstDanhMuc";
            this.lstDanhMuc.Size = new System.Drawing.Size(566, 330);
            this.lstDanhMuc.TabIndex = 1;
            this.lstDanhMuc.UseCompatibleStateImageBehavior = false;
            this.lstDanhMuc.View = System.Windows.Forms.View.Details;
            this.lstDanhMuc.DoubleClick += new System.EventHandler(this.lstDanhMuc_DoubleClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDem});
            this.statusStrip1.Location = new System.Drawing.Point(0, 3);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 32);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblDem
            // 
            this.lblDem.Name = "lblDem";
            this.lblDem.Size = new System.Drawing.Size(120, 25);
            this.lblDem.Text = "Tổng số mục:";
            // 
            // pnlStatusBar
            // 
            this.pnlStatusBar.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
            this.pnlStatusBar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlStatusBar.Controls.Add(this.statusStrip1);
            this.pnlStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStatusBar.Location = new System.Drawing.Point(0, 415);
            this.pnlStatusBar.Name = "pnlStatusBar";
            this.pnlStatusBar.Size = new System.Drawing.Size(800, 35);
            this.pnlStatusBar.TabIndex = 4;
            // 
            // frmNhom5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnlAddress);
            this.Controls.Add(this.pnlStatusBar);
            this.Controls.Add(this.tsMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNhom5";
            this.Text = "NHOM5";
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.pnlAddress.ResumeLayout(false);
            this.pnlAddress.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlStatusBar.ResumeLayout(false);
            this.pnlStatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripDropDownButton btncboNew;
        private System.Windows.Forms.ToolStripMenuItem btnTaoFolder;
        private System.Windows.Forms.ToolStripMenuItem btnTaoFile;
        private System.Windows.Forms.ToolStripSeparator toolStripButton2;
        private System.Windows.Forms.ToolStripButton btnCat;
        private System.Windows.Forms.ToolStripButton btnPaste;
        private System.Windows.Forms.ToolStripButton btnRename;
        private System.Windows.Forms.ToolStripButton btnShare;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnReload;
        private System.Windows.Forms.ToolStripSeparator toolStripButton1;
        private System.Windows.Forms.ToolStripDropDownButton btnSort;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton btnView;
        private System.Windows.Forms.ToolStripMenuItem btnLargeIcons;
        private System.Windows.Forms.ToolStripMenuItem smallIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.Panel pnlAddress;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TreeView trvDanhMuc;
        private System.Windows.Forms.ListView lstDanhMuc;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblDem;
        private System.Windows.Forms.Panel pnlStatusBar;
        private System.Windows.Forms.ToolStripDropDownButton btnXemThem;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
    }
}

