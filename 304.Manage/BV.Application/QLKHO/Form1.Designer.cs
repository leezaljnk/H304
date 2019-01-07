namespace BV.QLKHO
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
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Column 0");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Column 1");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn1 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Column 0");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn2 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Column 1");
            this.ultraGrid1 = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraDataSource1 = new Infragistics.Win.UltraWinDataSource.UltraDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraGrid1
            // 
            this.ultraGrid1.DataSource = this.ultraDataSource1;
            this.ultraGrid1.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Width = 265;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Width = 264;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2});
            this.ultraGrid1.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ultraGrid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.FixedAddRowOnBottom;
            this.ultraGrid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraGrid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ultraGrid1.Location = new System.Drawing.Point(12, 23);
            this.ultraGrid1.Name = "ultraGrid1";
            this.ultraGrid1.Size = new System.Drawing.Size(550, 198);
            this.ultraGrid1.TabIndex = 0;
            this.ultraGrid1.Text = "ultraGrid1";
            // 
            // ultraDataSource1
            // 
            this.ultraDataSource1.Band.AllowAdd = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDataSource1.Band.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDataSource1.Band.Columns.AddRange(new object[] {
            ultraDataColumn1,
            ultraDataColumn2});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 398);
            this.Controls.Add(this.ultraGrid1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGrid1;
        private Infragistics.Win.UltraWinDataSource.UltraDataSource ultraDataSource1;
    }
}

