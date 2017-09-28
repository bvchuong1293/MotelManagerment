using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotelManagement.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private MotelManagementDbContext dbContext;
        
        public MotelManagementDbContext Init()
        {
            return dbContext ?? (dbContext = new MotelManagementDbContext());
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
