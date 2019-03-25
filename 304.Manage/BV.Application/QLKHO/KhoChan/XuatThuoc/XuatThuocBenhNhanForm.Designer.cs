namespace BV.QLKHO.KhoChan.XuatThuoc
{
    partial class XuatThuocBenhNhanForm
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
            this.xuatThuocBNCtrl1 = new BV.QLKHO.KhoChan.XuatThuoc.XuatThuocBNCtrl();
            this.SuspendLayout();
            // 
            // xuatThuocBNCtrl1
            // 
            this.xuatThuocBNCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuatThuocBNCtrl1.Location = new System.Drawing.Point(0, 0);
            this.xuatThuocBNCtrl1.Name = "xuatThuocBNCtrl1";
            this.xuatThuocBNCtrl1.Size = new System.Drawing.Size(1393, 810);
            this.xuatThuocBNCtrl1.TabIndex = 0;
            // 
            // XuatThuocBenhNhanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 810);
            this.Controls.Add(this.xuatThuocBNCtrl1);
            this.Name = "XuatThuocBenhNhanForm";
            this.Text = "Xuất thuốc bệnh nhân";
            this.ResumeLayout(false);

        }

        #endregion

        private XuatThuocBNCtrl xuatThuocBNCtrl1;
    }
}