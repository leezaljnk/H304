using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BV.DataModel.KhoChung;

namespace BV.QLKHO.KhoBV
{
    public partial class DanhMucKhoCtrl : UserControl
    {
        public event EventHandler CloseView;
        private List<Kho> _DMKho;
        public DanhMucKhoCtrl(List<Kho> inventories)
        {
            _DMKho = inventories;
            InitializeComponent();
            InitControlUI(inventories);
        }
        internal void InitControlUI(List<Kho> inventories)
        {
            dataGridView1.Rows.Clear();
            foreach (var t in inventories)
            {
                var item = new object[] { t.MaKho, t.TenKho, t.LoaiKho.Ten, t.KhoaPhong.Ten };
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
                    DanhMucKhoForm oForm = new DanhMucKhoForm();
                    oForm.InitThongTin(null);
                    if (oForm.ShowDialog(this) == DialogResult.OK)
                    {
                        var t = oForm.Entity;
                        var item = new object[] { t.MaKho, t.TenKho, t.LoaiKhoId, t.KhoaId };
                        int i = dataGridView1.Rows.Add(item);
                        dataGridView1.Rows[i].Tag = t;
                    }
                }
                else if (e.ClickedItem.Name == "edit")
                {
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        var row = dataGridView1.SelectedRows[0];
                        Kho oKho = row.Tag as Kho;
                        DanhMucKhoForm oForm = new DanhMucKhoForm();
                        oForm.InitThongTin(oKho);
                        if (oForm.ShowDialog(this) == DialogResult.OK)
                        {
                            var t = oForm.Entity;
                            row.Cells[0].Value = t.MaKho;
                            row.Cells[1].Value = t.TenKho;
                            row.Cells[2].Value = t.LoaiKho.Ten;
                            row.Cells[3].Value = t.KhoaPhong.Ten;
                            row.Tag = t;
                        }
                    }
                }
                else if (e.ClickedItem.Name == "exit")
                {
                    CloseView?.Invoke(this, null);
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void HandleException(Exception ex)
        {
            MessageBox.Show(this, @"Có lỗi xảy ra, vui lòng thử lại hoặc liên hệ với người quản trị hệ thống." + Environment.NewLine + @"Lỗi: " + ex.Message, @"Quản lý kho", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var strSeach = txtTenCSSearch.Text.Trim();
            if (string.IsNullOrEmpty(strSeach))
            {
                InitControlUI(_DMKho);
                return;
            }

            var kho = _DMKho.Where(k => k.MaKho.Contains(strSeach) || k.TenKho.Contains(strSeach) || k.LoaiKho.Ten.Contains(strSeach) || k.KhoaPhong.Ten.Contains(strSeach));
            InitControlUI(kho.ToList());
        }
    }
}
