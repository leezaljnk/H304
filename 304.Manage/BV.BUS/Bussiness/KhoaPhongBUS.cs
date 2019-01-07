using BV.DAO;
using BV.DataModel;

namespace BV.BUS
{
    public class KhoaPhongBUS
    {
        public static Khoa UpdateKhoa(Khoa k)
        {
            return KhoaPhongDAO.UpdateKhoa(k);
        }

        public static PhongKham UpdatePhongKham(PhongKham p)
        {
            return KhoaPhongDAO.UpdatePhongKham(p);
        }
    }
}
