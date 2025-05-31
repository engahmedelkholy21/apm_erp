namespace pharma_manage
{
    partial class nwa2es_print
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.nwa2esBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new pharma_manage.DataSet1();
            this.pharmacy_dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.nwa2esTableAdapter = new pharma_manage.DataSet1TableAdapters.nwa2esTableAdapter();
            this.pharmacy_dataTableAdapter = new pharma_manage.DataSet1TableAdapters.pharmacy_dataTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.edit_productbtn = new System.Windows.Forms.Button();
            this.crystal_nwa2es1 = new pharma_manage.crystal_nwa2es();
            ((System.ComponentModel.ISupportInitialize)(this.nwa2esBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_dataBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nwa2esBindingSource
            // 
            this.nwa2esBindingSource.DataMember = "nwa2es";
            this.nwa2esBindingSource.DataSource = this.DataSet1;
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
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.nwa2esBindingSource;
            reportDataSource4.Name = "DataSet2";
            reportDataSource4.Value = this.pharmacy_dataBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "pharma_manage.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 16);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1175, 410);
            this.reportViewer1.TabIndex = 0;
            // 
            // nwa2esTableAdapter
            // 
            this.nwa2esTableAdapter.ClearBeforeFill = true;
            // 
            // pharmacy_dataTableAdapter
            // 
            this.pharmacy_dataTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox1.Controls.Add(this.reportViewer1);
            this.groupBox1.Location = new System.Drawing.Point(21, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1181, 429);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "طباعة عادية";
            // 
            // edit_productbtn
            // 
            this.edit_productbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edit_productbtn.BackColor = System.Drawing.Color.Green;
            this.edit_productbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.edit_productbtn.FlatAppearance.BorderSize = 2;
            this.edit_productbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_productbtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_productbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.edit_productbtn.Location = new System.Drawing.Point(919, 10);
            this.edit_productbtn.Name = "edit_productbtn";
            this.edit_productbtn.Size = new System.Drawing.Size(277, 28);
            this.edit_productbtn.TabIndex = 75;
            this.edit_productbtn.Text = "طباعة بطابعة الفواتير";
            this.edit_productbtn.UseVisualStyleBackColor = false;
            this.edit_productbtn.Click += new System.EventHandler(this.edit_productbtn_Click);
            // 
            // nwa2es_print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 469);
            this.Controls.Add(this.edit_productbtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "nwa2es_print";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "طباعة طلبية";
            this.Load += new System.EventHandler(this.nwa2es_print_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nwa2esBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_dataBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource nwa2esBindingSource;
        private DataSet1 DataSet1;
        private System.Windows.Forms.BindingSource pharmacy_dataBindingSource;
        private DataSet1TableAdapters.nwa2esTableAdapter nwa2esTableAdapter;
        private DataSet1TableAdapters.pharmacy_dataTableAdapter pharmacy_dataTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private crystal_nwa2es crystal_nwa2es1;
        private System.Windows.Forms.Button edit_productbtn;
    }
}