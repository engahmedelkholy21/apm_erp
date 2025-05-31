namespace pharma_manage
{
    partial class crystal_report_form
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport21 = new pharma_manage.CrystalReport2();
            this.dataSet11 = new pharma_manage.DataSet1();
            this.print_barcodeTableAdapter1 = new pharma_manage.DataSet1TableAdapters.print_barcodeTableAdapter();
            this.CrystalReport22 = new pharma_manage.CrystalReport2();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.CrystalReport22;
            this.crystalReportViewer1.Size = new System.Drawing.Size(602, 379);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // CrystalReport21
            // 
            this.CrystalReport21.FileName = "rassdk://C:\\Users\\eng\\AppData\\Local\\Temp\\temp_648753f3-220f-42f8-b2fe-dbbe48f4faa" +
    "9.rpt";
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // print_barcodeTableAdapter1
            // 
            this.print_barcodeTableAdapter1.ClearBeforeFill = true;
            // 
            // crystal_report_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 379);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "crystal_report_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "طباعة الباركود";
            this.Load += new System.EventHandler(this.crystal_report_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
         private DataSet1 dataSet11;
         private DataSet1TableAdapters.print_barcodeTableAdapter print_barcodeTableAdapter1;
         private CrystalReport2 CrystalReport21;
         private CrystalReport2 CrystalReport22;
    }
}