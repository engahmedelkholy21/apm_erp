namespace pharma_manage
{
    partial class sales_best_selling
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.salestablemostsellingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new pharma_manage.DataSet1();
            this.sales_table_most_selling_TableAdapter = new pharma_manage.DataSet1TableAdapters.sales_table_most_selling_TableAdapter();
            this.usertxt = new System.Windows.Forms.Label();
            this.far3_txt = new System.Windows.Forms.Label();
            this.dateGroup = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.sum_money_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sum_count_txt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.salesproductIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesproductnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalproductcountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalsalespriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesprostockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salestablemostsellingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.dateGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salesproductIDDataGridViewTextBoxColumn,
            this.salesproductnameDataGridViewTextBoxColumn,
            this.totalproductcountDataGridViewTextBoxColumn,
            this.totalsalespriceDataGridViewTextBoxColumn,
            this.salesprostockDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.salestablemostsellingBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.Location = new System.Drawing.Point(70, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(787, 370);
            this.dataGridView1.TabIndex = 4;
            // 
            // salestablemostsellingBindingSource
            // 
            this.salestablemostsellingBindingSource.DataMember = "sales_table_most_selling";
            this.salestablemostsellingBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sales_table_most_selling_TableAdapter
            // 
            this.sales_table_most_selling_TableAdapter.ClearBeforeFill = true;
            // 
            // usertxt
            // 
            this.usertxt.AutoSize = true;
            this.usertxt.Location = new System.Drawing.Point(32, 32);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(28, 13);
            this.usertxt.TabIndex = 100;
            this.usertxt.Text = "user";
            this.usertxt.Visible = false;
            // 
            // far3_txt
            // 
            this.far3_txt.AutoSize = true;
            this.far3_txt.Location = new System.Drawing.Point(32, 85);
            this.far3_txt.Name = "far3_txt";
            this.far3_txt.Size = new System.Drawing.Size(27, 13);
            this.far3_txt.TabIndex = 101;
            this.far3_txt.Text = "far3";
            this.far3_txt.Visible = false;
            // 
            // dateGroup
            // 
            this.dateGroup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateGroup.Controls.Add(this.label4);
            this.dateGroup.Controls.Add(this.label3);
            this.dateGroup.Controls.Add(this.dateTimePicker2);
            this.dateGroup.Controls.Add(this.dateTimePicker1);
            this.dateGroup.Location = new System.Drawing.Point(188, 2);
            this.dateGroup.Name = "dateGroup";
            this.dateGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateGroup.Size = new System.Drawing.Size(550, 52);
            this.dateGroup.TabIndex = 102;
            this.dateGroup.TabStop = false;
            this.dateGroup.Text = "بحث في يوم أو فترة";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(233, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 14);
            this.label4.TabIndex = 93;
            this.label4.Text = "إلــــى";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(501, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 14);
            this.label3.TabIndex = 92;
            this.label3.Text = "من";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(26, 15);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 91;
            this.dateTimePicker2.Value = new System.DateTime(2015, 9, 21, 0, 0, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(295, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 90;
            this.dateTimePicker1.Value = new System.DateTime(2015, 9, 21, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // sum_money_txt
            // 
            this.sum_money_txt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sum_money_txt.BackColor = System.Drawing.Color.White;
            this.sum_money_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum_money_txt.Location = new System.Drawing.Point(224, 452);
            this.sum_money_txt.Name = "sum_money_txt";
            this.sum_money_txt.ReadOnly = true;
            this.sum_money_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sum_money_txt.Size = new System.Drawing.Size(210, 22);
            this.sum_money_txt.TabIndex = 123269;
            this.sum_money_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(284, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 14);
            this.label1.TabIndex = 123268;
            this.label1.Text = "اجمالي المبلغ";
            // 
            // sum_count_txt
            // 
            this.sum_count_txt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sum_count_txt.BackColor = System.Drawing.Color.White;
            this.sum_count_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum_count_txt.Location = new System.Drawing.Point(493, 452);
            this.sum_count_txt.Name = "sum_count_txt";
            this.sum_count_txt.ReadOnly = true;
            this.sum_count_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sum_count_txt.Size = new System.Drawing.Size(210, 22);
            this.sum_count_txt.TabIndex = 123267;
            this.sum_count_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(553, 435);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 14);
            this.label13.TabIndex = 123266;
            this.label13.Text = "اجمالي الكمية";
            // 
            // salesproductIDDataGridViewTextBoxColumn
            // 
            this.salesproductIDDataGridViewTextBoxColumn.DataPropertyName = "sales_product_ID";
            dataGridViewCellStyle3.NullValue = null;
            this.salesproductIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.salesproductIDDataGridViewTextBoxColumn.HeaderText = "كود الصنف";
            this.salesproductIDDataGridViewTextBoxColumn.Name = "salesproductIDDataGridViewTextBoxColumn";
            this.salesproductIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.salesproductIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // salesproductnameDataGridViewTextBoxColumn
            // 
            this.salesproductnameDataGridViewTextBoxColumn.DataPropertyName = "sales_product_name";
            this.salesproductnameDataGridViewTextBoxColumn.HeaderText = "اسم الصنف";
            this.salesproductnameDataGridViewTextBoxColumn.Name = "salesproductnameDataGridViewTextBoxColumn";
            this.salesproductnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.salesproductnameDataGridViewTextBoxColumn.Width = 200;
            // 
            // totalproductcountDataGridViewTextBoxColumn
            // 
            this.totalproductcountDataGridViewTextBoxColumn.DataPropertyName = "total_product_count";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N2";
            this.totalproductcountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.totalproductcountDataGridViewTextBoxColumn.HeaderText = "الكمية";
            this.totalproductcountDataGridViewTextBoxColumn.Name = "totalproductcountDataGridViewTextBoxColumn";
            this.totalproductcountDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalproductcountDataGridViewTextBoxColumn.Width = 120;
            // 
            // totalsalespriceDataGridViewTextBoxColumn
            // 
            this.totalsalespriceDataGridViewTextBoxColumn.DataPropertyName = "total_sales_price";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "N2";
            this.totalsalespriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.totalsalespriceDataGridViewTextBoxColumn.HeaderText = "اجمالي السعر";
            this.totalsalespriceDataGridViewTextBoxColumn.Name = "totalsalespriceDataGridViewTextBoxColumn";
            this.totalsalespriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalsalespriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // salesprostockDataGridViewTextBoxColumn
            // 
            this.salesprostockDataGridViewTextBoxColumn.DataPropertyName = "sales_pro_stock";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.salesprostockDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.salesprostockDataGridViewTextBoxColumn.HeaderText = "الفرع";
            this.salesprostockDataGridViewTextBoxColumn.Name = "salesprostockDataGridViewTextBoxColumn";
            this.salesprostockDataGridViewTextBoxColumn.ReadOnly = true;
            this.salesprostockDataGridViewTextBoxColumn.Width = 120;
            // 
            // sales_best_selling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 480);
            this.Controls.Add(this.sum_money_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sum_count_txt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dateGroup);
            this.Controls.Add(this.far3_txt);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "sales_best_selling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sales_best_selling";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.sales_best_selling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salestablemostsellingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.dateGroup.ResumeLayout(false);
            this.dateGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource salestablemostsellingBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.sales_table_most_selling_TableAdapter sales_table_most_selling_TableAdapter;
        public System.Windows.Forms.Label usertxt;
        public System.Windows.Forms.Label far3_txt;
        private System.Windows.Forms.GroupBox dateGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox sum_money_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sum_count_txt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesproductIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesproductnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalproductcountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalsalespriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesprostockDataGridViewTextBoxColumn;
    }
}