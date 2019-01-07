using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BV.DataModel.KhoChung;

namespace BV.QLKHO.KhoBV
{
    public partial class DanhMucKhoForm : Form
    {
        public Kho Entity;
        public DanhMucKhoForm()
        {
            InitializeComponent();
        }

        internal void InitThongTin(Kho p)
        {
            cboKhoa.DataSource = KhoUtil.GetDanhMuc<KhoaPhong>();
            cboKhoa.DisplayMember = "Ten";
            cboKhoa.ValueMember = "ID";

            cboLoaiKho.DataSource = KhoUtil.GetDanhMuc<LoaiKho>();
            cboLoaiKho.DisplayMember = "Ten";
            cboLoaiKho.ValueMember = "ID";

            if (p == null) p = new Kho() { ID = Guid.Empty };
            Entity = p;
            txtTenKho.Text = p.TenKho;
            txtMaKho.Text = p.MaKho;
            cboKhoa.Value = p.KhoaId;
            cboLoaiKho.Value = p.LoaiKhoId;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void HandleException(Exception ex)
        {
            MessageBox.Show(this,
                @"Có lỗi xảy ra, vui lòng thử lại hoặc liên hệ với người quản trị hệ thống." + Environment.NewLine
                + $@"Lỗi: {ex.Message}", @"Quản lý kho", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SaveEntity()
        {
            var oKho = new Kho
            {
                ID = Entity.ID,
                MaKho = txtMaKho.Text,
                TenKho = txtMaKho.Text,
                KhoaId = (int?)cboKhoa.SelectedItem.DataValue,
                LoaiKhoId = (int?)cboLoaiKho.SelectedItem.DataValue
            };

            //Save data
            oKho = KhoUtil.SaveDanhMucKho(oKho);

            //Update cached

            oKho.LoaiKho = KhoUtil.GetDanhMuc<LoaiKho>().FirstOrDefault(e => e.ID == oKho.LoaiKhoId);
            oKho.KhoaPhong = KhoUtil.GetDanhMuc<KhoaPhong>().FirstOrDefault(e => e.ID == oKho.LoaiKhoId);
            KhoUtil.UpdateDanhMuc(oKho, "ID");
            Entity = oKho;
        }


    }
}
