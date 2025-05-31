namespace pharma_manage
{
    partial class madeen_details_print
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
            this.madeen_tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new pharma_manage.DataSet1();
            this.pharmacy_dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.madeen_tableTableAdapter = new pharma_manage.DataSet1TableAdapters.madeen_tableTableAdapter();
            this.pharmacy_dataTableAdapter = new pharma_manage.DataSet1TableAdapters.pharmacy_dataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.madeen_tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_dataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // madeen_tableBindingSource
            // 
            this.madeen_tableBindingSource.DataMember = "madeen_table";
            this.madeen_tableBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pharmacy_dataBindingSource
            // 
            this.pharmacy_dataBindingSource.DataMember = "pharmacy_data";
            this.pharmacy_dataBindingSource.DataSource = this.DataSet1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.madeen_tableBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.pharmacy_dataBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "pharma_manage.Report8.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(800, 457);
            this.reportViewer1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(350, 218);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Visible = false;
            // 
            // madeen_tableTableAdapter
            // 
            this.madeen_tableTableAdapter.ClearBeforeFill = true;
            // 
            // pharmacy_dataTableAdapter
            // 
            this.pharmacy_dataTableAdapter.ClearBeforeFill = true;
            // 
            // madeen_details_print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "madeen_details_print";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "طباعة تفاصيل مدين";
            this.Load += new System.EventHandler(this.madeen_details_print_Load);
            ((System.ComponentModel.ISupportInitialize)(this.madeen_tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_dataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource madeen_tableBindingSource;
        private DataSet1 DataSet1;
        private System.Windows.Forms.BindingSource pharmacy_dataBindingSource;
        private DataSet1TableAdapters.madeen_tableTableAdapter madeen_tableTableAdapter;
        private DataSet1TableAdapters.pharmacy_dataTableAdapter pharmacy_dataTableAdapter;
    }
}