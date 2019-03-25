namespace BV.QLKHO.KhoChan.XuatThuoc
{
    partial class XuatThuocBNCtrl
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
            this.txtKhoDN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHuyDN = new System.Windows.Forms.Button();
            this.btnDuyetDN = new System.Windows.Forms.Button();
            this.txtNgayDN = new System.Windows.Forms.TextBox();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNguoiDN = new System.Windows.Forms.TextBox();
            this.colCanhBao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNguoiTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTenKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTonThucTe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dateNgayDuyet = new System.Windows.Forms.DateTimePicker();
            this.btnView = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKhoDN
            // 
            this.txtKhoDN.Location = new System.Drawing.Point(195, 20);
            this.txtKhoDN.Name = "txtKhoDN";
            this.txtKhoDN.Size = new System.Drawing.Size(100, 20);
            this.txtKhoDN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kho đề nghị:";
            // 
            // btnHuyDN
            // 
            this.btnHuyDN.Location = new System.Drawing.Point(1095, 21);
            this.btnHuyDN.Name = "btnHuyDN";
            this.btnHuyDN.Size = new System.Drawing.Size(87, 25);
            this.btnHuyDN.TabIndex = 4;
            this.btnHuyDN.Text = "Hủy ĐN";
            this.btnHuyDN.UseVisualStyleBackColor = true;
            this.btnHuyDN.Click += new System.EventHandler(this.btnHuyDN_Click);
            // 
            // btnDuyetDN
            // 
            this.btnDuyetDN.Location = new System.Drawing.Point(1002, 21);
            this.btnDuyetDN.Name = "btnDuyetDN";
            this.btnDuyetDN.Size = new System.Drawing.Size(87, 25);
            this.btnDuyetDN.TabIndex = 4;
            this.btnDuyetDN.Text = "Duyệt ĐN";
            this.btnDuyetDN.UseVisualStyleBackColor = true;
            this.btnDuyetDN.Click += new System.EventHandler(this.btnDuyetDN_Click);
            // 
            // txtNgayDN
            // 
            this.txtNgayDN.Location = new System.Drawing.Point(677, 21);
            this.txtNgayDN.Name = "txtNgayDN";
            this.txtNgayDN.Size = new System.Drawing.Size(125, 20);
            this.txtNgayDN.TabIndex = 5;
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Location = new System.Drawing.Point(808, 24);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(58, 13);
            this.lblTinhTrang.TabIndex = 4;
            this.lblTinhTrang.Text = "Tình trạng:";
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(597, 24);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(74, 13);
            this.label25.TabIndex = 4;
            this.label25.Text = "Ngày đề nghị:";
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(316, 24);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(98, 13);
            this.label26.TabIndex = 4;
            this.label26.Text = "Nhân viên đề nghị:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtKhoDN);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnHuyDN);
            this.groupBox3.Controls.Add(this.btnDuyetDN);
            this.groupBox3.Controls.Add(this.txtNgayDN);
            this.groupBox3.Controls.Add(this.lblTinhTrang);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.txtNguoiDN);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 723);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1400, 62);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin đề nghị";
            // 
            // txtNguoiDN
            // 
            this.txtNguoiDN.Location = new System.Drawing.Point(422, 21);
            this.txtNguoiDN.Name = "txtNguoiDN";
            this.txtNguoiDN.Size = new System.Drawing.Size(169, 20);
            this.txtNguoiDN.TabIndex = 5;
            // 
            // colCanhBao
            // 
            this.colCanhBao.HeaderText = "Cảnh báo";
            this.colCanhBao.Name = "colCanhBao";
            this.colCanhBao.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Đơn giá";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // clmGhiChu
            // 
            this.clmGhiChu.HeaderText = "Số lô";
            this.clmGhiChu.Name = "clmGhiChu";
            this.clmGhiChu.ReadOnly = true;
            this.clmGhiChu.Width = 150;
            // 
            // clmNguoiTra
            // 
            this.clmNguoiTra.HeaderText = "Hạn sử dụng";
            this.clmNguoiTra.Name = "clmNguoiTra";
            this.clmNguoiTra.ReadOnly = true;
            this.clmNguoiTra.Width = 150;
            // 
            // clmTenKho
            // 
            this.clmTenKho.HeaderText = "Đơn vị";
            this.clmTenKho.Name = "clmTenKho";
            this.clmTenKho.ReadOnly = true;
            this.clmTenKho.Width = 150;
            // 
            // colTonThucTe
            // 
            this.colTonThucTe.HeaderText = "SL thực tế";
            this.colTonThucTe.Name = "colTonThucTe";
            this.colTonThucTe.ReadOnly = true;
            this.colTonThucTe.Width = 150;
            // 
            // colSoLuongDN
            // 
            this.colSoLuongDN.HeaderText = "SL đề nghị";
            this.colSoLuongDN.Name = "colSoLuongDN";
            this.colSoLuongDN.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSoLuongDN.Width = 150;
            // 
            // clmMa
            // 
            this.clmMa.HeaderText = "Tên thuốc";
            this.clmMa.Name = "clmMa";
            this.clmMa.ReadOnly = true;
            this.clmMa.Width = 250;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Thuộc phiếu";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column1,
            this.clmMa,
            this.colSoLuongDN,
            this.colTonThucTe,
            this.clmTenKho,
            this.clmNguoiTra,
            this.clmGhiChu,
            this.Column2,
            this.colCanhBao});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1400, 721);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(772, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ngày duyệt:";
            // 
            // dateNgayDuyet
            // 
            this.dateNgayDuyet.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayDuyet.Location = new System.Drawing.Point(842, 26);
            this.dateNgayDuyet.Name = "dateNgayDuyet";
            this.dateNgayDuyet.Size = new System.Drawing.Size(96, 20);
            this.dateNgayDuyet.TabIndex = 7;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(275, 24);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(91, 25);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "Xem thông tin";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã phiếu đề nghị:";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.BackColor = System.Drawing.Color.White;
            this.txtMaPhieu.Location = new System.Drawing.Point(141, 26);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(114, 20);
            this.txtMaPhieu.TabIndex = 1;
            this.txtMaPhieu.Text = "CNWIFQKIYF2U5C7LQNBCIZBP4CV20O8H";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateNgayDuyet);
            this.groupBox1.Controls.Add(this.btnView);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMaPhieu);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1400, 64);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(372, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 25);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm phiếu";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // XuatThuocBNCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "XuatThuocBNCtrl";
            this.Size = new System.Drawing.Size(1400, 785);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtKhoDN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHuyDN;
        private System.Windows.Forms.Button btnDuyetDN;
        private System.Windows.Forms.TextBox txtNgayDN;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNguoiDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCanhBao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNguoiTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTenKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTonThucTe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateNgayDuyet;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
    }
}
