namespace Common.Winforms.UserControls.TitleExt
{
    partial class UTitleExt
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEdit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(424, 43);
            this.label3.TabIndex = 4;
            this.label3.Text = "THÔNG TIN BỆNH NHÂN";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Image = global::Common.Winforms.Properties.Resources.down_button_18x18px;
            this.label4.Location = new System.Drawing.Point(460, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 43);
            this.label4.TabIndex = 5;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblEdit
            // 
            this.lblEdit.BackColor = System.Drawing.Color.Transparent;
            this.lblEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblEdit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit.ForeColor = System.Drawing.SystemColors.Window;
            this.lblEdit.Image = global::Common.Winforms.Properties.Resources.edit_icon;
            this.lblEdit.Location = new System.Drawing.Point(424, 0);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(36, 43);
            this.lblEdit.TabIndex = 6;
            this.lblEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEdit.Visible = false;
            this.lblEdit.Click += new System.EventHandler(this.lblEdit_Click);
            // 
            // UTitleExt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Common.Winforms.Properties.Resources.info_menu_bg_01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.label4);
            this.DoubleBuffered = true;
            this.Name = "UTitleExt";
            this.Size = new System.Drawing.Size(496, 43);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblEdit;
    }
}
