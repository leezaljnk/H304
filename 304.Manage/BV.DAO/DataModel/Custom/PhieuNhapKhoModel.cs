using System.Collections.Generic;

namespace BV.DataModel
{
    public class PhieuNhapKhoModel : PhieuNhapKho
    {
        public List<ChiTietPhieu> ChiTietPhieus { get; set; }
    }

    public enum LoaiChietKhau
    {
        PhanTram = 1,
        TienMat = 2
    }
}
