namespace pharma_manage
{
    partial class resp_list
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.respidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.respnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.respphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.respaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.respbonusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.respnotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mas2ool_matloob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mas2ool_madfoo3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mas2ool_ba2y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resptableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new pharma_manage.DataSet1();
            this.cst_nameTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resp_tableTableAdapter = new pharma_manage.DataSet1TableAdapters.resp_tableTableAdapter();
            this.mosta7akat_mas2oleen_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.mosta7akat_mas2oleen_tableTableAdapter();
            this.deleted_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.deleted_tableTableAdapter();
            this.far3txt = new System.Windows.Forms.Label();
            this.usertxt = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.user_previligesTableAdapter1 = new pharma_manage.DataSet1TableAdapters.user_previligesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resptableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
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
            this.respidDataGridViewTextBoxColumn,
            this.respnameDataGridViewTextBoxColumn,
            this.respphoneDataGridViewTextBoxColumn,
            this.respaddressDataGridViewTextBoxColumn,
            this.respbonusDataGridViewTextBoxColumn,
            this.respnotesDataGridViewTextBoxColumn,
            this.mas2ool_matloob,
            this.mas2ool_madfoo3,
            this.mas2ool_ba2y});
            this.dataGridView1.DataSource = this.resptableBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(42, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(1098, 412);
            this.dataGridView1.TabIndex = 99;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // respidDataGridViewTextBoxColumn
            // 
            this.respidDataGridViewTextBoxColumn.DataPropertyName = "resp_id";
            this.respidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.respidDataGridViewTextBoxColumn.Name = "respidDataGridViewTextBoxColumn";
            this.respidDataGridViewTextBoxColumn.ReadOnly = true;
            this.respidDataGridViewTextBoxColumn.Width = 75;
            // 
            // respnameDataGridViewTextBoxColumn
            // 
            this.respnameDataGridViewTextBoxColumn.DataPropertyName = "resp_name";
            this.respnameDataGridViewTextBoxColumn.HeaderText = "اسم المسئول";
            this.respnameDataGridViewTextBoxColumn.Name = "respnameDataGridViewTextBoxColumn";
            this.respnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.respnameDataGridViewTextBoxColumn.Width = 170;
            // 
            // respphoneDataGridViewTextBoxColumn
            // 
            this.respphoneDataGridViewTextBoxColumn.DataPropertyName = "resp_phone";
            this.respphoneDataGridViewTextBoxColumn.HeaderText = "رقم التليفون";
            this.respphoneDataGridViewTextBoxColumn.Name = "respphoneDataGridViewTextBoxColumn";
            this.respphoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.respphoneDataGridViewTextBoxColumn.Width = 120;
            // 
            // respaddressDataGridViewTextBoxColumn
            // 
            this.respaddressDataGridViewTextBoxColumn.DataPropertyName = "resp_address";
            this.respaddressDataGridViewTextBoxColumn.HeaderText = "العنوان";
            this.respaddressDataGridViewTextBoxColumn.Name = "respaddressDataGridViewTextBoxColumn";
            this.respaddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.respaddressDataGridViewTextBoxColumn.Width = 150;
            // 
            // respbonusDataGridViewTextBoxColumn
            // 
            this.respbonusDataGridViewTextBoxColumn.DataPropertyName = "resp_bonus";
            this.respbonusDataGridViewTextBoxColumn.HeaderText = "نسبة البونص";
            this.respbonusDataGridViewTextBoxColumn.Name = "respbonusDataGridViewTextBoxColumn";
            this.respbonusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // respnotesDataGridViewTextBoxColumn
            // 
            this.respnotesDataGridViewTextBoxColumn.DataPropertyName = "resp_notes";
            this.respnotesDataGridViewTextBoxColumn.HeaderText = "ملاحظات";
            this.respnotesDataGridViewTextBoxColumn.Name = "respnotesDataGridViewTextBoxColumn";
            this.respnotesDataGridViewTextBoxColumn.ReadOnly = true;
            this.respnotesDataGridViewTextBoxColumn.Width = 130;
            // 
            // mas2ool_matloob
            // 
            this.mas2ool_matloob.DataPropertyName = "mas2ool_matloob";
            this.mas2ool_matloob.HeaderText = "المطلوب";
            this.mas2ool_matloob.Name = "mas2ool_matloob";
            this.mas2ool_matloob.ReadOnly = true;
            // 
            // mas2ool_madfoo3
            // 
            this.mas2ool_madfoo3.DataPropertyName = "mas2ool_madfoo3";
            this.mas2ool_madfoo3.HeaderText = "المسدد";
            this.mas2ool_madfoo3.Name = "mas2ool_madfoo3";
            this.mas2ool_madfoo3.ReadOnly = true;
            // 
            // mas2ool_ba2y
            // 
            this.mas2ool_ba2y.DataPropertyName = "mas2ool_ba2y";
            this.mas2ool_ba2y.HeaderText = "المستحق";
            this.mas2ool_ba2y.Name = "mas2ool_ba2y";
            this.mas2ool_ba2y.ReadOnly = true;
            // 
            // resptableBindingSource
            // 
            this.resptableBindingSource.DataMember = "resp_table";
            this.resptableBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cst_nameTXT
            // 
            this.cst_nameTXT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cst_nameTXT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cst_nameTXT.Location = new System.Drawing.Point(421, 20);
            this.cst_nameTXT.Name = "cst_nameTXT";
            this.cst_nameTXT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cst_nameTXT.Size = new System.Drawing.Size(340, 22);
            this.cst_nameTXT.TabIndex = 120;
            this.cst_nameTXT.TextChanged += new System.EventHandler(this.cst_nameTXT_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(502, 4);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(179, 14);
            this.label1.TabIndex = 121;
            this.label1.Text = "اسم المسئول او رقم التليفون";
            // 
            // resp_tableTableAdapter
            // 
            this.resp_tableTableAdapter.ClearBeforeFill = true;
            // 
            // mosta7akat_mas2oleen_tableTableAdapter1
            // 
            this.mosta7akat_mas2oleen_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // deleted_tableTableAdapter1
            // 
            this.deleted_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // far3txt
            // 
            this.far3txt.AutoSize = true;
            this.far3txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.far3txt.Location = new System.Drawing.Point(650, 298);
            this.far3txt.Name = "far3txt";
            this.far3txt.Size = new System.Drawing.Size(32, 14);
            this.far3txt.TabIndex = 123259;
            this.far3txt.Text = "far3";
            this.far3txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.far3txt.Visible = false;
            // 
            // usertxt
            // 
            this.usertxt.AutoSize = true;
            this.usertxt.Location = new System.Drawing.Point(500, 175);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(27, 13);
            this.usertxt.TabIndex = 123258;
            this.usertxt.Text = "user";
            this.usertxt.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(104, 159);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(222, 173);
            this.listBox1.TabIndex = 123260;
            this.listBox1.Visible = false;
            // 
            // user_previligesTableAdapter1
            // 
            this.user_previligesTableAdapter1.ClearBeforeFill = true;
            // 
            // resp_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 487);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.far3txt);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.cst_nameTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "resp_list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قائمة المسئولين";
            this.Load += new System.EventHandler(this.resp_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resptableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox cst_nameTXT;
        private System.Windows.Forms.Label label1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource resptableBindingSource;
        private DataSet1TableAdapters.resp_tableTableAdapter resp_tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn respidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn respnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn respphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn respaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn respbonusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn respnotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mas2ool_matloob;
        private System.Windows.Forms.DataGridViewTextBoxColumn mas2ool_madfoo3;
        private System.Windows.Forms.DataGridViewTextBoxColumn mas2ool_ba2y;
        private DataSet1TableAdapters.mosta7akat_mas2oleen_tableTableAdapter mosta7akat_mas2oleen_tableTableAdapter1;
        private DataSet1TableAdapters.deleted_tableTableAdapter deleted_tableTableAdapter1;
        public System.Windows.Forms.Label far3txt;
        public System.Windows.Forms.Label usertxt;
        private System.Windows.Forms.ListBox listBox1;
        private DataSet1TableAdapters.user_previligesTableAdapter user_previligesTableAdapter1;
    }
}