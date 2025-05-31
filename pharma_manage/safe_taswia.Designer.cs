namespace pharma_manage
{
    partial class safe_taswia
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
            this.label6 = new System.Windows.Forms.Label();
            this.safe_raseed = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.current_txt = new System.Windows.Forms.Label();
            this.user_txt = new System.Windows.Forms.Label();
            this.far3_txt = new System.Windows.Forms.Label();
            this.income_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.income_tableTableAdapter();
            this.outcome_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.outcome_tableTableAdapter();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(231, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 14);
            this.label6.TabIndex = 20;
            this.label6.Text = "الرصيد الفعلي";
            // 
            // safe_raseed
            // 
            this.safe_raseed.BackColor = System.Drawing.Color.White;
            this.safe_raseed.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.safe_raseed.Location = new System.Drawing.Point(115, 39);
            this.safe_raseed.Name = "safe_raseed";
            this.safe_raseed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.safe_raseed.Size = new System.Drawing.Size(320, 22);
            this.safe_raseed.TabIndex = 19;
            this.safe_raseed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(156, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 35);
            this.button1.TabIndex = 123251;
            this.button1.Text = "تسوية";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // current_txt
            // 
            this.current_txt.AutoSize = true;
            this.current_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_txt.Location = new System.Drawing.Point(12, 14);
            this.current_txt.Name = "current_txt";
            this.current_txt.Size = new System.Drawing.Size(52, 14);
            this.current_txt.TabIndex = 123252;
            this.current_txt.Text = "current";
            this.current_txt.Visible = false;
            // 
            // user_txt
            // 
            this.user_txt.AutoSize = true;
            this.user_txt.Location = new System.Drawing.Point(407, 119);
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(28, 13);
            this.user_txt.TabIndex = 123290;
            this.user_txt.Text = "user";
            this.user_txt.Visible = false;
            // 
            // far3_txt
            // 
            this.far3_txt.AutoSize = true;
            this.far3_txt.Location = new System.Drawing.Point(190, 119);
            this.far3_txt.Name = "far3_txt";
            this.far3_txt.Size = new System.Drawing.Size(27, 13);
            this.far3_txt.TabIndex = 123291;
            this.far3_txt.Text = "far3";
            this.far3_txt.Visible = false;
            // 
            // income_tableTableAdapter1
            // 
            this.income_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // outcome_tableTableAdapter1
            // 
            this.outcome_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // safe_taswia
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 141);
            this.Controls.Add(this.user_txt);
            this.Controls.Add(this.far3_txt);
            this.Controls.Add(this.current_txt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.safe_raseed);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(548, 180);
            this.MinimumSize = new System.Drawing.Size(548, 180);
            this.Name = "safe_taswia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسوية الخزينة";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox safe_raseed;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label current_txt;
        public System.Windows.Forms.Label user_txt;
        public System.Windows.Forms.Label far3_txt;
        private DataSet1TableAdapters.income_tableTableAdapter income_tableTableAdapter1;
        private DataSet1TableAdapters.outcome_tableTableAdapter outcome_tableTableAdapter1;
    }
}