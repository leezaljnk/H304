namespace EHR.App.DSHoSo
{
    partial class ctrlThongTinBaoHiem
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaCSBD = new System.Windows.Forms.TextBox();
            this.txtTenCSBD = new System.Windows.Forms.TextBox();
            this.datDenNgay = new System.Windows.Forms.MaskedTextBox();
            this.datTuNgay = new System.Windows.Forms.MaskedTextBox();
            this.txtSoBHYT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.chkMienDCT = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkMienDCT);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txtMaCSBD);
            this.groupBox1.Controls.Add(this.txtTenCSBD);
            this.groupBox1.Controls.Add(this.datDenNgay);
            this.groupBox1.Controls.Add(this.datTuNgay);
            this.groupBox1.Controls.Add(this.txtSoBHYT);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(582, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Bảo Hiểm";
            // 
            // txtMaCSBD
            // 
            this.txtMaCSBD.Location = new System.Drawing.Point(464, 57);
            this.txtMaCSBD.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaCSBD.MaxLength = 15;
            this.txtMaCSBD.Name = "txtMaCSBD";
            this.txtMaCSBD.Size = new System.Drawing.Size(90, 22);
            this.txtMaCSBD.TabIndex = 10;
            // 
            // txtTenCSBD
            // 
            this.txtTenCSBD.Location = new System.Drawing.Point(124, 56);
            this.txtTenCSBD.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenCSBD.MaxLength = 15;
            this.txtTenCSBD.Name = "txtTenCSBD";
            this.txtTenCSBD.Size = new System.Drawing.Size(289, 22);
            this.txtTenCSBD.TabIndex = 9;
            // 
            // datDenNgay
            // 
            this.datDenNgay.Location = new System.Drawing.Point(383, 115);
            this.datDenNgay.Margin = new System.Windows.Forms.Padding(4);
            this.datDenNgay.Mask = "00/00/0000";
            this.datDenNgay.Name = "datDenNgay";
            this.datDenNgay.Size = new System.Drawing.Size(132, 22);
            this.datDenNgay.TabIndex = 8;
            this.datDenNgay.ValidatingType = typeof(System.DateTime);
            this.datDenNgay.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.datDenNgay_MaskInputRejected);
            this.datDenNgay.TextChanged += new System.EventHandler(this.txtMaCSBD_TextChanged);
            // 
            // datTuNgay
            // 
            this.datTuNgay.Location = new System.Drawing.Point(124, 115);
            this.datTuNgay.Margin = new System.Windows.Forms.Padding(4);
            this.datTuNgay.Mask = "00/00/0000";
            this.datTuNgay.Name = "datTuNgay";
            this.datTuNgay.Size = new System.Drawing.Size(108, 22);
            this.datTuNgay.TabIndex = 6;
            this.datTuNgay.ValidatingType = typeof(System.DateTime);
            this.datTuNgay.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.datTuNgay_MaskInputRejected);
            this.datTuNgay.TextChanged += new System.EventHandler(this.txtMaCSBD_TextChanged);
            // 
            // txtSoBHYT
            // 
            this.txtSoBHYT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSoBHYT.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoBHYT.Location = new System.Drawing.Point(124, 26);
            this.txtSoBHYT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoBHYT.MaxLength = 15;
            this.txtSoBHYT.Name = "txtSoBHYT";
            this.txtSoBHYT.Size = new System.Drawing.Size(40, 22);
            this.txtSoBHYT.TabIndex = 1;
            this.txtSoBHYT.Text = "HC";
            this.txtSoBHYT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSoBHYT.TextChanged += new System.EventHandler(this.txtSoBHYT_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(244, 118);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "Thời điểm đủ 05 năm:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(16, 118);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Giá trị từ ngày:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(16, 60);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nơi ĐK KCB BĐ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(16, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số BHYT:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(172, 26);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.MaxLength = 15;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(40, 22);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "4";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(220, 26);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.MaxLength = 15;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(40, 22);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "01";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(268, 26);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.MaxLength = 15;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(106, 22);
            this.textBox3.TabIndex = 13;
            this.textBox3.Text = "011 627 8708";
            // 
            // chkMienDCT
            // 
            this.chkMienDCT.AutoSize = true;
            this.chkMienDCT.Location = new System.Drawing.Point(124, 85);
            this.chkMienDCT.Name = "chkMienDCT";
            this.chkMienDCT.Size = new System.Drawing.Size(242, 20);
            this.chkMienDCT.TabIndex = 14;
            this.chkMienDCT.Text = "Miễn đồng chi trả (mức hưởng 100%)";
            this.chkMienDCT.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(426, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mã:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(381, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ctrlThongTinBaoHiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ctrlThongTinBaoHiem";
            this.Size = new System.Drawing.Size(582, 150);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox datDenNgay;
        private System.Windows.Forms.MaskedTextBox datTuNgay;
        private System.Windows.Forms.TextBox txtSoBHYT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtMaCSBD;
        private System.Windows.Forms.TextBox txtTenCSBD;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox chkMienDCT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
