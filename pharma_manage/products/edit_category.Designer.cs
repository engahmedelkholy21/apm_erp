namespace pharma_manage
{
    partial class edit_category
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
            this.save_btn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.notes_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dariba_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.categoryTableAdapter1 = new pharma_manage.DataSet1TableAdapters.CategoryTableAdapter();
            this.dataSet11 = new pharma_manage.DataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cat_id = new System.Windows.Forms.Label();
            this.products_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.products_tableTableAdapter();
            this.sales_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.sales_tableTableAdapter();
            this.far3txt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cat_extra_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // usertxt
            // 
            this.usertxt.AutoSize = true;
            this.usertxt.Location = new System.Drawing.Point(81, 119);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(27, 13);
            this.usertxt.TabIndex = 123240;
            this.usertxt.Text = "user";
            this.usertxt.Visible = false;
            // 
            // save_btn
            // 
            this.save_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.save_btn.BackColor = System.Drawing.Color.Green;
            this.save_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.save_btn.FlatAppearance.BorderSize = 2;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.save_btn.Location = new System.Drawing.Point(285, 159);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(224, 34);
            this.save_btn.TabIndex = 4;
            this.save_btn.Text = "تعديل الفئـة";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(562, 102);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(69, 14);
            this.label11.TabIndex = 123238;
            this.label11.Text = "ملاحظــــات";
            // 
            // notes_txt
            // 
            this.notes_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.notes_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notes_txt.Location = new System.Drawing.Point(206, 98);
            this.notes_txt.Name = "notes_txt";
            this.notes_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.notes_txt.Size = new System.Drawing.Size(355, 22);
            this.notes_txt.TabIndex = 3;
            this.notes_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(285, 67);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(82, 14);
            this.label3.TabIndex = 123236;
            this.label3.Text = "قيمة الضريبة";
            // 
            // dariba_txt
            // 
            this.dariba_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dariba_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dariba_txt.Location = new System.Drawing.Point(60, 62);
            this.dariba_txt.Name = "dariba_txt";
            this.dariba_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dariba_txt.Size = new System.Drawing.Size(213, 22);
            this.dariba_txt.TabIndex = 2;
            this.dariba_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(700, 67);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(104, 14);
            this.label2.TabIndex = 123234;
            this.label2.Text = "اسم الفئة الجديد";
            // 
            // name_txt
            // 
            this.name_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txt.Location = new System.Drawing.Point(481, 62);
            this.name_txt.Name = "name_txt";
            this.name_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_txt.Size = new System.Drawing.Size(213, 22);
            this.name_txt.TabIndex = 1;
            this.name_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // categoryTableAdapter1
            // 
            this.categoryTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(522, 28);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(108, 14);
            this.label1.TabIndex = 123242;
            this.label1.Text = "اسم الفئة الحالي";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(207, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(292, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cat_id
            // 
            this.cat_id.AutoSize = true;
            this.cat_id.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.cat_id.Location = new System.Drawing.Point(12, 25);
            this.cat_id.Name = "cat_id";
            this.cat_id.Size = new System.Drawing.Size(0, 14);
            this.cat_id.TabIndex = 123243;
            // 
            // products_tableTableAdapter1
            // 
            this.products_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // sales_tableTableAdapter1
            // 
            this.sales_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // far3txt
            // 
            this.far3txt.AutoSize = true;
            this.far3txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.far3txt.Location = new System.Drawing.Point(754, 28);
            this.far3txt.Name = "far3txt";
            this.far3txt.Size = new System.Drawing.Size(32, 14);
            this.far3txt.TabIndex = 123253;
            this.far3txt.Text = "far3";
            this.far3txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.far3txt.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(563, 136);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(134, 14);
            this.label4.TabIndex = 123255;
            this.label4.Text = "اضافي الفئة(اختياري)";
            // 
            // cat_extra_txt
            // 
            this.cat_extra_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cat_extra_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cat_extra_txt.Location = new System.Drawing.Point(207, 132);
            this.cat_extra_txt.Name = "cat_extra_txt";
            this.cat_extra_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cat_extra_txt.Size = new System.Drawing.Size(355, 22);
            this.cat_extra_txt.TabIndex = 123254;
            this.cat_extra_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // edit_category
            // 
            this.AcceptButton = this.save_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 205);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cat_extra_txt);
            this.Controls.Add(this.far3txt);
            this.Controls.Add(this.cat_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.notes_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dariba_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_txt);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(852, 244);
            this.MinimumSize = new System.Drawing.Size(852, 244);
            this.Name = "edit_category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "edit_category";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.edit_category_FormClosing);
            this.Load += new System.EventHandler(this.edit_category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label usertxt;
        private System.Windows.Forms.Button save_btn;
        public System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox notes_txt;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dariba_txt;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_txt;
        private DataSet1TableAdapters.CategoryTableAdapter categoryTableAdapter1;
        private DataSet1 dataSet11;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label cat_id;
        private DataSet1TableAdapters.products_tableTableAdapter products_tableTableAdapter1;
        private DataSet1TableAdapters.sales_tableTableAdapter sales_tableTableAdapter1;
        public System.Windows.Forms.Label far3txt;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cat_extra_txt;
    }
}