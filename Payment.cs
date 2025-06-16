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
    public partial class Payment: Form
    {
        private Parent mainForm;

        public Payment(Parent p)
        {
            mainForm=p;
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wstGrp22DataSet.PaymentForm' table. You can move, or remove it, as needed.
            this.paymentFormTableAdapter.Fill(this.wstGrp22DataSet.PaymentForm);
            // TODO: This line of code loads data into the 'wstGrp22DataSet.Payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter.Fill(this.wstGrp22DataSet.Payment);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Hide();
            mainForm.Panel1.Visible = true;
            mainForm.MenuStrip1.Items[8].Visible = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                paymentTableAdapter.FillByStatusTrue(this.wstGrp22DataSet.Payment);
            }
            else
            {
                paymentTableAdapter.FillByStatusFalse(this.wstGrp22DataSet.Payment);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.paymentTableAdapter.Fill(this.wstGrp22DataSet.Payment);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (Convert.ToDecimal(textBox1.Text.Trim()) <= 0)
            {
                MessageBox.Show("Payment amount must be a positive number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Update payment status?", "Update Payment", MessageBoxButtons.OKCancel);
            if (result != DialogResult.OK)
            {
                MessageBox.Show("Payment update cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Validate that a row is selected
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a payment to update.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate that the status is not already true
            if (Convert.ToBoolean(dataGridView1.CurrentRow.Cells[3].Value))
            {
                MessageBox.Show("This payment is already marked as paid.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Convert.ToDecimal(textBox1.Text.Trim()) >= Convert.ToDecimal(dataGridView1.CurrentRow.Cells[3].Value))
            {
                decimal surplus = Convert.ToDecimal(textBox1.Text.Trim()) - Convert.ToDecimal(dataGridView1.CurrentRow.Cells[3].Value);
                
                paymentTableAdapter.UpdatePayment(
                true,
                0,
                surplus,
                globalvar.paymentID
                );
            }
            else
            {
                // Update the payment status
                paymentTableAdapter.UpdatePayment(
                false,
                Convert.ToDecimal(dataGridView1.CurrentRow.Cells[3].Value) - Convert.ToDecimal(textBox1.Text.Trim()),
                0,
                globalvar.paymentID
                );
            }
              
            paymentFormTableAdapter.Fill(this.wstGrp22DataSet.PaymentForm);
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            globalvar.paymentID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);

            MessageBox.Show("Payment ID: " + globalvar.paymentID, "Payment Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Validate that the input is not empty
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter a client name to search.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Fill the PaymentForm table with the filtered data based on the client name

            paymentFormTableAdapter.FillByClientName(this.wstGrp22DataSet.PaymentForm, textBox2.Text.Trim());
        }
    }
}
