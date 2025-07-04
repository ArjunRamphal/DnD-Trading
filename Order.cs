﻿using DnD_Trading.WstGrp22DataSetTableAdapters;
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
    public partial class Order: Form
    {
        private Parent mainForm;
        
        public Order(Parent p)
        {
            InitializeComponent();
            mainForm=p;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Hide();
            mainForm.Panel1.Visible = true;
            mainForm.MenuStrip1.Items[8].Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Order_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wstGrp22DataSet1.ClientClientOrderProductOrder' table. You can move, or remove it, as needed.
            this.clientClientOrderProductOrderTableAdapter.Fill(this.wstGrp22DataSet1.ClientClientOrderProductOrder);
            // TODO: This line of code loads data into the 'wstGrp22DataSet2.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.wstGrp22DataSet2.User);
            // TODO: This line of code loads data into the 'wstGrp22DataSet2.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.wstGrp22DataSet2.Order);
            // TODO: This line of code loads data into the 'wstGrp22DataSet1.ClientOrder' table. You can move, or remove it, as needed.
            this.clientOrderTableAdapter.Fill(this.wstGrp22DataSet1.ClientOrder);
            // TODO: This line of code loads data into the 'wstGrp22DataSet.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.wstGrp22DataSet.Order);
            comboBox2.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            clientClientOrderProductOrderTableAdapter.FillByClientName(this.wstGrp22DataSet1.ClientClientOrderProductOrder, textBox1.Text.Trim());
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            clientClientOrderProductOrderTableAdapter.FillBySalesRep(this.wstGrp22DataSet1.ClientClientOrderProductOrder, comboBox2.Text.Trim());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.clientOrderTableAdapter.Fill(this.wstGrp22DataSet1.ClientOrder);
            textBox1.Clear();
            comboBox2.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is the checkbox column (index 4)
            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                // Force the current edit (checkbox) to commit
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);

                int orderID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                bool isOptOut = (bool)dataGridView1.Rows[e.RowIndex].Cells[5].Value;

                orderTableAdapter.UpdateStatus(isOptOut, orderID);

                MessageBox.Show("Order status updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
