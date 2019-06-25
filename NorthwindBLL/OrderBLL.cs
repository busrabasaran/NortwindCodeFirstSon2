using NorthwindEntitys;
using NortwindDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindBLL
{
    public static class OrderBLL
    {
        public static NorthwindDbContext db = new NorthwindDbContext();
        public static List<Orders> Get_Order( string CustomerId)
        {
            return db.Orders.Where(x => x.CustomerID == CustomerId).ToList();
        }

        public static object Get_Order_Details(int OrderId)
        {
            var details = from o in db.Orders
                          join c in db.Customers on o.CustomerID equals c.CustomerID
                          where o.OrderID==OrderId
                          select new
                          {
                             o.OrderID,
                             c.ContactName,                       
                             o.ShipCountry
                          };
            return details.ToList();
        }

        public static object Get_Order_Details_More(int OrderId)
        {
            var details = from o in db.Orders
                          join e in db.Employees on o.EmployeeID equals e.EmployeeID
                          join c in db.Customers on o.CustomerID equals c.CustomerID
                          where o.OrderID == OrderId
                          select new
                          {
                              o.OrderID,
                              c.ContactName,
                              e.FirstName,
                              o.ShipCountry
                          };
            return details.ToList();
        }
    }
}
