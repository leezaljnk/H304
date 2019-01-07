using BV.BUS;
using BV.DataModel;
using BV.SharedComponent;
using System;
using System.Windows.Forms;

namespace BV.QLKHO.THUOC
{
    public partial class QuyetDinhThauForm : Form
    {
        public QuyetDinhThau Entity = null;
        public QuyetDinhThauForm()
        {
            InitializeComponent();
        }

        public void InitThongTin(QuyetDinhThau oEntity)
        {
            if (oEntity == null)
            {
                oEntity = new QuyetDinhThau() { ID = Guid.Empty };
            }

            Entity = oEntity;
            txtMa.Text = oEntity.Ma;
            txtMoTa.Text = oEntity.MoTa;
            bvDateTimeCtrl1.Value = oEntity.NgayQuyetDinh;
            chkActive.Checked = true;// oEntity.HieuLuc;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            try
            {
                if (ValidateControl())
                {
                    SaveEntity();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                
            }
            catch (Exception ex)
            {
                this.HandleException(ex);
            }
        }

        private void SaveEntity()
        {
            QuyetDinhThau oLo = new QuyetDinhThau() { ID = Entity.ID };
            oLo.Ma = txtMa.Text;
            oLo.MoTa = txtMoTa.Text;
            oLo.NgayQuyetDinh = bvDateTimeCtrl1.Value;
            oLo.HieuLuc = chkActive.Checked;

            Entity = AppBus.SaveThongTinQuyetDinhThau(oLo);

            //Update cached
            AppBus.UpdateDanhMuc<QuyetDinhThau>(Entity, "ID");
        }

        private bool ValidateControl()
        {
            bool bRet = true;
            if (string.IsNullOrWhiteSpace(txtMa.Text))
            {
                errorProvider1.SetError(txtMa, "không được để trống!");
                bRet = true;
            }

            if (string.IsNullOrWhiteSpace(txtMoTa.Text))
            {
                errorProvider1.SetError(txtMoTa, "không được để trống!");
                bRet = true;
            }

            if (bvDateTimeCtrl1.Value == null)
            {
                errorProvider1.SetError(txtMoTa, "không hợp lệ!");
                bRet = true;
            }

            return bRet;
        }

        private void txtSoDangKy_TextChanged(object sender, EventArgs e)
        {
            var ctr = sender as Control;
            errorProvider1.SetError(ctr, "");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var ctr = sender as Control;
            errorProvider1.SetError(ctr, "");
        }

        private void bvDateTimeCtrl1_ValueChanged(object sender, EventArgs e)
        {
            var ctr = sender as Control;
            errorProvider1.SetError(ctr, "");
        }
    }
}
