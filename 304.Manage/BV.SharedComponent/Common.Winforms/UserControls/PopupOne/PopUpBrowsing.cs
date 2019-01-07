using System;
using System.Data;
using System.Text;
using System.Collections.Specialized;
using System.Windows.Forms;
using C1.Win.C1TrueDBGrid;
using System.Collections;
using System.Collections.Generic;
using Common.Winforms.UserControls.GeneralToolbar;

namespace Common.Winforms
{
    public partial class PopUpBrowsing : Telerik.WinControls.UI.RadForm, IToolbarGerenalEvent, IToolbarGerenalAddEvent
    {
        #region Varriables

        PopupData _Data = new PopupData();
        DataTable _dt;
       

        #endregion


        public PopUpBrowsing()
        {
            InitializeComponent();
        }

        #region Events

        private void btnCancel_Click(object sender, EventArgs e)
        {
            c1Grid.Enabled = true;        
        }
       
        private void PopUpBrowsing_Load(object sender, EventArgs e)
        {
            this.InitControls();
            if (_Data.FieldName != null)
                c1Grid.Columns[this.c1Grid.Col].FilterText = _Data.Content;
            else
                c1Grid.Columns[0].FilterText = _Data.Content;

            foreach (C1DisplayColumn column in c1Grid.Splits[0].DisplayColumns)
            {
                column.AutoSize();
                column.Width += 15;
            }
        }

        private void PopUpBrowsing_Activated(object sender, EventArgs e)
        {
            c1Grid.FilterActive = true;
            c1Grid.Focus();
            c1Grid.EditActive = true;
        }

        private void PopUpBrowsing_KeyDown(object sender, KeyEventArgs e)
        {
            //switch (e.KeyCode)
            //{
            //    case Keys.Enter:
            //        base.ProcessTabKey(true);
            //        break;
            //    default:
            //        break;
            //}
        }

        #endregion

        #region Grid events
        private void c1Grid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (c1Grid.Row >= 0)
                OnOK();
        }

