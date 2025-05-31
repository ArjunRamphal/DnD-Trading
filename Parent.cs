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

        }
    }
}
