namespace BV.QLKHO.KhoBV
{
    partial class DanhMucKhoForm
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
            this.ultraLabel8 = new Infragistics.Win.Misc.UltraLabel();
            this.btnCancel = new Infragistics.Win.Misc.UltraButton();
            this.btnSave = new Infragistics.Win.Misc.UltraButton();
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.txtTenKho = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.txtMaKho = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.cboKhoa = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.cboLoaiKho = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiKho)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraLabel8
            // 
            this.ultraLabel8.Location = new System.Drawing.Point(22, 77);
            this.ultraLabel8.Name = "ultraLabel8";
            this.ultraLabel8.Size = new System.Drawing.Size(100, 17);
            this.ultraLabel8.TabIndex = 4;
            this.ultraLabel8.Text = "Loại kho";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(455, 139);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(374, 139);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Chấp nhận";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ultraLabel3
            // 
            this.ultraLabel3.Location = new System.Drawing.Point(22, 103);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.Size = new System.Drawing.Size(100, 17);
            this.ultraLabel3.TabIndex = 6;
            this.ultraLabel3.Text = "Khoa";
            // 
            // txtTenKho
            // 
            this.txtTenKho.Location = new System.Drawing.Point(128, 46);
            this.txtTenKho.Name = "txtTenKho";
            this.txtTenKho.Size = new System.Drawing.Size(402, 21);
            this.txtTenKho.TabIndex = 3;
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.Location = new System.Drawing.Point(22, 50);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(100, 17);
            this.ultraLabel2.TabIndex = 2;
            this.ultraLabel2.Text = "Tên kho";
            // 
            // txtMaKho
            // 
            this.txtMaKho.Location = new System.Drawing.Point(128, 19);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(402, 21);
            this.txtMaKho.TabIndex = 1;
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.Location = new System.Drawing.Point(22, 23);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(100, 17);
            this.ultraLabel1.TabIndex = 0;
            this.ultraLabel1.Text = "Mã kho";
            // 
            // cboKhoa
            // 
            this.cboKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboKhoa.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.OnMouseEnter;
            this.cboKhoa.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cboKhoa.Location = new System.Drawing.Point(128, 100);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(402, 21);
            this.cboKhoa.TabIndex = 7;
            // 
            // cboLoaiKho
            // 
            this.cboLoaiKho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLoaiKho.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.OnMouseEnter;
            this.cboLoaiKho.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cboLoaiKho.Location = new System.Drawing.Point(128, 73);
            this.cboLoaiKho.Name = "cboLoaiKho";
            this.cboLoaiKho.Size = new System.Drawing.Size(402, 21);
            this.cboLoaiKho.TabIndex = 5;
            // 
            // DanhMucKhoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 176);
            this.Controls.Add(this.cboLoaiKho);
            this.Controls.Add(this.cboKhoa);
            this.Controls.Add(this.ultraLabel8);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ultraLabel3);
            this.Controls.Add(this.txtTenKho);
            this.Controls.Add(this.ultraLabel2);
            this.Controls.Add(this.txtMaKho);
            this.Controls.Add(this.ultraLabel1);
            this.Name = "DanhMucKhoForm";
            this.Text = "Thông tin kho";
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Infragistics.Win.Misc.UltraLabel ultraLabel8;
        private Infragistics.Win.Misc.UltraButton btnCancel;
        private Infragistics.Win.Misc.UltraButton btnSave;
        private Infragistics.Win.Misc.UltraLabel ultraLabel3;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtTenKho;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtMaKho;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor cboKhoa;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor cboLoaiKho;
    }
}