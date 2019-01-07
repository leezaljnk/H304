namespace BV.TiepNhanHoSo
{
    partial class TiepNhanForm
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
            this.ctrPhieuTiepNhan_simple1= new BV.TiepNhanHoSo.ctrPhieuTiepNhanFull();
            this.SuspendLayout();
            // 
            // ctrPhieuTiepNhan_simple1
            // 
            this.ctrPhieuTiepNhan_simple1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrPhieuTiepNhan_simple1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ctrPhieuTiepNhan_simple1.Location = new System.Drawing.Point(0, 0);
            this.ctrPhieuTiepNhan_simple1.Name = "ctrPhieuTiepNhan_simple1";
            this.ctrPhieuTiepNhan_simple1.Size = new System.Drawing.Size(1085, 511);
            this.ctrPhieuTiepNhan_simple1.TabIndex = 0;
            // 
            // TiepNhanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 511);
            this.Controls.Add(this.ctrPhieuTiepNhan_simple1);
            this.Name = "TiepNhanForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Tiếp Nhận Bệnh Nhân";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrPhieuTiepNhanFull ctrPhieuTiepNhan_simple1;
    }
}