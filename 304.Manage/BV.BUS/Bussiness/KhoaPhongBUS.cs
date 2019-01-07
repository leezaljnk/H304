using BV.DataConnector;
using BV.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
