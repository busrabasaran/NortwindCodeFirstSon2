using NorthwindEntitys;
using NortwindDAL.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NortwindDAL
{
     public class NorthwindDbContext:DbContext
    {
        public NorthwindDbContext():base(" name=NorthwindConnection")
        {
            Database.SetInitializer<NorthwindDbContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMapping());
            modelBuilder.Configurations.Add(new OrderMapping());
            modelBuilder.Configurations.Add(new EmployeeMapping());
        }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }

        public virtual DbSet<Employee> Employees { get; set; }
    }
}
