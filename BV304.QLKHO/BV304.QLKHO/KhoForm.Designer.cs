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
            this.nhậpThuốcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpTừNhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.họTrịLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.nhậpThuốcToolStripMenuItem,
            this.danhMụcToolStripMenuItem});
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
            // nhậpThuốcToolStripMenuItem
            // 
            this.nhậpThuốcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpTừNhàCungCấpToolStripMenuItem});
            this.nhậpThuốcToolStripMenuItem.Name = "nhậpThuốcToolStripMenuItem";
            this.nhậpThuốcToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.nhậpThuốcToolStripMenuItem.Text = "Nhập Thuốc";
            // 
            // nhậpTừNhàCungCấpToolStripMenuItem
            // 
            this.nhậpTừNhàCungCấpToolStripMenuItem.Name = "nhậpTừNhàCungCấpToolStripMenuItem";
            this.nhậpTừNhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.nhậpTừNhàCungCấpToolStripMenuItem.Text = "Nhập Từ Nhà Cung Cấp";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcToolStripMenuItem1,
            this.họTrịLiệuToolStripMenuItem,
            this.nhàCungCấpToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.danhMụcToolStripMenuItem.Text = "Danh Mục";
            // 
            // danhMụcToolStripMenuItem1
            // 
            this.danhMụcToolStripMenuItem1.Name = "danhMụcToolStripMenuItem1";
            this.danhMụcToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.danhMụcToolStripMenuItem1.Text = "Thuốc Bệnh Viện";
            this.danhMụcToolStripMenuItem1.Click += new System.EventHandler(this.danhMụcToolStripMenuItem1_Click);
            // 
            // họTrịLiệuToolStripMenuItem
            // 
            this.họTrịLiệuToolStripMenuItem.Name = "họTrịLiệuToolStripMenuItem";
            this.họTrịLiệuToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.họTrịLiệuToolStripMenuItem.Text = "Họ Trị Liệu";
            // 
            // nhàCungCấpToolStripMenuItem
            // 
            this.nhàCungCấpToolStripMenuItem.Name = "nhàCungCấpToolStripMenuItem";
            this.nhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.nhàCungCấpToolStripMenuItem.Text = "Nhà Cung Cấp";
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPageHome);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
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
            this.tabPageHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
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
        private System.Windows.Forms.ToolStripMenuItem nhậpThuốcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpTừNhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem họTrịLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPageHome;
    }
}