namespace BVSharedComponent
{
    partial class ToolbarGeneral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolbarGeneral));
            this.add = new System.Windows.Forms.ToolStripButton();
            this.edit = new System.Windows.Forms.ToolStripButton();
            this.delete = new System.Windows.Forms.ToolStripButton();
            this.save = new System.Windows.Forms.ToolStripButton();
            this.cancel = new System.Windows.Forms.ToolStripButton();
            this.exit = new System.Windows.Forms.ToolStripButton();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.add.Image = ((System.Drawing.Image)(resources.GetObject("add.Image")));
            this.add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(23, 22);
            this.add.Text = "toolStripButton1";
            // 
            // edit
            // 
            this.edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.edit.Image = ((System.Drawing.Image)(resources.GetObject("edit.Image")));
            this.edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(23, 22);
            this.edit.Text = "toolStripButton2";
            // 
            // delete
            // 
            this.delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(23, 22);
            this.delete.Text = "toolStripButton3";
            // 
            // save
            // 
            this.save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.save.Image = ((System.Drawing.Image)(resources.GetObject("save.Image")));
            this.save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(23, 20);
            this.save.Text = "toolStripButton4";
            // 
            // cancel
            // 
            this.cancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cancel.Image = ((System.Drawing.Image)(resources.GetObject("cancel.Image")));
            this.cancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(23, 20);
            this.cancel.Text = "toolStripButton5";
            // 
            // exit
            // 
            this.exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(23, 20);
            this.exit.Text = "toolStripButton6";
            // 
            // ToolbarGeneral
            // 
            this.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add,
            this.edit,
            this.delete,
            this.save,
            this.cancel,
            this.exit});
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripButton add;
        private System.Windows.Forms.ToolStripButton edit;
        private System.Windows.Forms.ToolStripButton delete;
        private System.Windows.Forms.ToolStripButton save;
        private System.Windows.Forms.ToolStripButton cancel;
        private System.Windows.Forms.ToolStripButton exit;
    }
}
