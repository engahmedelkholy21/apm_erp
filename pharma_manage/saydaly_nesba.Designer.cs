namespace pharma_manage
{
    partial class saydaly_nesba
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saydalydateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saydalynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saydalynesbaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productcountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saydalycostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saydalynesbaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new pharma_manage.DataSet1();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.egmaly_txt = new System.Windows.Forms.TextBox();
            this.saydaly_nesbaTableAdapter = new pharma_manage.DataSet1TableAdapters.saydaly_nesbaTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport11 = new pharma_manage.CrystalReport1();
            this.sales_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.sales_tableTableAdapter();
            this.far3_txt = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saydalynesbaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(407, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 14);
            this.label4.TabIndex = 106;
            this.label4.Text = "إلــــى";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(659, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 14);
            this.label3.TabIndex = 105;
            this.label3.Text = "من";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(200, 36);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 104;
            this.dateTimePicker2.Value = new System.DateTime(2015, 9, 21, 0, 0, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(453, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 103;
            this.dateTimePicker1.Value = new System.DateTime(2015, 9, 21, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // name_txt
            // 
            this.name_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txt.Location = new System.Drawing.Point(248, 8);
            this.name_txt.Name = "name_txt";
            this.name_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_txt.Size = new System.Drawing.Size(316, 22);
            this.name_txt.TabIndex = 123232;
            this.name_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name_txt.TextChanged += new System.EventHandler(this.name_txt_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(580, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 14);
            this.label1.TabIndex = 123233;
            this.label1.Text = "الصيدلي";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saydalydateDataGridViewTextBoxColumn,
            this.saydalynameDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.saydalynesbaDataGridViewTextBoxColumn,
            this.sellpriceDataGridViewTextBoxColumn,
            this.productcountDataGridViewTextBoxColumn,
            this.saydalycostDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.saydalynesbaBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(28, 430);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(828, 104);
            this.dataGridView1.TabIndex = 123236;
            // 
            // saydalydateDataGridViewTextBoxColumn
            // 
            this.saydalydateDataGridViewTextBoxColumn.DataPropertyName = "saydaly_date";
            this.saydalydateDataGridViewTextBoxColumn.HeaderText = "التاريخ";
            this.saydalydateDataGridViewTextBoxColumn.Name = "saydalydateDataGridViewTextBoxColumn";
            this.saydalydateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saydalynameDataGridViewTextBoxColumn
            // 
            this.saydalynameDataGridViewTextBoxColumn.DataPropertyName = "saydaly_name";
            this.saydalynameDataGridViewTextBoxColumn.HeaderText = "الصيدلي";
            this.saydalynameDataGridViewTextBoxColumn.Name = "saydalynameDataGridViewTextBoxColumn";
            this.saydalynameDataGridViewTextBoxColumn.ReadOnly = true;
            this.saydalynameDataGridViewTextBoxColumn.Width = 120;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "product_name";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "اسم الصنف";
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            this.productnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.productnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // saydalynesbaDataGridViewTextBoxColumn
            // 
            this.saydalynesbaDataGridViewTextBoxColumn.DataPropertyName = "saydaly_nesba";
            this.saydalynesbaDataGridViewTextBoxColumn.HeaderText = "النسبة";
            this.saydalynesbaDataGridViewTextBoxColumn.Name = "saydalynesbaDataGridViewTextBoxColumn";
            this.saydalynesbaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sellpriceDataGridViewTextBoxColumn
            // 
            this.sellpriceDataGridViewTextBoxColumn.DataPropertyName = "sell_price";
            this.sellpriceDataGridViewTextBoxColumn.HeaderText = "سعر الوحدة";
            this.sellpriceDataGridViewTextBoxColumn.Name = "sellpriceDataGridViewTextBoxColumn";
            this.sellpriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productcountDataGridViewTextBoxColumn
            // 
            this.productcountDataGridViewTextBoxColumn.DataPropertyName = "product_count";
            this.productcountDataGridViewTextBoxColumn.HeaderText = "الكمية";
            this.productcountDataGridViewTextBoxColumn.Name = "productcountDataGridViewTextBoxColumn";
            this.productcountDataGridViewTextBoxColumn.ReadOnly = true;
            this.productcountDataGridViewTextBoxColumn.Width = 110;
            // 
            // saydalycostDataGridViewTextBoxColumn
            // 
            this.saydalycostDataGridViewTextBoxColumn.DataPropertyName = "saydaly_cost";
            this.saydalycostDataGridViewTextBoxColumn.HeaderText = "مبلغ الصيدلي";
            this.saydalycostDataGridViewTextBoxColumn.Name = "saydalycostDataGridViewTextBoxColumn";
            this.saydalycostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saydalynesbaBindingSource
            // 
            this.saydalynesbaBindingSource.DataMember = "saydaly_nesba";
            this.saydalynesbaBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(642, -82);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(10, 22);
            this.textBox1.TabIndex = 123235;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(599, 543);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 14);
            this.label2.TabIndex = 123238;
            this.label2.Text = "الصيدلي";
            // 
            // egmaly_txt
            // 
            this.egmaly_txt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.egmaly_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.egmaly_txt.Location = new System.Drawing.Point(267, 540);
            this.egmaly_txt.Name = "egmaly_txt";
            this.egmaly_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.egmaly_txt.Size = new System.Drawing.Size(316, 22);
            this.egmaly_txt.TabIndex = 123237;
            this.egmaly_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // saydaly_nesbaTableAdapter
            // 
            this.saydaly_nesbaTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(-5, 75);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.CrystalReport11;
            this.crystalReportViewer1.Size = new System.Drawing.Size(878, 400);
            this.crystalReportViewer1.TabIndex = 123239;
            // 
            // sales_tableTableAdapter1
            // 
            this.sales_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // far3_txt
            // 
            this.far3_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.far3_txt.DisplayMember = "stock_name";
            this.far3_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.far3_txt.FormattingEnabled = true;
            this.far3_txt.Location = new System.Drawing.Point(662, 8);
            this.far3_txt.Name = "far3_txt";
            this.far3_txt.Size = new System.Drawing.Size(180, 22);
            this.far3_txt.TabIndex = 123260;
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(848, 12);
            this.label22.Name = "label22";
            this.label22.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label22.Size = new System.Drawing.Size(36, 14);
            this.label22.TabIndex = 123261;
            this.label22.Text = "الفرع";
            // 
            // saydaly_nesba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 574);
            this.Controls.Add(this.far3_txt);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.egmaly_txt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "saydaly_nesba";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "saydaly_nesba";
            this.Load += new System.EventHandler(this.saydaly_nesba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saydalynesbaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox egmaly_txt;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource saydalynesbaBindingSource;
        private DataSet1TableAdapters.saydaly_nesbaTableAdapter saydaly_nesbaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn saydalydateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saydalynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saydalynesbaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productcountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saydalycostDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer timer1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalReport1 CrystalReport11;
        private DataSet1TableAdapters.sales_tableTableAdapter sales_tableTableAdapter1;
        public System.Windows.Forms.TextBox name_txt;
        public System.Windows.Forms.ComboBox far3_txt;
        public System.Windows.Forms.Label label22;
    }
}