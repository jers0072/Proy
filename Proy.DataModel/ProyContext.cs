using Proy.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy.DataModel
{
    public class ProyContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<Employee> Employee { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Types().Configure(c => c.Ignore("IsDirty"));
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            foreach (var history in this.ChangeTracker.Entries()
                .Where(e => e.Entity is BaseObject && (e.State == EntityState.Added || e.State == EntityState.Modified))
                .Select(e => e.Entity as BaseObject))
            {
                DateTime now = DateTime.Now;

                history.DateModified = now;

                if (history.DateCreated == DateTime.MinValue)
                {
                    history.DateCreated = now;
                }


            }

            int result = base.SaveChanges();
            foreach (var history in this.ChangeTracker.Entries()
                .Where(e => e.Entity is BaseObject)
                .Select(e => e.Entity as BaseObject))
            {
                history.IsDirty = false;
            }
            return result;
        }
    }
}
