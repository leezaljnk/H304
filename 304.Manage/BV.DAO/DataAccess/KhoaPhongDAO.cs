using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BV.DataModel;

namespace BV.DataConnector
{
    public class KhoaPhongDAO
    {
        public static Khoa UpdateKhoa(Khoa entity)
        {
            var dbContext = AppDAO.DbContext;

            var item = dbContext.Khoa.FirstOrDefault(k => k.ID == entity.ID);
            if (item == null)
            {
                //Insert
                item = dbContext.Khoa.FirstOrDefault(k => k.Ma == entity.Ma);
                if (item != null)
                {
                    throw new Exception("Mã khoa trùng lặp với khoa khác");
                }

                dbContext.Khoa.Add(entity);
            }
            else
            {
                //Update
                var checkItem = dbContext.Khoa.FirstOrDefault(k => k.ID != entity.ID && k.Ma == entity.Ma);
                if (checkItem != null)
                {
                    throw new Exception("Mã khoa trùng lặp với khoa khác");
                }

                item.Ma = entity.Ma;
                item.Ten = entity.Ten;
                item.MoTa = entity.MoTa;
                item.MaBYT = entity.MaBYT;
                item.TenBYT = entity.TenBYT;
            }

            dbContext.SaveChanges();
            return entity;
        }

        public static PhongKham UpdatePhongKham(PhongKham entity)
        {
            var dbContext = AppDAO.DbContext;

            var item = dbContext.PhongKham.FirstOrDefault(k => k.ID == entity.ID);
            if (item == null)
            {
                //Insert
                item = dbContext.PhongKham.FirstOrDefault(k => k.Ma == entity.Ma);
                if (item != null)
                {
                    throw new Exception("Mã phòng khám trùng lặp với phòng khám khác");
                }

                dbContext.PhongKham.Add(entity);
            }
            else
            {
                //Update
                var checkItem = dbContext.PhongKham.FirstOrDefault(k => k.ID != entity.ID && k.Ma == entity.Ma);
                if (checkItem != null)
                {
                    throw new Exception("Mã phòng khám trùng lặp với phòng khám khác");
                }

                item.Ma = entity.Ma;
                item.Ten = entity.Ten;
                item.MoTa = entity.MoTa;
            }

            dbContext.SaveChanges();
            return entity;
        }
    }
}
