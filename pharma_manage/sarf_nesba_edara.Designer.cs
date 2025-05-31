namespace pharma_manage
{
    partial class sarf_nesba_edara
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
            this.partner_txt = new System.Windows.Forms.ComboBox();
            this.partnerssharetableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new pharma_manage.DataSet1();
            this.label5 = new System.Windows.Forms.Label();
            this.partners_share_tableTableAdapter = new pharma_manage.DataSet1TableAdapters.partners_share_tableTableAdapter();
            this.nesba_txt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.far3txt = new System.Windows.Forms.Label();
            this.arba7_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.arba7_tableTableAdapter();
            this.outcome_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.outcome_tableTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.reb7_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.masrofat_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.safy_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mosta7ak_txt = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataSet11 = new pharma_manage.DataSet1();
            this.usertxt = new System.Windows.Forms.Label();
            this.safeTableAdapter1 = new pharma_manage.DataSet1TableAdapters.safeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.partnerssharetableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // partner_txt
            // 
            this.partner_txt.DataSource = this.partnerssharetableBindingSource;
            this.partner_txt.DisplayMember = "partner_name";
            this.partner_txt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.partner_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.partner_txt.FormattingEnabled = true;
            this.partner_txt.Location = new System.Drawing.Point(57, 12);
            this.partner_txt.Name = "partner_txt";
            this.partner_txt.Size = new System.Drawing.Size(314, 22);
            this.partner_txt.TabIndex = 129;
            // 
            // partnerssharetableBindingSource
            // 
            this.partnerssharetableBindingSource.DataMember = "partners_share_table";
            this.partnerssharetableBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(394, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 14);
            this.label5.TabIndex = 130;
            this.label5.Text = "اسم الشريك";
            // 
            // partners_share_tableTableAdapter
            // 
            this.partners_share_tableTableAdapter.ClearBeforeFill = true;
            // 
            // nesba_txt
            // 
            this.nesba_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.nesba_txt.FormattingEnabled = true;
            this.nesba_txt.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45"});
            this.nesba_txt.Location = new System.Drawing.Point(57, 57);
            this.nesba_txt.Name = "nesba_txt";
            this.nesba_txt.Size = new System.Drawing.Size(314, 22);
            this.nesba_txt.TabIndex = 131;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(411, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 14);
            this.label1.TabIndex = 132;
            this.label1.Text = "النسبة";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(220, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 14);
            this.label4.TabIndex = 136;
            this.label4.Text = "إلــــى";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(13, 94);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 134;
            this.dateTimePicker2.Value = new System.DateTime(2015, 9, 21, 0, 0, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(488, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 14);
            this.label3.TabIndex = 135;
            this.label3.Text = "من";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(282, 94);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 133;
            this.dateTimePicker1.Value = new System.DateTime(2015, 9, 21, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // far3txt
            // 
            this.far3txt.AutoSize = true;
            this.far3txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.far3txt.Location = new System.Drawing.Point(19, 12);
            this.far3txt.Name = "far3txt";
            this.far3txt.Size = new System.Drawing.Size(32, 14);
            this.far3txt.TabIndex = 137;
            this.far3txt.Text = "far3";
            this.far3txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.far3txt.Visible = false;
            // 
            // arba7_tableTableAdapter1
            // 
            this.arba7_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // outcome_tableTableAdapter1
            // 
            this.outcome_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(378, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 14);
            this.label7.TabIndex = 123269;
            this.label7.Text = "اجمالي الربح";
            // 
            // reb7_txt
            // 
            this.reb7_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.reb7_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.reb7_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.reb7_txt.Location = new System.Drawing.Point(41, 13);
            this.reb7_txt.Name = "reb7_txt";
            this.reb7_txt.ReadOnly = true;
            this.reb7_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.reb7_txt.Size = new System.Drawing.Size(314, 22);
            this.reb7_txt.TabIndex = 123268;
            this.reb7_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(383, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 14);
            this.label2.TabIndex = 123271;
            this.label2.Text = "المصروفات";
            // 
            // masrofat_txt
            // 
            this.masrofat_txt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.masrofat_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.masrofat_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.masrofat_txt.Location = new System.Drawing.Point(41, 49);
            this.masrofat_txt.Name = "masrofat_txt";
            this.masrofat_txt.ReadOnly = true;
            this.masrofat_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.masrofat_txt.Size = new System.Drawing.Size(314, 22);
            this.masrofat_txt.TabIndex = 123270;
            this.masrofat_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(392, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 14);
            this.label6.TabIndex = 123273;
            this.label6.Text = "الصافي";
            // 
            // safy_txt
            // 
            this.safy_txt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.safy_txt.BackColor = System.Drawing.Color.White;
            this.safy_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.safy_txt.Location = new System.Drawing.Point(41, 86);
            this.safy_txt.Name = "safy_txt";
            this.safy_txt.ReadOnly = true;
            this.safy_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.safy_txt.Size = new System.Drawing.Size(314, 22);
            this.safy_txt.TabIndex = 123272;
            this.safy_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(381, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 14);
            this.label8.TabIndex = 123275;
            this.label8.Text = "القيمة المستحقة";
            // 
            // mosta7ak_txt
            // 
            this.mosta7ak_txt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mosta7ak_txt.BackColor = System.Drawing.Color.White;
            this.mosta7ak_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.mosta7ak_txt.Location = new System.Drawing.Point(57, 259);
            this.mosta7ak_txt.Name = "mosta7ak_txt";
            this.mosta7ak_txt.ReadOnly = true;
            this.mosta7ak_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mosta7ak_txt.Size = new System.Drawing.Size(314, 22);
            this.mosta7ak_txt.TabIndex = 123274;
            this.mosta7ak_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button5.BackColor = System.Drawing.Color.Green;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(158, 293);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(208, 30);
            this.button5.TabIndex = 123276;
            this.button5.Text = "صرف القيمة";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.safy_txt);
            this.groupBox1.Controls.Add(this.reb7_txt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.masrofat_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 121);
            this.groupBox1.TabIndex = 123277;
            this.groupBox1.TabStop = false;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usertxt
            // 
            this.usertxt.AutoSize = true;
            this.usertxt.Location = new System.Drawing.Point(9, 57);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(35, 13);
            this.usertxt.TabIndex = 123278;
            this.usertxt.Text = "admin";
            this.usertxt.Visible = false;
            // 
            // safeTableAdapter1
            // 
            this.safeTableAdapter1.ClearBeforeFill = true;
            // 
            // sarf_nesba_edara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 332);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mosta7ak_txt);
            this.Controls.Add(this.far3txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.nesba_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.partner_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(541, 371);
            this.MinimumSize = new System.Drawing.Size(541, 300);
            this.Name = "sarf_nesba_edara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "صرف نسبة إدارة";
            this.Load += new System.EventHandler(this.sarf_nesba_edara_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partnerssharetableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox partner_txt;
        private System.Windows.Forms.Label label5;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource partnerssharetableBindingSource;
        private DataSet1TableAdapters.partners_share_tableTableAdapter partners_share_tableTableAdapter;
        private System.Windows.Forms.ComboBox nesba_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Label far3txt;
        private DataSet1TableAdapters.arba7_tableTableAdapter arba7_tableTableAdapter1;
        private DataSet1TableAdapters.outcome_tableTableAdapter outcome_tableTableAdapter1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox reb7_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox masrofat_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox safy_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox mosta7ak_txt;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private DataSet1 dataSet11;
        public System.Windows.Forms.Label usertxt;
        private DataSet1TableAdapters.safeTableAdapter safeTableAdapter1;
    }
}