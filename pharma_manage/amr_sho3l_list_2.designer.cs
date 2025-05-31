namespace pharma_manage
{
    partial class amr_sho3l_list_2
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
            this.amr_sho3l_report1 = new pharma_manage.amr_sho3l_report();
            this.dataSet11 = new pharma_manage.DataSet1();
            //this.amr_sho3l_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.amr_sho3l_tableTableAdapter();
            this.pharmacy_dataTableAdapter1 = new pharma_manage.DataSet1TableAdapters.pharmacy_dataTableAdapter();
            this.amr_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.amr_tableTableAdapter();
            this.amr_material_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.amr_material_tableTableAdapter();
            this.amr_masrofat_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.amr_masrofat_tableTableAdapter();
            this.amr_masrofat_crystal1 = new pharma_manage.amr_masrofat_crystal();
            this.amr_materials_crystal1 = new pharma_manage.amr_materials_crystal();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.amr_crystal1 = new pharma_manage.amr_crystal();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // amr_sho3l_tableTableAdapter1
            // 
           // this.amr_sho3l_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // pharmacy_dataTableAdapter1
            // 
            this.pharmacy_dataTableAdapter1.ClearBeforeFill = true;
            // 
            // amr_tableTableAdapter1
            // 
            this.amr_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // amr_material_tableTableAdapter1
            // 
            this.amr_material_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // amr_masrofat_tableTableAdapter1
            // 
            this.amr_masrofat_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1046, 500);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // amr_sho3l_list_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 500);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "amr_sho3l_list_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "amr_sho3l_list";
            this.Load += new System.EventHandler(this.amr_sho3l_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private amr_sho3l_report amr_sho3l_report1;
        private DataSet1 dataSet11;
       // private DataSet1TableAdapters.amr_sho3l_tableTableAdapter amr_sho3l_tableTableAdapter1;
        private DataSet1TableAdapters.pharmacy_dataTableAdapter pharmacy_dataTableAdapter1;
        private amr_crystal amr_crystal1;
        private DataSet1TableAdapters.amr_tableTableAdapter amr_tableTableAdapter1;
        private DataSet1TableAdapters.amr_material_tableTableAdapter amr_material_tableTableAdapter1;
        private DataSet1TableAdapters.amr_masrofat_tableTableAdapter amr_masrofat_tableTableAdapter1;
        private amr_masrofat_crystal amr_masrofat_crystal1;
        private amr_materials_crystal amr_materials_crystal1;
    }
}