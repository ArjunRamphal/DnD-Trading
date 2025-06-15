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
        public TabControl TabControl1 { get; set; }

        private Parent mainForm;
        public Product(Parent p)
        {
            InitializeComponent();
            mainForm= p;
        }

        private Supplier supplierForm;
        public Product(Supplier p)
        {
            InitializeComponent();
            supplierForm = p;
        }

        private CreateOrder createOrderForm;
        private bool isCreateOrderForm = false;
        public Product(CreateOrder p)
        {
            InitializeComponent();
            createOrderForm = p;
            isCreateOrderForm = true;
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

            TabControl1 = this.tabControl1;
            comboBox1.Text = "";
            cmbSupplier.Text = "";
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
            if (isCreateOrderForm)
            {
                createOrderForm.Show();
                this.Hide();
                createOrderForm.WindowState = FormWindowState.Maximized;
                return;
            }
            this.Hide();
            mainForm.Show();
            mainForm.Panel1.Visible = true;
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            globalvar.productID = (int)dataGridView1.CurrentRow.Cells[0].Value;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string productName = txtProduct.Text.Trim();
            string supplierName = cmbSupplier.Text.Trim();

            if (string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(supplierName))
            {
                MessageBox.Show("Product name and supplier name cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Insert the new product into the database
            productTableAdapter.Insert(productName, text, 0, 0, 0, 0, 0, 0, 0);

            MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Optionally, you can clear the input fields after adding
            textBox1.Clear();
            comboBox1.SelectedIndex = -1;
            textBox3.Clear();
            textBox4.Clear();

            if (isCreateOrderForm)
            {
                createOrderForm.Show();
                this.Hide();
                createOrderForm.WindowState = FormWindowState.Maximized;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (isCreateOrderForm)
            {
                createOrderForm.Show();
                this.Hide();
                createOrderForm.WindowState = FormWindowState.Maximized;
                return;
            }
            this.Hide();
            mainForm.Show();
            mainForm.Panel1.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            productTableAdapter.FillByProduct(this.wstGrp22DataSet.Product, textBox2.Text.Trim());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.searchAddProductTableAdapter.Fill(this.wstGrp22DataSet.SearchAddProduct);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Supplier supplier = new Supplier(this);
            supplier.Show();
            this.Hide();
            supplier.WindowState = FormWindowState.Maximized;
        }
    }
}
