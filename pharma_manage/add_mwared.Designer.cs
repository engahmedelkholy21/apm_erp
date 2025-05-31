namespace pharma_manage
{
    partial class add_mwared
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
            this.cst_addressTXT = new System.Windows.Forms.TextBox();
            this.cst_phoneTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.notesTXT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.save_brn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cst_nameTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSet11 = new pharma_manage.DataSet1();
            this.mwardeenTableAdapter1 = new pharma_manage.DataSet1TableAdapters.mwardeenTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // cst_addressTXT
            // 
            this.cst_addressTXT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cst_addressTXT.Location = new System.Drawing.Point(45, 117);
            this.cst_addressTXT.Name = "cst_addressTXT";
            this.cst_addressTXT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cst_addressTXT.Size = new System.Drawing.Size(253, 22);
            this.cst_addressTXT.TabIndex = 113;
            // 
            // cst_phoneTXT
            // 
            this.cst_phoneTXT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cst_phoneTXT.Location = new System.Drawing.Point(45, 77);
            this.cst_phoneTXT.Name = "cst_phoneTXT";
            this.cst_phoneTXT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cst_phoneTXT.Size = new System.Drawing.Size(253, 22);
            this.cst_phoneTXT.TabIndex = 112;
            this.cst_phoneTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(319, 160);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(69, 14);
            this.label2.TabIndex = 120;
            this.label2.Text = "ملاحظــــات";
            // 
            // notesTXT
            // 
            this.notesTXT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.notesTXT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesTXT.Location = new System.Drawing.Point(45, 157);
            this.notesTXT.Name = "notesTXT";
            this.notesTXT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.notesTXT.Size = new System.Drawing.Size(253, 22);
            this.notesTXT.TabIndex = 114;
            this.notesTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(171, 9);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(91, 14);
            this.label8.TabIndex = 119;
            this.label8.Text = "إضـــافــة  مورد";
            // 
            // save_brn
            // 
            this.save_brn.BackColor = System.Drawing.Color.Green;
            this.save_brn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.save_brn.FlatAppearance.BorderSize = 2;
            this.save_brn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_brn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_brn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.save_brn.Location = new System.Drawing.Point(128, 200);
            this.save_brn.Name = "save_brn";
            this.save_brn.Size = new System.Drawing.Size(177, 34);
            this.save_brn.TabIndex = 115;
            this.save_brn.Text = "إضافة العميل";
            this.save_brn.UseVisualStyleBackColor = false;
            this.save_brn.Click += new System.EventHandler(this.save_brn_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(308, 120);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(80, 14);
            this.label4.TabIndex = 118;
            this.label4.Text = "عنوان المورد";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(304, 80);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(84, 14);
            this.label5.TabIndex = 117;
            this.label5.Text = "تليفون المورد";
            // 
            // cst_nameTXT
            // 
            this.cst_nameTXT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cst_nameTXT.Location = new System.Drawing.Point(45, 37);
            this.cst_nameTXT.Name = "cst_nameTXT";
            this.cst_nameTXT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cst_nameTXT.Size = new System.Drawing.Size(253, 22);
            this.cst_nameTXT.TabIndex = 111;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 40);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(73, 14);
            this.label1.TabIndex = 116;
            this.label1.Text = "إسم المورد";
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mwardeenTableAdapter1
            // 
            this.mwardeenTableAdapter1.ClearBeforeFill = true;
            // 
            // add_mwared
            // 
            this.AcceptButton = this.save_brn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 242);
            this.Controls.Add(this.cst_addressTXT);
            this.Controls.Add(this.cst_phoneTXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.notesTXT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.save_brn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cst_nameTXT);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(449, 280);
            this.MinimumSize = new System.Drawing.Size(449, 280);
            this.Name = "add_mwared";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add_mwared";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cst_addressTXT;
        private System.Windows.Forms.TextBox cst_phoneTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox notesTXT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button save_brn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cst_nameTXT;
        private System.Windows.Forms.Label label1;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.mwardeenTableAdapter mwardeenTableAdapter1;
    }
}