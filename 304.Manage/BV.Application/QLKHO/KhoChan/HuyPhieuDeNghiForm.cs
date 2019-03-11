using System;
using System.Windows.Forms;
using BV.BUS;
using Common.Winforms.UserControls;

namespace BV.QLKHO.KhoChan
{
    public partial class HuyPhieuDeNghiForm : FormBase
    {
        private ErrorProvider _error = new ErrorProvider();
        private Guid _phieuDeNghiId;
        public HuyPhieuDeNghiForm(Guid phieuDeNghiId)
        {
            InitializeComponent();
            _phieuDeNghiId = phieuDeNghiId;
        }

        private void btnHuyDN_Click(object sender, EventArgs e)
        {
            try
            {
                _error.Clear();
                if (string.IsNullOrEmpty(txtLyDoHuy.Text))
                {
                    _error.SetError(txtLyDoHuy,@"Lý do hủy không được để trống!");
                    return;
                }
                BusKho.HuyPhieuDeNghi(_phieuDeNghiId, txtLyDoHuy.Text);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }
    }
}
