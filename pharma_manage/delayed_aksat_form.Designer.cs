namespace pharma_manage
{
    partial class delayed_aksat_form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kestnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kest_modat_eltamweel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kestcstcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kestcstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kestamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kestest7kakdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kest_pay_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kest1stdamennameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keststatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kest_loan_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kest_far3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cst_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cst_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delayedaksatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new pharma_manage.DataSet1();
            this.delayed_aksatTableAdapter = new pharma_manage.DataSet1TableAdapters.delayed_aksatTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.user_txt = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.count_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.far3txt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayedaksatBindingSource)).BeginInit();
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
            this.kestnumberDataGridViewTextBoxColumn,
            this.kest_modat_eltamweel,
            this.kestcstcodeDataGridViewTextBoxColumn,
            this.kestcstnameDataGridViewTextBoxColumn,
            this.kestamountDataGridViewTextBoxColumn,
            this.kestest7kakdateDataGridViewTextBoxColumn,
            this.kest_pay_date,
            this.kest1stdamennameDataGridViewTextBoxColumn,
            this.keststatusDataGridViewTextBoxColumn,
            this.kest_loan_code,
            this.kest_far3,
            this.cst_phone,
            this.cst_address});
            this.dataGridView1.DataSource = this.delayedaksatBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Location = new System.Drawing.Point(8, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1333, 412);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // kestnumberDataGridViewTextBoxColumn
            // 
            this.kestnumberDataGridViewTextBoxColumn.DataPropertyName = "kest_number";
            this.kestnumberDataGridViewTextBoxColumn.HeaderText = "قسط رقم";
            this.kestnumberDataGridViewTextBoxColumn.Name = "kestnumberDataGridViewTextBoxColumn";
            this.kestnumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.kestnumberDataGridViewTextBoxColumn.Width = 70;
            // 
            // kest_modat_eltamweel
            // 
            this.kest_modat_eltamweel.DataPropertyName = "kest_modat_eltamweel";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.kest_modat_eltamweel.DefaultCellStyle = dataGridViewCellStyle3;
            this.kest_modat_eltamweel.HeaderText = "المدة";
            this.kest_modat_eltamweel.Name = "kest_modat_eltamweel";
            this.kest_modat_eltamweel.ReadOnly = true;
            this.kest_modat_eltamweel.Width = 70;
            // 
            // kestcstcodeDataGridViewTextBoxColumn
            // 
            this.kestcstcodeDataGridViewTextBoxColumn.DataPropertyName = "kest_cst_code";
            this.kestcstcodeDataGridViewTextBoxColumn.HeaderText = "كود العميل";
            this.kestcstcodeDataGridViewTextBoxColumn.Name = "kestcstcodeDataGridViewTextBoxColumn";
            this.kestcstcodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.kestcstcodeDataGridViewTextBoxColumn.Width = 90;
            // 
            // kestcstnameDataGridViewTextBoxColumn
            // 
            this.kestcstnameDataGridViewTextBoxColumn.DataPropertyName = "kest_cst_name";
            this.kestcstnameDataGridViewTextBoxColumn.HeaderText = "اسم العميل";
            this.kestcstnameDataGridViewTextBoxColumn.Name = "kestcstnameDataGridViewTextBoxColumn";
            this.kestcstnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.kestcstnameDataGridViewTextBoxColumn.Width = 200;
            // 
            // kestamountDataGridViewTextBoxColumn
            // 
            this.kestamountDataGridViewTextBoxColumn.DataPropertyName = "kest_amount";
            this.kestamountDataGridViewTextBoxColumn.HeaderText = "قيمة القسط";
            this.kestamountDataGridViewTextBoxColumn.Name = "kestamountDataGridViewTextBoxColumn";
            this.kestamountDataGridViewTextBoxColumn.ReadOnly = true;
            this.kestamountDataGridViewTextBoxColumn.Width = 110;
            // 
            // kestest7kakdateDataGridViewTextBoxColumn
            // 
            this.kestest7kakdateDataGridViewTextBoxColumn.DataPropertyName = "kest_est7kak_date";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.kestest7kakdateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.kestest7kakdateDataGridViewTextBoxColumn.HeaderText = "الاستحقاق";
            this.kestest7kakdateDataGridViewTextBoxColumn.Name = "kestest7kakdateDataGridViewTextBoxColumn";
            this.kestest7kakdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.kestest7kakdateDataGridViewTextBoxColumn.Width = 110;
            // 
            // kest_pay_date
            // 
            this.kest_pay_date.DataPropertyName = "kest_pay_date";
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.kest_pay_date.DefaultCellStyle = dataGridViewCellStyle5;
            this.kest_pay_date.HeaderText = "السداد";
            this.kest_pay_date.Name = "kest_pay_date";
            this.kest_pay_date.ReadOnly = true;
            // 
            // kest1stdamennameDataGridViewTextBoxColumn
            // 
            this.kest1stdamennameDataGridViewTextBoxColumn.DataPropertyName = "kest_1st_damen_name";
            this.kest1stdamennameDataGridViewTextBoxColumn.HeaderText = "الضامن";
            this.kest1stdamennameDataGridViewTextBoxColumn.Name = "kest1stdamennameDataGridViewTextBoxColumn";
            this.kest1stdamennameDataGridViewTextBoxColumn.ReadOnly = true;
            this.kest1stdamennameDataGridViewTextBoxColumn.Width = 175;
            // 
            // keststatusDataGridViewTextBoxColumn
            // 
            this.keststatusDataGridViewTextBoxColumn.DataPropertyName = "kest_status";
            this.keststatusDataGridViewTextBoxColumn.HeaderText = "الحالة";
            this.keststatusDataGridViewTextBoxColumn.Name = "keststatusDataGridViewTextBoxColumn";
            this.keststatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.keststatusDataGridViewTextBoxColumn.Width = 90;
            // 
            // kest_loan_code
            // 
            this.kest_loan_code.DataPropertyName = "kest_loan_code";
            this.kest_loan_code.HeaderText = "كود العملية";
            this.kest_loan_code.Name = "kest_loan_code";
            this.kest_loan_code.ReadOnly = true;
            // 
            // kest_far3
            // 
            this.kest_far3.DataPropertyName = "kest_far3";
            this.kest_far3.HeaderText = "الفرع";
            this.kest_far3.Name = "kest_far3";
            this.kest_far3.ReadOnly = true;
            // 
            // cst_phone
            // 
            this.cst_phone.DataPropertyName = "cst_phone";
            this.cst_phone.HeaderText = "رقم التليفون";
            this.cst_phone.Name = "cst_phone";
            this.cst_phone.ReadOnly = true;
            // 
            // cst_address
            // 
            this.cst_address.DataPropertyName = "cst_address";
            this.cst_address.HeaderText = "العنوان";
            this.cst_address.Name = "cst_address";
            this.cst_address.ReadOnly = true;
            this.cst_address.Width = 130;
            // 
            // delayedaksatBindingSource
            // 
            this.delayedaksatBindingSource.DataMember = "delayed_aksat";
            this.delayedaksatBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // delayed_aksatTableAdapter
            // 
            this.delayed_aksatTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(640, 10);
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
            this.label3.Location = new System.Drawing.Point(892, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 14);
            this.label3.TabIndex = 105;
            this.label3.Text = "من";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(433, 6);
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
            this.dateTimePicker1.Location = new System.Drawing.Point(686, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 103;
            this.dateTimePicker1.Value = new System.DateTime(2015, 9, 21, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // user_txt
            // 
            this.user_txt.AutoSize = true;
            this.user_txt.Location = new System.Drawing.Point(34, 73);
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(28, 13);
            this.user_txt.TabIndex = 123291;
            this.user_txt.Text = "user";
            this.user_txt.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox1.BackColor = System.Drawing.Color.Green;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(313, 448);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(244, 22);
            this.textBox1.TabIndex = 123293;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(563, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 14);
            this.label2.TabIndex = 123292;
            this.label2.Text = "اجمالي القيمة";
            // 
            // count_txt
            // 
            this.count_txt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.count_txt.BackColor = System.Drawing.Color.Green;
            this.count_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count_txt.Location = new System.Drawing.Point(703, 448);
            this.count_txt.Name = "count_txt";
            this.count_txt.ReadOnly = true;
            this.count_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.count_txt.Size = new System.Drawing.Size(244, 22);
            this.count_txt.TabIndex = 123295;
            this.count_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(953, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 14);
            this.label1.TabIndex = 123294;
            this.label1.Text = "اجمالي العدد";
            // 
            // far3txt
            // 
            this.far3txt.AutoSize = true;
            this.far3txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.far3txt.Location = new System.Drawing.Point(260, 12);
            this.far3txt.Name = "far3txt";
            this.far3txt.Size = new System.Drawing.Size(32, 14);
            this.far3txt.TabIndex = 123296;
            this.far3txt.Text = "far3";
            this.far3txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.far3txt.Visible = false;
            // 
            // delayed_aksat_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 482);
            this.Controls.Add(this.far3txt);
            this.Controls.Add(this.count_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.user_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "delayed_aksat_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الاقساط المتأخرة";
            this.Load += new System.EventHandler(this.delayed_aksat_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayedaksatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource delayedaksatBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.delayed_aksatTableAdapter delayed_aksatTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Label user_txt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn kestnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kest_modat_eltamweel;
        private System.Windows.Forms.DataGridViewTextBoxColumn kestcstcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kestcstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kestamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kestest7kakdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kest_pay_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn kest1stdamennameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keststatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kest_loan_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn kest_far3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cst_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cst_address;
        private System.Windows.Forms.TextBox count_txt;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label far3txt;
    }
}