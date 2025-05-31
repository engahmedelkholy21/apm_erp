namespace pharma_manage
{
    partial class ezn_show
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new pharma_manage.DataSet1();
            this.eznsarfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ezn_sarfTableAdapter = new pharma_manage.DataSet1TableAdapters.ezn_sarfTableAdapter();
            this.eznidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ezndateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ezncostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mostalemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ezndetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eznnotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eznuserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eznsarfBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(533, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 14);
            this.label4.TabIndex = 107;
            this.label4.Text = "إلــــى";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(785, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 14);
            this.label3.TabIndex = 106;
            this.label3.Text = "من";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(326, 9);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 104;
            this.dateTimePicker2.Value = new System.DateTime(2015, 9, 21, 0, 0, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(579, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 103;
            this.dateTimePicker1.Value = new System.DateTime(2015, 9, 21, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
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
            this.eznidDataGridViewTextBoxColumn,
            this.ezndateDataGridViewTextBoxColumn,
            this.ezncostDataGridViewTextBoxColumn,
            this.mostalemDataGridViewTextBoxColumn,
            this.ezndetailsDataGridViewTextBoxColumn,
            this.eznnotesDataGridViewTextBoxColumn,
            this.eznuserDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eznsarfBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(47, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(1083, 360);
            this.dataGridView1.TabIndex = 105;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eznsarfBindingSource
            // 
            this.eznsarfBindingSource.DataMember = "ezn_sarf";
            this.eznsarfBindingSource.DataSource = this.dataSet1;
            // 
            // ezn_sarfTableAdapter
            // 
            this.ezn_sarfTableAdapter.ClearBeforeFill = true;
            // 
            // eznidDataGridViewTextBoxColumn
            // 
            this.eznidDataGridViewTextBoxColumn.DataPropertyName = "ezn_id";
            this.eznidDataGridViewTextBoxColumn.HeaderText = "م";
            this.eznidDataGridViewTextBoxColumn.Name = "eznidDataGridViewTextBoxColumn";
            this.eznidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ezndateDataGridViewTextBoxColumn
            // 
            this.ezndateDataGridViewTextBoxColumn.DataPropertyName = "ezn_date";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.ezndateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.ezndateDataGridViewTextBoxColumn.HeaderText = "التاريخ";
            this.ezndateDataGridViewTextBoxColumn.Name = "ezndateDataGridViewTextBoxColumn";
            this.ezndateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ezncostDataGridViewTextBoxColumn
            // 
            this.ezncostDataGridViewTextBoxColumn.DataPropertyName = "ezn_cost";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.ezncostDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.ezncostDataGridViewTextBoxColumn.HeaderText = "القيمة";
            this.ezncostDataGridViewTextBoxColumn.Name = "ezncostDataGridViewTextBoxColumn";
            this.ezncostDataGridViewTextBoxColumn.ReadOnly = true;
            this.ezncostDataGridViewTextBoxColumn.Width = 130;
            // 
            // mostalemDataGridViewTextBoxColumn
            // 
            this.mostalemDataGridViewTextBoxColumn.DataPropertyName = "mostalem";
            this.mostalemDataGridViewTextBoxColumn.HeaderText = "المستلم";
            this.mostalemDataGridViewTextBoxColumn.Name = "mostalemDataGridViewTextBoxColumn";
            this.mostalemDataGridViewTextBoxColumn.ReadOnly = true;
            this.mostalemDataGridViewTextBoxColumn.Width = 200;
            // 
            // ezndetailsDataGridViewTextBoxColumn
            // 
            this.ezndetailsDataGridViewTextBoxColumn.DataPropertyName = "ezn_details";
            this.ezndetailsDataGridViewTextBoxColumn.HeaderText = "التفاصيل";
            this.ezndetailsDataGridViewTextBoxColumn.Name = "ezndetailsDataGridViewTextBoxColumn";
            this.ezndetailsDataGridViewTextBoxColumn.ReadOnly = true;
            this.ezndetailsDataGridViewTextBoxColumn.Width = 200;
            // 
            // eznnotesDataGridViewTextBoxColumn
            // 
            this.eznnotesDataGridViewTextBoxColumn.DataPropertyName = "ezn_notes";
            this.eznnotesDataGridViewTextBoxColumn.HeaderText = "ملاحظــــات";
            this.eznnotesDataGridViewTextBoxColumn.Name = "eznnotesDataGridViewTextBoxColumn";
            this.eznnotesDataGridViewTextBoxColumn.ReadOnly = true;
            this.eznnotesDataGridViewTextBoxColumn.Width = 150;
            // 
            // eznuserDataGridViewTextBoxColumn
            // 
            this.eznuserDataGridViewTextBoxColumn.DataPropertyName = "ezn_user";
            this.eznuserDataGridViewTextBoxColumn.HeaderText = "المستخدم";
            this.eznuserDataGridViewTextBoxColumn.Name = "eznuserDataGridViewTextBoxColumn";
            this.eznuserDataGridViewTextBoxColumn.ReadOnly = true;
            this.eznuserDataGridViewTextBoxColumn.Width = 150;
            // 
            // total_txt
            // 
            this.total_txt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.total_txt.BackColor = System.Drawing.Color.White;
            this.total_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_txt.Location = new System.Drawing.Point(404, 403);
            this.total_txt.Name = "total_txt";
            this.total_txt.ReadOnly = true;
            this.total_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.total_txt.Size = new System.Drawing.Size(304, 22);
            this.total_txt.TabIndex = 109;
            this.total_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(714, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 14);
            this.label2.TabIndex = 108;
            this.label2.Text = "الإجمالي";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ezn_show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 429);
            this.Controls.Add(this.total_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ezn_show";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "مراجعة اذونات الصرف";
            this.Load += new System.EventHandler(this.ezn_show_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eznsarfBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource eznsarfBindingSource;
        private DataSet1TableAdapters.ezn_sarfTableAdapter ezn_sarfTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eznidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ezndateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ezncostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mostalemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ezndetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eznnotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eznuserDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox total_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}