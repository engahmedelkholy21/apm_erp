namespace pharma_manage
{
    partial class points_def_formcs
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
            this.notes_txt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.min_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.point_value_txt = new System.Windows.Forms.TextBox();
            this.id_txt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataSet11 = new pharma_manage.DataSet1();
            this.points_definition_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.points_definition_tableTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.point_cost_in_fatora_txt = new System.Windows.Forms.TextBox();
            this.example_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(426, 153);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(57, 14);
            this.label1.TabIndex = 123257;
            this.label1.Text = "ملاحظات";
            // 
            // notes_txt
            // 
            this.notes_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.notes_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notes_txt.Location = new System.Drawing.Point(72, 150);
            this.notes_txt.Name = "notes_txt";
            this.notes_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.notes_txt.Size = new System.Drawing.Size(314, 22);
            this.notes_txt.TabIndex = 4;
            this.notes_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(398, 115);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(131, 14);
            this.label11.TabIndex = 123256;
            this.label11.Text = "الحد الادنى للاستبدال";
            // 
            // min_txt
            // 
            this.min_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.min_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min_txt.Location = new System.Drawing.Point(72, 112);
            this.min_txt.Name = "min_txt";
            this.min_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.min_txt.Size = new System.Drawing.Size(314, 22);
            this.min_txt.TabIndex = 3;
            this.min_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(392, 77);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(137, 14);
            this.label3.TabIndex = 123255;
            this.label3.Text = "قيمة النقطة للاستبدال";
            // 
            // point_value_txt
            // 
            this.point_value_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.point_value_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point_value_txt.Location = new System.Drawing.Point(72, 74);
            this.point_value_txt.Name = "point_value_txt";
            this.point_value_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.point_value_txt.Size = new System.Drawing.Size(314, 22);
            this.point_value_txt.TabIndex = 2;
            this.point_value_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // id_txt
            // 
            this.id_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.id_txt.AutoSize = true;
            this.id_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_txt.Location = new System.Drawing.Point(23, 171);
            this.id_txt.Name = "id_txt";
            this.id_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.id_txt.Size = new System.Drawing.Size(18, 14);
            this.id_txt.TabIndex = 123259;
            this.id_txt.Text = "id";
            this.id_txt.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(162, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "تعديل";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // points_definition_tableTableAdapter1
            // 
            this.points_definition_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(392, 15);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(149, 14);
            this.label2.TabIndex = 123262;
            this.label2.Text = "قيمة النقطة في الفاتورة";
            // 
            // point_cost_in_fatora_txt
            // 
            this.point_cost_in_fatora_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.point_cost_in_fatora_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point_cost_in_fatora_txt.Location = new System.Drawing.Point(72, 12);
            this.point_cost_in_fatora_txt.Name = "point_cost_in_fatora_txt";
            this.point_cost_in_fatora_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.point_cost_in_fatora_txt.Size = new System.Drawing.Size(314, 22);
            this.point_cost_in_fatora_txt.TabIndex = 0;
            this.point_cost_in_fatora_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.point_cost_in_fatora_txt.TextChanged += new System.EventHandler(this.point_cost_in_fatora_txt_TextChanged);
            // 
            // example_txt
            // 
            this.example_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.example_txt.Enabled = false;
            this.example_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.example_txt.Location = new System.Drawing.Point(72, 46);
            this.example_txt.Name = "example_txt";
            this.example_txt.ReadOnly = true;
            this.example_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.example_txt.Size = new System.Drawing.Size(466, 22);
            this.example_txt.TabIndex = 1;
            this.example_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // points_def_formcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 227);
            this.Controls.Add(this.example_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.point_cost_in_fatora_txt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.notes_txt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.min_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.point_value_txt);
            this.MaximizeBox = false;
            this.Name = "points_def_formcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعريف النقاط";
            this.Load += new System.EventHandler(this.points_def_formcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox notes_txt;
        public System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox min_txt;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox point_value_txt;
        public System.Windows.Forms.Label id_txt;
        private System.Windows.Forms.Button button1;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.points_definition_tableTableAdapter points_definition_tableTableAdapter1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox point_cost_in_fatora_txt;
        private System.Windows.Forms.TextBox example_txt;
    }
}