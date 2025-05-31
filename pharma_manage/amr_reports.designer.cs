namespace pharma_manage
{
    partial class amr_reports
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.amr_masrofat_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.amr_masrofat_tableTableAdapter();
            this.amr_material_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.amr_material_tableTableAdapter();
            this.amr_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.amr_tableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(891, 315);
            this.dataGridView1.TabIndex = 0;
            // 
            // amr_masrofat_tableTableAdapter1
            // 
            this.amr_masrofat_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // amr_material_tableTableAdapter1
            // 
            this.amr_material_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // amr_tableTableAdapter1
            // 
            this.amr_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // amr_reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 481);
            this.Controls.Add(this.dataGridView1);
            this.Name = "amr_reports";
            this.Text = "amr_reports";
            this.Load += new System.EventHandler(this.amr_reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1TableAdapters.amr_masrofat_tableTableAdapter amr_masrofat_tableTableAdapter1;
        private DataSet1TableAdapters.amr_material_tableTableAdapter amr_material_tableTableAdapter1;
        private DataSet1TableAdapters.amr_tableTableAdapter amr_tableTableAdapter1;
    }
}