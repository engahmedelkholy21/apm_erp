namespace pharma_manage
{
    partial class add_halek
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
            this.id_txt = new System.Windows.Forms.Label();
            this.user_txt = new System.Windows.Forms.Label();
            this.count_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.notes_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.halek_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.halek_tableTableAdapter();
            this.products_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.products_tableTableAdapter();
            this.dataSet11 = new pharma_manage.DataSet1();
            this.stock_txt = new System.Windows.Forms.Label();
            this.ma5zoon_movesTableAdapter1 = new pharma_manage.DataSet1TableAdapters.ma5zoon_movesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // id_txt
            // 
            this.id_txt.AutoSize = true;
            this.id_txt.Location = new System.Drawing.Point(83, 34);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(32, 13);
            this.id_txt.TabIndex = 20;
            this.id_txt.Text = "id_txt";
            this.id_txt.Visible = false;
            // 
            // user_txt
            // 
            this.user_txt.AutoSize = true;
            this.user_txt.Location = new System.Drawing.Point(29, 174);
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(44, 13);
            this.user_txt.TabIndex = 19;
            this.user_txt.Text = "user_txt";
            this.user_txt.Visible = false;
            // 
            // count_txt
            // 
            this.count_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.count_txt.Location = new System.Drawing.Point(46, 106);
            this.count_txt.Name = "count_txt";
            this.count_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.count_txt.Size = new System.Drawing.Size(357, 22);
            this.count_txt.TabIndex = 0;
            this.count_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(412, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 14);
            this.label3.TabIndex = 17;
            this.label3.Text = "الكـــــمـيــــة";
            // 
            // name_txt
            // 
            this.name_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.name_txt.Location = new System.Drawing.Point(46, 51);
            this.name_txt.Name = "name_txt";
            this.name_txt.ReadOnly = true;
            this.name_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_txt.Size = new System.Drawing.Size(357, 22);
            this.name_txt.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 14);
            this.label1.TabIndex = 15;
            this.label1.Text = "اسم الصنف";
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.save_btn.Location = new System.Drawing.Point(170, 196);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(208, 30);
            this.save_btn.TabIndex = 2;
            this.save_btn.Text = "حــــفـــــظ";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // notes_txt
            // 
            this.notes_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.notes_txt.Location = new System.Drawing.Point(46, 152);
            this.notes_txt.Name = "notes_txt";
            this.notes_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.notes_txt.Size = new System.Drawing.Size(357, 22);
            this.notes_txt.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(420, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 14);
            this.label6.TabIndex = 22;
            this.label6.Text = "ملاحظات";
            // 
            // halek_tableTableAdapter1
            // 
            this.halek_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // products_tableTableAdapter1
            // 
            this.products_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stock_txt
            // 
            this.stock_txt.AutoSize = true;
            this.stock_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.stock_txt.Location = new System.Drawing.Point(343, 25);
            this.stock_txt.Name = "stock_txt";
            this.stock_txt.Size = new System.Drawing.Size(67, 14);
            this.stock_txt.TabIndex = 24;
            this.stock_txt.Text = "stock_txt";
            this.stock_txt.Visible = false;
            // 
            // ma5zoon_movesTableAdapter1
            // 
            this.ma5zoon_movesTableAdapter1.ClearBeforeFill = true;
            // 
            // add_halek
            // 
            this.AcceptButton = this.save_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 251);
            this.Controls.Add(this.stock_txt);
            this.Controls.Add(this.notes_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.user_txt);
            this.Controls.Add(this.count_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.label1);
            this.Name = "add_halek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add_halek";
            this.Load += new System.EventHandler(this.add_halek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label id_txt;
        public System.Windows.Forms.Label user_txt;
        private System.Windows.Forms.TextBox count_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save_btn;
        private DataSet1TableAdapters.halek_tableTableAdapter halek_tableTableAdapter1;
        private DataSet1TableAdapters.products_tableTableAdapter products_tableTableAdapter1;
        private System.Windows.Forms.TextBox notes_txt;
        private System.Windows.Forms.Label label6;
        private DataSet1 dataSet11;
        public System.Windows.Forms.TextBox name_txt;
        public System.Windows.Forms.Label stock_txt;
        private DataSet1TableAdapters.ma5zoon_movesTableAdapter ma5zoon_movesTableAdapter1;
    }
}