namespace BV.QLKHO
{
    partial class KhoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhoForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhMucNhapThuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhapThuocTuNhaCungCap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhMucThuocVatTuYTe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhMucHoTriLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhMucNhaCungCap = new System.Windows.Forms.ToolStripMenuItem();
            this.khoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhMucKho = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPageHome = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.mnuDanhMucNhapThuoc,
            this.mnuDanhMuc,
            this.khoToolStripMenuItem,
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(638, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.mainToolStripMenuItem.Text = "Người Dùng";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.loginToolStripMenuItem.Text = "Đăng Nhập";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // mnuDanhMucNhapThuoc
            // 
            this.mnuDanhMucNhapThuoc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNhapThuocTuNhaCungCap});
            this.mnuDanhMucNhapThuoc.Name = "mnuDanhMucNhapThuoc";
            this.mnuDanhMucNhapThuoc.Size = new System.Drawing.Size(85, 20);
            this.mnuDanhMucNhapThuoc.Text = "Nhập Thuốc";
            // 
            // mnuNhapThuocTuNhaCungCap
            // 
            this.mnuNhapThuocTuNhaCungCap.Name = "mnuNhapThuocTuNhaCungCap";
            this.mnuNhapThuocTuNhaCungCap.Size = new System.Drawing.Size(201, 22);
            this.mnuNhapThuocTuNhaCungCap.Text = "Nhập Từ Nhà Cung Cấp";
            this.mnuNhapThuocTuNhaCungCap.Click += new System.EventHandler(this.mnuNhapThuocTuNhaCungCap_Click);
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDanhMucThuocVatTuYTe,
            this.mnuDanhMucHoTriLieu,
            this.mnuDanhMucNhaCungCap});
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(74, 20);
            this.mnuDanhMuc.Text = "Danh Mục";
            // 
            // mnuDanhMucThuocVatTuYTe
            // 
            this.mnuDanhMucThuocVatTuYTe.Name = "mnuDanhMucThuocVatTuYTe";
            this.mnuDanhMucThuocVatTuYTe.Size = new System.Drawing.Size(184, 22);
            this.mnuDanhMucThuocVatTuYTe.Text = "Thuốc && Vật Tư Y Tế";
            this.mnuDanhMucThuocVatTuYTe.Click += new System.EventHandler(this.mnuDanhMucThuocVatTuYTe_Click);
            // 
            // mnuDanhMucHoTriLieu
            // 
            this.mnuDanhMucHoTriLieu.Name = "mnuDanhMucHoTriLieu";
            this.mnuDanhMucHoTriLieu.Size = new System.Drawing.Size(184, 22);
            this.mnuDanhMucHoTriLieu.Text = "Họ Trị Liệu";
            // 
            // mnuDanhMucNhaCungCap
            // 
            this.mnuDanhMucNhaCungCap.Name = "mnuDanhMucNhaCungCap";
            this.mnuDanhMucNhaCungCap.Size = new System.Drawing.Size(184, 22);
            this.mnuDanhMucNhaCungCap.Text = "Nhà Cung Cấp";
            this.mnuDanhMucNhaCungCap.Click += new System.EventHandler(this.mnuDanhMucNhaCungCap_Click);
            // 
            // khoToolStripMenuItem
            // 
            this.khoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDanhMucKho});
            this.khoToolStripMenuItem.Name = "khoToolStripMenuItem";
            this.khoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.khoToolStripMenuItem.Text = "Kho";
            // 
            // mnuDanhMucKho
            // 
            this.mnuDanhMucKho.Name = "mnuDanhMucKho";
            this.mnuDanhMucKho.Size = new System.Drawing.Size(180, 22);
            this.mnuDanhMucKho.Text = "Danh Mục Kho";
            this.mnuDanhMucKho.Click += new System.EventHandler(this.mnuDanhMucKho_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gridToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // gridToolStripMenuItem
            // 
            this.gridToolStripMenuItem.Name = "gridToolStripMenuItem";
            this.gridToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.gridToolStripMenuItem.Text = "Grid";
            this.gridToolStripMenuItem.Click += new System.EventHandler(this.gridToolStripMenuItem_Click);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPageHome);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.ItemSize = new System.Drawing.Size(66, 32);
            this.tabMain.Location = new System.Drawing.Point(0, 24);
            this.tabMain.Margin = new System.Windows.Forms.Padding(4);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(638, 403);
            this.tabMain.TabIndex = 4;
            // 
            // tabPageHome
            // 
            this.tabPageHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageHome.BackgroundImage")));
            this.tabPageHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPageHome.Location = new System.Drawing.Point(4, 36);
            this.tabPageHome.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageHome.Size = new System.Drawing.Size(630, 363);
            this.tabPageHome.TabIndex = 2;
            this.tabPageHome.Text = "Thống kê";
            this.tabPageHome.UseVisualStyleBackColor = true;
            // 
            // KhoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 427);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "KhoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Kho";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMucNhapThuoc;
        private System.Windows.Forms.ToolStripMenuItem mnuNhapThuocTuNhaCungCap;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMucThuocVatTuYTe;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMucHoTriLieu;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMucNhaCungCap;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPageHome;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMucKho;
    }
}