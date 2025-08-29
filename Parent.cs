﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Net.Mail;
using System.Net.Sockets;

namespace DnD_Trading
{
    public partial class Parent: Form
    {

        public Panel Panel1;
        public MenuStrip MenuStrip1;
        public Parent()
        {
            InitializeComponent();
            Panel1 = this.panel1;
            MenuStrip1 = this.menuStrip1;
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
            Product product = new Product(this);
            FormSetup(product); // Set up the form as an MDI child
            product.MdiParent = this; //display the child window //maximize the child window
            product.WindowState = FormWindowState.Maximized;
            product.Show();
            panel1.Visible = false; // Hide the login panel when navigating to the inventory form
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports(this);
            FormSetup(reports); // Set up the form as an MDI child
            reports.MdiParent = this; //display the child window //maximize the child window
            reports.WindowState = FormWindowState.Maximized;
            reports.Show();
            panel1.Visible = false;
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClient addClient = new AddClient(this);
            FormSetup(addClient); // Set up the form as an MDI child
            addClient.MdiParent = this; //display the child window //maximize the child window
            addClient.WindowState = FormWindowState.Maximized;
            addClient.Show();
            panel1.Visible = false;
        }

        private void searchForClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client client = new Client(this);
            FormSetup(client); // Set up the form as an MDI child
            client.MdiParent = this; //display the child window //maximize the child window
            client.WindowState = FormWindowState.Maximized;
            client.Show();
            panel1.Visible = false;
        }

