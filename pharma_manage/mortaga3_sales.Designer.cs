namespace pharma_manage
{
    partial class mortaga3_sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mortaga3_sales));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateGroup = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataSet1 = new pharma_manage.DataSet1();
            this.salesmortaga3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sales_mortaga3TableAdapter = new pharma_manage.DataSet1TableAdapters.sales_mortaga3TableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mortaga3salesidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mortaga3salesfatoraIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mortaga3salescstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mortaga3salesdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mortaga3salesproductIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mortaga3salesproductnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mortaga3salescountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mortaga3salesunitpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mortaga3salespriceforsellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mortaga3salesuserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mortaga3_sales_notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pharmacy_dataTableAdapter1 = new pharma_manage.DataSet1TableAdapters.pharmacy_dataTableAdapter();
            this.madeen_small_reportTableAdapter1 = new pharma_manage.DataSet1TableAdapters.madeen_small_reportTableAdapter();
            this.mortaga3_crystal1 = new pharma_manage.mortaga3_crystal();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.dateGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesmortaga3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 108;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dateGroup
            // 
            this.dateGroup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateGroup.Controls.Add(this.label4);
            this.dateGroup.Controls.Add(this.label3);
            this.dateGroup.Controls.Add(this.dateTimePicker2);
            this.dateGroup.Controls.Add(this.dateTimePicker1);
            this.dateGroup.Location = new System.Drawing.Point(181, 7);
            this.dateGroup.Name = "dateGroup";
            this.dateGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateGroup.Size = new System.Drawing.Size(550, 52);
            this.dateGroup.TabIndex = 107;
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
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesmortaga3BindingSource
            // 
            this.salesmortaga3BindingSource.DataMember = "sales_mortaga3";
            this.salesmortaga3BindingSource.DataSource = this.dataSet1;
            // 
            // sales_mortaga3TableAdapter
            // 
            this.sales_mortaga3TableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mortaga3salesidDataGridViewTextBoxColumn,
            this.mortaga3salesfatoraIDDataGridViewTextBoxColumn,
            this.mortaga3salescstnameDataGridViewTextBoxColumn,
            this.mortaga3salesdateDataGridViewTextBoxColumn,
            this.mortaga3salesproductIDDataGridViewTextBoxColumn,
            this.mortaga3salesproductnameDataGridViewTextBoxColumn,
            this.mortaga3salescountDataGridViewTextBoxColumn,
            this.mortaga3salesunitpriceDataGridViewTextBoxColumn,
            this.mortaga3salespriceforsellDataGridViewTextBoxColumn,
            this.mortaga3salesuserDataGridViewTextBoxColumn,
            this.mortaga3_sales_notes});
            this.dataGridView1.DataSource = this.salesmortaga3BindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Location = new System.Drawing.Point(12, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(1179, 400);
            this.dataGridView1.TabIndex = 109;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // mortaga3salesidDataGridViewTextBoxColumn
            // 
            this.mortaga3salesidDataGridViewTextBoxColumn.DataPropertyName = "mortaga3_sales_id";
            this.mortaga3salesidDataGridViewTextBoxColumn.HeaderText = "م";
            this.mortaga3salesidDataGridViewTextBoxColumn.Name = "mortaga3salesidDataGridViewTextBoxColumn";
            this.mortaga3salesidDataGridViewTextBoxColumn.ReadOnly = true;
            this.mortaga3salesidDataGridViewTextBoxColumn.Width = 80;
            // 
            // mortaga3salesfatoraIDDataGridViewTextBoxColumn
            // 
            this.mortaga3salesfatoraIDDataGridViewTextBoxColumn.DataPropertyName = "mortaga3_sales_fatora_ID";
            this.mortaga3salesfatoraIDDataGridViewTextBoxColumn.HeaderText = "رقم الفاتورة";
            this.mortaga3salesfatoraIDDataGridViewTextBoxColumn.Name = "mortaga3salesfatoraIDDataGridViewTextBoxColumn";
            this.mortaga3salesfatoraIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.mortaga3salesfatoraIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // mortaga3salescstnameDataGridViewTextBoxColumn
            // 
            this.mortaga3salescstnameDataGridViewTextBoxColumn.DataPropertyName = "mortaga3_sales_cst_name";
            this.mortaga3salescstnameDataGridViewTextBoxColumn.HeaderText = "اسم العميل";
            this.mortaga3salescstnameDataGridViewTextBoxColumn.Name = "mortaga3salescstnameDataGridViewTextBoxColumn";
            this.mortaga3salescstnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.mortaga3salescstnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // mortaga3salesdateDataGridViewTextBoxColumn
            // 
            this.mortaga3salesdateDataGridViewTextBoxColumn.DataPropertyName = "mortaga3_sales_date";
            this.mortaga3salesdateDataGridViewTextBoxColumn.HeaderText = "التاريخ";
            this.mortaga3salesdateDataGridViewTextBoxColumn.Name = "mortaga3salesdateDataGridViewTextBoxColumn";
            this.mortaga3salesdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.mortaga3salesdateDataGridViewTextBoxColumn.Width = 80;
            // 
            // mortaga3salesproductIDDataGridViewTextBoxColumn
            // 
            this.mortaga3salesproductIDDataGridViewTextBoxColumn.DataPropertyName = "mortaga3_sales_productID";
            this.mortaga3salesproductIDDataGridViewTextBoxColumn.HeaderText = "كود المنتج";
            this.mortaga3salesproductIDDataGridViewTextBoxColumn.Name = "mortaga3salesproductIDDataGridViewTextBoxColumn";
            this.mortaga3salesproductIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.mortaga3salesproductIDDataGridViewTextBoxColumn.Width = 70;
            // 
            // mortaga3salesproductnameDataGridViewTextBoxColumn
            // 
            this.mortaga3salesproductnameDataGridViewTextBoxColumn.DataPropertyName = "mortaga3_sales_product_name";
            this.mortaga3salesproductnameDataGridViewTextBoxColumn.HeaderText = "اسم المنتج";
            this.mortaga3salesproductnameDataGridViewTextBoxColumn.Name = "mortaga3salesproductnameDataGridViewTextBoxColumn";
            this.mortaga3salesproductnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.mortaga3salesproductnameDataGridViewTextBoxColumn.Width = 170;
            // 
            // mortaga3salescountDataGridViewTextBoxColumn
            // 
            this.mortaga3salescountDataGridViewTextBoxColumn.DataPropertyName = "mortaga3_sales_count";
            this.mortaga3salescountDataGridViewTextBoxColumn.HeaderText = "عدد الوحدات";
            this.mortaga3salescountDataGridViewTextBoxColumn.Name = "mortaga3salescountDataGridViewTextBoxColumn";
            this.mortaga3salescountDataGridViewTextBoxColumn.ReadOnly = true;
            this.mortaga3salescountDataGridViewTextBoxColumn.Width = 90;
            // 
            // mortaga3salesunitpriceDataGridViewTextBoxColumn
            // 
            this.mortaga3salesunitpriceDataGridViewTextBoxColumn.DataPropertyName = "mortaga3_sales_unit_price";
            this.mortaga3salesunitpriceDataGridViewTextBoxColumn.HeaderText = "سعر الوحدة";
            this.mortaga3salesunitpriceDataGridViewTextBoxColumn.Name = "mortaga3salesunitpriceDataGridViewTextBoxColumn";
            this.mortaga3salesunitpriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.mortaga3salesunitpriceDataGridViewTextBoxColumn.Width = 90;
            // 
            // mortaga3salespriceforsellDataGridViewTextBoxColumn
            // 
            this.mortaga3salespriceforsellDataGridViewTextBoxColumn.DataPropertyName = "mortaga3_sales_price_for_sell";
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.mortaga3salespriceforsellDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.mortaga3salespriceforsellDataGridViewTextBoxColumn.HeaderText = "السعر";
            this.mortaga3salespriceforsellDataGridViewTextBoxColumn.Name = "mortaga3salespriceforsellDataGridViewTextBoxColumn";
            this.mortaga3salespriceforsellDataGridViewTextBoxColumn.ReadOnly = true;
            this.mortaga3salespriceforsellDataGridViewTextBoxColumn.Width = 90;
            // 
            // mortaga3salesuserDataGridViewTextBoxColumn
            // 
            this.mortaga3salesuserDataGridViewTextBoxColumn.DataPropertyName = "mortaga3_sales_user";
            this.mortaga3salesuserDataGridViewTextBoxColumn.HeaderText = "الموظف";
            this.mortaga3salesuserDataGridViewTextBoxColumn.Name = "mortaga3salesuserDataGridViewTextBoxColumn";
            this.mortaga3salesuserDataGridViewTextBoxColumn.ReadOnly = true;
            this.mortaga3salesuserDataGridViewTextBoxColumn.Width = 80;
            // 
            // mortaga3_sales_notes
            // 
            this.mortaga3_sales_notes.DataPropertyName = "mortaga3_sales_notes";
            this.mortaga3_sales_notes.HeaderText = "ملاحظات";
            this.mortaga3_sales_notes.Name = "mortaga3_sales_notes";
            this.mortaga3_sales_notes.ReadOnly = true;
            this.mortaga3_sales_notes.Width = 150;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(152, 471);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(304, 22);
            this.textBox1.TabIndex = 111;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(462, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 14);
            this.label6.TabIndex = 110;
            this.label6.Text = "الإجمالي";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(658, 472);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox2.Size = new System.Drawing.Size(304, 22);
            this.textBox2.TabIndex = 113;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(968, 476);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 14);
            this.label1.TabIndex = 112;
            this.label1.Text = "العدد";
            // 
            // pharmacy_dataTableAdapter1
            // 
            this.pharmacy_dataTableAdapter1.ClearBeforeFill = true;
            // 
            // madeen_small_reportTableAdapter1
            // 
            this.madeen_small_reportTableAdapter1.ClearBeforeFill = true;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.textBox3.Location = new System.Drawing.Point(835, 24);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 22);
            this.textBox3.TabIndex = 114;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(957, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 14);
            this.label2.TabIndex = 94;
            this.label2.Text = "رقم المرتجع";
            // 
            // mortaga3_sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 496);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateGroup);
            this.Name = "mortaga3_sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mortaga3_sales";
            this.Load += new System.EventHandler(this.mortaga3_sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.dateGroup.ResumeLayout(false);
            this.dateGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesmortaga3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox dateGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource salesmortaga3BindingSource;
        private DataSet1TableAdapters.sales_mortaga3TableAdapter sales_mortaga3TableAdapter;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mortaga3salesidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mortaga3salesfatoraIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mortaga3salescstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mortaga3salesdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mortaga3salesproductIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mortaga3salesproductnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mortaga3salescountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mortaga3salesunitpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mortaga3salespriceforsellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mortaga3salesuserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mortaga3_sales_notes;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private DataSet1TableAdapters.pharmacy_dataTableAdapter pharmacy_dataTableAdapter1;
        private DataSet1TableAdapters.madeen_small_reportTableAdapter madeen_small_reportTableAdapter1;
        private mortaga3_crystal mortaga3_crystal1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;

    }
}