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
    public partial class User: Form
    {
        private Parent mainForm;

        public User(Parent p)
        {
            InitializeComponent();
            mainForm = p;
        }

        private void User_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wstGrp22DataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.wstGrp22DataSet.User);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (e.ColumnIndex == 5)
                {
                    int index = dataGridView1.CurrentRow.Index;

                    string username = Convert.ToString(wstGrp22DataSet.User.Rows[index]["UserName"]);

                    bool isOptOut = !((bool)dataGridView1.CurrentRow.Cells[5].Value);

                    userTableAdapter.UpdateStatus(
                        isOptOut,
                        username
                    );
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Filter the user table based on the first name entered in the text box
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                // If the text box is empty, reload the full user list
                userTableAdapter.Fill(wstGrp22DataSet.User);
                return;
            }

            userTableAdapter.FillByFirstName(
                wstGrp22DataSet.User,
                textBox1.Text.Trim()
            );
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Show();
            mainForm.Panel1.Visible = true;
            mainForm.MenuStrip1.Items[8].Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                // If the text box is empty, reload the full user list
                userTableAdapter.Fill(wstGrp22DataSet.User);
                return;
            }

            userTableAdapter.FillByLastName(
                wstGrp22DataSet.User,
                textBox2.Text.Trim()
            );
        }
    }
}
