namespace BV.QLKHO.KhoChan
{
    partial class HuyPhieuDeNghiForm
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
            this.txtLyDoHuy = new System.Windows.Forms.RichTextBox();
            this.btnHuyDN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLyDoHuy
            // 
            this.txtLyDoHuy.Location = new System.Drawing.Point(14, 13);
            this.txtLyDoHuy.Name = "txtLyDoHuy";
            this.txtLyDoHuy.Size = new System.Drawing.Size(626, 195);
            this.txtLyDoHuy.TabIndex = 0;
            this.txtLyDoHuy.Text = "";
            // 
            // btnHuyDN
            // 
            this.btnHuyDN.Location = new System.Drawing.Point(537, 226);
            this.btnHuyDN.Name = "btnHuyDN";
            this.btnHuyDN.Size = new System.Drawing.Size(101, 27);
            this.btnHuyDN.TabIndex = 5;
            this.btnHuyDN.Text = "Hủy ĐN";
            this.btnHuyDN.UseVisualStyleBackColor = true;
            this.btnHuyDN.Click += new System.EventHandler(this.btnHuyDN_Click);
            // 
            // HuyPhieuDeNghiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 262);
            this.Controls.Add(this.btnHuyDN);
            this.Controls.Add(this.txtLyDoHuy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HuyPhieuDeNghiForm";
            this.Text = "Lý do Hủy phiếu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtLyDoHuy;
        private System.Windows.Forms.Button btnHuyDN;
    }
}