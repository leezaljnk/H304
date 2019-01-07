namespace BV.QLKHO.KhoBV
{
    partial class DanhMucKhoCtrl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhMucKhoCtrl));
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label39 = new System.Windows.Forms.Label();
            this.txtTenCSSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolbarGeneral1 = new BVSharedComponent.ToolbarGeneral();
            this.clmMaKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLoaiKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(304, 4);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 26);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm...";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label39);
            this.panel1.Controls.Add(this.txtTenCSSearch);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 40);
            this.panel1.TabIndex = 5;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(11, 11);
            this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(50, 13);
            this.label39.TabIndex = 0;
            this.label39.Text = "Từ khóa:";
            // 
            // txtTenCSSearch
            // 
            this.txtTenCSSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTenCSSearch.Location = new System.Drawing.Point(96, 6);
            this.txtTenCSSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenCSSearch.Name = "txtTenCSSearch";
            this.txtTenCSSearch.Size = new System.Drawing.Size(199, 20);
            this.txtTenCSSearch.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMaKho,
            this.clmTen,
            this.clmLoaiKho,
            this.clmKhoa});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 71);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(934, 463);
            this.dataGridView1.TabIndex = 6;
            // 
            // toolbarGeneral1
            // 
            this.toolbarGeneral1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolbarGeneral1.Location = new System.Drawing.Point(0, 0);
            this.toolbarGeneral1.Name = "toolbarGeneral1";
            this.toolbarGeneral1.Size = new System.Drawing.Size(934, 31);
            this.toolbarGeneral1.TabIndex = 4;
            this.toolbarGeneral1.Text = "toolbarGeneral1";
            this.toolbarGeneral1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolbarGeneral1_ItemClicked);
            // 
            // clmMaKho
            // 
            this.clmMaKho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmMaKho.HeaderText = "Mã";
            this.clmMaKho.Name = "clmMaKho";
            this.clmMaKho.ReadOnly = true;
            // 
            // clmTen
            // 
            this.clmTen.HeaderText = "Tên kho";
            this.clmTen.Name = "clmTen";
            this.clmTen.ReadOnly = true;
            // 
            // clmLoaiKho
            // 
            this.clmLoaiKho.HeaderText = "Loại";
            this.clmLoaiKho.Name = "clmLoaiKho";
            this.clmLoaiKho.ReadOnly = true;
            // 
            // clmKhoa
            // 
            this.clmKhoa.HeaderText = "Khoa";
            this.clmKhoa.Name = "clmKhoa";
            this.clmKhoa.ReadOnly = true;
            // 
            // DanhMucKhoCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolbarGeneral1);
            this.Name = "DanhMucKhoCtrl";
            this.Size = new System.Drawing.Size(934, 534);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox txtTenCSSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BVSharedComponent.ToolbarGeneral toolbarGeneral1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLoaiKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKhoa;
    }
}
