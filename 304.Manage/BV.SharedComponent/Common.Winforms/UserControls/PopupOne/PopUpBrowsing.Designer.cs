namespace Common.Winforms
{
    partial class PopUpBrowsing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopUpBrowsing));
            this.c1Grid = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmdToolBar = new Common.Winforms.UserControls.GeneralToolbar.ToolbarGeneral();
            ((System.ComponentModel.ISupportInitialize)(this.c1Grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Grid
            // 
            this.c1Grid.AllowDrop = true;
            this.c1Grid.AllowFilter = false;
            this.c1Grid.AllowUpdate = false;
            this.c1Grid.CaptionHeight = 17;
            this.c1Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Grid.ExtendRightColumn = true;
            this.c1Grid.FilterBar = true;
            this.c1Grid.GroupByCaption = "Drag a column header here to group by that column";
            this.c1Grid.Images.Add(((System.Drawing.Image)(resources.GetObject("c1Grid.Images"))));
            this.c1Grid.Location = new System.Drawing.Point(5, 33);
            this.c1Grid.Name = "c1Grid";
            this.c1Grid.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1Grid.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1Grid.PreviewInfo.ZoomFactor = 75D;
            this.c1Grid.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1Grid.PrintInfo.PageSettings")));
            this.c1Grid.RowHeight = 15;
            this.c1Grid.Size = new System.Drawing.Size(662, 360);
            this.c1Grid.TabIndex = 2;
            this.c1Grid.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
            this.c1Grid.FilterChange += new System.EventHandler(this.c1Grid_FilterChange);
            this.c1Grid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c1Grid_KeyDown);
            this.c1Grid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.c1Grid_KeyPress);
            this.c1Grid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.c1Grid_MouseDoubleClick);
            this.c1Grid.PropBag = resources.GetString("c1Grid.PropBag");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCount);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(5, 393);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 40);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(7, 16);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(64, 13);
            this.lblCount.TabIndex = 0;
            this.lblCount.Text = "Số bản ghi: ";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(107, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdToolBar
            // 
            this.cmdToolBar.AutoSize = true;
            this.cmdToolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.cmdToolBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdToolBar.EnableAdd = true;
            this.cmdToolBar.EnableBrowse = true;
            this.cmdToolBar.EnableCancel = true;
            this.cmdToolBar.EnableDelete = true;
            this.cmdToolBar.EnableEdit = true;
            this.cmdToolBar.EnableExport = true;
            this.cmdToolBar.EnableHelp = true;
            this.cmdToolBar.EnableImport = true;
            this.cmdToolBar.EnablePrint = true;
            this.cmdToolBar.EnableSave = true;
            this.cmdToolBar.GeneralAddEventHandler = null;
            this.cmdToolBar.GeneralEventHandler = null;
            this.cmdToolBar.Location = new System.Drawing.Point(5, 0);
            this.cmdToolBar.MinimumSize = new System.Drawing.Size(2, 31);
            this.cmdToolBar.Name = "cmdToolBar";
            this.cmdToolBar.Size = new System.Drawing.Size(662, 33);
            this.cmdToolBar.TabIndex = 7;
            this.cmdToolBar.VisibleAddNew = true;
            this.cmdToolBar.VisibleCancel = true;
            this.cmdToolBar.VisibleDelete = true;
            this.cmdToolBar.VisibleEdit = true;
            this.cmdToolBar.VisibleExcelExport = true;
            this.cmdToolBar.VisibleExcelImport = true;
            this.cmdToolBar.VisiblePrint = true;
            this.cmdToolBar.VisibleRefresh = true;
            this.cmdToolBar.VisibleSave = true;
            this.cmdToolBar.VisibleSearch = true;
            // 
            // PopUpBrowsing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(672, 438);
            this.Controls.Add(this.c1Grid);
            this.Controls.Add(this.cmdToolBar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = global::Common.Winforms.Properties.Resources.MOETlogo48;
            this.KeyPreview = true;
            this.Name = "PopUpBrowsing";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duyệt";
            this.Activated += new System.EventHandler(this.PopUpBrowsing_Activated);
            this.Load += new System.EventHandler(this.PopUpBrowsing_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PopUpBrowsing_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.c1Grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1TrueDBGrid.C1TrueDBGrid c1Grid;        
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button button1;
        private UserControls.GeneralToolbar.ToolbarGeneral cmdToolBar;
    }
}