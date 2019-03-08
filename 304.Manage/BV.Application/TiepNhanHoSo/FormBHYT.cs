using System;
using System.Windows.Forms;
using BV.DataModel;
using Common.Winforms.UserControls;

namespace EHR.App.HSBenhNhan
{
    public partial class FormBHYT : FormBase
    {
        public HS_BHYT Entity;

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
                    Cursor = Cursors.WaitCursor;
                    Entity = ctrlThongTinBaoHiem1.SaveSetting();
                    Cursor = Cursors.Default;
                }
                else
                {
                    return;
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(this, "Lỗi khi cập nhật thông tin về Bảo hiểm y tế. Nội dung: " + ex.Message, Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ctrlThongTinBaoHiem1_EventSettingChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = true;
        }
    }
}