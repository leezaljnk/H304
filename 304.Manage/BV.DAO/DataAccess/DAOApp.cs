using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using BV.DataModel;

namespace BV.DAO
{
    public class DAOApp
    {
        private static readonly string connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        private static BVEntities _bvProvider;
        public static BVEntities DbContext => _bvProvider ?? (_bvProvider = InitConnection());

        public static List<TEntity> GetDanhMuc<TEntity>(int take = 0) where TEntity : class
        {
            return take == 0
                ? DbContext.Set<TEntity>().AsNoTracking().ToList()
                : DbContext.Set<TEntity>().AsNoTracking().Take(take).ToList();
        }

        public static int CountRecords<TEntity>() where TEntity : class
        {
            return DbContext.Set<TEntity>().AsNoTracking().Count();
        }

        private static BVEntities InitConnection()
        {
            var ct = new BVEntities();
            if (!string.IsNullOrEmpty(connectionString))
                ct.Database.Connection.ConnectionString = connectionString;
            return ct;
        }
    }
}