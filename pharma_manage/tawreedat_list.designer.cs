namespace pharma_manage
{
    partial class tawreedat_list
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tawreedat_list));
            this.total_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.user_txt = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tawreedatnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tawreedatdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tawreedatresponsibleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tawreedatmaterialidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tawreedatmaterialnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tawreedatmaterialcountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tawreedatamrsho3lnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tawreedatuserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tawreedatstockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tawreedattableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new pharma_manage.DataSet1();
            this.tawreedat_tableTableAdapter = new pharma_manage.DataSet1TableAdapters.tawreedat_tableTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.tawreedat_report1 = new pharma_manage.tawreedat_report();
            this.delete_btn = new System.Windows.Forms.Button();
            this.products_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.products_tableTableAdapter();
            this.dataSet11 = new pharma_manage.DataSet1();
            this.ma5zoon_movesTableAdapter1 = new pharma_manage.DataSet1TableAdapters.ma5zoon_movesTableAdapter();
            this.pharmacy_dataTableAdapter1 = new pharma_manage.DataSet1TableAdapters.pharmacy_dataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tawreedattableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // total_txt
            // 
            this.total_txt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.total_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_txt.Location = new System.Drawing.Point(445, 529);
            this.total_txt.Name = "total_txt";
            this.total_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.total_txt.Size = new System.Drawing.Size(229, 22);
            this.total_txt.TabIndex = 123274;
            this.total_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(678, 533);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(58, 14);
            this.label6.TabIndex = 123275;
            this.label6.Text = "الاجمالي";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(289, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 14);
            this.label4.TabIndex = 123273;
            this.label4.Text = "إلــــى";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(548, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 14);
            this.label3.TabIndex = 123272;
            this.label3.Text = "من";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(82, 20);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 123271;
            this.dateTimePicker2.Value = new System.DateTime(2015, 9, 21, 0, 0, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(342, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 123270;
            this.dateTimePicker1.Value = new System.DateTime(2015, 9, 21, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // name_txt
            // 
            this.name_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.name_txt.Location = new System.Drawing.Point(583, 20);
            this.name_txt.Name = "name_txt";
            this.name_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_txt.Size = new System.Drawing.Size(332, 22);
            this.name_txt.TabIndex = 123268;
            this.name_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name_txt.TextChanged += new System.EventHandler(this.name_txt_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(918, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 14);
            this.label1.TabIndex = 123269;
            this.label1.Text = "اسم الصنف / رقم امر الشغل / رقم الفاتورة";
            // 
            // user_txt
            // 
            this.user_txt.AutoSize = true;
            this.user_txt.Location = new System.Drawing.Point(-3, 74);
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(44, 13);
            this.user_txt.TabIndex = 123267;
            this.user_txt.Text = "user_txt";
            this.user_txt.Visible = false;
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
            this.tawreedatnoDataGridViewTextBoxColumn,
            this.tawreedatdateDataGridViewTextBoxColumn,
            this.tawreedatresponsibleDataGridViewTextBoxColumn,
            this.tawreedatmaterialidDataGridViewTextBoxColumn,
            this.tawreedatmaterialnameDataGridViewTextBoxColumn,
            this.tawreedatmaterialcountDataGridViewTextBoxColumn,
            this.tawreedatamrsho3lnoDataGridViewTextBoxColumn,
            this.tawreedatuserDataGridViewTextBoxColumn,
            this.tawreedatstockDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tawreedattableBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(50, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(1081, 470);
            this.dataGridView1.TabIndex = 123266;
            // 
            // tawreedatnoDataGridViewTextBoxColumn
            // 
            this.tawreedatnoDataGridViewTextBoxColumn.DataPropertyName = "tawreedat_no";
            this.tawreedatnoDataGridViewTextBoxColumn.HeaderText = "رقم الفاتورة";
            this.tawreedatnoDataGridViewTextBoxColumn.Name = "tawreedatnoDataGridViewTextBoxColumn";
            this.tawreedatnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tawreedatnoDataGridViewTextBoxColumn.Width = 95;
            // 
            // tawreedatdateDataGridViewTextBoxColumn
            // 
            this.tawreedatdateDataGridViewTextBoxColumn.DataPropertyName = "tawreedat_date";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.tawreedatdateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.tawreedatdateDataGridViewTextBoxColumn.HeaderText = "التاريخ";
            this.tawreedatdateDataGridViewTextBoxColumn.Name = "tawreedatdateDataGridViewTextBoxColumn";
            this.tawreedatdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.tawreedatdateDataGridViewTextBoxColumn.Width = 85;
            // 
            // tawreedatresponsibleDataGridViewTextBoxColumn
            // 
            this.tawreedatresponsibleDataGridViewTextBoxColumn.DataPropertyName = "tawreedat_responsible";
            this.tawreedatresponsibleDataGridViewTextBoxColumn.HeaderText = "المسئول";
            this.tawreedatresponsibleDataGridViewTextBoxColumn.Name = "tawreedatresponsibleDataGridViewTextBoxColumn";
            this.tawreedatresponsibleDataGridViewTextBoxColumn.ReadOnly = true;
            this.tawreedatresponsibleDataGridViewTextBoxColumn.Width = 150;
            // 
            // tawreedatmaterialidDataGridViewTextBoxColumn
            // 
            this.tawreedatmaterialidDataGridViewTextBoxColumn.DataPropertyName = "tawreedat_material_id";
            this.tawreedatmaterialidDataGridViewTextBoxColumn.HeaderText = "كود الصنف";
            this.tawreedatmaterialidDataGridViewTextBoxColumn.Name = "tawreedatmaterialidDataGridViewTextBoxColumn";
            this.tawreedatmaterialidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tawreedatmaterialnameDataGridViewTextBoxColumn
            // 
            this.tawreedatmaterialnameDataGridViewTextBoxColumn.DataPropertyName = "tawreedat_material_name";
            this.tawreedatmaterialnameDataGridViewTextBoxColumn.HeaderText = "اسم الصنف";
            this.tawreedatmaterialnameDataGridViewTextBoxColumn.Name = "tawreedatmaterialnameDataGridViewTextBoxColumn";
            this.tawreedatmaterialnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.tawreedatmaterialnameDataGridViewTextBoxColumn.Width = 200;
            // 
            // tawreedatmaterialcountDataGridViewTextBoxColumn
            // 
            this.tawreedatmaterialcountDataGridViewTextBoxColumn.DataPropertyName = "tawreedat_material_count";
            this.tawreedatmaterialcountDataGridViewTextBoxColumn.HeaderText = "الكمية";
            this.tawreedatmaterialcountDataGridViewTextBoxColumn.Name = "tawreedatmaterialcountDataGridViewTextBoxColumn";
            this.tawreedatmaterialcountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tawreedatamrsho3lnoDataGridViewTextBoxColumn
            // 
            this.tawreedatamrsho3lnoDataGridViewTextBoxColumn.DataPropertyName = "tawreedat_amr_sho3l_no";
            this.tawreedatamrsho3lnoDataGridViewTextBoxColumn.HeaderText = "امر الشغل";
            this.tawreedatamrsho3lnoDataGridViewTextBoxColumn.Name = "tawreedatamrsho3lnoDataGridViewTextBoxColumn";
            this.tawreedatamrsho3lnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tawreedatuserDataGridViewTextBoxColumn
            // 
            this.tawreedatuserDataGridViewTextBoxColumn.DataPropertyName = "tawreedat_user";
            this.tawreedatuserDataGridViewTextBoxColumn.HeaderText = "المستخدم";
            this.tawreedatuserDataGridViewTextBoxColumn.Name = "tawreedatuserDataGridViewTextBoxColumn";
            this.tawreedatuserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tawreedatstockDataGridViewTextBoxColumn
            // 
            this.tawreedatstockDataGridViewTextBoxColumn.DataPropertyName = "tawreedat_stock";
            this.tawreedatstockDataGridViewTextBoxColumn.HeaderText = "العهدة";
            this.tawreedatstockDataGridViewTextBoxColumn.Name = "tawreedatstockDataGridViewTextBoxColumn";
            this.tawreedatstockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tawreedattableBindingSource
            // 
            this.tawreedattableBindingSource.DataMember = "tawreedat_table";
            this.tawreedattableBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tawreedat_tableTableAdapter
            // 
            this.tawreedat_tableTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(1133, 519);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 41);
            this.button2.TabIndex = 123281;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.Red;
            this.delete_btn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.delete_btn.Location = new System.Drawing.Point(12, 525);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(96, 34);
            this.delete_btn.TabIndex = 123282;
            this.delete_btn.Text = "حذف الفاتورة";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Visible = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // products_tableTableAdapter1
            // 
            this.products_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ma5zoon_movesTableAdapter1
            // 
            this.ma5zoon_movesTableAdapter1.ClearBeforeFill = true;
            // 
            // pharmacy_dataTableAdapter1
            // 
            this.pharmacy_dataTableAdapter1.ClearBeforeFill = true;
            // 
            // tawreedat_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 563);
            this.Controls.Add(this.delete_btn);
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
            this.Name = "tawreedat_list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tawreedat_list";
            this.Load += new System.EventHandler(this.tawreedat_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tawreedattableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox total_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label user_txt;
        public System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tawreedattableBindingSource;
        private DataSet1TableAdapters.tawreedat_tableTableAdapter tawreedat_tableTableAdapter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tawreedatnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tawreedatdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tawreedatresponsibleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tawreedatmaterialidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tawreedatmaterialnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tawreedatmaterialcountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tawreedatamrsho3lnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tawreedatuserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tawreedatstockDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        
        private tawreedat_report tawreedat_report1;
        private System.Windows.Forms.Button delete_btn;
        private DataSet1TableAdapters.products_tableTableAdapter products_tableTableAdapter1;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.ma5zoon_movesTableAdapter ma5zoon_movesTableAdapter1;
        private DataSet1TableAdapters.pharmacy_dataTableAdapter pharmacy_dataTableAdapter1;
    }
}