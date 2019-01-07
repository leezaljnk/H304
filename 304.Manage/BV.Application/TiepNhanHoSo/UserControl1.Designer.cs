namespace BV.TiepNhanHoSo
{
    partial class UserControl1
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
            this.hsbN_ThongTinHanhChinh1 = new EHR.App.HSBenhNhan.ctrlThongTinHanhChinh();
            this.SuspendLayout();
            // 
            // hsbN_ThongTinHanhChinh1
            // 
            this.hsbN_ThongTinHanhChinh1._entity = null;
            this.hsbN_ThongTinHanhChinh1._hssk_Id = null;
            this.hsbN_ThongTinHanhChinh1.AutoScroll = true;
            this.hsbN_ThongTinHanhChinh1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsbN_ThongTinHanhChinh1.Location = new System.Drawing.Point(0, 0);
            this.hsbN_ThongTinHanhChinh1.Margin = new System.Windows.Forms.Padding(4);
            this.hsbN_ThongTinHanhChinh1.Name = "hsbN_ThongTinHanhChinh1";
            this.hsbN_ThongTinHanhChinh1.SettingChanged = false;
            this.hsbN_ThongTinHanhChinh1.Size = new System.Drawing.Size(678, 299);
            this.hsbN_ThongTinHanhChinh1.TabIndex = 0;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hsbN_ThongTinHanhChinh1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(745, 591);
            this.ResumeLayout(false);

        }

        #endregion

        private EHR.App.HSBenhNhan.ctrlThongTinHanhChinh hsbN_ThongTinHanhChinh1;
    }
}
