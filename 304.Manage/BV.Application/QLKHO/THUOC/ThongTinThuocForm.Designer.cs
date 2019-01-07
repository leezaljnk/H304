namespace BV.QLKHO.THUOC
{
    partial class ThongTinThuocForm
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
            Infragistics.Win.UltraWinEditors.EditorButton editorButton1 = new Infragistics.Win.UltraWinEditors.EditorButton();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemoveDonVi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDonVi = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmTiLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPhepTinh = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddDonVi = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtGiaDichVu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHoatChat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoDangKy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDongGoi = new System.Windows.Forms.TextBox();
            this.txtHamLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboHoTriLieu = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.cboDuongDung = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.cboDonVi = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGiaCB = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtGiaBH = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTenThuoc = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboHoTriLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDuongDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDonVi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên thuốc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Họ trị liệu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Đơn vị chính:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnRemoveDonVi);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnAddDonVi);
            this.groupBox1.Location = new System.Drawing.Point(25, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 165);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chuyển Đổi Giữa Các Đơn Vị";
            // 
            // btnRemoveDonVi
            // 
            this.btnRemoveDonVi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveDonVi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveDonVi.Location = new System.Drawing.Point(43, 132);
            this.btnRemoveDonVi.Name = "btnRemoveDonVi";
            this.btnRemoveDonVi.Size = new System.Drawing.Size(34, 23);
            this.btnRemoveDonVi.TabIndex = 2;
            this.btnRemoveDonVi.Text = "-";
            this.btnRemoveDonVi.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSTT,
            this.clmDonVi,
            this.clmTiLe,
            this.clmPhepTinh,
            this.clmMoTa});
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(771, 106);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // clmSTT
            // 
            this.clmSTT.FillWeight = 50.76144F;
            this.clmSTT.HeaderText = "STT";
            this.clmSTT.Name = "clmSTT";
            this.clmSTT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmDonVi
            // 
            this.clmDonVi.FillWeight = 112.3097F;
            this.clmDonVi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clmDonVi.HeaderText = "Đơn Vị";
            this.clmDonVi.Name = "clmDonVi";
            // 
            // clmTiLe
            // 
            this.clmTiLe.FillWeight = 112.3097F;
            this.clmTiLe.HeaderText = "Tỉ Lệ Với Đơn Vị Chính";
            this.clmTiLe.Name = "clmTiLe";
            this.clmTiLe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmPhepTinh
            // 
            this.clmPhepTinh.FillWeight = 112.3097F;
            this.clmPhepTinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clmPhepTinh.HeaderText = "Phép Tính Chuyển Đổi";
            this.clmPhepTinh.Items.AddRange(new object[] {
            "Nhân",
            "Chia"});
            this.clmPhepTinh.Name = "clmPhepTinh";
            // 
            // clmMoTa
            // 
            this.clmMoTa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmMoTa.FillWeight = 112.3097F;
            this.clmMoTa.HeaderText = "Mô Tả";
            this.clmMoTa.Name = "clmMoTa";
            this.clmMoTa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmMoTa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnAddDonVi
            // 
            this.btnAddDonVi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddDonVi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDonVi.Location = new System.Drawing.Point(7, 132);
            this.btnAddDonVi.Name = "btnAddDonVi";
            this.btnAddDonVi.Size = new System.Drawing.Size(34, 23);
            this.btnAddDonVi.TabIndex = 1;
            this.btnAddDonVi.Text = "+";
            this.btnAddDonVi.UseVisualStyleBackColor = true;
            this.btnAddDonVi.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(653, 494);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(734, 494);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtGiaDichVu
            // 
            this.txtGiaDichVu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGiaDichVu.Location = new System.Drawing.Point(340, 18);
            this.txtGiaDichVu.Name = "txtGiaDichVu";
            this.txtGiaDichVu.Size = new System.Drawing.Size(70, 21);
            this.txtGiaDichVu.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(271, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Giá dịch vụ:";
            // 
            // txtHoatChat
            // 
            this.txtHoatChat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHoatChat.Location = new System.Drawing.Point(133, 74);
            this.txtHoatChat.Name = "txtHoatChat";
            this.txtHoatChat.Size = new System.Drawing.Size(670, 21);
            this.txtHoatChat.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hoạt chất:";
            // 
            // txtSoDangKy
            // 
            this.txtSoDangKy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoDangKy.Location = new System.Drawing.Point(133, 43);
            this.txtSoDangKy.Name = "txtSoDangKy";
            this.txtSoDangKy.Size = new System.Drawing.Size(670, 21);
            this.txtSoDangKy.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số đăng ký:";
            // 
            // txtDongGoi
            // 
            this.txtDongGoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDongGoi.Location = new System.Drawing.Point(133, 167);
            this.txtDongGoi.Name = "txtDongGoi";
            this.txtDongGoi.Size = new System.Drawing.Size(670, 21);
            this.txtDongGoi.TabIndex = 12;
            // 
            // txtHamLuong
            // 
            this.txtHamLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHamLuong.Location = new System.Drawing.Point(133, 105);
            this.txtHamLuong.Name = "txtHamLuong";
            this.txtHamLuong.Size = new System.Drawing.Size(670, 21);
            this.txtHamLuong.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Đường dùng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Đóng gói:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Hàm lượng:";
            // 
            // cboHoTriLieu
            // 
            this.cboHoTriLieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboHoTriLieu.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest;
            this.cboHoTriLieu.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains;
            this.cboHoTriLieu.Location = new System.Drawing.Point(133, 197);
            this.cboHoTriLieu.Name = "cboHoTriLieu";
            this.cboHoTriLieu.Size = new System.Drawing.Size(670, 22);
            this.cboHoTriLieu.TabIndex = 14;
            this.cboHoTriLieu.UseAppStyling = false;
            this.cboHoTriLieu.UseOsThemes = Infragistics.Win.DefaultableBoolean.True;
            // 
            // cboDuongDung
            // 
            this.cboDuongDung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDuongDung.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest;
            this.cboDuongDung.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains;
            this.cboDuongDung.Location = new System.Drawing.Point(133, 136);
            this.cboDuongDung.Name = "cboDuongDung";
            this.cboDuongDung.Size = new System.Drawing.Size(670, 22);
            this.cboDuongDung.TabIndex = 10;
            this.cboDuongDung.UseAppStyling = false;
            this.cboDuongDung.UseOsThemes = Infragistics.Win.DefaultableBoolean.True;
            // 
            // cboDonVi
            // 
            this.cboDonVi.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest;
            this.cboDonVi.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains;
            this.cboDonVi.Location = new System.Drawing.Point(108, 17);
            this.cboDonVi.Name = "cboDonVi";
            this.cboDonVi.Size = new System.Drawing.Size(140, 22);
            this.cboDonVi.TabIndex = 16;
            this.cboDonVi.UseAppStyling = false;
            this.cboDonVi.UseOsThemes = Infragistics.Win.DefaultableBoolean.True;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtGiaCB);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtGiaBH);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cboDonVi);
            this.groupBox2.Controls.Add(this.txtGiaDichVu);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(25, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(777, 60);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giá Thuốc (tính theo Việt Nam đồng)";
            // 
            // txtGiaCB
            // 
            this.txtGiaCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGiaCB.Location = new System.Drawing.Point(678, 18);
            this.txtGiaCB.Name = "txtGiaCB";
            this.txtGiaCB.Size = new System.Drawing.Size(70, 21);
            this.txtGiaCB.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(589, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Giá chính sách:";
            // 
            // txtGiaBH
            // 
            this.txtGiaBH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGiaBH.Location = new System.Drawing.Point(501, 18);
            this.txtGiaBH.Name = "txtGiaBH";
            this.txtGiaBH.Size = new System.Drawing.Size(70, 21);
            this.txtGiaBH.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(423, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Giá bảo hiểm:";
            // 
            // txtTenThuoc
            // 
            appearance1.TextHAlignAsString = "Center";
            appearance1.TextVAlignAsString = "Middle";
            editorButton1.Appearance = appearance1;
            editorButton1.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Flat;
            appearance2.TextHAlignAsString = "Center";
            appearance2.TextVAlignAsString = "Middle";
            editorButton1.PressedAppearance = appearance2;
            editorButton1.Text = "+";
            editorButton1.Width = 30;
            this.txtTenThuoc.ButtonsRight.Add(editorButton1);
            this.txtTenThuoc.Location = new System.Drawing.Point(133, 12);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Size = new System.Drawing.Size(669, 22);
            this.txtTenThuoc.TabIndex = 24;
            this.txtTenThuoc.EditorButtonClick += new Infragistics.Win.UltraWinEditors.EditorButtonEventHandler(this.utxtTenThuoc_EditorButtonClick);
            // 
            // ThongTinThuocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(821, 537);
            this.Controls.Add(this.txtTenThuoc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cboDuongDung);
            this.Controls.Add(this.cboHoTriLieu);
            this.Controls.Add(this.txtHoatChat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoDangKy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDongGoi);
            this.Controls.Add(this.txtHamLuong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "ThongTinThuocForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông Tin Thuốc Bệnh Viện";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboHoTriLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDuongDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDonVi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRemoveDonVi;
        private System.Windows.Forms.Button btnAddDonVi;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtGiaDichVu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHoatChat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoDangKy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDongGoi;
        private System.Windows.Forms.TextBox txtHamLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor cboHoTriLieu;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor cboDuongDung;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor cboDonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSTT;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmDonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTiLe;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmPhepTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMoTa;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtGiaCB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtGiaBH;
        private System.Windows.Forms.Label label12;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtTenThuoc;
    }
}