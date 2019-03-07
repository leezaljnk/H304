using System;
using System.Windows.Forms;
using BV.BUS;
using BV.DataModel;
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

            var button = new DataGridViewButtonColumn();
            {
                button.Name = "coPreview";
                button.HeaderText = @"Xem phiếu";
                button.Text = "Xem";
                button.UseColumnTextForButtonValue = true; //dont forget this line
                dataGridView1.Columns.Add(button);
            }
            dataGridView1.CellClick += dataGridView1_CellClick;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1 != null && e.ColumnIndex == dataGridView1.Columns["coPreview"].Index)
            {
                int rowIndex = e.RowIndex;
                var data = (PhieuTraThuoc)dataGridView1.Rows[rowIndex].Tag;

                var oForm = new ThuHoiThuocSearchForm();
                oForm.InitData(data);
                oForm.ShowDialog(this);

                //var x = (PhieuTraThuoc)data;
                //MessageBox.Show(x.MaPhieuTra);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var phieuTra = BusKho.GetPhieuTraThuoc(txtMaPhieu.Text, Converter.Obj2Date(dateTuNgay.Text),
                Converter.Obj2Date(dateDenNgay.Text));

            foreach (var phieu in phieuTra)
            {
                //add item to grid
                var newItem = new object[] {
                    phieu.ID,//id
                    phieu.NguoiLap,
                    phieu.KhoId,
                    phieu.MaPhieuTra,
                    phieu.NgayLap.ToString("dd/MM/yyyy"),
                    phieu.Kho.TenKho,
                    phieu.NguoiLap,
                    phieu.GhiChu
                };

                var newIdx = dataGridView1.Rows.Add(newItem);
                dataGridView1.Rows[newIdx].Tag = phieu;
            }
        }
    }
}
