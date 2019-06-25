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
    public partial class CustomerAdd : Form
    {
        public CustomerAdd()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CustomerBLL.AddCustomer(textCustomerID.Text, textCompanyName.Text, textContactName.Text, textContactTitle.Text, textAdress.Text, textCity.Text, textRagion.Text, textPostaCode.Text, textCountry.Text, textPhone.Text, textFax.Text);
        }
    }
}
