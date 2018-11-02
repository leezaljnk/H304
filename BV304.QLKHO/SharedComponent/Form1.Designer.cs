namespace BVSharedComponent
{
    partial class Form1
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
            this.toolbarGeneral1 = new BVSharedComponent.ToolbarGeneral();
            this.SuspendLayout();
            // 
            // toolbarGeneral1
            // 
            this.toolbarGeneral1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolbarGeneral1.Location = new System.Drawing.Point(0, 0);
            this.toolbarGeneral1.Name = "toolbarGeneral1";
            this.toolbarGeneral1.Size = new System.Drawing.Size(606, 31);
            this.toolbarGeneral1.TabIndex = 0;
            this.toolbarGeneral1.Text = "toolbarGeneral1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 414);
            this.Controls.Add(this.toolbarGeneral1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolbarGeneral toolbarGeneral1;
    }
}