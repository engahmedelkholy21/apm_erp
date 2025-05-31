namespace pharma_manage
{
    partial class select_printer
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
            this.button_WOC2 = new System.Windows.Forms.Button();
            this.button_WOC1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.a5_print = new System.Windows.Forms.RadioButton();
            this.reset_print = new System.Windows.Forms.RadioButton();
            this.a4_print = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.sales_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.sales_tableTableAdapter();
            this.pharmacy_dataTableAdapter1 = new pharma_manage.DataSet1TableAdapters.pharmacy_dataTableAdapter();
            this.dataSet11 = new pharma_manage.DataSet1();
            this.sales_num = new System.Windows.Forms.Label();
            this.madeen_small_reportTableAdapter1 = new pharma_manage.DataSet1TableAdapters.madeen_small_reportTableAdapter();
            this.cst_name_txt = new System.Windows.Forms.Label();
            this.customersTableAdapter1 = new pharma_manage.DataSet1TableAdapters.customersTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorker_print = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker_save_pdf = new System.ComponentModel.BackgroundWorker();
            this.far3txt = new System.Windows.Forms.Label();
            this.type_txt = new System.Windows.Forms.Label();
            this.a5_fatora_crystal_report1 = new pharma_manage.a5_fatora_crystal_report();
            this.a4_fatora1 = new pharma_manage.a4_fatora();
            this.copy_of_CrystalReport11 = new pharma_manage.Copy_of_CrystalReport1();
            this.a5_ezn_fatora_crystal_report1 = new pharma_manage.a5_ezn_fatora_crystal_report();
            this.a4_ezn_fatora1 = new pharma_manage.a4_ezn_fatora();
            this.nesba_or_not_txt = new System.Windows.Forms.Label();
            this.a4_fatora_nesba1 = new pharma_manage.a4_fatora_nesba();
            this.sales_total_txt = new System.Windows.Forms.Label();
            this.backgroundWorker_sms_sending = new System.ComponentModel.BackgroundWorker();
            this.crystalReport11 = new pharma_manage.CrystalReport1();
            this.crystalReport1_pos1 = new pharma_manage.CrystalReport1_pos();
            this.crystalReport1_apm1 = new pharma_manage.CrystalReport1_apm();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // button_WOC2
            // 
            this.button_WOC2.BackColor = System.Drawing.Color.Red;
            this.button_WOC2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_WOC2.FlatAppearance.BorderSize = 0;
            this.button_WOC2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC2.Location = new System.Drawing.Point(29, 104);
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
            this.button_WOC1.Location = new System.Drawing.Point(333, 104);
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
            this.groupBox1.Controls.Add(this.listBox1);
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
            this.listBox1.Location = new System.Drawing.Point(387, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 123255;
            this.listBox1.Visible = false;
            // 
            // sales_tableTableAdapter1
            // 
            this.sales_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // pharmacy_dataTableAdapter1
            // 
            this.pharmacy_dataTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sales_num
            // 
            this.sales_num.AutoSize = true;
            this.sales_num.Location = new System.Drawing.Point(2, 2);
            this.sales_num.Name = "sales_num";
            this.sales_num.Size = new System.Drawing.Size(57, 13);
            this.sales_num.TabIndex = 123254;
            this.sales_num.Text = "sales_num";
            this.sales_num.Visible = false;
            // 
            // madeen_small_reportTableAdapter1
            // 
            this.madeen_small_reportTableAdapter1.ClearBeforeFill = true;
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
            // customersTableAdapter1
            // 
            this.customersTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(181, 104);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 50);
            this.button1.TabIndex = 123257;
            this.button1.Text = "PDF حفظ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundWorker_print
            // 
            this.backgroundWorker_print.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_print_DoWork);
            // 
            // backgroundWorker_save_pdf
            // 
            this.backgroundWorker_save_pdf.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_save_pdf_DoWork);
            // 
            // far3txt
            // 
            this.far3txt.AutoSize = true;
            this.far3txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.far3txt.Location = new System.Drawing.Point(-8, 123);
            this.far3txt.Name = "far3txt";
            this.far3txt.Size = new System.Drawing.Size(32, 14);
            this.far3txt.TabIndex = 123258;
            this.far3txt.Text = "far3";
            this.far3txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.far3txt.Visible = false;
            // 
            // type_txt
            // 
            this.type_txt.AutoSize = true;
            this.type_txt.Location = new System.Drawing.Point(192, 2);
            this.type_txt.Name = "type_txt";
            this.type_txt.Size = new System.Drawing.Size(49, 13);
            this.type_txt.TabIndex = 123259;
            this.type_txt.Text = "type_txt";
            this.type_txt.Visible = false;
            // 
            // nesba_or_not_txt
            // 
            this.nesba_or_not_txt.AutoSize = true;
            this.nesba_or_not_txt.Location = new System.Drawing.Point(270, 2);
            this.nesba_or_not_txt.Name = "nesba_or_not_txt";
            this.nesba_or_not_txt.Size = new System.Drawing.Size(74, 13);
            this.nesba_or_not_txt.TabIndex = 123260;
            this.nesba_or_not_txt.Text = "nesba_or_not";
            this.nesba_or_not_txt.Visible = false;
            // 
            // sales_total_txt
            // 
            this.sales_total_txt.AutoSize = true;
            this.sales_total_txt.Location = new System.Drawing.Point(82, 2);
            this.sales_total_txt.Name = "sales_total_txt";
            this.sales_total_txt.Size = new System.Drawing.Size(79, 13);
            this.sales_total_txt.TabIndex = 123261;
            this.sales_total_txt.Text = "sales_total_txt";
            this.sales_total_txt.Visible = false;
            // 
            // backgroundWorker_sms_sending
            // 
            this.backgroundWorker_sms_sending.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_sms_sending_DoWork);
            // 
            // select_printer
            // 
            this.AcceptButton = this.button_WOC1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_WOC2;
            this.ClientSize = new System.Drawing.Size(525, 181);
            this.Controls.Add(this.sales_total_txt);
            this.Controls.Add(this.nesba_or_not_txt);
            this.Controls.Add(this.type_txt);
            this.Controls.Add(this.far3txt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cst_name_txt);
            this.Controls.Add(this.sales_num);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_WOC1);
            this.Controls.Add(this.button_WOC2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "select_printer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "select_printer";
            this.Load += new System.EventHandler(this.select_printer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
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
        private DataSet1TableAdapters.sales_tableTableAdapter sales_tableTableAdapter1;
        private DataSet1TableAdapters.pharmacy_dataTableAdapter pharmacy_dataTableAdapter1;
        private DataSet1 dataSet11;
        public System.Windows.Forms.Label sales_num;
        private a5_fatora_crystal_report a5_fatora_crystal_report1;
        private a4_fatora a4_fatora1;
       public System.Windows.Forms.ListBox listBox1;
        private Copy_of_CrystalReport1 copy_of_CrystalReport11;
        private DataSet1TableAdapters.madeen_small_reportTableAdapter madeen_small_reportTableAdapter1;
        public System.Windows.Forms.Label cst_name_txt;
        private a5_ezn_fatora_crystal_report a5_ezn_fatora_crystal_report1;
        private a4_ezn_fatora a4_ezn_fatora1;
        private DataSet1TableAdapters.customersTableAdapter customersTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker_print;
        private System.ComponentModel.BackgroundWorker backgroundWorker_save_pdf;
        public System.Windows.Forms.Label far3txt;
        public System.Windows.Forms.Label type_txt;
        public System.Windows.Forms.Label nesba_or_not_txt;
        private a4_fatora_nesba a4_fatora_nesba1;
        public System.Windows.Forms.Label sales_total_txt;
        private System.ComponentModel.BackgroundWorker backgroundWorker_sms_sending;
        private CrystalReport1 crystalReport11;
        private CrystalReport1_pos crystalReport1_pos1;
        private CrystalReport1_apm crystalReport1_apm1;
    
       // private fatora_crystal fatora_crystal1;
    }
}