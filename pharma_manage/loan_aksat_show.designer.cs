namespace pharma_manage
{
    partial class loan_aksat_show
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
            this.label2 = new System.Windows.Forms.Label();
            this.user_txt = new System.Windows.Forms.Label();
            this.far3_txt = new System.Windows.Forms.Label();
            this.savebtn = new System.Windows.Forms.Button();
            this.cst_name_txt = new System.Windows.Forms.Label();
            this.aksat_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.aksat_tableTableAdapter();
            this.dataSet11 = new pharma_manage.DataSet1();
            this.loans_requests_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.loans_requests_tableTableAdapter();
            this.customers_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.customersTableAdapter();
            this.byan_7ala_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.byan_7ala_tableTableAdapter();
            this.sales_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.sales_tableTableAdapter();
            this.dataSet12 = new pharma_manage.DataSet1();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.salesproductnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesproductcountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesunitpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salespriceforsellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salestableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reb7_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.taklefa_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nesba_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mo2dema_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.user_previligesTableAdapter1 = new pharma_manage.DataSet1TableAdapters.user_previligesTableAdapter();
            this.a5_fatora_crystal_report1 = new pharma_manage.a5_fatora_crystal_report();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.aksat_show_for_all_report1 = new pharma_manage.aksat_show_for_all_report();
            this.substringAutoCompleteTextBox1 = new pharma_manage.SubstringAutoCompleteTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salestableBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(777, 13);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(123, 14);
            this.label2.TabIndex = 123238;
            this.label2.Text = "اسم العميل او الكود";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // user_txt
            // 
            this.user_txt.AutoSize = true;
            this.user_txt.Location = new System.Drawing.Point(166, 15);
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(28, 13);
            this.user_txt.TabIndex = 123240;
            this.user_txt.Text = "user";
            // 
            // far3_txt
            // 
            this.far3_txt.AutoSize = true;
            this.far3_txt.Location = new System.Drawing.Point(231, 15);
            this.far3_txt.Name = "far3_txt";
            this.far3_txt.Size = new System.Drawing.Size(27, 13);
            this.far3_txt.TabIndex = 123241;
            this.far3_txt.Text = "far3";
            // 
            // savebtn
            // 
            this.savebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.savebtn.BackColor = System.Drawing.Color.Green;
            this.savebtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.savebtn.FlatAppearance.BorderSize = 0;
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.savebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.savebtn.Location = new System.Drawing.Point(139, 11);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(217, 28);
            this.savebtn.TabIndex = 123242;
            this.savebtn.Text = "عرض جميع بيانات الحالة";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Visible = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // cst_name_txt
            // 
            this.cst_name_txt.AutoSize = true;
            this.cst_name_txt.Location = new System.Drawing.Point(866, 14);
            this.cst_name_txt.Name = "cst_name_txt";
            this.cst_name_txt.Size = new System.Drawing.Size(53, 13);
            this.cst_name_txt.TabIndex = 123243;
            this.cst_name_txt.Text = "cst_name";
            this.cst_name_txt.Visible = false;
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
            // loans_requests_tableTableAdapter1
            // 
            this.loans_requests_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // customers_tableTableAdapter1
            // 
            this.customers_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // byan_7ala_tableTableAdapter1
            // 
            this.byan_7ala_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // sales_tableTableAdapter1
            // 
            this.sales_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet12
            // 
            this.dataSet12.DataSetName = "DataSet1";
            this.dataSet12.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salesproductnameDataGridViewTextBoxColumn,
            this.salesproductcountDataGridViewTextBoxColumn,
            this.salesunitpriceDataGridViewTextBoxColumn,
            this.salespriceforsellDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.salestableBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.Enabled = false;
            this.dataGridView2.Location = new System.Drawing.Point(3, 111);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView2.RowHeadersWidth = 20;
            this.dataGridView2.Size = new System.Drawing.Size(489, 402);
            this.dataGridView2.TabIndex = 123270;
            // 
            // salesproductnameDataGridViewTextBoxColumn
            // 
            this.salesproductnameDataGridViewTextBoxColumn.DataPropertyName = "sales_product_name";
            this.salesproductnameDataGridViewTextBoxColumn.HeaderText = "اسم الصنف";
            this.salesproductnameDataGridViewTextBoxColumn.Name = "salesproductnameDataGridViewTextBoxColumn";
            this.salesproductnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.salesproductnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // salesproductcountDataGridViewTextBoxColumn
            // 
            this.salesproductcountDataGridViewTextBoxColumn.DataPropertyName = "sales_product_count";
            this.salesproductcountDataGridViewTextBoxColumn.HeaderText = "الكمية";
            this.salesproductcountDataGridViewTextBoxColumn.Name = "salesproductcountDataGridViewTextBoxColumn";
            this.salesproductcountDataGridViewTextBoxColumn.ReadOnly = true;
            this.salesproductcountDataGridViewTextBoxColumn.Width = 85;
            // 
            // salesunitpriceDataGridViewTextBoxColumn
            // 
            this.salesunitpriceDataGridViewTextBoxColumn.DataPropertyName = "sales_unit_price";
            this.salesunitpriceDataGridViewTextBoxColumn.HeaderText = "الوحدة";
            this.salesunitpriceDataGridViewTextBoxColumn.Name = "salesunitpriceDataGridViewTextBoxColumn";
            this.salesunitpriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.salesunitpriceDataGridViewTextBoxColumn.Width = 110;
            // 
            // salespriceforsellDataGridViewTextBoxColumn
            // 
            this.salespriceforsellDataGridViewTextBoxColumn.DataPropertyName = "sales_price_for_sell";
            this.salespriceforsellDataGridViewTextBoxColumn.HeaderText = "الاجمالي";
            this.salespriceforsellDataGridViewTextBoxColumn.Name = "salespriceforsellDataGridViewTextBoxColumn";
            this.salespriceforsellDataGridViewTextBoxColumn.ReadOnly = true;
            this.salespriceforsellDataGridViewTextBoxColumn.Width = 120;
            // 
            // salestableBindingSource
            // 
            this.salestableBindingSource.DataMember = "sales_table";
            this.salestableBindingSource.DataSource = this.dataSet11;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.reb7_txt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.taklefa_txt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.savebtn);
            this.groupBox1.Controls.Add(this.nesba_txt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mo2dema_txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Location = new System.Drawing.Point(829, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(495, 519);
            this.groupBox1.TabIndex = 123271;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // reb7_txt
            // 
            this.reb7_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.reb7_txt.BackColor = System.Drawing.Color.White;
            this.reb7_txt.Enabled = false;
            this.reb7_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.reb7_txt.ForeColor = System.Drawing.Color.Black;
            this.reb7_txt.Location = new System.Drawing.Point(16, 81);
            this.reb7_txt.Name = "reb7_txt";
            this.reb7_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.reb7_txt.Size = new System.Drawing.Size(160, 22);
            this.reb7_txt.TabIndex = 123278;
            this.reb7_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.reb7_txt.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(192, 84);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(49, 14);
            this.label5.TabIndex = 123279;
            this.label5.Text = "الربـــــح";
            this.label5.Visible = false;
            // 
            // taklefa_txt
            // 
            this.taklefa_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.taklefa_txt.BackColor = System.Drawing.Color.White;
            this.taklefa_txt.Enabled = false;
            this.taklefa_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.taklefa_txt.ForeColor = System.Drawing.Color.Black;
            this.taklefa_txt.Location = new System.Drawing.Point(16, 48);
            this.taklefa_txt.Name = "taklefa_txt";
            this.taklefa_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.taklefa_txt.Size = new System.Drawing.Size(160, 22);
            this.taklefa_txt.TabIndex = 123276;
            this.taklefa_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.taklefa_txt.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(174, 51);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(85, 14);
            this.label4.TabIndex = 123277;
            this.label4.Text = "تكلفة الفاتورة";
            this.label4.Visible = false;
            // 
            // nesba_txt
            // 
            this.nesba_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nesba_txt.BackColor = System.Drawing.Color.White;
            this.nesba_txt.Enabled = false;
            this.nesba_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.nesba_txt.ForeColor = System.Drawing.Color.Black;
            this.nesba_txt.Location = new System.Drawing.Point(272, 81);
            this.nesba_txt.Name = "nesba_txt";
            this.nesba_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nesba_txt.Size = new System.Drawing.Size(160, 22);
            this.nesba_txt.TabIndex = 123274;
            this.nesba_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(438, 84);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(47, 14);
            this.label3.TabIndex = 123275;
            this.label3.Text = "النسبة";
            // 
            // mo2dema_txt
            // 
            this.mo2dema_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mo2dema_txt.BackColor = System.Drawing.Color.White;
            this.mo2dema_txt.Enabled = false;
            this.mo2dema_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.mo2dema_txt.ForeColor = System.Drawing.Color.Black;
            this.mo2dema_txt.Location = new System.Drawing.Point(272, 48);
            this.mo2dema_txt.Name = "mo2dema_txt";
            this.mo2dema_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mo2dema_txt.Size = new System.Drawing.Size(160, 22);
            this.mo2dema_txt.TabIndex = 123272;
            this.mo2dema_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(438, 51);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(52, 14);
            this.label1.TabIndex = 123273;
            this.label1.Text = "المقدمة";
            // 
            // user_previligesTableAdapter1
            // 
            this.user_previligesTableAdapter1.ClearBeforeFill = true;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(5, 40);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.aksat_show_for_all_report1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(820, 519);
            this.crystalReportViewer1.TabIndex = 123239;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.Visible = false;
            // 
            // substringAutoCompleteTextBox1
            // 
            this.substringAutoCompleteTextBox1.AcceptButton = null;
            this.substringAutoCompleteTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.substringAutoCompleteTextBox1.BackColor = System.Drawing.Color.Silver;
            this.substringAutoCompleteTextBox1.Location = new System.Drawing.Point(424, 12);
            this.substringAutoCompleteTextBox1.Name = "substringAutoCompleteTextBox1";
            this.substringAutoCompleteTextBox1.next_textbox = null;
            this.substringAutoCompleteTextBox1.Size = new System.Drawing.Size(347, 22);
            this.substringAutoCompleteTextBox1.TabIndex = 0;
            this.substringAutoCompleteTextBox1.Load += new System.EventHandler(this.substringAutoCompleteTextBox1_Load);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1218, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 123296;
            this.button3.Text = ">>";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 123297;
            this.button4.Text = "<<";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // loan_aksat_show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 571);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.substringAutoCompleteTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cst_name_txt);
            this.Controls.Add(this.far3_txt);
            this.Controls.Add(this.user_txt);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.label2);
            this.KeyPreview = true;
            this.Name = "loan_aksat_show";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عرض سداد عميل";
            this.Load += new System.EventHandler(this.loan_aksat_show_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salestableBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
       
        public System.Windows.Forms.Label user_txt;
        private DataSet1TableAdapters.aksat_tableTableAdapter aksat_tableTableAdapter1;
        private DataSet1 dataSet11;
        private aksat_show_for_all_report aksat_show_for_all_report1;
        public System.Windows.Forms.Label far3_txt;
        private DataSet1TableAdapters.loans_requests_tableTableAdapter loans_requests_tableTableAdapter1;
        private DataSet1TableAdapters.customersTableAdapter customers_tableTableAdapter1;
        public System.Windows.Forms.Button savebtn;
        public System.Windows.Forms.Label cst_name_txt;
        private DataSet1TableAdapters.byan_7ala_tableTableAdapter byan_7ala_tableTableAdapter1;
        private a5_fatora_crystal_report a5_fatora_crystal_report1;
        private DataSet1TableAdapters.sales_tableTableAdapter sales_tableTableAdapter1;
        private DataSet1 dataSet12;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesproductnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesproductcountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesunitpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salespriceforsellDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource salestableBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox nesba_txt;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox mo2dema_txt;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox reb7_txt;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox taklefa_txt;
        public System.Windows.Forms.Label label4;
        private DataSet1TableAdapters.user_previligesTableAdapter user_previligesTableAdapter1;
        public SubstringAutoCompleteTextBox substringAutoCompleteTextBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}