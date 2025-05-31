namespace pharma_manage
{
    partial class aksat_summary_form
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
            this.far3txt = new System.Windows.Forms.Label();
            this.user_txt = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aksatsummaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new pharma_manage.DataSet1();
            this.aksat_summaryTableAdapter = new pharma_manage.DataSet1TableAdapters.aksat_summaryTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.substringAutoCompleteTextBox1 = new pharma_manage.SubstringAutoCompleteTextBox();
            this.total_paid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.total_not_paid_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kestloancodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kestcstcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kestcstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kest1stdamencodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalloanamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_paid_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_paid_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kestfar3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kestmodateltamweelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countpaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalpaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countnotpaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalnotpaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aksatsummaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // far3txt
            // 
            this.far3txt.AutoSize = true;
            this.far3txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.far3txt.Location = new System.Drawing.Point(32, 9);
            this.far3txt.Name = "far3txt";
            this.far3txt.Size = new System.Drawing.Size(32, 14);
            this.far3txt.TabIndex = 123298;
            this.far3txt.Text = "far3";
            this.far3txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.far3txt.Visible = false;
            // 
            // user_txt
            // 
            this.user_txt.AutoSize = true;
            this.user_txt.Location = new System.Drawing.Point(70, 10);
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(28, 13);
            this.user_txt.TabIndex = 123297;
            this.user_txt.Text = "user";
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
            this.kestloancodeDataGridViewTextBoxColumn,
            this.kestcstcodeDataGridViewTextBoxColumn,
            this.kestcstnameDataGridViewTextBoxColumn,
            this.kest1stdamencodeDataGridViewTextBoxColumn,
            this.totalloanamountDataGridViewTextBoxColumn,
            this.first_paid_date,
            this.last_paid_date,
            this.kestfar3DataGridViewTextBoxColumn,
            this.kestmodateltamweelDataGridViewTextBoxColumn,
            this.countpaidDataGridViewTextBoxColumn,
            this.totalpaidDataGridViewTextBoxColumn,
            this.countnotpaidDataGridViewTextBoxColumn,
            this.totalnotpaidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aksatsummaryBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(20, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1302, 408);
            this.dataGridView1.TabIndex = 123299;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // aksatsummaryBindingSource
            // 
            this.aksatsummaryBindingSource.DataMember = "aksat_summary";
            this.aksatsummaryBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aksat_summaryTableAdapter
            // 
            this.aksat_summaryTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(552, 1);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(238, 14);
            this.label2.TabIndex = 123301;
            this.label2.Text = "كود التسقيط - كود العميل - اسم العميل";
            // 
            // substringAutoCompleteTextBox1
            // 
            this.substringAutoCompleteTextBox1.AcceptButton = null;
            this.substringAutoCompleteTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.substringAutoCompleteTextBox1.BackColor = System.Drawing.Color.Silver;
            this.substringAutoCompleteTextBox1.Location = new System.Drawing.Point(498, 18);
            this.substringAutoCompleteTextBox1.Name = "substringAutoCompleteTextBox1";
            this.substringAutoCompleteTextBox1.next_textbox = null;
            this.substringAutoCompleteTextBox1.Size = new System.Drawing.Size(347, 22);
            this.substringAutoCompleteTextBox1.TabIndex = 123302;
            // 
            // total_paid
            // 
            this.total_paid.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.total_paid.BackColor = System.Drawing.Color.Green;
            this.total_paid.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_paid.Location = new System.Drawing.Point(711, 458);
            this.total_paid.Name = "total_paid";
            this.total_paid.ReadOnly = true;
            this.total_paid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.total_paid.Size = new System.Drawing.Size(244, 22);
            this.total_paid.TabIndex = 123306;
            this.total_paid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(961, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 14);
            this.label1.TabIndex = 123305;
            this.label1.Text = "اجمالي المسدد";
            // 
            // total_not_paid_txt
            // 
            this.total_not_paid_txt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.total_not_paid_txt.BackColor = System.Drawing.Color.Green;
            this.total_not_paid_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_not_paid_txt.Location = new System.Drawing.Point(321, 458);
            this.total_not_paid_txt.Name = "total_not_paid_txt";
            this.total_not_paid_txt.ReadOnly = true;
            this.total_not_paid_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.total_not_paid_txt.Size = new System.Drawing.Size(244, 22);
            this.total_not_paid_txt.TabIndex = 123304;
            this.total_not_paid_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(571, 461);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 14);
            this.label3.TabIndex = 123303;
            this.label3.Text = "اجمالي المتبقي";
            // 
            // kestloancodeDataGridViewTextBoxColumn
            // 
            this.kestloancodeDataGridViewTextBoxColumn.DataPropertyName = "kest_loan_code";
            this.kestloancodeDataGridViewTextBoxColumn.HeaderText = "كود التقسيط";
            this.kestloancodeDataGridViewTextBoxColumn.Name = "kestloancodeDataGridViewTextBoxColumn";
            this.kestloancodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.kestloancodeDataGridViewTextBoxColumn.Width = 70;
            // 
            // kestcstcodeDataGridViewTextBoxColumn
            // 
            this.kestcstcodeDataGridViewTextBoxColumn.DataPropertyName = "kest_cst_code";
            this.kestcstcodeDataGridViewTextBoxColumn.HeaderText = "كود العميل";
            this.kestcstcodeDataGridViewTextBoxColumn.Name = "kestcstcodeDataGridViewTextBoxColumn";
            this.kestcstcodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.kestcstcodeDataGridViewTextBoxColumn.Width = 70;
            // 
            // kestcstnameDataGridViewTextBoxColumn
            // 
            this.kestcstnameDataGridViewTextBoxColumn.DataPropertyName = "kest_cst_name";
            this.kestcstnameDataGridViewTextBoxColumn.HeaderText = "اسم العميل";
            this.kestcstnameDataGridViewTextBoxColumn.Name = "kestcstnameDataGridViewTextBoxColumn";
            this.kestcstnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.kestcstnameDataGridViewTextBoxColumn.Width = 200;
            // 
            // kest1stdamencodeDataGridViewTextBoxColumn
            // 
            this.kest1stdamencodeDataGridViewTextBoxColumn.DataPropertyName = "kest_1st_damen_code";
            this.kest1stdamencodeDataGridViewTextBoxColumn.HeaderText = "الضامن";
            this.kest1stdamencodeDataGridViewTextBoxColumn.Name = "kest1stdamencodeDataGridViewTextBoxColumn";
            this.kest1stdamencodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.kest1stdamencodeDataGridViewTextBoxColumn.Width = 190;
            // 
            // totalloanamountDataGridViewTextBoxColumn
            // 
            this.totalloanamountDataGridViewTextBoxColumn.DataPropertyName = "total_loan_amount";
            this.totalloanamountDataGridViewTextBoxColumn.HeaderText = "اجمالي التقسيط";
            this.totalloanamountDataGridViewTextBoxColumn.Name = "totalloanamountDataGridViewTextBoxColumn";
            this.totalloanamountDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalloanamountDataGridViewTextBoxColumn.Width = 70;
            // 
            // first_paid_date
            // 
            this.first_paid_date.DataPropertyName = "first_paid_date";
            this.first_paid_date.HeaderText = "اول عملية";
            this.first_paid_date.Name = "first_paid_date";
            this.first_paid_date.ReadOnly = true;
            this.first_paid_date.Width = 90;
            // 
            // last_paid_date
            // 
            this.last_paid_date.DataPropertyName = "last_paid_date";
            this.last_paid_date.HeaderText = "اخر عملية";
            this.last_paid_date.Name = "last_paid_date";
            this.last_paid_date.ReadOnly = true;
            this.last_paid_date.Width = 90;
            // 
            // kestfar3DataGridViewTextBoxColumn
            // 
            this.kestfar3DataGridViewTextBoxColumn.DataPropertyName = "kest_far3";
            this.kestfar3DataGridViewTextBoxColumn.HeaderText = "الفرع";
            this.kestfar3DataGridViewTextBoxColumn.Name = "kestfar3DataGridViewTextBoxColumn";
            this.kestfar3DataGridViewTextBoxColumn.ReadOnly = true;
            this.kestfar3DataGridViewTextBoxColumn.Width = 80;
            // 
            // kestmodateltamweelDataGridViewTextBoxColumn
            // 
            this.kestmodateltamweelDataGridViewTextBoxColumn.DataPropertyName = "kest_modat_eltamweel";
            this.kestmodateltamweelDataGridViewTextBoxColumn.HeaderText = "الفترة";
            this.kestmodateltamweelDataGridViewTextBoxColumn.Name = "kestmodateltamweelDataGridViewTextBoxColumn";
            this.kestmodateltamweelDataGridViewTextBoxColumn.ReadOnly = true;
            this.kestmodateltamweelDataGridViewTextBoxColumn.Width = 70;
            // 
            // countpaidDataGridViewTextBoxColumn
            // 
            this.countpaidDataGridViewTextBoxColumn.DataPropertyName = "count_paid";
            this.countpaidDataGridViewTextBoxColumn.HeaderText = "الاقساط المسددة";
            this.countpaidDataGridViewTextBoxColumn.Name = "countpaidDataGridViewTextBoxColumn";
            this.countpaidDataGridViewTextBoxColumn.ReadOnly = true;
            this.countpaidDataGridViewTextBoxColumn.Width = 80;
            // 
            // totalpaidDataGridViewTextBoxColumn
            // 
            this.totalpaidDataGridViewTextBoxColumn.DataPropertyName = "total_paid";
            this.totalpaidDataGridViewTextBoxColumn.HeaderText = "اجمالي المسدد";
            this.totalpaidDataGridViewTextBoxColumn.Name = "totalpaidDataGridViewTextBoxColumn";
            this.totalpaidDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalpaidDataGridViewTextBoxColumn.Width = 90;
            // 
            // countnotpaidDataGridViewTextBoxColumn
            // 
            this.countnotpaidDataGridViewTextBoxColumn.DataPropertyName = "count_not_paid";
            this.countnotpaidDataGridViewTextBoxColumn.HeaderText = "الاقساط المتبقية";
            this.countnotpaidDataGridViewTextBoxColumn.Name = "countnotpaidDataGridViewTextBoxColumn";
            this.countnotpaidDataGridViewTextBoxColumn.ReadOnly = true;
            this.countnotpaidDataGridViewTextBoxColumn.Width = 80;
            // 
            // totalnotpaidDataGridViewTextBoxColumn
            // 
            this.totalnotpaidDataGridViewTextBoxColumn.DataPropertyName = "total_not_paid";
            this.totalnotpaidDataGridViewTextBoxColumn.HeaderText = "اجمالي المتبقي";
            this.totalnotpaidDataGridViewTextBoxColumn.Name = "totalnotpaidDataGridViewTextBoxColumn";
            this.totalnotpaidDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalnotpaidDataGridViewTextBoxColumn.Width = 90;
            // 
            // aksat_summary_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 493);
            this.Controls.Add(this.total_paid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.total_not_paid_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.substringAutoCompleteTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.far3txt);
            this.Controls.Add(this.user_txt);
            this.Name = "aksat_summary_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "aksat_summary_form";
            this.Load += new System.EventHandler(this.aksat_summary_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aksatsummaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label far3txt;
        public System.Windows.Forms.Label user_txt;
        public System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource aksatsummaryBindingSource;
        private DataSet1TableAdapters.aksat_summaryTableAdapter aksat_summaryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstduedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastpaymentdateDataGridViewTextBoxColumn;
        public System.Windows.Forms.Label label2;
        public SubstringAutoCompleteTextBox substringAutoCompleteTextBox1;
        private System.Windows.Forms.TextBox total_paid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox total_not_paid_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn kestloancodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kestcstcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kestcstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kest1stdamencodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalloanamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_paid_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_paid_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn kestfar3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kestmodateltamweelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countpaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalpaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countnotpaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalnotpaidDataGridViewTextBoxColumn;
    }
}