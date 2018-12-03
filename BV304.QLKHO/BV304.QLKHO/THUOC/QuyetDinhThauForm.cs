using BV.DataModel.KhoChung;
using BV.SharedComponent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            Entity = KhoUtil.SaveThongTinQuyetDinhThau(oLo);

            //Update cached
            KhoUtil.UpdateDanhMuc<QuyetDinhThau>(Entity, "ID");
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
