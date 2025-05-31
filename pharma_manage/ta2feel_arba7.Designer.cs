namespace pharma_manage
{
    partial class ta2feel_arba7
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
            this.partnerssharetableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new pharma_manage.DataSet1();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.arba7_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.arba7_tableTableAdapter();
            this.user_txt = new System.Windows.Forms.Label();
            this.far3_txt = new System.Windows.Forms.Label();
            this.partners_share_tableTableAdapter = new pharma_manage.DataSet1TableAdapters.partners_share_tableTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.partnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capitalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalProfitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profitShareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profitsharestableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profit_shares_tableTableAdapter = new pharma_manage.DataSet1TableAdapters.profit_shares_tableTableAdapter();
            this.total_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.partnerssharetableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profitsharestableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // partnerssharetableBindingSource
            // 
            this.partnerssharetableBindingSource.DataMember = "partners_share_table";
            this.partnerssharetableBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(537, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 14);
            this.label4.TabIndex = 106;
            this.label4.Text = "إلــــى";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(789, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 14);
            this.label3.TabIndex = 105;
            this.label3.Text = "من";
            this.label3.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(330, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 104;
            this.dateTimePicker2.Value = new System.DateTime(2015, 9, 21, 0, 0, 0, 0);
            this.dateTimePicker2.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(583, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 103;
            this.dateTimePicker1.Value = new System.DateTime(2015, 9, 21, 0, 0, 0, 0);
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // arba7_tableTableAdapter1
            // 
            this.arba7_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // user_txt
            // 
            this.user_txt.AutoSize = true;
            this.user_txt.Location = new System.Drawing.Point(254, 9);
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(28, 13);
            this.user_txt.TabIndex = 123290;
            this.user_txt.Text = "user";
            this.user_txt.Visible = false;
            // 
            // far3_txt
            // 
            this.far3_txt.AutoSize = true;
            this.far3_txt.Location = new System.Drawing.Point(37, 9);
            this.far3_txt.Name = "far3_txt";
            this.far3_txt.Size = new System.Drawing.Size(27, 13);
            this.far3_txt.TabIndex = 123291;
            this.far3_txt.Text = "far3";
            // 
            // partners_share_tableTableAdapter
            // 
            this.partners_share_tableTableAdapter.ClearBeforeFill = true;
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
            this.partnerDataGridViewTextBoxColumn,
            this.periodStartDataGridViewTextBoxColumn,
            this.periodEndDataGridViewTextBoxColumn,
            this.capitalDataGridViewTextBoxColumn,
            this.shareDataGridViewTextBoxColumn,
            this.totalProfitDataGridViewTextBoxColumn,
            this.profitShareDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.profitsharestableBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(66, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(1010, 326);
            this.dataGridView1.TabIndex = 6;
            // 
            // partnerDataGridViewTextBoxColumn
            // 
            this.partnerDataGridViewTextBoxColumn.DataPropertyName = "Partner";
            this.partnerDataGridViewTextBoxColumn.HeaderText = "الاسم";
            this.partnerDataGridViewTextBoxColumn.Name = "partnerDataGridViewTextBoxColumn";
            this.partnerDataGridViewTextBoxColumn.ReadOnly = true;
            this.partnerDataGridViewTextBoxColumn.Width = 200;
            // 
            // periodStartDataGridViewTextBoxColumn
            // 
            this.periodStartDataGridViewTextBoxColumn.DataPropertyName = "Period_Start";
            this.periodStartDataGridViewTextBoxColumn.HeaderText = "بداية الفترة";
            this.periodStartDataGridViewTextBoxColumn.Name = "periodStartDataGridViewTextBoxColumn";
            this.periodStartDataGridViewTextBoxColumn.ReadOnly = true;
            this.periodStartDataGridViewTextBoxColumn.Width = 120;
            // 
            // periodEndDataGridViewTextBoxColumn
            // 
            this.periodEndDataGridViewTextBoxColumn.DataPropertyName = "Period_End";
            this.periodEndDataGridViewTextBoxColumn.HeaderText = "نهاية الفترة";
            this.periodEndDataGridViewTextBoxColumn.Name = "periodEndDataGridViewTextBoxColumn";
            this.periodEndDataGridViewTextBoxColumn.ReadOnly = true;
            this.periodEndDataGridViewTextBoxColumn.Width = 120;
            // 
            // capitalDataGridViewTextBoxColumn
            // 
            this.capitalDataGridViewTextBoxColumn.DataPropertyName = "Capital";
            this.capitalDataGridViewTextBoxColumn.HeaderText = "Capital";
            this.capitalDataGridViewTextBoxColumn.Name = "capitalDataGridViewTextBoxColumn";
            this.capitalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shareDataGridViewTextBoxColumn
            // 
            this.shareDataGridViewTextBoxColumn.DataPropertyName = "Share (%)";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.shareDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.shareDataGridViewTextBoxColumn.HeaderText = "النسبة";
            this.shareDataGridViewTextBoxColumn.Name = "shareDataGridViewTextBoxColumn";
            this.shareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalProfitDataGridViewTextBoxColumn
            // 
            this.totalProfitDataGridViewTextBoxColumn.DataPropertyName = "Total_Profit";
            this.totalProfitDataGridViewTextBoxColumn.HeaderText = "اجمالي الربح في الفترة";
            this.totalProfitDataGridViewTextBoxColumn.Name = "totalProfitDataGridViewTextBoxColumn";
            this.totalProfitDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalProfitDataGridViewTextBoxColumn.Width = 180;
            // 
            // profitShareDataGridViewTextBoxColumn
            // 
            this.profitShareDataGridViewTextBoxColumn.DataPropertyName = "Profit_Share";
            this.profitShareDataGridViewTextBoxColumn.HeaderText = "النسبة من الربح";
            this.profitShareDataGridViewTextBoxColumn.Name = "profitShareDataGridViewTextBoxColumn";
            this.profitShareDataGridViewTextBoxColumn.ReadOnly = true;
            this.profitShareDataGridViewTextBoxColumn.Width = 120;
            // 
            // profitsharestableBindingSource
            // 
            this.profitsharestableBindingSource.DataMember = "profit_shares_table";
            this.profitsharestableBindingSource.DataSource = this.dataSet1;
            // 
            // profit_shares_tableTableAdapter
            // 
            this.profit_shares_tableTableAdapter.ClearBeforeFill = true;
            // 
            // total_txt
            // 
            this.total_txt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.total_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_txt.Location = new System.Drawing.Point(387, 368);
            this.total_txt.Name = "total_txt";
            this.total_txt.ReadOnly = true;
            this.total_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.total_txt.Size = new System.Drawing.Size(396, 22);
            this.total_txt.TabIndex = 123292;
            this.total_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ta2feel_arba7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 402);
            this.Controls.Add(this.total_txt);
            this.Controls.Add(this.user_txt);
            this.Controls.Add(this.far3_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ta2feel_arba7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقفيل أرباح ";
            this.Load += new System.EventHandler(this.ta2feel_arba7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partnerssharetableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profitsharestableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DataSet1TableAdapters.arba7_tableTableAdapter arba7_tableTableAdapter1;
        public System.Windows.Forms.Label user_txt;
        public System.Windows.Forms.Label far3_txt;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource partnerssharetableBindingSource;
        private DataSet1TableAdapters.partners_share_tableTableAdapter partners_share_tableTableAdapter;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource profitsharestableBindingSource;
        private DataSet1TableAdapters.profit_shares_tableTableAdapter profit_shares_tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn partnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capitalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalProfitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profitShareDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox total_txt;
    }
}