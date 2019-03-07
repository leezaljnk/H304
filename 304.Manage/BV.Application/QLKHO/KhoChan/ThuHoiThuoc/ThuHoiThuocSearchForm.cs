﻿using System;
using System.Windows.Forms;
using BV.DataModel;
using Common.Winforms.UserControls;

namespace BV.QLKHO.KhoChan.ThuHoiThuoc
{
    public partial class ThuHoiThuocSearchForm : FormBase
    {
        public bool _action = true;
        public ThuHoiThuocSearchForm()
        {
            InitializeComponent();
        }

        internal void InitData(PhieuTraThuoc phieuTraThuoc)
        {
            var index = 1;
            foreach (var phieu in phieuTraThuoc.PhieuTraThuocChiTiet)
            {
                //add item to grid
                var newItem = new object[]
                {
                    phieu.ID, //id
                    phieu.PhieuTraThuocId,
                    index,
                    phieu.HangHoa.Ten,
                    phieu.HangHoa.DonViHangHoa.Ten,
                    phieu.LoHangHoa.SoLo,
                    phieu.HanSuDung,
                    phieu.SoLuongTra,
                    phieu.ChietKhau,
                    phieu.DonGia,
                    phieu.SoLuongTra * phieu.DonGia
                };

                var newIdx = dataGridView1.Rows.Add(newItem);
                dataGridView1.Rows[newIdx].Tag = phieu;
                index++;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _action = true;
            DialogResult = DialogResult.OK;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _action = false;
            DialogResult = DialogResult.Cancel;
        }
    }
}
