using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BV.BUS;
using Common.Winforms;
using Common.Winforms.UserControls;

namespace BV.QLKHO.KhoChan.ThuHoiThuoc
{
    public partial class ThuHoiThuocCtrl : UserControlBase
    {
        public ThuHoiThuocCtrl()
        {
            InitializeComponent();

            dateTuNgay.MaxDate = DateTime.Now; // Ensures no future dates are set.
            dateTuNgay.Format = DateTimePickerFormat.Custom;
            dateTuNgay.Checked = true;
            dateTuNgay.CustomFormat = dateTuNgay.CustomFormat;
            dateTuNgay.Value = DateTime.Now;


            dateDenNgay.MaxDate = DateTime.Now; // Ensures no future dates are set.
            dateDenNgay.Format = DateTimePickerFormat.Custom;
            dateDenNgay.Checked = true;
            dateDenNgay.CustomFormat = dateDenNgay.CustomFormat;
            dateDenNgay.Value = DateTime.Now;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var phieuTra = BusKho.GetPhieuTraThuoc(txtMaPhieu.Text, Converter.Obj2Date(dateTuNgay.Text),
                Converter.Obj2Date(dateDenNgay.Text));


            //add item to grid
            var newItem = new object[] {
                Guid.NewGuid(),//id
                _phieuId,//ma phieu
                _chiTietPhieus.Count, //STT
                cboThuoc.Text,//ten thuoc
                cboDonVi.Text,//don vi tinh
                cboQDThau.Text,//quyet dinh thau
                cboLoHang.Text,//so lo
                dateHSD.Text,//han su dung
                txtSoLuong.Text,//so luong
                (txtChietKhau.Text + (_chietKhauHangHoa == LoaiChietKhauType.PhanTram ?" %":" đ")),//chiet khau
                txtDonGia.Text,//don gia
                //cboDonVi.Text,//ten don vi tinh
                _thanhTien,// thanh tien
                //_chietKhauHangHoa,//loai chiet khau
            };

            var newIdx = dataGridView1.Rows.Add(newItem);
            dataGridView1.Rows[newIdx].Tag = phieu;
            DataGridViewRow row = dataGridView1.Rows[newIdx];
            row.DefaultCellStyle.ForeColor = Color.Red;

            //var oForm = new PhieuNhapForm();
            //oForm.InitData(Guid.Empty);
            //oForm.ShowDialog(this);
        }
    }
}
