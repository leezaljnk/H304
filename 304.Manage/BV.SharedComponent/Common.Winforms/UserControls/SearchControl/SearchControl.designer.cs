namespace Common.Winforms.UserControls.SearchControl
{
    partial class SearchControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchControl));
            this.grdFilter = new System.Windows.Forms.DataGridView();
            this.colVaHoac = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colThuocTinh = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colPhepToan = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colGiaTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grdFilter)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdFilter
            // 
            this.grdFilter.AllowUserToAddRows = false;
            this.grdFilter.AllowUserToDeleteRows = false;
            this.grdFilter.BackgroundColor = System.Drawing.Color.White;
            this.grdFilter.ColumnHeadersHeight = 30;
            this.grdFilter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVaHoac,
            this.colThuocTinh,
            this.colPhepToan,
            this.colGiaTri});
            this.grdFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdFilter.Location = new System.Drawing.Point(0, 0);
            this.grdFilter.MultiSelect = false;
            this.grdFilter.Name = "grdFilter";
            this.grdFilter.RowHeadersVisible = false;
            this.grdFilter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdFilter.Size = new System.Drawing.Size(652, 155);
            this.grdFilter.TabIndex = 6;
            this.grdFilter.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdFilter_CellDoubleClick);
            this.grdFilter.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdFilter_CellEnter);
            this.grdFilter.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdFilter_CellValueChanged);
            this.grdFilter.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.grdFilter_EditingControlShowing);
            this.grdFilter.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.grdFilter_RowsAdded);
            // 
            // colVaHoac
            // 
            this.colVaHoac.DisplayStyleForCurrentCellOnly = true;
            this.colVaHoac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colVaHoac.HeaderText = "Và\\Hoặc";
            this.colVaHoac.Items.AddRange(new object[] {
            "Và",
            "Hoặc"});
            this.colVaHoac.Name = "colVaHoac";
            this.colVaHoac.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colVaHoac.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colThuocTinh
            // 
            this.colThuocTinh.DisplayStyleForCurrentCellOnly = true;
            this.colThuocTinh.FillWeight = 130F;
            this.colThuocTinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colThuocTinh.HeaderText = "Tìm Theo Thuộc Tính";
            this.colThuocTinh.Name = "colThuocTinh";
            this.colThuocTinh.Width = 200;
            // 
            // colPhepToan
            // 
            this.colPhepToan.DisplayStyleForCurrentCellOnly = true;
            this.colPhepToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colPhepToan.HeaderText = "Phép Toán";
            this.colPhepToan.Name = "colPhepToan";
            // 
            // colGiaTri
            // 
            this.colGiaTri.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGiaTri.HeaderText = "Giá Trị";
            this.colGiaTri.Name = "colGiaTri";
            this.colGiaTri.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colGiaTri.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewComboBoxColumn1.DisplayStyleForCurrentCellOnly = true;
            this.dataGridViewComboBoxColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewComboBoxColumn1.HeaderText = "";
            this.dataGridViewComboBoxColumn1.Items.AddRange(new object[] {
            "And",
            "Or"});
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewComboBoxColumn2
            // 
            this.dataGridViewComboBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewComboBoxColumn2.DisplayStyleForCurrentCellOnly = true;
            this.dataGridViewComboBoxColumn2.FillWeight = 130F;
            this.dataGridViewComboBoxColumn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewComboBoxColumn2.HeaderText = "Tên trường";
            this.dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            this.dataGridViewComboBoxColumn2.Width = 200;
            // 
            // dataGridViewComboBoxColumn3
            // 
            this.dataGridViewComboBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewComboBoxColumn3.DisplayStyleForCurrentCellOnly = true;
            this.dataGridViewComboBoxColumn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewComboBoxColumn3.HeaderText = "Điều kiện";
            this.dataGridViewComboBoxColumn3.Name = "dataGridViewComboBoxColumn3";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(2, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(28, 24);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.Location = new System.Drawing.Point(31, 6);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(28, 24);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Giá trị";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 35);
            this.panel1.TabIndex = 9;
            // 
            // SearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.grdFilter);
            this.Controls.Add(this.panel1);
            this.Name = "SearchControl";
            this.Size = new System.Drawing.Size(652, 190);
            ((System.ComponentModel.ISupportInitialize)(this.grdFilter)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdFilter;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridViewComboBoxColumn colVaHoac;
        private System.Windows.Forms.DataGridViewComboBoxColumn colThuocTinh;
        private System.Windows.Forms.DataGridViewComboBoxColumn colPhepToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaTri;
        private System.Windows.Forms.Panel panel1;
    }
}
