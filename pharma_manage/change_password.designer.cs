namespace pharma_manage
{
    partial class change_password
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
            this.userpreviligesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new pharma_manage.DataSet1();
            this.label2 = new System.Windows.Forms.Label();
            this.user_previligesTableAdapter = new pharma_manage.DataSet1TableAdapters.user_previligesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.confirm_password_TXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.old_password_txt = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.username_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.userpreviligesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // userpreviligesBindingSource
            // 
            this.userpreviligesBindingSource.DataMember = "user_previliges";
            this.userpreviligesBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(510, 45);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(96, 14);
            this.label2.TabIndex = 76;
            this.label2.Text = "اسم المستخدم";
            // 
            // user_previligesTableAdapter
            // 
            this.user_previligesTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(486, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 14);
            this.label1.TabIndex = 149;
            this.label1.Text = "تأكيد كلمة السر الجديدة";
            // 
            // confirm_password_TXT
            // 
            this.confirm_password_TXT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.confirm_password_TXT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_password_TXT.Location = new System.Drawing.Point(173, 190);
            this.confirm_password_TXT.Name = "confirm_password_TXT";
            this.confirm_password_TXT.PasswordChar = '*';
            this.confirm_password_TXT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.confirm_password_TXT.Size = new System.Drawing.Size(296, 22);
            this.confirm_password_TXT.TabIndex = 3;
            this.confirm_password_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(502, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 14);
            this.label3.TabIndex = 148;
            this.label3.Text = "كلمة السر الجديدة";
            // 
            // passwordTXT
            // 
            this.passwordTXT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordTXT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTXT.Location = new System.Drawing.Point(173, 141);
            this.passwordTXT.Name = "passwordTXT";
            this.passwordTXT.PasswordChar = '*';
            this.passwordTXT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.passwordTXT.Size = new System.Drawing.Size(296, 22);
            this.passwordTXT.TabIndex = 2;
            this.passwordTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(502, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 14);
            this.label4.TabIndex = 151;
            this.label4.Text = "كلمة السر القديمة";
            // 
            // old_password_txt
            // 
            this.old_password_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.old_password_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.old_password_txt.Location = new System.Drawing.Point(173, 92);
            this.old_password_txt.Name = "old_password_txt";
            this.old_password_txt.PasswordChar = '*';
            this.old_password_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.old_password_txt.Size = new System.Drawing.Size(296, 22);
            this.old_password_txt.TabIndex = 1;
            this.old_password_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // add_btn
            // 
            this.add_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.add_btn.BackColor = System.Drawing.Color.Green;
            this.add_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Location = new System.Drawing.Point(282, 236);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(175, 30);
            this.add_btn.TabIndex = 4;
            this.add_btn.Text = "تعديل كلمة السر";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(707, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 19);
            this.label6.TabIndex = 152;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // username_txt
            // 
            this.username_txt.BackColor = System.Drawing.Color.LightYellow;
            this.username_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.username_txt.Location = new System.Drawing.Point(173, 45);
            this.username_txt.Name = "username_txt";
            this.username_txt.ReadOnly = true;
            this.username_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.username_txt.Size = new System.Drawing.Size(296, 28);
            this.username_txt.TabIndex = 123237;
            // 
            // change_password
            // 
            this.AcceptButton = this.add_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 303);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.old_password_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirm_password_TXT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordTXT);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "change_password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تغيير كلمة السر";
            this.Load += new System.EventHandler(this.change_password_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.change_password_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.userpreviligesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource userpreviligesBindingSource;
        private DataSet1TableAdapters.user_previligesTableAdapter user_previligesTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox confirm_password_TXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordTXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox old_password_txt;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox username_txt;
    }
}