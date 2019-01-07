﻿namespace BV.QLKHO.THUOC
{
    partial class ThongTinLoHangForm
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
            this.txtTenThuoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoLo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.bvDateTimeCtrl1 = new BV.SharedComponent.Controls.BVDateTimeCtrl();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenThuoc.BackColor = System.Drawing.SystemColors.Window;
            this.txtTenThuoc.Location = new System.Drawing.Point(111, 16);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.ReadOnly = true;
            this.txtTenThuoc.Size = new System.Drawing.Size(408, 22);
            this.txtTenThuoc.TabIndex = 6;
            this.txtTenThuoc.TextChanged += new System.EventHandler(this.txtSoDangKy_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên thuốc:";
            // 
            // txtSoLo
            // 
            this.txtSoLo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoLo.Location = new System.Drawing.Point(111, 44);
            this.txtSoLo.Name = "txtSoLo";
            this.txtSoLo.Size = new System.Drawing.Size(408, 22);
            this.txtSoLo.TabIndex = 8;
            this.txtSoLo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "Số lô:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hạn sử dụng:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(337, 110);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(87, 25);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "Lưu";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(432, 110);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 25);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Đóng";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // bvDateTimeCtrl1
            // 
            this.bvDateTimeCtrl1.Location = new System.Drawing.Point(112, 72);
            this.bvDateTimeCtrl1.Name = "bvDateTimeCtrl1";
            this.bvDateTimeCtrl1.Size = new System.Drawing.Size(407, 22);
            this.bvDateTimeCtrl1.TabIndex = 14;
            this.bvDateTimeCtrl1.Value = null;
            this.bvDateTimeCtrl1.ValueText = "";
            this.bvDateTimeCtrl1.Load += new System.EventHandler(this.bvDateTimeCtrl1_Load);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ThongTinLoHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(533, 145);
            this.ControlBox = false;
            this.Controls.Add(this.bvDateTimeCtrl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoLo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenThuoc);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ThongTinLoHangForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông Tin Lô Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenThuoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoLo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private SharedComponent.Controls.BVDateTimeCtrl bvDateTimeCtrl1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}