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
    public partial class Client: Form
    {
        private Parent mainForm;
        public Client(Parent p)
        {
            
            InitializeComponent();
            mainForm=p;
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

        }
    }
}
