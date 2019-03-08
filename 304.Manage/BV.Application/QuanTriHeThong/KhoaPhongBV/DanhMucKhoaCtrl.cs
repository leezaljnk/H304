using System;
using System.Windows.Forms;
using BV.BUS;
using BV.DataModel;
using BV.QuanTriHeThong.KhoaPhongBV;

namespace BV.QLKHO.THUOC
{
    public partial class DanhMucKhoaCtrl : UserControl
    {
        public DanhMucKhoaCtrl()
        {
            InitializeComponent();
        }

        public event EventHandler CloseView;

        internal void InitControlUI()
        {
            var lstKhoa = BusApp.GetDanhMuc<Khoa>();
            foreach (var t in lstKhoa)
            {
                var item = new object[] {t.Ma, t.Ten, t.MoTa, t.MaBYT, t.TenBYT};
                var i = dataGridView1.Rows.Add(item);
                dataGridView1.Rows[i].Tag = t;
            }
        }

        private void toolbarGeneral1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                if (e.ClickedItem.Name == "add")
                {
                    var oForm = new ThongTinKhoaForm();
                    oForm.InitThongTin(null);
                    if (oForm.ShowDialog(this) == DialogResult.OK)
                    {
                        var t = oForm.Entity;
                        var item = new object[] {t.Ma, t.Ten, t.MoTa, t.MaBYT, t.TenBYT};
                        var i = dataGridView1.Rows.Add(item);
                        dataGridView1.Rows[i].Tag = t;
                    }
                }
                else if (e.ClickedItem.Name == "edit")
                {
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        var row = dataGridView1.SelectedRows[0];
                        var oThuoc = row.Tag as Khoa;
                        var oForm = new ThongTinKhoaForm();
                        oForm.InitThongTin(oThuoc);
                        if (oForm.ShowDialog(this) == DialogResult.OK)
                        {
                            var t = oForm.Entity;
                            row.Cells[0].Value = t.Ma;
                            row.Cells[1].Value = t.Ten;
                            row.Cells[2].Value = t.MoTa;
                            row.Cells[3].Value = t.MaBYT;
                            row.Cells[4].Value = t.TenBYT;

                            row.Tag = t;
                        }
                    }
                }
                else if (e.ClickedItem.Name == "exit")
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
            MessageBox.Show(this,
                "Có lỗi xảy ra, vui lòng thử lại hoặc liên hệ với người quản trị hệ thống." + Environment.NewLine +
                "Lỗi: " + ex.Message, "Quản lý thuốc", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}