using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BV.DataModel
{
    public partial class KhoProvider
    {
        private static BV304Entities _bvProvider;
        public static BV304Entities KhoTong => _bvProvider ?? (_bvProvider = new BV304Entities());

        BV304Entities dbContext;

        public KhoProvider()
        {
            dbContext = new BV304Entities();
        }

        public static void InitKhoTong()
        {
        }

        public static void InitKho()
        { }

        public KhoProvider(DbContext db)
        {
            dbContext = db as BV304Entities;
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
