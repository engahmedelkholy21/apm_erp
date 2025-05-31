namespace pharma_manage
{
    partial class show_tas3eer
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
            this.pharmacy_dataTableAdapter1 = new pharma_manage.DataSet1TableAdapters.pharmacy_dataTableAdapter();
            this.dataSet11 = new pharma_manage.DataSet1();
            this.tas3eer_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.tas3eer_tableTableAdapter();
            this.salesID_TXT = new System.Windows.Forms.TextBox();
            this.a4_fatora_tas3eer1 = new pharma_manage.a4_fatora_tas3eer();
            this.far3txt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowLogo = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1033, 478);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ReportRefresh += new CrystalDecisions.Windows.Forms.RefreshEventHandler(this.crystalReportViewer1_ReportRefresh);
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
            // tas3eer_tableTableAdapter1
            // 
            this.tas3eer_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // salesID_TXT
            // 
            this.salesID_TXT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.salesID_TXT.Enabled = false;
            this.salesID_TXT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesID_TXT.Location = new System.Drawing.Point(446, 228);
            this.salesID_TXT.Name = "salesID_TXT";
            this.salesID_TXT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.salesID_TXT.Size = new System.Drawing.Size(140, 22);
            this.salesID_TXT.TabIndex = 2;
            this.salesID_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.salesID_TXT.Visible = false;
            // 
            // far3txt
            // 
            this.far3txt.AutoSize = true;
            this.far3txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.far3txt.Location = new System.Drawing.Point(500, 232);
            this.far3txt.Name = "far3txt";
            this.far3txt.Size = new System.Drawing.Size(32, 14);
            this.far3txt.TabIndex = 123253;
            this.far3txt.Text = "far3";
            this.far3txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.far3txt.Visible = false;
            // 
            // show_tas3eer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 478);
            this.Controls.Add(this.far3txt);
            this.Controls.Add(this.salesID_TXT);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "show_tas3eer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عرض فواتير التسعير";
            this.Load += new System.EventHandler(this.show_tas3eer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private DataSet1TableAdapters.pharmacy_dataTableAdapter pharmacy_dataTableAdapter1;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.tas3eer_tableTableAdapter tas3eer_tableTableAdapter1;
        private a4_fatora_tas3eer a4_fatora_tas3eer1;
        public System.Windows.Forms.TextBox salesID_TXT;
        public System.Windows.Forms.Label far3txt;
    }
}