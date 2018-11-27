using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BV.DataModel
{
    public class KhoTongProvider
    {
        private static BVEntities _bvProvider;
        public static BVEntities KhoTong => _bvProvider ?? (_bvProvider = new BVEntities());

        BVEntities dbContext;

        public KhoTongProvider()
        {
            dbContext = new BVEntities();
        }

        public static void InitKhoTong()
        {
        }

        public static void InitKho()
        { }

        public KhoTongProvider(DbContext db)
        {
            dbContext = db as BVEntities;
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
