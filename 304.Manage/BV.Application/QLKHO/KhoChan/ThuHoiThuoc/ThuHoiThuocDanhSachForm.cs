using System;
using System.Linq;
using System.Windows.Forms;
using BV.BUS;
using BV.DataModel;
using Common.Winforms;
using Common.Winforms.UserControls;

namespace BV.QLKHO.KhoChan.ThuHoiThuoc
{
    public partial class ThuHoiThuocDanhSachForm : FormBase
    {
        public ThuHoiThuocDanhSachForm()
        {
            InitializeComponent();

            dateTuNgay.MaxDate = DateTime.MaxValue; // Ensures no future dates are set.
            dateTuNgay.Format = DateTimePickerFormat.Custom;
            dateTuNgay.Checked = true;
            dateTuNgay.CustomFormat = dateTuNgay.CustomFormat;
            dateTuNgay.Value = DateTime.Now;


            dateDenNgay.MinDate = DateTime.MinValue; // Ensures no future dates are set.
            dateDenNgay.Format = DateTimePickerFormat.Custom;
            dateDenNgay.Checked = true;
            dateDenNgay.CustomFormat = dateDenNgay.CustomFormat;
            dateDenNgay.Value = DateTime.Now;

            var button = new DataGridViewButtonColumn();
            {
                button.Name = "colView";
                button.HeaderText = @"Xem phiếu";
                button.Text = "Xem";
                button.UseColumnTextForButtonValue = true; //dont forget this line
                dataGridView1.Columns.Add(button);
            }
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1 != null && e.ColumnIndex == dataGridView1.Columns[$"colView"].Index)
            {
                var rowIndex = e.RowIndex;
                var phieuTraRow = dataGridView1.Rows[rowIndex];
                var data = (XuatTra)phieuTraRow.Tag;

                MessageBox.Show("show report");
            }
        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {

            var xuatTra= BusKho.GetXuatTra(Converter.Obj2Date(dateTuNgay.Text), Converter.Obj2Date(dateDenNgay.Text), null).ToList();
            foreach (var phieu in xuatTra)
            {
                var newItem = new object[]
                {
                    phieu.ID, //id
                    phieu.NguoiLap,
                    phieu.KhoId,
                    phieu.MaPhieu,
                    phieu.Ngay?.ToString("dd/MM/yyyy"),
                    phieu.Kho.TenKho,
                    phieu.NguoiLap,
                    //phieu.GhiChu
                };

                var newIdx = dataGridView1.Rows.Add(newItem);
                dataGridView1.Rows[newIdx].Tag = phieu;
            }
        }
    }
}
