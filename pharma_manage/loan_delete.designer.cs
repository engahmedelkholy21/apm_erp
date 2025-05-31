namespace pharma_manage
{
    partial class loan_delete
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
            this.user_txt = new System.Windows.Forms.Label();
            this.exit_btn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.loan_name_txt = new System.Windows.Forms.TextBox();
            this.delete_btn = new System.Windows.Forms.Button();
            this.dataSet11 = new pharma_manage.DataSet1();
            this.loans_requests_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.loans_requests_tableTableAdapter();
            this.customers_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.customersTableAdapter();
            this.safe_outcome_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.outcome_tableTableAdapter();
            this.safe_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.safeTableAdapter();
            this.far3_txt = new System.Windows.Forms.Label();
            this.aksat_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.aksat_tableTableAdapter();
            this.deleted_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.deleted_tableTableAdapter();
            this.safe_income_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.income_tableTableAdapter();
            this.deleted_tableTableAdapter2 = new pharma_manage.DataSet1TableAdapters.deleted_tableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // user_txt
            // 
            this.user_txt.AutoSize = true;
            this.user_txt.Location = new System.Drawing.Point(31, 9);
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(28, 13);
            this.user_txt.TabIndex = 123253;
            this.user_txt.Text = "user";
            this.user_txt.Visible = false;
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
            this.exit_btn.Location = new System.Drawing.Point(550, 9);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(80, 34);
            this.exit_btn.TabIndex = 2;
            this.exit_btn.Text = "خــروج";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(503, 55);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(74, 14);
            this.label9.TabIndex = 123257;
            this.label9.Text = "كود التقسيط";
            // 
            // loan_name_txt
            // 
            this.loan_name_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loan_name_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.loan_name_txt.Location = new System.Drawing.Point(103, 51);
            this.loan_name_txt.Name = "loan_name_txt";
            this.loan_name_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.loan_name_txt.Size = new System.Drawing.Size(381, 22);
            this.loan_name_txt.TabIndex = 0;
            this.loan_name_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // delete_btn
            // 
            this.delete_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.delete_btn.BackColor = System.Drawing.Color.Red;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Location = new System.Drawing.Point(225, 88);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(205, 37);
            this.delete_btn.TabIndex = 1;
            this.delete_btn.Text = "حفظ";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loans_requests_tableTableAdapter1
            // 
            this.loans_requests_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // customers_tableTableAdapter1
            // 
            this.customers_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // safe_outcome_tableTableAdapter1
            // 
            this.safe_outcome_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // safe_tableTableAdapter1
            // 
            this.safe_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // far3_txt
            // 
            this.far3_txt.AutoSize = true;
            this.far3_txt.Location = new System.Drawing.Point(12, 51);
            this.far3_txt.Name = "far3_txt";
            this.far3_txt.Size = new System.Drawing.Size(27, 13);
            this.far3_txt.TabIndex = 123258;
            this.far3_txt.Text = "far3";
            // 
            // aksat_tableTableAdapter1
            // 
            this.aksat_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // deleted_tableTableAdapter1
            // 
            this.deleted_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // safe_income_tableTableAdapter1
            // 
            this.safe_income_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // deleted_tableTableAdapter2
            // 
            this.deleted_tableTableAdapter2.ClearBeforeFill = true;
            // 
            // loan_delete
            // 
            this.AcceptButton = this.delete_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exit_btn;
            this.ClientSize = new System.Drawing.Size(654, 147);
            this.Controls.Add(this.far3_txt);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.loan_name_txt);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.user_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loan_delete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حذف تمويل";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label user_txt;
        private System.Windows.Forms.Button exit_btn;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button delete_btn;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.loans_requests_tableTableAdapter loans_requests_tableTableAdapter1;
        private DataSet1TableAdapters.customersTableAdapter customers_tableTableAdapter1;
     //   private DataSet1TableAdapters.productivity_tableTableAdapter productivity_tableTableAdapter1;
        private DataSet1TableAdapters.outcome_tableTableAdapter safe_outcome_tableTableAdapter1;
        private DataSet1TableAdapters.safeTableAdapter safe_tableTableAdapter1;
        public System.Windows.Forms.Label far3_txt;
       // private DataSet1TableAdapters.pay_order_tableTableAdapter pay_order_tableTableAdapter1;
        private DataSet1TableAdapters.aksat_tableTableAdapter aksat_tableTableAdapter1;
        private DataSet1TableAdapters.deleted_tableTableAdapter deleted_tableTableAdapter1;
        private DataSet1TableAdapters.income_tableTableAdapter safe_income_tableTableAdapter1;
        public System.Windows.Forms.TextBox loan_name_txt;
        private DataSet1TableAdapters.deleted_tableTableAdapter deleted_tableTableAdapter2;
    }
}