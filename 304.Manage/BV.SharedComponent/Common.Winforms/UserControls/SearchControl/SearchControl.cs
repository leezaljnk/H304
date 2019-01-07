using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Common.Winforms.UserControls.SearchControl
{
    public partial class SearchControl : UserControl
    {
        public delegate IList<LookupType> OnGetLookUp(string query);
        public OnGetLookUp _OnGetLookUp;

        public delegate LookupType OnGetBrowse(string query);
        public OnGetBrowse _OnGetBrowse;

        private IList<FieldExpression> _fieldExpressSet;
        private IList<Operators> m_lstOperators = new List<Operators>();
        private IList<Rule> m_lstRules = new List<Rule>();
        private IList<DataType> m_lstDataTypes = new List<DataType>();
        private IList<DataTypeGroup> m_lstDataTypeGroup = new List<DataTypeGroup>();
        private IList<ColumnFilter> m_lstColumnFilters = new List<ColumnFilter>();

        bool m_bControlShowing = false;
        bool m_bAuto = false;

        public SearchControl()
        {
            InitializeComponent();
            this.InitUserControl();
        }

        public void InitControl(IList<ColumnFilter> lstColumnFilter, IList<Operators> lstOperator, IList<Rule> lstRules, IList<DataType> lstDataType, IList<DataTypeGroup> lstDataTypeGroup)
        {
            m_lstColumnFilters = lstColumnFilter;
            m_lstOperators = lstOperator;
            m_lstRules = lstRules;
            m_lstDataTypes = lstDataType;
            m_lstDataTypeGroup = lstDataTypeGroup;
            grdFilter.RowCount = 0;
        }

        public IList<FieldExpression> FieldExpressionCollection
        {
            get
            {
                _fieldExpressSet = new List<FieldExpression>();
                //Loc theo row
                foreach (DataGridViewRow row in grdFilter.Rows)
                {
                    FieldExpression item = new FieldExpression();
                    if (Converter.Obj2String(row.Cells[1].Value) == string.Empty ||
                        Converter.Obj2String(row.Cells[2].Value) == string.Empty ||
                        Converter.Obj2String(row.Cells[3].Value) == string.Empty) continue;
                    item.IsOr = Converter.Obj2String(row.Cells[0].Value) == "Hoặc" ? true : false;
                    item.Operator = Converter.Obj2String(row.Cells[2].Value);
                    item.FieldName = Converter.Obj2String(row.Cells[1].Value);
                    item.Value = Converter.Obj2String(row.Cells[3].Value);

                    _fieldExpressSet.Add(item);
                }
                return _fieldExpressSet;
            }
        }

        #region Private Methods
        private IList<Operators> GetOperator(string dataType)
        {
            IList<Operators> found = (from dt in m_lstDataTypes
                                      from rl in m_lstRules
                                      from op in m_lstOperators
                                      where dt.DataTypeGroupId == rl.DataTypeGroupId
                                      && rl.OperatorId == op.OperatorId && dt.DataTypeId == dataType
                                      select op).ToList();
            return found;
        }

        public string GetDataType(string entityField)
        {
            if (entityField == string.Empty) return string.Empty;
            var found = this.m_lstColumnFilters.Where<ColumnFilter>(e => e.ColumnName == entityField);
            foreach (ColumnFilter item in found)
            { return item.DataType; }
            return string.Empty;
        }

        public string GetLookup(string entityField)
        {
            if (entityField == string.Empty) return string.Empty;
            var found = this.m_lstColumnFilters.Where<ColumnFilter>(e => e.ColumnName == entityField);
            foreach (ColumnFilter item in found)
            { return item.Lookup; }
            return string.Empty;
        }

        public bool GetBrowse(string entityField)
        {
            if (entityField == string.Empty) return false;
            var found = this.m_lstColumnFilters.Where<ColumnFilter>(e => e.ColumnName == entityField);
            foreach (ColumnFilter item in found)
            { return Converter.obj2Bool(item.IsBrowse); }
            return false;
        }
        #endregion

        #region DataGridView Controls

        public DataGridViewCell BuildValueCellControl(string dataType, string sSql)
        {
            IList<LookupType> lstLookupTypes = new List<LookupType>();
            DataGridViewCell oCell = new DataGridViewTextBoxCell();
            switch (dataType)
            {
                case "bit":
                    LookupType trueType = new LookupType() { ItemDisplay = "Đúng", ItemValue = true.ToString() };
                    LookupType falseType = new LookupType() { ItemDisplay = "Sai", ItemValue = false.ToString() };
                    lstLookupTypes.Add(trueType);
                    lstLookupTypes.Add(falseType);
                    oCell = new DataGridViewComboBoxCell();

                    break;
                case "datetime":
                    oCell = new CalendarCell();
                    break;

                case "lookup":

                    if (_OnGetLookUp != null)
                    {
                        lstLookupTypes = _OnGetLookUp(sSql);
                        oCell = new DataGridViewComboBoxCell();
                    }
                    break;

                case "browse":
                    if (_OnGetBrowse != null)
                    {
                        LookupType entity = _OnGetBrowse(sSql);
                        if (entity != null)
                            lstLookupTypes.Add(entity);

                        oCell = new DataGridViewComboBoxCell();
                        oCell.Style.BackColor = Color.YellowGreen;
                        oCell.ToolTipText = "Nháy đúp chuột để chọn lại";
                    }
                    break;
                default:
                    oCell = new DataGridViewTextBoxCell();
                    break;
            }

            oCell.Tag = dataType;

            if (oCell is DataGridViewComboBoxCell)
            {
                DataGridViewComboBoxCell cmb = (DataGridViewComboBoxCell)oCell;
                cmb.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;
                cmb.DisplayStyleForCurrentCellOnly = true;
                cmb.FlatStyle = FlatStyle.Flat;

                cmb.DisplayMember = "ItemDisplay";
                cmb.ValueMember = "ItemValue";
                cmb.DataSource = lstLookupTypes;
                if (lstLookupTypes.Count > 0)
                {
                    cmb.Value = lstLookupTypes[0].ItemValue;
                }
            }

            return oCell;
        }

        public DataGridViewComboBoxCell BuildOperatorCell(IList<Operators> lstOperators)
        {
            DataGridViewComboBoxCell cmb = new DataGridViewComboBoxCell();
            cmb.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;
            cmb.DisplayStyleForCurrentCellOnly = true;
            cmb.FlatStyle = FlatStyle.Flat;
            cmb.DisplayMember = "OperatorName";
            cmb.ValueMember = "MethodCall";
            cmb.DataSource = lstOperators;

            if (lstOperators.Count > 0)
            {
                cmb.Value = lstOperators[0].MethodCall;
            }

            return cmb;
        }

        private void grdFilter_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            m_bAuto = true;
            if (e.RowIndex != 0)
            {
                if (Converter.Obj2String(grdFilter.Rows[e.RowIndex].Cells[0].Value) == string.Empty)
                {
                    grdFilter.Rows[e.RowIndex].Cells[0].Value = "Và";
                    grdFilter.Rows[e.RowIndex].Cells[0].Selected = true;
                }
            }

            DataGridViewComboBoxCell cbProperty = new DataGridViewComboBoxCell();
            cbProperty.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;
            cbProperty.DisplayStyleForCurrentCellOnly = true;
            cbProperty.FlatStyle = FlatStyle.Flat;
            cbProperty.DisplayMember = "Description";
            cbProperty.ValueMember = "ColumnName";
            cbProperty.DataSource = m_lstColumnFilters;

            grdFilter.Rows[e.RowIndex].Cells[1] = cbProperty;
            if (m_lstColumnFilters.Count > 0)
                grdFilter.Rows[e.RowIndex].Cells[1].Value = m_lstColumnFilters[0].ColumnName;

            m_bAuto = false;
        }

        private void grdFilter_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //If is Data browse
            if (grdFilter.CurrentCell.Tag == null || (string)grdFilter.CurrentCell.Tag != "browse")
                return;

            string entityField = grdFilter.Rows[e.RowIndex].Cells[1].Value.ToString();
            string sLookup = GetLookup(entityField);
            grdFilter.Rows[e.RowIndex].Cells[3] = BuildValueCellControl("browse", sLookup);
        }

        private void grdFilter_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0 && e.ColumnIndex == 0)
            {
                //Disable Và\Hoặc
                grdFilter.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = true;
            }
            else
            {
                if (!m_bAuto)
                {
                    m_bControlShowing = true;
                    grdFilter.BeginEdit(true);
                    m_bControlShowing = false;
                }
            }
        }

        private void grdFilter_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is ComboBox)
            {
                ComboBox comboBox = e.Control as ComboBox;
                comboBox.SelectedIndexChanged -= comboBox_SelectedIndexChanged;
                comboBox.SelectedIndexChanged += new EventHandler(comboBox_SelectedIndexChanged);
            }
            else if (e.Control is TextBox)
            {
                TextBox txtControl = e.Control as TextBox;
                txtControl.KeyPress -= new KeyPressEventHandler(txtControl_KeyPress);
                txtControl.KeyPress += new KeyPressEventHandler(txtControl_KeyPress);
                txtControl.Validated -= new EventHandler(txtControl_Validated);
                txtControl.Validated += new EventHandler(txtControl_Validated);
            }
        }

        void txtControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            string sDataType = (string)grdFilter.CurrentCell.Tag;
            if (sDataType == "int")
            {
                int i = 0;
                e.Handled = e.KeyChar != '\b' && !int.TryParse(e.KeyChar.ToString(), out i);
            }
            else if (sDataType == "decimal")
            {
                decimal i = 0;
                e.Handled = e.KeyChar != '\b' && !".,0123456789".Contains(e.KeyChar.ToString());
            }
        }

        void txtControl_Validated(object sender, EventArgs e)
        {
            string sDataType = (string)grdFilter.CurrentCell.Tag;
            if (sDataType == "decimal")
            {
                grdFilter.CurrentCell.Value = Converter.obj2decimal(grdFilter.CurrentCell.Value);
            }
        }
        void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_bControlShowing)
                return;

            ComboBox cb = (ComboBox)sender;
            if (cb.SelectedIndex < 0)
                return;

            grdFilter.CurrentCell.Value = cb.SelectedValue != null ? cb.SelectedValue : cb.Text;
        }

        private void grdFilter_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != 1)
                return;

            // Get DatagridViewCell
            DataGridViewCell oCell = grdFilter.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (oCell.Value == null)
                return;

            string entityField = (string)oCell.Value;
            if (string.IsNullOrWhiteSpace(entityField))
                return;

            string dataType = this.GetDataType(entityField);
            string sLookup = this.GetLookup(entityField);

            IList<Operators> lstOperators = new List<Operators>();
            if (string.IsNullOrWhiteSpace(sLookup))
            {
                lstOperators = GetOperator(dataType);
            }
            else
            {
                lstOperators.Add(new Operators() { OperatorId = 1, OperatorName = "=", MethodCall = (dataType.Contains("char")) ? "Equals" : "=" });
               // if (!dataType.Contains("char"))
                    lstOperators.Add(new Operators() { OperatorId = 9, OperatorName = "<>", MethodCall = "<>" });
                //if(!dataType.Contains("char"))
                //    lstOperators.Add(new Operators() { OperatorId = 2, OperatorName = "<>", MethodCall ="<>" });
                if (GetBrowse(entityField))
                {
                    //lstOperators.Add(new Operators() { OperatorId = 1, OperatorName = "=", MethodCall = "Equals" });
                    dataType = "browse";
                }
                else
                {
                    //lstOperators.Add(new Operators() { OperatorId = 1, OperatorName = "=", MethodCall = "=" });
                    dataType = "lookup";
                }
            }

            grdFilter.Rows[e.RowIndex].Cells[2] = BuildOperatorCell(lstOperators);
            grdFilter.Rows[e.RowIndex].Cells[3] = BuildValueCellControl(dataType, sLookup);

            if (dataType == "browse")
                grdFilter.Rows[e.RowIndex].Cells[3].ReadOnly = true;
        }

        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            grdFilter.Rows.Add();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (grdFilter.CurrentCell != null)
            {
                grdFilter.Rows.RemoveAt(grdFilter.CurrentCell.RowIndex);
                DataGridViewSelectionMode oSeletedMode = grdFilter.SelectionMode;
                grdFilter.ClearSelection();
                grdFilter.SelectionMode = oSeletedMode;
            }
        }
    }
}
