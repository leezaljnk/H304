using BV.DataModel.Kho;
using BV.DataModel.KhoChung;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BV.DataModel
{
    public class KhoProvider
    {
        private static KhoEntities _bvProvider;
        public static KhoEntities KhoTong => _bvProvider ?? (_bvProvider = new KhoEntities());

        KhoEntities dbContext;

        public KhoProvider()
        {
            dbContext = new KhoEntities();
        }

        public static void InitKho(string makho)
        {
        }

        public static void InitKho()
        { }

        public KhoProvider(DbContext db)
        {
            dbContext = db as KhoEntities;
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
