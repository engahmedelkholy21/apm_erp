namespace pharma_manage
{
    partial class madeen_print
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
            this.madeen_small_reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new pharma_manage.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.madeen_small_reportTableAdapter = new pharma_manage.DataSet1TableAdapters.madeen_small_reportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.madeen_small_reportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // madeen_small_reportBindingSource
            // 
            this.madeen_small_reportBindingSource.DataMember = "madeen_small_report";
            this.madeen_small_reportBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.Locale = new System.Globalization.CultureInfo("en-US");
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.madeen_small_reportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "pharma_manage.Report12.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(787, 439);
            this.reportViewer1.TabIndex = 0;
            // 
            // madeen_small_reportTableAdapter
            // 
            this.madeen_small_reportTableAdapter.ClearBeforeFill = true;
            // 
            // madeen_print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 439);
            this.Controls.Add(this.reportViewer1);
            this.Name = "madeen_print";
            this.Text = "madeen_print";
            this.Load += new System.EventHandler(this.madeen_print_Load);
            ((System.ComponentModel.ISupportInitialize)(this.madeen_small_reportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource madeen_small_reportBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.madeen_small_reportTableAdapter madeen_small_reportTableAdapter;
    }
}