using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IAuditDataService
    {
        void SaveData(IEnumerable<DbEntityEntry> entries, Guid? sessionId);
    }
}