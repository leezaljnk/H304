using BV.DataModel;
using BV.DAO;

namespace BV.BUS
{
    public class BUSKhoaPhong
    {
        public static Khoa UpdateKhoa(Khoa k)
        {
            return DAOKhoaPhong.UpdateKhoa(k);
        }

        public static PhongKham UpdatePhongKham(PhongKham p)
        {
            return DAOKhoaPhong.UpdatePhongKham(p);
        }
    }
}