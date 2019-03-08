using System;
using System.Windows.Forms;
using BV.AppCommon;
using BV.BUS;
using BV.DataModel;
using BV.SharedComponent;

namespace BV.QLKHO.THUOC
{
    public partial class ThongTinLoHangForm : Form
    {
        public LoHangHoa Entity;

        public ThongTinLoHangForm()
        {
            InitializeComponent();
        }

        public void InitThongTin(HangHoa hanghoa, LoHangHoa oLoHang)
        {
            txtTenThuoc.Text = hanghoa.Ten;
            if (oLoHang == null)
                oLoHang = new LoHangHoa {ID = Guid.Empty, ThuocVtytID = hanghoa.ID, HanSuDung = DateTime.Now};

            Entity = oLoHang;

            txtSoLo.Text = oLoHang.SoLo;
            bvDateTimeCtrl1.Value = oLoHang.HanSuDung;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateControl())
                {
                    SaveEntity();
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception ex)
            {
                this.HandleException(ex);
            }
        }

        private void SaveEntity()
        {
            var oLo = new LoHangHoa {ID = Entity.ID, ThuocVtytID = Entity.ThuocVtytID};
            oLo.SoLo = txtSoLo.Text.Trim();
            oLo.HanSuDung = bvDateTimeCtrl1.Value;

            Entity = BusApp.SaveThongTinLoHang(oLo);

            //Update cached
            AppCached.UpdateDanhMuc(Entity, "ID");
        }

        private bool ValidateControl()
        {
            var bRet = true;
            if (string.IsNullOrWhiteSpace(txtSoLo.Text))
            {
                errorProvider1.SetError(txtSoLo, "không được để trống!");
                bRet = true;
            }

            if (bvDateTimeCtrl1.Value == null)
            {
                errorProvider1.SetError(txtSoLo, "không hợp lệ!");
                bRet = true;
            }

            return bRet;
        }

        private void txtSoDangKy_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(bvDateTimeCtrl1, "");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(bvDateTimeCtrl1, "");
        }

        private void bvDateTimeCtrl1_Load(object sender, EventArgs e)
        {
            errorProvider1.SetError(bvDateTimeCtrl1, "");
        }
    }
}