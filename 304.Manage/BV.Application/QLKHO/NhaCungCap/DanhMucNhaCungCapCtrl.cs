using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BV.DataModel;
using BV.BUS;

namespace BV.QLKHO.THUOC
{
    public partial class DanhMucNhaCungCapCtrl : UserControl
    {
        public event EventHandler CloseView;
        private List<NhaCungCap> _DMNhaCungCap;

        public DanhMucNhaCungCapCtrl()
        {
            InitializeComponent();
        }

        internal void InitControlUI()
        {
            _DMNhaCungCap = BusApp.GetDanhMuc<NhaCungCap>();
            foreach (var t in _DMNhaCungCap)
            {
                var item = new object[] { t.Ten, t.DiaChi, t.TinhThanh, t.DienThoai, t.GhiChu};
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
                    NhaCungCapForm oForm = new NhaCungCapForm();
                    oForm.InitThongTin(null);
                    if (oForm.ShowDialog(this) == DialogResult.OK)
                    {
                        var t = oForm.Entity;
                        var item = new object[] { t.Ten, t.DiaChi, t.TinhThanh, t.DienThoai, t.GhiChu };
                        int i = dataGridView1.Rows.Add(item);
                        dataGridView1.Rows[i].Tag = t;
                    }
                }
                else if (e.ClickedItem.Name == "edit")
                {
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        var row = dataGridView1.SelectedRows[0];
                        NhaCungCap oThuoc = row.Tag as NhaCungCap;
                        NhaCungCapForm oForm = new NhaCungCapForm();
                        oForm.InitThongTin(oThuoc);
                        if (oForm.ShowDialog(this) == DialogResult.OK)
                        {
                            var t = oForm.Entity;
                            row.Cells[0].Value = t.Ten;
                            row.Cells[1].Value = t.DiaChi;
                            row.Cells[2].Value = t.TinhThanh;
                            row.Cells[3].Value = t.DienThoai;
                            row.Cells[4].Value = t.GhiChu;
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

        private void DanhMucNhaCungCapCtrl_CloseView1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DanhMucNhaCungCapCtrl_CloseView(object sender, EventArgs e)
        {
        }

        private void HandleException(Exception ex)
        {
            MessageBox.Show(this, "Có lỗi xảy ra, vui lòng thử lại hoặc liên hệ với người quản trị hệ thống." + Environment.NewLine + "Lỗi: " + ex.Message, "Quản lý thuốc", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
