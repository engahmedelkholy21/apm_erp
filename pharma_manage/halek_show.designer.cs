namespace pharma_manage
{
    partial class halek_show
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.stock_txt = new System.Windows.Forms.Label();
            this.halektableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new pharma_manage.DataSet1();
            this.halek_tableTableAdapter = new pharma_manage.DataSet1TableAdapters.halek_tableTableAdapter();
            this.halekidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.halekmaterialdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.halekmaterialidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.halekmaterialnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.halekmaterialcountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.halekmaterialnotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.halekmaterialuserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.halek_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.halektableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.halekidDataGridViewTextBoxColumn,
            this.halekmaterialdateDataGridViewTextBoxColumn,
            this.halekmaterialidDataGridViewTextBoxColumn,
            this.halekmaterialnameDataGridViewTextBoxColumn,
            this.halekmaterialcountDataGridViewTextBoxColumn,
            this.halekmaterialnotesDataGridViewTextBoxColumn,
            this.halekmaterialuserDataGridViewTextBoxColumn,
            this.halek_stock});
            this.dataGridView1.DataSource = this.halektableBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(27, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(959, 451);
            this.dataGridView1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Location = new System.Drawing.Point(332, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(149, 22);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2020, 12, 18, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(487, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "من";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(298, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "الى";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(137, 12);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(155, 22);
            this.dateTimePicker2.TabIndex = 2;
            this.dateTimePicker2.Value = new System.DateTime(2020, 12, 18, 0, 0, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // name_txt
            // 
            this.name_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.name_txt.Location = new System.Drawing.Point(556, 12);
            this.name_txt.Name = "name_txt";
            this.name_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_txt.Size = new System.Drawing.Size(296, 22);
            this.name_txt.TabIndex = 0;
            this.name_txt.TextChanged += new System.EventHandler(this.name_txt_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(856, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 14);
            this.label3.TabIndex = 16;
            this.label3.Text = "اسم الصنف";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(311, 503);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(332, 22);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(647, 506);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 14);
            this.label4.TabIndex = 18;
            this.label4.Text = "المجموع";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // stock_txt
            // 
            this.stock_txt.AutoSize = true;
            this.stock_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.stock_txt.Location = new System.Drawing.Point(47, 15);
            this.stock_txt.Name = "stock_txt";
            this.stock_txt.Size = new System.Drawing.Size(67, 14);
            this.stock_txt.TabIndex = 25;
            this.stock_txt.Text = "stock_txt";
            this.stock_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // halektableBindingSource
            // 
            this.halektableBindingSource.DataMember = "halek_table";
            this.halektableBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // halek_tableTableAdapter
            // 
            this.halek_tableTableAdapter.ClearBeforeFill = true;
            // 
            // halekidDataGridViewTextBoxColumn
            // 
            this.halekidDataGridViewTextBoxColumn.DataPropertyName = "halek_id";
            this.halekidDataGridViewTextBoxColumn.HeaderText = "م";
            this.halekidDataGridViewTextBoxColumn.Name = "halekidDataGridViewTextBoxColumn";
            this.halekidDataGridViewTextBoxColumn.ReadOnly = true;
            this.halekidDataGridViewTextBoxColumn.Width = 70;
            // 
            // halekmaterialdateDataGridViewTextBoxColumn
            // 
            this.halekmaterialdateDataGridViewTextBoxColumn.DataPropertyName = "halek_material_date";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.halekmaterialdateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.halekmaterialdateDataGridViewTextBoxColumn.HeaderText = "التاريخ";
            this.halekmaterialdateDataGridViewTextBoxColumn.Name = "halekmaterialdateDataGridViewTextBoxColumn";
            this.halekmaterialdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.halekmaterialdateDataGridViewTextBoxColumn.Width = 90;
            // 
            // halekmaterialidDataGridViewTextBoxColumn
            // 
            this.halekmaterialidDataGridViewTextBoxColumn.DataPropertyName = "halek_material_id";
            this.halekmaterialidDataGridViewTextBoxColumn.HeaderText = "كود الصنف";
            this.halekmaterialidDataGridViewTextBoxColumn.Name = "halekmaterialidDataGridViewTextBoxColumn";
            this.halekmaterialidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // halekmaterialnameDataGridViewTextBoxColumn
            // 
            this.halekmaterialnameDataGridViewTextBoxColumn.DataPropertyName = "halek_material_name";
            this.halekmaterialnameDataGridViewTextBoxColumn.HeaderText = "اسم الصنف";
            this.halekmaterialnameDataGridViewTextBoxColumn.Name = "halekmaterialnameDataGridViewTextBoxColumn";
            this.halekmaterialnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.halekmaterialnameDataGridViewTextBoxColumn.Width = 200;
            // 
            // halekmaterialcountDataGridViewTextBoxColumn
            // 
            this.halekmaterialcountDataGridViewTextBoxColumn.DataPropertyName = "halek_material_count";
            this.halekmaterialcountDataGridViewTextBoxColumn.HeaderText = "كمية الهالك";
            this.halekmaterialcountDataGridViewTextBoxColumn.Name = "halekmaterialcountDataGridViewTextBoxColumn";
            this.halekmaterialcountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // halekmaterialnotesDataGridViewTextBoxColumn
            // 
            this.halekmaterialnotesDataGridViewTextBoxColumn.DataPropertyName = "halek_material_notes";
            this.halekmaterialnotesDataGridViewTextBoxColumn.HeaderText = "ملاحظات";
            this.halekmaterialnotesDataGridViewTextBoxColumn.Name = "halekmaterialnotesDataGridViewTextBoxColumn";
            this.halekmaterialnotesDataGridViewTextBoxColumn.ReadOnly = true;
            this.halekmaterialnotesDataGridViewTextBoxColumn.Width = 150;
            // 
            // halekmaterialuserDataGridViewTextBoxColumn
            // 
            this.halekmaterialuserDataGridViewTextBoxColumn.DataPropertyName = "halek_material_user";
            this.halekmaterialuserDataGridViewTextBoxColumn.HeaderText = "المستخدم";
            this.halekmaterialuserDataGridViewTextBoxColumn.Name = "halekmaterialuserDataGridViewTextBoxColumn";
            this.halekmaterialuserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // halek_stock
            // 
            this.halek_stock.DataPropertyName = "halek_stock";
            this.halek_stock.HeaderText = "الفرع";
            this.halek_stock.Name = "halek_stock";
            this.halek_stock.ReadOnly = true;
            // 
            // halek_show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 530);
            this.Controls.Add(this.stock_txt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "halek_show";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "halek_show";
            this.Load += new System.EventHandler(this.halek_show_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.halektableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource halektableBindingSource;
        private DataSet1TableAdapters.halek_tableTableAdapter halek_tableTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label stock_txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn halekidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn halekmaterialdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn halekmaterialidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn halekmaterialnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn halekmaterialcountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn halekmaterialnotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn halekmaterialuserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn halek_stock;
    }
}