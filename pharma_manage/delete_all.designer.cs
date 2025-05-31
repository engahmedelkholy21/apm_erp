namespace pharma_manage
{
    partial class delete_all
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
            this.label1 = new System.Windows.Forms.Label();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.user_previligesTableAdapter1 = new pharma_manage.DataSet1TableAdapters.user_previligesTableAdapter();
            this.dataSet11 = new pharma_manage.DataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.user_previligesTableAdapter2 = new pharma_manage.DataSet1TableAdapters.user_previligesTableAdapter();
            this.numbers_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.Numbers_tableTableAdapter();
            this.stock_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.stock_tableTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(464, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 123236;
            this.label1.Text = "إسم المستخدم";
            // 
            // password_txt
            // 
            this.password_txt.BackColor = System.Drawing.Color.LightYellow;
            this.password_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.password_txt.Location = new System.Drawing.Point(88, 105);
            this.password_txt.Name = "password_txt";
            this.password_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.password_txt.Size = new System.Drawing.Size(456, 28);
            this.password_txt.TabIndex = 1;
            this.password_txt.UseSystemPasswordChar = true;
            // 
            // username_txt
            // 
            this.username_txt.BackColor = System.Drawing.Color.LightYellow;
            this.username_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.username_txt.Location = new System.Drawing.Point(88, 43);
            this.username_txt.Name = "username_txt";
            this.username_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.username_txt.Size = new System.Drawing.Size(456, 28);
            this.username_txt.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(483, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 123237;
            this.label2.Text = "كلمة السر";
            // 
            // user_previligesTableAdapter1
            // 
            this.user_previligesTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(223, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 33);
            this.button1.TabIndex = 123238;
            this.button1.Text = "مسح جميع البيانات";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // user_previligesTableAdapter2
            // 
            this.user_previligesTableAdapter2.ClearBeforeFill = true;
            // 
            // numbers_tableTableAdapter1
            // 
            this.numbers_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // stock_tableTableAdapter1
            // 
            this.stock_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.LightYellow;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(88, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(456, 37);
            this.comboBox1.TabIndex = 123239;
            // 
            // delete_all
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 211);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_txt);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(648, 250);
            this.MinimumSize = new System.Drawing.Size(648, 250);
            this.Name = "delete_all";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مسح جميع البيانات";
            this.Load += new System.EventHandler(this.delete_all_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox username_txt;
        private DataSet1TableAdapters.user_previligesTableAdapter user_previligesTableAdapter1;
        private DataSet1 dataSet11;
        private System.Windows.Forms.Button button1;
        private DataSet1TableAdapters.user_previligesTableAdapter user_previligesTableAdapter2;
        private DataSet1TableAdapters.Numbers_tableTableAdapter numbers_tableTableAdapter1;
        private DataSet1TableAdapters.stock_tableTableAdapter stock_tableTableAdapter1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}