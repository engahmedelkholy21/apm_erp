namespace pharma_manage
{
    partial class delete_kest
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
            this.delete_btn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.loan_code_txt = new System.Windows.Forms.TextBox();
            this.exit_btn = new System.Windows.Forms.Button();
            this.user_txt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kest_num_txt = new System.Windows.Forms.TextBox();
            this.aksat_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.aksat_tableTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.cst_name_text = new System.Windows.Forms.TextBox();
            this.loans_requests_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.loans_requests_tableTableAdapter();
            this.dataSet11 = new pharma_manage.DataSet1();
            this.safe_income_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.income_tableTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.kest_amount_txt = new System.Windows.Forms.TextBox();
            this.safe_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.safeTableAdapter();
            this.far3_txt = new System.Windows.Forms.Label();
            this.type_txt = new System.Windows.Forms.Label();
            this.deleted_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.deleted_tableTableAdapter();
            this.crystalReport11 = new pharma_manage.CrystalReport1();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // delete_btn
            // 
            this.delete_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.delete_btn.BackColor = System.Drawing.Color.Red;
            this.delete_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Location = new System.Drawing.Point(226, 213);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(193, 26);
            this.delete_btn.TabIndex = 3;
            this.delete_btn.Text = "حفظ";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(493, 56);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(81, 14);
            this.label9.TabIndex = 123262;
            this.label9.Text = "كود التقسيط";
            // 
            // loan_code_txt
            // 
            this.loan_code_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loan_code_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.loan_code_txt.Location = new System.Drawing.Point(93, 52);
            this.loan_code_txt.Name = "loan_code_txt";
            this.loan_code_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.loan_code_txt.Size = new System.Drawing.Size(381, 22);
            this.loan_code_txt.TabIndex = 0;
            this.loan_code_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loan_code_txt.TextChanged += new System.EventHandler(this.loan_code_txt_TextChanged);
            // 
            // exit_btn
            // 
            this.exit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.exit_btn.ForeColor = System.Drawing.Color.Red;
            this.exit_btn.Location = new System.Drawing.Point(540, 15);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(80, 34);
            this.exit_btn.TabIndex = 4;
            this.exit_btn.Text = "خــروج";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // user_txt
            // 
            this.user_txt.AutoSize = true;
            this.user_txt.Location = new System.Drawing.Point(21, 37);
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(28, 13);
            this.user_txt.TabIndex = 123261;
            this.user_txt.Text = "user";
            this.user_txt.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(493, 120);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(72, 14);
            this.label1.TabIndex = 123264;
            this.label1.Text = "رقم القسط";
            // 
            // kest_num_txt
            // 
            this.kest_num_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.kest_num_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.kest_num_txt.Location = new System.Drawing.Point(93, 116);
            this.kest_num_txt.Name = "kest_num_txt";
            this.kest_num_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.kest_num_txt.Size = new System.Drawing.Size(381, 22);
            this.kest_num_txt.TabIndex = 2;
            this.kest_num_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kest_num_txt.TextChanged += new System.EventHandler(this.kest_num_txt_TextChanged);
            // 
            // aksat_tableTableAdapter1
            // 
            this.aksat_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(493, 88);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(75, 14);
            this.label2.TabIndex = 123266;
            this.label2.Text = "اسم العميل";
            // 
            // cst_name_text
            // 
            this.cst_name_text.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cst_name_text.Enabled = false;
            this.cst_name_text.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.cst_name_text.Location = new System.Drawing.Point(93, 84);
            this.cst_name_text.Name = "cst_name_text";
            this.cst_name_text.ReadOnly = true;
            this.cst_name_text.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cst_name_text.Size = new System.Drawing.Size(381, 22);
            this.cst_name_text.TabIndex = 1;
            this.cst_name_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // loans_requests_tableTableAdapter1
            // 
            this.loans_requests_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // safe_income_tableTableAdapter1
            // 
            this.safe_income_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(493, 152);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(78, 14);
            this.label3.TabIndex = 123268;
            this.label3.Text = "قيمة القسط";
            // 
            // kest_amount_txt
            // 
            this.kest_amount_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.kest_amount_txt.Enabled = false;
            this.kest_amount_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.kest_amount_txt.Location = new System.Drawing.Point(93, 148);
            this.kest_amount_txt.Name = "kest_amount_txt";
            this.kest_amount_txt.ReadOnly = true;
            this.kest_amount_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.kest_amount_txt.Size = new System.Drawing.Size(381, 22);
            this.kest_amount_txt.TabIndex = 123267;
            this.kest_amount_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // safe_tableTableAdapter1
            // 
            this.safe_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // far3_txt
            // 
            this.far3_txt.AutoSize = true;
            this.far3_txt.Location = new System.Drawing.Point(31, 75);
            this.far3_txt.Name = "far3_txt";
            this.far3_txt.Size = new System.Drawing.Size(27, 13);
            this.far3_txt.TabIndex = 123269;
            this.far3_txt.Text = "far3";
            // 
            // type_txt
            // 
            this.type_txt.AutoSize = true;
            this.type_txt.Location = new System.Drawing.Point(40, 192);
            this.type_txt.Name = "type_txt";
            this.type_txt.Size = new System.Drawing.Size(29, 13);
            this.type_txt.TabIndex = 123270;
            this.type_txt.Text = "type";
            this.type_txt.Visible = false;
            // 
            // deleted_tableTableAdapter1
            // 
            this.deleted_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(93, 176);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(381, 21);
            this.comboBox1.TabIndex = 123271;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // delete_kest
            // 
            this.AcceptButton = this.delete_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exit_btn;
            this.ClientSize = new System.Drawing.Size(645, 251);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.type_txt);
            this.Controls.Add(this.far3_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kest_amount_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cst_name_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kest_num_txt);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.loan_code_txt);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.user_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "delete_kest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "delete_kest";
            this.Load += new System.EventHandler(this.delete_kest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete_btn;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox loan_code_txt;
        private System.Windows.Forms.Button exit_btn;
        public System.Windows.Forms.Label user_txt;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kest_num_txt;
       
        private DataSet1TableAdapters.income_tableTableAdapter safe_income_tableTableAdapter1;
        private DataSet1TableAdapters.aksat_tableTableAdapter aksat_tableTableAdapter1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cst_name_text;
        private DataSet1TableAdapters.loans_requests_tableTableAdapter loans_requests_tableTableAdapter1;
        private DataSet1 dataSet11;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kest_amount_txt;
        private DataSet1TableAdapters.safeTableAdapter safe_tableTableAdapter1;
        public System.Windows.Forms.Label far3_txt;
        public System.Windows.Forms.Label type_txt;
        private CrystalReport1 crystalReport11;
        private DataSet1TableAdapters.deleted_tableTableAdapter deleted_tableTableAdapter1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}