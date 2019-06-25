using NorthwindEntitys;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NortwindDAL.Mapping
{
    public class OrderMapping: EntityTypeConfiguration<Orders>
    {
        public OrderMapping()
        {
            ToTable("Orders");
            HasKey(x => x.CustomerID);
        }
    }
}
