using NorthwindEntitys;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NortwindDAL.Mapping
{
    public class EmployeeMapping : EntityTypeConfiguration<Employee>
    {
        public EmployeeMapping()
        {
            ToTable("Employees");
            HasKey(e => e.EmployeeID);
        }
    }
}
