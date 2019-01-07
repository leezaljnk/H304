namespace BV.QuanTriHeThong
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
            this.danhMucHanhChinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dmKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPageHome = new System.Windows.Forms.TabPage();
            this.dmPKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dmKhoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.danhMucHanhChinhToolStripMenuItem,
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
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loginToolStripMenuItem.Text = "Đăng Nhập";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // danhMucHanhChinhToolStripMenuItem
            // 
            this.danhMucHanhChinhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dmKhoaToolStripMenuItem,
            this.dmPKToolStripMenuItem,
            this.dmKhoToolStripMenuItem});
            this.danhMucHanhChinhToolStripMenuItem.Name = "danhMucHanhChinhToolStripMenuItem";
            this.danhMucHanhChinhToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.danhMucHanhChinhToolStripMenuItem.Text = "Danh Mục";
            // 
            // dmKhoToolStripMenuItem
            // 
            this.dmKhoToolStripMenuItem.Name = "dmKhoToolStripMenuItem";
            this.dmKhoToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.dmKhoToolStripMenuItem.Text = "Danh Mục Kho";
            this.dmKhoToolStripMenuItem.Click += new System.EventHandler(this.khoToolStripMenuItem_Click);
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
            this.gridToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            // dmPKToolStripMenuItem
            // 
            this.dmPKToolStripMenuItem.Name = "dmPKToolStripMenuItem";
            this.dmPKToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.dmPKToolStripMenuItem.Text = "Danh Mục Phòng Khám";
            this.dmPKToolStripMenuItem.Click += new System.EventHandler(this.dmPKToolStripMenuItem_Click);
            // 
            // dmKhoaToolStripMenuItem
            // 
            this.dmKhoaToolStripMenuItem.Name = "dmKhoaToolStripMenuItem";
            this.dmKhoaToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.dmKhoaToolStripMenuItem.Text = "Danh Mục Khoa";
            this.dmKhoaToolStripMenuItem.Click += new System.EventHandler(this.dmKhoaToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem danhMucHanhChinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dmKhoToolStripMenuItem;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPageHome;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dmPKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dmKhoaToolStripMenuItem;
    }
}