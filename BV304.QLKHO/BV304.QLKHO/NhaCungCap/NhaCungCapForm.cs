using BV.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BV.QLKHO.THUOC
{
    public partial class NhaCungCapForm : Form
    {
        public NhaCungCap Entity = null;
        public NhaCungCapForm()
        {
            InitializeComponent();
        }

        internal void InitThongTin(NhaCungCap p)
        {
            if (p == null)
            {
                p = new NhaCungCap() { NguonNhapID = -1 };
            }
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
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void SaveEntity()
        {
            NhaCungCap ncc = new NhaCungCap();
            ncc.NguonNhapID = Entity.NguonNhapID;
            ncc.Ten = txtTen.Text;
            ncc.DiaChi = txtDiaChi.Text;
            ncc.TinhThanh = txtThanPho.Text;
            ncc.DienThoai = txtSDT.Text;
            ncc.Fax = txtFax.Text;
            ncc.Email = txtEmail.Text;
            ncc.WebSite = txtWebsite.Text;
            ncc.GhiChu = txtGhiChu.Text;

            //Save data
            ncc = KhoUtil.SaveNhaCungCap(ncc);

            //Update cached
            KhoUtil.UpdateDanhMuc<NhaCungCap>(ncc, "NguonNhapID");
            Entity = ncc;
        }

        private void HandleException(Exception ex)
        {
            MessageBox.Show(this, "Có lỗi xảy ra, vui lòng thử lại hoặc liên hệ với người quản trị hệ thống." + Environment.NewLine + "Lỗi: " + ex.Message, "Quản lý thuốc", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
