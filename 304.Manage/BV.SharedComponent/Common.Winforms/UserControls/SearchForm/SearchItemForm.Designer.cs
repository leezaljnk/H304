namespace Common.Winforms
{
    partial class SearchItemForm
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
            this.grb = new System.Windows.Forms.GroupBox();
            this.txtContent = new C1.Win.C1Input.C1TextBox();
            this.btnClose = new C1.Win.C1Input.C1Button();
            this.btnSearch = new C1.Win.C1Input.C1Button();
            this.grb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // grb
            // 
            this.grb.BackColor = System.Drawing.Color.Transparent;
            this.grb.Controls.Add(this.txtContent);
            this.grb.Controls.Add(this.btnClose);
            this.grb.Controls.Add(this.btnSearch);
            this.grb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb.Location = new System.Drawing.Point(0, 0);
            this.grb.Margin = new System.Windows.Forms.Padding(0);
            this.grb.MaximumSize = new System.Drawing.Size(284, 78);
            this.grb.MinimumSize = new System.Drawing.Size(284, 78);
            this.grb.Name = "grb";
            this.grb.Padding = new System.Windows.Forms.Padding(0);
            this.grb.Size = new System.Drawing.Size(284, 78);
            this.grb.TabIndex = 1;
            this.grb.TabStop = false;
            // 
            // txtContent
            // 
            this.txtContent.AcceptsEscape = false;
            this.txtContent.AutoSize = false;
            this.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContent.DataType = typeof(string);
            this.txtContent.Location = new System.Drawing.Point(9, 13);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(268, 18);
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
            this.btnClose.Location = new System.Drawing.Point(205, 37);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(73, 28);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "    Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Image = global::Common.Winforms.Properties.Resources.search24;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(129, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 28);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // SearchItemForm
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(284, 69);
            this.ControlBox = false;
            this.Controls.Add(this.grb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(292, 107);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(292, 107);
            this.Name = "SearchItemForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(292, 107);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tìm kiếm";
            this.grb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb;
        private C1.Win.C1Input.C1TextBox txtContent;
        private C1.Win.C1Input.C1Button btnClose;
        private C1.Win.C1Input.C1Button btnSearch;
    }
}