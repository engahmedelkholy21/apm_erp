namespace pharma_manage
{
    partial class add_product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_product));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cost_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.limit_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.count_txt = new System.Windows.Forms.TextBox();
            this.category_txt = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new pharma_manage.DataSet1();
            this.label9 = new System.Windows.Forms.Label();
            this.notes_txt = new System.Windows.Forms.TextBox();
            this.productstableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.save_btn = new System.Windows.Forms.Button();
            this.usertxt = new System.Windows.Forms.Label();
            this.products_tableTableAdapter = new pharma_manage.DataSet1TableAdapters.products_tableTableAdapter();
            this.categoryTableAdapter = new pharma_manage.DataSet1TableAdapters.CategoryTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.proIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pronameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procostpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probee3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_txt = new System.Windows.Forms.ComboBox();
            this.stocktableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pieces_in_packet_txt = new System.Windows.Forms.TextBox();
            this.stock_tableTableAdapter = new pharma_manage.DataSet1TableAdapters.stock_tableTableAdapter();
            this.dataSet11 = new pharma_manage.DataSet1();
            this.int_code_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bee3_txt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.basic_profit_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.company_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.site_txt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.picture_txt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.discount_nesba_txt = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.bee3_gomla_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productstableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocktableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1162, 16);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(87, 14);
            this.label2.TabIndex = 127;
            this.label2.Text = "اســم الصنــف";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // name_txt
            // 
            this.name_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txt.Location = new System.Drawing.Point(626, 10);
            this.name_txt.Name = "name_txt";
            this.name_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_txt.Size = new System.Drawing.Size(533, 22);
            this.name_txt.TabIndex = 0;
            this.name_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(517, 16);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(69, 14);
            this.label1.TabIndex = 129;
            this.label1.Text = "فئة الصنف";
            // 
            // cost_txt
            // 
            this.cost_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cost_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost_txt.Location = new System.Drawing.Point(626, 56);
            this.cost_txt.Name = "cost_txt";
            this.cost_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cost_txt.Size = new System.Drawing.Size(213, 22);
            this.cost_txt.TabIndex = 4;
            this.cost_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cost_txt.TextChanged += new System.EventHandler(this.cost_txt_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(845, 59);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(77, 14);
            this.label3.TabIndex = 131;
            this.label3.Text = "سعر التكلفة";
            // 
            // limit_txt
            // 
            this.limit_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.limit_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limit_txt.Location = new System.Drawing.Point(959, 90);
            this.limit_txt.Name = "limit_txt";
            this.limit_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.limit_txt.Size = new System.Drawing.Size(200, 22);
            this.limit_txt.TabIndex = 7;
            this.limit_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1160, 93);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(71, 14);
            this.label5.TabIndex = 135;
            this.label5.Text = "الحد الأدنى";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1168, 59);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(43, 14);
            this.label7.TabIndex = 139;
            this.label7.Text = "الكمية";
            // 
            // count_txt
            // 
            this.count_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.count_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count_txt.Location = new System.Drawing.Point(959, 56);
            this.count_txt.Name = "count_txt";
            this.count_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.count_txt.Size = new System.Drawing.Size(200, 22);
            this.count_txt.TabIndex = 3;
            this.count_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // category_txt
            // 
            this.category_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.category_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.category_txt.FormattingEnabled = true;
            this.category_txt.Location = new System.Drawing.Point(333, 12);
            this.category_txt.Name = "category_txt";
            this.category_txt.Size = new System.Drawing.Size(178, 22);
            this.category_txt.TabIndex = 1;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(495, 96);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(69, 14);
            this.label9.TabIndex = 154;
            this.label9.Text = "ملاحــــظات";
            // 
            // notes_txt
            // 
            this.notes_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.notes_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notes_txt.Location = new System.Drawing.Point(230, 93);
            this.notes_txt.Name = "notes_txt";
            this.notes_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.notes_txt.Size = new System.Drawing.Size(263, 22);
            this.notes_txt.TabIndex = 9;
            this.notes_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // productstableBindingSource
            // 
            this.productstableBindingSource.DataMember = "products_table";
            this.productstableBindingSource.DataSource = this.dataSet1;
            // 
            // save_btn
            // 
            this.save_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.save_btn.BackColor = System.Drawing.Color.Green;
            this.save_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.save_btn.FlatAppearance.BorderSize = 2;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.save_btn.Location = new System.Drawing.Point(518, 181);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(224, 34);
            this.save_btn.TabIndex = 11;
            this.save_btn.Text = "إضافة الصنف";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // usertxt
            // 
            this.usertxt.AutoSize = true;
            this.usertxt.Location = new System.Drawing.Point(273, 133);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(27, 13);
            this.usertxt.TabIndex = 123231;
            this.usertxt.Text = "user";
            this.usertxt.Visible = false;
            // 
            // products_tableTableAdapter
            // 
            this.products_tableTableAdapter.ClearBeforeFill = true;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 123232;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 123233;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proIDDataGridViewTextBoxColumn,
            this.pronameDataGridViewTextBoxColumn,
            this.pro_stock,
            this.procostpriceDataGridViewTextBoxColumn,
            this.probee3DataGridViewTextBoxColumn,
            this.procountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productstableBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.Location = new System.Drawing.Point(18, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.Size = new System.Drawing.Size(1225, 329);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // proIDDataGridViewTextBoxColumn
            // 
            this.proIDDataGridViewTextBoxColumn.DataPropertyName = "pro_ID";
            this.proIDDataGridViewTextBoxColumn.HeaderText = "كود الصنف";
            this.proIDDataGridViewTextBoxColumn.Name = "proIDDataGridViewTextBoxColumn";
            this.proIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.proIDDataGridViewTextBoxColumn.Width = 120;
            // 
            // pronameDataGridViewTextBoxColumn
            // 
            this.pronameDataGridViewTextBoxColumn.DataPropertyName = "pro_name";
            this.pronameDataGridViewTextBoxColumn.HeaderText = "اسم الصنف";
            this.pronameDataGridViewTextBoxColumn.Name = "pronameDataGridViewTextBoxColumn";
            this.pronameDataGridViewTextBoxColumn.ReadOnly = true;
            this.pronameDataGridViewTextBoxColumn.Width = 300;
            // 
            // pro_stock
            // 
            this.pro_stock.DataPropertyName = "pro_stock";
            this.pro_stock.HeaderText = "المخزن";
            this.pro_stock.Name = "pro_stock";
            this.pro_stock.ReadOnly = true;
            this.pro_stock.Width = 120;
            // 
            // procostpriceDataGridViewTextBoxColumn
            // 
            this.procostpriceDataGridViewTextBoxColumn.DataPropertyName = "pro_cost_price";
            this.procostpriceDataGridViewTextBoxColumn.HeaderText = "سعر الشراء";
            this.procostpriceDataGridViewTextBoxColumn.Name = "procostpriceDataGridViewTextBoxColumn";
            this.procostpriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // probee3DataGridViewTextBoxColumn
            // 
            this.probee3DataGridViewTextBoxColumn.DataPropertyName = "pro_bee3";
            this.probee3DataGridViewTextBoxColumn.HeaderText = "سعر البيع";
            this.probee3DataGridViewTextBoxColumn.Name = "probee3DataGridViewTextBoxColumn";
            this.probee3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // procountDataGridViewTextBoxColumn
            // 
            this.procountDataGridViewTextBoxColumn.DataPropertyName = "pro_count";
            this.procountDataGridViewTextBoxColumn.HeaderText = "الكمية";
            this.procountDataGridViewTextBoxColumn.Name = "procountDataGridViewTextBoxColumn";
            this.procountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stock_txt
            // 
            this.stock_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.stock_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.stock_txt.FormattingEnabled = true;
            this.stock_txt.Location = new System.Drawing.Point(51, 12);
            this.stock_txt.Name = "stock_txt";
            this.stock_txt.Size = new System.Drawing.Size(180, 22);
            this.stock_txt.TabIndex = 2;
            // 
            // stocktableBindingSource
            // 
            this.stocktableBindingSource.DataMember = "stock_table";
            this.stocktableBindingSource.DataSource = this.dataSet1;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(237, 16);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(47, 14);
            this.label11.TabIndex = 123237;
            this.label11.Text = "المخزن";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(401, 152);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(116, 14);
            this.label12.TabIndex = 123239;
            this.label12.Text = "الوحدات في العبوه";
            this.label12.Visible = false;
            // 
            // pieces_in_packet_txt
            // 
            this.pieces_in_packet_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pieces_in_packet_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pieces_in_packet_txt.Location = new System.Drawing.Point(184, 149);
            this.pieces_in_packet_txt.Name = "pieces_in_packet_txt";
            this.pieces_in_packet_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pieces_in_packet_txt.Size = new System.Drawing.Size(213, 22);
            this.pieces_in_packet_txt.TabIndex = 5;
            this.pieces_in_packet_txt.Text = "1";
            this.pieces_in_packet_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pieces_in_packet_txt.Visible = false;
            // 
            // stock_tableTableAdapter
            // 
            this.stock_tableTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // int_code_txt
            // 
            this.int_code_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.int_code_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.int_code_txt.Location = new System.Drawing.Point(451, 133);
            this.int_code_txt.Name = "int_code_txt";
            this.int_code_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.int_code_txt.Size = new System.Drawing.Size(298, 22);
            this.int_code_txt.TabIndex = 10;
            this.int_code_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(755, 136);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(54, 14);
            this.label8.TabIndex = 123241;
            this.label8.Text = "الكــــــود";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(515, 59);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(71, 14);
            this.label10.TabIndex = 123243;
            this.label10.Text = "بيع قطاعي";
            // 
            // bee3_txt
            // 
            this.bee3_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bee3_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bee3_txt.Location = new System.Drawing.Point(331, 56);
            this.bee3_txt.Name = "bee3_txt";
            this.bee3_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bee3_txt.Size = new System.Drawing.Size(175, 22);
            this.bee3_txt.TabIndex = 5;
            this.bee3_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bee3_txt.TextChanged += new System.EventHandler(this.gomla_gomla_txt_TextChanged);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1184, 172);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(78, 14);
            this.label13.TabIndex = 123245;
            this.label13.Text = "ربح اساسي";
            this.label13.Visible = false;
            // 
            // basic_profit_txt
            // 
            this.basic_profit_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.basic_profit_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basic_profit_txt.Location = new System.Drawing.Point(998, 166);
            this.basic_profit_txt.Name = "basic_profit_txt";
            this.basic_profit_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.basic_profit_txt.Size = new System.Drawing.Size(180, 22);
            this.basic_profit_txt.TabIndex = 10;
            this.basic_profit_txt.Text = "0";
            this.basic_profit_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.basic_profit_txt.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1052, 127);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(50, 14);
            this.label4.TabIndex = 123247;
            this.label4.Text = "الشركة";
            this.label4.Visible = false;
            // 
            // company_txt
            // 
            this.company_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.company_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company_txt.Location = new System.Drawing.Point(845, 124);
            this.company_txt.Name = "company_txt";
            this.company_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.company_txt.Size = new System.Drawing.Size(200, 22);
            this.company_txt.TabIndex = 9;
            this.company_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.company_txt.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(858, 96);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(43, 14);
            this.label6.TabIndex = 123249;
            this.label6.Text = "المكان";
            // 
            // site_txt
            // 
            this.site_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.site_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.site_txt.Location = new System.Drawing.Point(626, 93);
            this.site_txt.Name = "site_txt";
            this.site_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.site_txt.Size = new System.Drawing.Size(213, 22);
            this.site_txt.TabIndex = 8;
            this.site_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1160, 160);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label14.Size = new System.Drawing.Size(80, 14);
            this.label14.TabIndex = 123251;
            this.label14.Text = "صورة الصنف";
            this.label14.Visible = false;
            // 
            // picture_txt
            // 
            this.picture_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picture_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picture_txt.Location = new System.Drawing.Point(673, 157);
            this.picture_txt.Name = "picture_txt";
            this.picture_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.picture_txt.Size = new System.Drawing.Size(481, 22);
            this.picture_txt.TabIndex = 123250;
            this.picture_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.picture_txt.Visible = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(216, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 28);
            this.button2.TabIndex = 12;
            this.button2.Text = "اختر صورة الصنف";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(612, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 18);
            this.label15.TabIndex = 123252;
            this.label15.Text = "*";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(320, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(18, 18);
            this.label16.TabIndex = 123253;
            this.label16.Text = "*";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(37, 14);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(18, 18);
            this.label17.TabIndex = 123254;
            this.label17.Text = "*";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(947, 60);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(18, 18);
            this.label18.TabIndex = 123255;
            this.label18.Text = "*";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(612, 59);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(18, 18);
            this.label19.TabIndex = 123256;
            this.label19.Text = "*";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(43, 60);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(18, 18);
            this.label20.TabIndex = 123257;
            this.label20.Text = "*";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(312, 59);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(18, 18);
            this.label21.TabIndex = 123258;
            this.label21.Text = "*";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(1043, 186);
            this.label22.Name = "label22";
            this.label22.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label22.Size = new System.Drawing.Size(206, 14);
            this.label22.TabIndex = 123259;
            this.label22.Text = "البيانات المتبوعة ب * لا تترك فارغة";
            // 
            // label29
            // 
            this.label29.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(1141, 136);
            this.label29.Name = "label29";
            this.label29.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label29.Size = new System.Drawing.Size(80, 14);
            this.label29.TabIndex = 123305;
            this.label29.Text = "نسبة الخصم";
            // 
            // discount_nesba_txt
            // 
            this.discount_nesba_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.discount_nesba_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount_nesba_txt.Location = new System.Drawing.Point(957, 133);
            this.discount_nesba_txt.Name = "discount_nesba_txt";
            this.discount_nesba_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.discount_nesba_txt.Size = new System.Drawing.Size(178, 22);
            this.discount_nesba_txt.TabIndex = 13;
            this.discount_nesba_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.discount_nesba_txt.TextChanged += new System.EventHandler(this.discount_nesba_txt_TextChanged);
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label23.ForeColor = System.Drawing.Color.Red;
            this.label23.Location = new System.Drawing.Point(946, 94);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(18, 18);
            this.label23.TabIndex = 123306;
            this.label23.Text = "*";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(240, 59);
            this.label24.Name = "label24";
            this.label24.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label24.Size = new System.Drawing.Size(58, 14);
            this.label24.TabIndex = 123308;
            this.label24.Text = "بيع جملة";
            // 
            // bee3_gomla_txt
            // 
            this.bee3_gomla_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bee3_gomla_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bee3_gomla_txt.Location = new System.Drawing.Point(56, 56);
            this.bee3_gomla_txt.Name = "bee3_gomla_txt";
            this.bee3_gomla_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bee3_gomla_txt.Size = new System.Drawing.Size(175, 22);
            this.bee3_gomla_txt.TabIndex = 6;
            this.bee3_gomla_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // add_product
            // 
            this.AcceptButton = this.save_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1261, 554);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.bee3_gomla_txt);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.discount_nesba_txt);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.picture_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.site_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.company_txt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.basic_profit_txt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bee3_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.int_code_txt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pieces_in_packet_txt);
            this.Controls.Add(this.stock_txt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.notes_txt);
            this.Controls.Add(this.category_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.count_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.limit_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cost_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label23);
            this.Name = "add_product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add_product";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.add_product_FormClosing);
            this.Load += new System.EventHandler(this.add_product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productstableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocktableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_txt;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cost_txt;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox limit_txt;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox count_txt;
        private System.Windows.Forms.ComboBox category_txt;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox notes_txt;
        private System.Windows.Forms.Button save_btn;
        public System.Windows.Forms.Label usertxt;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource productstableBindingSource;
        private DataSet1TableAdapters.products_tableTableAdapter products_tableTableAdapter;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private DataSet1TableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox pieces_in_packet_txt;
        private System.Windows.Forms.BindingSource stocktableBindingSource;
        private DataSet1TableAdapters.stock_tableTableAdapter stock_tableTableAdapter;
        private DataSet1 dataSet11;
        private System.Windows.Forms.TextBox int_code_txt;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox bee3_txt;
        public System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox basic_profit_txt;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox company_txt;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox site_txt;
        public System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox picture_txt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridViewTextBoxColumn proIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pronameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn procostpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn probee3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn procountDataGridViewTextBoxColumn;
        public System.Windows.Forms.ComboBox stock_txt;
        public System.Windows.Forms.Label label22;
        public System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox discount_nesba_txt;
        private System.Windows.Forms.Label label23;
        public System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox bee3_gomla_txt;
         }
}