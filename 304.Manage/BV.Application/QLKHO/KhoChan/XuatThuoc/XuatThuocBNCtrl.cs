using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BV.BUS;
using BV.DataModel;
using BV.SharedComponent;
using Common.Winforms;
using Common.Winforms.UserControls;
using Infragistics.Win.UltraWinGrid;

namespace BV.QLKHO.KhoChan.XuatThuoc
{
    public partial class XuatThuocBNCtrl : UserControlBase
    {
        private PhieuDeNghi _phieuDeNghi;
        private PhieuDeNghiLoaiType _loaiPhieuDeNghi;
        private LoaiKhoType _loaiKho;
        private ErrorProvider _error = new ErrorProvider();
        public XuatThuocBNCtrl()
        {
            InitializeComponent();
        }

        public void InitControl(LoaiKhoType loaiKho, PhieuDeNghiLoaiType loaiPhieuDeNghi)
        {
            _loaiKho = loaiKho;
            _loaiPhieuDeNghi = loaiPhieuDeNghi;
        }
        
        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                _error.Clear();
                if (string.IsNullOrEmpty(txtMaPhieu.Text))
                {
                    _error.SetError(txtMaPhieu, "Mã phiếu không được để trống!");
                    return;
                }

                _phieuDeNghi = BusKho.GetPhieuDeNghi(txtMaPhieu.Text, _loaiPhieuDeNghi);

                InitPhieuDeNghiData();
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                _phieuDeNghi = null;
                var oForm = new TimKiemPhieuDeNghiForm();
                oForm.InitControl(_loaiPhieuDeNghi, _loaiKho);
                //oForm.ShowDialog(this);
                if (oForm.ShowDialog(this) == DialogResult.OK)
                {
                    Cursor = Cursors.WaitCursor;
                    _phieuDeNghi = oForm._phieuDeNghi;
                    InitPhieuDeNghiData();
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void InitPhieuDeNghiData()
        {
            txtMaPhieu.Text = _phieuDeNghi.Ma;
            txtKhoDN.Text = _phieuDeNghi.Kho.TenKho;
            txtNgayDN.Text = _phieuDeNghi.NgayDeNghi?.ToString("dd/MM/yyyy");
            txtNguoiDN.Text = _phieuDeNghi.NguoiTao;
            dataGridView1.Rows.Clear();
            var tonThucTe = BusKho.GetThuocTonKho(_phieuDeNghi.PhieuDeNghiChiTiet.Select(e => e.HangHoaID)).ToList();
            foreach (var chiTiet in _phieuDeNghi.PhieuDeNghiChiTiet)
            {
                var soLuong = Converter.Obj2Int(chiTiet.SoLuong);
                var tonKho = tonThucTe.FirstOrDefault(e => e.ThuocVtytID == chiTiet.HangHoaID)?.SoLuongTon ?? 0;
                var canhBao = "";
                var color = Color.Black;
                if (soLuong > tonKho)
                {
                    canhBao = "Không đủ cấp!";
                    color = Color.Red;
                }
                var newItem = new object[]
                {
                    chiTiet.ID, //id
                    "Phieu Id",
                    chiTiet.HangHoa.Ten,
                    soLuong,
                    tonKho,
                    chiTiet.TenDonVi,
                    chiTiet.HanSuDung?.ToString("dd/MM/yyyy"),
                    chiTiet.LoHangHoa?.SoLo,
                    chiTiet.DonGia,
                    canhBao
                };

                var newIdx = dataGridView1.Rows.Add(newItem);
                dataGridView1.Rows[newIdx].Tag = chiTiet;
                var row = dataGridView1.Rows[newIdx];
                row.DefaultCellStyle.ForeColor = color;
            }
            switch (_phieuDeNghi.TinhTrang)
            {
                case 1:
                    lblTinhTrang.Text = "Tình trạng: Chưa duyệt";
                    break;
                case 2:
                    lblTinhTrang.Text = "Tình trạng: Đã duyệt";
                    break;
                case 3:
                    lblTinhTrang.Text = "Tình trạng: Đã hủy";
                    break;
            }

            if (_phieuDeNghi.TinhTrang != 1)
            {
                btnDuyetDN.Enabled = false;
                btnHuyDN.Enabled = false;
                //dateNgayDuyet.Value = ;7076
            }
            else
            {
                btnDuyetDN.Enabled = true;
                btnHuyDN.Enabled = true;
            }
            Cursor = Cursors.Default;
        }

        private void btnHuyDN_Click(object sender, EventArgs e)
        {
            if (_phieuDeNghi == null)
            {
                MessageBox.Show(@"Không có phiếu nào được chọn!", @"Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {

                var oForm = new HuyPhieuDeNghiForm(_phieuDeNghi.ID);
                if (oForm.ShowDialog(this) == DialogResult.OK)
                {
                    Cursor = Cursors.WaitCursor;
                    _phieuDeNghi.TinhTrang = (int)PhieuDeNghiTinhTrangType.DaHuy;
                    _phieuDeNghi.NgayHuy = DateTime.Now;
                    InitPhieuDeNghiData();
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnDuyetDN_Click(object sender, EventArgs e)
        {
            if (_phieuDeNghi == null)
            {
                MessageBox.Show(@"Không có phiếu nào được chọn!", @"Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                BusKho.DuyetPhieuDeNghi(_phieuDeNghi, PhieuDeNghiLoaiType.XuatToiKho);
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Double dobTotal = 0.00;
                if (dataGridView1.Columns["colSoLuongDN"].Name.Equals("colSoLuongDN"))
                {
                    //for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    //{
                    //    dobTotal += Double.Parse(dataGridView1["colSoLuongDN", i].EditedFormattedValue.ToString());
                    //}
                    //txtTotal.Text = dobTotal.ToString();
                    var soLuong = Converter.Obj2Int(dataGridView1[e.ColumnIndex, e.RowIndex].Value);
                    var SoLuongTon = Converter.Obj2Int(dataGridView1[e.ColumnIndex + 1, e.RowIndex].Value);
                    if (soLuong > SoLuongTon)
                    {
                        MessageBox.Show("Số lượng duyệt không được lớn hơn số lượng tồn thực tế", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dataGridView1[e.ColumnIndex, e.RowIndex].Value = SoLuongTon;
                    }
                }
            }
        }
    }
}