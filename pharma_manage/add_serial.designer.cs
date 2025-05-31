namespace pharma_manage
{
    partial class add_serial
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.products_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.products_tableTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.serialidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialproidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialpronameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialserialnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialtableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new pharma_manage.DataSet1();
            this.serial_tableTableAdapter = new pharma_manage.DataSet1TableAdapters.serial_tableTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.added_serials_txt = new System.Windows.Forms.TextBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.serial_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pro_count_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pro_id_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.usertxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialtableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // products_tableTableAdapter1
            // 
            this.products_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialidDataGridViewTextBoxColumn,
            this.serialproidDataGridViewTextBoxColumn,
            this.serialpronameDataGridViewTextBoxColumn,
            this.serialserialnoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.serialtableBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.Size = new System.Drawing.Size(737, 400);
            this.dataGridView1.TabIndex = 2;
            // 
            // serialidDataGridViewTextBoxColumn
            // 
            this.serialidDataGridViewTextBoxColumn.DataPropertyName = "serial_id";
            this.serialidDataGridViewTextBoxColumn.HeaderText = "م";
            this.serialidDataGridViewTextBoxColumn.Name = "serialidDataGridViewTextBoxColumn";
            this.serialidDataGridViewTextBoxColumn.ReadOnly = true;
            this.serialidDataGridViewTextBoxColumn.Width = 120;
            // 
            // serialproidDataGridViewTextBoxColumn
            // 
            this.serialproidDataGridViewTextBoxColumn.DataPropertyName = "serial_pro_id";
            this.serialproidDataGridViewTextBoxColumn.HeaderText = "كود الصنف";
            this.serialproidDataGridViewTextBoxColumn.Name = "serialproidDataGridViewTextBoxColumn";
            this.serialproidDataGridViewTextBoxColumn.ReadOnly = true;
            this.serialproidDataGridViewTextBoxColumn.Width = 150;
            // 
            // serialpronameDataGridViewTextBoxColumn
            // 
            this.serialpronameDataGridViewTextBoxColumn.DataPropertyName = "serial_pro_name";
            this.serialpronameDataGridViewTextBoxColumn.HeaderText = "اسم الصنف";
            this.serialpronameDataGridViewTextBoxColumn.Name = "serialpronameDataGridViewTextBoxColumn";
            this.serialpronameDataGridViewTextBoxColumn.ReadOnly = true;
            this.serialpronameDataGridViewTextBoxColumn.Width = 220;
            // 
            // serialserialnoDataGridViewTextBoxColumn
            // 
            this.serialserialnoDataGridViewTextBoxColumn.DataPropertyName = "serial_serial_no";
            this.serialserialnoDataGridViewTextBoxColumn.HeaderText = "السيريال";
            this.serialserialnoDataGridViewTextBoxColumn.Name = "serialserialnoDataGridViewTextBoxColumn";
            this.serialserialnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.serialserialnoDataGridViewTextBoxColumn.Width = 200;
            // 
            // serialtableBindingSource
            // 
            this.serialtableBindingSource.DataMember = "serial_table";
            this.serialtableBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serial_tableTableAdapter
            // 
            this.serial_tableTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.added_serials_txt);
            this.groupBox1.Controls.Add(this.addbtn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.serial_txt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pro_count_txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pro_id_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.name_txt);
            this.groupBox1.Location = new System.Drawing.Point(755, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(482, 400);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(354, 317);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(118, 14);
            this.label5.TabIndex = 123250;
            this.label5.Text = "السيريالات المضافة";
            // 
            // added_serials_txt
            // 
            this.added_serials_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.added_serials_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.added_serials_txt.Location = new System.Drawing.Point(55, 314);
            this.added_serials_txt.Name = "added_serials_txt";
            this.added_serials_txt.ReadOnly = true;
            this.added_serials_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.added_serials_txt.Size = new System.Drawing.Size(293, 22);
            this.added_serials_txt.TabIndex = 4;
            this.added_serials_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addbtn
            // 
            this.addbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addbtn.BackColor = System.Drawing.Color.Green;
            this.addbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addbtn.FlatAppearance.BorderSize = 2;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addbtn.Location = new System.Drawing.Point(159, 256);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(165, 26);
            this.addbtn.TabIndex = 3;
            this.addbtn.Text = "إضافة السيريال";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(363, 213);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(57, 14);
            this.label4.TabIndex = 123247;
            this.label4.Text = "السيريال";
            // 
            // serial_txt
            // 
            this.serial_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.serial_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serial_txt.Location = new System.Drawing.Point(54, 210);
            this.serial_txt.Name = "serial_txt";
            this.serial_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.serial_txt.Size = new System.Drawing.Size(293, 22);
            this.serial_txt.TabIndex = 2;
            this.serial_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.serial_txt.Enter += new System.EventHandler(this.serial_txt_Enter);
            this.serial_txt.Leave += new System.EventHandler(this.serial_txt_Leave);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(370, 155);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(43, 14);
            this.label3.TabIndex = 123245;
            this.label3.Text = "الكمية";
            // 
            // pro_count_txt
            // 
            this.pro_count_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pro_count_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pro_count_txt.Location = new System.Drawing.Point(54, 152);
            this.pro_count_txt.Name = "pro_count_txt";
            this.pro_count_txt.ReadOnly = true;
            this.pro_count_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pro_count_txt.Size = new System.Drawing.Size(293, 22);
            this.pro_count_txt.TabIndex = 123244;
            this.pro_count_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 96);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 123243;
            this.label1.Text = "كود الصنف";
            // 
            // pro_id_txt
            // 
            this.pro_id_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pro_id_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pro_id_txt.Location = new System.Drawing.Point(54, 93);
            this.pro_id_txt.Name = "pro_id_txt";
            this.pro_id_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pro_id_txt.Size = new System.Drawing.Size(293, 22);
            this.pro_id_txt.TabIndex = 1;
            this.pro_id_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pro_id_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pro_id_txt_KeyDown);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 43);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(75, 14);
            this.label2.TabIndex = 123241;
            this.label2.Text = "اسم الصنف";
            // 
            // name_txt
            // 
            this.name_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txt.Location = new System.Drawing.Point(54, 40);
            this.name_txt.Name = "name_txt";
            this.name_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_txt.Size = new System.Drawing.Size(293, 22);
            this.name_txt.TabIndex = 0;
            this.name_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name_txt.TextChanged += new System.EventHandler(this.name_txt_TextChanged);
            this.name_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.name_txt_KeyDown);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // usertxt
            // 
            this.usertxt.AutoSize = true;
            this.usertxt.Location = new System.Drawing.Point(895, 9);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(35, 13);
            this.usertxt.TabIndex = 123233;
            this.usertxt.Text = "admin";
            this.usertxt.Visible = false;
            // 
            // add_serial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 448);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "add_serial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة سيريال";
            this.Load += new System.EventHandler(this.add_serial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialtableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1TableAdapters.products_tableTableAdapter products_tableTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource serialtableBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.serial_tableTableAdapter serial_tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialproidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialpronameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialserialnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox serial_txt;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pro_count_txt;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pro_id_txt;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_txt;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox added_serials_txt;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label usertxt;
    }
}