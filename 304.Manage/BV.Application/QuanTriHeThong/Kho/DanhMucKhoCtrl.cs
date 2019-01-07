using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BV.QLKHO;
using BV.DataModel;
using BV.BUS;

namespace BV.QuanTriHeThong.Kho
{
    public partial class DanhMucKhoCtrl : UserControl
    {
        public event EventHandler CloseView;
        private List<HangHoa> _DanhMucThuoc304;
        private List<HoTriLieu> _HoTriLieu;

        public DanhMucKhoCtrl()
        {
            InitializeComponent();
        }

        internal void InitControlUI()
        {
            _DanhMucThuoc304 = BusApp.GetDanhMuc<HangHoa>();
            _HoTriLieu = BusApp.GetDanhMuc<HoTriLieu>();
            foreach (var t in _DanhMucThuoc304)
            {
                var item = new object[] { t.Ma, t.Ten, t.HoatChat, t.HamLuong, t.DongGoi, t.DuongDung, t.HoTriLieu };
                int i = dataGridView1.Rows.Add(item);
                dataGridView1.Rows[i].Tag = t;
            }
        }

        private void toolbarGeneral1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                if (e.ClickedItem.Name == "add")
                {
                    ThongTinKhoForm oForm = new ThongTinKhoForm();
                    oForm.InitThongTin(null);
                    if (oForm.ShowDialog(this) == DialogResult.OK)
                    {
                        //var t = oForm.Entity;
                        //var item = new object[] { t.Ma, t.Ten, t.HoatChat, t.HamLuong, t.DongGoi, t.DuongDung, t.HoTriLieu };
                        //int i = dataGridView1.Rows.Add(item);
                        //dataGridView1.Rows[i].Tag = t;
                    }
                }
                else if (e.ClickedItem.Name == "edit")
                {
                    //if (dataGridView1.SelectedRows.Count > 0)
                    //{
                    //    var row = dataGridView1.SelectedRows[0];
                    //    Thuoc_VatTuYte oThuoc = row.Tag as Thuoc_VatTuYte;
                    //    ThongTinKhoForm oForm = new ThongTinKhoForm();
                    //    oForm.InitThongTin(oThuoc);
                    //    if (oForm.ShowDialog(this) == DialogResult.OK)
                    //    {
                    //        var t = oForm.Entity;
                    //        row.Cells[0].Value = t.Ma;
                    //        row.Cells[1].Value = t.Ten;
                    //        row.Cells[2].Value = t.HoatChat;
                    //        row.Cells[3].Value = t.HamLuong;
                    //        row.Cells[4].Value = t.DongGoi;
                    //        row.Cells[5].Value = t.DongGoi;
                    //        row.Cells[6].Value = t.HoTriLieu;
                    //    }
                    //}
                }
                else if(e.ClickedItem.Name == "exit")
                {
                    CloseView?.Invoke(this, e);
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void HandleException(Exception ex)
        {
            MessageBox.Show(this, "Có lỗi xảy ra, vui lòng thử lại hoặc liên hệ với người quản trị hệ thống." + Environment.NewLine + "Lỗi: " + ex.Message, "Quản lý thuốc", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