        private void c1Grid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter & c1Grid.Row >= 0)
                OnOK();
        }

        private void c1Grid_FilterChange(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            C1DataColumn dc = this.c1Grid.Columns[this.c1Grid.Col];
            if ((dc.FilterText.Length > 0))
            {
                if (sb.Length > 0)
                    sb.Append(" AND ");
                if (dc.DataType == typeof(decimal))
                    sb.Append(dc.DataField + "=" + Convert.ToDecimal(dc.FilterText));
                else if (dc.DataType == typeof(DateTime))
                {
                    if (CommonFunction.IsdateTime(dc.FilterText))
                        sb.Append(dc.DataField + "='" + Convert.ToDateTime(dc.FilterText) + "'");
                }
                else if (dc.DataType == typeof(bool))
                {

                }
                else sb.Append(dc.DataField + " like " + "'*" + dc.FilterText.Replace("'", "''") + "*'");
            }
            _dt.DefaultView.RowFilter = sb.ToString();
        }

        private void c1Grid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\r'))
                OnOK();
        }
        #endregion

        #region Methods
        private void InitControls()
        {
           // this.WindowState = (FormWindowState)PublicVariable.PopUpWindowState;
            this.BackColor = System.Drawing.Color.FromArgb(196, 218, 250);
            c1Grid.InitC1TrueDBGrid();
            c1Grid.RowHeight = 18;
            
            cmdToolBar.btnAdd.Visible = false;
            cmdToolBar.btnEdit.Visible = false;
            cmdToolBar.btnCancel.Visible = false;
            cmdToolBar.btnDelete.Visible = false;
            cmdToolBar.btnPrint.Visible = false;
            cmdToolBar.btnRefresh.Visible = false;
            cmdToolBar.btnSave.Visible = false;
            cmdToolBar.btnSearch.Visible = false;
            cmdToolBar.toolStripSeparator3.Visible = false;
            cmdToolBar.toolStripSeparator2.Visible = false;
            cmdToolBar.toolStripSeparator.Visible = false;
            cmdToolBar.GeneralEventHandler = this;
            cmdToolBar.GeneralAddEventHandler = this;
        }

        private void FillData2Grid()
        {
            string key = _Data.PrimaryKey;
            string[] key2s = _Data.SecondReturnField == null ? new string[] { } : _Data.SecondReturnField.Split(',');//_Data.SecondReturnField ?? string.Empty;
            //string[] Fields = _Data.ColumnName.ToLower().Split(',');
            string[] Fields = _Data.ColumnName.Split(',');

            StringCollection sc = new StringCollection();
            sc.AddRange(Fields);

            StringCollection sc2 = new StringCollection();
            sc2.AddRange(key2s);

            _dt = _Data.DataSource.Copy();
            foreach (DataColumn datCol in _Data.DataSource.Columns)
            {
                //if (!sc.Contains(datCol.ColumnName.ToLower()) && key.ToLower() != datCol.ColumnName.ToLower() && (!sc2.Contains(datCol.ColumnName.ToLower())))
                if (!sc.Contains(datCol.ColumnName) && key != datCol.ColumnName && (!sc2.Contains(datCol.ColumnName)))
                {
                    _dt.Columns.Remove(datCol.ColumnName);
                }

            }
            for (int i = 0; i <= Fields.GetUpperBound(0); i++)
            {
                _dt.Columns[Fields[i]].SetOrdinal(i);
            }

            c1Grid.DataSource = _dt;
            c1Grid.SetTrueDBCaption(Data.ResoucePrefix ?? c1Grid.Name);
            c1Grid.Refresh();


            if (!sc.Contains(key.ToLower()))
                c1Grid.Splits[c1Grid.SplitIndex].DisplayColumns[key].Visible = false;
            foreach (string key2 in sc2)
            {
                if (key2 != string.Empty && !sc.Contains(key2.ToLower()))
                    c1Grid.Splits[c1Grid.SplitIndex].DisplayColumns[key2].Visible = false;
            }

            C1DataColumn dc = this.c1Grid.Columns[_Data.FieldName];
            this.c1Grid.Col = this.c1Grid.Columns.IndexOf(dc);
            foreach (C1.Win.C1TrueDBGrid.C1DataColumn dataCol in this.c1Grid.Columns)
            {
                if (dataCol.DataType.ToString().Contains("Decimal"))
                    dataCol.NumberFormat = PublicVariables.NUMBER_FORMAT;
            }

            lblCount.Text = Resources.GetString("TotalRecord") + " " + c1Grid.RowCount.ToString();
        }
        #endregion

        #region IPopupView Members
        public PopupData Data
        {
            get
            {
                return _Data;
            }
            set
            {
                _Data = value;
                FillData2Grid();
            }
        }

        public int RowIndex
        {
            get
            {
                return c1Grid.Row;
            }
            set
            {
                c1Grid.Row = value;
            }
        }

        public object SeletedValue
        {
            get
            {
                if (RowIndex < 0 || _dt.DefaultView.Count == 0) return null;
                return c1Grid[RowIndex, this._Data.PrimaryKey];
            }
            set
            {
                c1Grid[RowIndex, this._Data.PrimaryKey] = value;
            }
        }

        public Dictionary<string, object> SelectedValue2
        {
            get
            {
                if (RowIndex < 0 || _dt.DefaultView.Count == 0) return null;
                Dictionary<string, object> retVals = new Dictionary<string, object>();
                foreach (string field in _Data.SecondReturnField.Split(','))
                {
                    retVals.Add(field, c1Grid[RowIndex, field]);
                }
                return retVals;
            }
        }

        #endregion

        #region ISearchEventHandler Members

        public void OnEdit()
        {
           
        }
        public void OnAdd()
        {
           
        }

        public void OnSearch()
        {

        }
        public void OnDelete()
        {

        }
        public void OnSave()
        {

        }
        public void OnCancel()
        {

        }
        public void OnRefresh()
        {
           
        }

        public void OnExcelExport()
        {
            
        }
        public void OnExcelImport()
        {
        
        }
        public void OnClose()
        {
            //OnOK();
            Data.ReturnValue = null;            
            this.Close();
        }

        public void OnOK()
        {
            Data.ReturnValue = this.SeletedValue;
            if (Data.SecondReturnField != null)
            {
                Data.SecondValue = this.SelectedValue2;
            }            
            this.Close();
        }

        public void OnPrint()
        {
        }

        public void OnHelp()
        {
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}