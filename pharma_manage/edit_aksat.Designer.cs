namespace pharma_manage
{
    partial class edit_aksat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.total_txt = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.loan_code_txt = new System.Windows.Forms.TextBox();
            this.far3_txt = new System.Windows.Forms.Label();
            this.user_txt = new System.Windows.Forms.Label();
            this.aksat_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.aksat_tableTableAdapter();
            this.dataSet11 = new pharma_manage.DataSet1();
            this.most7ak_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // total_txt
            // 
            this.total_txt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.total_txt.BackColor = System.Drawing.Color.White;
            this.total_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.total_txt.Location = new System.Drawing.Point(274, 475);
            this.total_txt.Name = "total_txt";
            this.total_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.total_txt.Size = new System.Drawing.Size(341, 22);
            this.total_txt.TabIndex = 123301;
            this.total_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label24.Location = new System.Drawing.Point(415, 460);
            this.label24.Name = "label24";
            this.label24.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label24.Size = new System.Drawing.Size(58, 14);
            this.label24.TabIndex = 123302;
            this.label24.Text = "الاجمالي";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridView1.Location = new System.Drawing.Point(274, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersWidth = 15;
            this.dataGridView1.Size = new System.Drawing.Size(341, 395);
            this.dataGridView1.TabIndex = 123303;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // Column1
            // 
            dataGridViewCellStyle15.Format = "N0";
            dataGridViewCellStyle15.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle15;
            this.Column1.HeaderText = "رقم القسط";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            dataGridViewCellStyle16.Format = "d";
            dataGridViewCellStyle16.NullValue = null;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle16;
            this.Column2.HeaderText = "تاريخ الاستحقاق";
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            dataGridViewCellStyle17.Format = "N2";
            dataGridViewCellStyle17.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle17;
            this.Column3.HeaderText = "قيمة القسط";
            this.Column3.Name = "Column3";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(752, 13);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(81, 14);
            this.label2.TabIndex = 123305;
            this.label2.Text = "كود التقسيط";
            // 
            // loan_code_txt
            // 
            this.loan_code_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loan_code_txt.BackColor = System.Drawing.Color.White;
            this.loan_code_txt.Enabled = false;
            this.loan_code_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.loan_code_txt.ForeColor = System.Drawing.Color.Black;
            this.loan_code_txt.Location = new System.Drawing.Point(508, 10);
            this.loan_code_txt.Name = "loan_code_txt";
            this.loan_code_txt.ReadOnly = true;
            this.loan_code_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.loan_code_txt.Size = new System.Drawing.Size(238, 22);
            this.loan_code_txt.TabIndex = 123306;
            this.loan_code_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // far3_txt
            // 
            this.far3_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.far3_txt.AutoSize = true;
            this.far3_txt.Location = new System.Drawing.Point(463, 19);
            this.far3_txt.Name = "far3_txt";
            this.far3_txt.Size = new System.Drawing.Size(27, 13);
            this.far3_txt.TabIndex = 123308;
            this.far3_txt.Text = "far3";
            // 
            // user_txt
            // 
            this.user_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.user_txt.AutoSize = true;
            this.user_txt.Location = new System.Drawing.Point(398, 19);
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(28, 13);
            this.user_txt.TabIndex = 123307;
            this.user_txt.Text = "user";
            // 
            // aksat_tableTableAdapter1
            // 
            this.aksat_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // most7ak_txt
            // 
            this.most7ak_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.most7ak_txt.BackColor = System.Drawing.Color.White;
            this.most7ak_txt.Enabled = false;
            this.most7ak_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.most7ak_txt.ForeColor = System.Drawing.Color.Black;
            this.most7ak_txt.Location = new System.Drawing.Point(77, 10);
            this.most7ak_txt.Name = "most7ak_txt";
            this.most7ak_txt.ReadOnly = true;
            this.most7ak_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.most7ak_txt.Size = new System.Drawing.Size(238, 22);
            this.most7ak_txt.TabIndex = 123310;
            this.most7ak_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(321, 13);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(102, 14);
            this.label1.TabIndex = 123309;
            this.label1.Text = "المبلغ المستحق";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(274, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(341, 33);
            this.button1.TabIndex = 123311;
            this.button1.Text = "حفظ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // edit_aksat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.most7ak_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.far3_txt);
            this.Controls.Add(this.user_txt);
            this.Controls.Add(this.loan_code_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.total_txt);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.dataGridView1);
            this.Name = "edit_aksat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "edit_aksat";
            this.Load += new System.EventHandler(this.edit_aksat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox total_txt;
        public System.Windows.Forms.Label label24;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox loan_code_txt;
        public System.Windows.Forms.Label far3_txt;
        public System.Windows.Forms.Label user_txt;
        private DataSet1TableAdapters.aksat_tableTableAdapter aksat_tableTableAdapter1;
        private DataSet1 dataSet11;
        public System.Windows.Forms.TextBox most7ak_txt;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}