namespace pharma_manage
{
    partial class employees_show
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employees_show));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeenationalidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeejobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeelastgraduationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeenotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeedailysalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeemonthlysalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeuserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeetableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new pharma_manage.DataSet1();
            this.employee_tableTableAdapter = new pharma_manage.DataSet1TableAdapters.employee_tableTableAdapter();
            this.usertxt = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.deleted_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.deleted_tableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeetableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.employeeidDataGridViewTextBoxColumn,
            this.employeenameDataGridViewTextBoxColumn,
            this.employeeaddressDataGridViewTextBoxColumn,
            this.employeephoneDataGridViewTextBoxColumn,
            this.employeenationalidDataGridViewTextBoxColumn,
            this.employeejobDataGridViewTextBoxColumn,
            this.employeelastgraduationDataGridViewTextBoxColumn,
            this.employeenotesDataGridViewTextBoxColumn,
            this.employeedailysalaryDataGridViewTextBoxColumn,
            this.employeemonthlysalaryDataGridViewTextBoxColumn,
            this.employeeuserDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeetableBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(54, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(1047, 396);
            this.dataGridView1.TabIndex = 65;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // employeeidDataGridViewTextBoxColumn
            // 
            this.employeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.HeaderText = "م";
            this.employeeidDataGridViewTextBoxColumn.Name = "employeeidDataGridViewTextBoxColumn";
            this.employeeidDataGridViewTextBoxColumn.Width = 50;
            // 
            // employeenameDataGridViewTextBoxColumn
            // 
            this.employeenameDataGridViewTextBoxColumn.DataPropertyName = "employee_name";
            this.employeenameDataGridViewTextBoxColumn.HeaderText = "اسم الموظف";
            this.employeenameDataGridViewTextBoxColumn.Name = "employeenameDataGridViewTextBoxColumn";
            this.employeenameDataGridViewTextBoxColumn.Width = 150;
            // 
            // employeeaddressDataGridViewTextBoxColumn
            // 
            this.employeeaddressDataGridViewTextBoxColumn.DataPropertyName = "employee_address";
            this.employeeaddressDataGridViewTextBoxColumn.HeaderText = "العنوان";
            this.employeeaddressDataGridViewTextBoxColumn.Name = "employeeaddressDataGridViewTextBoxColumn";
            // 
            // employeephoneDataGridViewTextBoxColumn
            // 
            this.employeephoneDataGridViewTextBoxColumn.DataPropertyName = "employee_phone";
            this.employeephoneDataGridViewTextBoxColumn.HeaderText = "التليفون";
            this.employeephoneDataGridViewTextBoxColumn.Name = "employeephoneDataGridViewTextBoxColumn";
            this.employeephoneDataGridViewTextBoxColumn.Width = 80;
            // 
            // employeenationalidDataGridViewTextBoxColumn
            // 
            this.employeenationalidDataGridViewTextBoxColumn.DataPropertyName = "employee_national_id";
            this.employeenationalidDataGridViewTextBoxColumn.HeaderText = "الرقم القومي";
            this.employeenationalidDataGridViewTextBoxColumn.Name = "employeenationalidDataGridViewTextBoxColumn";
            this.employeenationalidDataGridViewTextBoxColumn.Width = 80;
            // 
            // employeejobDataGridViewTextBoxColumn
            // 
            this.employeejobDataGridViewTextBoxColumn.DataPropertyName = "employee_job";
            this.employeejobDataGridViewTextBoxColumn.HeaderText = "الوظيفة";
            this.employeejobDataGridViewTextBoxColumn.Name = "employeejobDataGridViewTextBoxColumn";
            // 
            // employeelastgraduationDataGridViewTextBoxColumn
            // 
            this.employeelastgraduationDataGridViewTextBoxColumn.DataPropertyName = "employee_last_graduation";
            this.employeelastgraduationDataGridViewTextBoxColumn.HeaderText = "اخر مؤهل";
            this.employeelastgraduationDataGridViewTextBoxColumn.Name = "employeelastgraduationDataGridViewTextBoxColumn";
            this.employeelastgraduationDataGridViewTextBoxColumn.Width = 80;
            // 
            // employeenotesDataGridViewTextBoxColumn
            // 
            this.employeenotesDataGridViewTextBoxColumn.DataPropertyName = "employee_notes";
            this.employeenotesDataGridViewTextBoxColumn.HeaderText = "ملاحظات";
            this.employeenotesDataGridViewTextBoxColumn.Name = "employeenotesDataGridViewTextBoxColumn";
            // 
            // employeedailysalaryDataGridViewTextBoxColumn
            // 
            this.employeedailysalaryDataGridViewTextBoxColumn.DataPropertyName = "employee_daily_salary";
            this.employeedailysalaryDataGridViewTextBoxColumn.HeaderText = "الراتب اليومي";
            this.employeedailysalaryDataGridViewTextBoxColumn.Name = "employeedailysalaryDataGridViewTextBoxColumn";
            this.employeedailysalaryDataGridViewTextBoxColumn.Width = 80;
            // 
            // employeemonthlysalaryDataGridViewTextBoxColumn
            // 
            this.employeemonthlysalaryDataGridViewTextBoxColumn.DataPropertyName = "employee_monthly_salary";
            this.employeemonthlysalaryDataGridViewTextBoxColumn.HeaderText = "الراتب الشهري";
            this.employeemonthlysalaryDataGridViewTextBoxColumn.Name = "employeemonthlysalaryDataGridViewTextBoxColumn";
            this.employeemonthlysalaryDataGridViewTextBoxColumn.Width = 80;
            // 
            // employeeuserDataGridViewTextBoxColumn
            // 
            this.employeeuserDataGridViewTextBoxColumn.DataPropertyName = "employee_user";
            this.employeeuserDataGridViewTextBoxColumn.HeaderText = "المستخدم";
            this.employeeuserDataGridViewTextBoxColumn.Name = "employeeuserDataGridViewTextBoxColumn";
            // 
            // employeetableBindingSource
            // 
            this.employeetableBindingSource.DataMember = "employee_table";
            this.employeetableBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employee_tableTableAdapter
            // 
            this.employee_tableTableAdapter.ClearBeforeFill = true;
            // 
            // usertxt
            // 
            this.usertxt.AutoSize = true;
            this.usertxt.Location = new System.Drawing.Point(182, 9);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(35, 13);
            this.usertxt.TabIndex = 123234;
            this.usertxt.Text = "admin";
            this.usertxt.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 123236;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(649, 19);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(179, 14);
            this.label2.TabIndex = 123238;
            this.label2.Text = "اسم الموظف او الرقم القومي";
            // 
            // name_txt
            // 
            this.name_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txt.Location = new System.Drawing.Point(327, 15);
            this.name_txt.Name = "name_txt";
            this.name_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_txt.Size = new System.Drawing.Size(316, 22);
            this.name_txt.TabIndex = 0;
            this.name_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name_txt.TextChanged += new System.EventHandler(this.name_txt_TextChanged);
            // 
            // deleted_tableTableAdapter1
            // 
            this.deleted_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // employees_show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 466);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "employees_show";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "عرض الموظفين";
            this.Load += new System.EventHandler(this.employees_show_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeetableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource employeetableBindingSource;
        private DataSet1TableAdapters.employee_tableTableAdapter employee_tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeenationalidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeejobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeelastgraduationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeenotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeedailysalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeemonthlysalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeuserDataGridViewTextBoxColumn;
        public System.Windows.Forms.Label usertxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_txt;
        private DataSet1TableAdapters.deleted_tableTableAdapter deleted_tableTableAdapter1;
    }
}