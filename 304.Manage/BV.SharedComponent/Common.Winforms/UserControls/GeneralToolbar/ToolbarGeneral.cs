using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Common.Winforms.UserControls.GeneralToolbar
{
    public partial class ToolbarGeneral : UserControl
    {
        public event EventHandler ButtonClick;
        #region "Khai báo biến"
        private bool _isCreate = true;
        private bool _isUpdate = true;
        private bool _isDelete = true;
        private bool _isPrint = true;
        private string functionName = string.Empty;
        private ContextMenuStrip _mnuContext;
        private ToolStripMenuItem mnuAdd;
        private ToolStripMenuItem mnuEdit;
        private ToolStripMenuItem mnuDelete;

        #endregion
        #region "Các thuộc tính"
        public string FunctionName
        {
            set { functionName = value; }
        }
        #endregion
        public ToolbarGeneral()
        {
            InitializeComponent();
            //Khoi tao menu context
            InitMenu();
        }

        private void InitMenu()
        {
            _mnuContext = new ContextMenuStrip();
            mnuAdd = new ToolStripMenuItem(btnAdd.Image)
            {
                Text = btnAdd.Text
            };
            mnuAdd.Click += btnAdd_Click;

            mnuEdit = new ToolStripMenuItem(btnEdit.Image)
            {
                Text = btnEdit.Text
            };
            mnuEdit.Click += btnEdit_Click;

            mnuDelete = new ToolStripMenuItem(btnDelete.Image)
            {
                Text = btnDelete.Text
            };
            mnuDelete.Click += btnDelete_Click;

            _mnuContext.Items.AddRange(new ToolStripMenuItem[] { mnuAdd, mnuEdit, mnuDelete });
        }
        #region Handle event
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ButtonClick?.Invoke("add", e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ButtonClick?.Invoke("edit", e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ButtonClick?.Invoke("delete", e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ButtonClick?.Invoke("cancel", e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ButtonClick?.Invoke("save", e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ButtonClick?.Invoke("search", e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ButtonClick?.Invoke("close", e);
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            ButtonClick?.Invoke("print", e);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            ButtonClick?.Invoke("help", e);
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ButtonClick?.Invoke("refresh", e);
        }

        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            ButtonClick?.Invoke("excelexport", e);
        }

        private void btnExcelImport_Click(object sender, EventArgs e)
        {
            ButtonClick?.Invoke("excelimport", e);
        }

        private void btnGanThe_Click(object sender, EventArgs e)
        {
            ButtonClick?.Invoke("ganthe", e);
        }
        #endregion
        #region "Các hàm tự định nghĩa"


        public void SetPermission(bool isCreate, bool isUpdate, bool isDelete)
        {
            this._isCreate = isCreate;
            this._isUpdate = isUpdate;
            this._isDelete = isDelete;
        }

        public void SetPermission(bool isCreate, bool isUpdate, bool isDelete, bool isPrint)
        {
            this._isCreate = isCreate;
            this._isUpdate = isUpdate;
            this._isDelete = isDelete;
            this._isPrint = isPrint;
            
        }


        public bool CheckEnableButton(string btnName)
        {
            switch (btnName)
            {
                case CONSTANT.BUTTON_ADDNEW:
                    return btnAdd.Enabled;
                case CONSTANT.BUTTON_EDIT:
                    return btnEdit.Enabled;
                case CONSTANT.BUTTON_DELETE:
                    return btnDelete.Enabled;
                case CONSTANT.BUTTON_SAVE:
                    return btnSave.Enabled;
                case CONSTANT.BUTTON_CANCEL:
                    return btnCancel.Enabled;
                case CONSTANT.BUTTON_SEARCH:
                    return btnSearch.Enabled;
                case CONSTANT.BUTTON_PRINT:
                    return btnPrint.Enabled;
                default:
                    return false;
            }
        }

        public void EnableButton(ActionTypes actionType, int Count)
        {
            switch (actionType)
            {
                case ActionTypes.Refresh:
                    btnAdd.Enabled = (_isCreate);
                    if (Count > 0)
                    {
                        mnuEdit.Enabled = btnEdit.Enabled = (_isUpdate );
                        mnuDelete.Enabled = btnDelete.Enabled = (_isDelete);
                    }
                    else
                    {
                        mnuEdit.Enabled = btnEdit.Enabled = false;
                        mnuDelete.Enabled = btnDelete.Enabled = false;
                    }
                    btnSearch.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnRefresh.Enabled = true;
                    btnPrint.Enabled = _isPrint;
                    btnExcelExport.Enabled = true;
                    lblTotal.Text = $"Tổng số bản ghi: {Count}";
                    lblTotal.Visible = true;
                    break;
                case ActionTypes.RefreshInEditMode:
                    if (Count > 0)
                    {
                        mnuEdit.Enabled = btnEdit.Enabled = (_isUpdate);
                        mnuDelete.Enabled = btnDelete.Enabled = (_isDelete);
                        btnAdd.Enabled = false;
                    }
                    else
                    {
                        btnAdd.Enabled = _isCreate;
                        mnuEdit.Enabled = btnEdit.Enabled = false;
                        mnuDelete.Enabled = btnDelete.Enabled = false;
                    }
                    btnSearch.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnRefresh.Enabled = true;
                    btnPrint.Enabled = _isPrint;
                    btnExcelExport.Enabled = true;
                    break;
                case ActionTypes.Insert:
                    btnSave.Enabled = ((_isUpdate || _isCreate));
                    btnCancel.Enabled = true;
                    mnuAdd.Enabled= btnAdd.Enabled = false;
                    mnuEdit.Enabled= btnEdit.Enabled = false;
                    mnuDelete.Enabled = btnDelete.Enabled = false;
                    btnSearch.Enabled = false;
                    btnRefresh.Enabled = false;
                    btnPrint.Enabled = false;
                    btnExcelExport.Enabled = false;
                    break;
                case ActionTypes.Update:
                    btnSave.Enabled = ((_isUpdate || _isCreate));
                    btnCancel.Enabled = true;
                    mnuAdd.Enabled = btnAdd.Enabled = false;
                    mnuEdit.Enabled = btnEdit.Enabled = false;
                    mnuDelete.Enabled = btnDelete.Enabled = false;
                    btnSearch.Enabled = false;
                    btnRefresh.Enabled = false;
                    btnPrint.Enabled = false;
                    btnExcelExport.Enabled = false;
                    break;
                case ActionTypes.Delete:
                    mnuAdd.Enabled = btnAdd.Enabled = (_isCreate);
                    mnuEdit.Enabled=btnEdit.Enabled = false;
                    mnuDelete.Enabled = btnDelete.Enabled = false;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnSearch.Enabled = true;
                    btnPrint.Enabled = _isPrint;
                    break;
                case ActionTypes.Nostatus:
                    mnuAdd.Enabled = btnSave.Enabled = false;
                    btnCancel.Enabled = true;
                    btnAdd.Enabled = false;
                    mnuEdit.Enabled = btnEdit.Enabled = false;
                    mnuDelete.Enabled = btnDelete.Enabled = false;
                    btnPrint.Enabled = _isPrint;
                    break;
                case ActionTypes.PrintOnly:
                    mnuAdd.Enabled = btnAdd.Enabled = false;
                    mnuEdit.Enabled = btnEdit.Enabled = false;
                    mnuDelete.Enabled = btnDelete.Enabled = false;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnSearch.Enabled = false;
                    btnPrint.Enabled = _isPrint;
                    btnExcelExport.Enabled = false;
                    break;
                case ActionTypes.EditOnly:
                    mnuAdd.Enabled = btnAdd.Enabled = false;
                    mnuEdit.Enabled = btnEdit.Enabled = _isUpdate;
                    mnuDelete.Enabled = btnDelete.Enabled = false;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnSearch.Enabled = false;
                    btnPrint.Enabled = _isPrint;
                    btnExcelExport.Enabled = false;
                    break;
                case ActionTypes.AddAndBrowse:
                    mnuAdd.Enabled = btnAdd.Enabled = (_isCreate);
                    mnuEdit.Enabled = btnEdit.Enabled = false;
                    mnuDelete.Enabled = btnDelete.Enabled = false;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnSearch.Enabled = true;
                    btnPrint.Enabled = _isPrint;
                    btnExcelExport.Enabled = false;
                    break;
                case ActionTypes.CloseOnly:
                    mnuAdd.Enabled = btnAdd.Enabled = false;
                    mnuEdit.Enabled = btnEdit.Enabled = false;
                    mnuDelete.Enabled = btnDelete.Enabled = false;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnSearch.Enabled = false;
                    btnPrint.Enabled = false;
                    btnExcelExport.Enabled = false;
                    break;
                case ActionTypes.SearchOnly:
                    mnuAdd.Enabled = btnAdd.Enabled = false;
                    mnuEdit.Enabled = btnEdit.Enabled = false;
                    mnuDelete.Enabled = btnDelete.Enabled = false;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnSearch.Enabled = true;
                    btnPrint.Enabled = _isPrint;
                    btnExcelExport.Enabled = false;
                    break;
                case ActionTypes.Start:
                    mnuAdd.Enabled = btnAdd.Enabled = false;
                    mnuEdit.Enabled = btnEdit.Enabled = false;
                    mnuDelete.Enabled = btnDelete.Enabled = false;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnSearch.Enabled = false;
                    btnPrint.Enabled = false;
                    btnExcelImport.Enabled = false;
                    btnExcelExport.Enabled = false;
                    break;
            }

        }
        #endregion

        #region Set status control
        public void OnKeyPreview(object sender, KeyEventArgs e)
        {
            if (e.Alt || e.Control || e.Shift || (int)e.KeyCode==13)
                return;
            switch ((int)e.KeyCode)
            {
                case (int)KEYVALUE.HELP:
                    if (btnHelp.Enabled)
                        btnHelp_Click(sender, e);
                    break;
                case (int)KEYVALUE.ADDNEW:
                    if (btnAdd.Enabled)                    
                        btnAdd_Click(sender, e);                   
                    break;
                case (int)KEYVALUE.EDIT:
                    if (btnEdit.Enabled)
                        btnEdit_Click(sender, e);
                    break;
                case (int)KEYVALUE.DELETE:
                    if (btnDelete.Enabled)
                        btnDelete_Click(sender, e);
                    break;
                case (int)KEYVALUE.SAVE:
                    if (btnSave.Enabled)
                        btnSave_Click(sender, e);
                    break;
                case (int)KEYVALUE.CANCEL:
                    if (btnCancel.Enabled)
                        btnCancel_Click(sender, e);
                    break;
                case (int)KEYVALUE.EXIT:
                    if (btnClose.Enabled)
                        btnClose_Click(sender, e);
                    break;
                case (int)KEYVALUE.PRINT:
                    if (btnPrint.Enabled)
                        btnPrint_Click(sender, e);
                    break;
                case (int)KEYVALUE.SEARCH:
                    if (btnSearch.Enabled)
                        btnSearch_Click(sender, e);
                    break;
                case (int)KEYVALUE.REFRESH:
                    if (btnRefresh.Enabled)
                        btnRefresh_Click(sender, e);
                    break;
                default: break;
            }
        }

        public void SetStatus(bool _status)
        {
            this.btnAdd.Enabled = _status;
            this.btnEdit.Enabled = !_status;
        }
        public void VisibleSearch_Print_Delete(bool _status, string Search_Print_Delete)
        {
            switch (Search_Print_Delete)
            {
                case "P":
                    this.btnPrint.Visible = _status;
                    break;
                case "S":
                    this.btnSearch.Visible = _status;
                    break;
                case "D":
                    this.btnDelete.Visible = _status;
                    break;
                case "SP":
                    this.toolStripSeparator.Visible = _status;
                    this.btnSearch.Visible = _status;
                    this.btnPrint.Visible = _status;
                    break;
                case "SD":
                    this.btnSearch.Visible = _status;
                    this.btnDelete.Visible = _status;
                    break;
                case "PD":
                    this.btnPrint.Visible = _status;
                    this.btnDelete.Visible = _status;
                    break;
                case "SPD":
                    this.toolStripSeparator.Visible = _status;
                    this.btnSearch.Visible = _status;
                    this.btnPrint.Visible = _status;
                    this.btnDelete.Visible = _status;
                    break;
                default: break;
            }
        }
        
        public void VisibleSearch_Print_Delete(bool _status, GeneralControlStatus Search_Print_Delete)
        {
            switch (Search_Print_Delete)
            {
                case GeneralControlStatus.P:
                    this.btnPrint.Visible = _status;
                    break;
                case GeneralControlStatus.S:
                    this.btnSearch.Visible = _status;
                    break;
                case GeneralControlStatus.D:
                    this.btnDelete.Visible = _status;
                    break;
                case GeneralControlStatus.SP:
                    this.toolStripSeparator.Visible = _status;
                    this.btnSearch.Visible = _status;
                    this.btnPrint.Visible = _status;
                    break;
                case GeneralControlStatus.SD:
                    this.btnSearch.Visible = _status;
                    this.btnDelete.Visible = _status;
                    break;
                case GeneralControlStatus.PD:
                    this.btnPrint.Visible = _status;
                    this.btnDelete.Visible = _status;
                    break;
                case GeneralControlStatus.SPD:
                    this.toolStripSeparator.Visible = _status;
                    this.btnSearch.Visible = _status;
                    this.btnPrint.Visible = _status;
                    this.btnDelete.Visible = _status;
                    break;
                default: break;
            }
        }

        //public void VisibleSave(bool status)
        //{
        //    btnSave.Visible = status;
        //    btnCancel.Visible = status;
        //} 
        public bool VisibleSave
        {
            get { return btnSave.Visible; }
            set { 
                btnSave.Visible = value;
                btnCancel.Visible = value;
            }
        }

        public bool VisibleExcelExport
        {
            get { return btnExcelExport.Visible; }
            set { 
                btnExcelExport.Visible = value;
                //if (!btnExcelExport.Visible && !value)
                //    toolStripExcel.Visible = false;
                toolStripSeparator1.Visible = VisibleExcelImport || VisibleExcelExport;
            }
        }

        public bool VisibleExcelImport
        {
            get { return btnExcelImport.Visible; }
            set {
                btnExcelImport.Visible = value;
                //if (!btnExcelExport.Visible && !value)
                //    toolStripExcel.Visible = false;

                toolStripSeparator1.Visible = VisibleExcelImport || VisibleExcelExport;
            }
        }

        public bool VisibleAddNew
        {
            get { return btnAdd.Visible; }
            set
            {
                btnAdd.Visible = value;                
            }
        }

        public bool VisibleEdit
        {
            get
            {
                return btnEdit.Visible;
            }
            set
            {
                btnEdit.Visible = value;
            }
        }
        public bool VisibleDelete
        {
            get
            {
                return btnDelete.Visible;
            }
            set
            {
                btnDelete.Visible = value;
            }
        }
        public bool VisibleCancel
        {
            get
            {
                return btnCancel.Visible;
            }
            set
            {
                btnCancel.Visible = value;
            }
        }
        public bool VisibleRefresh
        {
            get
            {
                return btnRefresh.Visible;
            }
            set
            {
                btnRefresh.Visible = value;
                toolStripSeparator3.Visible = value;
            }
        }
        public bool VisiblePrint
        {
            get
            {
                return btnPrint.Visible;
            }
            set
            {
                btnPrint.Visible = value;
                toolStripSeparator.Visible = VisiblePrint || VisibleSearch;
            }
        }

        public bool VisibleSearch
        {
            get
            {
                return btnSearch.Visible;
            }
            set
            {
                btnSearch.Visible = value;
                toolStripSeparator.Visible = VisiblePrint || VisibleSearch;

            }
        }

        public bool VisibleClose
        {
            get
            {
                return btnClose.Visible;
            }
            set
            {
                btnClose.Visible = value;
                toolStripExcel.Visible = value;

            }
        }

        public bool VisibleHelp
        {
            get
            {
                return btnHelp.Visible;
            }
            set
            {
                btnHelp.Visible = value;
                toolStripSeparator2.Visible = value;

            }
        }

        public bool VisibleGanThe
        {
            get { return btnGanThe.Visible; }
            set { btnGanThe.Visible = value; }
        }
        #region Enable
        public bool EnableAdd
        {
            get
            {
                return btnAdd.Enabled;
            }
            set
            {
                btnAdd.Enabled = value;
            }
        }
        public bool EnableEdit
        {
            get
            {
                return btnEdit.Enabled;
            }
            set
            {
                btnEdit.Enabled = value;
            }
        }
        public bool EnableDelete
        {
            get
            {
                return btnDelete.Enabled;
            }
            set
            {
                mnuDelete.Enabled = btnDelete.Enabled = value;
            }
        }
        public bool EnableCancel
        {
            get
            {
                return btnCancel.Enabled;
            }
            set
            {
                btnCancel.Enabled = value;
            }
        }
        public bool EnableSave
        {
            get
            {
                return btnSave.Enabled;
            }
            set
            {
                btnSave.Enabled = value;
            }
        }
        public bool EnableBrowse
        {
            get
            {
                return btnSearch.Enabled;
            }
            set
            {
                btnSearch.Enabled = value;
            }
        }
        public bool EnablePrint
        {
            get
            {
                return btnPrint.Enabled;
            }
            set
            {
                btnPrint.Enabled = value;
            }
        }
        public bool EnableHelp
        {
            get
            {
                return btnHelp.Enabled;
            }
            set
            {
                btnHelp.Enabled = value;
            }
        }
        public bool EnableImport
        {
            get
            {
                return btnExcelImport.Enabled;
            }
            set
            {
                btnExcelImport.Enabled = value;
            }
        }
        public bool EnableExport
        {
            get
            {
                return btnExcelExport.Enabled;
            }
            set
            {
                btnExcelExport.Enabled = value;
                toolStripSeparator1.Visible = !EnableImport && !EnableExport;
            }
        }
        public bool EnableGanThe
        {
            get
            {
                return btnGanThe.Enabled;
            }
            set
            {
                btnGanThe.Enabled = value;
            }
        }
        #endregion


        #endregion
        public ContextMenuStrip GetMenuContext()
        {
            return _mnuContext;
        }

        
    }
    public enum GeneralControlStatus:int
    {
        P,D,S,SP,SD,PD,SPD        
    }
}
