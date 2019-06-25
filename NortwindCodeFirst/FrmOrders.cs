using NorthwindBLL;
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
    public partial class FrmOrders : Form
    {
        public FrmOrders()
        {
            InitializeComponent();
        }

        public static int OrderId { get; set; }

        private void FrmOrders_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = OrderBLL.Get_Order(FrmGetCustomer.customerId);
        }

        
        private void siparişDetaylarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrderDetails frm = new FrmOrderDetails();
            OrderId = (int)dataGridView1.CurrentRow.Cells["OrderID"].Value;
            frm.Show();
        }
    }
}
