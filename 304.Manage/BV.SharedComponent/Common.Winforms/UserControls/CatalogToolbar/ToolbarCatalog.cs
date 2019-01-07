using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common.Winforms.UserControls.CatalogToolbar;

namespace Common.Winforms.UserControls.CatalogToolbar
{
    public partial class ToolbarCatalog : UserControl
    {
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
        public ToolbarCatalog()
        {
            InitializeComponent();
            //Khoi tao menu context
            InitMenu();
        }

        private void InitMenu()
        {
            _mnuContext = new ContextMenuStrip();
            mnuAdd = new ToolStripMenuItem(btnAdd.Image);
            mnuAdd.Text = btnAdd.Text;
            mnuAdd.Click += btnAdd_Click;

            mnuEdit = new ToolStripMenuItem(btnEdit.Image);
            mnuEdit.Text = btnEdit.Text;            
            mnuEdit.Click += btnEdit_Click;

            mnuDelete = new ToolStripMenuItem(btnDelete.Image);
            mnuDelete.Text = btnDelete.Text;
            mnuDelete.Click += btnDelete_Click;

            _mnuContext.Items.AddRange(new ToolStripMenuItem[] { mnuAdd, mnuEdit, mnuDelete });
        }
        #region Handle event
        public IToolbarCatalogEvent CatalogEventHandler
        {
            get;
            set;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.CatalogEventHandler == null)
                return;
            this.CatalogEventHandler.OnAdd();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.CatalogEventHandler == null)
                return;
            this.CatalogEventHandler.OnEdit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.CatalogEventHandler == null)
                return;
            this.CatalogEventHandler.OnDelete();
        }      
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.CatalogEventHandler == null)
                return;
            this.CatalogEventHandler.OnSearch();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (this.CatalogEventHandler == null)
                return;
            this.CatalogEventHandler.OnClose();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (this.CatalogEventHandler == null)
                return;
            this.CatalogEventHandler.OnPrint();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            if (this.CatalogEventHandler == null)
                return;
            this.CatalogEventHandler.OnHelp();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (this.CatalogEventHandler == null)
                return;
            this.CatalogEventHandler.OnRefresh();
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
                        mnuEdit.Enabled = btnEdit.Enabled = (_isUpdate);
                        mnuDelete.Enabled = btnDelete.Enabled = (_isDelete);
                    }
                    else
                    {
                        mnuEdit.Enabled = btnEdit.Enabled = false;
                        mnuDelete.Enabled = btnDelete.Enabled = false;
                    }
                    btnSearch.Enabled = true;                    
                    btnRefresh.Enabled = true;
                    btnPrint.Enabled = _isPrint;
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
                    btnRefresh.Enabled = true;
                    btnPrint.Enabled = _isPrint;                    
                    break;
                case ActionTypes.Insert:                   
                    mnuAdd.Enabled= btnAdd.Enabled = false;
                    mnuEdit.Enabled= btnEdit.Enabled = false;
                    mnuDelete.Enabled = btnDelete.Enabled = false;
                    btnSearch.Enabled = false;
                    btnRefresh.Enabled = false;
                    btnPrint.Enabled = false;                    
                    break;
                case ActionTypes.Update:                   
                    mnuAdd.Enabled = btnAdd.Enabled = false;
                    mnuEdit.Enabled = btnEdit.Enabled = false;
                    mnuDelete.Enabled = btnDelete.Enabled = false;
                    btnSearch.Enabled = false;
                    btnRefresh.Enabled = false;
                    btnPrint.Enabled = false;                    
                    break;
                case ActionTypes.Delete:
                    mnuAdd.Enabled = btnAdd.Enabled = (_isCreate);
                    mnuEdit.Enabled=btnEdit.Enabled = false;
                    mnuDelete.Enabled = btnDelete.Enabled = false;                   
                    btnSearch.Enabled = true;
                    btnPrint.Enabled = _isPrint;
                    break;
                case ActionTypes.Nostatus:                    
                    btnAdd.Enabled = false;
                    mnuEdit.Enabled = btnEdit.Enabled = false;
                    mnuDelete.Enabled = btnDelete.Enabled = false;
                    btnPrint.Enabled = _isPrint;
                    break;
                case ActionTypes.PrintOnly:
                    mnuAdd.Enabled = btnAdd.Enabled = false;
                    mnuEdit.Enabled = btnEdit.Enabled = false;
                    mnuDelete.Enabled = btnDelete.Enabled = false;                   
                    btnSearch.Enabled = false;
                    btnPrint.Enabled = _isPrint;                    
                    break;
                case ActionTypes.EditOnly:
                    mnuAdd.Enabled = btnAdd.Enabled = false;
                    mnuEdit.Enabled = btnEdit.Enabled = _isUpdate;
                    mnuDelete.Enabled = btnDelete.Enabled = false;                    
                    btnSearch.Enabled = false;
                    btnPrint.Enabled = _isPrint;                    
                    break;
                case ActionTypes.AddAndBrowse:
                    mnuAdd.Enabled = btnAdd.Enabled = (_isCreate);
                    mnuEdit.Enabled = btnEdit.Enabled = false;
                    mnuDelete.Enabled = btnDelete.Enabled = false;                   
                    btnSearch.Enabled = true;
                    btnPrint.Enabled = _isPrint;                    
                    break;
                case ActionTypes.CloseOnly:
                    mnuAdd.Enabled = btnAdd.Enabled = false;
                    mnuEdit.Enabled = btnEdit.Enabled = false;
                    mnuDelete.Enabled = btnDelete.Enabled = false;                    
                    btnSearch.Enabled = false;
                    btnPrint.Enabled = false;                    
                    break;
                case ActionTypes.SearchOnly:
                    mnuAdd.Enabled = btnAdd.Enabled = false;
                    mnuEdit.Enabled = btnEdit.Enabled = false;
                    mnuDelete.Enabled = btnDelete.Enabled = false;                    
                    btnSearch.Enabled = true;
                    btnPrint.Enabled = _isPrint;                    
                    break;
                case ActionTypes.Start:
                    mnuAdd.Enabled = btnAdd.Enabled = false;
                    mnuEdit.Enabled = btnEdit.Enabled = false;
                    mnuDelete.Enabled = btnDelete.Enabled = false;                    
                    btnSearch.Enabled = false;
                    btnPrint.Enabled = false;                    
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
        #region Visible
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
        public bool VisibleRefresh
        {
            get
            {
                return btnRefresh.Visible;
            }
            set
            {
                btnRefresh.Visible = value;
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
            }
        } 
        #endregion

        public bool VisibleSearch
        {
            get
            {
                return btnSearch.Visible;
            }
            set
            {
                btnSearch.Visible = value;
            }
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
                mnuDelete.Enabled = btnDelete.Enabled = _isDelete && value;
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

        #endregion
       

        #endregion
        public ContextMenuStrip GetMenuContext()
        {
            return _mnuContext;
        }

        

        
    }  
}
