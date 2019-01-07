namespace BV.QuanTriHeThong.KhoaPhongBV
{
    partial class ctrlThongTinPhongKham
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboTenKhoa = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboCongKham = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboTenKhoa)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboCongKham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mô tả:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 14);
            this.label8.TabIndex = 5;
            this.label8.Text = "Tên khoa:";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMoTa.Location = new System.Drawing.Point(104, 112);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(436, 22);
            this.txtMoTa.TabIndex = 8;
            this.txtMoTa.TextChanged += new System.EventHandler(this.txtMaKhoa_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cboTenKhoa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenPhong);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMaPhong);
            this.groupBox1.Controls.Add(this.txtMoTa);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 155);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Nội Bộ";
            // 
            // cboTenKhoa
            // 
            this.cboTenKhoa.AutoCompleteIgnoreDiacritics = true;
            this.cboTenKhoa.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest;
            this.cboTenKhoa.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains;
            appearance1.BackColor = System.Drawing.SystemColors.Window;
            appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboTenKhoa.DisplayLayout.Appearance = appearance1;
            this.cboTenKhoa.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn;
            this.cboTenKhoa.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.None;
            this.cboTenKhoa.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance2.BorderColor = System.Drawing.SystemColors.Window;
            this.cboTenKhoa.DisplayLayout.GroupByBox.Appearance = appearance2;
            appearance3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cboTenKhoa.DisplayLayout.GroupByBox.BandLabelAppearance = appearance3;
            this.cboTenKhoa.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance4.BackColor2 = System.Drawing.SystemColors.Control;
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cboTenKhoa.DisplayLayout.GroupByBox.PromptAppearance = appearance4;
            this.cboTenKhoa.DisplayLayout.MaxColScrollRegions = 1;
            this.cboTenKhoa.DisplayLayout.MaxRowScrollRegions = 1;
            appearance5.BackColor = System.Drawing.SystemColors.Window;
            appearance5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboTenKhoa.DisplayLayout.Override.ActiveCellAppearance = appearance5;
            appearance6.BackColor = System.Drawing.SystemColors.Highlight;
            appearance6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cboTenKhoa.DisplayLayout.Override.ActiveRowAppearance = appearance6;
            this.cboTenKhoa.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.cboTenKhoa.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance7.BackColor = System.Drawing.SystemColors.Window;
            this.cboTenKhoa.DisplayLayout.Override.CardAreaAppearance = appearance7;
            appearance8.BorderColor = System.Drawing.Color.Silver;
            appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.cboTenKhoa.DisplayLayout.Override.CellAppearance = appearance8;
            this.cboTenKhoa.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.cboTenKhoa.DisplayLayout.Override.CellPadding = 0;
            appearance9.BackColor = System.Drawing.SystemColors.Control;
            appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance9.BorderColor = System.Drawing.SystemColors.Window;
            this.cboTenKhoa.DisplayLayout.Override.GroupByRowAppearance = appearance9;
            appearance10.TextHAlignAsString = "Left";
            this.cboTenKhoa.DisplayLayout.Override.HeaderAppearance = appearance10;
            this.cboTenKhoa.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.cboTenKhoa.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance11.BackColor = System.Drawing.SystemColors.Window;
            appearance11.BorderColor = System.Drawing.Color.Silver;
            this.cboTenKhoa.DisplayLayout.Override.RowAppearance = appearance11;
            this.cboTenKhoa.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cboTenKhoa.DisplayLayout.Override.TemplateAddRowAppearance = appearance12;
            this.cboTenKhoa.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.cboTenKhoa.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.cboTenKhoa.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.cboTenKhoa.DropDownResizeHandleStyle = Infragistics.Win.DropDownResizeHandleStyle.DiagonalResize;
            this.cboTenKhoa.DropDownSearchMethod = Infragistics.Win.UltraWinGrid.DropDownSearchMethod.Linear;
            this.cboTenKhoa.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cboTenKhoa.Location = new System.Drawing.Point(104, 23);
            this.cboTenKhoa.Name = "cboTenKhoa";
            this.cboTenKhoa.Size = new System.Drawing.Size(436, 24);
            this.cboTenKhoa.TabIndex = 15;
            this.cboTenKhoa.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.cboTenKhoa_InitializeLayout);
            this.cboTenKhoa.TextChanged += new System.EventHandler(this.cboTenKhoa_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã phòng:";
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenPhong.Location = new System.Drawing.Point(104, 84);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(436, 22);
            this.txtTenPhong.TabIndex = 12;
            this.txtTenPhong.TextChanged += new System.EventHandler(this.txtMaKhoa_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tên phòng:";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(104, 54);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(90, 22);
            this.txtMaPhong.TabIndex = 10;
            this.txtMaPhong.TextChanged += new System.EventHandler(this.txtMaKhoa_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cboCongKham);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(4, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(569, 63);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Công khám:";
            // 
            // cboCongKham
            // 
            this.cboCongKham.AutoCompleteIgnoreDiacritics = true;
            this.cboCongKham.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest;
            this.cboCongKham.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains;
            appearance13.BackColor = System.Drawing.SystemColors.Window;
            appearance13.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboCongKham.DisplayLayout.Appearance = appearance13;
            this.cboCongKham.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn;
            this.cboCongKham.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.None;
            this.cboCongKham.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance14.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance14.BorderColor = System.Drawing.SystemColors.Window;
            this.cboCongKham.DisplayLayout.GroupByBox.Appearance = appearance14;
            appearance15.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cboCongKham.DisplayLayout.GroupByBox.BandLabelAppearance = appearance15;
            this.cboCongKham.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance16.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance16.BackColor2 = System.Drawing.SystemColors.Control;
            appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance16.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cboCongKham.DisplayLayout.GroupByBox.PromptAppearance = appearance16;
            this.cboCongKham.DisplayLayout.MaxColScrollRegions = 1;
            this.cboCongKham.DisplayLayout.MaxRowScrollRegions = 1;
            appearance17.BackColor = System.Drawing.SystemColors.Window;
            appearance17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboCongKham.DisplayLayout.Override.ActiveCellAppearance = appearance17;
            appearance18.BackColor = System.Drawing.SystemColors.Highlight;
            appearance18.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cboCongKham.DisplayLayout.Override.ActiveRowAppearance = appearance18;
            this.cboCongKham.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.cboCongKham.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance19.BackColor = System.Drawing.SystemColors.Window;
            this.cboCongKham.DisplayLayout.Override.CardAreaAppearance = appearance19;
            appearance20.BorderColor = System.Drawing.Color.Silver;
            appearance20.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.cboCongKham.DisplayLayout.Override.CellAppearance = appearance20;
            this.cboCongKham.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.cboCongKham.DisplayLayout.Override.CellPadding = 0;
            appearance21.BackColor = System.Drawing.SystemColors.Control;
            appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance21.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance21.BorderColor = System.Drawing.SystemColors.Window;
            this.cboCongKham.DisplayLayout.Override.GroupByRowAppearance = appearance21;
            appearance22.TextHAlignAsString = "Left";
            this.cboCongKham.DisplayLayout.Override.HeaderAppearance = appearance22;
            this.cboCongKham.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.cboCongKham.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance23.BackColor = System.Drawing.SystemColors.Window;
            appearance23.BorderColor = System.Drawing.Color.Silver;
            this.cboCongKham.DisplayLayout.Override.RowAppearance = appearance23;
            this.cboCongKham.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance24.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cboCongKham.DisplayLayout.Override.TemplateAddRowAppearance = appearance24;
            this.cboCongKham.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.cboCongKham.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.cboCongKham.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.cboCongKham.DropDownResizeHandleStyle = Infragistics.Win.DropDownResizeHandleStyle.DiagonalResize;
            this.cboCongKham.DropDownSearchMethod = Infragistics.Win.UltraWinGrid.DropDownSearchMethod.Linear;
            this.cboCongKham.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cboCongKham.Location = new System.Drawing.Point(104, 23);
            this.cboCongKham.Name = "cboCongKham";
            this.cboCongKham.Size = new System.Drawing.Size(436, 24);
            this.cboCongKham.TabIndex = 14;
            this.cboCongKham.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.cboCongKham_InitializeLayout);
            this.cboCongKham.TextChanged += new System.EventHandler(this.cboCongKham_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "Công khám:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlThongTinPhongKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "ctrlThongTinPhongKham";
            this.Size = new System.Drawing.Size(576, 236);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboTenKhoa)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboCongKham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Infragistics.Win.UltraWinGrid.UltraCombo cboCongKham;
        private Infragistics.Win.UltraWinGrid.UltraCombo cboTenKhoa;
    }
}
