using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTTShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        NTTShopDbContext dbContext;
        public NTTShopDbContext Init()
        {
            return dbContext ?? (dbContext = new NTTShopDbContext());
        }
        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
