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

            foreach (DataRow row in dataGridView1.Rows) {
                orderSupplierProductTableAdapter.Insert(globalvar.orderID, (int)dataGridView1.CurrentRow.Cells[1].Value, (int)dataGridView1.CurrentRow.Cells[2].Value, (int)dataGridView1.CurrentRow.Cells[3].Value, (decimal)dataGridView1.CurrentRow.Cells[4].Value, (bool)dataGridView1.CurrentRow.Cells[5].Value);
            }

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
        }

        private void dataGridView3_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //add supplier product to order
            DataRow dr;
            dr = wstGrp22DataSet.OrderSupplierProduct.NewRow();
            dr["OrderID"] = globalvar.orderID;
            dr["ProductID"] = (int)dataGridView3.CurrentRow.Cells[0].Value;
            dr["SupplierID"] = (int)dataGridView3.CurrentRow.Cells[1].Value;
            dr["OrderSupplierProductQuantity"] = int.Parse(numericUpDown1.Text.Trim());

            productTableAdapter.FillByProductSurcharge(wstGrp22DataSet.Product, (int)dataGridView3.CurrentRow.Cells[0].Value);

            decimal surcharge = (decimal)Convert.ToDecimal(dataGridView6.CurrentRow.Cells[2].Value)/100;

            dr["OrderSupplierProductPrice"] = ((decimal)dataGridView3.CurrentRow.Cells[2].Value + (surcharge * (decimal)dataGridView3.CurrentRow.Cells[2].Value)) * int.Parse(numericUpDown1.Text.Trim());
            dr["OrderSupplierProductStatus"] = false; // Default value for OrderSupplierProductStatus
            wstGrp22DataSet.OrderSupplierProduct.Rows.Add(dr);
            orderSupplierProductTableAdapter.Update(wstGrp22DataSet.OrderSupplierProduct);
            
        }
    }
}
