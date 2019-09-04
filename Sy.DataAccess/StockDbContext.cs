using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Sy.Core.Entities;

namespace Sy.DataAccess
{
    public class StockDbContext :DbContext
    {
        public StockDbContext()
            :base(nameOrConnectionString :"name=MyCon")
        {

        }

        public virtual DbSet<Product>Products { get; set; }
        public virtual DbSet<Client> Clients { get; set; }

    }
}
