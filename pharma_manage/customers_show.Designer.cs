namespace pharma_manage
{
    partial class customers_show
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customers_show));
            this.cst_nameTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cstIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cst_price_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstnotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cst_national_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cst_takseet_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.betaka_url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new pharma_manage.DataSet1();
            this.customersTableAdapter = new pharma_manage.DataSet1TableAdapters.customersTableAdapter();
            this.far3txt = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.madeen_small_reportTableAdapter1 = new pharma_manage.DataSet1TableAdapters.madeen_small_reportTableAdapter();
            this.usertxt = new System.Windows.Forms.Label();
            this.aksat_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.aksat_tableTableAdapter();
            this.total_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cst_nameTXT
            // 
            this.cst_nameTXT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cst_nameTXT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cst_nameTXT.Location = new System.Drawing.Point(501, 13);
            this.cst_nameTXT.Name = "cst_nameTXT";
            this.cst_nameTXT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cst_nameTXT.Size = new System.Drawing.Size(253, 22);
            this.cst_nameTXT.TabIndex = 94;
            this.cst_nameTXT.TextChanged += new System.EventHandler(this.cst_nameTXT_TextChanged);
            this.cst_nameTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cst_nameTXT_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(769, 16);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(75, 14);
            this.label1.TabIndex = 96;
            this.label1.Text = "إسم العميل";
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
            this.cstIDDataGridViewTextBoxColumn,
            this.cstnameDataGridViewTextBoxColumn,
            this.cstphoneDataGridViewTextBoxColumn,
            this.cstaddressDataGridViewTextBoxColumn,
            this.cst_price_category,
            this.cstnotesDataGridViewTextBoxColumn,
            this.cst_national_id,
            this.cst_takseet_status,
            this.betaka_url});
            this.dataGridView1.DataSource = this.customersBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(36, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(1272, 480);
            this.dataGridView1.TabIndex = 97;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // cstIDDataGridViewTextBoxColumn
            // 
            this.cstIDDataGridViewTextBoxColumn.DataPropertyName = "cst_ID";
            this.cstIDDataGridViewTextBoxColumn.HeaderText = "م";
            this.cstIDDataGridViewTextBoxColumn.Name = "cstIDDataGridViewTextBoxColumn";
            this.cstIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cstIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // cstnameDataGridViewTextBoxColumn
            // 
            this.cstnameDataGridViewTextBoxColumn.DataPropertyName = "cst_name";
            this.cstnameDataGridViewTextBoxColumn.HeaderText = "اسم العميل";
            this.cstnameDataGridViewTextBoxColumn.Name = "cstnameDataGridViewTextBoxColumn";
            this.cstnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.cstnameDataGridViewTextBoxColumn.Width = 220;
            // 
            // cstphoneDataGridViewTextBoxColumn
            // 
            this.cstphoneDataGridViewTextBoxColumn.DataPropertyName = "cst_phone";
            this.cstphoneDataGridViewTextBoxColumn.HeaderText = "تليفون العميل";
            this.cstphoneDataGridViewTextBoxColumn.Name = "cstphoneDataGridViewTextBoxColumn";
            this.cstphoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.cstphoneDataGridViewTextBoxColumn.Width = 110;
            // 
            // cstaddressDataGridViewTextBoxColumn
            // 
            this.cstaddressDataGridViewTextBoxColumn.DataPropertyName = "cst_address";
            this.cstaddressDataGridViewTextBoxColumn.HeaderText = "عنوان العميل";
            this.cstaddressDataGridViewTextBoxColumn.Name = "cstaddressDataGridViewTextBoxColumn";
            this.cstaddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.cstaddressDataGridViewTextBoxColumn.Width = 120;
            // 
            // cst_price_category
            // 
            this.cst_price_category.DataPropertyName = "cst_price_category";
            this.cst_price_category.HeaderText = "الحد الاقصى";
            this.cst_price_category.Name = "cst_price_category";
            this.cst_price_category.ReadOnly = true;
            // 
            // cstnotesDataGridViewTextBoxColumn
            // 
            this.cstnotesDataGridViewTextBoxColumn.DataPropertyName = "cst_notes";
            this.cstnotesDataGridViewTextBoxColumn.HeaderText = "ملاحظات";
            this.cstnotesDataGridViewTextBoxColumn.Name = "cstnotesDataGridViewTextBoxColumn";
            this.cstnotesDataGridViewTextBoxColumn.ReadOnly = true;
            this.cstnotesDataGridViewTextBoxColumn.Width = 320;
            // 
            // cst_national_id
            // 
            this.cst_national_id.DataPropertyName = "cst_national_id";
            this.cst_national_id.HeaderText = "الرقم القومي";
            this.cst_national_id.Name = "cst_national_id";
            this.cst_national_id.ReadOnly = true;
            this.cst_national_id.Width = 120;
            // 
            // cst_takseet_status
            // 
            this.cst_takseet_status.DataPropertyName = "cst_takseet_status";
            this.cst_takseet_status.HeaderText = "حالة التقسيط";
            this.cst_takseet_status.Name = "cst_takseet_status";
            this.cst_takseet_status.ReadOnly = true;
            this.cst_takseet_status.Width = 120;
            // 
            // betaka_url
            // 
            this.betaka_url.DataPropertyName = "betaka_url";
            this.betaka_url.HeaderText = "صورة البطاقة";
            this.betaka_url.Name = "betaka_url";
            this.betaka_url.ReadOnly = true;
            this.betaka_url.Width = 120;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "customers";
            this.customersBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // far3txt
            // 
            this.far3txt.AutoSize = true;
            this.far3txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.far3txt.Location = new System.Drawing.Point(567, 258);
            this.far3txt.Name = "far3txt";
            this.far3txt.Size = new System.Drawing.Size(32, 14);
            this.far3txt.TabIndex = 123253;
            this.far3txt.Text = "far3";
            this.far3txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.far3txt.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1294, 514);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 123255;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // madeen_small_reportTableAdapter1
            // 
            this.madeen_small_reportTableAdapter1.ClearBeforeFill = true;
            // 
            // usertxt
            // 
            this.usertxt.AutoSize = true;
            this.usertxt.Location = new System.Drawing.Point(658, 275);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(28, 13);
            this.usertxt.TabIndex = 123270;
            this.usertxt.Text = "user";
            this.usertxt.Visible = false;
            // 
            // aksat_tableTableAdapter1
            // 
            this.aksat_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // total_txt
            // 
            this.total_txt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.total_txt.BackColor = System.Drawing.Color.White;
            this.total_txt.Enabled = false;
            this.total_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_txt.Location = new System.Drawing.Point(513, 537);
            this.total_txt.Name = "total_txt";
            this.total_txt.ReadOnly = true;
            this.total_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.total_txt.Size = new System.Drawing.Size(244, 22);
            this.total_txt.TabIndex = 123272;
            this.total_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(772, 540);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 14);
            this.label9.TabIndex = 123271;
            this.label9.Text = "عدد العملاء";
            // 
            // customers_show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 563);
            this.Controls.Add(this.total_txt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.far3txt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cst_nameTXT);
            this.Controls.Add(this.label1);
            this.Name = "customers_show";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "customers_show";
            this.Load += new System.EventHandler(this.customers_show_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cst_nameTXT;
        private System.Windows.Forms.Label label1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private DataSet1TableAdapters.customersTableAdapter customersTableAdapter;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label far3txt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DataSet1TableAdapters.madeen_small_reportTableAdapter madeen_small_reportTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cst_price_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstnotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cst_national_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cst_takseet_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn betaka_url;
        public System.Windows.Forms.Label usertxt;
        private DataSet1TableAdapters.aksat_tableTableAdapter aksat_tableTableAdapter1;
        private System.Windows.Forms.TextBox total_txt;
        private System.Windows.Forms.Label label9;
    }
}