using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace DnD_Trading
{
    public partial class Parent: Form
    {
        public Parent()
        {
            InitializeComponent();
        }

        private void pbShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '\0';
            pbShowPassword.Image = Image.FromFile("HidePassword.png");
        }

        private void pbShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '*';
            pbShowPassword.Image = System.Drawing.Image.FromFile("ShowPassword.png");
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Show();
            this.Hide();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
            this.Hide();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClient addClient = new AddClient();
            addClient.Show();
            this.Hide();
        }

        private void searchForClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
            this.Hide();
        }

        private void searchForOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Show();
            this.Hide();
        }

        private void createOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateOrder createOrder = new CreateOrder();
            createOrder.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                userTableAdapter.FillByUsernameAndPassword(wstGrp22DataSet.User, txtUsername.Text.Trim(), txtPassword.Text.Trim());

                if (wstGrp22DataSet.User.Rows.Count > 0)
                {
                    menuStrip1.Visible = true;
                    menuStrip1.Items[0].Visible = false;

                    // Access the specific row and column instead of using ItemArray  
                    DataRow userRow = wstGrp22DataSet.User.Rows[0];
                    if (userRow["UserType"].ToString() == "False")
                    {
                        menuStrip1.Items[4].Visible = false;
                        menuStrip1.Items[5].Visible = false;
                    }
                    else
                    {
                        menuStrip1.Items[4].Visible = true;
                        menuStrip1.Items[5].Visible = true;
                    }
                        // User exists, proceed to the main application  
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // User does not exist, show error message  
                    MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during login: " + ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnLogin.Visible = false;
            lblForgotPassword.Visible = false;
            lblReEnter.Visible = true;
            txtReEnterPassword.Visible = true;
            btnChangePassword.Visible = true;
            pbBack.Visible = true;
            pbReEnterPassword.Visible = true;
            txtUsername.Clear();
            txtPassword.Clear();
            txtReEnterPassword.Clear();
            label2.Text = "New password:";
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtReEnterPassword.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please enter both username and new password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtReEnterPassword.Text.Trim() != txtPassword.Text.Trim())
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            { 
                // Attempt to update and get number of affected rows
                int affectedRows = userTableAdapter.UpdateQuery(
                    txtReEnterPassword.Text.Trim(),
                    txtUsername.Text.Trim()
                );

                if (affectedRows > 0)
                {
                    MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No user found with that username. Password not changed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while changing the password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Parent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wstGrp22DataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.wstGrp22DataSet.User);
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            pbBack.Visible = false;
            btnLogin.Visible = true;
            lblForgotPassword.Visible = true;
            lblReEnter.Visible = false;
            txtReEnterPassword.Visible = false;
            btnChangePassword.Visible = false;
            pbReEnterPassword.Visible = false;
            txtUsername.Clear();
            txtPassword.Clear();
            txtReEnterPassword.Clear();
            label2.Text = "Password:";
        }

        private void pbReEnterPassword_Click(object sender, EventArgs e)
        {

        }

        private void pbReEnterPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtReEnterPassword.PasswordChar = '\0';
            pbReEnterPassword.Image = Image.FromFile("HidePassword.png");
        }

        private void pbReEnterPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtReEnterPassword.PasswordChar = '*';
            pbReEnterPassword.Image = System.Drawing.Image.FromFile("ShowPassword.png");
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();
            supplier.Show();
            this.Hide();
        }
    }
}
