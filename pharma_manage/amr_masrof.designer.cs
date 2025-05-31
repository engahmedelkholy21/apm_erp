namespace pharma_manage
{
    partial class amr_masrof
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
            this.far3txt = new System.Windows.Forms.Label();
            this.usertxt = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cost_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.amr_num_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.byan_txt = new System.Windows.Forms.ComboBox();
            this.amr_masrofat_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.amr_masrofat_tableTableAdapter();
            this.dataSet11 = new pharma_manage.DataSet1();
            this.label4 = new System.Windows.Forms.Label();
            this.notes_txt = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.outcome_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.outcome_tableTableAdapter();
            this.safeTableAdapter1 = new pharma_manage.DataSet1TableAdapters.safeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // far3txt
            // 
            this.far3txt.AutoSize = true;
            this.far3txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.far3txt.Location = new System.Drawing.Point(368, 7);
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
            this.usertxt.Location = new System.Drawing.Point(282, 13);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(28, 13);
            this.usertxt.TabIndex = 123258;
            this.usertxt.Text = "user";
            this.usertxt.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(78, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(314, 22);
            this.dateTimePicker1.TabIndex = 123257;
            this.dateTimePicker1.Value = new System.DateTime(2015, 9, 21, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(433, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 14);
            this.label7.TabIndex = 123256;
            this.label7.Text = "التــاريـخ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(439, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 14);
            this.label3.TabIndex = 123255;
            this.label3.Text = "المبلغ";
            // 
            // cost_txt
            // 
            this.cost_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cost_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost_txt.Location = new System.Drawing.Point(78, 191);
            this.cost_txt.Name = "cost_txt";
            this.cost_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cost_txt.Size = new System.Drawing.Size(314, 22);
            this.cost_txt.TabIndex = 2;
            this.cost_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(413, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 14);
            this.label1.TabIndex = 123261;
            this.label1.Text = "رقم امر الشغل";
            // 
            // amr_num_txt
            // 
            this.amr_num_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.amr_num_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amr_num_txt.Location = new System.Drawing.Point(78, 84);
            this.amr_num_txt.Name = "amr_num_txt";
            this.amr_num_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.amr_num_txt.Size = new System.Drawing.Size(314, 22);
            this.amr_num_txt.TabIndex = 0;
            this.amr_num_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.amr_num_txt.TextChanged += new System.EventHandler(this.amr_num_txt_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(440, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 14);
            this.label2.TabIndex = 123263;
            this.label2.Text = "البيان";
            // 
            // byan_txt
            // 
            this.byan_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.byan_txt.FormattingEnabled = true;
            this.byan_txt.Location = new System.Drawing.Point(78, 133);
            this.byan_txt.Name = "byan_txt";
            this.byan_txt.Size = new System.Drawing.Size(314, 22);
            this.byan_txt.TabIndex = 1;
            this.byan_txt.SelectedIndexChanged += new System.EventHandler(this.byan_txt_SelectedIndexChanged);
            this.byan_txt.TextChanged += new System.EventHandler(this.byan_txt_TextChanged);
            // 
            // amr_masrofat_tableTableAdapter1
            // 
            this.amr_masrofat_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(431, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 14);
            this.label4.TabIndex = 123265;
            this.label4.Text = "ملاحظات";
            // 
            // notes_txt
            // 
            this.notes_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.notes_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notes_txt.Location = new System.Drawing.Point(78, 239);
            this.notes_txt.Name = "notes_txt";
            this.notes_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.notes_txt.Size = new System.Drawing.Size(314, 22);
            this.notes_txt.TabIndex = 3;
            this.notes_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button5.BackColor = System.Drawing.Color.Green;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(190, 289);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(175, 40);
            this.button5.TabIndex = 4;
            this.button5.Text = "حــفظ";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // outcome_tableTableAdapter1
            // 
            this.outcome_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // safeTableAdapter1
            // 
            this.safeTableAdapter1.ClearBeforeFill = true;
            // 
            // amr_masrof
            // 
            this.AcceptButton = this.button5;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 358);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.notes_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.byan_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amr_num_txt);
            this.Controls.Add(this.far3txt);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cost_txt);
            this.Name = "amr_masrof";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مصروف امر شغل";
            this.Load += new System.EventHandler(this.amr_masrof_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label far3txt;
        public System.Windows.Forms.Label usertxt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cost_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amr_num_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox byan_txt;
        private DataSet1TableAdapters.amr_masrofat_tableTableAdapter amr_masrofat_tableTableAdapter1;
        private DataSet1 dataSet11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox notes_txt;
        private System.Windows.Forms.Button button5;
        private DataSet1TableAdapters.outcome_tableTableAdapter outcome_tableTableAdapter1;
        private DataSet1TableAdapters.safeTableAdapter safeTableAdapter1;
    }
}