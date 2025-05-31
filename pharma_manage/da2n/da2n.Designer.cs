namespace pharma_manage
{
    partial class da2n
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(da2n));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataSet1 = new pharma_manage.DataSet1();
            this.searchbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.search_text = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.egmalyTXT = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.usertxt = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.da2nsmallidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.da2nsmallnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.da2nsmallmatloobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.da2nsmallmadfoo3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.da2nsmallba2yDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.da2nsmallreportsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.da2n_small_reportsTableAdapter = new pharma_manage.DataSet1TableAdapters.da2n_small_reportsTableAdapter();
            this.da2nsmallreportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.far3txt = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.user_previligesTableAdapter1 = new pharma_manage.DataSet1TableAdapters.user_previligesTableAdapter();
            this.mosta7akat_da2neen_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.mosta7akat_da2neen_tableTableAdapter();
            this.deleted_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.deleted_tableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.da2nsmallreportsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.da2nsmallreportsBindingSource)).BeginInit();
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
            this.searchbtn.Location = new System.Drawing.Point(402, 32);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(161, 26);
            this.searchbtn.TabIndex = 97;
            this.searchbtn.Text = "بــــحـــــث";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(576, 10);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 99;
            this.label1.Text = "اسم الدائن";
            // 
            // search_text
            // 
            this.search_text.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.search_text.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_text.Location = new System.Drawing.Point(318, 7);
            this.search_text.Name = "search_text";
            this.search_text.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.search_text.Size = new System.Drawing.Size(258, 22);
            this.search_text.TabIndex = 96;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(536, 556);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(91, 14);
            this.label7.TabIndex = 104;
            this.label7.Text = "إجمالي المبالغ";
            // 
            // egmalyTXT
            // 
            this.egmalyTXT.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.egmalyTXT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.egmalyTXT.Location = new System.Drawing.Point(337, 552);
            this.egmalyTXT.Name = "egmalyTXT";
            this.egmalyTXT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.egmalyTXT.Size = new System.Drawing.Size(197, 22);
            this.egmalyTXT.TabIndex = 103;
            this.egmalyTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(897, 531);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 102;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // usertxt
            // 
            this.usertxt.AutoSize = true;
            this.usertxt.Location = new System.Drawing.Point(111, 13);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(27, 13);
            this.usertxt.TabIndex = 100;
            this.usertxt.Text = "user";
            this.usertxt.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 101;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.da2nsmallidDataGridViewTextBoxColumn,
            this.da2nsmallnameDataGridViewTextBoxColumn,
            this.da2nsmallmatloobDataGridViewTextBoxColumn,
            this.da2nsmallmadfoo3DataGridViewTextBoxColumn,
            this.da2nsmallba2yDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.da2nsmallreportsBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(13, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(938, 464);
            this.dataGridView1.TabIndex = 98;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // da2nsmallidDataGridViewTextBoxColumn
            // 
            this.da2nsmallidDataGridViewTextBoxColumn.DataPropertyName = "da2n_small_id";
            this.da2nsmallidDataGridViewTextBoxColumn.HeaderText = "م";
            this.da2nsmallidDataGridViewTextBoxColumn.Name = "da2nsmallidDataGridViewTextBoxColumn";
            this.da2nsmallidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // da2nsmallnameDataGridViewTextBoxColumn
            // 
            this.da2nsmallnameDataGridViewTextBoxColumn.DataPropertyName = "da2n_small_name";
            this.da2nsmallnameDataGridViewTextBoxColumn.HeaderText = "اسم الدائن";
            this.da2nsmallnameDataGridViewTextBoxColumn.Name = "da2nsmallnameDataGridViewTextBoxColumn";
            this.da2nsmallnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.da2nsmallnameDataGridViewTextBoxColumn.Width = 250;
            // 
            // da2nsmallmatloobDataGridViewTextBoxColumn
            // 
            this.da2nsmallmatloobDataGridViewTextBoxColumn.DataPropertyName = "da2n_small_matloob";
            this.da2nsmallmatloobDataGridViewTextBoxColumn.HeaderText = "المبلغ المطلوب";
            this.da2nsmallmatloobDataGridViewTextBoxColumn.Name = "da2nsmallmatloobDataGridViewTextBoxColumn";
            this.da2nsmallmatloobDataGridViewTextBoxColumn.ReadOnly = true;
            this.da2nsmallmatloobDataGridViewTextBoxColumn.Width = 180;
            // 
            // da2nsmallmadfoo3DataGridViewTextBoxColumn
            // 
            this.da2nsmallmadfoo3DataGridViewTextBoxColumn.DataPropertyName = "da2n_small_madfoo3";
            this.da2nsmallmadfoo3DataGridViewTextBoxColumn.HeaderText = "المبلغ المدفوع";
            this.da2nsmallmadfoo3DataGridViewTextBoxColumn.Name = "da2nsmallmadfoo3DataGridViewTextBoxColumn";
            this.da2nsmallmadfoo3DataGridViewTextBoxColumn.ReadOnly = true;
            this.da2nsmallmadfoo3DataGridViewTextBoxColumn.Width = 180;
            // 
            // da2nsmallba2yDataGridViewTextBoxColumn
            // 
            this.da2nsmallba2yDataGridViewTextBoxColumn.DataPropertyName = "da2n_small_ba2y";
            this.da2nsmallba2yDataGridViewTextBoxColumn.HeaderText = "المبلغ المستحق";
            this.da2nsmallba2yDataGridViewTextBoxColumn.Name = "da2nsmallba2yDataGridViewTextBoxColumn";
            this.da2nsmallba2yDataGridViewTextBoxColumn.ReadOnly = true;
            this.da2nsmallba2yDataGridViewTextBoxColumn.Width = 180;
            // 
            // da2nsmallreportsBindingSource1
            // 
            this.da2nsmallreportsBindingSource1.DataMember = "da2n_small_reports";
            this.da2nsmallreportsBindingSource1.DataSource = this.dataSet1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // da2n_small_reportsTableAdapter
            // 
            this.da2n_small_reportsTableAdapter.ClearBeforeFill = true;
            // 
            // da2nsmallreportsBindingSource
            // 
            this.da2nsmallreportsBindingSource.DataMember = "da2n_small_reports";
            // 
            // far3txt
            // 
            this.far3txt.AutoSize = true;
            this.far3txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.far3txt.Location = new System.Drawing.Point(765, 9);
            this.far3txt.Name = "far3txt";
            this.far3txt.Size = new System.Drawing.Size(32, 14);
            this.far3txt.TabIndex = 123254;
            this.far3txt.Text = "far3";
            this.far3txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.far3txt.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(374, 211);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(222, 173);
            this.listBox1.TabIndex = 123258;
            this.listBox1.Visible = false;
            // 
            // user_previligesTableAdapter1
            // 
            this.user_previligesTableAdapter1.ClearBeforeFill = true;
            // 
            // mosta7akat_da2neen_tableTableAdapter1
            // 
            this.mosta7akat_da2neen_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // deleted_tableTableAdapter1
            // 
            this.deleted_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // da2n
            // 
            this.AcceptButton = this.searchbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 595);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.far3txt);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_text);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.egmalyTXT);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "da2n";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "da2n";
            this.Load += new System.EventHandler(this.da2n_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.da2nsmallreportsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.da2nsmallreportsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search_text;
        private System.Windows.Forms.BindingSource da2nsmallreportsBindingSource;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox egmalyTXT;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label usertxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource da2nsmallreportsBindingSource1;
        private DataSet1TableAdapters.da2n_small_reportsTableAdapter da2n_small_reportsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn da2nsmallidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn da2nsmallnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn da2nsmallmatloobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn da2nsmallmadfoo3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn da2nsmallba2yDataGridViewTextBoxColumn;
        public System.Windows.Forms.Label far3txt;
        private System.Windows.Forms.ListBox listBox1;
        private DataSet1TableAdapters.user_previligesTableAdapter user_previligesTableAdapter1;
        private DataSet1TableAdapters.mosta7akat_da2neen_tableTableAdapter mosta7akat_da2neen_tableTableAdapter1;
        private DataSet1TableAdapters.deleted_tableTableAdapter deleted_tableTableAdapter1;

    }
}