namespace pharma_manage
{
    partial class add_da2n
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
            this.usertxt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.save_brn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.madfoo3txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.matloobtxt = new System.Windows.Forms.TextBox();
            this.madeen_nameTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mwardeenTableAdapter1 = new pharma_manage.DataSet1TableAdapters.mwardeenTableAdapter();
            this.da2n_small_reportsTableAdapter1 = new pharma_manage.DataSet1TableAdapters.da2n_small_reportsTableAdapter();
            this.dataSet11 = new pharma_manage.DataSet1();
            this.income_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.income_tableTableAdapter();
            this.safeTableAdapter1 = new pharma_manage.DataSet1TableAdapters.safeTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.notes_txt = new System.Windows.Forms.TextBox();
            this.mosta7akat_da2neen_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.mosta7akat_da2neen_tableTableAdapter();
            this.far3txt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // usertxt
            // 
            this.usertxt.AutoSize = true;
            this.usertxt.Location = new System.Drawing.Point(38, 12);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(28, 13);
            this.usertxt.TabIndex = 99;
            this.usertxt.Text = "user";
            this.usertxt.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(162, 11);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(85, 14);
            this.label8.TabIndex = 98;
            this.label8.Text = "إضـــافــة دائن";
            // 
            // save_brn
            // 
            this.save_brn.BackColor = System.Drawing.Color.Green;
            this.save_brn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.save_brn.FlatAppearance.BorderSize = 2;
            this.save_brn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_brn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_brn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.save_brn.Location = new System.Drawing.Point(114, 227);
            this.save_brn.Name = "save_brn";
            this.save_brn.Size = new System.Drawing.Size(177, 34);
            this.save_brn.TabIndex = 4;
            this.save_brn.Text = "إضافة الدائن";
            this.save_brn.UseVisualStyleBackColor = false;
            this.save_brn.Click += new System.EventHandler(this.save_brn_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 134);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(99, 14);
            this.label4.TabIndex = 96;
            this.label4.Text = "إجمالي المدفوع";
            // 
            // madfoo3txt
            // 
            this.madfoo3txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.madfoo3txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.madfoo3txt.Location = new System.Drawing.Point(32, 131);
            this.madfoo3txt.Name = "madfoo3txt";
            this.madfoo3txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.madfoo3txt.Size = new System.Drawing.Size(229, 22);
            this.madfoo3txt.TabIndex = 2;
            this.madfoo3txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(274, 88);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(103, 14);
            this.label5.TabIndex = 95;
            this.label5.Text = "إجمالي المطلوب";
            // 
            // matloobtxt
            // 
            this.matloobtxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.matloobtxt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matloobtxt.Location = new System.Drawing.Point(32, 85);
            this.matloobtxt.Name = "matloobtxt";
            this.matloobtxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.matloobtxt.Size = new System.Drawing.Size(229, 22);
            this.matloobtxt.TabIndex = 1;
            this.matloobtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // madeen_nameTXT
            // 
            this.madeen_nameTXT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.madeen_nameTXT.Location = new System.Drawing.Point(32, 39);
            this.madeen_nameTXT.Name = "madeen_nameTXT";
            this.madeen_nameTXT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.madeen_nameTXT.Size = new System.Drawing.Size(229, 22);
            this.madeen_nameTXT.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 42);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 91;
            this.label1.Text = "إسم الدائن";
            // 
            // mwardeenTableAdapter1
            // 
            this.mwardeenTableAdapter1.ClearBeforeFill = true;
            // 
            // da2n_small_reportsTableAdapter1
            // 
            this.da2n_small_reportsTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // income_tableTableAdapter1
            // 
            this.income_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // safeTableAdapter1
            // 
            this.safeTableAdapter1.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 181);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(87, 14);
            this.label2.TabIndex = 101;
            this.label2.Text = "ملاحظــــــــــات";
            // 
            // notes_txt
            // 
            this.notes_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.notes_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notes_txt.Location = new System.Drawing.Point(32, 178);
            this.notes_txt.Name = "notes_txt";
            this.notes_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.notes_txt.Size = new System.Drawing.Size(229, 22);
            this.notes_txt.TabIndex = 3;
            this.notes_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mosta7akat_da2neen_tableTableAdapter1
            // 
            this.mosta7akat_da2neen_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // far3txt
            // 
            this.far3txt.AutoSize = true;
            this.far3txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.far3txt.Location = new System.Drawing.Point(188, 135);
            this.far3txt.Name = "far3txt";
            this.far3txt.Size = new System.Drawing.Size(32, 14);
            this.far3txt.TabIndex = 123255;
            this.far3txt.Text = "far3";
            this.far3txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.far3txt.Visible = false;
            // 
            // add_da2n
            // 
            this.AcceptButton = this.save_brn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 285);
            this.Controls.Add(this.far3txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.notes_txt);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.save_brn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.madfoo3txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.matloobtxt);
            this.Controls.Add(this.madeen_nameTXT);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(425, 324);
            this.MinimumSize = new System.Drawing.Size(425, 260);
            this.Name = "add_da2n";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add_da2n";
            this.Load += new System.EventHandler(this.add_da2n_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label usertxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button save_brn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox madfoo3txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox matloobtxt;
        private System.Windows.Forms.TextBox madeen_nameTXT;
        private System.Windows.Forms.Label label1;
        private DataSet1TableAdapters.mwardeenTableAdapter mwardeenTableAdapter1;
        private DataSet1TableAdapters.da2n_small_reportsTableAdapter da2n_small_reportsTableAdapter1;
       // private DataSet1TableAdapters.da2n_tableTableAdapter da2n_tableTableAdapter1;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.income_tableTableAdapter income_tableTableAdapter1;
        private DataSet1TableAdapters.safeTableAdapter safeTableAdapter1;
       // private DataSet1TableAdapters.safe_users_tableTableAdapter safe_users_tableTableAdapter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox notes_txt;
        private DataSet1TableAdapters.mosta7akat_da2neen_tableTableAdapter mosta7akat_da2neen_tableTableAdapter1;
        public System.Windows.Forms.Label far3txt;
    }
}