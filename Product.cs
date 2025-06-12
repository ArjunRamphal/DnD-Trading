using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD_Trading
{
    public partial class Product: Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Product_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wstGrp22DataSet.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.wstGrp22DataSet.Supplier);
            // TODO: This line of code loads data into the 'wstGrp22DataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.wstGrp22DataSet.Product);
        }

        private void txtProduct_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
