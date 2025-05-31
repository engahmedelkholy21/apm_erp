namespace pharma_manage
{
    partial class mwardeen_show
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cst_nameTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSet1 = new pharma_manage.DataSet1();
            this.mwardeenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mwardeenTableAdapter = new pharma_manage.DataSet1TableAdapters.mwardeenTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mwaredIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mwarednameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mwaredphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mwaredaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mwarednotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mwardeenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cst_nameTXT
            // 
            this.cst_nameTXT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cst_nameTXT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cst_nameTXT.Location = new System.Drawing.Point(303, 13);
            this.cst_nameTXT.Name = "cst_nameTXT";
            this.cst_nameTXT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cst_nameTXT.Size = new System.Drawing.Size(253, 22);
            this.cst_nameTXT.TabIndex = 97;
            this.cst_nameTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cst_nameTXT_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(571, 16);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(73, 14);
            this.label1.TabIndex = 99;
            this.label1.Text = "اسم المورد";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mwardeenBindingSource
            // 
            this.mwardeenBindingSource.DataMember = "mwardeen";
            this.mwardeenBindingSource.DataSource = this.dataSet1;
            // 
            // mwardeenTableAdapter
            // 
            this.mwardeenTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mwaredIDDataGridViewTextBoxColumn,
            this.mwarednameDataGridViewTextBoxColumn,
            this.mwaredphoneDataGridViewTextBoxColumn,
            this.mwaredaddressDataGridViewTextBoxColumn,
            this.mwarednotesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mwardeenBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(48, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(851, 472);
            this.dataGridView1.TabIndex = 100;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // mwaredIDDataGridViewTextBoxColumn
            // 
            this.mwaredIDDataGridViewTextBoxColumn.DataPropertyName = "mwared_ID";
            this.mwaredIDDataGridViewTextBoxColumn.HeaderText = "م";
            this.mwaredIDDataGridViewTextBoxColumn.Name = "mwaredIDDataGridViewTextBoxColumn";
            this.mwaredIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mwarednameDataGridViewTextBoxColumn
            // 
            this.mwarednameDataGridViewTextBoxColumn.DataPropertyName = "mwared_name";
            this.mwarednameDataGridViewTextBoxColumn.HeaderText = "اسم المورد";
            this.mwarednameDataGridViewTextBoxColumn.Name = "mwarednameDataGridViewTextBoxColumn";
            this.mwarednameDataGridViewTextBoxColumn.ReadOnly = true;
            this.mwarednameDataGridViewTextBoxColumn.Width = 150;
            // 
            // mwaredphoneDataGridViewTextBoxColumn
            // 
            this.mwaredphoneDataGridViewTextBoxColumn.DataPropertyName = "mwared_phone";
            this.mwaredphoneDataGridViewTextBoxColumn.HeaderText = "تليفون المورد";
            this.mwaredphoneDataGridViewTextBoxColumn.Name = "mwaredphoneDataGridViewTextBoxColumn";
            this.mwaredphoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.mwaredphoneDataGridViewTextBoxColumn.Width = 110;
            // 
            // mwaredaddressDataGridViewTextBoxColumn
            // 
            this.mwaredaddressDataGridViewTextBoxColumn.DataPropertyName = "mwared_address";
            this.mwaredaddressDataGridViewTextBoxColumn.HeaderText = "عنوان المورد";
            this.mwaredaddressDataGridViewTextBoxColumn.Name = "mwaredaddressDataGridViewTextBoxColumn";
            this.mwaredaddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.mwaredaddressDataGridViewTextBoxColumn.Width = 120;
            // 
            // mwarednotesDataGridViewTextBoxColumn
            // 
            this.mwarednotesDataGridViewTextBoxColumn.DataPropertyName = "mwared_notes";
            this.mwarednotesDataGridViewTextBoxColumn.HeaderText = "ملاحظــات";
            this.mwarednotesDataGridViewTextBoxColumn.Name = "mwarednotesDataGridViewTextBoxColumn";
            this.mwarednotesDataGridViewTextBoxColumn.ReadOnly = true;
            this.mwarednotesDataGridViewTextBoxColumn.Width = 320;
            // 
            // mwardeen_show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 531);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cst_nameTXT);
            this.Controls.Add(this.label1);
            this.Name = "mwardeen_show";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mwardeen_show";
            this.Load += new System.EventHandler(this.mwardeen_show_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mwardeenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cst_nameTXT;
        private System.Windows.Forms.Label label1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource mwardeenBindingSource;
        private DataSet1TableAdapters.mwardeenTableAdapter mwardeenTableAdapter;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mwaredIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mwarednameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mwaredphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mwaredaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mwarednotesDataGridViewTextBoxColumn;
    }
}