namespace BV.QuanTriHeThong.KhoaPhongBV
{
    partial class ThongTinHanhChinhForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.ctrlThongTinHanhChinh1 = new EHR.App.HSBenhNhan.ctrlThongTinHanhChinh();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(339, 452);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 25);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(245, 452);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(87, 25);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "Chấp nhận";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ctrlThongTinHanhChinh1
            // 
            this.ctrlThongTinHanhChinh1._entity = null;
            this.ctrlThongTinHanhChinh1._hssk_Id = null;
            this.ctrlThongTinHanhChinh1.AutoScroll = true;
            this.ctrlThongTinHanhChinh1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlThongTinHanhChinh1.Location = new System.Drawing.Point(2, 2);
            this.ctrlThongTinHanhChinh1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlThongTinHanhChinh1.Name = "ctrlThongTinHanhChinh1";
            this.ctrlThongTinHanhChinh1.SettingChanged = false;
            this.ctrlThongTinHanhChinh1.Size = new System.Drawing.Size(464, 443);
            this.ctrlThongTinHanhChinh1.TabIndex = 5;
            this.ctrlThongTinHanhChinh1.VisibleTitleExt = false;
            // 
            // ThongTinHanhChinhForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(465, 493);
            this.Controls.Add(this.ctrlThongTinHanhChinh1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Name = "ThongTinHanhChinhForm";
            this.Text = "Thông Tin Cá Nhân";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private EHR.App.HSBenhNhan.ctrlThongTinHanhChinh ctrlThongTinHanhChinh1;
    }
}