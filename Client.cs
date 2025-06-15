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
using DnD_Trading.WstGrp22DataSetTableAdapters;

namespace DnD_Trading
{
    public partial class Client : Form
    {
        private Parent mainForm;

        public Client(Parent p)
        {
            InitializeComponent();
            mainForm = p;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            clientTableAdapter.FillByName(this.wstGrp22DataSet.Client, txtName.Text.Trim());
            txtPhoneNumber.Clear();
            txtEmail.Clear();
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            clientTableAdapter.FillByPhoneNumber(this.wstGrp22DataSet.Client, txtPhoneNumber.Text.Trim());
            txtName.Clear();
            txtEmail.Clear();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            clientTableAdapter.FillByEmail(this.wstGrp22DataSet.Client, txtEmail.Text.Trim());
            txtName.Clear();
            txtPhoneNumber.Clear();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wstGrp22DataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.wstGrp22DataSet.Client);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Hide();
            mainForm.Panel1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int clientID = dataGridView1.CurrentRow.Cells[0].Value != null ? Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value) : 0;

            if (clientID == 0)
            {
                MessageBox.Show("Please select a client to update.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text) && string.IsNullOrWhiteSpace(txtPhoneNumber.Text) && string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please enter at least one field to search.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                if (MessageBox.Show("Are you sure you want to update client name?", "Client Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    clientTableAdapter.UpdateName(
                        textBox1.Text.Trim(), // ClientName
                        clientID // ClientID
                    );
                    MessageBox.Show("Client added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    MessageBox.Show("Client name update cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid client name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!string.IsNullOrWhiteSpace(textBox2.Text) && IsValidPhoneNumber(textBox2.Text.Trim()))
            {
                if (MessageBox.Show("Are you sure you want to update client phone number?", "Client Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    clientTableAdapter.UpdatePhoneNumber(
                        textBox2.Text.Trim(), // ClientName
                        clientID // ClientID
                    );
                    MessageBox.Show("Client added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Client phone number update cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            if (!string.IsNullOrWhiteSpace(textBox3.Text) && IsValidEmail(textBox3.Text.Trim()))
            {
                if (MessageBox.Show("Are you sure you want to update client email?", "Client Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    clientTableAdapter.UpdateEmail(
                        textBox3.Text.Trim(), // ClientName
                        clientID // ClientID
                    );
                    MessageBox.Show("Client added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Client email update cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else {
                MessageBox.Show("Please enter a valid email address.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is the checkbox column (index 4)
            if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                // Force the current edit (checkbox) to commit
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);

                int clientID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                bool isOptOut = (bool)dataGridView1.Rows[e.RowIndex].Cells[4].Value;

                clientTableAdapter.UpdateStatus(isOptOut, clientID);
            }
        }
    }
}
