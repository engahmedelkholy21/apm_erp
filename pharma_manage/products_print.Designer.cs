namespace pharma_manage
{
    partial class products_print
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.products_tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new pharma_manage.DataSet1();
            this.pharmacy_dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.products_tableTableAdapter = new pharma_manage.DataSet1TableAdapters.products_tableTableAdapter();
            this.pharmacy_dataTableAdapter = new pharma_manage.DataSet1TableAdapters.pharmacy_dataTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.addbtn = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.products_crystal_taklefa_bee31 = new pharma_manage.products_crystal_taklefa_bee3();
            this.dataSet11 = new pharma_manage.DataSet1();
            this.products_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.products_tableTableAdapter();
            this.froo3_txt = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.stock_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.stock_tableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.products_tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // products_tableBindingSource
            // 
            this.products_tableBindingSource.DataMember = "products_table";
            this.products_tableBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.Locale = new System.Globalization.CultureInfo("en-US");
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pharmacy_dataBindingSource
            // 
            this.pharmacy_dataBindingSource.DataMember = "pharmacy_data";
            this.pharmacy_dataBindingSource.DataSource = this.DataSet1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.products_tableBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.pharmacy_dataBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "pharma_manage.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(4, 30);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(319, 468);
            this.reportViewer1.TabIndex = 0;
            // 
            // products_tableTableAdapter
            // 
            this.products_tableTableAdapter.ClearBeforeFill = true;
            // 
            // pharmacy_dataTableAdapter
            // 
            this.pharmacy_dataTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.products_tableBindingSource;
            reportDataSource4.Name = "DataSet2";
            reportDataSource4.Value = this.pharmacy_dataBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "pharma_manage.Copy of Report3.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(326, 30);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(319, 468);
            this.reportViewer2.TabIndex = 1;
            // 
            // reportViewer3
            // 
            this.reportViewer3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.products_tableBindingSource;
            reportDataSource6.Name = "DataSet2";
            reportDataSource6.Value = this.pharmacy_dataBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "pharma_manage.Copy of Copy of Report3.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(651, 30);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.Size = new System.Drawing.Size(319, 468);
            this.reportViewer3.TabIndex = 3;
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
            this.addbtn.Location = new System.Drawing.Point(1071, 1);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(213, 26);
            this.addbtn.TabIndex = 9;
            this.addbtn.Text = "طباعة جرد جميع الاصناف";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(976, 30);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.products_crystal_taklefa_bee31;
            this.crystalReportViewer1.Size = new System.Drawing.Size(376, 468);
            this.crystalReportViewer1.TabIndex = 123254;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // products_tableTableAdapter1
            // 
            this.products_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // froo3_txt
            // 
            this.froo3_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.froo3_txt.FormattingEnabled = true;
            this.froo3_txt.Location = new System.Drawing.Point(26, 4);
            this.froo3_txt.Name = "froo3_txt";
            this.froo3_txt.Size = new System.Drawing.Size(180, 22);
            this.froo3_txt.TabIndex = 123256;
            this.froo3_txt.SelectedIndexChanged += new System.EventHandler(this.far3_txt_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(212, 8);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(36, 14);
            this.label11.TabIndex = 123257;
            this.label11.Text = "الفرع";
            // 
            // stock_tableTableAdapter1
            // 
            this.stock_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // products_print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 498);
            this.Controls.Add(this.froo3_txt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.reportViewer3);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Name = "products_print";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "طباعة الجرد";
            this.Load += new System.EventHandler(this.products_print_Load);
            this.Shown += new System.EventHandler(this.products_print_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.products_tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource products_tableBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.products_tableTableAdapter products_tableTableAdapter;
        private System.Windows.Forms.BindingSource pharmacy_dataBindingSource;
        private DataSet1TableAdapters.pharmacy_dataTableAdapter pharmacy_dataTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.Button addbtn;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private products_crystal_taklefa_bee3 products_crystal_taklefa_bee31;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.products_tableTableAdapter products_tableTableAdapter1;
        public System.Windows.Forms.ComboBox froo3_txt;
        public System.Windows.Forms.Label label11;
        private DataSet1TableAdapters.stock_tableTableAdapter stock_tableTableAdapter1;
    }
}