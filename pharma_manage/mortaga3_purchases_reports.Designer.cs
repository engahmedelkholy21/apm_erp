namespace pharma_manage
{
    partial class mortaga3_purchases_reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mortaga3_purchases_reports));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateGroup = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataSet1 = new pharma_manage.DataSet1();
            this.mortaga3purchasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mortaga3_purchasesTableAdapter = new pharma_manage.DataSet1TableAdapters.mortaga3_purchasesTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mortaga3purchasesidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mortaga3purchasesfatoraIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mortaga3purchasesdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mortaga3purchasesmwarednameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mortaga3purchasesproductIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mortaga3purchasesproductnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mortaga3purchasescountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mortaga3purchasesunitpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mortaga3purchasespriceforsellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mortaga3_purchases_notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mortaga3purchasesuserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.da2n_small_reportsTableAdapter1 = new pharma_manage.DataSet1TableAdapters.da2n_small_reportsTableAdapter();
            this.pharmacy_dataTableAdapter1 = new pharma_manage.DataSet1TableAdapters.pharmacy_dataTableAdapter();
            this.mortaga3_purchases_crystal1 = new pharma_manage.mortaga3_purchases_crystal();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.dateGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mortaga3purchasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 106;
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
            this.dateGroup.Location = new System.Drawing.Point(326, 12);
            this.dateGroup.Name = "dateGroup";
            this.dateGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateGroup.Size = new System.Drawing.Size(550, 52);
            this.dateGroup.TabIndex = 105;
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
            // mortaga3purchasesBindingSource
            // 
            this.mortaga3purchasesBindingSource.DataMember = "mortaga3_purchases";
            this.mortaga3purchasesBindingSource.DataSource = this.dataSet1;
            // 
            // mortaga3_purchasesTableAdapter
            // 
            this.mortaga3_purchasesTableAdapter.ClearBeforeFill = true;
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
            this.mortaga3purchasesidDataGridViewTextBoxColumn,
            this.mortaga3purchasesfatoraIDDataGridViewTextBoxColumn,
            this.mortaga3purchasesdateDataGridViewTextBoxColumn,
            this.mortaga3purchasesmwarednameDataGridViewTextBoxColumn,
            this.mortaga3purchasesproductIDDataGridViewTextBoxColumn,
            this.mortaga3purchasesproductnameDataGridViewTextBoxColumn,
            this.mortaga3purchasescountDataGridViewTextBoxColumn,
            this.mortaga3purchasesunitpriceDataGridViewTextBoxColumn,
            this.mortaga3purchasespriceforsellDataGridViewTextBoxColumn,
            this.mortaga3_purchases_notes,
            this.mortaga3purchasesuserDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mortaga3purchasesBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(1179, 404);
            this.dataGridView1.TabIndex = 107;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // mortaga3purchasesidDataGridViewTextBoxColumn
            // 
            this.mortaga3purchasesidDataGridViewTextBoxColumn.DataPropertyName = "mortaga3_purchases_id";
            this.mortaga3purchasesidDataGridViewTextBoxColumn.HeaderText = "م";
            this.mortaga3purchasesidDataGridViewTextBoxColumn.Name = "mortaga3purchasesidDataGridViewTextBoxColumn";
            this.mortaga3purchasesidDataGridViewTextBoxColumn.ReadOnly = true;
            this.mortaga3purchasesidDataGridViewTextBoxColumn.Width = 80;
            // 
            // mortaga3purchasesfatoraIDDataGridViewTextBoxColumn
            // 
            this.mortaga3purchasesfatoraIDDataGridViewTextBoxColumn.DataPropertyName = "mortaga3_purchases_fatora_ID";
            this.mortaga3purchasesfatoraIDDataGridViewTextBoxColumn.HeaderText = "رقم الفاتورة";
            this.mortaga3purchasesfatoraIDDataGridViewTextBoxColumn.Name = "mortaga3purchasesfatoraIDDataGridViewTextBoxColumn";
            this.mortaga3purchasesfatoraIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.mortaga3purchasesfatoraIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // mortaga3purchasesdateDataGridViewTextBoxColumn
            // 
            this.mortaga3purchasesdateDataGridViewTextBoxColumn.DataPropertyName = "mortaga3_purchases_date";
            this.mortaga3purchasesdateDataGridViewTextBoxColumn.HeaderText = "التاريخ";
            this.mortaga3purchasesdateDataGridViewTextBoxColumn.Name = "mortaga3purchasesdateDataGridViewTextBoxColumn";
            this.mortaga3purchasesdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.mortaga3purchasesdateDataGridViewTextBoxColumn.Width = 80;
            // 
            // mortaga3purchasesmwarednameDataGridViewTextBoxColumn
            // 
            this.mortaga3purchasesmwarednameDataGridViewTextBoxColumn.DataPropertyName = "mortaga3_purchases_mwared_name";
            this.mortaga3purchasesmwarednameDataGridViewTextBoxColumn.HeaderText = "اسم المورد";
            this.mortaga3purchasesmwarednameDataGridViewTextBoxColumn.Name = "mortaga3purchasesmwarednameDataGridViewTextBoxColumn";
            this.mortaga3purchasesmwarednameDataGridViewTextBoxColumn.ReadOnly = true;
            this.mortaga3purchasesmwarednameDataGridViewTextBoxColumn.Width = 150;
            // 
            // mortaga3purchasesproductIDDataGridViewTextBoxColumn
            // 
            this.mortaga3purchasesproductIDDataGridViewTextBoxColumn.DataPropertyName = "mortaga3_purchases_productID";
            this.mortaga3purchasesproductIDDataGridViewTextBoxColumn.HeaderText = "كود المنتج";
            this.mortaga3purchasesproductIDDataGridViewTextBoxColumn.Name = "mortaga3purchasesproductIDDataGridViewTextBoxColumn";
            this.mortaga3purchasesproductIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.mortaga3purchasesproductIDDataGridViewTextBoxColumn.Width = 70;
            // 
            // mortaga3purchasesproductnameDataGridViewTextBoxColumn
            // 
            this.mortaga3purchasesproductnameDataGridViewTextBoxColumn.DataPropertyName = "mortaga3_purchases_product_name";
            this.mortaga3purchasesproductnameDataGridViewTextBoxColumn.HeaderText = "اسم المنتج";
            this.mortaga3purchasesproductnameDataGridViewTextBoxColumn.Name = "mortaga3purchasesproductnameDataGridViewTextBoxColumn";
            this.mortaga3purchasesproductnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.mortaga3purchasesproductnameDataGridViewTextBoxColumn.Width = 170;
            // 
            // mortaga3purchasescountDataGridViewTextBoxColumn
            // 
            this.mortaga3purchasescountDataGridViewTextBoxColumn.DataPropertyName = "mortaga3_purchases_count";
            this.mortaga3purchasescountDataGridViewTextBoxColumn.HeaderText = "عدد الوحدات";
            this.mortaga3purchasescountDataGridViewTextBoxColumn.Name = "mortaga3purchasescountDataGridViewTextBoxColumn";
            this.mortaga3purchasescountDataGridViewTextBoxColumn.ReadOnly = true;
            this.mortaga3purchasescountDataGridViewTextBoxColumn.Width = 90;
            // 
            // mortaga3purchasesunitpriceDataGridViewTextBoxColumn
            // 
            this.mortaga3purchasesunitpriceDataGridViewTextBoxColumn.DataPropertyName = "mortaga3_purchases_unit_price";
            this.mortaga3purchasesunitpriceDataGridViewTextBoxColumn.HeaderText = "سعر الوحدة";
            this.mortaga3purchasesunitpriceDataGridViewTextBoxColumn.Name = "mortaga3purchasesunitpriceDataGridViewTextBoxColumn";
            this.mortaga3purchasesunitpriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.mortaga3purchasesunitpriceDataGridViewTextBoxColumn.Width = 90;
            // 
            // mortaga3purchasespriceforsellDataGridViewTextBoxColumn
            // 
            this.mortaga3purchasespriceforsellDataGridViewTextBoxColumn.DataPropertyName = "mortaga3_purchases_price_for_sell";
            this.mortaga3purchasespriceforsellDataGridViewTextBoxColumn.HeaderText = "السعر";
            this.mortaga3purchasespriceforsellDataGridViewTextBoxColumn.Name = "mortaga3purchasespriceforsellDataGridViewTextBoxColumn";
            this.mortaga3purchasespriceforsellDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mortaga3_purchases_notes
            // 
            this.mortaga3_purchases_notes.DataPropertyName = "mortaga3_purchases_notes";
            this.mortaga3_purchases_notes.HeaderText = "ملاحظات";
            this.mortaga3_purchases_notes.Name = "mortaga3_purchases_notes";
            this.mortaga3_purchases_notes.ReadOnly = true;
            this.mortaga3_purchases_notes.Width = 140;
            // 
            // mortaga3purchasesuserDataGridViewTextBoxColumn
            // 
            this.mortaga3purchasesuserDataGridViewTextBoxColumn.DataPropertyName = "mortaga3_purchases_user";
            this.mortaga3purchasesuserDataGridViewTextBoxColumn.HeaderText = "الموظف";
            this.mortaga3purchasesuserDataGridViewTextBoxColumn.Name = "mortaga3purchasesuserDataGridViewTextBoxColumn";
            this.mortaga3purchasesuserDataGridViewTextBoxColumn.ReadOnly = true;
            this.mortaga3purchasesuserDataGridViewTextBoxColumn.Width = 80;
            // 
            // da2n_small_reportsTableAdapter1
            // 
            this.da2n_small_reportsTableAdapter1.ClearBeforeFill = true;
            // 
            // pharmacy_dataTableAdapter1
            // 
            this.pharmacy_dataTableAdapter1.ClearBeforeFill = true;
            // 
            // mortaga3_purchases_reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 496);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateGroup);
            this.Name = "mortaga3_purchases_reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mortaga3_purchases_reports";
            this.Load += new System.EventHandler(this.mortaga3_purchases_reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.dateGroup.ResumeLayout(false);
            this.dateGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mortaga3purchasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox dateGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource mortaga3purchasesBindingSource;
        private DataSet1TableAdapters.mortaga3_purchasesTableAdapter mortaga3_purchasesTableAdapter;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mortaga3purchasesidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mortaga3purchasesfatoraIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mortaga3purchasesdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mortaga3purchasesmwarednameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mortaga3purchasesproductIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mortaga3purchasesproductnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mortaga3purchasescountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mortaga3purchasesunitpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mortaga3purchasespriceforsellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mortaga3_purchases_notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn mortaga3purchasesuserDataGridViewTextBoxColumn;
        private DataSet1TableAdapters.da2n_small_reportsTableAdapter da2n_small_reportsTableAdapter1;
        private DataSet1TableAdapters.pharmacy_dataTableAdapter pharmacy_dataTableAdapter1;
        private mortaga3_purchases_crystal mortaga3_purchases_crystal1;
    }
}