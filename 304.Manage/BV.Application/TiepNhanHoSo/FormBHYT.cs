using BV.DataModel;
using Common.Winforms.UserControls;
using System;
using System.Windows.Forms;

namespace EHR.App.HSBenhNhan
{
    public partial class FormBHYT : FormBase
    {
        public HS_BHYT Entity = null;
        public FormBHYT()
        {
            InitializeComponent();
        }

        public void InitGUI(HS_BHYT source)
        {
            ctrlThongTinBaoHiem1.InitGUI(source);
            btnOK.Enabled = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (ctrlThongTinBaoHiem1.ValidateSetting())
                {
                    this.Cursor = Cursors.WaitCursor;
                    Entity = ctrlThongTinBaoHiem1.SaveSetting();
                    this.Cursor = Cursors.Default;
                }
                else
                    return;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(this, "Lỗi khi cập nhật thông tin về Bảo hiểm y tế. Nội dung: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void ctrlThongTinBaoHiem1_EventSettingChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = true;
        }
    }
}
