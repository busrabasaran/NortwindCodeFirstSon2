using NorthwindBLL;
using NortwindDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NortwindCodeFirst
{
    public partial class FrmGetCustomer : Form
    {
        public FrmGetCustomer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        public static string customerId { get; set; }
        public static int OrderId { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource=  CustomerBLL.Get_Customer();
          
           
        }

        private void siparişleriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrders frm = new FrmOrders();
            customerId = (string)dataGridView1.CurrentRow.Cells["CustomerID"].Value;
            frm.Show();
           
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            CustomerAdd cd = new CustomerAdd();
            cd.Show();
        }

        
    }
}
