namespace pharma_manage
{
    partial class customers_points
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new pharma_manage.DataSet1();
            this.customerpointstableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customer_points_tableTableAdapter = new pharma_manage.DataSet1TableAdapters.customer_points_tableTableAdapter();
            this.cstpointsidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstpointscstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstpointscstphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csttotalpointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstredeemedpointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstvalidpointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cst_nameTXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerpointstableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cstpointsidDataGridViewTextBoxColumn,
            this.cstpointscstnameDataGridViewTextBoxColumn,
            this.cstpointscstphoneDataGridViewTextBoxColumn,
            this.csttotalpointsDataGridViewTextBoxColumn,
            this.cstredeemedpointsDataGridViewTextBoxColumn,
            this.cstvalidpointsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerpointstableBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.Location = new System.Drawing.Point(139, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Size = new System.Drawing.Size(785, 402);
            this.dataGridView1.TabIndex = 99;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerpointstableBindingSource
            // 
            this.customerpointstableBindingSource.DataMember = "customer_points_table";
            this.customerpointstableBindingSource.DataSource = this.dataSet1;
            // 
            // customer_points_tableTableAdapter
            // 
            this.customer_points_tableTableAdapter.ClearBeforeFill = true;
            // 
            // cstpointsidDataGridViewTextBoxColumn
            // 
            this.cstpointsidDataGridViewTextBoxColumn.DataPropertyName = "cst_points_id";
            this.cstpointsidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.cstpointsidDataGridViewTextBoxColumn.Name = "cstpointsidDataGridViewTextBoxColumn";
            this.cstpointsidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cstpointscstnameDataGridViewTextBoxColumn
            // 
            this.cstpointscstnameDataGridViewTextBoxColumn.DataPropertyName = "cst_points_cst_name";
            this.cstpointscstnameDataGridViewTextBoxColumn.HeaderText = "اسم العميل";
            this.cstpointscstnameDataGridViewTextBoxColumn.Name = "cstpointscstnameDataGridViewTextBoxColumn";
            this.cstpointscstnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.cstpointscstnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // cstpointscstphoneDataGridViewTextBoxColumn
            // 
            this.cstpointscstphoneDataGridViewTextBoxColumn.DataPropertyName = "cst_points_cst_phone";
            this.cstpointscstphoneDataGridViewTextBoxColumn.HeaderText = "رقم التليفون";
            this.cstpointscstphoneDataGridViewTextBoxColumn.Name = "cstpointscstphoneDataGridViewTextBoxColumn";
            this.cstpointscstphoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.cstpointscstphoneDataGridViewTextBoxColumn.Width = 120;
            // 
            // csttotalpointsDataGridViewTextBoxColumn
            // 
            this.csttotalpointsDataGridViewTextBoxColumn.DataPropertyName = "cst_total_points";
            this.csttotalpointsDataGridViewTextBoxColumn.HeaderText = "اجمالي النقاط";
            this.csttotalpointsDataGridViewTextBoxColumn.Name = "csttotalpointsDataGridViewTextBoxColumn";
            this.csttotalpointsDataGridViewTextBoxColumn.ReadOnly = true;
            this.csttotalpointsDataGridViewTextBoxColumn.Width = 120;
            // 
            // cstredeemedpointsDataGridViewTextBoxColumn
            // 
            this.cstredeemedpointsDataGridViewTextBoxColumn.DataPropertyName = "cst_redeemed_points";
            this.cstredeemedpointsDataGridViewTextBoxColumn.HeaderText = "النقاط المستبدله";
            this.cstredeemedpointsDataGridViewTextBoxColumn.Name = "cstredeemedpointsDataGridViewTextBoxColumn";
            this.cstredeemedpointsDataGridViewTextBoxColumn.ReadOnly = true;
            this.cstredeemedpointsDataGridViewTextBoxColumn.Width = 120;
            // 
            // cstvalidpointsDataGridViewTextBoxColumn
            // 
            this.cstvalidpointsDataGridViewTextBoxColumn.DataPropertyName = "cst_valid_points";
            this.cstvalidpointsDataGridViewTextBoxColumn.HeaderText = "النقاط المتاحة";
            this.cstvalidpointsDataGridViewTextBoxColumn.Name = "cstvalidpointsDataGridViewTextBoxColumn";
            this.cstvalidpointsDataGridViewTextBoxColumn.ReadOnly = true;
            this.cstvalidpointsDataGridViewTextBoxColumn.Width = 120;
            // 
            // cst_nameTXT
            // 
            this.cst_nameTXT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cst_nameTXT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cst_nameTXT.Location = new System.Drawing.Point(373, 12);
            this.cst_nameTXT.Name = "cst_nameTXT";
            this.cst_nameTXT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cst_nameTXT.Size = new System.Drawing.Size(229, 22);
            this.cst_nameTXT.TabIndex = 111;
            this.cst_nameTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cst_nameTXT_KeyDown);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(606, 16);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(84, 14);
            this.label6.TabIndex = 112;
            this.label6.Text = "إســـم العميل";
            // 
            // customers_points
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 480);
            this.Controls.Add(this.cst_nameTXT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Name = "customers_points";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نقاط العملاء";
            this.Load += new System.EventHandler(this.customers_points_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerpointstableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource customerpointstableBindingSource;
        private DataSet1TableAdapters.customer_points_tableTableAdapter customer_points_tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstpointsidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstpointscstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstpointscstphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn csttotalpointsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstredeemedpointsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstvalidpointsDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox cst_nameTXT;
        private System.Windows.Forms.Label label6;
    }
}