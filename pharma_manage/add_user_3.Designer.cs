namespace pharma_manage
{
    partial class add_user_3
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
            this.typeTXT = new System.Windows.Forms.Label();
            this.flowPanel_subItems = new System.Windows.Forms.FlowLayoutPanel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.user_txt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.confirm_password_TXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.usernameTXT = new System.Windows.Forms.TextBox();
            this.user_previligesTableAdapter1 = new pharma_manage.DataSet1TableAdapters.user_previligesTableAdapter();
            this.dataSet11 = new pharma_manage.DataSet1();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stock_txt = new System.Windows.Forms.ComboBox();
            this.stocktableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stock_tableTableAdapter = new pharma_manage.DataSet1TableAdapters.stock_tableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocktableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // typeTXT
            // 
            this.typeTXT.AutoSize = true;
            this.typeTXT.Location = new System.Drawing.Point(88, 21);
            this.typeTXT.Name = "typeTXT";
            this.typeTXT.Size = new System.Drawing.Size(29, 13);
            this.typeTXT.TabIndex = 148;
            this.typeTXT.Text = "type";
            this.typeTXT.Visible = false;
            // 
            // flowPanel_subItems
            // 
            this.flowPanel_subItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowPanel_subItems.Location = new System.Drawing.Point(11, 61);
            this.flowPanel_subItems.Name = "flowPanel_subItems";
            this.flowPanel_subItems.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowPanel_subItems.Size = new System.Drawing.Size(1241, 597);
            this.flowPanel_subItems.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(-6, 15);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 146;
            this.listBox1.Visible = false;
            // 
            // add_btn
            // 
            this.add_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.add_btn.BackColor = System.Drawing.Color.Green;
            this.add_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Location = new System.Drawing.Point(548, 672);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(175, 30);
            this.add_btn.TabIndex = 5;
            this.add_btn.Text = "إضافة المستخدم";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // user_txt
            // 
            this.user_txt.AutoSize = true;
            this.user_txt.Location = new System.Drawing.Point(807, 601);
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(28, 13);
            this.user_txt.TabIndex = 147;
            this.user_txt.Text = "user";
            this.user_txt.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(133, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 14);
            this.label2.TabIndex = 145;
            this.label2.Text = "تأكيد كلمة السر";
            // 
            // confirm_password_TXT
            // 
            this.confirm_password_TXT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.confirm_password_TXT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_password_TXT.Location = new System.Drawing.Point(70, 33);
            this.confirm_password_TXT.Name = "confirm_password_TXT";
            this.confirm_password_TXT.PasswordChar = '*';
            this.confirm_password_TXT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.confirm_password_TXT.Size = new System.Drawing.Size(224, 22);
            this.confirm_password_TXT.TabIndex = 3;
            this.confirm_password_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(447, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 144;
            this.label1.Text = "كلمة السر";
            // 
            // passwordTXT
            // 
            this.passwordTXT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordTXT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTXT.Location = new System.Drawing.Point(368, 33);
            this.passwordTXT.Name = "passwordTXT";
            this.passwordTXT.PasswordChar = '*';
            this.passwordTXT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.passwordTXT.Size = new System.Drawing.Size(224, 22);
            this.passwordTXT.TabIndex = 2;
            this.passwordTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1029, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 14);
            this.label3.TabIndex = 143;
            this.label3.Text = "اسم المستخدم";
            // 
            // usernameTXT
            // 
            this.usernameTXT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.usernameTXT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTXT.Location = new System.Drawing.Point(965, 33);
            this.usernameTXT.Name = "usernameTXT";
            this.usernameTXT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.usernameTXT.Size = new System.Drawing.Size(224, 22);
            this.usernameTXT.TabIndex = 0;
            this.usernameTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // user_previligesTableAdapter1
            // 
            this.user_previligesTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(1090, 680);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(165, 22);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "تحديد كل الصلاحيات";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(755, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 14);
            this.label4.TabIndex = 152;
            this.label4.Text = "الفــــرع";
            // 
            // stock_txt
            // 
            this.stock_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.stock_txt.DataSource = this.stocktableBindingSource;
            this.stock_txt.DisplayMember = "stock_name";
            this.stock_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.stock_txt.FormattingEnabled = true;
            this.stock_txt.Location = new System.Drawing.Point(679, 33);
            this.stock_txt.Name = "stock_txt";
            this.stock_txt.Size = new System.Drawing.Size(201, 22);
            this.stock_txt.TabIndex = 1;
            this.stock_txt.ValueMember = "stock_name";
            // 
            // stocktableBindingSource
            // 
            this.stocktableBindingSource.DataMember = "stock_table";
            this.stocktableBindingSource.DataSource = this.dataSet11;
            // 
            // stock_tableTableAdapter
            // 
            this.stock_tableTableAdapter.ClearBeforeFill = true;
            // 
            // add_user
            // 
            this.AcceptButton = this.add_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 714);
            this.Controls.Add(this.stock_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.typeTXT);
            this.Controls.Add(this.flowPanel_subItems);
            this.Controls.Add(this.user_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.confirm_password_TXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTXT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usernameTXT);
            this.Controls.Add(this.listBox1);
            this.KeyPreview = true;
            this.Name = "add_user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "add_user";
            this.Load += new System.EventHandler(this.add_user_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.add_user_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocktableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label typeTXT;
        private System.Windows.Forms.FlowLayoutPanel flowPanel_subItems;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label user_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox confirm_password_TXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordTXT;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox usernameTXT;
        private DataSet1TableAdapters.user_previligesTableAdapter user_previligesTableAdapter1;
        private DataSet1 dataSet11;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox stock_txt;
        private System.Windows.Forms.BindingSource stocktableBindingSource;
        private DataSet1TableAdapters.stock_tableTableAdapter stock_tableTableAdapter;
    }
}