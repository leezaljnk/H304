namespace EHR.App.HSBenhNhan
{
    partial class FormBHYT
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
            this.ctrlThongTinBaoHiem1 = new EHR.App.DSHoSo.ctrlThongTinBaoHiem();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(471, 200);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 26);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Bỏ qua";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(390, 200);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 26);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "Đồng ý";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ctrlThongTinBaoHiem1
            // 
            this.ctrlThongTinBaoHiem1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlThongTinBaoHiem1.AutoScroll = true;
            this.ctrlThongTinBaoHiem1.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlThongTinBaoHiem1.Location = new System.Drawing.Point(5, 14);
            this.ctrlThongTinBaoHiem1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ctrlThongTinBaoHiem1.Name = "ctrlThongTinBaoHiem1";
            this.ctrlThongTinBaoHiem1.Size = new System.Drawing.Size(540, 179);
            this.ctrlThongTinBaoHiem1.TabIndex = 0;
            this.ctrlThongTinBaoHiem1.EventSettingChanged += new System.EventHandler(this.ctrlThongTinBaoHiem1_EventSettingChanged);
            // 
            // FormBHYT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(558, 236);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.ctrlThongTinBaoHiem1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(574, 275);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(574, 275);
            this.Name = "FormBHYT";
            this.ShowInTaskbar = false;
            this.Text = "Thông Tin Thẻ Bảo Hiểm  Y Tế";
            this.ResumeLayout(false);

        }

        #endregion

        private DSHoSo.ctrlThongTinBaoHiem ctrlThongTinBaoHiem1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}