using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BV.BUS;
using BV.DataModel;
using BV.SharedComponent;
using Common.Winforms;
using Common.Winforms.UserControls;
using Infragistics.Win.UltraWinGrid;

namespace BV.QLKHO.KhoChan
{
    public partial class TimKiemPhieuDeNghiForm : FormBase
    {
        //private int _loaiKho;
        private PhieuDeNghiLoaiType _phieuDeNghiLoai;
        public PhieuDeNghi _phieuDeNghi;
        public TimKiemPhieuDeNghiForm()
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

            var button = new DataGridViewButtonColumn();
            {
                button.Name = "colDel";
                button.HeaderText = @"Chọn phiếu";
                button.Text = "Chọn";
                button.UseColumnTextForButtonValue = true; //dont forget this line
                dataGridView1.Columns.Add(button);
            }
            dataGridView1.CellClick += dataGridView1_CellClick;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="type">Loai phieu de nghi</param>
        /// <param name="loaiKho">exclude kho type from list Kho to filter</param>
        public void InitControl(PhieuDeNghiLoaiType type, LoaiKhoType loaiKho)
        {
            List<Kho> lstKho;
            _phieuDeNghiLoai = type;
            var loaiKhoInt = (int)loaiKho;
            switch (loaiKho)
            {
                case LoaiKhoType.KhoChan:
                    lstKho = BusApp.GetDanhMuc<Kho>().Where(k => k.LoaiKhoId != loaiKhoInt).ToList();
                    break;
                case LoaiKhoType.KhoLe:
                case LoaiKhoType.TuTruc:
                case LoaiKhoType.KhoDongY:
                case LoaiKhoType.NganHangMau:
                    lstKho = BusApp.GetDanhMuc<Kho>().Where(k => k.LoaiKhoId == loaiKhoInt).ToList();
                    break;
                default:
                    lstKho = new List<Kho>();
                    break;
            }

            cboKho.DataSource = lstKho;
            cboKho.ValueMember = "MaKho";
            cboKho.DisplayMember = "TenKho";
            cboKho.DisplayLayout.PerformAutoResizeColumns(false, PerformAutoSizeType.AllRowsInBand);
        }

        private void cboKho_InitializeLayout(object sender, InitializeLayoutEventArgs e)
        {
            cboKho.UltraCommbo_InitializeLayout(sender, e);
            if (e.Layout.Bands.Count > 0)
                foreach (var clm in e.Layout.Bands[0].Columns)
                    if (clm.Key == "MaKho")
                        clm.Header.Caption = @"Mã";
                    else if (clm.Key == "TenKho")
                        clm.Header.Caption = @"Tên";
                    else
                        clm.Hidden = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var deNghi = BusKho.GetPhieuDeNghi(Converter.Obj2Date(dateTuNgay.Text),
                Converter.Obj2Date(dateDenNgay.Text), Converter.obj2Guid(cboKho.Value), _phieuDeNghiLoai, PhieuDeNghiTinhTrangType.ChuaDuyet).ToList();
            foreach (var xuatTra in deNghi)
            {
                var newItem = new object[]
                {
                    xuatTra.ID, //id
                    xuatTra.NguoiTao,
                    xuatTra.Kho.TenKho,
                    xuatTra.Ma,
                    xuatTra.NgayDeNghi?.ToString("dd/MM/yyyy"),
                    xuatTra.Kho.TenKho,
                    xuatTra.NguoiTao,
                    //xuatTra.GhiChu
                };

                var newIdx = dataGridView1.Rows.Add(newItem);
                dataGridView1.Rows[newIdx].Tag = xuatTra;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1 != null && e.ColumnIndex == dataGridView1.Columns[$"colDel"].Index)
            {
                var rowIndex = e.RowIndex;
                var phieuDN = dataGridView1.Rows[rowIndex];
                _phieuDeNghi = (PhieuDeNghi)phieuDN.Tag;
                DialogResult = DialogResult.OK;
                //var oForm = new ThuHoiThuocSearchForm();
                //oForm.InitData(data);
                //oForm.ShowDialog(this);

                //if (oForm._action)
                //    dataGridView1.Rows.Remove(phieuTraRow);
            }
        }
    }
}
