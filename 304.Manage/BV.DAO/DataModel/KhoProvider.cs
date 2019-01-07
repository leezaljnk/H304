using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BV.DataModel
{
    public partial class KhoProvider
    {
        private static BV304Entities _bvProvider;
        public static BV304Entities DbContext => _bvProvider ?? (_bvProvider = new BV304Entities());

        public List<TEntity> GetDanhMuc<TEntity>(int take = 0) where TEntity: class
        {
            if (take == 0)
                return DbContext.Set<TEntity>().AsNoTracking().ToList();
            else
                return DbContext.Set<TEntity>().AsNoTracking().Take<TEntity>(take).ToList();
        }
    }
}