        private void searchForOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order order = new Order(this);
            FormSetup(order); // Set up the form as an MDI child
            order.MdiParent = this; //display the child window //maximize the child window
            order.WindowState = FormWindowState.Maximized;
            order.Show();
            panel1.Visible = false;
        }

        private void createOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateOrder createOrder = new CreateOrder(this);
            FormSetup(createOrder); // Set up the form as an MDI child
            createOrder.MdiParent = this; //display the child window //maximize the child window
            createOrder.WindowState = FormWindowState.Maximized;
            createOrder.Show();
            panel1.Visible = false;
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

                    if (Convert.ToInt32(wstGrp22DataSet.User.Rows[0]["UserOptOut"]) == 1)
                    {
                        MessageBox.Show("This user has opted out of the system. Please contact support.", "User Opted Out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Exit the login process if the user has opted out
                    }

                    globalvar.loggedInAs = Convert.ToInt32(wstGrp22DataSet.User.Rows[0]["UserType"]); // 0 = Sales Rep, 1 = Manager

                    // Access the specific row and column instead of using ItemArray  
                    DataRow userRow = wstGrp22DataSet.User.Rows[0];
                    if (userRow["UserType"].ToString() == "False")
                    {
                        menuStrip1.Items[6].Visible = false;
                        menuStrip1.Items[7].Visible = false;
                    }
                    else
                    {
                        menuStrip1.Items[6].Visible = true;
                        menuStrip1.Items[7].Visible = true;
                    }
                    
                    // User exists, proceed to the main application  
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    globalvar.userName = txtUsername.Text.Trim();
                    globalvar.userFirstName = userRow["UserFirstName"].ToString();
                    globalvar.userSurname = userRow["UserLastName"].ToString();
                    txtUsername.Clear();
                    txtPassword.Clear();   
                    txtUsername.Visible = false;
                    txtPassword.Visible = false;
                    btnLogin.Visible = false;
                    lblForgotPassword.Visible = false;
                    lblReEnter.Visible = false;
                    txtReEnterPassword.Visible = false;
                    btnChangePassword.Visible = false;
                    pbBack.Visible = false;
                    pbReEnterPassword.Visible = false;
                    label1.Visible = false;
                    label2.Visible = false;
                    pbShowPassword.Visible = false;
                    lblLogin.Visible = true;
                    lblLogin.Location = new Point(12, 9); // Adjust the position as needed

                    lblLogin.Text = "Welcome, " + globalvar.userFirstName + " " + globalvar.userSurname + "!";
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
            label3.Visible = true;
            label4.Visible = true;
            textBox1.Visible = true;
            button2.Visible = true;
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
                int affectedRows = userTableAdapter.UpdateQuery1(
                    txtReEnterPassword.Text.Trim(),
                    txtUsername.Text.Trim(),
                    textBox1.Text.Trim(),
                    txtUsername.Text.Trim()
                );

                if (affectedRows > 0)
                {
                    MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtReEnterPassword.Clear();
                    lblReEnter.Visible = false;
                    txtReEnterPassword.Visible = false;
                    btnChangePassword.Visible = false;
                    pbReEnterPassword.Visible = false;
                    pbBack.Visible = false;
                    btnLogin.Visible = true;
                    lblForgotPassword.Visible = true;
                    label3.Visible = false;
                    label4.Visible = false;
                    textBox1.Visible = false;
                    button2.Visible = false;
                    textBox1.Clear();
                    label4.Text = "Verification Question:";
                }
                else
                {
                    MessageBox.Show("Incorrect username/verification question answer. Password not changed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            this.WindowState = FormWindowState.Maximized; // Set the form to maximized state
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
            label3.Visible = false;
            label4.Visible = false;
            textBox1.Visible = false;
            button2.Visible = false;
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
            Supplier supplier = new Supplier(this);
            FormSetup(supplier); // Set up the form as an MDI child
            supplier.MdiParent = this; //display the child window //maximize the child window
            supplier.WindowState = FormWindowState.Maximized;
            supplier.Show();
            panel1.Visible = false;
        }

        private void createOrderRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateOrderRequest createOrderRequest = new CreateOrderRequest(this);
            FormSetup(createOrderRequest); // Set up the form as an MDI child
            createOrderRequest.MdiParent = this; //display the child window //maximize the child window
            createOrderRequest.WindowState = FormWindowState.Maximized;
            createOrderRequest.Show();
            panel1.Visible = false;
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment(this);
            FormSetup(payment); // Set up the form as an MDI child
            payment.MdiParent = this; //display the child window //maximize the child window
            payment.WindowState = FormWindowState.Maximized;
            payment.Show();
            panel1.Visible = false;
        }

        public void FormSetup(Form myForm)
        { 
            //if a childform exists, close it
            if (this.ActiveMdiChild != null)
            { 
                this.ActiveMdiChild.Close();
            }
            menuStrip1.Items[8].Visible = false;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
            txtUsername.Visible = true;
            txtPassword.Visible = true;
            btnLogin.Visible = true;
            lblForgotPassword.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            pbShowPassword.Visible = true;
            label3.Visible = false;
            globalvar.userName = string.Empty; // Clear the global variable
            globalvar.userFirstName = string.Empty; // Clear the global variable
            globalvar.userSurname = string.Empty; // Clear the global variable
            globalvar.clientID = 0; // Reset client ID
            globalvar.orderID = 0; // Reset order ID
            globalvar.paymentID = 0; // Reset payment ID
            lblLogin.Visible = true;
            lblLogin.Text = "Login";
            lblLogin.Location = new Point(750, 150); // Adjust the position as needed
            lblReEnter.Visible = false;
            txtUsername.Clear();
            txtPassword.Clear();
            txtReEnterPassword.Clear();
            globalvar.priceTotal = 0; // Reset price total
            globalvar.productID = 0; // Reset product ID
            globalvar.loggedInAs = -1; // Reset logged in status

            MessageBox.Show("You have been logged out successfully.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void addUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser(this);
            FormSetup(addUser); // Set up the form as an MDI child
            addUser.MdiParent = this; //display the child window //maximize the child window
            addUser.WindowState = FormWindowState.Maximized;
            addUser.Show();
            panel1.Visible = false;
        }

        private void searchForUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User User = new User(this);
            FormSetup(User); // Set up the form as an MDI child
            User.MdiParent = this; //display the child window //maximize the child window
            User.WindowState = FormWindowState.Maximized;
            User.Show();
            panel1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            /*
            try
            {
                // Fill the DataGridView with users matching the entered username
                userTableAdapter.FillByUsername(wstGrp22DataSet.User, txtUsername.Text.Trim());
                label4.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();
                label4.Text = wstGrp22DataSet.User.Rows[0]["UserQuestion"].ToString();
            }
            catch (Exception ex)
            {
                // Handle the case where there are no rows or the cell is empty
                label4.Text = "Verification Question:";
            }
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                // Fill the DataGridView with users matching the entered username
                userTableAdapter.FillByUsername(wstGrp22DataSet.User, txtUsername.Text.Trim());
                //label4.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();
                label4.Text = wstGrp22DataSet.User.Rows[0]["UserQuestion"].ToString();
            }
            catch (Exception ex)
            {
                // Handle the case where there are no rows or the cell is empty
                label4.Text = "Verification Question:";
            }
        }
    }
}
