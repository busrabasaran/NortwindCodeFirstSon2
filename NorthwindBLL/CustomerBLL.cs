using NorthwindEntitys;
using NortwindDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindBLL
{
    public static class CustomerBLL
    {
        public static NorthwindDbContext db = new NorthwindDbContext();

        public static List<Customer> Get_Customer()
        {
            return db.Customers.ToList();
        }

        public static Customer CustomerShow(string id)
        {
            return db.Customers.FirstOrDefault(x => x.CustomerID == id);
        }

        public static void AddCustomer(string CustomerId, string CoumpanyName, string CountactName, string countacttitle, string adress, string city,
        string region, string PostaCode, string Country, string Phone, string fax)
        {

            try
            {
                if (CustomerId.Length > 5) { MessageBox.Show("Beş Karakterden Fazla Giriş Yaptınız Lütfen Düzeltiniz"); }                
                else if (CustomerId == "") { MessageBox.Show("CustomerID Bölümü BoşBırakılamaz"); }
                else if (CustomerId.Length < 5) { MessageBox.Show("CustomerID Beş Karakterden Oluşmalıdır"); }
                else
                {
                    db.Customers.Add(new Customer
                    {

                        CustomerID = CustomerId.ToUpper(),
                        CompanyName = CoumpanyName,
                        ContactName = CountactName,
                        ContactTitle = countacttitle,
                        Address = adress,
                        City = city,
                        Region = region,
                        PostalCode = PostaCode,
                        Country = Country,
                        Phone = Phone,
                        Fax = fax
                    });
                    db.SaveChanges();
                    MessageBox.Show("İşleminiz Başarı İle Gerçekleştirilmiştir ");
                }
            }
            catch
            {

                MessageBox.Show("İşleminiz Gerçekleştirilemedi");
            }
            //Server=BK-LAB204-IS002;Database=Northwind;User Id=sa; Password = 123

        }
    }
}
