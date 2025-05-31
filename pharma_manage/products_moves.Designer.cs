namespace pharma_manage
{
    partial class products_moves
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataSet1 = new pharma_manage.DataSet1();
            this.searchbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.search_text = new System.Windows.Forms.TextBox();
            this.usertxt = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ma5zoonidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma5zoondateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma5zoon_pro_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma5zoonpronameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma5zooncountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma5zoonpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma5zoonbeforeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma5zoonafterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma5zoontypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma5zoonfatoraidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma5zooncstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma5zoonuserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma5zoonmovesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ma5zoon_movesTableAdapter = new pharma_manage.DataSet1TableAdapters.ma5zoon_movesTableAdapter();
            this.products_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.products_tableTableAdapter();
            this.stock_txt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ma5zoonmovesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.searchbtn.Location = new System.Drawing.Point(572, 37);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(161, 26);
            this.searchbtn.TabIndex = 73;
            this.searchbtn.Text = "بــــحـــــث";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(731, 12);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(72, 14);
            this.label1.TabIndex = 72;
            this.label1.Text = "إسم المنتج";
            // 
            // search_text
            // 
            this.search_text.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.search_text.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_text.Location = new System.Drawing.Point(502, 9);
            this.search_text.Name = "search_text";
            this.search_text.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.search_text.Size = new System.Drawing.Size(229, 22);
            this.search_text.TabIndex = 71;
            this.search_text.TextChanged += new System.EventHandler(this.search_text_TextChanged);
            // 
            // usertxt
            // 
            this.usertxt.AutoSize = true;
            this.usertxt.Location = new System.Drawing.Point(21, 44);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(27, 13);
            this.usertxt.TabIndex = 70;
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
            this.ma5zoonidDataGridViewTextBoxColumn,
            this.ma5zoondateDataGridViewTextBoxColumn,
            this.ma5zoon_pro_code,
            this.ma5zoonpronameDataGridViewTextBoxColumn,
            this.ma5zooncountDataGridViewTextBoxColumn,
            this.ma5zoonpriceDataGridViewTextBoxColumn,
            this.ma5zoonbeforeDataGridViewTextBoxColumn,
            this.ma5zoonafterDataGridViewTextBoxColumn,
            this.ma5zoontypeDataGridViewTextBoxColumn,
            this.ma5zoonfatoraidDataGridViewTextBoxColumn,
            this.ma5zooncstnameDataGridViewTextBoxColumn,
            this.ma5zoonuserDataGridViewTextBoxColumn,
            this.stock});
            this.dataGridView1.DataSource = this.ma5zoonmovesBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(9, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(1287, 444);
            this.dataGridView1.TabIndex = 69;
            // 
            // ma5zoonidDataGridViewTextBoxColumn
            // 
            this.ma5zoonidDataGridViewTextBoxColumn.DataPropertyName = "ma5zoon_id";
            this.ma5zoonidDataGridViewTextBoxColumn.HeaderText = "م";
            this.ma5zoonidDataGridViewTextBoxColumn.Name = "ma5zoonidDataGridViewTextBoxColumn";
            this.ma5zoonidDataGridViewTextBoxColumn.ReadOnly = true;
            this.ma5zoonidDataGridViewTextBoxColumn.Width = 65;
            // 
            // ma5zoondateDataGridViewTextBoxColumn
            // 
            this.ma5zoondateDataGridViewTextBoxColumn.DataPropertyName = "ma5zoon_date";
            this.ma5zoondateDataGridViewTextBoxColumn.HeaderText = "التاريخ";
            this.ma5zoondateDataGridViewTextBoxColumn.Name = "ma5zoondateDataGridViewTextBoxColumn";
            this.ma5zoondateDataGridViewTextBoxColumn.ReadOnly = true;
            this.ma5zoondateDataGridViewTextBoxColumn.Width = 80;
            // 
            // ma5zoon_pro_code
            // 
            this.ma5zoon_pro_code.DataPropertyName = "ma5zoon_pro_code";
            this.ma5zoon_pro_code.HeaderText = "كود المنتج";
            this.ma5zoon_pro_code.Name = "ma5zoon_pro_code";
            this.ma5zoon_pro_code.ReadOnly = true;
            // 
            // ma5zoonpronameDataGridViewTextBoxColumn
            // 
            this.ma5zoonpronameDataGridViewTextBoxColumn.DataPropertyName = "ma5zoon_pro_name";
            this.ma5zoonpronameDataGridViewTextBoxColumn.HeaderText = "إسم المنتج";
            this.ma5zoonpronameDataGridViewTextBoxColumn.Name = "ma5zoonpronameDataGridViewTextBoxColumn";
            this.ma5zoonpronameDataGridViewTextBoxColumn.ReadOnly = true;
            this.ma5zoonpronameDataGridViewTextBoxColumn.Width = 200;
            // 
            // ma5zooncountDataGridViewTextBoxColumn
            // 
            this.ma5zooncountDataGridViewTextBoxColumn.DataPropertyName = "ma5zoon_count";
            this.ma5zooncountDataGridViewTextBoxColumn.HeaderText = "الكمية";
            this.ma5zooncountDataGridViewTextBoxColumn.Name = "ma5zooncountDataGridViewTextBoxColumn";
            this.ma5zooncountDataGridViewTextBoxColumn.ReadOnly = true;
            this.ma5zooncountDataGridViewTextBoxColumn.Width = 80;
            // 
            // ma5zoonpriceDataGridViewTextBoxColumn
            // 
            this.ma5zoonpriceDataGridViewTextBoxColumn.DataPropertyName = "ma5zoon_price";
            this.ma5zoonpriceDataGridViewTextBoxColumn.HeaderText = "السعر";
            this.ma5zoonpriceDataGridViewTextBoxColumn.Name = "ma5zoonpriceDataGridViewTextBoxColumn";
            this.ma5zoonpriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.ma5zoonpriceDataGridViewTextBoxColumn.Width = 80;
            // 
            // ma5zoonbeforeDataGridViewTextBoxColumn
            // 
            this.ma5zoonbeforeDataGridViewTextBoxColumn.DataPropertyName = "ma5zoon_before";
            this.ma5zoonbeforeDataGridViewTextBoxColumn.HeaderText = "الرصيد قبل العملية";
            this.ma5zoonbeforeDataGridViewTextBoxColumn.Name = "ma5zoonbeforeDataGridViewTextBoxColumn";
            this.ma5zoonbeforeDataGridViewTextBoxColumn.ReadOnly = true;
            this.ma5zoonbeforeDataGridViewTextBoxColumn.Width = 80;
            // 
            // ma5zoonafterDataGridViewTextBoxColumn
            // 
            this.ma5zoonafterDataGridViewTextBoxColumn.DataPropertyName = "ma5zoon_after";
            this.ma5zoonafterDataGridViewTextBoxColumn.HeaderText = "رصيد بعد العملية";
            this.ma5zoonafterDataGridViewTextBoxColumn.Name = "ma5zoonafterDataGridViewTextBoxColumn";
            this.ma5zoonafterDataGridViewTextBoxColumn.ReadOnly = true;
            this.ma5zoonafterDataGridViewTextBoxColumn.Width = 80;
            // 
            // ma5zoontypeDataGridViewTextBoxColumn
            // 
            this.ma5zoontypeDataGridViewTextBoxColumn.DataPropertyName = "ma5zoon_type";
            this.ma5zoontypeDataGridViewTextBoxColumn.HeaderText = "نوع العملية";
            this.ma5zoontypeDataGridViewTextBoxColumn.Name = "ma5zoontypeDataGridViewTextBoxColumn";
            this.ma5zoontypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ma5zoonfatoraidDataGridViewTextBoxColumn
            // 
            this.ma5zoonfatoraidDataGridViewTextBoxColumn.DataPropertyName = "ma5zoon_fatora_id";
            this.ma5zoonfatoraidDataGridViewTextBoxColumn.HeaderText = "رقم الفاتورة";
            this.ma5zoonfatoraidDataGridViewTextBoxColumn.Name = "ma5zoonfatoraidDataGridViewTextBoxColumn";
            this.ma5zoonfatoraidDataGridViewTextBoxColumn.ReadOnly = true;
            this.ma5zoonfatoraidDataGridViewTextBoxColumn.Width = 80;
            // 
            // ma5zooncstnameDataGridViewTextBoxColumn
            // 
            this.ma5zooncstnameDataGridViewTextBoxColumn.DataPropertyName = "ma5zoon_cst_name";
            this.ma5zooncstnameDataGridViewTextBoxColumn.HeaderText = "إسم العميل او المورد";
            this.ma5zooncstnameDataGridViewTextBoxColumn.Name = "ma5zooncstnameDataGridViewTextBoxColumn";
            this.ma5zooncstnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.ma5zooncstnameDataGridViewTextBoxColumn.Width = 120;
            // 
            // ma5zoonuserDataGridViewTextBoxColumn
            // 
            this.ma5zoonuserDataGridViewTextBoxColumn.DataPropertyName = "ma5zoon_user";
            this.ma5zoonuserDataGridViewTextBoxColumn.HeaderText = "المستخدم";
            this.ma5zoonuserDataGridViewTextBoxColumn.Name = "ma5zoonuserDataGridViewTextBoxColumn";
            this.ma5zoonuserDataGridViewTextBoxColumn.ReadOnly = true;
            this.ma5zoonuserDataGridViewTextBoxColumn.Width = 80;
            // 
            // stock
            // 
            this.stock.DataPropertyName = "stock";
            this.stock.HeaderText = "الفرع";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // ma5zoonmovesBindingSource
            // 
            this.ma5zoonmovesBindingSource.DataMember = "ma5zoon_moves";
            this.ma5zoonmovesBindingSource.DataSource = this.dataSet1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ma5zoon_movesTableAdapter
            // 
            this.ma5zoon_movesTableAdapter.ClearBeforeFill = true;
            // 
            // products_tableTableAdapter1
            // 
            this.products_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // stock_txt
            // 
            this.stock_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stock_txt.AutoSize = true;
            this.stock_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_txt.Location = new System.Drawing.Point(1172, 17);
            this.stock_txt.Name = "stock_txt";
            this.stock_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.stock_txt.Size = new System.Drawing.Size(40, 14);
            this.stock_txt.TabIndex = 74;
            this.stock_txt.Text = "stock";
            // 
            // products_moves
            // 
            this.AcceptButton = this.searchbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 525);
            this.Controls.Add(this.stock_txt);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_text);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "products_moves";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "products_moves";
            this.Load += new System.EventHandler(this.products_moves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ma5zoonmovesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox search_text;
        private System.Windows.Forms.BindingSource ma5zoonmovesBindingSource;
        public System.Windows.Forms.Label usertxt;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private DataSet1TableAdapters.ma5zoon_movesTableAdapter ma5zoon_movesTableAdapter;
        private DataSet1TableAdapters.products_tableTableAdapter products_tableTableAdapter1;
        public System.Windows.Forms.Label stock_txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma5zoonidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma5zoondateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma5zoon_pro_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma5zoonpronameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma5zooncountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma5zoonpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma5zoonbeforeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma5zoonafterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma5zoontypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma5zoonfatoraidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma5zooncstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma5zoonuserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;

    }
}