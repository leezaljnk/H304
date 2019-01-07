namespace BV.TiepNhanHoSo
{
    partial class ctrlThongTinTiepNhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlThongTinTiepNhan));
            this.ugrpDoiTuong = new Infragistics.Win.Misc.UltraGroupBox();
            this.cboCA = new System.Windows.Forms.ComboBox();
            this.rdCA = new System.Windows.Forms.RadioButton();
            this.rdDichVu = new System.Windows.Forms.RadioButton();
            this.rdBHXH = new System.Windows.Forms.RadioButton();
            this.grpChuyenVien = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ucboPhongKham = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.ucboDichVu = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.label7 = new System.Windows.Forms.Label();
            this.grpChuyenNoiVien = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.uTitleExt1 = new Common.Winforms.UserControls.TitleExt.UTitleExt();
            this.ctrlThongTinCA1 = new EHR.App.DSHoSo.ctrlThongTinCA();
            this.ctrlThongTinBaoHiem1 = new EHR.App.DSHoSo.ctrlThongTinBaoHiem();
            ((System.ComponentModel.ISupportInitialize)(this.ugrpDoiTuong)).BeginInit();
            this.ugrpDoiTuong.SuspendLayout();
            this.grpChuyenVien.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ucboPhongKham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucboDichVu)).BeginInit();
            this.grpChuyenNoiVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // ugrpDoiTuong
            // 
            this.ugrpDoiTuong.Controls.Add(this.cboCA);
            this.ugrpDoiTuong.Controls.Add(this.rdCA);
            this.ugrpDoiTuong.Controls.Add(this.rdDichVu);
            this.ugrpDoiTuong.Controls.Add(this.rdBHXH);
            this.ugrpDoiTuong.Dock = System.Windows.Forms.DockStyle.Top;
            this.ugrpDoiTuong.Location = new System.Drawing.Point(0, 133);
            this.ugrpDoiTuong.Name = "ugrpDoiTuong";
            this.ugrpDoiTuong.Size = new System.Drawing.Size(612, 52);
            this.ugrpDoiTuong.TabIndex = 0;
            this.ugrpDoiTuong.Text = "Đối Tượng Áp Dụng";
            // 
            // cboCA
            // 
            this.cboCA.FormattingEnabled = true;
            this.cboCA.Location = new System.Drawing.Point(347, 24);
            this.cboCA.Name = "cboCA";
            this.cboCA.Size = new System.Drawing.Size(200, 22);
            this.cboCA.TabIndex = 4;
            this.cboCA.Text = "Cán bộ khám định kỳ";
            // 
            // rdCA
            // 
            this.rdCA.AutoSize = true;
            this.rdCA.Location = new System.Drawing.Point(271, 25);
            this.rdCA.Name = "rdCA";
            this.rdCA.Size = new System.Drawing.Size(74, 18);
            this.rdCA.TabIndex = 3;
            this.rdCA.Text = "Công an:";
            this.rdCA.UseVisualStyleBackColor = true;
            // 
            // rdDichVu
            // 
            this.rdDichVu.AutoSize = true;
            this.rdDichVu.Location = new System.Drawing.Point(189, 25);
            this.rdDichVu.Name = "rdDichVu";
            this.rdDichVu.Size = new System.Drawing.Size(65, 18);
            this.rdDichVu.TabIndex = 2;
            this.rdDichVu.Text = "Dịch vụ";
            this.rdDichVu.UseVisualStyleBackColor = true;
            // 
            // rdBHXH
            // 
            this.rdBHXH.AutoSize = true;
            this.rdBHXH.Checked = true;
            this.rdBHXH.Location = new System.Drawing.Point(34, 25);
            this.rdBHXH.Name = "rdBHXH";
            this.rdBHXH.Size = new System.Drawing.Size(137, 18);
            this.rdBHXH.TabIndex = 0;
            this.rdBHXH.TabStop = true;
            this.rdBHXH.Text = "Thẻ bảo hiểm xã hội";
            this.rdBHXH.UseVisualStyleBackColor = true;
            // 
            // grpChuyenVien
            // 
            this.grpChuyenVien.Controls.Add(this.textBox1);
            this.grpChuyenVien.Controls.Add(this.label1);
            this.grpChuyenVien.Controls.Add(this.textBox4);
            this.grpChuyenVien.Controls.Add(this.label5);
            this.grpChuyenVien.Controls.Add(this.textBox3);
            this.grpChuyenVien.Controls.Add(this.label3);
            this.grpChuyenVien.Controls.Add(this.textBox2);
            this.grpChuyenVien.Controls.Add(this.label2);
            this.grpChuyenVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpChuyenVien.Location = new System.Drawing.Point(0, 425);
            this.grpChuyenVien.Name = "grpChuyenVien";
            this.grpChuyenVien.Size = new System.Drawing.Size(612, 119);
            this.grpChuyenVien.TabIndex = 3;
            this.grpChuyenVien.TabStop = false;
            this.grpChuyenVien.Text = "Thông Tin Chuyển Viện";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 82);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.MaxLength = 15;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(423, 22);
            this.textBox1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(19, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 14);
            this.label1.TabIndex = 17;
            this.label1.Text = "Số giấy chuyển viện:";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(501, 25);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(80, 22);
            this.textBox4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mã đơn vị:";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(156, 53);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(423, 22);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chỉ định tuyến trước:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(156, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(270, 22);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nơi giới thiệu:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ucboPhongKham);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.ucboDichVu);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(612, 92);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đăng Ký Khám";
            // 
            // ucboPhongKham
            // 
            this.ucboPhongKham.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucboPhongKham.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ucboPhongKham.Location = new System.Drawing.Point(114, 51);
            this.ucboPhongKham.Name = "ucboPhongKham";
            this.ucboPhongKham.Size = new System.Drawing.Size(394, 23);
            this.ucboPhongKham.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phòng khám:";
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(514, 27);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(67, 18);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "Ưu tiên";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // ucboDichVu
            // 
            this.ucboDichVu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucboDichVu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ucboDichVu.Location = new System.Drawing.Point(114, 22);
            this.ucboDichVu.Name = "ucboDichVu";
            this.ucboDichVu.Size = new System.Drawing.Size(394, 23);
            this.ucboDichVu.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 14);
            this.label7.TabIndex = 6;
            this.label7.Text = "Dịch vụ:";
            // 
            // grpChuyenNoiVien
            // 
            this.grpChuyenNoiVien.Controls.Add(this.textBox7);
            this.grpChuyenNoiVien.Controls.Add(this.label8);
            this.grpChuyenNoiVien.Controls.Add(this.textBox8);
            this.grpChuyenNoiVien.Controls.Add(this.label9);
            this.grpChuyenNoiVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpChuyenNoiVien.Location = new System.Drawing.Point(0, 544);
            this.grpChuyenNoiVien.Name = "grpChuyenNoiVien";
            this.grpChuyenNoiVien.Size = new System.Drawing.Size(612, 88);
            this.grpChuyenNoiVien.TabIndex = 5;
            this.grpChuyenNoiVien.TabStop = false;
            this.grpChuyenNoiVien.Text = "Thông Tin Chuyển Nội Viện";
            this.grpChuyenNoiVien.Visible = false;
            // 
            // textBox7
            // 
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7.Location = new System.Drawing.Point(156, 53);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(423, 22);
            this.textBox7.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 14);
            this.label8.TabIndex = 4;
            this.label8.Text = "Chỉ định tuyến trước:";
            // 
            // textBox8
            // 
            this.textBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox8.Location = new System.Drawing.Point(156, 25);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(425, 22);
            this.textBox8.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 14);
            this.label9.TabIndex = 2;
            this.label9.Text = "Khoa/Phòng khám:";
            // 
            // uTitleExt1
            // 
            this.uTitleExt1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uTitleExt1.BackgroundImage")));
            this.uTitleExt1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uTitleExt1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uTitleExt1.ImageBG = Common.Winforms.UserControls.TitleExt.TitleBackgroud.Blue;
            this.uTitleExt1.Location = new System.Drawing.Point(0, 0);
            this.uTitleExt1.Name = "uTitleExt1";
            this.uTitleExt1.ShowButtonEdit = false;
            this.uTitleExt1.ShowButtonExt = false;
            this.uTitleExt1.Size = new System.Drawing.Size(612, 41);
            this.uTitleExt1.TabIndex = 83;
            this.uTitleExt1.Title = "THÔNG TIN TIẾP NHẬN";
            this.uTitleExt1.TypeOfTitle = Common.Winforms.UserControls.TitleExt.TitleType.Extend;
            // 
            // ctrlThongTinCA1
            // 
            this.ctrlThongTinCA1.AutoScroll = true;
            this.ctrlThongTinCA1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrlThongTinCA1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ctrlThongTinCA1.Location = new System.Drawing.Point(0, 334);
            this.ctrlThongTinCA1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlThongTinCA1.Name = "ctrlThongTinCA1";
            this.ctrlThongTinCA1.Size = new System.Drawing.Size(612, 91);
            this.ctrlThongTinCA1.TabIndex = 2;
            this.ctrlThongTinCA1.Visible = false;
            // 
            // ctrlThongTinBaoHiem1
            // 
            this.ctrlThongTinBaoHiem1.AutoScroll = true;
            this.ctrlThongTinBaoHiem1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrlThongTinBaoHiem1.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlThongTinBaoHiem1.Location = new System.Drawing.Point(0, 185);
            this.ctrlThongTinBaoHiem1.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlThongTinBaoHiem1.Name = "ctrlThongTinBaoHiem1";
            this.ctrlThongTinBaoHiem1.Size = new System.Drawing.Size(612, 149);
            this.ctrlThongTinBaoHiem1.TabIndex = 1;
            // 
            // ctrlThongTinTiepNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpChuyenNoiVien);
            this.Controls.Add(this.grpChuyenVien);
            this.Controls.Add(this.ctrlThongTinCA1);
            this.Controls.Add(this.ctrlThongTinBaoHiem1);
            this.Controls.Add(this.ugrpDoiTuong);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.uTitleExt1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "ctrlThongTinTiepNhan";
            this.Size = new System.Drawing.Size(612, 655);
            ((System.ComponentModel.ISupportInitialize)(this.ugrpDoiTuong)).EndInit();
            this.ugrpDoiTuong.ResumeLayout(false);
            this.ugrpDoiTuong.PerformLayout();
            this.grpChuyenVien.ResumeLayout(false);
            this.grpChuyenVien.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ucboPhongKham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucboDichVu)).EndInit();
            this.grpChuyenNoiVien.ResumeLayout(false);
            this.grpChuyenNoiVien.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraGroupBox ugrpDoiTuong;
        private System.Windows.Forms.ComboBox cboCA;
        private System.Windows.Forms.RadioButton rdCA;
        private System.Windows.Forms.RadioButton rdDichVu;
        private System.Windows.Forms.RadioButton rdBHXH;
        private EHR.App.DSHoSo.ctrlThongTinBaoHiem ctrlThongTinBaoHiem1;
        private EHR.App.DSHoSo.ctrlThongTinCA ctrlThongTinCA1;
        private System.Windows.Forms.GroupBox grpChuyenVien;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox2;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor ucboDichVu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpChuyenNoiVien;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor ucboPhongKham;
        private System.Windows.Forms.Label label4;
        private Common.Winforms.UserControls.TitleExt.UTitleExt uTitleExt1;
    }
}
