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
    public partial class AddUser: Form
    {
        private Parent mainForm;

        public AddUser(Parent p)
        {
            InitializeComponent();
            mainForm = p;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Add new user record?", "New User", MessageBoxButtons.OKCancel);
            if (result != DialogResult.OK)
            {
                return; // User cancelled the operation
            }

            // Validate required fields
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("User Name, First Name, and Last Name are required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            userTableAdapter.Insert(
                textBox1.Text.Trim(), // UserName
                textBox2.Text.Trim(), // UserFirstName
                textBox3.Text.Trim(), // UserLastName
                false, // UserPhoneNumber
                "12345", // UserPassword
                false // UserOptOut
            );
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wstGrp22DataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.wstGrp22DataSet.User);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Show();
            mainForm.Panel1.Visible = true;
        }
    }
}
