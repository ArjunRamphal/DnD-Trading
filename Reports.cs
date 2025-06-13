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
    public partial class Reports: Form
    {
        private Parent mainForm;
        public Reports(Parent p)
        {
            InitializeComponent();
            mainForm=p;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Hide();
        }
    }
}
