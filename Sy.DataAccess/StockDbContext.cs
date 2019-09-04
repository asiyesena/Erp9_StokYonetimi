using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Sy.Core.Entities;
using Sy.Core.ComplexTypes;
using Sy.Core.Abstracts;

namespace Sy.DataAccess
{
    public class StockDbContext : DbContext
    {
        public StockDbContext()
            : base(nameOrConnectionString: "name=MyCon")
        {
        }

            public override int SaveChanges()
        {
            if (StockSettings.UserInfo == null)
            {
                var selectedEntityList = ChangeTracker.Entries()
                    .Where(x => x.Entity is AuditBase && x.State == EntityState.Added);
                //insert yapılan entitiyleri yakalamak için

                foreach (var item in selectedEntityList)
                {
                    (item.Entity as AuditBase).CreatedUser = StockSettings.UserInfo.Email;
                    (item.Entity as AuditBase).CreatedDate = DateTime.Now;
                }
                selectedEntityList = ChangeTracker.Entries()
                     .Where(x => x.Entity is AuditBase && x.State == EntityState.Modified);
                foreach (var item in selectedEntityList)
                {
                    (item.Entity as AuditBase).CreatedUser = StockSettings.UserInfo.Email;
                    (item.Entity as AuditBase).CreatedDate = DateTime.Now;
                }
            }
            return base.SaveChanges();
        }
    

        public virtual DbSet<Product>Products { get; set; }
        public virtual DbSet<Client> Clients { get; set; }

    }
}
