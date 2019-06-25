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
    public partial class FrmOrderDetails : Form
    {
        public FrmOrderDetails()
        {
            InitializeComponent();
        }

        private void FrmOrderDetails_Load(object sender, EventArgs e)
        {
            //dgv_OrderDetails.DataSource = OrderBLL.Get_Order_Details(FrmOrders.OrderId);
            dgv_OrderDetails.DataSource = OrderBLL.Get_Order_Details_More(FrmOrders.OrderId);
        }
    }
}
