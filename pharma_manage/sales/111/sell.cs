using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace pharma_manage
{
    public partial class sell : Form
    {
        public sell()
        {
            InitializeComponent();
           
        }

        private void madfoo3TXT_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = savebtn;
            try
            {
                decimal ba2y = Convert.ToDecimal(matloobTXT.Text) - Convert.ToDecimal(madfoo3TXT.Text);
                ba2y_txt.Text = ba2y.ToString();
            }
            catch 
            {
                ba2y_txt.Text = "0"; 
            }
            try 
            {

                decimal kest_cost = (Convert.ToDecimal(matloobTXT.Text) - Convert.ToDecimal(madfoo3TXT.Text)) / Convert.ToDecimal(number_of_aksat_txt.Text);
                foreach (DataGridViewRow dgr in dataGridView2.Rows)
                {
                    if (dgr.Cells[0].Value.ToString() != "")
                    {
                        dgr.Cells[2].Value = kest_cost.ToString();
                    }
                }
            }
            catch { }
        }

        private void product_nameTXT_TextChanged(object sender, EventArgs e)
        {
            if (product_nameTXT.Text != "")
            {
                this.AcceptButton = addbtn;
              //  addbtn_Click(sender, e);
            }
        }

        private void countTXT_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = addbtn;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            try 
            {
                label29.Text = dataGridView1.Rows.Count.ToString();
               // int selectedrowindex = dataGridView1.SelectedRows;
              //  DataGridViewRow selectedRow = dataGridView1.Rows[dataGridView1.Rows.Count-1];
              //  dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count-1;//[dataGridView1.Rows.Count - 1];
             
            }
            catch { }
          
            try
            {
                decimal ba2y = Convert.ToDecimal(madfoo3TXT.Text) - Convert.ToDecimal(matloobTXT.Text);
                ba2y_txt.Text = ba2y.ToString();
            }
            catch { }
            try
            {
                this.numbers_tableTableAdapter1.Fill(this.dataSet11.Numbers_table);
                salesID_TXT.Text = dataSet11.Numbers_table.Rows[0]["sales_ID"].ToString();
            }
            catch { }
            decimal sum = 0;
           // decimal sum_dariba = 0;

            try
            {
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    dataGridView1.Rows[i].Cells[4].Value = Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value) * Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value);
                   // sum_dariba += Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);
                    sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                }
                //egmaly_dariba_txt.Text = sum_dariba.ToString();
                egmaly_se3r_txt.Text = sum.ToString("0.00");

                decimal egmaly_after =  sum  ;
                egmalyTXT.Text = egmaly_after.ToString("0.00"); ;
              
            }
            catch { }


            decimal sum_aksat = 0;

            try
            {
                for (int i = 0; i < dataGridView2.Rows.Count; ++i)
                {
                    sum_aksat += Convert.ToDecimal(dataGridView2.Rows[i].Cells[2].Value);
                }
              //  motbaky_txt.Text = real_sum.ToString();

               if (hesab_sab2_txt.Text == "") 
               {
                   hesab_sab2_txt.Text = "0";
               }
               decimal real_sum = (Convert.ToDecimal(hesab_sab2_txt.Text)+-Convert.ToDecimal(ba2y_txt.Text)) - sum_aksat;
               motbaky_txt.Text = real_sum.ToString("0.00");
              }
            catch { }



            egmaly_kest_txt.Text = "0";
            if (discountTXT.Text == "")
            {
                discountTXT.Text = "0";
            }

            try
            {


                decimal matloob = Convert.ToDecimal(egmalyTXT.Text) - Convert.ToDecimal(discountTXT.Text);
                matloobTXT.Text = matloob.ToString("0.00");

            }
            catch { }
           
        }
        private void suggest_product()
        {
            try
            {
                this.products_tableTableAdapter1.FillBy_stock(this.dataSet11.products_table,far3txt.Text);
                product_nameTXT.AutoCompleteMode = AutoCompleteMode.Suggest;
                product_nameTXT.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection DataCollection1 = new AutoCompleteStringCollection();
                foreach (DataRow dr in dataSet11.products_table.Rows)
                {
                    DataCollection1.Add(dr["pro_name"].ToString());
                }

                product_nameTXT.AutoCompleteCustomSource = DataCollection1;
            }
            catch { }
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
           
                if (product_nameTXT.Text == "")
                {
                    MessageBox.Show("ادخل اسم المنتج");
                    product_nameTXT.Focus();
                    return;
                }
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == product_nameTXT.Text)
                    {
                        decimal count_in = Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value) + Convert.ToDecimal(countTXT.Text);
                        products_tableTableAdapter1.FillBy_int_code_and_far3(dataSet11.products_table,Convert.ToInt32( dataGridView1.Rows[i].Cells[0].Value.ToString()),far3txt.Text);

                        decimal count = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);

                        if (count_in <= count)
                        {

                            dataGridView1.Rows[i].Cells[2].Value = count_in.ToString();

                            products_tableTableAdapter1.FillBy_int_code_and_far3(dataSet11.products_table,Convert.ToInt32( product_nameTXT.Text), far3txt.Text);
                            decimal pro_count = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);
                            product_nameTXT.Clear();
                            product_nameTXT.Focus();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("الكمية غير متاحه في الفرع", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }

                    }




                    if (dataGridView1.Rows[i].Cells[1].Value.ToString() == product_nameTXT.Text)
                    {
                        try
                        {
                            decimal count_in = Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value) + Convert.ToDecimal(countTXT.Text);
                            //  string category_name = "";
                            products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, dataGridView1.Rows[i].Cells[1].Value.ToString(), far3txt.Text);

                            decimal count = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);

                            if (count_in <= count)
                            {
                                dataGridView1.Rows[i].Cells[2].Value = count_in.ToString();

                                product_nameTXT.Clear();
                                product_nameTXT.Focus();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("الكمية غير متاحه في الفرع", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                return;
                            }
                            //MessageBox.Show("qqq");

                        }
                        catch { }
                    }
                }


                if (countTXT.Text == "")
                {
                    MessageBox.Show("أدخل الكمية");
                    countTXT.Select();
                    return;
                }
                try
                {

                    string pro_code = "";
                    string product_name;
                    string unit_price = "";
                    string category_name1;
                    string stock1;

                    products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, product_nameTXT.Text, far3txt.Text);
                    pro_code = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                    product_name = dataSet11.products_table.Rows[0]["pro_name"].ToString();
                    unit_price = dataSet11.products_table.Rows[0]["pro_bee3"].ToString();
                   

                    //try
                    //{
                    //    //sales_last_price
                    //    sales_tableTableAdapter.FillBy_cst_name_and_pro_name(dataSet11.sales_table, cst_nameTXT.Text, product_nameTXT.Text);

                  //   unit_price= dataSet11.sales_table.Rows[dataSet11.sales_table.Rows.Count - 1]["sales_unit_price"].ToString();
                    //}
                    //catch
                    //{
                    //           }
                    category_name1 = dataSet11.products_table.Rows[0]["pro_category"].ToString();
                    //stock1 = dataSet11.products_table.Rows[0]["pro_stock"].ToString();

                    //string pro_stock = "";
                    //if (stock1 == "الفرع")
                    //{
                    //    pro_stock = "0";
                    //}
                    //else if (stock1 == "مخزن 1") 
                    //{
                    //    pro_stock = "1";
                    //}
                    //else if (stock1 == "مخزن 2")
                    //{
                    //    pro_stock = "2";
                    //}



                    double unit_price_after = Convert.ToDouble(unit_price);
                    //+dariba;
                    decimal pro_count1 = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);
                    if (Convert.ToDecimal(countTXT.Text) > pro_count1)
                    {
                        MessageBox.Show("الكمية غير متاحه في الفرع", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        countTXT.Focus();
                        return;
                    }
                    else
                    {
                        dataGridView1.Rows.Add(pro_code, product_name, countTXT.Text, unit_price_after, "", category_name1);
                        if (dataGridView1.Columns.Count == 6)
                        {
                            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

                            btn.Width = 75;
                            btn.Text = "حذف";
                            btn.DefaultCellStyle.BackColor = Color.Red;
                            btn.Name = "الحذف";
                            btn.UseColumnTextForButtonValue = true;


                            dataGridView1.Columns.Add(btn);
                        }
                        dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1;
                    }
                    product_nameTXT.Clear();
                    product_nameTXT.Focus();


                }

                catch
                {
                    //try
                    //{
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells[1].Value.ToString() == product_nameTXT.Text)
                        {
                            decimal count_in = Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value) + Convert.ToDecimal(countTXT.Text);
                            string category_name = dataSet11.products_table.Rows[0]["pro_category"].ToString();

                            decimal count = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);

                            if (count_in <= count)
                            {

                                dataGridView1.Rows[i].Cells[2].Value = count_in.ToString();

                                products_tableTableAdapter1.FillBy_int_code_and_far3(dataSet11.products_table,Convert.ToInt32( product_nameTXT.Text), far3txt.Text);
                                decimal pro_count = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);
                                product_nameTXT.Clear();
                                product_nameTXT.Focus();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("الكمية غير متاحه في الفرع", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                return;
                            }
                        }
                    }
                    if (countTXT.Text == "")
                    {
                        MessageBox.Show("أدخل الكمية");
                        countTXT.Select();
                        return;
                    }
                    string pro_code1;
                    string product_name1;
                    string unit_price1 = "";
                    string category_name11;
                    string stock11;
                    try
                    {
                        products_tableTableAdapter1.FillBy_int_code_and_far3(dataSet11.products_table,Convert.ToInt32( product_nameTXT.Text), far3txt.Text);
                        pro_code1 = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                        product_name1 = dataSet11.products_table.Rows[0]["pro_name"].ToString();
                        unit_price1 = dataSet11.products_table.Rows[0]["pro_bee3"].ToString();

                        //try
                        //{
                        //    //sales_last_price
                        //    sales_tableTableAdapter.FillBy_cst_name_and_pro_ID(dataSet11.sales_table, cst_nameTXT.Text, product_nameTXT.Text);

                        //    unit_price1 = dataSet11.sales_table.Rows[dataSet11.sales_table.Rows.Count - 1]["sales_unit_price"].ToString();
                        //}
                        //catch
                        //{
                        //    if (fatora_type.Text == "جمله")
                        //    {
                        //        unit_price1 = dataSet11.products_table.Rows[0]["pro_bee3"].ToString();
                        //    }
                        //    else if (fatora_type.Text == "جملة الجمله")
                        //    {
                        //        unit_price1 = dataSet11.products_table.Rows[0]["pro_gomla_gomla"].ToString();
                        //    }
                        //}
                        category_name11 = dataSet11.products_table.Rows[0]["pro_category"].ToString();
                        //  categoryTableAdapter1.FillBy_name(dataSet11.Category, category_name11);
                        //stock11 = dataSet11.products_table.Rows[0]["pro_stock"].ToString();

                        //string pro_stock = "";
                        //if (stock11 == "الفرع")
                        //{
                        //    pro_stock = "0";
                        //}
                        //else if (stock11 == "مخزن 1")
                        //{
                        //    pro_stock = "1";
                        //}
                        //else if (stock11 == "مخزن 2")
                        //{
                        //    pro_stock = "2";
                        //}
                        //double dariba1 = 0;
                        //try
                        //{
                        //    dariba1 = Convert.ToDouble(dataSet11.Category.Rows[0]["Category_dariba"]) * Convert.ToDouble(unit_price1) * Convert.ToDouble(countTXT.Text);

                        //}
                        //catch
                        //{
                        //    dariba1 = 0;
                        //}

                        double unit_price_after = Convert.ToDouble(unit_price1);

                        decimal pro_count1 = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);
                        if (Convert.ToDecimal(countTXT.Text) > pro_count1)
                        {
                            MessageBox.Show("الكمية غير متاحه في الفرع", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            countTXT.Focus();
                            return;
                        }
                        else
                        {
                            dataGridView1.Rows.Add(pro_code1, product_name1, countTXT.Text, unit_price_after, "", category_name11);
                            if (dataGridView1.Columns.Count == 6)
                            {
                                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

                                btn.Width = 75;
                                btn.Text = "حذف";
                                btn.DefaultCellStyle.BackColor = Color.Red;
                                btn.Name = "الحذف";
                                btn.UseColumnTextForButtonValue = true;


                                dataGridView1.Columns.Add(btn);
                            }
                            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1;
                            product_nameTXT.Clear();
                            product_nameTXT.Focus();
                        }
                    }
                    catch
                    {
                        try
                        {
                            products_tableTableAdapter1.FillBy_int_code_and_far3(dataSet11.products_table,Convert.ToInt32( product_nameTXT.Text), far3txt.Text);
                            pro_code1 = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                            product_name1 = dataSet11.products_table.Rows[0]["pro_name"].ToString();

                            //if (fatora_type.Text == "جمله")
                            //{
                            //    unit_price1 = dataSet11.products_table.Rows[0]["pro_bee3"].ToString();
                            //}
                            //else if (fatora_type.Text == "جملة الجمله")
                            //{
                            //    unit_price1 = dataSet11.products_table.Rows[0]["pro_gomla_gomla"].ToString();
                            //}
                            //   unit_price1 = dataSet11.products_table.Rows[0]["pro_bee3"].ToString();
                            //category_name11 = dataSet11.products_table.Rows[0]["pro_category"].ToString();
                            //categoryTableAdapter1.FillBy_name(dataSet11.Category, category_name11);

                            //double dariba1 = 0;
                            //try
                            //{
                            //    dariba1 = Convert.ToDouble(dataSet11.Category.Rows[0]["Category_dariba"]) * Convert.ToDouble(unit_price1) * Convert.ToDouble(countTXT.Text);

                            //}
                            //catch
                            //{
                            //    dariba1 = 0;
                            //}

                            double unit_price_after = Convert.ToDouble(unit_price1);

                            decimal pro_count1 = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);
                            if (Convert.ToDecimal(countTXT.Text) > pro_count1)
                            {
                                MessageBox.Show("الكمية غير متاحه في الفرع", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                countTXT.Focus();
                                return;
                            }
                            else
                            {
                                if (dataGridView1.Columns.Count == 6)
                                {
                                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

                                    btn.Width = 75;
                                    btn.Text = "حذف";
                                    btn.DefaultCellStyle.BackColor = Color.Red;
                                    btn.Name = "الحذف";
                                    btn.UseColumnTextForButtonValue = true;


                                    dataGridView1.Columns.Add(btn);
                                }
                                product_nameTXT.Clear();
                                product_nameTXT.Focus();
                            }
                        }
                        catch { }
                    }
                }
            }

        

        private void read_mandoob()
        {
            int counter = 0;
            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file =new System.IO.StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\المندوبين.txt", Encoding.Default, true);
          //  MessageBox.Show(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\المندوبين.txt");
            while ((line = file.ReadLine()) != null)
            {
                mandoob_txt.Items.Add(line);
                counter++;
            }

            file.Close();
        }
        private void sell_Load(object sender, EventArgs e)
        {
           
            this.user_previligesTableAdapter1.FillBy_name(dataSet11.user_previliges, usertxt.Text);
            read_mandoob();
            if (usertxt.Text != "admin")
            {
                ListBox l = new ListBox();
                foreach (DataRow dr in dataSet11.user_previliges.Rows)
                {
                    l.Items.Add(dr["user_previliges"].ToString());
                  
                }
                if (l.Items.Contains("قائمة الأصناف"))
                {
                    taklefa_txt.Visible = true;
                    label23.Visible = true;
                }
                else 
                {
                    taklefa_txt.Visible = false;
                    label23.Visible = false;

                   // dataGridView1.Columns[3].ReadOnly = true;
                    
                }
            }

            madeen_small_reportTableAdapter1.Delete_when0();
            madeen_tableTableAdapter1.Delete_when0();
          //  this.pharmacy_dataTableAdapter.Fill(this.DataSet1.pharmacy_data);
           // timer1.Stop();
            this.dateTimePicker1.Value = DateTime.Today;
            suggest_cst_name();
           suggest_product();
         //  timer1.Start();
           try
           {
               this.numbers_tableTableAdapter1.Fill(this.dataSet11.Numbers_table);
               salesID_TXT.Text = dataSet11.Numbers_table.Rows[0]["sales_ID"].ToString();
           }
           catch { }
           if (type_txt.Text == "تعديل") 
           {
               salesID_TXT.Text = "";
               salesID_TXT.Enabled = true;
               salesID_TXT.ReadOnly = false;
               
           }
          
           try 
           {
               cost_in_words_txt.Clear();
               currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Egypt));
               currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.USA));
               currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.SaudiArabia));
               currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Gold));

               cboCurrency.DataSource = currencies;

               cboCurrency_DropDownClosed(null, null);
           }
           catch { }

           product_nameTXT.Focus();


           //try
           //{
               //foreach(Control c in flowLayoutPanel1.Controls)
               //{
               //    if (c.Name != "ketab_mark_txt") 
               //    {
               //        flowLayoutPanel1.Controls.Remove(c);
               //    }
               //}
               //flowLayoutPanel1.Controls.Clear();
              
               Form1 f = new Form1();
               //foreach (var item in category_list.Items) 
               //{
               //    Button buttton = new Button();

               //    buttton.Text = item.ToString();
               //    buttton.Name = item.ToString();
               //    buttton.Width = 80;
               //    buttton.Height = 45;
               //    buttton.Click += new EventHandler(buttton_Click);
               //    buttton.FlatStyle = FlatStyle.Flat;
               //    buttton.BackColor = Color.Green;
               //    buttton.ForeColor = Color.White;
               //    buttton.Font = new Font("Tahoma", 17, FontStyle.Bold);
               //    buttton.BackColor = System.Drawing.Color.Green;
               //    buttton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
               //    buttton.FlatAppearance.BorderSize = 2;
               //    // buttton.Padding = new System.Windows.Forms.Padding(0);
               //    buttton.Margin = new System.Windows.Forms.Padding(0);
               //    // buttton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               //    buttton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               //    buttton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
               //    // buttton.Size = new System.Drawing.Size(114, 23);
               //    buttton.UseVisualStyleBackColor = false;
               //    buttton.Cursor = Cursors.Hand;
               //    //  buttton.DragOver += new DragEventHandler(button_DragOver);
               //    // button.FlatAppearance.BorderColor

               //    // buttton.AutoSize = true;

               //    this.flowLayoutPanel1.Controls.Add(buttton);
               //    buttton = new System.Windows.Forms.Button();
               //}

               //this.categoryTableAdapter1.Fill(this.dataSet11.Category);
               //foreach (DataRow DRow in dataSet11.Category.Rows)
               //{


                   
               //        Button buttton = new Button();

               //        buttton.Text = DRow["Category_name"].ToString();
               //        buttton.Name = DRow["Category_name"].ToString();
               //        buttton.Width = 80;
               //        buttton.Height = 45;
               //        buttton.Click += new EventHandler(buttton_Click);
               //        buttton.FlatStyle = FlatStyle.Flat;
               //        buttton.BackColor = Color.Green;
               //        buttton.ForeColor = Color.White;
               //        buttton.Font = new Font("Tahoma", 17, FontStyle.Bold);
               //        buttton.BackColor = System.Drawing.Color.Green;
               //        buttton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
               //        buttton.FlatAppearance.BorderSize = 2;
               //       // buttton.Padding = new System.Windows.Forms.Padding(0);
               //        buttton.Margin = new System.Windows.Forms.Padding(0);
               //       // buttton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               //        buttton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               //        buttton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
               //        // buttton.Size = new System.Drawing.Size(114, 23);
               //        buttton.UseVisualStyleBackColor = false;
               //        buttton.Cursor = Cursors.Hand;
               //        //  buttton.DragOver += new DragEventHandler(button_DragOver);
               //        // button.FlatAppearance.BorderColor

               //       // buttton.AutoSize = true;

               //        this.flowLayoutPanel1.Controls.Add(buttton);
               //        buttton = new System.Windows.Forms.Button();

               //    }
               
           //}
           //catch { }

             //  MessageBox.Show(far3txt.Text);
        }






        private void pro_buttton_Click(object sender, EventArgs e)
        {
           
                Control_Clicks(sender, e);
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString() == public_label.Text)
                    {
                        
                            decimal count_in = Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value) + 1;
                          //  string category_name = "";
                            products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, dataGridView1.Rows[i].Cells[1].Value.ToString(), far3txt.Text);

                            //try
                            //{
                            //    category_name = dataSet11.products_table.Rows[0]["pro_category"].ToString();
                            //}
                            //catch { }
                            //categoryTableAdapter1.FillBy_name(dataSet11.Category, category_name);

                              decimal count = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);

                              if (count_in <= count)
                              {

                                  dataGridView1.Rows[i].Cells[2].Value = count_in.ToString();

                                  product_nameTXT.Clear();
                                  product_nameTXT.Focus();

                                  return;
                              }
                              else 
                              {
                                 MessageBox.Show("الكمية غير متاحه في الفرع", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                  return;
                              }
                       
                    }
                }
                products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, public_label.Text, far3txt.Text);
                //double dariba2 = 0; ;
                string pro_code = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                string pro_name = dataSet11.products_table.Rows[0]["pro_name"].ToString();
                string unit_price="";
                
                   
                        unit_price = dataSet11.products_table.Rows[0]["pro_bee3"].ToString();
                   
                
                string category_name1 = dataSet11.products_table.Rows[0]["pro_category"].ToString();
               // string stock_name = dataSet11.products_table.Rows[0]["pro_stock"].ToString();
                string pro_count = dataSet11.products_table.Rows[0]["pro_count"].ToString();
               
                //string pro_stock = "";
                //if (stock_name == "الفرع")
                //{
                //    pro_stock = "0";
                //}
                //else if (stock_name == "مخزن 1")
                //{
                //    pro_stock = "1";
                //}
                //else if (stock_name == "مخزن 2")
                //{
                //    pro_stock = "2";
                //}

                //try
                //{
                //    dariba2 = Convert.ToDouble(dataSet11.Category.Rows[0]["Category_dariba"]) * Convert.ToDouble(unit_price) * Convert.ToDouble(1);

                //}
                //catch
                //{
                //    dariba2 = 0;
                //}

                if (Convert.ToDecimal(pro_count) >= 1)
                {

                    dataGridView1.Rows.Add(pro_code, pro_name, 1, unit_price, "", category_name1);
                }
                else 
                {
                   MessageBox.Show("الكمية غير متاحه في الفرع", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                if (dataGridView1.Columns.Count == 6)
                {
                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

                    btn.Width = 75;
                    btn.Text = "حذف";
                    btn.Name = product_nameTXT.Text;
                    btn.UseColumnTextForButtonValue = true;


                    dataGridView1.Columns.Add(btn);
                }
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1;
            
           
            
        }


        //private void buttton_Click(object sender, EventArgs e)
        //{
        //    Control_Clicks_for_category(sender, e);
        //    products_tableTableAdapter1.FillBy_category_and_far3(dataSet11.products_table, public_label.Text,far3txt.Text);
        //    flowLayoutPanel2.Controls.Clear();
        //    foreach (DataRow DRow in dataSet11.products_table.Rows)
        //    {
        //        try
        //        {

                    
        //                Button pro_button = new Button();

        //                pro_button.Text = DRow["pro_name"].ToString();
        //                pro_button.Name = DRow["pro_name"].ToString();
        //                pro_button.Width = 125;
        //                pro_button.Height = 40;
        //                pro_button.Click += new EventHandler(pro_buttton_Click);
        //                pro_button.FlatStyle = FlatStyle.Flat;
        //                pro_button.BackColor = Color.WhiteSmoke;
        //                pro_button.ForeColor = Color.Black;
        //                pro_button.Font = new Font("Tahoma", 9, FontStyle.Bold);
        //                pro_button.TextAlign = ContentAlignment.MiddleCenter;
        //                pro_button.Margin = new System.Windows.Forms.Padding(0);
        //               // pro_button.BackColor = System.Drawing.Color.Green;
        //                pro_button.FlatAppearance.BorderColor = Color.FromName(flowLayoutPanel2.BackColor.Name);// System.Drawing.Color.Brown;
        //                  //  .FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        //               // pro_button.FlatAppearance.BorderSize = 1;
        //                pro_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        //               // pro_button.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //               // pro_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        //                // buttton.Size = new System.Drawing.Size(114, 23);
        //                pro_button.UseVisualStyleBackColor = false;
        //                pro_button.Cursor = Cursors.Hand;
        //                //  buttton.DragOver += new DragEventHandler(button_DragOver);
        //                // button.FlatAppearance.BorderColor

        //                //pro_button.AutoSize = true;

        //                this.flowLayoutPanel2.Controls.Add(pro_button);
        //               // pro_button = new System.Windows.Forms.Button();

                    
        //        }
        //        catch { }
        //    }
        //}
            
           
        



        // dataGridView1.Rows.Add(
        // MessageBox.Show(public_label.Text);

        private void Control_Clicks_for_category(object sender, EventArgs e)
        {
            Control control = (Control)sender;   // Sender gives you which control is clicked.
            public_label.Text = control.Text.ToString();
           
        }
        

        private void suggest_cst_name()
        {
            this.customersTableAdapter1.Fill(this.dataSet11.customers);
            cst_nameTXT.AutoCompleteMode = AutoCompleteMode.Suggest;
            cst_nameTXT.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet11.customers.Rows)
            {
                DataCollection.Add(dr["cst_name"].ToString());
            }

            cst_nameTXT.AutoCompleteCustomSource = DataCollection;

        }
        //private void pictureBox1_Click(object sender, EventArgs e)
        //{
        //    try
        //    {

        //        if (dataGridView1.SelectedRows.Count > 0)
        //        {
        //            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        //        }
        //    }
        //    catch { MessageBox.Show("قم بتحديد العنصرالمراد حذفه"); }
        //}
        private void check_customer()
        {
            customersTableAdapter1.FillBy_name(dataSet11.customers, cst_nameTXT.Text);
            if (dataSet11.customers.Rows.Count <= 0)
            {
                customersTableAdapter1.Insert(cst_nameTXT.Text, cst_phoneTXT.Text, cst_addressTXT.Text, "عميل مبيعات", "");
            }
            else 
            {
                int id=Convert.ToInt32(dataSet11.customers.Rows[0]["cst_ID"]);
                customersTableAdapter1.Update_cst_by_id(cst_nameTXT.Text, cst_phoneTXT.Text, cst_addressTXT.Text, notesTXT.Text, "", id);
            }
          

        }
        private void delete_sales()
        {
            //try
            //{
            //delete ma5zoon
            ma5zoon_movesTableAdapter1.Delete_by_fatora_ID(Convert.ToInt32(salesID_TXT.Text));

            //update products
            sales_tableTableAdapter1.FillBy_ID(dataSet11.sales_table, Convert.ToInt32(salesID_TXT.Text));

            foreach (DataRow dgr in dataSet11.sales_table.Rows)
            {
                products_tableTableAdapter1.Update_count_BY_ID_buy(Convert.ToDecimal(dgr["sales_product_count"]), Convert.ToDecimal(dgr["sales_product_count"]), dgr["sales_product_ID"].ToString(),far3txt.Text);
            }

            decimal income_cost = 0;
            if (Convert.ToDecimal(madfoo3TXT.Text) < Convert.ToDecimal(egmaly_elfatoraTXT.Text))
            {
                income_cost = Convert.ToDecimal(madfoo3TXT.Text);
            }
            else
            {
                income_cost = Convert.ToDecimal(egmaly_elfatoraTXT.Text);
            }

            


            madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet11.madeen_small_report, cst_nameTXT.Text);
            decimal old_7esab = 0;
            decimal ba2y_el7esab = 0;

            try
            {
                //if madeen exist
                old_7esab = Convert.ToDecimal(dataSet11.madeen_small_report.Rows[0]["madeen_small_ba2y"]);


                //madeen small report update
                madeen_small_reportTableAdapter1.Update_matloob_AND_madfoo3_by_name(-Convert.ToDecimal(egmaly_elfatoraTXT.Text), -Convert.ToDecimal(old_madfoo3), cst_nameTXT.Text);
                madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet11.madeen_small_report, cst_nameTXT.Text);
                decimal new_matloob = Convert.ToDecimal(dataSet11.madeen_small_report.Rows[0]["madeen_small_matloob"]);
                decimal new_madfoo3 = Convert.ToDecimal(dataSet11.madeen_small_report.Rows[0]["madeen_small_madfoo3"]);

                ba2y_el7esab = Convert.ToDecimal(dataSet11.madeen_small_report.Rows[0]["madeen_small_ba2y"]);

                //madeen details insert
                string madeen_byan = "مبلغ من فاتورة بيع رقم " + salesID_TXT.Text;
                madeen_tableTableAdapter1.Delete_by_details(madeen_byan);
                string madeen_byan2 = "مبلغ ناتج عن عملية مرتجع بيع لفاتورة رقم  " + salesID_TXT.Text;

                madeen_tableTableAdapter1.Update_matloob_and_madfoo3_by_madeen_name(-Convert.ToDecimal(egmaly_elfatoraTXT.Text), -Convert.ToDecimal(old_madfoo3), cst_nameTXT.Text);


                madeen_tableTableAdapter1.Delete_by_fatora_id(Convert.ToInt32(salesID_TXT.Text));
                //madeen details update matlob and madfo93
                madeen_small_reportTableAdapter1.Delete_when0();
                madeen_tableTableAdapter1.Delete_when0();

            }
            catch { }

            //delete sales
            sales_tableTableAdapter1.Delete_by_ID(Convert.ToInt32(salesID_TXT.Text));


            decimal all_income = 0;
            income_tableTableAdapter1.FillBy_fatora_id(dataSet11.income_table, Convert.ToInt32(salesID_TXT.Text));
            foreach (DataRow dr in dataSet11.income_table.Rows)
            {
                all_income += Convert.ToDecimal(dr["income_cost"]);
            }
            safeTableAdapter1.Update_sarf_from_safe(all_income);
            safeTableAdapter1.Insert_safe(dateTimePicker1.Value.ToShortDateString(), -all_income);
        
            //delete from arba7
            arba7_tableTableAdapter1.Delete_fatora_id(Convert.ToInt32(salesID_TXT.Text));

            //delete from income
            string income_details = "مبلغ من فاتورة بيع رقم " + salesID_TXT.Text;

            sales_mortaga3TableAdapter1.Delete_by_fatora_id(Convert.ToInt32(salesID_TXT.Text));
            income_tableTableAdapter1.Delete_by_fatora(Convert.ToInt32(salesID_TXT.Text));
            saydaly_nesbaTableAdapter1.Delete_by_fatora_id(Convert.ToInt32(salesID_TXT.Text));
            // }
            //catch
            //{
            //    MessageBox.Show("تأكد من ادخال البيانات بطريقة صحيحه");
            //    return;
            //}

        }

        string new_fatora_type="";

        private void savebtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
                string id = dgr.Cells[1].Value.ToString();
                products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, id, far3txt.Text);
                decimal pro_count;


               
                    pro_count = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);

                    if (Convert.ToDecimal(dgr.Cells[2].Value) > pro_count)
                    {

                        //selectedRow.Cells[2].Value = "0";
                        //selectedRow.Cells[5].Value = "0";
                        // dataGridView1.Rows.RemoveAt(selectedrowindex);
                        dgr.Selected = true;
                        MessageBox.Show("الكمية " + id.ToString() + " غير متاحه في الفرع  برجاء اضافة الكمية الصحيحة  ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                
            }


            try
            {
                if ((Convert.ToDecimal(madfoo3TXT.Text) < Convert.ToDecimal(matloobTXT.Text)) && cst_nameTXT.Text == "")
                {
                    MessageBox.Show("ادخل اسم العميل");
                    return;
                }
                if ((Convert.ToDecimal(madfoo3TXT.Text) < Convert.ToDecimal(matloobTXT.Text)) && cst_nameTXT.Text == "نقدي")
                {
                    MessageBox.Show("ادخل اسم العميل");
                    return;
                }

            }
            catch { }
            if (madfoo3TXT.Text == "")
            {
                madfoo3TXT.Text = matloobTXT.Text;
                //MessageBox.Show("ادخل المبلغ المدفوع", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //madfoo3TXT.Select();
                //return;
            }

            if (mandoob_txt.Text == "")
            {

                MessageBox.Show("ادخل اسم المندوب ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mandoob_txt.Select();
                return;
            }


            egmaly_kest_txt.Text = "0";



            try
            {
                this.numbers_tableTableAdapter1.Fill(this.dataSet11.Numbers_table);
                salesID_TXT.Text = dataSet11.Numbers_table.Rows[0]["sales_ID"].ToString();
            }
            catch { }

            int fatora_number = Convert.ToInt32(sales_num);
            string old_user = usertxt.Text;

           

           

           
            if ((Convert.ToDecimal(madfoo3TXT.Text) < Convert.ToDecimal(matloobTXT.Text)) && cst_nameTXT.Text == "")
            {
                MessageBox.Show("ادخل اسم العميل");
                return;
            }
            if ((Convert.ToDecimal(madfoo3TXT.Text) < Convert.ToDecimal(matloobTXT.Text)) && cst_nameTXT.Text == "نقدي")
            {
                MessageBox.Show("ادخل اسم العميل");
                return;
            }

            sales_num = salesID_TXT.Text;


            egmaly_kest_txt.Text = "0";


           
            if (type_txt.Text == "تعديل")
            {
                delete_sales();
                save_fatora();
            }
            else
            {
               
                save_fatora();
            }

          

           
            select_printer s = new select_printer();
            
            s.sales_num.Text = sales_num;
            s.cst_name_txt.Text = cst_nameTXT.Text;
            s.ShowDialog();
           
            //DialogResult re = MessageBox.Show("هل تريد طباعة الفاتورة", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if (re == DialogResult.Yes)
            //{

            //    try
            //    {



            //        try
            //        {
            //            crystalReport11.Refresh();
            //            crystalReport11.SetDataSource(dataSet11);
            //        }
            //        catch
            //        {

            //            crystalReport11.Refresh();
            //            crystalReport11.SetDataSource(dataSet11);
            //        }
            //        sales_tableTableAdapter.FillBy_ID(dataSet11.sales_table, Convert.ToInt32(sales_num));


            //        crystalReport11.PrintToPrinter(1, false, 0, 0);
                    

            //        string ppath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Copy of CrystalReport1.rpt";

            //        foreach (var item in l.Items)
            //        {
            //            // MessageBox.Show(item.ToString());
            //            try
            //            {




            //                try
            //                {
            //                    copy_of_CrystalReport11.Refresh();
            //                    copy_of_CrystalReport11.SetDataSource(dataSet11);
            //                }
            //                catch
            //                {

            //                    copy_of_CrystalReport11.Refresh();
            //                    copy_of_CrystalReport11.SetDataSource(dataSet11);
            //                }

            //                sales_tableTableAdapter.FillBy_sales_id_and_dariba(dataSet11.sales_table, Convert.ToInt32(sales_num), Convert.ToDecimal(item.ToString()));//(;.., item.ToString());

            //                copy_of_CrystalReport11.PrintToPrinter(1, false, 0, 0);


            //            }
            //            catch { }
            //        }

            //        fatora_type.Text = new_fatora_type;
            //        usertxt.Text = old_user;
            //    }
            //    catch
            //    {
            //        Thread.Sleep(1500);

            //        try
            //        {
            //            crystalReport11.Refresh();
            //            crystalReport11.SetDataSource(dataSet11);
            //        }
            //        catch
            //        {

            //            crystalReport11.Refresh();
            //            crystalReport11.SetDataSource(dataSet11);
            //        }
            //        sales_tableTableAdapter.FillBy_ID(dataSet11.sales_table, Convert.ToInt32(sales_num));


            //        crystalReport11.PrintToPrinter(1, false, 0, 0);



            //        string ppath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Copy of CrystalReport1.rpt";

            //        foreach (var item in l.Items)
            //        {
            //            // MessageBox.Show(item.ToString());
            //            try
            //            {




            //                try
            //                {
            //                    copy_of_CrystalReport11.Refresh();
            //                    copy_of_CrystalReport11.SetDataSource(dataSet11);
            //                }
            //                catch
            //                {

            //                    copy_of_CrystalReport11.Refresh();
            //                    copy_of_CrystalReport11.SetDataSource(dataSet11);
            //                }

            //                sales_tableTableAdapter.FillBy_sales_id_and_dariba(dataSet11.sales_table, Convert.ToInt32(sales_num), Convert.ToDecimal(item.ToString()));//(;.., item.ToString());

            //                copy_of_CrystalReport11.PrintToPrinter(1, false, 0, 0);


            //            }
            //            catch { }
            //        }
            //    }




            //    fatora_type.Text = new_fatora_type;
            //    usertxt.Text = old_user;
            //}

            try
            {
                this.numbers_tableTableAdapter1.Fill(this.dataSet11.Numbers_table);
                salesID_TXT.Text = dataSet11.Numbers_table.Rows[0]["sales_ID"].ToString();
            }
            catch { }
            dataGridView1.Rows.Clear();
            discountTXT.Text = "0";
            product_nameTXT.Clear();
            cst_addressTXT.Clear();
            cst_nameTXT.Clear();
            cst_phoneTXT.Clear();

            madfoo3TXT.Text = "";
            usertxt.Text = old_user;
            cst_nameTXT.Text = "نقدي";
            suggest_cst_name();
        }
        
        string sales_num;
        private void save_fatora()
        {

            //madeen_tableTableAdapter1.FillBy_by_madeen(dataSet11.madeen_table, cst_nameTXT.Text);
            //MessageBox.Show(dataSet11.madeen_table.Rows[0]["madden_matloob"].ToString());
            //MessageBox.Show(dataSet11.madeen_table.Rows[0]["madden_madfoo3"].ToString());

            try
            {
                this.numbers_tableTableAdapter1.Fill(this.dataSet11.Numbers_table);
                salesID_TXT.Text = dataSet11.Numbers_table.Rows[0]["sales_ID"].ToString();
                sales_num = salesID_TXT.Text;
            }
            catch { }
            
            //check if customer exist
            check_customer();
            //if (madfoo3TXT.Text == "")
            //{
            //    MessageBox.Show("ادخل المبلغ المدفوع", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    madfoo3TXT.Select();
            //    return;
            //}

            if (Convert.ToDecimal(madfoo3TXT.Text) < Convert.ToDecimal(matloobTXT.Text))
            {


                //madeen 
                madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet11.madeen_small_report, cst_nameTXT.Text);
                //madeen_tableTableAdapter1.FillBy_by_madeen(dataSet11.madeen_table, cst_nameTXT.Text);

                decimal old_7esab = 0;
                decimal ba2y_el7esab = 0;
                if (dataSet11.madeen_small_report.Rows.Count >0)
                {
                    //if madeen exist
                    // شوف هنعمل ايه هنا
                    old_7esab = Convert.ToDecimal(dataSet11.madeen_small_report.Rows[0]["madeen_small_ba2y"]);


                    //madeen small report update
                    madeen_small_reportTableAdapter1.Update_matloob_AND_madfoo3_by_name(Convert.ToDecimal(matloobTXT.Text), Convert.ToDecimal(madfoo3TXT.Text), cst_nameTXT.Text);
                    madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet11.madeen_small_report, cst_nameTXT.Text);
                    decimal new_matloob = Convert.ToDecimal(dataSet11.madeen_small_report.Rows[0]["madeen_small_matloob"]);
                    decimal new_madfoo3 = Convert.ToDecimal(dataSet11.madeen_small_report.Rows[0]["madeen_small_madfoo3"]);

                    ba2y_el7esab = Convert.ToDecimal(dataSet11.madeen_small_report.Rows[0]["madeen_small_ba2y"]);

                    //madeen details insert


                    string madeen_byan = "مدفوع وقت الفاتورة " + salesID_TXT.Text;
                    madeen_tableTableAdapter1.Insert_madeen_details(dateTimePicker1.Value.ToShortDateString(), cst_nameTXT.Text, madeen_byan, Convert.ToDecimal(matloobTXT.Text), Convert.ToDecimal(madfoo3TXT.Text), notesTXT.Text, usertxt.Text, ""
                   , Convert.ToDecimal(matloobTXT.Text), Convert.ToDecimal(madfoo3TXT.Text), Convert.ToInt32(salesID_TXT.Text), 1, dateTimePicker1.Value.ToShortDateString(), Convert.ToDecimal(madfoo3TXT.Text), "paid", dateTimePicker1.Value.ToShortDateString(), "");


                    madeen_tableTableAdapter1.Update_est7kak_AND_cost_BY_name_AND_kest_no(DateTime.Today.AddDays(3).ToShortDateString(), Convert.ToDecimal(hesab_sab2_txt.Text) + (Convert.ToDecimal(matloobTXT.Text) - Convert.ToDecimal(madfoo3TXT.Text))
                                   , 2, cst_nameTXT.Text);

                    //تعديل هنا
                    //  madeen_tableTableAdapter1.Insert_madeen_details(dateTimePicker1.Value.ToShortDateString(), cst_nameTXT.Text, madeen_byan, Convert.ToDecimal(matloobTXT.Text), Convert.ToDecimal(madfoo3TXT.Text), notesTXT.Text, usertxt.Text, ""
                    //   , new_matloob, new_madfoo3, Convert.ToInt32(salesID_TXT.Text));

                    //madeen details update matlob and madfo93
                    madeen_tableTableAdapter1.Update_new_matloob_new_madfoo3_by_name(new_matloob, new_madfoo3, cst_nameTXT.Text);

                    madeen_tableTableAdapter1.FillBy_by_madeen(dataSet11.madeen_table, cst_nameTXT.Text);
                    //string matloob=dataSet11.madeen_table.Rows[0][""].ToString();
                    //MessageBox.Show(

                }

                else
                {
                    //if madeen doesn't exist
                    //try
                    //{
                    old_7esab = 0;

                    ba2y_el7esab = Convert.ToDecimal(matloobTXT.Text) - Convert.ToDecimal(madfoo3TXT.Text);
                    if (Convert.ToDecimal(madfoo3TXT.Text) < Convert.ToDecimal(matloobTXT.Text))
                    {
                        //madeen small report
                        madeen_small_reportTableAdapter1.Insert_madeen_small(cst_nameTXT.Text, Convert.ToDecimal(matloobTXT.Text), Convert.ToDecimal(madfoo3TXT.Text));

                        //madeen details insert
                        string madeen_byan = "مدفوع وقت الفاتورة " + salesID_TXT.Text;
                        madeen_tableTableAdapter1.Insert_madeen_details(dateTimePicker1.Value.ToShortDateString(), cst_nameTXT.Text, madeen_byan, Convert.ToDecimal(matloobTXT.Text), Convert.ToDecimal(madfoo3TXT.Text), notesTXT.Text, usertxt.Text, ""
                       , Convert.ToDecimal(matloobTXT.Text), Convert.ToDecimal(madfoo3TXT.Text), Convert.ToInt32(salesID_TXT.Text), 1, dateTimePicker1.Value.ToShortDateString(), Convert.ToDecimal(madfoo3TXT.Text), "paid", dateTimePicker1.Value.ToShortDateString(), "");



                        madeen_tableTableAdapter1.Insert_madeen_details(dateTimePicker1.Value.ToShortDateString(), cst_nameTXT.Text, "", Convert.ToDecimal(matloobTXT.Text), Convert.ToDecimal(matloobTXT.Text) - Convert.ToDecimal(madfoo3TXT.Text), notesTXT.Text, usertxt.Text, ""
                             , Convert.ToDecimal(matloobTXT.Text), Convert.ToDecimal(madfoo3TXT.Text), Convert.ToInt32(salesID_TXT.Text), 2, DateTime.Today.AddDays(3).ToString(), Convert.ToDecimal(matloobTXT.Text) - Convert.ToDecimal(madfoo3TXT.Text), "not paid", "", "");


                    }
                    else { ba2y_el7esab = 0; }


                }

            }
            //ma5zoon
            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {


                products_tableTableAdapter1.FillBy_int_code_and_far3(dataSet11.products_table,Convert.ToInt32( dgr.Cells[0].Value.ToString()), far3txt.Text);
                    string pro_code = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                    string unit_price = dataSet11.products_table.Rows[0]["pro_bee3"].ToString();
                    decimal pro_count = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);
                    decimal pro_count_after = pro_count - Convert.ToDecimal(dgr.Cells[2].Value);
                    ma5zoon_movesTableAdapter1.Insert_ma5zoon_moves_all(dateTimePicker1.Value.ToShortDateString(), dgr.Cells[0].Value.ToString(), dgr.Cells[1].Value.ToString(), Convert.ToDecimal(dgr.Cells[2].Value),
                        Convert.ToDecimal(dgr.Cells[4].Value), pro_count, pro_count_after, "بيـع", Convert.ToInt32(salesID_TXT.Text), cst_nameTXT.Text, usertxt.Text,far3txt.Text);

                
            }

            //products
            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
              
                    products_tableTableAdapter1.Update_count_BY_ID_bee3(Convert.ToDecimal(dgr.Cells[2].Value), Convert.ToDecimal(dgr.Cells[2].Value), dgr.Cells[0].Value.ToString(),far3txt.Text);
               
            }
            
            //reb7
            decimal reb7 = 0;
            decimal basic=0;
            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {


                products_tableTableAdapter1.FillBy_int_code_and_far3(dataSet11.products_table, Convert.ToInt32(dgr.Cells[0].Value.ToString()), far3txt.Text);

                decimal basic_profit = Convert.ToDecimal(dataSet11.products_table.Rows[0]["nesba_saydaly"]) * Convert.ToDecimal(dgr.Cells[2].Value);
                decimal pro_taklefa = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_cost_price"]) * Convert.ToDecimal(dgr.Cells[2].Value);
                decimal pro_bee3 = Convert.ToDecimal(dgr.Cells[3].Value) * Convert.ToDecimal(dgr.Cells[2].Value);
                decimal pro_profit = pro_bee3 - pro_taklefa;

                reb7 += pro_profit;
                basic += basic_profit;

                decimal pro_cost_all = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_cost_price"]) * Convert.ToDecimal(dgr.Cells[2].Value);
                decimal pro_bee3_all = Convert.ToDecimal(dgr.Cells[3].Value) * Convert.ToDecimal(dgr.Cells[2].Value);

                arba7_cat_tableTableAdapter1.Insert(DateTime.Today, dgr.Cells[1].Value.ToString(), pro_bee3_all - pro_cost_all, dgr.Cells[5].Value.ToString(), Convert.ToInt32(salesID_TXT.Text), "قطع غيار صيانة");



                reb7 += Convert.ToDecimal(egmaly_kest_txt.Text);
                //    reb7 -= Convert.ToDecimal(discountTXT.Text);
            }
            //sales
            if (egmaly_kest_txt.Text == "")
            {
                egmaly_kest_txt.Text = "0";
            }
            string note="";
            if(Convert.ToDecimal(madfoo3TXT.Text)>=Convert.ToDecimal(matloobTXT.Text))
            {
            //    note="كاش";
            }else
            {
           //     note="قسط على "+number_of_aksat_txt.Text+" "+comboBox1.Text;
            }
               foreach (DataGridViewRow dgr in dataGridView1.Rows)
                {
                    //try
                    //{
                    products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, dgr.Cells[1].Value.ToString(),far3txt.Text);
                    string cat = dataSet11.products_table.Rows[0]["pro_category"].ToString();
                   decimal old_7esab_sab2;
                   decimal ba2y_el7esab_new;
                   if (Convert.ToDecimal(madfoo3TXT.Text) < Convert.ToDecimal(matloobTXT.Text))
                   {
                       ba2y_el7esab_new = Convert.ToDecimal(matloobTXT.Text) - Convert.ToDecimal(madfoo3TXT.Text);
                   }
                   else
                   {
                       ba2y_el7esab_new = 0;
                   }
                   if (hesab_sab2_txt.Text != "")
                   {
                       old_7esab_sab2 = Convert.ToDecimal(hesab_sab2_txt.Text);
                   }
                   else
                   {
                       old_7esab_sab2 = 0;
                   }
                   sales_tableTableAdapter1.Insert(Convert.ToInt32(salesID_TXT.Text), dateTimePicker1.Value, cst_nameTXT.Text, cst_phoneTXT.Text, cst_addressTXT.Text
                            , reb7, Convert.ToDecimal(madfoo3TXT.Text), usertxt.Text, Convert.ToDecimal(discountTXT.Text),old_7esab_sab2, ba2y_el7esab_new, dgr.Cells[0].Value.ToString(), dgr.Cells[1].Value.ToString(),
                            Convert.ToDecimal(dgr.Cells[2].Value), Convert.ToDecimal(dgr.Cells[3].Value), note + "  " + notesTXT.Text, Convert.ToDouble(nesba_discount_txt.Text), Convert.ToDecimal(0), cat, Convert.ToDecimal(egmaly_kest_txt.Text),"", far3txt.Text
                            ,mandoob_txt.Text);
                        
                     //}
                    //catch { }
                    //decimal nesba = Convert.ToDecimal(dataSet11.products_table.Rows[0]["nesba_saydaly"]);
                    //decimal bee3 = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_bee3"]);
                    //decimal count = Convert.ToDecimal(dgr.Cells[2].Value);

                    //saydaly_nesbaTableAdapter1.Insert(dateTimePicker1.Value, usertxt.Text, dgr.Cells[1].Value.ToString(), nesba, bee3, count, Convert.ToInt32(salesID_TXT.Text));
                }
            
            //arba7

               string arba7_details = "ربح فاتورة بيع رقم " + salesID_TXT.Text;
               arba7_tableTableAdapter1.Insert_arba7(dateTimePicker1.Value.ToShortDateString(), arba7_details, reb7, "مبيعات", Convert.ToInt32(salesID_TXT.Text), "", usertxt.Text,basic);

            //income
               string income_details = "مبلغ من فاتورة بيع رقم " + salesID_TXT.Text;
            decimal income_cost = 0;
            string source="";
            if (Convert.ToDecimal(madfoo3TXT.Text) < Convert.ToDecimal(matloobTXT.Text))
            {
                income_cost = Convert.ToDecimal(madfoo3TXT.Text);
                source = "آجل";
                safeTableAdapter1.Update_add_to_safe(income_cost);


                //safe status daily
                safeTableAdapter1.Insert_safe(dateTimePicker1.Value.ToShortDateString(), income_cost);


            }
            else if (Convert.ToDecimal(madfoo3TXT.Text) >= Convert.ToDecimal(matloobTXT.Text) &&radioButton1.Checked==true)
            {
                income_cost = Convert.ToDecimal(matloobTXT.Text);
                source = "كاش";
                safeTableAdapter1.Update_add_to_safe(income_cost);


                //safe status daily
                safeTableAdapter1.Insert_safe(dateTimePicker1.Value.ToShortDateString(), income_cost);



            }
            else if (Convert.ToDecimal(madfoo3TXT.Text) >= Convert.ToDecimal(matloobTXT.Text) && radioButton2.Checked == true)
            {
                income_cost = Convert.ToDecimal(matloobTXT.Text);
                source = "فيزا";

            }
            income_tableTableAdapter1.Insert_income(dateTimePicker1.Value.ToShortDateString(), income_details, income_cost, Convert.ToInt32(salesID_TXT.Text), source, cst_nameTXT.Text, usertxt.Text, "  " + "",far3txt.Text);

            //safe_status  current

            

            //sales number
            if (type_txt.Text != "تعديل")
            {
                numbers_tableTableAdapter1.Update_sales_id();
            }
            //}
            //catch { }

          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cst_nameTXT_TextChanged(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
            //customersTableAdapter1.FillBy_NAME_LIKE(dataSet11.customers, cst_nameTXT.Text);
            //foreach (DataRow dr in dataSet11.customers.Rows) 
            //{
            //    dataGridView3.Rows.Add(dr["cst_name"].ToString());
            //}

            customersTableAdapter1.FillBy_name(dataSet11.customers, cst_nameTXT.Text);
            try
            {
                cst_phoneTXT.Text = dataSet11.customers.Rows[0]["cst_phone"].ToString();
                cst_addressTXT.Text = dataSet11.customers.Rows[0]["cst_address"].ToString();
                notesTXT.Text = dataSet11.customers.Rows[0]["cst_notes"].ToString();
                //fatora_type.Text = dataSet11.customers.Rows[0]["cst_price_category"].ToString();
            }
            catch
            {
                cst_phoneTXT.Text = "";
                cst_addressTXT.Text = "";
             //   fatora_type.Text = "";
            }
            
            try
            {
                madeen_tableTableAdapter1.FillBy_by_madeen(dataSet11.madeen_table, cst_nameTXT.Text);
                hesab_sab2_txt.Text = dataSet11.madeen_table.Rows[0]["madden_ba2y"].ToString();

            }
            catch
            {
                try
                {
                    

                    madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet11.madeen_small_report, cst_nameTXT.Text);
                    hesab_sab2_txt.Text = dataSet11.madeen_small_report.Rows[0]["madeen_small_ba2y"].ToString();

                }
                catch
                {

                    notesTXT.Text = "";
                   
                    hesab_sab2_txt.Text = "";


                }


            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //if (type_txt.Text != "تعديل")
                //{
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                    decimal old_count = Convert.ToDecimal(selectedRow.Cells[2].Value);
                    string id = selectedRow.Cells[1].Value.ToString();
                    products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, id, far3txt.Text);
                    decimal pro_count;


                   
                        pro_count = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);

                        if (Convert.ToDecimal(selectedRow.Cells[2].Value) > pro_count)
                        {

                             //selectedRow.Cells[2].Value = "0";
                            //selectedRow.Cells[5].Value = "0";
                            dataGridView1.Rows.RemoveAt(selectedrowindex);
                            MessageBox.Show("الكمية غير متاحه في الفرع تم حذف الصنف برجاء اضافة الكمية الصحيحة مرة اخرى", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                           
                            //selectedRow.Selected = false;
                           // MessageBox.Show("gomla");
                            return;

                        }
                        else { return; }
                   

                    //    products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, (selectedRow.Cells[1].Value.ToString()));
                    //    string category_name = "";
                    //    try
                    //    {
                    //        category_name = dataSet11.products_table.Rows[0]["pro_category"].ToString();
                    //    }
                    //    catch { }
                    //    categoryTableAdapter1.FillBy_name(dataSet11.Category, category_name);

                    //}
               // }
            }
            catch { }
        }

       

        

        private void gadwala_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.Rows.Clear();
                int count = 1;
                if (madfoo3TXT.Text == "")
                {
                    madfoo3TXT.Text = "0";
                }
                decimal kest_cost = (Convert.ToDecimal(matloobTXT.Text) - Convert.ToDecimal(madfoo3TXT.Text)) / Convert.ToDecimal(number_of_aksat_txt.Text);
                if (comboBox1.Text == "شهري")
                {
                    DateTime date = DateTime.Today;

                    for (int i = 0; i < Convert.ToInt32(number_of_aksat_txt.Text); i++)
                    {
                        count += 1;
                        date = date.AddMonths(1);
                        dataGridView2.Rows.Add(count.ToString(), date.ToShortDateString(), kest_cost, "new");
                    }
                }
                else if (comboBox1.Text == "إسبوعي")
                {
                    DateTime date = DateTime.Today;

                    for (int i = 0; i < Convert.ToInt32(number_of_aksat_txt.Text); i++)
                    {
                        count += 1;
                        date = date.AddDays(7);
                        dataGridView2.Rows.Add(count.ToString(), date.ToShortDateString(), kest_cost, "new");
                    }
                }
            }
            catch { }
        }

        private void egmaly_kest_txt_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = gadwala_btn;
            //try 
            //{
            //    gadwala_btn_Click(sender, e);
            //}
            //catch { }

           


            try
            {
                decimal ba2y = Convert.ToDecimal(madfoo3TXT.Text) - Convert.ToDecimal(matloobTXT.Text);
                ba2y_txt.Text = ba2y.ToString();
            }
            catch
            {
                ba2y_txt.Text = "0";
            }
            //try
            //{

            //    decimal kest_cost = (Convert.ToDecimal(matloobTXT.Text) - Convert.ToDecimal(madfoo3TXT.Text)) / Convert.ToDecimal(number_of_aksat_txt.Text);
            //    foreach (DataGridViewRow dgr in dataGridView2.Rows)
            //    {
            //        if (dgr.Cells[0].Value.ToString() != "")
            //        {
            //            dgr.Cells[2].Value = kest_cost.ToString();
            //        }
            //    }
            //}
            //catch { }
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedrowindex = dataGridView2.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView2.Rows[selectedrowindex];
                
                    int x = selectedRow.Index - 1;
                    int ready = Convert.ToInt32(dataGridView2.Rows[x].Cells[0].Value) + 1;
                    selectedRow.Cells[0].Value = ready.ToString();

                    try 
                    {
                        string selected_string = selectedRow.Cells[3].Value.ToString();
                        //MessageBox.Show(selected_string);
                    }
                    catch 
                    {
                        selectedRow.Cells[3].Value = "new";
                    }

                
                //  string selected_string = selectedRow.Cells["Column11"].Value.ToString();
                    //MessageBox.Show(selected_string);
                    //if ( selected_string== "")
                    //{
                   // MessageBox.Show("aaaa");
                   // selectedRow.Cells[3].Value = "new";
                    //  MessageBox.Show(selectedRow.Cells[0].Value.ToString());
                    //   }
                

            }
            catch {  }
        }

        private void discountTXT_TextChanged(object sender, EventArgs e)
        {

            //try
            //{
            //    double nesba = (Convert.ToDouble(discountTXT.Text) * 100) / Convert.ToDouble(egmalyTXT.Text);
            //    nesba_discount_txt.Text = nesba.ToString();
            //}
            //catch { }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, selectedRow.Cells[1].Value.ToString(), far3txt.Text);
                raseed_now_txt.Text = dataSet11.products_table.Rows[0]["pro_count"].ToString();
                taklefa_txt.Text = dataSet11.products_table.Rows[0]["pro_cost_price"].ToString();
                we7dat_txt.Text = dataSet11.products_table.Rows[0]["pro_pieces_in_packet"].ToString();
            }
            catch { }
            try
            {
                if (e.ColumnIndex == 6)
                {
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                    DialogResult re = MessageBox.Show("هل تريد حذف الصنف  " + selectedRow.Cells[1].Value.ToString() + " ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (re == DialogResult.Yes)
                    {
                        dataGridView1.Rows.Remove(selectedRow);
                    }
                }

            }
            catch { }
        }

        string old_madfoo3 = "";
        private void salesID_TXT_TextChanged(object sender, EventArgs e)
        {
        //    try 
        //    {
        //       // timer1.Stop();
        //        dataGridView1.Rows.Clear();
        //        sales_tableTableAdapter.FillBy_ID(dataSet11.sales_table, Convert.ToInt32(salesID_TXT.Text));

        //        cst_nameTXT.Text = dataSet11.sales_table.Rows[0]["sales_cst_name"].ToString();
        //        cst_phoneTXT.Text = dataSet11.sales_table.Rows[0]["sales_cst_phone"].ToString();
        //        cst_addressTXT.Text = dataSet11.sales_table.Rows[0]["sales_cst_address"].ToString();

        //        dateTimePicker1.Value = Convert.ToDateTime(dataSet11.sales_table.Rows[0]["sales_date"]);
               
        //        //discountTXT.Text = dataSet11.sales_table.Rows[0]["sales_discount"].ToString();
        //        //nesba_discount_txt.Text = dataSet11.sales_table.Rows[0]["sales_nesba_discount"].ToString();
        //      //  reb7TXT.Text = dataSet11.sales_table.Rows[0]["sales_profit"].ToString();
        //       // hesab_sab2TXT.Text = dataSet11.sales_table.Rows[0]["sales_7esab_sabe2"].ToString();
        //      //  ba2y_el7esabTXT.Text = dataSet11.sales_table.Rows[0]["sales_ba2y_el7esab"].ToString();

        //      old_madfoo3= dataSet11.sales_table.Rows[0]["sales_madfoo3"].ToString();
        //      madfoo3TXT.Text = dataSet11.sales_table.Rows[0]["sales_madfoo3"].ToString();
        //      //  mwazafTXT.Text = dataSet11.sales_table.Rows[0]["sales_user"].ToString();

        //        notesTXT.Text = dataSet11.sales_table.Rows[0]["sales_notes"].ToString();


        //        egmaly_kest_txt.Text = dataSet11.sales_table.Rows[0]["sales_egmaly_kest_cost"].ToString();
        //        foreach (DataRow dr in dataSet11.sales_table.Rows)
        //        {
        //            dataGridView1.Rows.Add(dr["sales_product_ID"].ToString(), dr["sales_product_name"].ToString(), dr["sales_product_count"].ToString(), dr["sales_unit_price"].ToString(), dr["sales_price_for_sell"].ToString(), dr["sales_dariba"].ToString());
        //            if (dataGridView1.Columns.Count == 8)
        //            {
        //                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

        //                btn.Width = 75;
        //                btn.Text = "حذف";
        //                btn.DefaultCellStyle.BackColor = Color.Red;
        //                btn.Name = "الحذف";
        //                btn.UseColumnTextForButtonValue = true;


        //                dataGridView1.Columns.Add(btn);
        //            }
        //        }


        //        try
        //        {
        //            decimal sum = 0;
        //           // decimal sum_dariba = 0;
        //            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
        //            {
        //                dataGridView1.Rows[i].Cells[4].Value = Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value) * Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value);
        //                //sum_dariba += Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);

        //                sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);

        //            }

        //            decimal egmaly_after = sum + Convert.ToDecimal(egmaly_kest_txt.Text);
        //            egmaly_se3r_txt.Text = sum.ToString();
        //           // egmaly_dariba_txt.Text = sum_dariba.ToString();
        //            egmaly_elfatoraTXT.Text = Convert.ToString(egmaly_after);
                    

        //            foreach (DataGridViewRow dgr in dataGridView2.Rows)
        //            {
        //                if (dgr.Cells[0].Value.ToString() != "")
        //                {
        //                    dgr.Cells[3].Value = "new";
        //                }
        //            }
        //        }
        //        catch { }
        //        try
        //        {
        //            decimal ba2y = Convert.ToDecimal(matloobTXT.Text) - Convert.ToDecimal(madfoo3TXT.Text);
        //            ba2y_txt.Text = ba2y.ToString();
        //        }
        //        catch
        //        {
        //            ba2y_txt.Text = "0";
        //        }
        //       // timer1.Start();

        //}

        //    catch { 
        //    //    timer1.Start();
        //    }
        }

        private void nesba_discount_txt_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (nesba_discount_txt.Text == "")
            //    {
            //        nesba_discount_txt.Text = "0";
            //    }
            //    if (nesba_discount_txt.Text != "")
            //    {
            //        double nesba = (Convert.ToDouble(nesba_discount_txt.Text) / 100) * Convert.ToDouble(egmalyTXT.Text);
            //        discountTXT.Text = nesba.ToString();
            //    }
            //    else if (nesba_discount_txt.Text != "0")
            //    {
            //        double nesba = (Convert.ToDouble(nesba_discount_txt.Text) / 100) * Convert.ToDouble(egmalyTXT.Text);
            //        discountTXT.Text = nesba.ToString();
            //        //  discountTXT.Text = "0";
            //    }

            //}
            //catch { }
        }

        private void label_reb7_txt_Click(object sender, EventArgs e)
        {
            if (label_reb7_txt.Text == "الــربح")
            {
                decimal reb77 = 0;
                foreach (DataGridViewRow dgr in dataGridView1.Rows)
                {
                    products_tableTableAdapter1.FillBy_int_code_and_far3(dataSet11.products_table,Convert.ToInt32( dgr.Cells[0].Value.ToString()), far3txt.Text);

                    decimal pro_taklefa = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_cost_price"]) * Convert.ToDecimal(dgr.Cells[2].Value);
                    decimal pro_bee3 = Convert.ToDecimal(dgr.Cells[3].Value) * Convert.ToDecimal(dgr.Cells[2].Value);
                    decimal pro_profit = pro_bee3 - pro_taklefa;

                    reb77 += pro_profit;

                }
                string ll = egmaly_kest_txt.Text;
                if (egmaly_kest_txt.Text == "") 
                {
                    egmaly_kest_txt.Text = "0";
                }
                reb77 += Convert.ToDecimal(egmaly_kest_txt.Text);
              //  reb77 -= Convert.ToDecimal(discountTXT.Text);
                label_reb7_txt.Text = reb77.ToString();
                egmaly_kest_txt.Text = ll;
            }
            else { label_reb7_txt.Text = "الــربح"; }
        }

        private void label_reb7_txt_MouseLeave(object sender, EventArgs e)
        {
            label_reb7_txt.Text = "الــربح"; 
        }

        private void egmaly_elfatoraTXT_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (type_txt.Text != "تعديل")
            //    {
            //        madeen_tableTableAdapter1.FillBy_by_madeen(dataSet11.madeen_table, cst_nameTXT.Text);

            //        hesab_sab2_txt.Text = dataSet11.madeen_small_report.Rows[0]["madeen_small_ba2y"].ToString();

            //        //decimal sabek = (Convert.ToDecimal(dataSet11.madeen_table.Rows[0]["madden_ba2y"]) + Convert.ToDecimal(old_madfoo3)) - Convert.ToDecimal(egmaly_elfatoraTXT.Text);
            //        //hesab_sab2_txt.Text = sabek.ToString();
            //        //MessageBox.Show(dr["madden_ba2y"].ToString() + " " + old_madfoo3.ToString() + " " + egmaly_elfatoraTXT.Text);
            //    }
            //}
            //catch { }
        }

        private void egmaly_kest_txt_Leave(object sender, EventArgs e)
        {
            try
            {
                if (madfoo3TXT.Text == "")
                {
                    madfoo3TXT.Text = "0";
                }
                decimal kest_cost = (Convert.ToDecimal(matloobTXT.Text) - Convert.ToDecimal(madfoo3TXT.Text)) / Convert.ToDecimal(number_of_aksat_txt.Text);
                foreach (DataGridViewRow dgr in dataGridView2.Rows)
                {
                    if (dgr.Cells[0].Value.ToString() != "")
                    {
                        dgr.Cells[2].Value = kest_cost.ToString();
                    }
                }
            }
            catch { }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
                int selectedrowindex = dataGridView3.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView3.Rows[selectedrowindex];
                cst_nameTXT.Text = selectedRow.Cells[0].Value.ToString();
            }
            catch { }
        }


        List<CurrencyInfo> currencies = new List<CurrencyInfo>();
        
        
        private void matloobTXT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ToWord toWord = new ToWord(Convert.ToDecimal(matloobTXT.Text), currencies[Convert.ToInt32(0)]);
                // textBox2.Text = toWord.ConvertToEnglish();
                cost_in_words_txt.Text = toWord.ConvertToArabic();
            }
            catch { }
        }


        public class ToWord
        {
            /// Group Levels: 987,654,321.234
            /// 234 : Group Level -1
            /// 321 : Group Level 0
            /// 654 : Group Level 1
            /// 987 : Group Level 2

            #region Varaibles & Properties

            /// <summary>
            /// integer part
            /// </summary>
            private long _intergerValue;

            /// <summary>
            /// Decimal Part
            /// </summary>
            private int _decimalValue;

            /// <summary>
            /// Number to be converted
            /// </summary>
            public Decimal Number { get; set; }

            /// <summary>
            /// Currency to use
            /// </summary>
            public CurrencyInfo Currency { get; set; }

            /// <summary>
            /// English text to be placed before the generated text
            /// </summary>
            public String EnglishPrefixText { get; set; }

            /// <summary>
            /// English text to be placed after the generated text
            /// </summary>
            public String EnglishSuffixText { get; set; }

            /// <summary>
            /// Arabic text to be placed before the generated text
            /// </summary>
            public String ArabicPrefixText { get; set; }

            /// <summary>
            /// Arabic text to be placed after the generated text
            /// </summary>
            public String ArabicSuffixText { get; set; }
            #endregion

            #region General

            /// <summary>
            /// Constructor: short version
            /// </summary>
            /// <param name="number">Number to be converted</param>
            /// <param name="currency">Currency to use</param>
            public ToWord(Decimal number, CurrencyInfo currency)
            {
                InitializeClass(number, currency, String.Empty, "only.", "فقط", "لا غير.");
            }

            /// <summary>
            /// Constructor: Full Version
            /// </summary>
            /// <param name="number">Number to be converted</param>
            /// <param name="currency">Currency to use</param>
            /// <param name="englishPrefixText">English text to be placed before the generated text</param>
            /// <param name="englishSuffixText">English text to be placed after the generated text</param>
            /// <param name="arabicPrefixText">Arabic text to be placed before the generated text</param>
            /// <param name="arabicSuffixText">Arabic text to be placed after the generated text</param>
            public ToWord(Decimal number, CurrencyInfo currency, String englishPrefixText, String englishSuffixText, String arabicPrefixText, String arabicSuffixText)
            {
                InitializeClass(number, currency, englishPrefixText, englishSuffixText, arabicPrefixText, arabicSuffixText);
            }

            /// <summary>
            /// Initialize Class Varaibles
            /// </summary>
            /// <param name="number">Number to be converted</param>
            /// <param name="currency">Currency to use</param>
            /// <param name="englishPrefixText">English text to be placed before the generated text</param>
            /// <param name="englishSuffixText">English text to be placed after the generated text</param>
            /// <param name="arabicPrefixText">Arabic text to be placed before the generated text</param>
            /// <param name="arabicSuffixText">Arabic text to be placed after the generated text</param>
            private void InitializeClass(Decimal number, CurrencyInfo currency, String englishPrefixText, String englishSuffixText, String arabicPrefixText, String arabicSuffixText)
            {
                Number = number;
                Currency = currency;
                EnglishPrefixText = englishPrefixText;
                EnglishSuffixText = englishSuffixText;
                ArabicPrefixText = arabicPrefixText;
                ArabicSuffixText = arabicSuffixText;

                ExtractIntegerAndDecimalParts();
            }

            /// <summary>
            /// Get Proper Decimal Value
            /// </summary>
            /// <param name="decimalPart">Decimal Part as a String</param>
            /// <returns></returns>
            private string GetDecimalValue(string decimalPart)
            {
                string result = String.Empty;

                if (Currency.PartPrecision != decimalPart.Length)
                {
                    int decimalPartLength = decimalPart.Length;

                    for (int i = 0; i < Currency.PartPrecision - decimalPartLength; i++)
                    {
                        decimalPart += "0"; //Fix for 1 number after decimal ( 10.5 , 1442.2 , 375.4 ) 
                    }

                    result = String.Format("{0}.{1}", decimalPart.Substring(0, Currency.PartPrecision), decimalPart.Substring(Currency.PartPrecision, decimalPart.Length - Currency.PartPrecision));

                    result = (Math.Round(Convert.ToDecimal(result))).ToString();
                }
                else
                    result = decimalPart;

                for (int i = 0; i < Currency.PartPrecision - result.Length; i++)
                {
                    result += "0";
                }

                return result;
            }

            /// <summary>
            /// Eextract Interger and Decimal parts
            /// </summary>
            private void ExtractIntegerAndDecimalParts()
            {
                String[] splits = Number.ToString().Split('.');

                _intergerValue = Convert.ToInt32(splits[0]);

                if (splits.Length > 1)
                    _decimalValue = Convert.ToInt32(GetDecimalValue(splits[1]));
            }
            #endregion

            #region English Number To Word

            #region Varaibles

            private static string[] englishOnes =
               new string[] {
            "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine",
            "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"
        };

            private static string[] englishTens =
                new string[] {
            "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"
        };

            private static string[] englishGroup =
                new string[] {
            "Hundred", "Thousand", "Million", "Billion", "Trillion", "Quadrillion", "Quintillion", "Sextillian",
            "Septillion", "Octillion", "Nonillion", "Decillion", "Undecillion", "Duodecillion", "Tredecillion",
            "Quattuordecillion", "Quindecillion", "Sexdecillion", "Septendecillion", "Octodecillion", "Novemdecillion",
            "Vigintillion", "Unvigintillion", "Duovigintillion", "10^72", "10^75", "10^78", "10^81", "10^84", "10^87",
            "Vigintinonillion", "10^93", "10^96", "Duotrigintillion", "Trestrigintillion"
        };
            #endregion

            /// <summary>
            /// Process a group of 3 digits
            /// </summary>
            /// <param name="groupNumber">The group number to process</param>
            /// <returns></returns>
            private string ProcessGroup(int groupNumber)
            {
                int tens = groupNumber % 100;

                int hundreds = groupNumber / 100;

                string retVal = String.Empty;

                if (hundreds > 0)
                {
                    retVal = String.Format("{0} {1}", englishOnes[hundreds], englishGroup[0]);
                }
                if (tens > 0)
                {
                    if (tens < 20)
                    {
                        retVal += ((retVal != String.Empty) ? " " : String.Empty) + englishOnes[tens];
                    }
                    else
                    {
                        int ones = tens % 10;

                        tens = (tens / 10) - 2; // 20's offset

                        retVal += ((retVal != String.Empty) ? " " : String.Empty) + englishTens[tens];

                        if (ones > 0)
                        {
                            retVal += ((retVal != String.Empty) ? " " : String.Empty) + englishOnes[ones];
                        }
                    }
                }

                return retVal;
            }

            /// <summary>
            /// Convert stored number to words using selected currency
            /// </summary>
            /// <returns></returns>
            public string ConvertToEnglish()
            {
                Decimal tempNumber = Number;

                if (tempNumber == 0)
                    return "Zero";

                string decimalString = ProcessGroup(_decimalValue);

                string retVal = String.Empty;

                int group = 0;

                if (tempNumber < 1)
                {
                    retVal = englishOnes[0];
                }
                else
                {
                    while (tempNumber >= 1)
                    {
                        int numberToProcess = (int)(tempNumber % 1000);

                        tempNumber = tempNumber / 1000;

                        string groupDescription = ProcessGroup(numberToProcess);

                        if (groupDescription != String.Empty)
                        {
                            if (group > 0)
                            {
                                retVal = String.Format("{0} {1}", englishGroup[group], retVal);
                            }

                            retVal = String.Format("{0} {1}", groupDescription, retVal);
                        }

                        group++;
                    }
                }

                String formattedNumber = String.Empty;
                formattedNumber += (EnglishPrefixText != String.Empty) ? String.Format("{0} ", EnglishPrefixText) : String.Empty;
                formattedNumber += (retVal != String.Empty) ? retVal : String.Empty;
                formattedNumber += (retVal != String.Empty) ? (_intergerValue == 1 ? Currency.EnglishCurrencyName : Currency.EnglishPluralCurrencyName) : String.Empty;
                formattedNumber += (decimalString != String.Empty) ? " and " : String.Empty;
                formattedNumber += (decimalString != String.Empty) ? decimalString : String.Empty;
                formattedNumber += (decimalString != String.Empty) ? " " + (_decimalValue == 1 ? Currency.EnglishCurrencyPartName : Currency.EnglishPluralCurrencyPartName) : String.Empty;
                formattedNumber += (EnglishSuffixText != String.Empty) ? String.Format(" {0}", EnglishSuffixText) : String.Empty;

                return formattedNumber;
            }

            #endregion

            #region Arabic Number To Word

            #region Varaibles

            private static string[] arabicOnes =
               new string[] {
            String.Empty, "واحد", "اثنان", "ثلاثة", "أربعة", "خمسة", "ستة", "سبعة", "ثمانية", "تسعة",
            "عشرة", "أحد عشر", "اثنا عشر", "ثلاثة عشر", "أربعة عشر", "خمسة عشر", "ستة عشر", "سبعة عشر", "ثمانية عشر", "تسعة عشر"
        };

            private static string[] arabicFeminineOnes =
               new string[] {
            String.Empty, "إحدى", "اثنتان", "ثلاث", "أربع", "خمس", "ست", "سبع", "ثمان", "تسع",
            "عشر", "إحدى عشرة", "اثنتا عشرة", "ثلاث عشرة", "أربع عشرة", "خمس عشرة", "ست عشرة", "سبع عشرة", "ثماني عشرة", "تسع عشرة"
        };

            private static string[] arabicTens =
                new string[] {
            "عشرون", "ثلاثون", "أربعون", "خمسون", "ستون", "سبعون", "ثمانون", "تسعون"
        };

            private static string[] arabicHundreds =
                new string[] {
            "", "مائة", "مئتان", "ثلاثمائة", "أربعمائة", "خمسمائة", "ستمائة", "سبعمائة", "ثمانمائة","تسعمائة"
        };

            private static string[] arabicAppendedTwos =
                new string[] {
            "مئتا", "ألفا", "مليونا", "مليارا", "تريليونا", "كوادريليونا", "كوينتليونا", "سكستيليونا"
        };

            private static string[] arabicTwos =
                new string[] {
            "مئتان", "ألفان", "مليونان", "ملياران", "تريليونان", "كوادريليونان", "كوينتليونان", "سكستيليونان"
        };

            private static string[] arabicGroup =
                new string[] {
            "مائة", "ألف", "مليون", "مليار", "تريليون", "كوادريليون", "كوينتليون", "سكستيليون"
        };

            private static string[] arabicAppendedGroup =
                new string[] {
            "", "ألفاً", "مليوناً", "ملياراً", "تريليوناً", "كوادريليوناً", "كوينتليوناً", "سكستيليوناً"
        };

            private static string[] arabicPluralGroups =
                new string[] {
            "", "آلاف", "ملايين", "مليارات", "تريليونات", "كوادريليونات", "كوينتليونات", "سكستيليونات"
        };
            #endregion

            /// <summary>
            /// Get Feminine Status of one digit
            /// </summary>
            /// <param name="digit">The Digit to check its Feminine status</param>
            /// <param name="groupLevel">Group Level</param>
            /// <returns></returns>
            private string GetDigitFeminineStatus(int digit, int groupLevel)
            {
                if (groupLevel == -1)
                { // if it is in the decimal part
                    if (Currency.IsCurrencyPartNameFeminine)
                        return arabicFeminineOnes[digit]; // use feminine field
                    else
                        return arabicOnes[digit];
                }
                else
                    if (groupLevel == 0)
                    {
                        if (Currency.IsCurrencyNameFeminine)
                            return arabicFeminineOnes[digit];// use feminine field
                        else
                            return arabicOnes[digit];
                    }
                    else
                        return arabicOnes[digit];
            }

            /// <summary>
            /// Process a group of 3 digits
            /// </summary>
            /// <param name="groupNumber">The group number to process</param>
            /// <returns></returns>
            private string ProcessArabicGroup(int groupNumber, int groupLevel, Decimal remainingNumber)
            {
                int tens = groupNumber % 100;

                int hundreds = groupNumber / 100;

                string retVal = String.Empty;

                if (hundreds > 0)
                {
                    if (tens == 0 && hundreds == 2) // حالة المضاف
                        retVal = String.Format("{0}", arabicAppendedTwos[0]);
                    else //  الحالة العادية
                        retVal = String.Format("{0}", arabicHundreds[hundreds]);
                }

                if (tens > 0)
                {
                    if (tens < 20)
                    { // if we are processing under 20 numbers
                        if (tens == 2 && hundreds == 0 && groupLevel > 0)
                        { // This is special case for number 2 when it comes alone in the group
                            if (_intergerValue == 2000 || _intergerValue == 2000000 || _intergerValue == 2000000000 || _intergerValue == 2000000000000 || _intergerValue == 2000000000000000 || _intergerValue == 2000000000000000000)
                                retVal = String.Format("{0}", arabicAppendedTwos[groupLevel]); // في حالة الاضافة
                            else
                                retVal = String.Format("{0}", arabicTwos[groupLevel]);//  في حالة الافراد
                        }
                        else
                        { // General case
                            if (retVal != String.Empty)
                                retVal += " و ";

                            if (tens == 1 && groupLevel > 0 && hundreds == 0)
                                retVal += " ";
                            else
                                if ((tens == 1 || tens == 2) && (groupLevel == 0 || groupLevel == -1) && hundreds == 0 && remainingNumber == 0)
                                    retVal += String.Empty; // Special case for 1 and 2 numbers like: ليرة سورية و ليرتان سوريتان
                                else
                                    retVal += GetDigitFeminineStatus(tens, groupLevel);// Get Feminine status for this digit
                        }
                    }
                    else
                    {
                        int ones = tens % 10;
                        tens = (tens / 10) - 2; // 20's offset

                        if (ones > 0)
                        {
                            if (retVal != String.Empty)
                                retVal += " و ";

                            // Get Feminine status for this digit
                            retVal += GetDigitFeminineStatus(ones, groupLevel);
                        }

                        if (retVal != String.Empty)
                            retVal += " و ";

                        // Get Tens text
                        retVal += arabicTens[tens];
                    }
                }

                return retVal;
            }

            /// <summary>
            /// Convert stored number to words using selected currency
            /// </summary>
            /// <returns></returns>
            public string ConvertToArabic()
            {
                Decimal tempNumber = Number;

                if (tempNumber == 0)
                    return "صفر";

                // Get Text for the decimal part
                string decimalString = ProcessArabicGroup(_decimalValue, -1, 0);

                string retVal = String.Empty;
                Byte group = 0;
                while (tempNumber >= 1)
                {
                    // seperate number into groups
                    int numberToProcess = (int)(tempNumber % 1000);

                    tempNumber = tempNumber / 1000;

                    // convert group into its text
                    string groupDescription = ProcessArabicGroup(numberToProcess, group, Math.Floor(tempNumber));

                    if (groupDescription != String.Empty)
                    { // here we add the new converted group to the previous concatenated text
                        if (group > 0)
                        {
                            if (retVal != String.Empty)
                                retVal = String.Format("{0} {1}", "و", retVal);

                            if (numberToProcess != 2)
                            {
                                if (numberToProcess % 100 != 1)
                                {
                                    if (numberToProcess >= 3 && numberToProcess <= 10) // for numbers between 3 and 9 we use plural name
                                        retVal = String.Format("{0} {1}", arabicPluralGroups[group], retVal);
                                    else
                                    {
                                        if (retVal != String.Empty) // use appending case
                                            retVal = String.Format("{0} {1}", arabicAppendedGroup[group], retVal);
                                        else
                                            retVal = String.Format("{0} {1}", arabicGroup[group], retVal); // use normal case
                                    }
                                }
                                else
                                {
                                    retVal = String.Format("{0} {1}", arabicGroup[group], retVal); // use normal case
                                }
                            }
                        }

                        retVal = String.Format("{0} {1}", groupDescription, retVal);
                    }

                    group++;
                }

                String formattedNumber = String.Empty;
                formattedNumber += (ArabicPrefixText != String.Empty) ? String.Format("{0} ", ArabicPrefixText) : String.Empty;
                formattedNumber += (retVal != String.Empty) ? retVal : String.Empty;
                if (_intergerValue != 0)
                { // here we add currency name depending on _intergerValue : 1 ,2 , 3--->10 , 11--->99
                    int remaining100 = (int)(_intergerValue % 100);

                    if (remaining100 == 0)
                        formattedNumber += Currency.Arabic1CurrencyName;
                    else
                        if (remaining100 == 1)
                            formattedNumber += Currency.Arabic1CurrencyName;
                        else
                            if (remaining100 == 2)
                            {
                                if (_intergerValue == 2)
                                    formattedNumber += Currency.Arabic2CurrencyName;
                                else
                                    formattedNumber += Currency.Arabic1CurrencyName;
                            }
                            else
                                if (remaining100 >= 3 && remaining100 <= 10)
                                    formattedNumber += Currency.Arabic310CurrencyName;
                                else
                                    if (remaining100 >= 11 && remaining100 <= 99)
                                        formattedNumber += Currency.Arabic1199CurrencyName;
                }
                formattedNumber += (_decimalValue != 0) ? " و " : String.Empty;
                formattedNumber += (_decimalValue != 0) ? decimalString : String.Empty;
                if (_decimalValue != 0)
                { // here we add currency part name depending on _intergerValue : 1 ,2 , 3--->10 , 11--->99
                    formattedNumber += " ";

                    int remaining100 = (int)(_decimalValue % 100);

                    if (remaining100 == 0)
                        formattedNumber += Currency.Arabic1CurrencyPartName;
                    else
                        if (remaining100 == 1)
                            formattedNumber += Currency.Arabic1CurrencyPartName;
                        else
                            if (remaining100 == 2)
                                formattedNumber += Currency.Arabic2CurrencyPartName;
                            else
                                if (remaining100 >= 3 && remaining100 <= 10)
                                    formattedNumber += Currency.Arabic310CurrencyPartName;
                                else
                                    if (remaining100 >= 11 && remaining100 <= 99)
                                        formattedNumber += Currency.Arabic1199CurrencyPartName;
                }
                formattedNumber += (ArabicSuffixText != String.Empty) ? String.Format(" {0}", ArabicSuffixText) : String.Empty;

                return formattedNumber;
            }
            #endregion
        }

        public class CurrencyInfo
        {
            public enum Currencies { Egypt = 0, USA, SaudiArabia, Gold };

            #region Constructors

            public CurrencyInfo(Currencies currency)
            {
                switch (currency)
                {
                    case Currencies.Egypt:
                        CurrencyID = 0;
                        CurrencyCode = "EGP";
                        IsCurrencyNameFeminine = true;
                        EnglishCurrencyName = "Egyptian Pound";
                        EnglishPluralCurrencyName = "Egyptian Pounds";
                        EnglishCurrencyPartName = "Piaster";
                        EnglishPluralCurrencyPartName = "Piasteres";
                        Arabic1CurrencyName = "جنيها";
                        Arabic2CurrencyName = "جنيهان";
                        Arabic310CurrencyName = "جنيهات";
                        Arabic1199CurrencyName = "جنيه";
                        Arabic1CurrencyPartName = "قرش";
                        Arabic2CurrencyPartName = "قرشان";
                        Arabic310CurrencyPartName = "قروش";
                        Arabic1199CurrencyPartName = "قرشاً";
                        PartPrecision = 2;
                        IsCurrencyPartNameFeminine = false;
                        break;

                    case Currencies.USA:
                        CurrencyID = 1;
                        CurrencyCode = "Dollar";
                        IsCurrencyNameFeminine = false;
                        EnglishCurrencyName = "Dollor";
                        EnglishPluralCurrencyName = "Dollor";
                        EnglishCurrencyPartName = "Cent";
                        EnglishPluralCurrencyPartName = "Cents";
                        Arabic1CurrencyName = "دولار امريكي";
                        Arabic2CurrencyName = "دولاران امريكيان";
                        Arabic310CurrencyName = "دولارات امريكيه";
                        Arabic1199CurrencyName = "دولارا امريكيا";
                        Arabic1CurrencyPartName = "سنت";
                        Arabic2CurrencyPartName = "سنتان";
                        Arabic310CurrencyPartName = "سنت";
                        Arabic1199CurrencyPartName = "سنتا";
                        PartPrecision = 2;
                        IsCurrencyPartNameFeminine = false;
                        break;

                    case Currencies.SaudiArabia:
                        CurrencyID = 2;
                        CurrencyCode = "SAR";
                        IsCurrencyNameFeminine = false;
                        EnglishCurrencyName = "Saudi Riyal";
                        EnglishPluralCurrencyName = "Saudi Riyals";
                        EnglishCurrencyPartName = "Halala";
                        EnglishPluralCurrencyPartName = "Halalas";
                        Arabic1CurrencyName = "ريال سعودي";
                        Arabic2CurrencyName = "ريالان سعوديان";
                        Arabic310CurrencyName = "ريالات سعودية";
                        Arabic1199CurrencyName = "ريالاً سعودياً";
                        Arabic1CurrencyPartName = "هللة";
                        Arabic2CurrencyPartName = "هللتان";
                        Arabic310CurrencyPartName = "هللات";
                        Arabic1199CurrencyPartName = "هللة";
                        PartPrecision = 2;
                        IsCurrencyPartNameFeminine = true;
                        break;


                    case Currencies.Gold:
                        CurrencyID = 4;
                        CurrencyCode = "XAU";
                        IsCurrencyNameFeminine = false;
                        EnglishCurrencyName = "Gram";
                        EnglishPluralCurrencyName = "Grams";
                        EnglishCurrencyPartName = "Milligram";
                        EnglishPluralCurrencyPartName = "Milligrams";
                        Arabic1CurrencyName = "جرام";
                        Arabic2CurrencyName = "جرامان";
                        Arabic310CurrencyName = "جرامات";
                        Arabic1199CurrencyName = "جراماً";
                        Arabic1CurrencyPartName = "ملجرام";
                        Arabic2CurrencyPartName = "ملجرامان";
                        Arabic310CurrencyPartName = "ملجرامات";
                        Arabic1199CurrencyPartName = "ملجراماً";
                        PartPrecision = 2;
                        IsCurrencyPartNameFeminine = false;
                        break;

                }
            }

            #endregion

            #region Properties

            /// <summary>
            /// Currency ID
            /// </summary>
            public int CurrencyID { get; set; }

            /// <summary>
            /// Standard Code
            /// Syrian Pound: SYP
            /// UAE Dirham: AED
            /// </summary>
            public string CurrencyCode { get; set; }

            /// <summary>
            /// Is the currency name feminine ( Mua'anath مؤنث)
            /// ليرة سورية : مؤنث = true
            /// درهم : مذكر = false
            /// </summary>
            public Boolean IsCurrencyNameFeminine { get; set; }

            /// <summary>
            /// English Currency Name for single use
            /// Syrian Pound
            /// UAE Dirham
            /// </summary>
            public string EnglishCurrencyName { get; set; }

            /// <summary>
            /// English Plural Currency Name for Numbers over 1
            /// Syrian Pounds
            /// UAE Dirhams
            /// </summary>
            public string EnglishPluralCurrencyName { get; set; }

            /// <summary>
            /// Arabic Currency Name for 1 unit only
            /// ليرة سورية
            /// درهم إماراتي
            /// </summary>
            public string Arabic1CurrencyName { get; set; }

            /// <summary>
            /// Arabic Currency Name for 2 units only
            /// ليرتان سوريتان
            /// درهمان إماراتيان
            /// </summary>
            public string Arabic2CurrencyName { get; set; }

            /// <summary>
            /// Arabic Currency Name for 3 to 10 units
            /// خمس ليرات سورية
            /// خمسة دراهم إماراتية
            /// </summary>
            public string Arabic310CurrencyName { get; set; }

            /// <summary>
            /// Arabic Currency Name for 11 to 99 units
            /// خمس و سبعون ليرةً سوريةً
            /// خمسة و سبعون درهماً إماراتياً
            /// </summary>
            public string Arabic1199CurrencyName { get; set; }

            /// <summary>
            /// Decimal Part Precision
            /// for Syrian Pounds: 2 ( 1 SP = 100 parts)
            /// for Tunisian Dinars: 3 ( 1 TND = 1000 parts)
            /// </summary>
            public Byte PartPrecision { get; set; }

            /// <summary>
            /// Is the currency part name feminine ( Mua'anath مؤنث)
            /// هللة : مؤنث = true
            /// قرش : مذكر = false
            /// </summary>
            public Boolean IsCurrencyPartNameFeminine { get; set; }

            /// <summary>
            /// English Currency Part Name for single use
            /// Piaster
            /// Fils
            /// </summary>
            public string EnglishCurrencyPartName { get; set; }

            /// <summary>
            /// English Currency Part Name for Plural
            /// Piasters
            /// Fils
            /// </summary>
            public string EnglishPluralCurrencyPartName { get; set; }

            /// <summary>
            /// Arabic Currency Part Name for 1 unit only
            /// قرش
            /// هللة
            /// </summary>
            public string Arabic1CurrencyPartName { get; set; }

            /// <summary>
            /// Arabic Currency Part Name for 2 unit only
            /// قرشان
            /// هللتان
            /// </summary>
            public string Arabic2CurrencyPartName { get; set; }

            /// <summary>
            /// Arabic Currency Part Name for 3 to 10 units
            /// قروش
            /// هللات
            /// </summary>
            public string Arabic310CurrencyPartName { get; set; }

            /// <summary>
            /// Arabic Currency Part Name for 11 to 99 units
            /// قرشاً
            /// هللةً
            /// </summary>
            public string Arabic1199CurrencyPartName { get; set; }
            #endregion
        }

        private void cboCurrency_DropDownClosed(object sender, EventArgs e)
        {

        }

        private void Control_Clicks(object sender, EventArgs e)
        {
            Control control = (Control)sender;   // Sender gives you which control is clicked.
            public_label.Text = control.Text.ToString();
            //delete_label_txt.Text = control.Name.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void sell_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.F12) 
            //{

            //    //if (madfoo3TXT.Text == "")
            //    //{
            //    //    madfoo3TXT.Text = matloobTXT.Text;
            //    //    //MessageBox.Show("ادخل المبلغ المدفوع", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    //    //madfoo3TXT.Select();
            //    //    //return;
            //    //}

            //    //egmaly_kest_txt.Text = "0";

            //    //if (type_txt.Text == "تعديل")
            //    //{
            //    //    delete_sales();
            //    //    save_fatora();
            //    //}
            //    //else { save_fatora(); }



            //    //int fatora_number = Convert.ToInt32(salesID_TXT.Text);
            //    //string old_user = usertxt.Text;

            //    //ListBox l = new ListBox();
            //    //foreach (DataGridViewRow dgr in dataGridView1.Rows)
            //    //{
            //    //    if (dgr.Cells[5].Value.ToString() != "0")
            //    //    {
            //    //        try
            //    //        {
            //    //            if (l.Items.Contains(dgr.Cells[5].Value.ToString()))
            //    //            {
            //    //            }
            //    //            else
            //    //            {
            //    //                l.Items.Add(dgr.Cells[5].Value.ToString());
            //    //            }
            //    //        }
            //    //        catch { }
            //    //    }
            //    //}

            //    //l.Items.Remove("0.00");

            //    //new_fatora_type = fatora_type.Text;
            //    //DialogResult re = MessageBox.Show("هل تريد طباعة الفاتورة", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //    //if (re == DialogResult.Yes)
            //    //{



            //    //    sales_tableTableAdapter.FillBy_ID(dataSet11.sales_table, Convert.ToInt32(sales_num));

            //    //    try
            //    //    {
            //    //        crystalReport11.SetDataSource(dataSet11);
            //    //    }
            //    //    catch { crystalReport11.SetDataSource(dataSet11); }
            //    //    crystalReport11.Refresh();
            //    //    crystalReport11.PrintOptions.PrinterName = "BIXOLON SRP-350II";
            //    //    crystalReport11.PrintToPrinter(1, false, 0, 0);




            //    //    foreach (var item in l.Items)
            //    //    {
            //    //        // MessageBox.Show(item.ToString());
            //    //        try
            //    //        {

            //    //            sales_tableTableAdapter.FillBy_sales_id_and_dariba(dataSet11.sales_table, Convert.ToInt32(sales_num), Convert.ToDecimal(item.ToString()));//(;.., item.ToString());
            //    //            try
            //    //            {
            //    //                copy_of_CrystalReport11.SetDataSource(dataSet11);
            //    //            }
            //    //            catch { copy_of_CrystalReport11.SetDataSource(dataSet11); }
            //    //            copy_of_CrystalReport11.Refresh();
            //    //            copy_of_CrystalReport11.PrintOptions.PrinterName = "BIXOLON SRP-350II";
            //    //            copy_of_CrystalReport11.PrintToPrinter(1, false, 0, 0);

            //    //        }
            //    //        catch { }
            //    //    }


            //    //    //this.Controls.Clear();
            //    //    ////sell s = new sell();
            //    //    ////foreach (Control x in this.Controls) 
            //    //    ////{
            //    //    ////    x
            //    //    ////}
            //    //    //InitializeComponent();
            //    //    //this.dateTimePicker1.Value = DateTime.Today;
            //    //    //this.WindowState = FormWindowState.Normal;
            //    //    //this.WindowState = FormWindowState.Maximized;
            //    //    //sales_print sfp = new sales_print();
            //    //    //sfp.Text = "طباعة فاتورة";
            //    //    //sfp.textBox1.Text = sales_num;
            //    //    ////sales number
            //    //    //sfp.ShowDialog();
            //    //    //sell_Load(sender, e);


            //    //    this.Controls.Clear();
            //    //    InitializeComponent();
            //    //    this.dateTimePicker1.Value = DateTime.Today;
            //    //    this.WindowState = FormWindowState.Normal;
            //    //    this.WindowState = FormWindowState.Maximized;
            //    //    sell_Load(sender, e);
            //    //    try
            //    //    {
            //    //        this.numbers_tableTableAdapter1.Fill(this.dataSet11.Numbers_table);
            //    //        salesID_TXT.Text = dataSet11.Numbers_table.Rows[0]["sales_ID"].ToString();
            //    //    }
            //    //    catch { }
                  

            //    //}
            //    //else 
            //    //{
            //    //    this.Controls.Clear();
            //    //    InitializeComponent();
            //    //    this.dateTimePicker1.Value = DateTime.Today;
            //    //    this.WindowState = FormWindowState.Normal;
            //    //    this.WindowState = FormWindowState.Maximized;
            //    //    sell_Load(sender, e);
            //    //    try
            //    //    {
            //    //        this.numbers_tableTableAdapter1.Fill(this.dataSet11.Numbers_table);
            //    //        salesID_TXT.Text = dataSet11.Numbers_table.Rows[0]["sales_ID"].ToString();
            //    //    }
            //    //    catch { }
                    
            //    //}
            //    //madfoo3TXT.Text = "";
               
            //    //fatora_type.Text = new_fatora_type;
            //    //return;

              
            //    savebtn_Click(sender, e);
               
            //}


            if  (e.KeyCode == Keys.F9)
            {
                dataGridView1.Rows.Clear();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            savebtn_Click(sender, e);
        }

        decimal last_discount;
        private void discountTXT_Leave(object sender, EventArgs e)
        {
            //try
            //{

            //    last_discount = Convert.ToDecimal(discountTXT.Text);

            //    //  decimal _1st_discount = first_discount / Convert.ToDecimal(dataGridView1.Rows.Count);

            //    decimal _last_discount = last_discount / Convert.ToDecimal(dataGridView1.Rows.Count);

            //    foreach (DataGridViewRow dgr in dataGridView1.Rows)
            //    {
            //        dgr.Cells[3].Value = Convert.ToDecimal(dgr.Cells[3].Value) - (_last_discount / Convert.ToDecimal(dgr.Cells[2].Value));
            //    }


            //}
            //catch { }
        }

        private void discountTXT_Enter(object sender, EventArgs e)
        {
            //try
            //{
               
            //    foreach (DataGridViewRow dgr in dataGridView1.Rows)
            //    {
            //        products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, dgr.Cells[1].Value.ToString());
            //        // raseed_now_txt.Text = dataSet11.products_table.Rows[0]["pro_count"].ToString();
            //        if (fatora_type.Text == "قطاعي")
            //        {
            //            dgr.Cells[3].Value =(Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_bee3_2"])/Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_pieces_in_packet"])).ToString();
            //        }
            //        else if (fatora_type.Text == "جمله")
            //        {
            //           dgr.Cells[3].Value = dataSet11.products_table.Rows[0]["pro_bee3"].ToString();
            //        }
            //        else if (fatora_type.Text == "جملة الجمله")
            //        {
            //           dgr.Cells[3].Value =  dataSet11.products_table.Rows[0]["pro_gomla_gomla"].ToString();
            //        }
            //    }

            //    discountTXT.Text = "0";
            //    discountTXT.Focus();
            //    discountTXT.SelectAll();




            //}
            //catch { }
        }

        private void cst_nameTXT_Leave(object sender, EventArgs e)
        {
            try
            {
                madeen_tableTableAdapter1.FillBy_by_madeen(dataSet11.madeen_table, cst_nameTXT.Text);
                 hesab_sab2_txt.Text = dataSet11.madeen_small_report.Rows[0]["madeen_small_ba2y"].ToString();

            }
            catch
            {
                try
                {
                  
                    madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet11.madeen_small_report, cst_nameTXT.Text);
                    hesab_sab2_txt.Text = dataSet11.madeen_small_report.Rows[0]["madeen_small_ba2y"].ToString();

                }
                catch
                {

                    notesTXT.Text = "";
                   
                    hesab_sab2_txt.Text = "";


                }
            }
        }


       
        
       
        }
    }

