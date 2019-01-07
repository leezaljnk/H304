namespace Common.Winforms.UserControls
{
    partial class DonViFullSelect
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonViFullSelect));
            this.pagBranch = new Telerik.WinControls.UI.RadPageView();
            this.radPageViewPage1 = new Telerik.WinControls.UI.RadPageViewPage();
            this.trvDonViGD = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.radPageViewPage2 = new Telerik.WinControls.UI.RadPageViewPage();
            this.trvDonViDT = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pagBranch)).BeginInit();
            this.pagBranch.SuspendLayout();
            this.radPageViewPage1.SuspendLayout();
            this.radPageViewPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pagBranch
            // 
            this.pagBranch.Controls.Add(this.radPageViewPage1);
            this.pagBranch.Controls.Add(this.radPageViewPage2);
            this.pagBranch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagBranch.Location = new System.Drawing.Point(0, 0);
            this.pagBranch.Name = "pagBranch";
            this.pagBranch.SelectedPage = this.radPageViewPage1;
            this.pagBranch.Size = new System.Drawing.Size(377, 409);
            this.pagBranch.TabIndex = 0;
            this.pagBranch.Text = "radPageView1";
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.pagBranch.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            // 
            // radPageViewPage1
            // 
            this.radPageViewPage1.Controls.Add(this.trvDonViGD);
            this.radPageViewPage1.Location = new System.Drawing.Point(10, 37);
            this.radPageViewPage1.Name = "radPageViewPage1";
            this.radPageViewPage1.Size = new System.Drawing.Size(356, 361);
            this.radPageViewPage1.Text = "Khối giáo dục";
            // 
            // trvDonViGD
            // 
            this.trvDonViGD.BackColor = System.Drawing.SystemColors.Info;
            this.trvDonViGD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trvDonViGD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvDonViGD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvDonViGD.FullRowSelect = true;
            this.trvDonViGD.HideSelection = false;
            this.trvDonViGD.ImageIndex = 0;
            this.trvDonViGD.ImageList = this.imageList1;
            this.trvDonViGD.Location = new System.Drawing.Point(0, 0);
            this.trvDonViGD.Name = "trvDonViGD";
            this.trvDonViGD.SelectedImageIndex = 1;
            this.trvDonViGD.Size = new System.Drawing.Size(356, 361);
            this.trvDonViGD.TabIndex = 1;
            this.trvDonViGD.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvDonViGD_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Moet_log24.jpg");
            this.imageList1.Images.SetKeyName(1, "Home32.png");
            this.imageList1.Images.SetKeyName(2, "TruongCapHoc.png");
            this.imageList1.Images.SetKeyName(3, "School32.png");
            this.imageList1.Images.SetKeyName(4, "house32.png");
            // 
            // radPageViewPage2
            // 
            this.radPageViewPage2.Controls.Add(this.trvDonViDT);
            this.radPageViewPage2.Location = new System.Drawing.Point(10, 37);
            this.radPageViewPage2.Name = "radPageViewPage2";
            this.radPageViewPage2.Size = new System.Drawing.Size(356, 361);
            this.radPageViewPage2.Text = "Khối đào tạo";
            // 
            // trvDonViDT
            // 
            this.trvDonViDT.BackColor = System.Drawing.SystemColors.Info;
            this.trvDonViDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trvDonViDT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvDonViDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvDonViDT.FullRowSelect = true;
            this.trvDonViDT.HideSelection = false;
            this.trvDonViDT.ImageIndex = 0;
            this.trvDonViDT.ImageList = this.imageList1;
            this.trvDonViDT.Location = new System.Drawing.Point(0, 0);
            this.trvDonViDT.Name = "trvDonViDT";
            this.trvDonViDT.SelectedImageIndex = 0;
            this.trvDonViDT.Size = new System.Drawing.Size(356, 361);
            this.trvDonViDT.TabIndex = 2;
            this.trvDonViDT.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvDonViDT_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 409);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 43);
            this.panel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(297, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "   &Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Enabled = false;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(216, 8);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 28);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "&Đồng ý";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // DonViFullSelect
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(377, 452);
            this.ControlBox = false;
            this.Controls.Add(this.pagBranch);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = global::Common.Winforms.Properties.Resources.MOETlogo48; 
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DonViFullSelect";
            this.Text = "Chọn đơn vị";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DonViFullSelect_FormClosed);
            this.Load += new System.EventHandler(this.DonViFullSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pagBranch)).EndInit();
            this.pagBranch.ResumeLayout(false);
            this.radPageViewPage1.ResumeLayout(false);
            this.radPageViewPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView pagBranch;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TreeView trvDonViGD;
        private System.Windows.Forms.TreeView trvDonViDT;
        private System.Windows.Forms.ImageList imageList1;
    }
}