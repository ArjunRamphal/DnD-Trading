namespace DnD_Trading
{
    partial class Reports
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
            this.lblReport = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentSurplus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentStatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wstGrp22DataSet = new DnD_Trading.WstGrp22DataSet();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.paymentTableAdapter = new DnD_Trading.WstGrp22DataSetTableAdapters.PaymentTableAdapter();
            this.crystalReport11 = new DnD_Trading.CrystalReport1();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productSurchargeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new DnD_Trading.WstGrp22DataSetTableAdapters.ProductTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderSupplierProductQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderSupplierProductPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderSupplierProductStatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.orderSupplierProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderSupplierProductTableAdapter = new DnD_Trading.WstGrp22DataSetTableAdapters.OrderSupplierProductTableAdapter();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wstGrp22DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderSupplierProductBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Font = new System.Drawing.Font("Impact", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReport.Location = new System.Drawing.Point(1185, 55);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(210, 68);
            this.lblReport.TabIndex = 0;
            this.lblReport.Text = "Reports";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.paymentIDDataGridViewTextBoxColumn,
            this.PaymentTotal,
            this.PaymentDue,
            this.PaymentSurplus,
            this.paymentStatusDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.paymentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(851, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(928, 357);
            this.dataGridView1.TabIndex = 1;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            // 
            // paymentIDDataGridViewTextBoxColumn
            // 
            this.paymentIDDataGridViewTextBoxColumn.DataPropertyName = "PaymentID";
            this.paymentIDDataGridViewTextBoxColumn.HeaderText = "PaymentID";
            this.paymentIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.paymentIDDataGridViewTextBoxColumn.Name = "paymentIDDataGridViewTextBoxColumn";
            this.paymentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PaymentTotal
            // 
            this.PaymentTotal.DataPropertyName = "PaymentTotal";
            this.PaymentTotal.HeaderText = "PaymentTotal";
            this.PaymentTotal.MinimumWidth = 8;
            this.PaymentTotal.Name = "PaymentTotal";
            // 
            // PaymentDue
            // 
            this.PaymentDue.DataPropertyName = "PaymentDue";
            this.PaymentDue.HeaderText = "PaymentDue";
            this.PaymentDue.MinimumWidth = 8;
            this.PaymentDue.Name = "PaymentDue";
            // 
            // PaymentSurplus
            // 
            this.PaymentSurplus.DataPropertyName = "PaymentSurplus";
            this.PaymentSurplus.HeaderText = "PaymentSurplus";
            this.PaymentSurplus.MinimumWidth = 8;
            this.PaymentSurplus.Name = "PaymentSurplus";
            // 
            // paymentStatusDataGridViewCheckBoxColumn
            // 
            this.paymentStatusDataGridViewCheckBoxColumn.DataPropertyName = "PaymentStatus";
            this.paymentStatusDataGridViewCheckBoxColumn.HeaderText = "PaymentStatus";
            this.paymentStatusDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.paymentStatusDataGridViewCheckBoxColumn.Name = "paymentStatusDataGridViewCheckBoxColumn";
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "Payment";
            this.paymentBindingSource.DataSource = this.wstGrp22DataSet;
            // 
            // wstGrp22DataSet
            // 
            this.wstGrp22DataSet.DataSetName = "WstGrp22DataSet";
            this.wstGrp22DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(970, 691);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(172, 28);
            this.cmbMonth.TabIndex = 2;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(981, 751);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(150, 55);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "Generate report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(970, 653);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(172, 28);
            this.cmbYear.TabIndex = 4;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1148, 505);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(631, 342);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(857, 656);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(107, 20);
            this.lblMonth.TabIndex = 6;
            this.lblMonth.Text = "Select month:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(857, 694);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(92, 20);
            this.lblYear.TabIndex = 7;
            this.lblYear.Text = "Select year:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::DnD_Trading.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1263);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(857, 617);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Product:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(857, 575);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Supplier:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(970, 572);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 28);
            this.comboBox1.TabIndex = 11;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(970, 614);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(172, 28);
            this.comboBox2.TabIndex = 12;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productSurchargeDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.productBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(339, 64);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 13;
            this.dataGridView2.Visible = false;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // productSurchargeDataGridViewTextBoxColumn
            // 
            this.productSurchargeDataGridViewTextBoxColumn.DataPropertyName = "ProductSurcharge";
            this.productSurchargeDataGridViewTextBoxColumn.HeaderText = "ProductSurcharge";
            this.productSurchargeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productSurchargeDataGridViewTextBoxColumn.Name = "productSurchargeDataGridViewTextBoxColumn";
            this.productSurchargeDataGridViewTextBoxColumn.Width = 150;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.wstGrp22DataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn1,
            this.productIDDataGridViewTextBoxColumn1,
            this.supplierIDDataGridViewTextBoxColumn,
            this.orderSupplierProductQuantityDataGridViewTextBoxColumn,
            this.orderSupplierProductPriceDataGridViewTextBoxColumn,
            this.orderSupplierProductStatusDataGridViewCheckBoxColumn});
            this.dataGridView3.DataSource = this.orderSupplierProductBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(339, 281);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(240, 150);
            this.dataGridView3.TabIndex = 14;
            this.dataGridView3.Visible = false;
            // 
            // orderIDDataGridViewTextBoxColumn1
            // 
            this.orderIDDataGridViewTextBoxColumn1.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn1.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.orderIDDataGridViewTextBoxColumn1.Name = "orderIDDataGridViewTextBoxColumn1";
            this.orderIDDataGridViewTextBoxColumn1.Width = 150;
            // 
            // productIDDataGridViewTextBoxColumn1
            // 
            this.productIDDataGridViewTextBoxColumn1.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn1.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.productIDDataGridViewTextBoxColumn1.Name = "productIDDataGridViewTextBoxColumn1";
            this.productIDDataGridViewTextBoxColumn1.Width = 150;
            // 
            // supplierIDDataGridViewTextBoxColumn
            // 
            this.supplierIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.HeaderText = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn";
            this.supplierIDDataGridViewTextBoxColumn.Width = 150;
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
            // orderSupplierProductBindingSource
            // 
            this.orderSupplierProductBindingSource.DataMember = "OrderSupplierProduct";
            this.orderSupplierProductBindingSource.DataSource = this.wstGrp22DataSet;
            // 
            // orderSupplierProductTableAdapter
            // 
            this.orderSupplierProductTableAdapter.ClearBeforeFill = true;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(95, 12);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.crystalReport11;
            this.crystalReportViewer1.Size = new System.Drawing.Size(2371, 1334);
            this.crystalReportViewer1.TabIndex = 15;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(2478, 1344);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblReport);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wstGrp22DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderSupplierProductBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private WstGrp22DataSet wstGrp22DataSet;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private WstGrp22DataSetTableAdapters.PaymentTableAdapter paymentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentDue;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentSurplus;
        private System.Windows.Forms.DataGridViewCheckBoxColumn paymentStatusDataGridViewCheckBoxColumn;
        private CrystalReport1 crystalReport11;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource productBindingSource;
        private WstGrp22DataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productSurchargeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource orderSupplierProductBindingSource;
        private WstGrp22DataSetTableAdapters.OrderSupplierProductTableAdapter orderSupplierProductTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderSupplierProductQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderSupplierProductPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn orderSupplierProductStatusDataGridViewCheckBoxColumn;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}