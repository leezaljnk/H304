using BV.DataModel.KhoChung;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BV.DataModel
{
    public class KhoTongProvider
    {
        private static KhoChungEntities _bvProvider;
        public static KhoChungEntities KhoTong => _bvProvider ?? (_bvProvider = new KhoChungEntities());

        KhoChungEntities dbContext;

        public KhoTongProvider()
        {
            dbContext = new KhoChungEntities();
        }

        public static void InitKhoTong()
        {
        }

        public static void InitKho()
        { }

        public KhoTongProvider(DbContext db)
        {
            dbContext = db as KhoChungEntities;
        }

        public List<TEntity> GetDanhMuc<TEntity>(int take = 0) where TEntity: class
        {
            if (take == 0)
                return dbContext.Set<TEntity>().AsNoTracking().ToList();
            else
                return dbContext.Set<TEntity>().AsNoTracking().Take<TEntity>(take).ToList();
        }
    }
}
