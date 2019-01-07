namespace Common.Winforms.UserControls.SearchForm
{
    partial class SearchItemFrm
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
            this.radTitleBar1 = new Telerik.WinControls.UI.RadTitleBar();
            this.grb = new System.Windows.Forms.GroupBox();
            this.txtContent = new C1.Win.C1Input.C1TextBox();
            this.btnClose = new C1.Win.C1Input.C1Button();
            this.btnSearch = new C1.Win.C1Input.C1Button();
            this.qsfShape1 = new Telerik.WinControls.QsfShape(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).BeginInit();
            this.grb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtContent)).BeginInit();
            this.SuspendLayout();
            // 
            // radTitleBar1
            // 
            this.radTitleBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radTitleBar1.Caption = "SearchItemFrm";
            this.radTitleBar1.Location = new System.Drawing.Point(1, 1);
            this.radTitleBar1.Name = "radTitleBar1";
            // 
            // 
            // 
            this.radTitleBar1.RootElement.ApplyShapeToControl = true;
            this.radTitleBar1.Size = new System.Drawing.Size(287, 23);
            this.radTitleBar1.TabIndex = 0;
            this.radTitleBar1.TabStop = false;
            this.radTitleBar1.Text = "SearchItemFrm";
            // 
            // grb
            // 
            this.grb.Controls.Add(this.txtContent);
            this.grb.Controls.Add(this.btnClose);
            this.grb.Controls.Add(this.btnSearch);
            this.grb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb.Location = new System.Drawing.Point(0, 0);
            this.grb.Name = "grb";
            this.grb.Padding = new System.Windows.Forms.Padding(0);
            this.grb.Size = new System.Drawing.Size(289, 85);
            this.grb.TabIndex = 2;
            this.grb.TabStop = false;
            // 
            // txtContent
            // 
            this.txtContent.AcceptsEscape = false;
            this.txtContent.AutoSize = false;
            this.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContent.DataType = typeof(string);
            this.txtContent.Location = new System.Drawing.Point(9, 22);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(272, 18);
            this.txtContent.TabIndex = 1;
            this.txtContent.Tag = null;
            this.txtContent.TrimEnd = false;
            this.txtContent.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Black;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = global::Common.Winforms.Properties.Resources.Cancel;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(207, 46);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(77, 31);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "    Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Image = global::Common.Winforms.Properties.Resources.search24;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(129, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(77, 31);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // SearchItemFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(289, 85);
            this.Controls.Add(this.grb);
            this.Controls.Add(this.radTitleBar1);
            this.Name = "SearchItemFrm";
            this.Shape = this.qsfShape1;
            this.Text = "SearchItemFrm";
            this.Load += new System.EventHandler(this.SearchItemFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).EndInit();
            this.grb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtContent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTitleBar radTitleBar1;
        private System.Windows.Forms.GroupBox grb;
        private C1.Win.C1Input.C1TextBox txtContent;
        private C1.Win.C1Input.C1Button btnClose;
        private C1.Win.C1Input.C1Button btnSearch;
        //private Telerik.WinControls.QsfShape qsfShape1;
    }
}