namespace pharma_manage
{
    partial class show_picture_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(show_picture_form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.left_btn = new System.Windows.Forms.PictureBox();
            this.right_btn = new System.Windows.Forms.PictureBox();
            this.far3txt = new System.Windows.Forms.Label();
            this.products_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.products_tableTableAdapter();
            this.dataSet11 = new pharma_manage.DataSet1();
            this.dataSet12 = new pharma_manage.DataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.left_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.right_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(682, 406);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // name_txt
            // 
            this.name_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name_txt.Enabled = false;
            this.name_txt.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.name_txt.ForeColor = System.Drawing.Color.Green;
            this.name_txt.Location = new System.Drawing.Point(63, 9);
            this.name_txt.Name = "name_txt";
            this.name_txt.ReadOnly = true;
            this.name_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_txt.Size = new System.Drawing.Size(581, 25);
            this.name_txt.TabIndex = 2;
            this.name_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.left_btn);
            this.groupBox1.Controls.Add(this.right_btn);
            this.groupBox1.Location = new System.Drawing.Point(25, 444);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 92);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // left_btn
            // 
            this.left_btn.Location = new System.Drawing.Point(176, 10);
            this.left_btn.Name = "left_btn";
            this.left_btn.Size = new System.Drawing.Size(116, 76);
            this.left_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.left_btn.TabIndex = 2;
            this.left_btn.TabStop = false;
            this.left_btn.Click += new System.EventHandler(this.left_btn_Click);
            // 
            // right_btn
            // 
            this.right_btn.Location = new System.Drawing.Point(374, 10);
            this.right_btn.Name = "right_btn";
            this.right_btn.Size = new System.Drawing.Size(116, 76);
            this.right_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.right_btn.TabIndex = 1;
            this.right_btn.TabStop = false;
            this.right_btn.Click += new System.EventHandler(this.right_btn_Click);
            // 
            // far3txt
            // 
            this.far3txt.AutoSize = true;
            this.far3txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.far3txt.Location = new System.Drawing.Point(6, 15);
            this.far3txt.Name = "far3txt";
            this.far3txt.Size = new System.Drawing.Size(32, 14);
            this.far3txt.TabIndex = 123253;
            this.far3txt.Text = "far3";
            this.far3txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.far3txt.Visible = false;
            // 
            // products_tableTableAdapter1
            // 
            this.products_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.EnforceConstraints = false;
            this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet12
            // 
            this.dataSet12.DataSetName = "DataSet1";
            this.dataSet12.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // show_picture_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 529);
            this.Controls.Add(this.far3txt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.name_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "show_picture_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عرض صورة المنتج";
            this.Load += new System.EventHandler(this.show_picture_form_Load);
            this.Shown += new System.EventHandler(this.show_picture_form_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.left_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.right_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox right_btn;
        private System.Windows.Forms.PictureBox left_btn;
        public System.Windows.Forms.Label far3txt;
        private DataSet1TableAdapters.products_tableTableAdapter products_tableTableAdapter1;
        private DataSet1 dataSet11;
        private DataSet1 dataSet12;
    }
}