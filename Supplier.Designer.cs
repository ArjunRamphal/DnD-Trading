namespace DnD_Trading
{
    partial class Supplier
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
            this.supplierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierPhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierOptOutDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wstGrp22DataSet = new DnD_Trading.WstGrp22DataSet();
            this.supplierTableAdapter = new DnD_Trading.WstGrp22DataSetTableAdapters.SupplierTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.grpAddSupplier = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSupplierEmail = new System.Windows.Forms.TextBox();
            this.txtSupplierPhoneNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wstGrp22DataSet)).BeginInit();
            this.grpAddSupplier.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplierIDDataGridViewTextBoxColumn,
            this.supplierNameDataGridViewTextBoxColumn,
            this.supplierPhoneNumberDataGridViewTextBoxColumn,
            this.supplierEmailDataGridViewTextBoxColumn,
            this.supplierOptOutDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.supplierBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1272, 560);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // supplierIDDataGridViewTextBoxColumn
            // 
            this.supplierIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.HeaderText = "Supplier ID";
            this.supplierIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn";
            this.supplierIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supplierNameDataGridViewTextBoxColumn
            // 
            this.supplierNameDataGridViewTextBoxColumn.DataPropertyName = "SupplierName";
            this.supplierNameDataGridViewTextBoxColumn.HeaderText = "Supplier Name";
            this.supplierNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            // 
            // supplierPhoneNumberDataGridViewTextBoxColumn
            // 
            this.supplierPhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "SupplierPhoneNumber";
            this.supplierPhoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.supplierPhoneNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.supplierPhoneNumberDataGridViewTextBoxColumn.Name = "supplierPhoneNumberDataGridViewTextBoxColumn";
            // 
            // supplierEmailDataGridViewTextBoxColumn
            // 
            this.supplierEmailDataGridViewTextBoxColumn.DataPropertyName = "SupplierEmail";
            this.supplierEmailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.supplierEmailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.supplierEmailDataGridViewTextBoxColumn.Name = "supplierEmailDataGridViewTextBoxColumn";
            // 
            // supplierOptOutDataGridViewCheckBoxColumn
            // 
            this.supplierOptOutDataGridViewCheckBoxColumn.DataPropertyName = "SupplierOptOut";
            this.supplierOptOutDataGridViewCheckBoxColumn.HeaderText = "Opt Out";
            this.supplierOptOutDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.supplierOptOutDataGridViewCheckBoxColumn.Name = "supplierOptOutDataGridViewCheckBoxColumn";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.wstGrp22DataSet;
            // 
            // wstGrp22DataSet
            // 
            this.wstGrp22DataSet.DataSetName = "WstGrp22DataSet";
            this.wstGrp22DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1153, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 68);
            this.label1.TabIndex = 1;
            this.label1.Text = "Suppliers";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(6, 42);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(290, 26);
            this.lblSupplier.TabIndex = 2;
            this.lblSupplier.Text = "Search for supplier by name:";
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(291, 39);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(315, 32);
            this.txtSupplier.TabIndex = 3;
            this.txtSupplier.TextChanged += new System.EventHandler(this.txtSupplier_TextChanged);
            // 
            // grpAddSupplier
            // 
            this.grpAddSupplier.Controls.Add(this.btnAdd);
            this.grpAddSupplier.Controls.Add(this.txtSupplierEmail);
            this.grpAddSupplier.Controls.Add(this.txtSupplierPhoneNumber);
            this.grpAddSupplier.Controls.Add(this.label4);
            this.grpAddSupplier.Controls.Add(this.label3);
            this.grpAddSupplier.Controls.Add(this.txtSupplierName);
            this.grpAddSupplier.Controls.Add(this.lblSupplierName);
            this.grpAddSupplier.Location = new System.Drawing.Point(651, 623);
            this.grpAddSupplier.Name = "grpAddSupplier";
            this.grpAddSupplier.Size = new System.Drawing.Size(640, 274);
            this.grpAddSupplier.TabIndex = 4;
            this.grpAddSupplier.TabStop = false;
            this.grpAddSupplier.Text = "Add Supplier";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(247, 208);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 42);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add Supplier";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSupplierEmail
            // 
            this.txtSupplierEmail.Location = new System.Drawing.Point(217, 155);
            this.txtSupplierEmail.Name = "txtSupplierEmail";
            this.txtSupplierEmail.Size = new System.Drawing.Size(398, 32);
            this.txtSupplierEmail.TabIndex = 5;
            // 
            // txtSupplierPhoneNumber
            // 
            this.txtSupplierPhoneNumber.Location = new System.Drawing.Point(263, 100);
            this.txtSupplierPhoneNumber.Name = "txtSupplierPhoneNumber";
            this.txtSupplierPhoneNumber.Size = new System.Drawing.Size(352, 32);
            this.txtSupplierPhoneNumber.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Supplier Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Supplier Phone Number:";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(217, 39);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(398, 32);
            this.txtSupplierName.TabIndex = 1;
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Location = new System.Drawing.Point(6, 42);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(163, 26);
            this.lblSupplierName.TabIndex = 0;
            this.lblSupplierName.Text = "Supplier Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSupplier);
            this.groupBox1.Controls.Add(this.txtSupplier);
            this.groupBox1.Location = new System.Drawing.Point(18, 623);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 274);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::DnD_Trading.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(3, 1260);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::DnD_Trading.Properties.Resources.help_252;
            this.pictureBox2.Location = new System.Drawing.Point(2388, 1260);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Location = new System.Drawing.Point(435, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 401);
            this.panel1.TabIndex = 9;
            this.panel1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close help";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(29, 51);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(332, 246);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "·  Enter the supplier’s details in the form.\n\n·  Click \"Add Supplier\" to save the" +
    " information.\n";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.grpAddSupplier);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(659, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1341, 924);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List of suppliers";
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(2478, 1344);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Supplier";
            this.Text = "Suppliers";
            this.Load += new System.EventHandler(this.Supplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wstGrp22DataSet)).EndInit();
            this.grpAddSupplier.ResumeLayout(false);
            this.grpAddSupplier.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private WstGrp22DataSet wstGrp22DataSet;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private WstGrp22DataSetTableAdapters.SupplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.GroupBox grpAddSupplier;
        private System.Windows.Forms.TextBox txtSupplierEmail;
        private System.Windows.Forms.TextBox txtSupplierPhoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierPhoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn supplierOptOutDataGridViewCheckBoxColumn;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}