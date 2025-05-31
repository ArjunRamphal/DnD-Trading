namespace DnD_Trading
{
    partial class CreateOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtProductSearch = new System.Windows.Forms.TextBox();
            this.wstGrp22DataSet = new DnD_Trading.WstGrp22DataSet();
            this.supplierProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierProductTableAdapter = new DnD_Trading.WstGrp22DataSetTableAdapters.SupplierProductTableAdapter();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierProductPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderSupplierProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderSupplierProductTableAdapter = new DnD_Trading.WstGrp22DataSetTableAdapters.OrderSupplierProductTableAdapter();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderSupplierProductQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderSupplierProductPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderSupplierProductStatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wstGrp22DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderSupplierProductBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create order";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn1,
            this.supplierIDDataGridViewTextBoxColumn1,
            this.orderSupplierProductQuantityDataGridViewTextBoxColumn,
            this.orderSupplierProductPriceDataGridViewTextBoxColumn,
            this.orderSupplierProductStatusDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.orderSupplierProductBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 349);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(928, 220);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Location = new System.Drawing.Point(282, 694);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(179, 59);
            this.btnCreateOrder.TabIndex = 3;
            this.btnCreateOrder.Text = "Create order";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.supplierIDDataGridViewTextBoxColumn,
            this.supplierProductPriceDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.supplierProductBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(12, 111);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(928, 220);
            this.dataGridView3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 636);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Search for products";
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Location = new System.Drawing.Point(517, 694);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(179, 59);
            this.btnCancelOrder.TabIndex = 8;
            this.btnCancelOrder.Text = "Cancel order";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::DnD_Trading.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(0, 718);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // txtProductSearch
            // 
            this.txtProductSearch.Location = new System.Drawing.Point(480, 630);
            this.txtProductSearch.Name = "txtProductSearch";
            this.txtProductSearch.Size = new System.Drawing.Size(198, 26);
            this.txtProductSearch.TabIndex = 10;
            // 
            // wstGrp22DataSet
            // 
            this.wstGrp22DataSet.DataSetName = "WstGrp22DataSet";
            this.wstGrp22DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplierProductBindingSource
            // 
            this.supplierProductBindingSource.DataMember = "SupplierProduct";
            this.supplierProductBindingSource.DataSource = this.wstGrp22DataSet;
            // 
            // supplierProductTableAdapter
            // 
            this.supplierProductTableAdapter.ClearBeforeFill = true;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // supplierIDDataGridViewTextBoxColumn
            // 
            this.supplierIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.HeaderText = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn";
            this.supplierIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // supplierProductPriceDataGridViewTextBoxColumn
            // 
            this.supplierProductPriceDataGridViewTextBoxColumn.DataPropertyName = "SupplierProductPrice";
            this.supplierProductPriceDataGridViewTextBoxColumn.HeaderText = "SupplierProductPrice";
            this.supplierProductPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.supplierProductPriceDataGridViewTextBoxColumn.Name = "supplierProductPriceDataGridViewTextBoxColumn";
            this.supplierProductPriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderSupplierProductBindingSource
            // 
            this.orderSupplierProductBindingSource.DataMember = "OrderSupplierProduct";
            this.orderSupplierProductBindingSource.DataSource = this.wstGrp22DataSet;
            // 
            // orderSupplierProductTableAdapter
            // 
            this.orderSupplierProductTableAdapter.ClearBeforeFill = true;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // productIDDataGridViewTextBoxColumn1
            // 
            this.productIDDataGridViewTextBoxColumn1.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn1.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.productIDDataGridViewTextBoxColumn1.Name = "productIDDataGridViewTextBoxColumn1";
            this.productIDDataGridViewTextBoxColumn1.Width = 150;
            // 
            // supplierIDDataGridViewTextBoxColumn1
            // 
            this.supplierIDDataGridViewTextBoxColumn1.DataPropertyName = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn1.HeaderText = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.supplierIDDataGridViewTextBoxColumn1.Name = "supplierIDDataGridViewTextBoxColumn1";
            this.supplierIDDataGridViewTextBoxColumn1.Width = 150;
            // 
            // orderSupplierProductQuantityDataGridViewTextBoxColumn
            // 
            this.orderSupplierProductQuantityDataGridViewTextBoxColumn.DataPropertyName = "OrderSupplierProductQuantity";
            this.orderSupplierProductQuantityDataGridViewTextBoxColumn.HeaderText = "OrderSupplierProductQuantity";
            this.orderSupplierProductQuantityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderSupplierProductQuantityDataGridViewTextBoxColumn.Name = "orderSupplierProductQuantityDataGridViewTextBoxColumn";
            this.orderSupplierProductQuantityDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderSupplierProductPriceDataGridViewTextBoxColumn
            // 
            this.orderSupplierProductPriceDataGridViewTextBoxColumn.DataPropertyName = "OrderSupplierProductPrice";
            this.orderSupplierProductPriceDataGridViewTextBoxColumn.HeaderText = "OrderSupplierProductPrice";
            this.orderSupplierProductPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderSupplierProductPriceDataGridViewTextBoxColumn.Name = "orderSupplierProductPriceDataGridViewTextBoxColumn";
            this.orderSupplierProductPriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderSupplierProductStatusDataGridViewCheckBoxColumn
            // 
            this.orderSupplierProductStatusDataGridViewCheckBoxColumn.DataPropertyName = "OrderSupplierProductStatus";
            this.orderSupplierProductStatusDataGridViewCheckBoxColumn.HeaderText = "OrderSupplierProductStatus";
            this.orderSupplierProductStatusDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.orderSupplierProductStatusDataGridViewCheckBoxColumn.Name = "orderSupplierProductStatusDataGridViewCheckBoxColumn";
            this.orderSupplierProductStatusDataGridViewCheckBoxColumn.Width = 150;
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 801);
            this.Controls.Add(this.txtProductSearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "CreateOrder";
            this.Text = "DnD Trading - Create Order";
            this.Load += new System.EventHandler(this.CreateOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wstGrp22DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderSupplierProductBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtProductSearch;
        private WstGrp22DataSet wstGrp22DataSet;
        private System.Windows.Forms.BindingSource supplierProductBindingSource;
        private WstGrp22DataSetTableAdapters.SupplierProductTableAdapter supplierProductTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierProductPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderSupplierProductBindingSource;
        private WstGrp22DataSetTableAdapters.OrderSupplierProductTableAdapter orderSupplierProductTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderSupplierProductQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderSupplierProductPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn orderSupplierProductStatusDataGridViewCheckBoxColumn;
    }
}