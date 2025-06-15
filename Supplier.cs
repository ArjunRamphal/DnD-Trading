using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD_Trading
{
    public partial class Supplier: Form
    {
        private Parent mainForm;

        private Product productForm;

        private bool isMainForm = false;
        private bool isProductForm = false;
        public Supplier(Parent p)
        {
            InitializeComponent();
            mainForm=p;
            isMainForm = true;
        }

        public Supplier(Product p)
        {
            InitializeComponent();
            productForm = p;
            isProductForm = true;
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wstGrp22DataSet.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.wstGrp22DataSet.Supplier);
        }

        private void txtSupplier_TextChanged(object sender, EventArgs e)
        {
            supplierTableAdapter.FillBySupplierName(this.wstGrp22DataSet.Supplier, txtSupplier.Text.Trim());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string supplierName = txtSupplierName.Text.Trim();
            string phoneNumber = txtSupplierPhoneNumber.Text.Trim();
            string email = txtSupplierEmail.Text.Trim();

            // Validate Supplier Name
            if (string.IsNullOrEmpty(supplierName))
            {
                MessageBox.Show("Supplier name is required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Phone Number, only digits
            if (!IsValidPhoneNumber(phoneNumber))
            {
                MessageBox.Show("Phone number must be 10 digits", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Email using MailAddress
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email address.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Insert the supplier data
            supplierTableAdapter.Insert(
                supplierName,      // SupplierName
                phoneNumber,       // SupplierPhoneNumber
                email,             // SupplierEmail
                false              // SupplierOptOut
            );

            MessageBox.Show("Supplier added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.supplierTableAdapter.Fill(this.wstGrp22DataSet.Supplier);

            if (isProductForm)
            {
                productForm.Show();
                this.Hide();
                productForm.WindowState = FormWindowState.Maximized;
            }
        }

        bool IsValidPhoneNumber(string number)
        {
            if (number.Length != 10)
                return false;

            foreach (char c in number)
            {
                if (!char.IsDigit(c))
                    return false;
            }

            return true;
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (isMainForm)
            {
                mainForm.Show();
                this.Hide();
                mainForm.Panel1.Visible = true;
            }
            else if (isProductForm)
            {
                productForm.Show();
                this.Hide();
                productForm.WindowState = FormWindowState.Maximized;
            }
                
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Product productForm = new Product(this);
            productForm.Show();
            productForm.WindowState = FormWindowState.Maximized;
            productForm.TabControl1.SelectedIndex = 1; // Switch to the first tab
            this.Hide();
        }
    }
}
