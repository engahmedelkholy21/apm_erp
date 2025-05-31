namespace pharma_manage
{
    partial class barcode_form_single
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
            this.addbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.products_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.products_tableTableAdapter();
            this.dataSet11 = new pharma_manage.DataSet1();
            this.print_barcodeTableAdapter1 = new pharma_manage.DataSet1TableAdapters.print_barcodeTableAdapter();
            this.dataSet1 = new pharma_manage.DataSet1();
            this.printbarcodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pharmacy_dataTableAdapter1 = new pharma_manage.DataSet1TableAdapters.pharmacy_dataTableAdapter();
            this.pro_code_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stock_txt = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.stocktableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stock_tableTableAdapter = new pharma_manage.DataSet1TableAdapters.stock_tableTableAdapter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.crystalReport21 = new pharma_manage.CrystalReport2();
            this.crystalReport2_small1 = new pharma_manage.CrystalReport2_small();
            this.label3 = new System.Windows.Forms.Label();
            this.pro_name_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.count_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printbarcodeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocktableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addbtn
            // 
            this.addbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addbtn.BackColor = System.Drawing.Color.Green;
            this.addbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addbtn.FlatAppearance.BorderSize = 2;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addbtn.Location = new System.Drawing.Point(480, 64);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(173, 42);
            this.addbtn.TabIndex = 123236;
            this.addbtn.Text = "اطبع";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 123237;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // products_tableTableAdapter1
            // 
            this.products_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // print_barcodeTableAdapter1
            // 
            this.print_barcodeTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // printbarcodeBindingSource
            // 
            this.printbarcodeBindingSource.DataMember = "print_barcode";
            this.printbarcodeBindingSource.DataSource = this.dataSet1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 123239;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // pharmacy_dataTableAdapter1
            // 
            this.pharmacy_dataTableAdapter1.ClearBeforeFill = true;
            // 
            // pro_code_txt
            // 
            this.pro_code_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pro_code_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pro_code_txt.Location = new System.Drawing.Point(787, 22);
            this.pro_code_txt.Name = "pro_code_txt";
            this.pro_code_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pro_code_txt.Size = new System.Drawing.Size(202, 22);
            this.pro_code_txt.TabIndex = 1;
            this.pro_code_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pro_code_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.pro_code_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(995, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 14);
            this.label2.TabIndex = 123241;
            this.label2.Text = "كود الصنف";
            // 
            // stock_txt
            // 
            this.stock_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.stock_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.stock_txt.FormattingEnabled = true;
            this.stock_txt.Location = new System.Drawing.Point(829, 88);
            this.stock_txt.Name = "stock_txt";
            this.stock_txt.Size = new System.Drawing.Size(180, 22);
            this.stock_txt.TabIndex = 123242;
            this.stock_txt.Visible = false;
            this.stock_txt.SelectedIndexChanged += new System.EventHandler(this.stock_txt_SelectedIndexChanged);
            this.stock_txt.TextChanged += new System.EventHandler(this.stock_txt_TextChanged);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1015, 92);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(36, 14);
            this.label11.TabIndex = 123243;
            this.label11.Text = "الفرع";
            this.label11.Visible = false;
            // 
            // stocktableBindingSource
            // 
            this.stocktableBindingSource.DataMember = "stock_table";
            this.stocktableBindingSource.DataSource = this.dataSet11;
            // 
            // stock_tableTableAdapter
            // 
            this.stock_tableTableAdapter.ClearBeforeFill = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(645, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 14);
            this.label3.TabIndex = 123245;
            this.label3.Text = "اسم الصنف";
            // 
            // pro_name_txt
            // 
            this.pro_name_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pro_name_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pro_name_txt.Location = new System.Drawing.Point(343, 22);
            this.pro_name_txt.Name = "pro_name_txt";
            this.pro_name_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pro_name_txt.Size = new System.Drawing.Size(296, 22);
            this.pro_name_txt.TabIndex = 123244;
            this.pro_name_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(204, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 14);
            this.label4.TabIndex = 123247;
            this.label4.Text = "عدد الباركود";
            // 
            // count_txt
            // 
            this.count_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.count_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count_txt.Location = new System.Drawing.Point(68, 22);
            this.count_txt.Name = "count_txt";
            this.count_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.count_txt.Size = new System.Drawing.Size(130, 22);
            this.count_txt.TabIndex = 123246;
            this.count_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // barcode_form_single
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 131);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.count_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pro_name_txt);
            this.Controls.Add(this.stock_txt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pro_code_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "barcode_form_single";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "طباعة باركود صنف";
            this.Load += new System.EventHandler(this.barcode_form_single_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printbarcodeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocktableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1TableAdapters.products_tableTableAdapter products_tableTableAdapter1;
        private DataSet1 dataSet11;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DataSet1TableAdapters.print_barcodeTableAdapter print_barcodeTableAdapter1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource printbarcodeBindingSource;
        public System.Windows.Forms.Label label1;
        private DataSet1TableAdapters.pharmacy_dataTableAdapter pharmacy_dataTableAdapter1;
        private System.Windows.Forms.Label label2;
        private CrystalReport2 crystalReport21;
        public System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource stocktableBindingSource;
        private DataSet1TableAdapters.stock_tableTableAdapter stock_tableTableAdapter;
        public System.Windows.Forms.ComboBox stock_txt;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CrystalReport2_small crystalReport2_small1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox pro_name_txt;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox count_txt;
        public System.Windows.Forms.TextBox pro_code_txt;
    }
}