namespace pharma_manage
{
    partial class serials_form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(serials_form));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.serialidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialproidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialpronameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialserialnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serial_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serial_last_update_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialtableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new pharma_manage.DataSet1();
            this.label2 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.raseed_txt = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.usertxt = new System.Windows.Forms.Label();
            this.serial_tableTableAdapter = new pharma_manage.DataSet1TableAdapters.serial_tableTableAdapter();
            this.products_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.products_tableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialtableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialidDataGridViewTextBoxColumn,
            this.serialproidDataGridViewTextBoxColumn,
            this.serialpronameDataGridViewTextBoxColumn,
            this.serialserialnoDataGridViewTextBoxColumn,
            this.serial_user,
            this.serial_last_update_date});
            this.dataGridView1.DataSource = this.serialtableBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(28, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(1067, 383);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
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
            // serial_user
            // 
            this.serial_user.DataPropertyName = "serial_user";
            this.serial_user.HeaderText = "المستخدم";
            this.serial_user.Name = "serial_user";
            this.serial_user.ReadOnly = true;
            this.serial_user.Width = 150;
            // 
            // serial_last_update_date
            // 
            this.serial_last_update_date.DataPropertyName = "serial_last_update_date";
            dataGridViewCellStyle2.Format = "d";
            this.serial_last_update_date.DefaultCellStyle = dataGridViewCellStyle2;
            this.serial_last_update_date.HeaderText = "تاريخ الاضافة او اخر تعديل";
            this.serial_last_update_date.Name = "serial_last_update_date";
            this.serial_last_update_date.ReadOnly = true;
            this.serial_last_update_date.Width = 180;
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
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(624, 19);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(192, 14);
            this.label2.TabIndex = 123239;
            this.label2.Text = "اسم الصنف او الكود او السيريال";
            // 
            // name_txt
            // 
            this.name_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txt.Location = new System.Drawing.Point(306, 16);
            this.name_txt.Name = "name_txt";
            this.name_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_txt.Size = new System.Drawing.Size(316, 22);
            this.name_txt.TabIndex = 0;
            this.name_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.name_txt_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 123240;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(684, 437);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 14);
            this.label13.TabIndex = 123242;
            this.label13.Text = "العدد";
            // 
            // raseed_txt
            // 
            this.raseed_txt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.raseed_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.raseed_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raseed_txt.Location = new System.Drawing.Point(402, 433);
            this.raseed_txt.Name = "raseed_txt";
            this.raseed_txt.ReadOnly = true;
            this.raseed_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.raseed_txt.Size = new System.Drawing.Size(276, 22);
            this.raseed_txt.TabIndex = 123241;
            this.raseed_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // usertxt
            // 
            this.usertxt.AutoSize = true;
            this.usertxt.Location = new System.Drawing.Point(189, 20);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(35, 13);
            this.usertxt.TabIndex = 123243;
            this.usertxt.Text = "admin";
            this.usertxt.Visible = false;
            // 
            // serial_tableTableAdapter
            // 
            this.serial_tableTableAdapter.ClearBeforeFill = true;
            // 
            // products_tableTableAdapter1
            // 
            this.products_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // serials_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 460);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.raseed_txt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "serials_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مراجعة السيريالات";
            this.Load += new System.EventHandler(this.serials_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialtableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource serialtableBindingSource;
        private DataSet1TableAdapters.serial_tableTableAdapter serial_tableTableAdapter;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox raseed_txt;
        private System.Windows.Forms.Timer timer1;
        private DataSet1TableAdapters.products_tableTableAdapter products_tableTableAdapter1;
        public System.Windows.Forms.Label usertxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialproidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialpronameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialserialnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serial_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn serial_last_update_date;
    }
}