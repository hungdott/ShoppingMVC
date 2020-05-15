using PMSShopping.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSShopping.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        PMSShoppingDBContext dbContext;
        public PMSShoppingDBContext Init()
        {
            return dbContext ?? (dbContext = new PMSShoppingDBContext());
        }
        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}