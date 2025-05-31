namespace pharma_manage
{
    partial class da2n_details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(da2n_details));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.da2n_tableTableAdapter = new pharma_manage.DataSet1TableAdapters.da2n_tableTableAdapter();
            this.dataSet1 = new pharma_manage.DataSet1();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.search_text = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ba2ytxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.madfoo3txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.matloobtxt = new System.Windows.Forms.TextBox();
            this.usertxt = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.da2nidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.da2ndateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.da2nfatoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.da2ndetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.da2nmatloobinfatoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.da2ncostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.da2nnotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.da2nuserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.da2ntableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.da2ntableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.a5_crystal_da2n_details1 = new pharma_manage.a5_crystal_da2n_details();
            this.pharmacy_dataTableAdapter1 = new pharma_manage.DataSet1TableAdapters.pharmacy_dataTableAdapter();
            this.da2n_small_reportsTableAdapter1 = new pharma_manage.DataSet1TableAdapters.da2n_small_reportsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.da2ntableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.da2ntableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // da2n_tableTableAdapter
            // 
            this.da2n_tableTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1073, 474);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 98;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(657, 12);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 95;
            this.label1.Text = "اسم الدائن";
            // 
            // searchbtn
            // 
            this.searchbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchbtn.BackColor = System.Drawing.Color.Green;
            this.searchbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.searchbtn.FlatAppearance.BorderSize = 2;
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchbtn.Location = new System.Drawing.Point(485, 36);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(161, 26);
            this.searchbtn.TabIndex = 96;
            this.searchbtn.Text = "بــــحـــــث";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // search_text
            // 
            this.search_text.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.search_text.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_text.Location = new System.Drawing.Point(399, 9);
            this.search_text.Name = "search_text";
            this.search_text.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.search_text.Size = new System.Drawing.Size(258, 22);
            this.search_text.TabIndex = 94;
            this.search_text.TextChanged += new System.EventHandler(this.search_text_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ba2ytxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.madfoo3txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.matloobtxt);
            this.groupBox1.Location = new System.Drawing.Point(183, 447);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(765, 84);
            this.groupBox1.TabIndex = 97;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 23);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(98, 14);
            this.label4.TabIndex = 76;
            this.label4.Text = "إجمالي البــاقي";
            // 
            // ba2ytxt
            // 
            this.ba2ytxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ba2ytxt.BackColor = System.Drawing.Color.Red;
            this.ba2ytxt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ba2ytxt.Location = new System.Drawing.Point(11, 40);
            this.ba2ytxt.Name = "ba2ytxt";
            this.ba2ytxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ba2ytxt.Size = new System.Drawing.Size(229, 22);
            this.ba2ytxt.TabIndex = 75;
            this.ba2ytxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(331, 23);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(99, 14);
            this.label3.TabIndex = 74;
            this.label3.Text = "إجمالي المدفوع";
            // 
            // madfoo3txt
            // 
            this.madfoo3txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.madfoo3txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.madfoo3txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.madfoo3txt.Location = new System.Drawing.Point(267, 40);
            this.madfoo3txt.Name = "madfoo3txt";
            this.madfoo3txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.madfoo3txt.Size = new System.Drawing.Size(229, 22);
            this.madfoo3txt.TabIndex = 73;
            this.madfoo3txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(587, 23);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(103, 14);
            this.label2.TabIndex = 72;
            this.label2.Text = "إجمالي المطلوب";
            // 
            // matloobtxt
            // 
            this.matloobtxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.matloobtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.matloobtxt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matloobtxt.Location = new System.Drawing.Point(523, 40);
            this.matloobtxt.Name = "matloobtxt";
            this.matloobtxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.matloobtxt.Size = new System.Drawing.Size(229, 22);
            this.matloobtxt.TabIndex = 71;
            this.matloobtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // usertxt
            // 
            this.usertxt.AutoSize = true;
            this.usertxt.Location = new System.Drawing.Point(87, 29);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(28, 13);
            this.usertxt.TabIndex = 93;
            this.usertxt.Text = "user";
            this.usertxt.Visible = false;
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
            this.da2nidDataGridViewTextBoxColumn,
            this.da2ndateDataGridViewTextBoxColumn,
            this.da2nfatoraDataGridViewTextBoxColumn,
            this.da2ndetailsDataGridViewTextBoxColumn,
            this.da2nmatloobinfatoraDataGridViewTextBoxColumn,
            this.da2ncostDataGridViewTextBoxColumn,
            this.da2nnotesDataGridViewTextBoxColumn,
            this.da2nuserDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.da2ntableBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(44, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(1076, 388);
            this.dataGridView1.TabIndex = 99;
            // 
            // da2nidDataGridViewTextBoxColumn
            // 
            this.da2nidDataGridViewTextBoxColumn.DataPropertyName = "da2n_id";
            this.da2nidDataGridViewTextBoxColumn.HeaderText = "م";
            this.da2nidDataGridViewTextBoxColumn.Name = "da2nidDataGridViewTextBoxColumn";
            this.da2nidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // da2ndateDataGridViewTextBoxColumn
            // 
            this.da2ndateDataGridViewTextBoxColumn.DataPropertyName = "da2n_date";
            this.da2ndateDataGridViewTextBoxColumn.HeaderText = "التاريخ";
            this.da2ndateDataGridViewTextBoxColumn.Name = "da2ndateDataGridViewTextBoxColumn";
            this.da2ndateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // da2nfatoraDataGridViewTextBoxColumn
            // 
            this.da2nfatoraDataGridViewTextBoxColumn.DataPropertyName = "da2n_fatora";
            this.da2nfatoraDataGridViewTextBoxColumn.HeaderText = "رقم الفاتورة";
            this.da2nfatoraDataGridViewTextBoxColumn.Name = "da2nfatoraDataGridViewTextBoxColumn";
            this.da2nfatoraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // da2ndetailsDataGridViewTextBoxColumn
            // 
            this.da2ndetailsDataGridViewTextBoxColumn.DataPropertyName = "da2n_details";
            this.da2ndetailsDataGridViewTextBoxColumn.HeaderText = "تفاصيل";
            this.da2ndetailsDataGridViewTextBoxColumn.Name = "da2ndetailsDataGridViewTextBoxColumn";
            this.da2ndetailsDataGridViewTextBoxColumn.ReadOnly = true;
            this.da2ndetailsDataGridViewTextBoxColumn.Width = 250;
            // 
            // da2nmatloobinfatoraDataGridViewTextBoxColumn
            // 
            this.da2nmatloobinfatoraDataGridViewTextBoxColumn.DataPropertyName = "da2n_matloob_in__fatora";
            this.da2nmatloobinfatoraDataGridViewTextBoxColumn.HeaderText = "المطلوب";
            this.da2nmatloobinfatoraDataGridViewTextBoxColumn.Name = "da2nmatloobinfatoraDataGridViewTextBoxColumn";
            this.da2nmatloobinfatoraDataGridViewTextBoxColumn.ReadOnly = true;
            this.da2nmatloobinfatoraDataGridViewTextBoxColumn.Width = 110;
            // 
            // da2ncostDataGridViewTextBoxColumn
            // 
            this.da2ncostDataGridViewTextBoxColumn.DataPropertyName = "da2n_cost";
            this.da2ncostDataGridViewTextBoxColumn.HeaderText = "المدفوع";
            this.da2ncostDataGridViewTextBoxColumn.Name = "da2ncostDataGridViewTextBoxColumn";
            this.da2ncostDataGridViewTextBoxColumn.ReadOnly = true;
            this.da2ncostDataGridViewTextBoxColumn.Width = 110;
            // 
            // da2nnotesDataGridViewTextBoxColumn
            // 
            this.da2nnotesDataGridViewTextBoxColumn.DataPropertyName = "da2n_notes";
            this.da2nnotesDataGridViewTextBoxColumn.HeaderText = "ملاحظات";
            this.da2nnotesDataGridViewTextBoxColumn.Name = "da2nnotesDataGridViewTextBoxColumn";
            this.da2nnotesDataGridViewTextBoxColumn.ReadOnly = true;
            this.da2nnotesDataGridViewTextBoxColumn.Width = 150;
            // 
            // da2nuserDataGridViewTextBoxColumn
            // 
            this.da2nuserDataGridViewTextBoxColumn.DataPropertyName = "da2n_user";
            this.da2nuserDataGridViewTextBoxColumn.HeaderText = "المستخدم";
            this.da2nuserDataGridViewTextBoxColumn.Name = "da2nuserDataGridViewTextBoxColumn";
            this.da2nuserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // da2ntableBindingSource1
            // 
            this.da2ntableBindingSource1.DataMember = "da2n_table";
            this.da2ntableBindingSource1.DataSource = this.dataSet1;
            // 
            // da2ntableBindingSource
            // 
            this.da2ntableBindingSource.DataMember = "da2n_table";
            // 
            // pharmacy_dataTableAdapter1
            // 
            this.pharmacy_dataTableAdapter1.ClearBeforeFill = true;
            // 
            // da2n_small_reportsTableAdapter1
            // 
            this.da2n_small_reportsTableAdapter1.ClearBeforeFill = true;
            // 
            // da2n_details
            // 
            this.AcceptButton = this.searchbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 540);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.search_text);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.usertxt);
            this.Name = "da2n_details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "da2n_details";
            this.Load += new System.EventHandler(this.da2n_details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.da2ntableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.da2ntableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1TableAdapters.da2n_tableTableAdapter da2n_tableTableAdapter;
        private DataSet1 dataSet1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchbtn;
        public System.Windows.Forms.TextBox search_text;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ba2ytxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox madfoo3txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox matloobtxt;
        private System.Windows.Forms.BindingSource da2ntableBindingSource;
        public System.Windows.Forms.Label usertxt;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn da2nidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn da2ndateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn da2nfatoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn da2ndetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn da2nmatloobinfatoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn da2ncostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn da2nnotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn da2nuserDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource da2ntableBindingSource1;
        private a5_crystal_da2n_details a5_crystal_da2n_details1;
        private DataSet1TableAdapters.pharmacy_dataTableAdapter pharmacy_dataTableAdapter1;
        private DataSet1TableAdapters.da2n_small_reportsTableAdapter da2n_small_reportsTableAdapter1;
    }
}