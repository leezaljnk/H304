﻿using System;
using System.Windows.Forms;
using BV.AppCommon;
using BV.BUS;
using BV.DataModel;

namespace BV.QLKHO.THUOC
{
    public partial class NhaCungCapForm : Form
    {
        public NhaCungCap Entity;

        public NhaCungCapForm()
        {
            InitializeComponent();
        }

        internal void InitThongTin(NhaCungCap p)
        {
            if (p == null) p = new NhaCungCap {ID = -1};
            Entity = p;
            txtDiaChi.Text = p.DiaChi;
            txtThanPho.Text = p.TinhThanh;
            txtTen.Text = p.Ten;
            txtSDT.Text = p.DienThoai;
            txtFax.Text = p.Fax;
            txtEmail.Text = p.Email;
            txtEmail.Text = p.WebSite;
            txtGhiChu.Text = p.GhiChu;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveEntity();
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void SaveEntity()
        {
            var ncc = new NhaCungCap();
            ncc.ID = Entity.ID;
            ncc.Ten = txtTen.Text;
            ncc.DiaChi = txtDiaChi.Text;
            ncc.TinhThanh = txtThanPho.Text;
            ncc.DienThoai = txtSDT.Text;
            ncc.Fax = txtFax.Text;
            ncc.Email = txtEmail.Text;
            ncc.WebSite = txtWebsite.Text;
            ncc.GhiChu = txtGhiChu.Text;

            //Save data
            ncc = BusApp.SaveNhaCungCap(ncc);

            //Update cached
            AppCached.UpdateDanhMuc(ncc, "ID");
            Entity = ncc;
        }

        private void HandleException(Exception ex)
        {
            MessageBox.Show(this,
                "Có lỗi xảy ra, vui lòng thử lại hoặc liên hệ với người quản trị hệ thống." + Environment.NewLine +
                "Lỗi: " + ex.Message, "Quản lý thuốc", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}