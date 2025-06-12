using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace DnD_Trading
{
    public partial class CreateOrder: Form
    {
        public CreateOrder()
        {
            InitializeComponent();
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {

        }

        private void CreateOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wstGrp22DataSet1.ClientOrderProduct' table. You can move, or remove it, as needed.
            this.clientOrderProductTableAdapter.Fill(this.wstGrp22DataSet1.ClientOrderProduct);
            // TODO: This line of code loads data into the 'wstGrp22DataSet.OrderSupplierProduct' table. You can move, or remove it, as needed.
            //this.orderSupplierProductTableAdapter.Fill(this.wstGrp22DataSet.OrderSupplierProduct);
            // TODO: This line of code loads data into the 'wstGrp22DataSet.SupplierProduct' table. You can move, or remove it, as needed.
            this.supplierProductTableAdapter.Fill(this.wstGrp22DataSet.SupplierProduct);

        }
    }
}
