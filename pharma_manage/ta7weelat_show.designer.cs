namespace pharma_manage
{
    partial class ta7weelat_show
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ta7weelat_show));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ta7weelnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ta7weeldateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ta7weelfromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ta7weeltoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ta7weelprocodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ta7weelpronameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ta7weelcountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ta7weel_pro_unit_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ta7weel_pro_price_forall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ta7weeluserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ta7weeltableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new pharma_manage.DataSet1();
            this.ta7weel_tableTableAdapter = new pharma_manage.DataSet1TableAdapters.ta7weel_tableTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pharmacy_dataTableAdapter1 = new pharma_manage.DataSet1TableAdapters.pharmacy_dataTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.salesID_TXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.matloobTXT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.a4_ta7weel_crystal_report1 = new pharma_manage.a4_ta7weel_crystal_report();
            this.a5_ta7weel_crystal_report1 = new pharma_manage.a5_ta7weel_crystal_report();
            this.reciept_ta7weel_crystal_report1 = new pharma_manage.reciept_ta7weel_crystal_report();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ta7weeltableBindingSource)).BeginInit();
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
            this.ta7weelnumberDataGridViewTextBoxColumn,
            this.ta7weeldateDataGridViewTextBoxColumn,
            this.ta7weelfromDataGridViewTextBoxColumn,
            this.ta7weeltoDataGridViewTextBoxColumn,
            this.ta7weelprocodeDataGridViewTextBoxColumn,
            this.ta7weelpronameDataGridViewTextBoxColumn,
            this.ta7weelcountDataGridViewTextBoxColumn,
            this.ta7weel_pro_unit_price,
            this.ta7weel_pro_price_forall,
            this.ta7weeluserDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ta7weeltableBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(36, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(1190, 399);
            this.dataGridView1.TabIndex = 123237;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // ta7weelnumberDataGridViewTextBoxColumn
            // 
            this.ta7weelnumberDataGridViewTextBoxColumn.DataPropertyName = "ta7weel_number";
            this.ta7weelnumberDataGridViewTextBoxColumn.HeaderText = "رقم التحويل";
            this.ta7weelnumberDataGridViewTextBoxColumn.Name = "ta7weelnumberDataGridViewTextBoxColumn";
            this.ta7weelnumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ta7weeldateDataGridViewTextBoxColumn
            // 
            this.ta7weeldateDataGridViewTextBoxColumn.DataPropertyName = "ta7weel_date";
            this.ta7weeldateDataGridViewTextBoxColumn.HeaderText = "التاريخ";
            this.ta7weeldateDataGridViewTextBoxColumn.Name = "ta7weeldateDataGridViewTextBoxColumn";
            this.ta7weeldateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ta7weelfromDataGridViewTextBoxColumn
            // 
            this.ta7weelfromDataGridViewTextBoxColumn.DataPropertyName = "ta7weel_from";
            this.ta7weelfromDataGridViewTextBoxColumn.HeaderText = "من";
            this.ta7weelfromDataGridViewTextBoxColumn.Name = "ta7weelfromDataGridViewTextBoxColumn";
            this.ta7weelfromDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ta7weeltoDataGridViewTextBoxColumn
            // 
            this.ta7weeltoDataGridViewTextBoxColumn.DataPropertyName = "ta7weel_to";
            this.ta7weeltoDataGridViewTextBoxColumn.HeaderText = "الى";
            this.ta7weeltoDataGridViewTextBoxColumn.Name = "ta7weeltoDataGridViewTextBoxColumn";
            this.ta7weeltoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ta7weelprocodeDataGridViewTextBoxColumn
            // 
            this.ta7weelprocodeDataGridViewTextBoxColumn.DataPropertyName = "ta7weel_pro_code";
            this.ta7weelprocodeDataGridViewTextBoxColumn.HeaderText = "كود الصنف";
            this.ta7weelprocodeDataGridViewTextBoxColumn.Name = "ta7weelprocodeDataGridViewTextBoxColumn";
            this.ta7weelprocodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.ta7weelprocodeDataGridViewTextBoxColumn.Width = 130;
            // 
            // ta7weelpronameDataGridViewTextBoxColumn
            // 
            this.ta7weelpronameDataGridViewTextBoxColumn.DataPropertyName = "ta7weel_pro_name";
            this.ta7weelpronameDataGridViewTextBoxColumn.HeaderText = "اسم الصنف";
            this.ta7weelpronameDataGridViewTextBoxColumn.Name = "ta7weelpronameDataGridViewTextBoxColumn";
            this.ta7weelpronameDataGridViewTextBoxColumn.ReadOnly = true;
            this.ta7weelpronameDataGridViewTextBoxColumn.Width = 150;
            // 
            // ta7weelcountDataGridViewTextBoxColumn
            // 
            this.ta7weelcountDataGridViewTextBoxColumn.DataPropertyName = "ta7weel_count";
            this.ta7weelcountDataGridViewTextBoxColumn.HeaderText = "الكمية";
            this.ta7weelcountDataGridViewTextBoxColumn.Name = "ta7weelcountDataGridViewTextBoxColumn";
            this.ta7weelcountDataGridViewTextBoxColumn.ReadOnly = true;
            this.ta7weelcountDataGridViewTextBoxColumn.Width = 130;
            // 
            // ta7weel_pro_unit_price
            // 
            this.ta7weel_pro_unit_price.DataPropertyName = "ta7weel_pro_unit_price";
            this.ta7weel_pro_unit_price.HeaderText = "سعر الوحدة";
            this.ta7weel_pro_unit_price.Name = "ta7weel_pro_unit_price";
            this.ta7weel_pro_unit_price.ReadOnly = true;
            // 
            // ta7weel_pro_price_forall
            // 
            this.ta7weel_pro_price_forall.DataPropertyName = "ta7weel_pro_price_forall";
            this.ta7weel_pro_price_forall.HeaderText = "اجمالي";
            this.ta7weel_pro_price_forall.Name = "ta7weel_pro_price_forall";
            this.ta7weel_pro_price_forall.ReadOnly = true;
            // 
            // ta7weeluserDataGridViewTextBoxColumn
            // 
            this.ta7weeluserDataGridViewTextBoxColumn.DataPropertyName = "ta7weel_user";
            this.ta7weeluserDataGridViewTextBoxColumn.HeaderText = "المستخدم";
            this.ta7weeluserDataGridViewTextBoxColumn.Name = "ta7weeluserDataGridViewTextBoxColumn";
            this.ta7weeluserDataGridViewTextBoxColumn.ReadOnly = true;
            this.ta7weeluserDataGridViewTextBoxColumn.Width = 130;
            // 
            // ta7weeltableBindingSource
            // 
            this.ta7weeltableBindingSource.DataMember = "ta7weel_table";
            this.ta7weeltableBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ta7weel_tableTableAdapter
            // 
            this.ta7weel_tableTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(434, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 14);
            this.label4.TabIndex = 123241;
            this.label4.Text = "إلــــى";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(686, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 14);
            this.label3.TabIndex = 123240;
            this.label3.Text = "من";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(227, 13);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 2;
            this.dateTimePicker2.Value = new System.DateTime(2015, 9, 21, 0, 0, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(480, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2015, 9, 21, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // pharmacy_dataTableAdapter1
            // 
            this.pharmacy_dataTableAdapter1.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 123242;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // salesID_TXT
            // 
            this.salesID_TXT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.salesID_TXT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesID_TXT.Location = new System.Drawing.Point(740, 14);
            this.salesID_TXT.Name = "salesID_TXT";
            this.salesID_TXT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.salesID_TXT.Size = new System.Drawing.Size(161, 22);
            this.salesID_TXT.TabIndex = 0;
            this.salesID_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.salesID_TXT.TextChanged += new System.EventHandler(this.salesID_TXT_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(907, 17);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(97, 14);
            this.label5.TabIndex = 123244;
            this.label5.Text = "رقم امر التحويل";
            // 
            // matloobTXT
            // 
            this.matloobTXT.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.matloobTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.matloobTXT.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Bold);
            this.matloobTXT.Location = new System.Drawing.Point(496, 446);
            this.matloobTXT.Name = "matloobTXT";
            this.matloobTXT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.matloobTXT.Size = new System.Drawing.Size(214, 27);
            this.matloobTXT.TabIndex = 123246;
            this.matloobTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(716, 452);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(50, 14);
            this.label8.TabIndex = 123245;
            this.label8.Text = "اجمالي";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ta7weelat_show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 475);
            this.Controls.Add(this.matloobTXT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.salesID_TXT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ta7weelat_show";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عرض اوامر التحويل";
            this.Load += new System.EventHandler(this.ta7weelat_show_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ta7weeltableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource ta7weeltableBindingSource;
        private DataSet1TableAdapters.ta7weel_tableTableAdapter ta7weel_tableTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DataSet1TableAdapters.pharmacy_dataTableAdapter pharmacy_dataTableAdapter1;
        private a5_ta7weel_crystal_report a5_ta7weel_crystal_report1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox salesID_TXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ta7weelnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ta7weeldateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ta7weelfromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ta7weeltoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ta7weelprocodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ta7weelpronameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ta7weelcountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ta7weel_pro_unit_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ta7weel_pro_price_forall;
        private System.Windows.Forms.DataGridViewTextBoxColumn ta7weeluserDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox matloobTXT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private a4_ta7weel_crystal_report a4_ta7weel_crystal_report1;
        private reciept_ta7weel_crystal_report reciept_ta7weel_crystal_report1;
    }
}