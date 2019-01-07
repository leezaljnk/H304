﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BV.DataModel;
using BV.BUS;
using System.Linq;
using BV.QuanTriHeThong.KhoaPhongBV;

namespace BV.QLKHO.THUOC
{
    public partial class DanhMucPhongKhamCtrl : UserControl
    {
        public event EventHandler CloseView;

        public DanhMucPhongKhamCtrl()
        {
            InitializeComponent();
        }

        internal void InitControlUI()
        {
            var lstPhongKham = AppBus.GetDanhMuc<PhongKham>();
            foreach (var t in lstPhongKham)
            {
                //Get TenKhoa
                var khoa = AppBus.GetDanhMuc<Khoa>().FirstOrDefault(k => k.ID == t.KhoaID);
                var item = new object[] { t.Ma, t.Ten, t.MoTa, khoa?.Ten};
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
                    ThongTinPhongKhamForm oForm = new ThongTinPhongKhamForm();
                    oForm.InitThongTin(null);
                    if (oForm.ShowDialog(this) == DialogResult.OK)
                    {
                        var t = oForm.Entity;
                        var khoa = AppBus.GetDanhMuc<Khoa>().FirstOrDefault(k => k.ID == t.KhoaID);
                        
                        var item = new object[] { t.Ma, t.Ten, t.MoTa, khoa?.Ten };
                        int i = dataGridView1.Rows.Add(item);
                        dataGridView1.Rows[i].Tag = t;
                    }
                }
                else if (e.ClickedItem.Name == "edit")
                {
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        var row = dataGridView1.SelectedRows[0];
                        PhongKham oThuoc = row.Tag as PhongKham;
                        ThongTinPhongKhamForm oForm = new ThongTinPhongKhamForm();
                        oForm.InitThongTin(oThuoc);
                        if (oForm.ShowDialog(this) == DialogResult.OK)
                        {
                            var t = oForm.Entity;
                            var khoa = AppBus.GetDanhMuc<Khoa>().FirstOrDefault(k => k.ID == t.KhoaID);
                            row.Cells[0].Value = t.Ma;
                            row.Cells[1].Value = t.Ten;
                            row.Cells[2].Value = t.MoTa;
                            row.Cells[3].Value = khoa?.Ten;

                            row.Tag = t;
                        }
                    }
                }
                else if(e.ClickedItem.Name == "exit")
                {
                    CloseView?.Invoke(this, e);
                }
            }
            catch (Exception ex)
            {
                this.HandleException(ex);
            }
        }

        private void HandleException(Exception ex)
        {
            MessageBox.Show(this, "Có lỗi xảy ra, vui lòng thử lại hoặc liên hệ với người quản trị hệ thống." + Environment.NewLine + "Lỗi: " + ex.Message, "Quản lý thuốc", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}