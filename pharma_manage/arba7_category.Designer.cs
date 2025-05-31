namespace pharma_manage
{
    partial class arba7_category
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.arba7catidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arba7catdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arba7catdetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arba7catcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arba7catcategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arba7catfatoraidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arba7catsrcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arba7cattableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new pharma_manage.DataSet1();
            this.label4 = new System.Windows.Forms.Label();
            this.arba7_cat_tableTableAdapter = new pharma_manage.DataSet1TableAdapters.arba7_cat_tableTableAdapter();
            this.category_txt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.pharmacy_dataTableAdapter1 = new pharma_manage.DataSet1TableAdapters.pharmacy_dataTableAdapter();
            this.arba7_cat_report1 = new pharma_manage.arba7_cat_report();
            this.far3_txt = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.stock_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.stock_tableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arba7cattableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(503, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 14);
            this.label3.TabIndex = 93;
            this.label3.Text = "من";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(100, 12);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(167, 22);
            this.dateTimePicker2.TabIndex = 2;
            this.dateTimePicker2.Value = new System.DateTime(2015, 9, 21, 0, 0, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(326, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(171, 22);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2015, 9, 21, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.arba7catidDataGridViewTextBoxColumn,
            this.arba7catdateDataGridViewTextBoxColumn,
            this.arba7catdetailsDataGridViewTextBoxColumn,
            this.arba7catcostDataGridViewTextBoxColumn,
            this.arba7catcategoryDataGridViewTextBoxColumn,
            this.arba7catfatoraidDataGridViewTextBoxColumn,
            this.arba7catsrcDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.arba7cattableBindingSource;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridView1.Location = new System.Drawing.Point(100, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridView1.Size = new System.Drawing.Size(951, 401);
            this.dataGridView1.TabIndex = 90;
            // 
            // arba7catidDataGridViewTextBoxColumn
            // 
            this.arba7catidDataGridViewTextBoxColumn.DataPropertyName = "arba7_cat_id";
            this.arba7catidDataGridViewTextBoxColumn.HeaderText = "م";
            this.arba7catidDataGridViewTextBoxColumn.Name = "arba7catidDataGridViewTextBoxColumn";
            this.arba7catidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // arba7catdateDataGridViewTextBoxColumn
            // 
            this.arba7catdateDataGridViewTextBoxColumn.DataPropertyName = "arba7_cat_date";
            dataGridViewCellStyle18.Format = "d";
            this.arba7catdateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle18;
            this.arba7catdateDataGridViewTextBoxColumn.HeaderText = "التاريخ";
            this.arba7catdateDataGridViewTextBoxColumn.Name = "arba7catdateDataGridViewTextBoxColumn";
            this.arba7catdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // arba7catdetailsDataGridViewTextBoxColumn
            // 
            this.arba7catdetailsDataGridViewTextBoxColumn.DataPropertyName = "arba7_cat_details";
            this.arba7catdetailsDataGridViewTextBoxColumn.HeaderText = "التفاصيل";
            this.arba7catdetailsDataGridViewTextBoxColumn.Name = "arba7catdetailsDataGridViewTextBoxColumn";
            this.arba7catdetailsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // arba7catcostDataGridViewTextBoxColumn
            // 
            this.arba7catcostDataGridViewTextBoxColumn.DataPropertyName = "arba7_cat_cost";
            this.arba7catcostDataGridViewTextBoxColumn.HeaderText = "القيمة";
            this.arba7catcostDataGridViewTextBoxColumn.Name = "arba7catcostDataGridViewTextBoxColumn";
            this.arba7catcostDataGridViewTextBoxColumn.ReadOnly = true;
            this.arba7catcostDataGridViewTextBoxColumn.Width = 150;
            // 
            // arba7catcategoryDataGridViewTextBoxColumn
            // 
            this.arba7catcategoryDataGridViewTextBoxColumn.DataPropertyName = "arba7_cat_category";
            this.arba7catcategoryDataGridViewTextBoxColumn.HeaderText = "الفئة";
            this.arba7catcategoryDataGridViewTextBoxColumn.Name = "arba7catcategoryDataGridViewTextBoxColumn";
            this.arba7catcategoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.arba7catcategoryDataGridViewTextBoxColumn.Width = 150;
            // 
            // arba7catfatoraidDataGridViewTextBoxColumn
            // 
            this.arba7catfatoraidDataGridViewTextBoxColumn.DataPropertyName = "arba7_cat_fatora_id";
            this.arba7catfatoraidDataGridViewTextBoxColumn.HeaderText = "رقم الفاتورة";
            this.arba7catfatoraidDataGridViewTextBoxColumn.Name = "arba7catfatoraidDataGridViewTextBoxColumn";
            this.arba7catfatoraidDataGridViewTextBoxColumn.ReadOnly = true;
            this.arba7catfatoraidDataGridViewTextBoxColumn.Width = 150;
            // 
            // arba7catsrcDataGridViewTextBoxColumn
            // 
            this.arba7catsrcDataGridViewTextBoxColumn.DataPropertyName = "arba7_cat_src";
            this.arba7catsrcDataGridViewTextBoxColumn.HeaderText = "المصدر";
            this.arba7catsrcDataGridViewTextBoxColumn.Name = "arba7catsrcDataGridViewTextBoxColumn";
            this.arba7catsrcDataGridViewTextBoxColumn.ReadOnly = true;
            this.arba7catsrcDataGridViewTextBoxColumn.Width = 150;
            // 
            // arba7cattableBindingSource
            // 
            this.arba7cattableBindingSource.DataMember = "arba7_cat_table";
            this.arba7cattableBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(274, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 14);
            this.label4.TabIndex = 94;
            this.label4.Text = "إلــــى";
            // 
            // arba7_cat_tableTableAdapter
            // 
            this.arba7_cat_tableTableAdapter.ClearBeforeFill = true;
            // 
            // category_txt
            // 
            this.category_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.category_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.category_txt.FormattingEnabled = true;
            this.category_txt.Location = new System.Drawing.Point(533, 13);
            this.category_txt.Name = "category_txt";
            this.category_txt.Size = new System.Drawing.Size(242, 22);
            this.category_txt.TabIndex = 0;
            this.category_txt.SelectedIndexChanged += new System.EventHandler(this.category_txt_SelectedIndexChanged);
            this.category_txt.TextChanged += new System.EventHandler(this.category_txt_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(778, 17);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(69, 14);
            this.label1.TabIndex = 131;
            this.label1.Text = "فئة الصنف";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(636, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 14);
            this.label2.TabIndex = 132;
            this.label2.Text = "الإجمالي";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(457, 452);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(173, 22);
            this.textBox1.TabIndex = 133;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(12, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 134;
            this.button1.Text = "طباعة";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pharmacy_dataTableAdapter1
            // 
            this.pharmacy_dataTableAdapter1.ClearBeforeFill = true;
            // 
            // far3_txt
            // 
            this.far3_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.far3_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.far3_txt.FormattingEnabled = true;
            this.far3_txt.Location = new System.Drawing.Point(856, 12);
            this.far3_txt.Name = "far3_txt";
            this.far3_txt.Size = new System.Drawing.Size(180, 22);
            this.far3_txt.TabIndex = 123256;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1042, 16);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(36, 14);
            this.label11.TabIndex = 123257;
            this.label11.Text = "الفرع";
            // 
            // stock_tableTableAdapter1
            // 
            this.stock_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // arba7_category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 478);
            this.Controls.Add(this.far3_txt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.category_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Name = "arba7_category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "الارباح بالفئة";
            this.Load += new System.EventHandler(this.arba7_category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arba7cattableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource arba7cattableBindingSource;
        private DataSet1TableAdapters.arba7_cat_tableTableAdapter arba7_cat_tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn arba7catidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arba7catdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arba7catdetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arba7catcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arba7catcategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arba7catfatoraidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arba7catsrcDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox category_txt;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private arba7_cat_report arba7_cat_report1;
        private System.Windows.Forms.Button button1;
        private DataSet1TableAdapters.pharmacy_dataTableAdapter pharmacy_dataTableAdapter1;
        public System.Windows.Forms.ComboBox far3_txt;
        public System.Windows.Forms.Label label11;
        private DataSet1TableAdapters.stock_tableTableAdapter stock_tableTableAdapter1;
    }
}