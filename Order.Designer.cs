namespace DnD_Trading
{
    partial class Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clientClientOrderProductOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wstGrp22DataSet1 = new DnD_Trading.WstGrp22DataSet();
            this.clientOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblOrder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wstGrp22DataSet2 = new DnD_Trading.WstGrp22DataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wstGrp22DataSet = new DnD_Trading.WstGrp22DataSet();
            this.orderTableAdapter = new DnD_Trading.WstGrp22DataSetTableAdapters.OrderTableAdapter();
            this.clientOrderTableAdapter = new DnD_Trading.WstGrp22DataSetTableAdapters.ClientOrderTableAdapter();
            this.orderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new DnD_Trading.WstGrp22DataSetTableAdapters.UserTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clientClientOrderProductOrderTableAdapter = new DnD_Trading.WstGrp22DataSetTableAdapters.ClientClientOrderProductOrderTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderAmountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStatusDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientClientOrderProductOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wstGrp22DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wstGrp22DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wstGrp22DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.ClientName,
            this.orderDateDataGridViewTextBoxColumn,
            this.orderAmountDataGridViewTextBoxColumn,
            this.UserName,
            this.orderStatusDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.clientClientOrderProductOrderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1318, 681);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "Order ID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ClientName
            // 
            this.ClientName.DataPropertyName = "ClientName";
            this.ClientName.HeaderText = "Client Name";
            this.ClientName.MinimumWidth = 8;
            this.ClientName.Name = "ClientName";
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "Order Date";
            this.orderDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            // 
            // orderAmountDataGridViewTextBoxColumn
            // 
            this.orderAmountDataGridViewTextBoxColumn.DataPropertyName = "OrderAmount";
            this.orderAmountDataGridViewTextBoxColumn.HeaderText = "Order Amount";
            this.orderAmountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderAmountDataGridViewTextBoxColumn.Name = "orderAmountDataGridViewTextBoxColumn";
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "Sales Rep Username";
            this.UserName.MinimumWidth = 8;
            this.UserName.Name = "UserName";
            // 
            // orderStatusDataGridViewCheckBoxColumn
            // 
            this.orderStatusDataGridViewCheckBoxColumn.DataPropertyName = "OrderStatus";
            this.orderStatusDataGridViewCheckBoxColumn.HeaderText = "Order Complete";
            this.orderStatusDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.orderStatusDataGridViewCheckBoxColumn.Name = "orderStatusDataGridViewCheckBoxColumn";
            // 
            // clientClientOrderProductOrderBindingSource
            // 
            this.clientClientOrderProductOrderBindingSource.DataMember = "ClientClientOrderProductOrder";
            this.clientClientOrderProductOrderBindingSource.DataSource = this.wstGrp22DataSet1;
            // 
            // wstGrp22DataSet1
            // 
            this.wstGrp22DataSet1.DataSetName = "WstGrp22DataSet";
            this.wstGrp22DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientOrderBindingSource
            // 
            this.clientOrderBindingSource.DataMember = "ClientOrder";
            this.clientOrderBindingSource.DataSource = this.wstGrp22DataSet1;
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Impact", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(1089, 72);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(184, 68);
            this.lblOrder.TabIndex = 1;
            this.lblOrder.Text = "Orders";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Client:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sales Representative:";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.userBindingSource;
            this.comboBox2.DisplayMember = "UserName";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(229, 87);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(334, 34);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.ValueMember = "UserName";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.wstGrp22DataSet2;
            // 
            // wstGrp22DataSet2
            // 
            this.wstGrp22DataSet2.DataSetName = "WstGrp22DataSet";
            this.wstGrp22DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::DnD_Trading.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1258);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(428, 32);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.wstGrp22DataSet;
            // 
            // wstGrp22DataSet
            // 
            this.wstGrp22DataSet.DataSetName = "WstGrp22DataSet";
            this.wstGrp22DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // clientOrderTableAdapter
            // 
            this.clientOrderTableAdapter.ClearBeforeFill = true;
            // 
            // orderBindingSource1
            // 
            this.orderBindingSource1.DataMember = "Order";
            this.orderBindingSource1.DataSource = this.wstGrp22DataSet2;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 52);
            this.button1.TabIndex = 11;
            this.button1.Text = "Reset filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Location = new System.Drawing.Point(387, 741);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 222);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // clientClientOrderProductOrderTableAdapter
            // 
            this.clientClientOrderProductOrderTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn1,
            this.clientIDDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn1,
            this.orderAmountDataGridViewTextBoxColumn1,
            this.orderStatusDataGridViewCheckBoxColumn1,
            this.userNameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.orderBindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(57, 153);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 13;
            this.dataGridView2.Visible = false;
            // 
            // orderIDDataGridViewTextBoxColumn1
            // 
            this.orderIDDataGridViewTextBoxColumn1.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn1.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.orderIDDataGridViewTextBoxColumn1.Name = "orderIDDataGridViewTextBoxColumn1";
            this.orderIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.orderIDDataGridViewTextBoxColumn1.Width = 150;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderDateDataGridViewTextBoxColumn1
            // 
            this.orderDateDataGridViewTextBoxColumn1.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn1.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.orderDateDataGridViewTextBoxColumn1.Name = "orderDateDataGridViewTextBoxColumn1";
            this.orderDateDataGridViewTextBoxColumn1.Width = 150;
            // 
            // orderAmountDataGridViewTextBoxColumn1
            // 
            this.orderAmountDataGridViewTextBoxColumn1.DataPropertyName = "OrderAmount";
            this.orderAmountDataGridViewTextBoxColumn1.HeaderText = "OrderAmount";
            this.orderAmountDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.orderAmountDataGridViewTextBoxColumn1.Name = "orderAmountDataGridViewTextBoxColumn1";
            this.orderAmountDataGridViewTextBoxColumn1.Width = 150;
            // 
            // orderStatusDataGridViewCheckBoxColumn1
            // 
            this.orderStatusDataGridViewCheckBoxColumn1.DataPropertyName = "OrderStatus";
            this.orderStatusDataGridViewCheckBoxColumn1.HeaderText = "OrderStatus";
            this.orderStatusDataGridViewCheckBoxColumn1.MinimumWidth = 8;
            this.orderStatusDataGridViewCheckBoxColumn1.Name = "orderStatusDataGridViewCheckBoxColumn1";
            this.orderStatusDataGridViewCheckBoxColumn1.Width = 150;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderBindingSource2
            // 
            this.orderBindingSource2.DataMember = "Order";
            this.orderBindingSource2.DataSource = this.wstGrp22DataSet1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(536, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1373, 995);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select an order by double clicking";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(2478, 1344);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblOrder);
            this.Name = "Order";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientClientOrderProductOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wstGrp22DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wstGrp22DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wstGrp22DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private WstGrp22DataSet wstGrp22DataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private WstGrp22DataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private WstGrp22DataSet wstGrp22DataSet1;
        private System.Windows.Forms.BindingSource clientOrderBindingSource;
        private WstGrp22DataSetTableAdapters.ClientOrderTableAdapter clientOrderTableAdapter;
        private WstGrp22DataSet wstGrp22DataSet2;
        private System.Windows.Forms.BindingSource orderBindingSource1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private WstGrp22DataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource clientClientOrderProductOrderBindingSource;
        private WstGrp22DataSetTableAdapters.ClientClientOrderProductOrderTableAdapter clientClientOrderProductOrderTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderAmountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn orderStatusDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderBindingSource2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn orderStatusDataGridViewCheckBoxColumn;
    }
}