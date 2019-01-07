using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Common.Winforms.UserControls.ValidateForm
{
    public partial class ValidateForm : Telerik.WinControls.UI.RadForm
    {
        private string _inprocess = "Đang thực hiện...";
        private string _processed = "Đã thực hiện xong!";
        private string _processError = "Lỗi xảy ra.";
        public ValidateForm()
        {
            InitializeComponent();
        }

        public IList<EventStep> StepCollection { get; set; }
        public string Title 
        {
            set { lbTitle.Text = value; }
        }

        private void InitStep()
        {
            if (StepCollection == null || StepCollection.Count == 0) return;
            foreach (EventStep st in StepCollection)
            {
                if (st != null)
                {
                    ListViewItem item = new ListViewItem(st.StepTitle);
                    item.Checked = true;
                    item.SubItems.Add("");
                    item.SubItems.Add("");
                    item.Tag = st;
                    lsvProcess.Items.Add(item);
                }
            }
            lbTongSo.Text = string.Format((string)lbTongSo.Tag, StepCollection.Count);
        }

        private EventStep EventStepSelected
        { 
            get 
            {
                if (lsvProcess.SelectedItems.Count == 0) return null;
                return lsvProcess.SelectedItems[0].Tag as EventStep;
            }
        }
        private void ValidateForm_Load(object sender, EventArgs e)
        {
            InitStep();
        }

        private void btnCancal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            int iProcess = 0;
            foreach (ListViewItem item in lsvProcess.Items)
            {
                EventStep step = item.Tag as EventStep;
                if (item.Checked && !step.StepError)
                {
                    iProcess++;
                    item.ForeColor = Color.AliceBlue;
                    item.SubItems[1].Text = _inprocess;
                    Application.DoEvents();
                    step.Result = step._OnProcess();
                    if (step.Result == null) //Thuc hien thanh cong
                    {
                        item.SubItems[1].Text = _processed;
                        item.ForeColor = Color.Brown;
                    }
                    else
                    {
                        item.SubItems[1].Text = _processError;
                        item.SubItems[2].Text = step.Result.Summary;
                        step.StepError = true;
                        item.ForeColor = Color.Red;
                        if (VNMessageBox.VN_MessageBox.Show("Lỗi trong quá trình tổng hợp!\n Có tiếp tục nữa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
                        {
                            this.Cursor = Cursors.Default;
                            return;                        
                        }
                    }
                    lbThucHien.Text = string.Format((string)lbThucHien.Tag, iProcess);
                    Application.DoEvents();
                }
            }
            this.Cursor = Cursors.Default;
            VNMessageBox.VN_MessageBox.Show("Quá trình tổng hợp kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void lsvProcess_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtResult.ForeColor = Color.Black;
            txtResult.Text = "<<Không có lỗi>>";
            if (EventStepSelected == null||EventStepSelected.Result == null) return;
            txtResult.ForeColor = Color.Red;
            txtResult.Text = EventStepSelected.Result.Detail;
        }
             
    }
}
