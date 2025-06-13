using DnD_Trading.WstGrp22DataSetTableAdapters;
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
    public partial class CreateOrderRequest : Form
    {
        private Parent mainForm;
        public CreateOrderRequest(Parent p)
        {
            InitializeComponent();
            mainForm=p;
        }

        private void CreateOrderRequest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wstGrp22DataSet.Payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter.Fill(this.wstGrp22DataSet.Payment);
            // TODO: This line of code loads data into the 'wstGrp22DataSet.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.wstGrp22DataSet.Order);
            // TODO: This line of code loads data into the 'wstGrp22DataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.wstGrp22DataSet.Client);
            // TODO: This line of code loads data into the 'wstGrp22DataSet.ClientOrderProduct' table. You can move, or remove it, as needed.
            this.clientOrderProductTableAdapter.Fill(this.wstGrp22DataSet.ClientOrderProduct);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Add new product to order?", "New Product", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK) {
                // Validate Product Description
                if (string.IsNullOrWhiteSpace(txtProdDesc.Text))
                {
                    MessageBox.Show("Product description is required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Validate Product Quantity
                if (!int.TryParse(txtProdQuantity.Text.Trim(), out int quantity) || quantity <= 0)
                {
                    MessageBox.Show("Product quantity must be a positive integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Insert the product into the order
                clientOrderProductTableAdapter.Insert(
                    globalvar.orderID,
                    globalvar.clientID,
                    txtProdDesc.Text.Trim(),
                    Convert.ToInt32(txtProdQuantity.Text.Trim())
                );

                MessageBox.Show("Product added to order successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionally, you can clear the input fields after adding
                txtProdDesc.Clear();
                txtProdQuantity.Clear();

                clientOrderProductTableAdapter.FillByOrderID(this.wstGrp22DataSet.ClientOrderProduct, globalvar.orderID);
            }
            else
            {
                MessageBox.Show("Product addition cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView2_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            globalvar.clientID = (int)dataGridView2.CurrentRow.Cells[0].Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //orderTableAdapter.FillByDESC(this.wstGrp22DataSet.Order);
            //globalvar.orderID = Convert.ToInt32(dataGridView3.Rows[0].Cells[0].Value) + 1;

            int paymentID;

            if (dataGridView3.Rows.Count > 0 && dataGridView3.Rows[0].Cells[0].Value != null)
            {
                paymentID = Convert.ToInt32(dataGridView3.Rows[0].Cells[0].Value);
            }
            else
            {
                paymentID = 0;
            }

            DialogResult result = MessageBox.Show("Create new order record?", "New Order", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                globalvar.orderID = orderTableAdapter.Insert(
                    globalvar.clientID, // ClientID
                    paymentID, // PaymentID
                    globalvar.userName, // UserName
                    DateTime.Now, // OrderDate
                    0, // OrderTotal
                    false // OrderComplete
                );
                MessageBox.Show("Order created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Order creation cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Hide();
        }
    }

    public static class globalvar
    {
        public static string userName = "";
        public static string userFirstName = "";
        public static string userSurname = "";
        public static int orderID = 0;
        public static int clientID = 0;
        public static int productID = 0;
    }
}