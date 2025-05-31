namespace pharma_manage
{
    partial class edit_category_price
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
            this.category_txt = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new pharma_manage.DataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryTableAdapter = new pharma_manage.DataSet1TableAdapters.CategoryTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nesba_radio = new System.Windows.Forms.RadioButton();
            this.amount_radio = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.minus_radio = new System.Windows.Forms.RadioButton();
            this.added_radio = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cost_txt = new System.Windows.Forms.TextBox();
            this.bee3_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pro_name_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bee3_after_txt = new System.Windows.Forms.TextBox();
            this.cost_after_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cost_before_txt = new System.Windows.Forms.TextBox();
            this.bee3_before_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.products_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.products_tableTableAdapter();
            this.far3_txt = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.stock_tableTableAdapter1 = new pharma_manage.DataSet1TableAdapters.stock_tableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // category_txt
            // 
            this.category_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.category_txt.DataSource = this.categoryBindingSource;
            this.category_txt.DisplayMember = "Category_name";
            this.category_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.category_txt.FormattingEnabled = true;
            this.category_txt.Location = new System.Drawing.Point(239, 50);
            this.category_txt.Name = "category_txt";
            this.category_txt.Size = new System.Drawing.Size(178, 22);
            this.category_txt.TabIndex = 130;
            this.category_txt.SelectedIndexChanged += new System.EventHandler(this.category_txt_SelectedIndexChanged);
            this.category_txt.TextChanged += new System.EventHandler(this.category_txt_TextChanged);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(423, 54);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 131;
            this.label1.Text = "الفئة";
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(158, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 52);
            this.groupBox1.TabIndex = 132;
            this.groupBox1.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.radioButton2.Location = new System.Drawing.Point(111, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton2.Size = new System.Drawing.Size(56, 18);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "نسبة";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.radioButton1.Location = new System.Drawing.Point(216, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton1.Size = new System.Drawing.Size(53, 18);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "قيمة";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nesba_radio);
            this.groupBox2.Controls.Add(this.amount_radio);
            this.groupBox2.Location = new System.Drawing.Point(158, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 52);
            this.groupBox2.TabIndex = 132;
            this.groupBox2.TabStop = false;
            // 
            // nesba_radio
            // 
            this.nesba_radio.AutoSize = true;
            this.nesba_radio.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.nesba_radio.Location = new System.Drawing.Point(111, 19);
            this.nesba_radio.Name = "nesba_radio";
            this.nesba_radio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nesba_radio.Size = new System.Drawing.Size(56, 18);
            this.nesba_radio.TabIndex = 1;
            this.nesba_radio.Text = "نسبة";
            this.nesba_radio.UseVisualStyleBackColor = true;
            this.nesba_radio.CheckedChanged += new System.EventHandler(this.nesba_radio_CheckedChanged);
            // 
            // amount_radio
            // 
            this.amount_radio.AutoSize = true;
            this.amount_radio.Checked = true;
            this.amount_radio.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.amount_radio.Location = new System.Drawing.Point(216, 19);
            this.amount_radio.Name = "amount_radio";
            this.amount_radio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.amount_radio.Size = new System.Drawing.Size(53, 18);
            this.amount_radio.TabIndex = 0;
            this.amount_radio.TabStop = true;
            this.amount_radio.Text = "قيمة";
            this.amount_radio.UseVisualStyleBackColor = true;
            this.amount_radio.CheckedChanged += new System.EventHandler(this.amount_radio_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton5);
            this.groupBox3.Controls.Add(this.radioButton6);
            this.groupBox3.Location = new System.Drawing.Point(158, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(381, 52);
            this.groupBox3.TabIndex = 133;
            this.groupBox3.TabStop = false;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.radioButton5.Location = new System.Drawing.Point(111, 19);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton5.Size = new System.Drawing.Size(61, 18);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "نقصان";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.radioButton6.Location = new System.Drawing.Point(216, 19);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton6.Size = new System.Drawing.Size(53, 18);
            this.radioButton6.TabIndex = 0;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "زيادة";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.minus_radio);
            this.groupBox4.Controls.Add(this.added_radio);
            this.groupBox4.Location = new System.Drawing.Point(158, 132);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(381, 52);
            this.groupBox4.TabIndex = 133;
            this.groupBox4.TabStop = false;
            // 
            // minus_radio
            // 
            this.minus_radio.AutoSize = true;
            this.minus_radio.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.minus_radio.Location = new System.Drawing.Point(111, 19);
            this.minus_radio.Name = "minus_radio";
            this.minus_radio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.minus_radio.Size = new System.Drawing.Size(61, 18);
            this.minus_radio.TabIndex = 1;
            this.minus_radio.Text = "نقصان";
            this.minus_radio.UseVisualStyleBackColor = true;
            this.minus_radio.CheckedChanged += new System.EventHandler(this.minus_radio_CheckedChanged);
            // 
            // added_radio
            // 
            this.added_radio.AutoSize = true;
            this.added_radio.Checked = true;
            this.added_radio.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.added_radio.Location = new System.Drawing.Point(216, 19);
            this.added_radio.Name = "added_radio";
            this.added_radio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.added_radio.Size = new System.Drawing.Size(53, 18);
            this.added_radio.TabIndex = 0;
            this.added_radio.TabStop = true;
            this.added_radio.Text = "زيادة";
            this.added_radio.UseVisualStyleBackColor = true;
            this.added_radio.CheckedChanged += new System.EventHandler(this.added_radio_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.cost_txt);
            this.groupBox5.Controls.Add(this.bee3_txt);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(158, 184);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(381, 88);
            this.groupBox5.TabIndex = 134;
            this.groupBox5.TabStop = false;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(251, 59);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(108, 14);
            this.label10.TabIndex = 123261;
            this.label10.Text = "القيمة لسعر البيع";
            // 
            // cost_txt
            // 
            this.cost_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cost_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost_txt.Location = new System.Drawing.Point(21, 21);
            this.cost_txt.Name = "cost_txt";
            this.cost_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cost_txt.Size = new System.Drawing.Size(213, 22);
            this.cost_txt.TabIndex = 123258;
            this.cost_txt.Text = "0";
            this.cost_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cost_txt.TextChanged += new System.EventHandler(this.cost_txt_TextChanged);
            // 
            // bee3_txt
            // 
            this.bee3_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bee3_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bee3_txt.Location = new System.Drawing.Point(21, 56);
            this.bee3_txt.Name = "bee3_txt";
            this.bee3_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bee3_txt.Size = new System.Drawing.Size(213, 22);
            this.bee3_txt.TabIndex = 123259;
            this.bee3_txt.Text = "0";
            this.bee3_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bee3_txt.TextChanged += new System.EventHandler(this.bee3_txt_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(240, 24);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(119, 14);
            this.label3.TabIndex = 123260;
            this.label3.Text = "القيمة لسعر الشراء";
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
            this.save_btn.Location = new System.Drawing.Point(236, 377);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(224, 34);
            this.save_btn.TabIndex = 135;
            this.save_btn.Text = "تعديل سعر الفئة";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.pro_name_txt);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.bee3_after_txt);
            this.groupBox6.Controls.Add(this.cost_after_txt);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.cost_before_txt);
            this.groupBox6.Controls.Add(this.bee3_before_txt);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Location = new System.Drawing.Point(41, 271);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox6.Size = new System.Drawing.Size(614, 103);
            this.groupBox6.TabIndex = 123262;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "مثال";
            // 
            // pro_name_txt
            // 
            this.pro_name_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pro_name_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pro_name_txt.Location = new System.Drawing.Point(84, 14);
            this.pro_name_txt.Name = "pro_name_txt";
            this.pro_name_txt.ReadOnly = true;
            this.pro_name_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pro_name_txt.Size = new System.Drawing.Size(447, 22);
            this.pro_name_txt.TabIndex = 123266;
            this.pro_name_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(158, 76);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(130, 14);
            this.label6.TabIndex = 123265;
            this.label6.Text = "سعر البيع بعد التعديل";
            // 
            // bee3_after_txt
            // 
            this.bee3_after_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bee3_after_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bee3_after_txt.Location = new System.Drawing.Point(18, 73);
            this.bee3_after_txt.Name = "bee3_after_txt";
            this.bee3_after_txt.ReadOnly = true;
            this.bee3_after_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bee3_after_txt.Size = new System.Drawing.Size(123, 22);
            this.bee3_after_txt.TabIndex = 123264;
            this.bee3_after_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cost_after_txt
            // 
            this.cost_after_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cost_after_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost_after_txt.Location = new System.Drawing.Point(18, 42);
            this.cost_after_txt.Name = "cost_after_txt";
            this.cost_after_txt.ReadOnly = true;
            this.cost_after_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cost_after_txt.Size = new System.Drawing.Size(123, 22);
            this.cost_after_txt.TabIndex = 123262;
            this.cost_after_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(147, 45);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(141, 14);
            this.label5.TabIndex = 123263;
            this.label5.Text = "سعر الشراء بعد التعديل";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(473, 76);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(134, 14);
            this.label2.TabIndex = 123261;
            this.label2.Text = "سعر البيع قبل التعديل";
            // 
            // cost_before_txt
            // 
            this.cost_before_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cost_before_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost_before_txt.Location = new System.Drawing.Point(333, 42);
            this.cost_before_txt.Name = "cost_before_txt";
            this.cost_before_txt.ReadOnly = true;
            this.cost_before_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cost_before_txt.Size = new System.Drawing.Size(123, 22);
            this.cost_before_txt.TabIndex = 123258;
            this.cost_before_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bee3_before_txt
            // 
            this.bee3_before_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bee3_before_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bee3_before_txt.Location = new System.Drawing.Point(333, 73);
            this.bee3_before_txt.Name = "bee3_before_txt";
            this.bee3_before_txt.ReadOnly = true;
            this.bee3_before_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bee3_before_txt.Size = new System.Drawing.Size(123, 22);
            this.bee3_before_txt.TabIndex = 123259;
            this.bee3_before_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(462, 45);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(145, 14);
            this.label4.TabIndex = 123260;
            this.label4.Text = "سعر الشراء قبل التعديل";
            // 
            // products_tableTableAdapter1
            // 
            this.products_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // far3_txt
            // 
            this.far3_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.far3_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.far3_txt.FormattingEnabled = true;
            this.far3_txt.Location = new System.Drawing.Point(237, 12);
            this.far3_txt.Name = "far3_txt";
            this.far3_txt.Size = new System.Drawing.Size(180, 22);
            this.far3_txt.TabIndex = 123263;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(423, 16);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(36, 14);
            this.label11.TabIndex = 123264;
            this.label11.Text = "الفرع";
            // 
            // stock_tableTableAdapter1
            // 
            this.stock_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // edit_category_price
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 417);
            this.Controls.Add(this.far3_txt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.category_txt);
            this.Controls.Add(this.label1);
            this.Name = "edit_category_price";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل سعر فئة";
            this.Load += new System.EventHandler(this.edit_category_price_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox category_txt;
        public System.Windows.Forms.Label label1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private DataSet1TableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton nesba_radio;
        private System.Windows.Forms.RadioButton amount_radio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton minus_radio;
        private System.Windows.Forms.RadioButton added_radio;
        private System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox cost_txt;
        private System.Windows.Forms.TextBox bee3_txt;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox6;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cost_before_txt;
        private System.Windows.Forms.TextBox bee3_before_txt;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.TextBox pro_name_txt;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox bee3_after_txt;
        private System.Windows.Forms.TextBox cost_after_txt;
        public System.Windows.Forms.Label label5;
        private DataSet1TableAdapters.products_tableTableAdapter products_tableTableAdapter1;
        public System.Windows.Forms.ComboBox far3_txt;
        public System.Windows.Forms.Label label11;
        private DataSet1TableAdapters.stock_tableTableAdapter stock_tableTableAdapter1;
    }
}