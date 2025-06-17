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

            decimal price = 0;

            DataRow dr;
            dr = wstGrp22DataSet.OrderSupplierProduct.NewRow();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Skip the last row if it's the new row placeholder
                if (row.IsNewRow) continue;

                dr = wstGrp22DataSet.OrderSupplierProduct.NewRow();

                dr["OrderID"] = globalvar.orderID;
                dr["ProductID"] = Convert.ToInt32(row.Cells[1].Value);
                dr["SupplierID"] = Convert.ToInt32(row.Cells[2].Value);
                dr["OrderSupplierProductQuantity"] = Convert.ToInt32(row.Cells[3].Value);
                dr["OrderSupplierProductPrice"] = Convert.ToDecimal(row.Cells[4].Value);
                dr["OrderSupplierProductStatus"] = false;

                // Add the price directly
                price += Convert.ToDecimal(row.Cells[4].Value);

                // Add the row to the dataset
                //wstGrp22DataSet.OrderSupplierProduct.Rows.Add(dr);
            }

            orderTableAdapter.UpdateOrderAmount(
                price,
                globalvar.orderID
            );

            //wstGrp22DataSet.OrderSupplierProduct.Rows.Add(dr);
            orderSupplierProductTableAdapter.Update(wstGrp22DataSet.OrderSupplierProduct);
            MessageBox.Show("Order created successfully.", "Order Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            paymentTableAdapter.UpdatePaymentTotalAndPaymentDue(
                price,
                price,
                globalvar.paymentID // Use the global variable for payment ID
            );

            // Send email notification to client

            globalvar.orderMessage +=
                "\nTotal Price: " + price.ToString("C2") + "\n" +
                "Please send proof of payment to the following email address: DNDTrading22@gmail.com";

            /*
            string to, from, pass, body;
            MailMessage msg = new MailMessage();
            //to = globalvar.clientEmail;
            to = "arjuunramphal@gmail.com";
            from = "dndtrading22@gmail.com";
            //pass = "onetwothreefourfive";
            pass = "qyax myny exec tzrb";
            
            body = globalvar.orderMessage;
            msg.To.Add(to);
            msg.From = new MailAddress(from);
            msg.Body = body;
            msg.Subject = "Requesting Proof of Payment from " + globalvar.clientName + " for Order " + globalvar.orderID.ToString();
            msg.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(msg);
                MessageBox.Show("Email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message, "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            */

            /*
            string to = "arjuunramphal@gmail.com";
            string from = "dndtrading22@gmail.com";
            // This must be an **App Password**, not your Gmail login password
            string pass = "qyax myny exec tzrb";
            string body = globalvar.orderMessage;

            MailMessage msg = new MailMessage();
            msg.To.Add(to);
            msg.From = new MailAddress(from);
            msg.Body = body;

            string clientName = globalvar.clientName?.Replace("\r", "").Replace("\n", "").Trim();
            string orderID = globalvar.orderID.ToString().Replace("\r", "").Replace("\n", "").Trim();

            // Limit the length if needed (Gmail supports up to ~998 characters for headers, but stay safe)
            if (clientName.Length > 100) clientName = clientName.Substring(0, 100);
            if (orderID.Length > 100) orderID = orderID.Substring(0, 100);

            // Set subject safely
            msg.Subject = $"Requesting Proof of Payment from {clientName} for Order {orderID}";

            //msg.Subject = "Requesting Proof of Payment from " + globalvar.clientName + " for Order " + globalvar.orderID.ToString();
           
            // Replace this line:
            //string orderID = globalvar.orderID?.ToString().Replace("\r", "").Replace("\n", "").Trim();

            // With this corrected line:
            
            msg.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(msg);
                MessageBox.Show("Email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message, "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */

            mainForm.Show();
            mainForm.Panel1.Visible = true;
            this.Hide();
        }

        private void CreateOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wstGrp22DataSet3.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.wstGrp22DataSet3.Order);
            // TODO: This line of code loads data into the 'wstGrp22DataSet.Payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter.Fill(this.wstGrp22DataSet.Payment);
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
                orderTableAdapter.DeleteQuery(globalvar.orderID);
                clientOrderProductTableAdapter.DeleteQuery(globalvar.orderID);
                orderSupplierProductTableAdapter.DeleteQuery(globalvar.orderID);
                dataGridView1.DataSource = null; // Clear the DataGridView
                dataGridView1.DataSource = wstGrp22DataSet.OrderSupplierProduct; // Rebind to the updated dataset
                dataGridView1.Refresh();
                globalvar.priceTotal = 0; // Reset the total price
                MessageBox.Show("Order cancelled successfully.", "Order Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                globalvar.orderID = 0; // Reset the order ID
                globalvar.clientID = 0; // Reset the client ID
                globalvar.clientName = string.Empty; // Reset the client name
                globalvar.clientEmail = string.Empty; // Reset the client email
                label4.Text = "Total Price: " + globalvar.priceTotal.ToString("C2"); // Update the total price label

                mainForm.Show();
                mainForm.Panel1.Visible = true; // Show the main form's panel
                mainForm.MenuStrip1.Items[8].Visible = true; // Show the "Create Order" menu item
                this.Hide(); // Hide the CreateOrder form
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Show();
            mainForm.Panel1.Visible = true;
            mainForm.MenuStrip1.Items[8].Visible = true;
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
            globalvar.priceTotal += ((decimal)dataGridView3.CurrentRow.Cells[2].Value + (surcharge * (decimal)dataGridView3.CurrentRow.Cells[2].Value)) * int.Parse(numericUpDown1.Text.Trim());
            label4.Text = "Total Price: " + globalvar.priceTotal.ToString("C2");
            dr["OrderSupplierProductStatus"] = false; // Default value for OrderSupplierProductStatus

            globalvar.orderMessage +=
                "Product: " + dataGridView3.CurrentRow.Cells[0].Value.ToString() + "\n" +
                "Supplier: " + dataGridView3.CurrentRow.Cells[1].Value.ToString() + "\n" +
                "Quantity: " + numericUpDown1.Text.Trim() + "\n" +
                "Price: " + ((decimal)dataGridView3.CurrentRow.Cells[2].Value + (surcharge * (decimal)dataGridView3.CurrentRow.Cells[2].Value)) * int.Parse(numericUpDown1.Text.Trim()) + "\n";

            wstGrp22DataSet.OrderSupplierProduct.Rows.Add(dr);
            orderSupplierProductTableAdapter.Update(wstGrp22DataSet.OrderSupplierProduct);
            numericUpDown1.Value = 0; // Reset the numericUpDown control after adding the product

            txtProductSearch.Clear(); // Clear the search box after adding the product
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
