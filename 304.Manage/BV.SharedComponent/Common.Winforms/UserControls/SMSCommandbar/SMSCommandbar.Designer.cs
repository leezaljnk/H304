namespace Common.Winforms.UserControls.SMSCommandbar
{
    partial class SMSCommandbar
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSearch = new Telerik.WinControls.UI.RadButton();
            this.btnClose = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.btnSwicth = new Telerik.WinControls.UI.RadButton();
            this.btnSMS = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSwicth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSMS)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSearch.Image = global::Common.Winforms.Properties.Resources.search24;
            this.btnSearch.Location = new System.Drawing.Point(174, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(79, 49);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnSearch, "Tìm kiểm (F7)");
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClose.Image = global::Common.Winforms.Properties.Resources.Exit24;
            this.btnClose.Location = new System.Drawing.Point(375, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 49);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Thoát";
            this.btnClose.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnClose, "Thoát (F10)");
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSave.Image = global::Common.Winforms.Properties.Resources.save24;
            this.btnSave.Location = new System.Drawing.Point(0, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 49);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Ghi";
            this.btnSave.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnSave, "Ghi (F5)");
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSwicth
            // 
            this.btnSwicth.BackColor = System.Drawing.Color.Transparent;
            this.btnSwicth.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSwicth.Image = global::Common.Winforms.Properties.Resources.bangthongke24;
            this.btnSwicth.Location = new System.Drawing.Point(253, 0);
            this.btnSwicth.Name = "btnSwicth";
            this.btnSwicth.Size = new System.Drawing.Size(122, 49);
            this.btnSwicth.TabIndex = 6;
            this.btnSwicth.Text = "Bảng tổng hợp";
            this.btnSwicth.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSwicth.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSwicth.Click += new System.EventHandler(this.btnSwicth_Click);
            // 
            // btnSMS
            // 
            this.btnSMS.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSMS.Image = global::Common.Winforms.Properties.Resources.sms24;
            this.btnSMS.Location = new System.Drawing.Point(79, 0);
            this.btnSMS.Name = "btnSMS";
            this.btnSMS.Size = new System.Drawing.Size(95, 49);
            this.btnSMS.TabIndex = 4;
            this.btnSMS.Text = "Gửi tin nhắn";
            this.btnSMS.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSMS.Click += new System.EventHandler(this.btnSMS_Click);
            // 
            // SMSCommandbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSwicth);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSMS);
            this.Controls.Add(this.btnSave);
            this.Name = "SMSCommandbar";
            this.Size = new System.Drawing.Size(682, 49);
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSwicth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSMS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadButton btnSMS;
        private Telerik.WinControls.UI.RadButton btnClose;
        private Telerik.WinControls.UI.RadButton btnSwicth;
        private Telerik.WinControls.UI.RadButton btnSearch;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
