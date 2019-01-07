namespace BV.TiepNhanHoSo
{
    partial class ctrPhieuTiepNhanFull
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.hsbN_ThongTinHanhChinhRutGon1 = new EHR.App.HSBenhNhan.HSBN_ThongTinHanhChinhRutGon();
            this.ctrPhieuTiepNhan1 = new BV.TiepNhanHoSo.ctrlThongTinTiepNhan();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.hsbN_ThongTinHanhChinhRutGon1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ctrPhieuTiepNhan1);
            this.splitContainer1.Size = new System.Drawing.Size(989, 562);
            this.splitContainer1.SplitterDistance = 346;
            this.splitContainer1.TabIndex = 0;
            // 
            // hsbN_ThongTinHanhChinhRutGon1
            // 
            this.hsbN_ThongTinHanhChinhRutGon1._entity = null;
            this.hsbN_ThongTinHanhChinhRutGon1._hssk_Id = null;
            this.hsbN_ThongTinHanhChinhRutGon1.AutoScroll = true;
            this.hsbN_ThongTinHanhChinhRutGon1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hsbN_ThongTinHanhChinhRutGon1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsbN_ThongTinHanhChinhRutGon1.Location = new System.Drawing.Point(0, 0);
            this.hsbN_ThongTinHanhChinhRutGon1.Margin = new System.Windows.Forms.Padding(4);
            this.hsbN_ThongTinHanhChinhRutGon1.Name = "hsbN_ThongTinHanhChinhRutGon1";
            this.hsbN_ThongTinHanhChinhRutGon1.SettingChanged = false;
            this.hsbN_ThongTinHanhChinhRutGon1.Size = new System.Drawing.Size(346, 562);
            this.hsbN_ThongTinHanhChinhRutGon1.TabIndex = 0;
            // 
            // ctrPhieuTiepNhan1
            // 
            this.ctrPhieuTiepNhan1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrPhieuTiepNhan1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ctrPhieuTiepNhan1.Location = new System.Drawing.Point(0, 0);
            this.ctrPhieuTiepNhan1.Name = "ctrPhieuTiepNhan1";
            this.ctrPhieuTiepNhan1.Size = new System.Drawing.Size(639, 562);
            this.ctrPhieuTiepNhan1.TabIndex = 0;
            // 
            // ctrPhieuTiepNhanFull
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "ctrPhieuTiepNhanFull";
            this.Size = new System.Drawing.Size(989, 562);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private ctrlThongTinTiepNhan ctrPhieuTiepNhan1;
        private EHR.App.HSBenhNhan.HSBN_ThongTinHanhChinhRutGon hsbN_ThongTinHanhChinhRutGon1;
    }
}
