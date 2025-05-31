namespace pharma_manage
{
    partial class mas7obat_list
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mas7obat_list));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mas7obattableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new pharma_manage.DataSet1();
            this.mas7obat_tableTableAdapter = new pharma_manage.DataSet1TableAdapters.mas7obat_tableTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.user_txt = new System.Windows.Forms.Label();
            this.total_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pharmacy_dataTableAdapter1 = new pharma_manage.DataSet1TableAdapters.pharmacy_dataTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.mas7obatnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mas7obatdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mas7obatresponsibleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mas7obatmaterialidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mas7obatmaterialnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mas7obatmaterialcountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mas7obat_unit_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mas7obat_price_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mas7obatmaterialcategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mas7obatamrsho3lnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mas7obatuserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mas7obat_list_report1 = new pharma_manage.mas7obat_list_report();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mas7obattableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
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
            this.mas7obatnoDataGridViewTextBoxColumn,
            this.mas7obatdateDataGridViewTextBoxColumn,
            this.mas7obatresponsibleDataGridViewTextBoxColumn,
            this.mas7obatmaterialidDataGridViewTextBoxColumn,
            this.mas7obatmaterialnameDataGridViewTextBoxColumn,
            this.mas7obatmaterialcountDataGridViewTextBoxColumn,
            this.mas7obat_unit_price,
            this.mas7obat_price_total,
            this.mas7obatmaterialcategoryDataGridViewTextBoxColumn,
            this.mas7obatamrsho3lnoDataGridViewTextBoxColumn,
            this.mas7obatuserDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mas7obattableBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(33, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(1279, 370);
            this.dataGridView1.TabIndex = 102;
            // 
            // mas7obattableBindingSource
            // 
            this.mas7obattableBindingSource.DataMember = "mas7obat_table";
            this.mas7obattableBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mas7obat_tableTableAdapter
            // 
            this.mas7obat_tableTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(371, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 14);
            this.label4.TabIndex = 115;
            this.label4.Text = "إلــــى";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(630, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 14);
            this.label3.TabIndex = 114;
            this.label3.Text = "من";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(164, 13);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 113;
            this.dateTimePicker2.Value = new System.DateTime(2015, 9, 21, 0, 0, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(424, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 112;
            this.dateTimePicker1.Value = new System.DateTime(2015, 9, 21, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // name_txt
            // 
            this.name_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.name_txt.Location = new System.Drawing.Point(665, 13);
            this.name_txt.Name = "name_txt";
            this.name_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_txt.Size = new System.Drawing.Size(332, 22);
            this.name_txt.TabIndex = 110;
            this.name_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name_txt.TextChanged += new System.EventHandler(this.name_txt_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1000, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 14);
            this.label1.TabIndex = 111;
            this.label1.Text = "اسم الصنف / رقم امر الشغل ";
            // 
            // user_txt
            // 
            this.user_txt.AutoSize = true;
            this.user_txt.Location = new System.Drawing.Point(12, 29);
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(44, 13);
            this.user_txt.TabIndex = 109;
            this.user_txt.Text = "user_txt";
            this.user_txt.Visible = false;
            // 
            // total_txt
            // 
            this.total_txt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.total_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_txt.Location = new System.Drawing.Point(699, 422);
            this.total_txt.Name = "total_txt";
            this.total_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.total_txt.Size = new System.Drawing.Size(229, 22);
            this.total_txt.TabIndex = 123264;
            this.total_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(932, 426);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(90, 14);
            this.label6.TabIndex = 123265;
            this.label6.Text = "اجمالي الكمية";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pharmacy_dataTableAdapter1
            // 
            this.pharmacy_dataTableAdapter1.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(1286, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 41);
            this.button2.TabIndex = 123281;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mas7obatnoDataGridViewTextBoxColumn
            // 
            this.mas7obatnoDataGridViewTextBoxColumn.DataPropertyName = "mas7obat_no";
            this.mas7obatnoDataGridViewTextBoxColumn.HeaderText = "م";
            this.mas7obatnoDataGridViewTextBoxColumn.Name = "mas7obatnoDataGridViewTextBoxColumn";
            this.mas7obatnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.mas7obatnoDataGridViewTextBoxColumn.Width = 80;
            // 
            // mas7obatdateDataGridViewTextBoxColumn
            // 
            this.mas7obatdateDataGridViewTextBoxColumn.DataPropertyName = "mas7obat_date";
            dataGridViewCellStyle3.Format = "d";
            this.mas7obatdateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.mas7obatdateDataGridViewTextBoxColumn.HeaderText = "التاريخ";
            this.mas7obatdateDataGridViewTextBoxColumn.Name = "mas7obatdateDataGridViewTextBoxColumn";
            this.mas7obatdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.mas7obatdateDataGridViewTextBoxColumn.Width = 85;
            // 
            // mas7obatresponsibleDataGridViewTextBoxColumn
            // 
            this.mas7obatresponsibleDataGridViewTextBoxColumn.DataPropertyName = "mas7obat_responsible";
            this.mas7obatresponsibleDataGridViewTextBoxColumn.HeaderText = "اسم الساحب";
            this.mas7obatresponsibleDataGridViewTextBoxColumn.Name = "mas7obatresponsibleDataGridViewTextBoxColumn";
            this.mas7obatresponsibleDataGridViewTextBoxColumn.ReadOnly = true;
            this.mas7obatresponsibleDataGridViewTextBoxColumn.Width = 200;
            // 
            // mas7obatmaterialidDataGridViewTextBoxColumn
            // 
            this.mas7obatmaterialidDataGridViewTextBoxColumn.DataPropertyName = "mas7obat_material_id";
            this.mas7obatmaterialidDataGridViewTextBoxColumn.HeaderText = "كود الصنف";
            this.mas7obatmaterialidDataGridViewTextBoxColumn.Name = "mas7obatmaterialidDataGridViewTextBoxColumn";
            this.mas7obatmaterialidDataGridViewTextBoxColumn.ReadOnly = true;
            this.mas7obatmaterialidDataGridViewTextBoxColumn.Width = 80;
            // 
            // mas7obatmaterialnameDataGridViewTextBoxColumn
            // 
            this.mas7obatmaterialnameDataGridViewTextBoxColumn.DataPropertyName = "mas7obat_material_name";
            this.mas7obatmaterialnameDataGridViewTextBoxColumn.HeaderText = "اسم الصنف";
            this.mas7obatmaterialnameDataGridViewTextBoxColumn.Name = "mas7obatmaterialnameDataGridViewTextBoxColumn";
            this.mas7obatmaterialnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.mas7obatmaterialnameDataGridViewTextBoxColumn.Width = 200;
            // 
            // mas7obatmaterialcountDataGridViewTextBoxColumn
            // 
            this.mas7obatmaterialcountDataGridViewTextBoxColumn.DataPropertyName = "mas7obat_material_count";
            this.mas7obatmaterialcountDataGridViewTextBoxColumn.HeaderText = "الكمية";
            this.mas7obatmaterialcountDataGridViewTextBoxColumn.Name = "mas7obatmaterialcountDataGridViewTextBoxColumn";
            this.mas7obatmaterialcountDataGridViewTextBoxColumn.ReadOnly = true;
            this.mas7obatmaterialcountDataGridViewTextBoxColumn.Width = 80;
            // 
            // mas7obat_unit_price
            // 
            this.mas7obat_unit_price.DataPropertyName = "mas7obat_unit_price";
            this.mas7obat_unit_price.HeaderText = "سعر الوحدة";
            this.mas7obat_unit_price.Name = "mas7obat_unit_price";
            this.mas7obat_unit_price.ReadOnly = true;
            // 
            // mas7obat_price_total
            // 
            this.mas7obat_price_total.DataPropertyName = "mas7obat_price_total";
            this.mas7obat_price_total.HeaderText = "الاجمالي";
            this.mas7obat_price_total.Name = "mas7obat_price_total";
            this.mas7obat_price_total.ReadOnly = true;
            // 
            // mas7obatmaterialcategoryDataGridViewTextBoxColumn
            // 
            this.mas7obatmaterialcategoryDataGridViewTextBoxColumn.DataPropertyName = "mas7obat_material_category";
            this.mas7obatmaterialcategoryDataGridViewTextBoxColumn.HeaderText = "فئة الصنف";
            this.mas7obatmaterialcategoryDataGridViewTextBoxColumn.Name = "mas7obatmaterialcategoryDataGridViewTextBoxColumn";
            this.mas7obatmaterialcategoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.mas7obatmaterialcategoryDataGridViewTextBoxColumn.Width = 90;
            // 
            // mas7obatamrsho3lnoDataGridViewTextBoxColumn
            // 
            this.mas7obatamrsho3lnoDataGridViewTextBoxColumn.DataPropertyName = "mas7obat_amr_sho3l_no";
            this.mas7obatamrsho3lnoDataGridViewTextBoxColumn.HeaderText = "امر الشغل";
            this.mas7obatamrsho3lnoDataGridViewTextBoxColumn.Name = "mas7obatamrsho3lnoDataGridViewTextBoxColumn";
            this.mas7obatamrsho3lnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mas7obatuserDataGridViewTextBoxColumn
            // 
            this.mas7obatuserDataGridViewTextBoxColumn.DataPropertyName = "mas7obat_user";
            this.mas7obatuserDataGridViewTextBoxColumn.HeaderText = "المستخدم";
            this.mas7obatuserDataGridViewTextBoxColumn.Name = "mas7obatuserDataGridViewTextBoxColumn";
            this.mas7obatuserDataGridViewTextBoxColumn.ReadOnly = true;
            this.mas7obatuserDataGridViewTextBoxColumn.Width = 120;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(323, 422);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(229, 22);
            this.textBox1.TabIndex = 123282;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(556, 426);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(94, 14);
            this.label2.TabIndex = 123283;
            this.label2.Text = "اجمالي التكلفة";
            // 
            // mas7obat_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 454);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.total_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user_txt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "mas7obat_list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mas7obat_list";
            this.Load += new System.EventHandler(this.mas7obat_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mas7obattableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource mas7obattableBindingSource;
        private DataSet1TableAdapters.mas7obat_tableTableAdapter mas7obat_tableTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label user_txt;
        private System.Windows.Forms.TextBox total_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private DataSet1TableAdapters.pharmacy_dataTableAdapter pharmacy_dataTableAdapter1;
        private System.Windows.Forms.Button button2;
        private mas7obat_list_report mas7obat_list_report1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mas7obatnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mas7obatdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mas7obatresponsibleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mas7obatmaterialidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mas7obatmaterialnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mas7obatmaterialcountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mas7obat_unit_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn mas7obat_price_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn mas7obatmaterialcategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mas7obatamrsho3lnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mas7obatuserDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}