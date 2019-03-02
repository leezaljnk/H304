using BV.QLKHO.KhoChan.NhapThuoc;

namespace BV.QLKHO.PhieuNhapThuoc
{
    partial class PhieuNhapForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.phieuNhapThuocCtrl1 = new PhieuNhapThuocCtrl();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(1067, 508);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 25);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Chấp nhận";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(1162, 508);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 25);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // phieuNhapThuocCtrl1
            // 
            this.phieuNhapThuocCtrl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.phieuNhapThuocCtrl1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.phieuNhapThuocCtrl1.Location = new System.Drawing.Point(0, 0);
            this.phieuNhapThuocCtrl1.Name = "phieuNhapThuocCtrl1";
            this.phieuNhapThuocCtrl1.Size = new System.Drawing.Size(1263, 501);
            this.phieuNhapThuocCtrl1.TabIndex = 0;
            // 
            // PhieuNhapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 545);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.phieuNhapThuocCtrl1);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Name = "PhieuNhapForm";
            this.ShowInTaskbar = false;
            this.Text = "Phiếu Nhập Kho";
            this.ResumeLayout(false);

        }

        #endregion

        private PhieuNhapThuocCtrl phieuNhapThuocCtrl1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}