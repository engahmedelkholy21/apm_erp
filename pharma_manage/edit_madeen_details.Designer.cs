namespace pharma_manage
{
    partial class edit_madeen_details
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
            this.label7 = new System.Windows.Forms.Label();
            this.kest_num_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fatora_id_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tafaseel_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.notes_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.est7kak_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.paid_date_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.kest_cost = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.status_txt = new System.Windows.Forms.TextBox();
            this.fatora_date = new System.Windows.Forms.DateTimePicker();
            this.old_kest_txt = new System.Windows.Forms.Label();
            this.addbtn = new System.Windows.Forms.Button();
            this.old_status_txt = new System.Windows.Forms.Label();
            this.old_paid_date_txt = new System.Windows.Forms.Label();
            this.madeen_name_txt = new System.Windows.Forms.Label();
            this.madeen_small_reportTableAdapter1 = new pharma_manage.DataSet1TableAdapters.madeen_small_reportTableAdapter();
            this.madeen_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.madeen_tableTableAdapter();
            this.dataSet11 = new pharma_manage.DataSet1();
            this.income_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.income_tableTableAdapter();
            this.sales_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.sales_tableTableAdapter();
            this.safeTableAdapter1 = new pharma_manage.DataSet1TableAdapters.safeTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.daftartxt = new System.Windows.Forms.TextBox();
            this.far3txt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(425, 25);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(72, 14);
            this.label7.TabIndex = 106;
            this.label7.Text = "رقم القسط";
            // 
            // kest_num_txt
            // 
            this.kest_num_txt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.kest_num_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kest_num_txt.Location = new System.Drawing.Point(269, 22);
            this.kest_num_txt.Name = "kest_num_txt";
            this.kest_num_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.kest_num_txt.Size = new System.Drawing.Size(144, 22);
            this.kest_num_txt.TabIndex = 105;
            this.kest_num_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kest_num_txt.TextChanged += new System.EventHandler(this.kest_num_txt_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(658, 65);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(81, 14);
            this.label1.TabIndex = 108;
            this.label1.Text = "تاريخ الفاتورة";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 68);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(76, 14);
            this.label2.TabIndex = 110;
            this.label2.Text = "رقم الفاتورة";
            // 
            // fatora_id_txt
            // 
            this.fatora_id_txt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.fatora_id_txt.Enabled = false;
            this.fatora_id_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatora_id_txt.Location = new System.Drawing.Point(77, 65);
            this.fatora_id_txt.Name = "fatora_id_txt";
            this.fatora_id_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fatora_id_txt.Size = new System.Drawing.Size(200, 22);
            this.fatora_id_txt.TabIndex = 1;
            this.fatora_id_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(674, 102);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(48, 14);
            this.label3.TabIndex = 112;
            this.label3.Text = "تفاصيل";
            // 
            // tafaseel_txt
            // 
            this.tafaseel_txt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tafaseel_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tafaseel_txt.Location = new System.Drawing.Point(443, 98);
            this.tafaseel_txt.Name = "tafaseel_txt";
            this.tafaseel_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tafaseel_txt.Size = new System.Drawing.Size(200, 22);
            this.tafaseel_txt.TabIndex = 2;
            this.tafaseel_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(304, 104);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(57, 14);
            this.label4.TabIndex = 114;
            this.label4.Text = "ملاحظات";
            // 
            // notes_txt
            // 
            this.notes_txt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.notes_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notes_txt.Location = new System.Drawing.Point(77, 101);
            this.notes_txt.Name = "notes_txt";
            this.notes_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.notes_txt.Size = new System.Drawing.Size(200, 22);
            this.notes_txt.TabIndex = 3;
            this.notes_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(282, 140);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(100, 14);
            this.label5.TabIndex = 116;
            this.label5.Text = "تاريخ الاستحقاق";
            // 
            // est7kak_txt
            // 
            this.est7kak_txt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.est7kak_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.est7kak_txt.Location = new System.Drawing.Point(77, 137);
            this.est7kak_txt.Name = "est7kak_txt";
            this.est7kak_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.est7kak_txt.Size = new System.Drawing.Size(200, 22);
            this.est7kak_txt.TabIndex = 5;
            this.est7kak_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(298, 176);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(68, 14);
            this.label6.TabIndex = 118;
            this.label6.Text = "تاريخ الدفع";
            // 
            // paid_date_txt
            // 
            this.paid_date_txt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.paid_date_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paid_date_txt.Location = new System.Drawing.Point(77, 173);
            this.paid_date_txt.Name = "paid_date_txt";
            this.paid_date_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.paid_date_txt.Size = new System.Drawing.Size(200, 22);
            this.paid_date_txt.TabIndex = 7;
            this.paid_date_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(659, 139);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(78, 14);
            this.label8.TabIndex = 120;
            this.label8.Text = "قيمة القسط";
            // 
            // kest_cost
            // 
            this.kest_cost.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.kest_cost.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kest_cost.Location = new System.Drawing.Point(443, 136);
            this.kest_cost.Name = "kest_cost";
            this.kest_cost.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.kest_cost.Size = new System.Drawing.Size(200, 22);
            this.kest_cost.TabIndex = 4;
            this.kest_cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(678, 176);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(40, 14);
            this.label9.TabIndex = 122;
            this.label9.Text = "الحالة";
            // 
            // status_txt
            // 
            this.status_txt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.status_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_txt.Location = new System.Drawing.Point(443, 174);
            this.status_txt.Name = "status_txt";
            this.status_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.status_txt.Size = new System.Drawing.Size(200, 22);
            this.status_txt.TabIndex = 6;
            this.status_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fatora_date
            // 
            this.fatora_date.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.fatora_date.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatora_date.Location = new System.Drawing.Point(443, 60);
            this.fatora_date.Name = "fatora_date";
            this.fatora_date.Size = new System.Drawing.Size(200, 22);
            this.fatora_date.TabIndex = 0;
            this.fatora_date.Value = new System.DateTime(2017, 11, 29, 0, 0, 0, 0);
            // 
            // old_kest_txt
            // 
            this.old_kest_txt.AutoSize = true;
            this.old_kest_txt.Location = new System.Drawing.Point(12, 11);
            this.old_kest_txt.Name = "old_kest_txt";
            this.old_kest_txt.Size = new System.Drawing.Size(47, 13);
            this.old_kest_txt.TabIndex = 124;
            this.old_kest_txt.Text = "old_kest";
            this.old_kest_txt.Visible = false;
            // 
            // addbtn
            // 
            this.addbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addbtn.BackColor = System.Drawing.Color.Green;
            this.addbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addbtn.FlatAppearance.BorderSize = 2;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addbtn.Location = new System.Drawing.Point(326, 231);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(117, 26);
            this.addbtn.TabIndex = 9;
            this.addbtn.Text = "تعديــــل";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // old_status_txt
            // 
            this.old_status_txt.AutoSize = true;
            this.old_status_txt.Location = new System.Drawing.Point(12, 31);
            this.old_status_txt.Name = "old_status_txt";
            this.old_status_txt.Size = new System.Drawing.Size(57, 13);
            this.old_status_txt.TabIndex = 126;
            this.old_status_txt.Text = "old_status";
            this.old_status_txt.Visible = false;
            // 
            // old_paid_date_txt
            // 
            this.old_paid_date_txt.AutoSize = true;
            this.old_paid_date_txt.Location = new System.Drawing.Point(12, 49);
            this.old_paid_date_txt.Name = "old_paid_date_txt";
            this.old_paid_date_txt.Size = new System.Drawing.Size(75, 13);
            this.old_paid_date_txt.TabIndex = 127;
            this.old_paid_date_txt.Text = "old_paid_date";
            this.old_paid_date_txt.Visible = false;
            // 
            // madeen_name_txt
            // 
            this.madeen_name_txt.AutoSize = true;
            this.madeen_name_txt.Location = new System.Drawing.Point(114, 11);
            this.madeen_name_txt.Name = "madeen_name_txt";
            this.madeen_name_txt.Size = new System.Drawing.Size(77, 13);
            this.madeen_name_txt.TabIndex = 128;
            this.madeen_name_txt.Text = "madeen_name";
            this.madeen_name_txt.Visible = false;
            // 
            // madeen_small_reportTableAdapter1
            // 
            this.madeen_small_reportTableAdapter1.ClearBeforeFill = true;
            // 
            // madeen_tableTableAdapter1
            // 
            this.madeen_tableTableAdapter1.ClearBeforeFill = true;
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
            // sales_tableTableAdapter1
            // 
            this.sales_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // safeTableAdapter1
            // 
            this.safeTableAdapter1.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(529, 207);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(40, 14);
            this.label10.TabIndex = 130;
            this.label10.Text = "الدفتر";
            // 
            // daftartxt
            // 
            this.daftartxt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.daftartxt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daftartxt.Location = new System.Drawing.Point(187, 204);
            this.daftartxt.Name = "daftartxt";
            this.daftartxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.daftartxt.Size = new System.Drawing.Size(326, 22);
            this.daftartxt.TabIndex = 8;
            this.daftartxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // far3txt
            // 
            this.far3txt.AutoSize = true;
            this.far3txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.far3txt.Location = new System.Drawing.Point(367, 121);
            this.far3txt.Name = "far3txt";
            this.far3txt.Size = new System.Drawing.Size(32, 14);
            this.far3txt.TabIndex = 131;
            this.far3txt.Text = "far3";
            this.far3txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edit_madeen_details
            // 
            this.AcceptButton = this.addbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 256);
            this.Controls.Add(this.far3txt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.daftartxt);
            this.Controls.Add(this.madeen_name_txt);
            this.Controls.Add(this.old_paid_date_txt);
            this.Controls.Add(this.old_status_txt);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.old_kest_txt);
            this.Controls.Add(this.fatora_date);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.status_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.kest_cost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.paid_date_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.est7kak_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.notes_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tafaseel_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fatora_id_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.kest_num_txt);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(783, 295);
            this.MinimumSize = new System.Drawing.Size(783, 295);
            this.Name = "edit_madeen_details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "edit_madeen_details";
            this.Load += new System.EventHandler(this.edit_madeen_details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox kest_num_txt;
        public System.Windows.Forms.TextBox fatora_id_txt;
        public System.Windows.Forms.TextBox tafaseel_txt;
        public System.Windows.Forms.TextBox notes_txt;
        public System.Windows.Forms.TextBox est7kak_txt;
        public System.Windows.Forms.TextBox paid_date_txt;
        public System.Windows.Forms.TextBox kest_cost;
        public System.Windows.Forms.TextBox status_txt;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.DateTimePicker fatora_date;
        public System.Windows.Forms.Label old_kest_txt;
        private System.Windows.Forms.Button addbtn;
        public System.Windows.Forms.Label old_status_txt;
        public System.Windows.Forms.Label old_paid_date_txt;
        public System.Windows.Forms.Label madeen_name_txt;
        private DataSet1TableAdapters.madeen_small_reportTableAdapter madeen_small_reportTableAdapter1;
        private DataSet1TableAdapters.madeen_tableTableAdapter madeen_tableTableAdapter1;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.income_tableTableAdapter income_tableTableAdapter1;
        private DataSet1TableAdapters.sales_tableTableAdapter sales_tableTableAdapter1;
        private DataSet1TableAdapters.safeTableAdapter safeTableAdapter1;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox daftartxt;
        public System.Windows.Forms.Label far3txt;
    }
}