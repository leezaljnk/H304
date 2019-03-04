namespace BV.QLKHO.KhoChan.ThuHoiThuoc
{
    partial class ThuHoiThuocForm
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
            this.thuHoiThuocCtrl1 = new BV.QLKHO.KhoChan.ThuHoiThuoc.ThuHoiThuocCtrl();
            this.SuspendLayout();
            // 
            // thuHoiThuocCtrl1
            // 
            this.thuHoiThuocCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thuHoiThuocCtrl1.Location = new System.Drawing.Point(0, 0);
            this.thuHoiThuocCtrl1.Name = "thuHoiThuocCtrl1";
            this.thuHoiThuocCtrl1.Size = new System.Drawing.Size(1472, 624);
            this.thuHoiThuocCtrl1.TabIndex = 0;
            // 
            // ThuHoiThuocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 624);
            this.Controls.Add(this.thuHoiThuocCtrl1);
            this.Name = "ThuHoiThuocForm";
            this.Text = "ThuHoiThuocForm";
            this.ResumeLayout(false);

        }

        #endregion

        private ThuHoiThuocCtrl thuHoiThuocCtrl1;
    }
}