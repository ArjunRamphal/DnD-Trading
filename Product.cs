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
        private Parent mainForm;
        public Product(Parent p)
        {
            InitializeComponent();
            mainForm= p;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Product_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wstGrp22DataSet.SearchAddProduct' table. You can move, or remove it, as needed.
            this.searchAddProductTableAdapter.Fill(this.wstGrp22DataSet.SearchAddProduct);
            // TODO: This line of code loads data into the 'wstGrp22DataSet.SupplierProduct' table. You can move, or remove it, as needed.
            this.supplierProductTableAdapter.Fill(this.wstGrp22DataSet.SupplierProduct);
            // TODO: This line of code loads data into the 'wstGrp22DataSet.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.wstGrp22DataSet.Supplier);
            // TODO: This line of code loads data into the 'wstGrp22DataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.wstGrp22DataSet.Product);
        }

        private void txtProduct_TextChanged(object sender, EventArgs e)
        {
            // Filter the Product table based on the text entered in txtProduct
            if (string.IsNullOrWhiteSpace(txtProduct.Text))
            {
                // If the text box is empty, reload all products
                searchAddProductTableAdapter.Fill(this.wstGrp22DataSet.SearchAddProduct);
                return;
            }

            searchAddProductTableAdapter.FillByProduct(this.wstGrp22DataSet.SearchAddProduct, txtProduct.Text.Trim());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtSurcharge.Text, out decimal surcharge))
            {
                productTableAdapter.UpdateQuery(surcharge, globalvar.productID);
                MessageBox.Show("Surcharge updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please enter a valid decimal value for the surcharge.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            productTableAdapter.Fill(this.wstGrp22DataSet.Product);
        }

        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            supplierTableAdapter.FillBySupplierName(this.wstGrp22DataSet.Supplier, cmbSupplier.Text.Trim());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Show();

        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            globalvar.productID = (int)dataGridView1.CurrentRow.Cells[0].Value;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Show();
        }
    }
}
