namespace pharma_manage
{
    partial class select_printer_kashf_7esab
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
            this.button_WOC2 = new System.Windows.Forms.Button();
            this.button_WOC1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.a5_print = new System.Windows.Forms.RadioButton();
            this.reset_print = new System.Windows.Forms.RadioButton();
            this.a4_print = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cst_name_txt = new System.Windows.Forms.Label();
            this.mosta7akattableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new pharma_manage.DataSet1();
            this.mosta7akat_tableTableAdapter = new pharma_manage.DataSet1TableAdapters.mosta7akat_tableTableAdapter();
            this.pharmacy_dataTableAdapter1 = new pharma_manage.DataSet1TableAdapters.pharmacy_dataTableAdapter();
            this.kashf_7esab_report1 = new pharma_manage.kashf_7esab_report();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.kashf_7esab_report_reset1 = new pharma_manage.kashf_7esab_report_reset();
            this.kashf_7esab_report_a51 = new pharma_manage.kashf_7esab_report_a5();
            this.kashf_7esab_report_a52 = new pharma_manage.kashf_7esab_report_a5();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mosta7akattableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_WOC2
            // 
            this.button_WOC2.BackColor = System.Drawing.Color.Red;
            this.button_WOC2.FlatAppearance.BorderSize = 0;
            this.button_WOC2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC2.Location = new System.Drawing.Point(65, 109);
            this.button_WOC2.Margin = new System.Windows.Forms.Padding(2);
            this.button_WOC2.Name = "button_WOC2";
            this.button_WOC2.Size = new System.Drawing.Size(149, 50);
            this.button_WOC2.TabIndex = 2;
            this.button_WOC2.Text = "لا";
            this.button_WOC2.UseVisualStyleBackColor = false;
            this.button_WOC2.Click += new System.EventHandler(this.button_WOC2_Click);
            // 
            // button_WOC1
            // 
            this.button_WOC1.BackColor = System.Drawing.Color.Green;
            this.button_WOC1.FlatAppearance.BorderSize = 0;
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC1.Location = new System.Drawing.Point(278, 109);
            this.button_WOC1.Margin = new System.Windows.Forms.Padding(2);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.Size = new System.Drawing.Size(149, 50);
            this.button_WOC1.TabIndex = 0;
            this.button_WOC1.Text = "طباعة";
            this.button_WOC1.UseVisualStyleBackColor = false;
            this.button_WOC1.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.a5_print);
            this.groupBox1.Controls.Add(this.reset_print);
            this.groupBox1.Controls.Add(this.a4_print);
            this.groupBox1.Location = new System.Drawing.Point(6, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 84);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // a5_print
            // 
            this.a5_print.AutoSize = true;
            this.a5_print.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.a5_print.Location = new System.Drawing.Point(208, 39);
            this.a5_print.Name = "a5_print";
            this.a5_print.Size = new System.Drawing.Size(91, 22);
            this.a5_print.TabIndex = 2;
            this.a5_print.Text = "A5 فاتورة";
            this.a5_print.UseVisualStyleBackColor = true;
            // 
            // reset_print
            // 
            this.reset_print.AutoSize = true;
            this.reset_print.Checked = true;
            this.reset_print.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.reset_print.Location = new System.Drawing.Point(47, 39);
            this.reset_print.Name = "reset_print";
            this.reset_print.Size = new System.Drawing.Size(85, 22);
            this.reset_print.TabIndex = 1;
            this.reset_print.TabStop = true;
            this.reset_print.Text = "فواتيـــــر";
            this.reset_print.UseVisualStyleBackColor = true;
            // 
            // a4_print
            // 
            this.a4_print.AutoSize = true;
            this.a4_print.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.a4_print.Location = new System.Drawing.Point(375, 39);
            this.a4_print.Name = "a4_print";
            this.a4_print.Size = new System.Drawing.Size(91, 22);
            this.a4_print.TabIndex = 0;
            this.a4_print.Text = "A4 فاتورة";
            this.a4_print.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(432, 103);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 123255;
            this.listBox1.Visible = false;
            // 
            // cst_name_txt
            // 
            this.cst_name_txt.AutoSize = true;
            this.cst_name_txt.Location = new System.Drawing.Point(219, 146);
            this.cst_name_txt.Name = "cst_name_txt";
            this.cst_name_txt.Size = new System.Drawing.Size(35, 13);
            this.cst_name_txt.TabIndex = 123256;
            this.cst_name_txt.Text = "label1";
            this.cst_name_txt.Visible = false;
            // 
            // mosta7akattableBindingSource
            // 
            this.mosta7akattableBindingSource.DataMember = "mosta7akat_table";
            this.mosta7akattableBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mosta7akat_tableTableAdapter
            // 
            this.mosta7akat_tableTableAdapter.ClearBeforeFill = true;
            // 
            // pharmacy_dataTableAdapter1
            // 
            this.pharmacy_dataTableAdapter1.ClearBeforeFill = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(36, 79);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 123289;
            this.dateTimePicker2.Value = new System.DateTime(2015, 9, 21, 0, 0, 0, 0);
            this.dateTimePicker2.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(289, 79);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 123288;
            this.dateTimePicker1.Value = new System.DateTime(2015, 9, 21, 0, 0, 0, 0);
            this.dateTimePicker1.Visible = false;
            // 
            // select_printer_kashf_7esab
            // 
            this.AcceptButton = this.button_WOC1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 181);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cst_name_txt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_WOC1);
            this.Controls.Add(this.button_WOC2);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "select_printer_kashf_7esab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "select_printer";
            this.Load += new System.EventHandler(this.select_printer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mosta7akattableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_WOC2;
        private System.Windows.Forms.Button button_WOC1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton a5_print;
        private System.Windows.Forms.RadioButton reset_print;
        private System.Windows.Forms.RadioButton a4_print;
        //  private CrystalReport1 crystalReport11;
        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.Label cst_name_txt;
        private System.Windows.Forms.BindingSource mosta7akattableBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.mosta7akat_tableTableAdapter mosta7akat_tableTableAdapter;
        private DataSet1TableAdapters.pharmacy_dataTableAdapter pharmacy_dataTableAdapter1;
        private kashf_7esab_report kashf_7esab_report1;
        public System.Windows.Forms.DateTimePicker dateTimePicker2;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private kashf_7esab_report_reset kashf_7esab_report_reset1;
        private kashf_7esab_report_a5 kashf_7esab_report_a51;
        private kashf_7esab_report_a5 kashf_7esab_report_a52;
    }
}