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
            // TODO: This line of code loads data into the 'wstGrp22DataSet.Payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter.Fill(this.wstGrp22DataSet.Payment);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Hide();
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
    }
}
