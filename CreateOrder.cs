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
using System.Net;
using System.Reflection;

namespace DnD_Trading
{
    public partial class CreateOrder: Form
    {
        private Parent mainForm;
        public CreateOrder(Parent p)
        {
            mainForm=p;
            InitializeComponent();
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {

            //orderSupplierProductTableAdapter.Insert(globalvar.orderID, orderSupplierProductTableAdapter.);
            
            if (dataGridView1.Rows.Count == 1)
            {
                MessageBox.Show("No products in the order to create.", "No Products", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataRow dr;
            dr = wstGrp22DataSet.OrderSupplierProduct.NewRow();

            for (int i = 0; i < dr.ItemArray.Length; i++)
            {
                dr["OrderID"] = globalvar.orderID;
                dr["ProductID"] = (int)dataGridView1.CurrentRow.Cells[1].Value;
                dr["SupplierID"] = (int)dataGridView1.CurrentRow.Cells[2].Value;
                dr["OrderSupplierProductQuantity"] = (int)dataGridView1.CurrentRow.Cells[3].Value;
                dr["OrderSupplierProductPrice"] = (decimal)dataGridView1.CurrentRow.Cells[4].Value;
                dr["OrderSupplierProductStatus"] = (bool)dataGridView1.CurrentRow.Cells[5].Value;
            }

            //wstGrp22DataSet.OrderSupplierProduct.Rows.Add(dr);
            orderSupplierProductTableAdapter.Update(wstGrp22DataSet.OrderSupplierProduct);
            MessageBox.Show("Order created successfully.", "Order Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            
            // Send email notification

            string to, from, pass, body;
            MailMessage msg = new MailMessage();
            to = "ClientEmail";
            from = "DNDTrading22@gmail.com";
            pass = "onetwothreefourfive";
            body = "Order message";
            msg.To.Add(to);
            msg.From = new MailAddress(from);
            msg.Body = body;
            msg.Subject = "Subject";
            msg.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
        }

        private void CreateOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wstGrp22DataSet.CreateOrderSupplierProduct' table. You can move, or remove it, as needed.
            this.createOrderSupplierProductTableAdapter.Fill(this.wstGrp22DataSet.CreateOrderSupplierProduct);
            // TODO: This line of code loads data into the 'wstGrp22DataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.wstGrp22DataSet.Product);
            // TODO: This line of code loads data into the 'wstGrp22DataSet2.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.wstGrp22DataSet2.Supplier);

            // TODO: This line of code loads data into the 'wstGrp22DataSet2.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.wstGrp22DataSet2.Client);

            // TODO: This line of code loads data into the 'wstGrp22DataSet1.ClientOrderProduct' table. You can move, or remove it, as needed.
            this.clientOrderProductTableAdapter.FillByOrderID(this.wstGrp22DataSet1.ClientOrderProduct, globalvar.orderID);

            // TODO: This line of code loads data into the 'wstGrp22DataSet.OrderSupplierProduct' table. You can move, or remove it, as needed.
            //this.orderSupplierProductTableAdapter.Fill(this.wstGrp22DataSet.OrderSupplierProduct);

            // TODO: This line of code loads data into the 'wstGrp22DataSet.SupplierProduct' table. You can move, or remove it, as needed.
            this.supplierProductTableAdapter.Fill(this.wstGrp22DataSet.SupplierProduct);

        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel the order?", "Cancel Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dataGridView1.Rows.Count == 1)
                {
                    MessageBox.Show("No products in the order to cancel.", "No Products", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                MessageBox.Show("Order cancelled successfully.", "Order Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Show();
            mainForm.Panel1.Visible = true;
        }

        private void dataGridView3_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //add supplier product to order

            if (!int.TryParse(numericUpDown1.Text.Trim(), out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Product quantity must be a positive integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRow dr;
            dr = wstGrp22DataSet.OrderSupplierProduct.NewRow();

            int index = dataGridView3.CurrentRow.Index;

            int productID = Convert.ToInt32(wstGrp22DataSet.CreateOrderSupplierProduct.Rows[index]["ProductID"]);
            int supplierID = Convert.ToInt32(wstGrp22DataSet.CreateOrderSupplierProduct.Rows[index]["SupplierID"]);
            int price = Convert.ToInt32(wstGrp22DataSet.CreateOrderSupplierProduct.Rows[index]["SupplierProductPrice"]);

            dr["OrderID"] = globalvar.orderID;
            dr["ProductID"] = productID;
            dr["SupplierID"] = supplierID;
            dr["OrderSupplierProductQuantity"] = int.Parse(numericUpDown1.Text.Trim());

            productTableAdapter.FillByProductSurcharge(wstGrp22DataSet.Product, productID);

            decimal surcharge = (decimal)Convert.ToDecimal(dataGridView6.CurrentRow.Cells[2].Value)/100;

            dr["OrderSupplierProductPrice"] = ((decimal)dataGridView3.CurrentRow.Cells[2].Value + (surcharge * (decimal)dataGridView3.CurrentRow.Cells[2].Value)) * int.Parse(numericUpDown1.Text.Trim());
            dr["OrderSupplierProductStatus"] = false; // Default value for OrderSupplierProductStatus
            wstGrp22DataSet.OrderSupplierProduct.Rows.Add(dr);
            orderSupplierProductTableAdapter.Update(wstGrp22DataSet.OrderSupplierProduct);
            numericUpDown1.Value = 0; // Reset the numericUpDown control after adding the product
        }

        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {
            createOrderSupplierProductTableAdapter.FillByProductName(wstGrp22DataSet.CreateOrderSupplierProduct, txtProductSearch.Text.Trim());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Product product = new Product(this);
            product.Show();
            product.WindowState = FormWindowState.Maximized;
            product.TabControl1.SelectedIndex = 1; // Switch to the second tab
            this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Make sure there are rows and the clicked column is the checkbox column (index 2)
            if (dataGridView2.Rows.Count > 0 && e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                // Commit the checkbox value change
                dataGridView2.CommitEdit(DataGridViewDataErrorContexts.Commit);

                int index = e.RowIndex; // Use e.RowIndex for accurate indexing

                // Get IDs from the dataset (ensure binding/index match)
                int clientOrderProductID = Convert.ToInt32(wstGrp22DataSet1.ClientOrderProduct.Rows[index]["ClientOrderProductID"]);
                int orderID = Convert.ToInt32(wstGrp22DataSet1.ClientOrderProduct.Rows[index]["orderID"]);

                // Read the updated checkbox value
                bool isAdded = (bool)dataGridView2.Rows[index].Cells[2].Value;

                // Call update method with correct values
                clientOrderProductTableAdapter.UpdateStatus(
                    isAdded,
                    clientOrderProductID,
                    orderID
                );
            }
        }
    }
}
