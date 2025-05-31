namespace pharma_manage
{
    partial class ta2feel
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
            this.date_time_to_txt = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.before_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataSet12 = new pharma_manage.DataSet1();
            this.safe_outcome_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.outcome_tableTableAdapter();
            this.dataSet11 = new pharma_manage.DataSet1();
            this.far3_txt = new System.Windows.Forms.Label();
            this.first_person_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.second_person_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.safe_income_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.income_tableTableAdapter();
            this.today_raseed_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.all_now_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.emp_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.employee_tableTableAdapter();
            this.dataSet1 = new pharma_manage.DataSet1();
            this.date_time_from_txt = new System.Windows.Forms.DateTimePicker();
            this.ta2feel_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.ta2feel_tableTableAdapter();
            this.madeen_small_reportTableAdapter1 = new pharma_manage.DataSet1TableAdapters.madeen_small_reportTableAdapter();
            this.da2n_small_reportsTableAdapter1 = new pharma_manage.DataSet1TableAdapters.da2n_small_reportsTableAdapter();
            this.ta2feel_crystal1 = new pharma_manage.ta2feel_crystal();
            this.daily_gard1 = new pharma_manage.daily_gard();
            this.outcome_report1 = new pharma_manage.outcome_report();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // date_time_to_txt
            // 
            this.date_time_to_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.date_time_to_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_time_to_txt.Location = new System.Drawing.Point(44, 0);
            this.date_time_to_txt.Name = "date_time_to_txt";
            this.date_time_to_txt.Size = new System.Drawing.Size(200, 22);
            this.date_time_to_txt.TabIndex = 123305;
            this.date_time_to_txt.Value = new System.DateTime(2015, 9, 21, 0, 0, 0, 0);
            this.date_time_to_txt.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(263, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "تقفيل الخزينة";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // before_txt
            // 
            this.before_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.before_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.before_txt.Location = new System.Drawing.Point(149, 32);
            this.before_txt.Name = "before_txt";
            this.before_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.before_txt.Size = new System.Drawing.Size(396, 22);
            this.before_txt.TabIndex = 0;
            this.before_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.before_txt.TextChanged += new System.EventHandler(this.before_txt_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(324, 12);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(76, 14);
            this.label7.TabIndex = 123308;
            this.label7.Text = "مبلغ ما قبله";
            // 
            // dataSet12
            // 
            this.dataSet12.DataSetName = "DataSet1";
            this.dataSet12.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // safe_outcome_tableTableAdapter1
            // 
            this.safe_outcome_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // far3_txt
            // 
            this.far3_txt.AutoSize = true;
            this.far3_txt.Location = new System.Drawing.Point(520, 18);
            this.far3_txt.Name = "far3_txt";
            this.far3_txt.Size = new System.Drawing.Size(25, 13);
            this.far3_txt.TabIndex = 123309;
            this.far3_txt.Text = "far3";
            this.far3_txt.Visible = false;
            // 
            // first_person_txt
            // 
            this.first_person_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.first_person_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_person_txt.Location = new System.Drawing.Point(29, 19);
            this.first_person_txt.Name = "first_person_txt";
            this.first_person_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.first_person_txt.Size = new System.Drawing.Size(305, 22);
            this.first_person_txt.TabIndex = 0;
            this.first_person_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 22);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(41, 14);
            this.label1.TabIndex = 123311;
            this.label1.Text = "السيد";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.second_person_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.first_person_txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(142, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(411, 88);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الحاضرون";
            // 
            // second_person_txt
            // 
            this.second_person_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.second_person_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.second_person_txt.Location = new System.Drawing.Point(29, 56);
            this.second_person_txt.Name = "second_person_txt";
            this.second_person_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.second_person_txt.Size = new System.Drawing.Size(305, 22);
            this.second_person_txt.TabIndex = 1;
            this.second_person_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(340, 59);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(41, 14);
            this.label2.TabIndex = 123313;
            this.label2.Text = "السيد";
            // 
            // safe_income_tableTableAdapter1
            // 
            this.safe_income_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // today_raseed_txt
            // 
            this.today_raseed_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.today_raseed_txt.BackColor = System.Drawing.Color.Chartreuse;
            this.today_raseed_txt.Enabled = false;
            this.today_raseed_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.today_raseed_txt.Location = new System.Drawing.Point(195, 170);
            this.today_raseed_txt.Name = "today_raseed_txt";
            this.today_raseed_txt.ReadOnly = true;
            this.today_raseed_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.today_raseed_txt.Size = new System.Drawing.Size(305, 22);
            this.today_raseed_txt.TabIndex = 123314;
            this.today_raseed_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(284, 153);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(127, 14);
            this.label3.TabIndex = 123315;
            this.label3.Text = "الرصيد منذ اخر تقفيل";
            // 
            // all_now_txt
            // 
            this.all_now_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.all_now_txt.BackColor = System.Drawing.Color.Green;
            this.all_now_txt.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.all_now_txt.ForeColor = System.Drawing.Color.White;
            this.all_now_txt.Location = new System.Drawing.Point(149, 224);
            this.all_now_txt.Name = "all_now_txt";
            this.all_now_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.all_now_txt.Size = new System.Drawing.Size(396, 24);
            this.all_now_txt.TabIndex = 123316;
            this.all_now_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(281, 207);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(132, 14);
            this.label4.TabIndex = 123317;
            this.label4.Text = "الرصيد الفعلي الحالي";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(123, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(449, 208);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "الفئة";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "العدد";
            this.Column2.Name = "Column2";
            this.Column2.Width = 130;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "القيمة";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 130;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(171, 471);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(305, 22);
            this.textBox1.TabIndex = 123319;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(482, 474);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(96, 14);
            this.label5.TabIndex = 123320;
            this.label5.Text = "اجمالي التفقيط";
            // 
            // emp_tableTableAdapter1
            // 
            this.emp_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // date_time_from_txt
            // 
            this.date_time_from_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.date_time_from_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_time_from_txt.Location = new System.Drawing.Point(-6, 135);
            this.date_time_from_txt.Name = "date_time_from_txt";
            this.date_time_from_txt.Size = new System.Drawing.Size(200, 22);
            this.date_time_from_txt.TabIndex = 123321;
            this.date_time_from_txt.Value = new System.DateTime(2015, 9, 21, 0, 0, 0, 0);
            this.date_time_from_txt.Visible = false;
            // 
            // ta2feel_tableTableAdapter1
            // 
            this.ta2feel_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // madeen_small_reportTableAdapter1
            // 
            this.madeen_small_reportTableAdapter1.ClearBeforeFill = true;
            // 
            // da2n_small_reportsTableAdapter1
            // 
            this.da2n_small_reportsTableAdapter1.ClearBeforeFill = true;
            // 
            // ta2feel
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 553);
            this.Controls.Add(this.date_time_from_txt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.all_now_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.today_raseed_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.far3_txt);
            this.Controls.Add(this.before_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.date_time_to_txt);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(587, 218);
            this.Name = "ta2feel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تقفيل الخزينة";
            this.Load += new System.EventHandler(this.ta2feel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker date_time_to_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox before_txt;
        public System.Windows.Forms.Label label7;
        private DataSet1 dataSet12;
        private DataSet1TableAdapters.outcome_tableTableAdapter safe_outcome_tableTableAdapter1;
        private DataSet1 dataSet11;
        public System.Windows.Forms.Label far3_txt;
        private ta2feel_crystal ta2feel_crystal1;
        private System.Windows.Forms.TextBox first_person_txt;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox second_person_txt;
        public System.Windows.Forms.Label label2;
        private daily_gard daily_gard1;
        private DataSet1TableAdapters.income_tableTableAdapter safe_income_tableTableAdapter1;
        private DataSet1 DataSet11;
        private System.Windows.Forms.TextBox today_raseed_txt;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox all_now_txt;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label label5;
        private DataSet1TableAdapters.employee_tableTableAdapter emp_tableTableAdapter1;
      //  private income_report income_report1;
        private outcome_report outcome_report1;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.ta2feel_tableTableAdapter ta2feel_tableTableAdapter1;
        public System.Windows.Forms.DateTimePicker date_time_from_txt;
        private DataSet1TableAdapters.madeen_small_reportTableAdapter madeen_small_reportTableAdapter1;
        private DataSet1TableAdapters.da2n_small_reportsTableAdapter da2n_small_reportsTableAdapter1;
    }
}