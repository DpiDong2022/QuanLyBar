using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamMem.DAO {
    internal class AppContextDb: DbContext {
        protected AppContextDb() {
        }
    }
}
