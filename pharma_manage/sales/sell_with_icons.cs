using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Drawing.Drawing2D;

namespace pharma_manage
{
    public partial class sell_with_icons: Form
    {
        public sell_with_icons()
        {
            InitializeComponent();

            cst_code.KeyPress += DigitOnly_KeyPress;
            max_limit_txt.KeyPress += DigitOnly_KeyPress;
          //  tas3eer_id_txt.KeyPress += DigitOnly_KeyPress;
            discountTXT.KeyPress += DigitOnly_KeyPress;
            nesba_discount_txt.KeyPress += DigitOnly_KeyPress;
            bonus_txt.KeyPress += DigitOnly_KeyPress;
            countTXT.KeyPress += DigitOnly_KeyPress;
            madfoo3TXT.KeyPress += DigitOnly_KeyPress;
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
                    if (dgr.Cells[1].Value.ToString() != "")
                    {
                        dgr.Cells[3].Value = kest_cost.ToString();
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
            if (type_txt.Text != "تعديل" && dates_ed == "no")
            {
                try
                {
                    check_date(dateTimePicker1, notesTXT);//dateTimePicker1.Value = DateTime.Today;
                }
                catch { }
            }
            //try
            //{
            //    dateTimePicker1.Value = DateTime.Today;
            //}
            //catch { }

            try
            {
                label29.Text = dataGridView1.Rows.Count.ToString();


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
                if (type_txt.Text != "تعديل")
                {
                    this.numbers_tableTableAdapter1.FillBy_stock(this.dataSet11.Numbers_table, far3txt.Text);
                    salesID_TXT.Text = dataSet11.Numbers_table.Rows[0]["sales_ID"].ToString();
                    try
                    {
                        day_numbersTableAdapter1.FillBy_date(dataSet11.day_numbers, dateTimePicker1.Value.ToShortDateString());
                        if (dataSet11.day_numbers.Rows.Count > 0)
                        {
                            day_num_txt.Text = dataSet11.day_numbers.Rows[0]["day_num"].ToString();
                        }
                        else
                        {
                            day_numbersTableAdapter1.Insert(dateTimePicker1.Value, 1);
                        }
                    }
                    catch { }
                }
            }
            catch { }
            decimal sum = 0;
            decimal sum_items = 0;
            decimal sum_dariba = 0;

            try
            {
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    dataGridView1.Rows[i].Cells[6].Value = (Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value) * Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value)) + ((Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value) * Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value)) * Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value));
                    sum_dariba += Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value) * (Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value) * Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value));
                    sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value) * Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
                    sum_items += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
                }
                egmaly_dariba_txt.Text = sum_dariba.ToString();
                egmaly_se3r_txt.Text = sum.ToString("0.00");

                decimal egmaly_after = sum + sum_dariba;
                egmalyTXT.Text = egmaly_after.ToString("0.00"); ;
                items_count_txt.Text = sum_items.ToString();

            }
            catch { }


            decimal sum_aksat = 0;

            try
            {
                for (int i = 0; i < dataGridView2.Rows.Count; ++i)
                {
                    sum_aksat += Convert.ToDecimal(dataGridView2.Rows[i].Cells[3].Value);
                }
                //  motbaky_txt.Text = real_sum.ToString();

                if (hesab_sab2_txt.Text == "")
                {
                    hesab_sab2_txt.Text = "0";
                }
                decimal real_sum = (Convert.ToDecimal(hesab_sab2_txt.Text) + -Convert.ToDecimal(ba2y_txt.Text)) - sum_aksat;
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


            try
            {
                egmaly_7esab_txt.Text = ((Convert.ToDecimal(hesab_sab2_txt.Text) + Convert.ToDecimal(matloobTXT.Text)) - Convert.ToDecimal(madfoo3TXT.Text)).ToString();
            }
            catch
            {
                egmaly_7esab_txt.Text = ((Convert.ToDecimal(hesab_sab2_txt.Text) + Convert.ToDecimal(matloobTXT.Text))).ToString();

            }

        }
        private void suggest_product()
        {
            try
            {
                this.products_tableTableAdapter1.FillBy_stock_and_not_5amat(this.dataSet11.products_table, far3txt.Text);
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

        private void read_mandoob()
        {
            int counter = 0;
            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file = new System.IO.StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\المندوبين.txt", Encoding.Default, true);
            //  MessageBox.Show(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\المندوبين.txt");
            while ((line = file.ReadLine()) != null)
            {
                mandoob_txt.Items.Add(line);
                counter++;
            }

            file.Close();
        }
        string dates_ed = "";
        private void sell_Load(object sender, EventArgs e)
        {
            

        }


        private void buttton_Click(object sender, EventArgs e)
        {
            Control_Clicks_for_category(sender, e);
            products_tableTableAdapter1.FillBy_category_and_far3(dataSet11.products_table, public_label.Text,far3txt.Text);
            flowLayoutPanel2.Controls.Clear();
            foreach (DataRow DRow in dataSet11.products_table.Rows)
            {
                //try
                //{

              
                    Button pro_button = new Button();

                    pro_button.Text = DRow["pro_name"].ToString() + Environment.NewLine + "( "+DRow["pro_count"].ToString()+" )";
                    pro_button.Name = DRow["pro_name"].ToString();
                    try
                    {
                        pro_button.Image = Image.FromFile(DRow["pro_mwared"].ToString());
                        pro_button.TextImageRelation = TextImageRelation.ImageAboveText;
                        pro_button.TextAlign = ContentAlignment.BottomCenter;
                    }
                    catch { }
                    pro_button.Width = 110;
                    pro_button.Height = 50;

                    GraphicsPath path = new GraphicsPath();
                    int cornerRadius = 4;
                    int borderWidth = 1;
                    Rectangle panelBounds = new Rectangle(borderWidth, borderWidth, pro_button.Width - 3 * borderWidth, pro_button.Height - 3 * borderWidth);
                    path.AddArc(panelBounds.Left, panelBounds.Top, cornerRadius, cornerRadius, 180, 90);
                    path.AddArc(panelBounds.Right - cornerRadius, panelBounds.Top, cornerRadius, cornerRadius, 270, 90);
                    path.AddArc(panelBounds.Right - cornerRadius, panelBounds.Bottom - cornerRadius, cornerRadius, cornerRadius, 0, 90);
                    path.AddArc(panelBounds.Left, panelBounds.Bottom - cornerRadius, cornerRadius, cornerRadius, 90, 90);
                    path.CloseFigure();
                    pro_button.Region = new Region(path);

                    pro_button.MouseDown += new MouseEventHandler(pro_buttton_Click);
                    pro_button.FlatStyle = FlatStyle.Flat;
                    mo3adalat_tasnee3_tableTableAdapter1.FillBy_pro_name(dataSet11.mo3adalat_tasnee3_table, DRow["pro_name"].ToString());
                  //  MessageBox.Show(dataSet11.mo3adalat_tasnee3_table.Rows.Count.ToString());
                    if (dataSet11.mo3adalat_tasnee3_table.Rows.Count <= 0)
                    {
                      //  MessageBox.Show(DRow["pro_count"].ToString());
                        if (Convert.ToDecimal(DRow["pro_count"]) <= 0)
                        {
                            pro_button.BackColor = Color.Red;
                        }
                        else if (Convert.ToDecimal(DRow["pro_count"]) < 1)
                        {
                            pro_button.BackColor = Color.Salmon;
                        }
                        else
                        {
                            pro_button.BackColor = Color.WhiteSmoke;
                        }
                    }
                    else
                    {
                        pro_button.BackColor = Color.WhiteSmoke;
                    }
                    
                    pro_button.ForeColor = Color.Black;
                    pro_button.Font = new Font("Tahoma", 8, FontStyle.Bold);
                    pro_button.TextAlign = ContentAlignment.MiddleCenter;
                    pro_button.Margin = new System.Windows.Forms.Padding(0);
                    // pro_button.BackColor = System.Drawing.Color.Green;
                    pro_button.FlatAppearance.BorderColor = Color.FromName(flowLayoutPanel2.BackColor.Name);// System.Drawing.Color.Brown;
                    //  .FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
                    // pro_button.FlatAppearance.BorderSize = 1;
                  //  pro_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    // pro_button.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    // pro_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                    // buttton.Size = new System.Drawing.Size(114, 23);
                    pro_button.UseVisualStyleBackColor = false;
                    pro_button.Cursor = Cursors.Hand;
                    //  buttton.DragOver += new DragEventHandler(button_DragOver);
                    // button.FlatAppearance.BorderColor

                    //pro_button.AutoSize = true;

                    this.flowLayoutPanel2.Controls.Add(pro_button);
                    // pro_button = new System.Windows.Forms.Button();


                //}
                //catch { }
            }
        }



        private void pro_buttton_Click(object sender, MouseEventArgs  e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Left mouse button clicked
                // Your code for left button click here
                countTXT.Text = "1";
              //  MessageBox.Show("left");
            }
            else if (e.Button == MouseButtons.Right)
            {

                using (awzan_form p = new awzan_form())
                {
                    //   pro_suggest_for_sell p = new pro_suggest_for_sell();
                   // p.product_nameTXT.Text = product_nameTXT.Text;
                 //   p.stock_txt.Text = far3txt.Text;
                    //if (countTXT.Text == "")
                    //{
                    //    p.count_label.Text = "0";
                    //}
                    //else
                    //{
                    //    p.count_label.Text = countTXT.Text;
                    //}
                    p.ShowDialog();
                    string r = p.Result_count;
                      countTXT.Text = r;
                }
              
               // // Right mouse button clicked
               // // Your code for right button click here
               // countTXT.Text = "0.5";
               //// MessageBox.Show("Right");
            }

            Control_Clicks(sender, e);
            product_nameTXT.Text = public_label.Text;
            addbtn_Click(sender, e);


            //Control_Clicks(sender, e);
            //product_nameTXT.Text = public_label.Text;


            //addbtn_Click(sender, e);

            //for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            //{
            //    if (dataGridView1.Rows[i].Cells[2].Value.ToString() == public_label.Text)
            //    {

            //        decimal count_in = Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value) + 1;
            //        //  string category_name = "";
            //        products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, dataGridView1.Rows[i].Cells[2].Value.ToString(), far3txt.Text);

            //        //try
            //        //{
            //        //    category_name = dataSet11.products_table.Rows[0]["pro_category"].ToString();
            //        //}
            //        //catch { }
            //        //categoryTableAdapter1.FillBy_name(dataSet11.Category, category_name);

            //        decimal count = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);

            //        if (count_in <= count)
            //        {

            //            dataGridView1.Rows[i].Cells[3].Value = count_in.ToString();

            //            product_nameTXT.Clear();
            //            product_nameTXT.Focus();

            //            return;
            //        }
            //        else
            //        {
            //            MessageBox.Show("الكمية غير متاحه في المخزن", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //            return;
            //        }

            //    }
            //}
            //products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, public_label.Text, far3txt.Text);
            ////double dariba2 = 0; ;
            //string pro_code = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
            //string pro_name = dataSet11.products_table.Rows[0]["pro_name"].ToString();
            //string unit_price = "";


            //unit_price = dataSet11.products_table.Rows[0]["pro_bee3"].ToString();


            //string category_name1 = dataSet11.products_table.Rows[0]["pro_category"].ToString();
            //// string stock_name = dataSet11.products_table.Rows[0]["pro_stock"].ToString();
            //string pro_count = dataSet11.products_table.Rows[0]["pro_count"].ToString();

            
            //if (Convert.ToDecimal(pro_count) >= 1)
            //{

            //    dataGridView1.Rows.Add((dataGridView1.Rows.Count + 1).ToString(), pro_code, pro_name, 1, unit_price, "", category_name1);
            //}
            //else
            //{
            //    MessageBox.Show("الكمية غير متاحه في المخزن", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    return;
            //}
            //if (dataGridView1.Columns.Count == 7)
            //{
            //    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

            //    btn.Width = 100;
            //    btn.Text = "حذف";
            //    btn.Name = product_nameTXT.Text;
            //    btn.UseColumnTextForButtonValue = true;


            //    dataGridView1.Columns.Add(btn);
            //}
            //dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1;



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






        // dataGridView1.Rows.Add((dataGridView1.Rows.Count + 1).ToString(), 
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
            AutoCompleteStringCollection DataCollection2 = new AutoCompleteStringCollection();
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
                customersTableAdapter1.Insert(cst_nameTXT.Text, cst_phoneTXT.Text, cst_addressTXT.Text, cst_notes_txt.Text, max_limit_txt.Text, "", "", "");
            }
            else
            {
                int id = Convert.ToInt32(dataSet11.customers.Rows[0]["cst_ID"]);
                customersTableAdapter1.Update_cst_by_id(cst_nameTXT.Text, cst_phoneTXT.Text, cst_addressTXT.Text, cst_notes_txt.Text, max_limit_txt.Text, id);
            }


        }
        private void check_mandoob()
        {
            try
            {
                if (mandoob_txt.Text != "")
                {
                    resp_tableTableAdapter1.FillBy_name(dataSet11.resp_table, mandoob_txt.Text);
                    if (dataSet11.resp_table.Rows.Count <= 0)
                    {
                        decimal bonus = 0;
                        if (bonus_txt.Text != "")
                        {
                            bonus = Convert.ToDecimal(bonus_txt.Text);
                        }
                        else
                        {
                            bonus = 0;
                        }
                        resp_tableTableAdapter1.Insert(mandoob_txt.Text, resp_phone_txt.Text, "", bonus, "", 0, 0);
                    }
                    else
                    {
                        //int id = Convert.ToInt32(dataSet11.customers.Rows[0]["cst_ID"]);
                        //customersTableAdapter1.Update_cst_by_id(cst_nameTXT.Text, cst_phoneTXT.Text, cst_addressTXT.Text, cst_notes_txt.Text, max_limit_txt.Text, id);
                    }
                }
            }
            catch { }
        }
        private void delete_sales()
        {
            //try
            //{
            //delete ma5zoon
            ma5zoon_movesTableAdapter1.Delete_by_fatora_ID(Convert.ToInt32(salesID_TXT.Text));

            //update products
            sales_tableTableAdapter1.FillBy_ID_stock(dataSet11.sales_table, Convert.ToInt32(salesID_TXT.Text),far3txt.Text);

            foreach (DataRow dgr in dataSet11.sales_table.Rows)
            {
                products_tableTableAdapter1.Update_count_BY_ID_buy(Convert.ToDecimal(dgr["sales_product_count"]), Convert.ToDecimal(dgr["sales_product_count"]), dgr["sales_product_ID"].ToString(), far3txt.Text);
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
            income_tableTableAdapter1.FillBy_fatora_id(dataSet11.income_table, Convert.ToInt32(salesID_TXT.Text),far3txt.Text);
            foreach (DataRow dr in dataSet11.income_table.Rows)
            {
                all_income += Convert.ToDecimal(dr["income_cost"]);
            }
            safeTableAdapter1.Update_sarf_from_safe(all_income);
            safeTableAdapter1.Insert_safe(dateTimePicker1.Value.ToShortDateString(), -all_income);

            //delete from arba7
            arba7_tableTableAdapter1.Delete_fatora_id_stock(Convert.ToInt32(salesID_TXT.Text),far3txt.Text);

            //delete from income
            string income_details = "مبلغ من فاتورة بيع رقم " + salesID_TXT.Text;

            sales_mortaga3TableAdapter1.Delete_by_fatora_id(Convert.ToInt32(salesID_TXT.Text));
            income_tableTableAdapter1.Delete_by_fatora(Convert.ToInt32(salesID_TXT.Text),far3txt.Text);
            saydaly_nesbaTableAdapter1.Delete_by_fatora_id(Convert.ToInt32(salesID_TXT.Text));
            // }
            //catch
            //{
            //    MessageBox.Show("تأكد من ادخال البيانات بطريقة صحيحه");
            //    return;
            //}

        }

        string new_fatora_type = "";

        private void savebtn_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count <= 0)
            {
                MessageBox.Show("الفاتورة فارغه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
                string id = dgr.Cells[2].Value.ToString();
                products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, id, far3txt.Text);
                decimal pro_count;
                if (dataSet11.products_table.Count <= 0)
                {
                    MessageBox.Show("بيانات الصنف " + dgr.Cells[2].Value.ToString() + " خاطئة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }


                pro_count = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);
                if (pro_count <= 0)
                {
                    mo3adalat_tasnee3_tableTableAdapter1.FillBy_pro_name(dataSet11.mo3adalat_tasnee3_table, id);
                    if (dataSet11.mo3adalat_tasnee3_table.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dataSet11.mo3adalat_tasnee3_table.Rows)
                        {
                            string material_name = dr["mo3adalat_tasnee3_material_name"].ToString();
                            products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, material_name, far3txt.Text);

                            if (dataSet11.products_table.Rows.Count <= 0)
                            {
                                MessageBox.Show("الصنف " + material_name + " غير موجود في الفرع " + far3txt.Text, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                return;
                            }

                            decimal pro_count_in_mo3adalt = Convert.ToDecimal(dr["mo3adalat_tasnee3_material_count"]);
                            decimal material_pro_count = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);

                            if (material_pro_count <= 0)
                            {
                                // Perform a recursive check for the material's components
                                mo3adalat_tasnee3_tableTableAdapter1.FillBy_pro_name(dataSet12.mo3adalat_tasnee3_table, material_name);
                                if (dataSet12.mo3adalat_tasnee3_table.Rows.Count > 0)
                                {
                                    foreach (DataRow dr2 in dataSet12.mo3adalat_tasnee3_table.Rows)
                                    {
                                        string sub_material_name = dr2["mo3adalat_tasnee3_material_name"].ToString();
                                        products_tableTableAdapter1.FillBy_name_and_far3(dataSet12.products_table, sub_material_name, far3txt.Text);

                                        if (dataSet12.products_table.Rows.Count <= 0)
                                        {
                                            MessageBox.Show("الصنف " + sub_material_name + " غير موجود في الفرع " + far3txt.Text, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                            return;
                                        }

                                        decimal sub_material_count = Convert.ToDecimal(dataSet12.products_table.Rows[0]["pro_count"]);
                                        decimal sub_material_required = Convert.ToDecimal(dr2["mo3adalat_tasnee3_material_count"]) * Convert.ToDecimal(dgr.Cells[3].Value);

                                        if (sub_material_required > sub_material_count)
                                        {
                                            MessageBox.Show("الكمية من " + sub_material_name + " الخاصة بالصنف " + id + " غير متاحه في " + far3txt.Text + "  برجاء اضافة الكمية الصحيحة  ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                            return;
                                        }
                                    }
                                }
                            }
                            else if ((Convert.ToDecimal(dgr.Cells[3].Value) * pro_count_in_mo3adalt) > material_pro_count)
                            {
                                MessageBox.Show("الكمية من " + material_name + " الخاصة بالصنف " + id + " غير متاحه في " + far3txt.Text + "  برجاء اضافة الكمية الصحيحة  ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                return;
                            }
                        }
                    }
                    else
                    {
                        if (Convert.ToDecimal(dgr.Cells[3].Value) > pro_count)
                        {
                            dgr.Selected = true;
                            MessageBox.Show("الكمية " + id.ToString() + " غير متاحه في المخزن  برجاء اضافة الكمية الصحيحة  ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }
                    }
                }


            }


            try
            {
                if ((Convert.ToDecimal(madfoo3TXT.Text) < Convert.ToDecimal(matloobTXT.Text)) && cst_nameTXT.Text == "")
                {
                    MessageBox.Show("ادخل اسم العميل");
                    cst_nameTXT.SelectAll();
                    cst_nameTXT.Focus();
                    return;
                }
                if ((Convert.ToDecimal(madfoo3TXT.Text) < Convert.ToDecimal(matloobTXT.Text)) && cst_nameTXT.Text == "نقدي")
                {
                    cst_nameTXT.SelectAll();
                    cst_nameTXT.Focus();
                    MessageBox.Show("ادخل اسم العميل");
                    return;
                }

            }
            catch { }

            if (max_limit_txt.Text != "")
            {
                if (Convert.ToDecimal(egmaly_7esab_txt.Text) > Convert.ToDecimal(max_limit_txt.Text))
                {
                    decimal max_avail = Convert.ToDecimal(max_limit_txt.Text) - Convert.ToDecimal(hesab_sab2_txt.Text);
                    MessageBox.Show(" اقصى ملبغ متاح لهذا العميل" + max_avail.ToString(), "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }
            if (madfoo3TXT.Text == "")
            {
                madfoo3TXT.Text = matloobTXT.Text;
                //MessageBox.Show("ادخل المبلغ المدفوع", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //madfoo3TXT.Select();
                //return;
            }



            //if (mandoob_txt.Text == "")
            //{

            //    MessageBox.Show("ادخل اسم المندوب ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    mandoob_txt.Select();
            //    return;
            //}


            egmaly_kest_txt.Text = "0";



            try
            {
                if (type_txt.Text != "تعديل")
                {
                    this.numbers_tableTableAdapter1.FillBy_stock(this.dataSet11.Numbers_table, far3txt.Text);
                    salesID_TXT.Text = dataSet11.Numbers_table.Rows[0]["sales_ID"].ToString();

                    try
                    {
                        day_numbersTableAdapter1.FillBy_date(dataSet11.day_numbers, dateTimePicker1.Value.ToShortDateString());
                        if (dataSet11.day_numbers.Rows.Count > 0)
                        {
                            day_num_txt.Text = dataSet11.day_numbers.Rows[0]["day_num"].ToString();
                        }
                        else
                        {
                            day_numbersTableAdapter1.Insert(dateTimePicker1.Value, 1);
                        }
                    }
                    catch { }
                }
            }
            catch { }

            int fatora_number = Convert.ToInt32(sales_num);
            string old_user = usertxt.Text;






            if ((Convert.ToDecimal(madfoo3TXT.Text) < Convert.ToDecimal(matloobTXT.Text)) && cst_nameTXT.Text == "")
            {
                MessageBox.Show("ادخل اسم العميل");
                cst_nameTXT.SelectAll();
                cst_nameTXT.Focus();
                return;
            }
            if ((Convert.ToDecimal(madfoo3TXT.Text) < Convert.ToDecimal(matloobTXT.Text)) && cst_nameTXT.Text == "نقدي")
            {
                MessageBox.Show("ادخل اسم العميل");
                cst_nameTXT.SelectAll();
                cst_nameTXT.Focus();
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
            s.type_txt.Text = "بيع";
            // s.fatora_type_txt.Text = fatora_type_txt.Text;
            s.cst_name_txt.Text = cst_nameTXT.Text;
            s.far3txt.Text = far3txt.Text;
            s.listBox1.Items.Clear();
            string ezn_type = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\ezn_type.txt").First();


            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
                if (ezn_type == "الفئة")
                {
                    if (s.listBox1.Items.Contains(dgr.Cells[7].Value.ToString()))
                    {
                    }
                    else
                    {
                        s.listBox1.Items.Add(dgr.Cells[7].Value.ToString());
                    }
                }
                else if (ezn_type == "الفرع")
                {
                    if (s.listBox1.Items.Contains(far3txt.Text))
                    {
                    }
                    else
                    {
                        s.listBox1.Items.Add(far3txt.Text);
                    }
                }
            }


            s.ShowDialog();



            try
            {
                if (type_txt.Text != "تعديل")
                {
                    this.numbers_tableTableAdapter1.FillBy_stock(this.dataSet11.Numbers_table, far3txt.Text);
                    salesID_TXT.Text = dataSet11.Numbers_table.Rows[0]["sales_ID"].ToString();

                    try
                    {
                        day_numbersTableAdapter1.FillBy_date(dataSet11.day_numbers, dateTimePicker1.Value.ToShortDateString());
                        if (dataSet11.day_numbers.Rows.Count > 0)
                        {
                            day_num_txt.Text = dataSet11.day_numbers.Rows[0]["day_num"].ToString();
                        }
                        else
                        {
                            day_numbersTableAdapter1.Insert(dateTimePicker1.Value, 1);
                        }
                    }
                    catch { }
                }
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
            hesab_sab2_txt.Text = "0";
            //tas3eer_id_txt.Text = "";
            //tas3eer_id_txt.Enabled = false;
            cst_nameTXT_TextChanged(sender, e);

            check_date(dateTimePicker1, notesTXT);// dateTimePicker1.Value = DateTime.Today;
            notesTXT.Text = "";
            mandoob_txt.Text = "";
            resp_phone_txt.Text = "";
            bonus_txt.Text = "";

            mandoob_txt.Items.Clear();
            this.resp_tableTableAdapter1.Fill(this.dataSet11.resp_table);
            foreach (DataRow dr in dataSet11.resp_table.Rows)
            {
                mandoob_txt.Items.Add(dr["resp_name"].ToString());
            }

            cst_nameTXT.Focus();
            cst_nameTXT.SelectAll();
           
        }

        string sales_num;
        private void save_fatora()
        {

            //madeen_tableTableAdapter1.FillBy_by_madeen(dataSet11.madeen_table, cst_nameTXT.Text);
            //MessageBox.Show(dataSet11.madeen_table.Rows[1]["madden_matloob"].ToString());
            //MessageBox.Show(dataSet11.madeen_table.Rows[1]["madden_madfoo3"].ToString());

            try
            {
                if (type_txt.Text != "تعديل")
                {
                    this.numbers_tableTableAdapter1.FillBy_stock(this.dataSet11.Numbers_table, far3txt.Text);
                    salesID_TXT.Text = dataSet11.Numbers_table.Rows[0]["sales_ID"].ToString();

                    try
                    {
                        day_numbersTableAdapter1.FillBy_date(dataSet11.day_numbers, dateTimePicker1.Value.ToShortDateString());
                        if (dataSet11.day_numbers.Rows.Count > 0)
                        {
                            day_num_txt.Text = dataSet11.day_numbers.Rows[0]["day_num"].ToString();
                        }
                        else
                        {
                            day_numbersTableAdapter1.Insert(dateTimePicker1.Value, 1);
                        }
                    }
                    catch { }
                }
                sales_num = salesID_TXT.Text;
            }
            catch { }

            //check if customer exist
            check_customer();
            check_mandoob();
            //if (madfoo3TXT.Text == "")
            //{
            //    MessageBox.Show("ادخل المبلغ المدفوع", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    madfoo3TXT.Select();
            //    return;
            //}

            //if (Convert.ToDecimal(madfoo3TXT.Text) < Convert.ToDecimal(matloobTXT.Text))
            //{


            //madeen 
            madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet11.madeen_small_report, cst_nameTXT.Text);
            //madeen_tableTableAdapter1.FillBy_by_madeen(dataSet11.madeen_table, cst_nameTXT.Text);

            decimal old_7esab = 0;
            decimal ba2y_el7esab = 0;
            if (dataSet11.madeen_small_report.Rows.Count > 0)
            {
                //if madeen exist
                // شوف هنعمل ايه هنا


                // MessageBox.Show("111111");
                old_7esab = Convert.ToDecimal(dataSet11.madeen_small_report.Rows[0]["madeen_small_ba2y"]);

                decimal far2_madfoo3_akbar = Convert.ToDecimal(madfoo3TXT.Text) - Convert.ToDecimal(matloobTXT.Text);
                if (Convert.ToDecimal(madfoo3TXT.Text) <= Convert.ToDecimal(matloobTXT.Text))
                {
                    // MessageBox.Show("1");
                    //madeen small report update
                    madeen_small_reportTableAdapter1.Update_matloob_AND_madfoo3_by_name(Convert.ToDecimal(matloobTXT.Text), Convert.ToDecimal(madfoo3TXT.Text), cst_nameTXT.Text);
                    madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet11.madeen_small_report, cst_nameTXT.Text);
                    decimal new_matloob = Convert.ToDecimal(dataSet11.madeen_small_report.Rows[0]["madeen_small_matloob"]);
                    decimal new_madfoo3 = Convert.ToDecimal(dataSet11.madeen_small_report.Rows[0]["madeen_small_madfoo3"]);

                    ba2y_el7esab = Convert.ToDecimal(dataSet11.madeen_small_report.Rows[0]["madeen_small_ba2y"]);

                    //madeen details insert

                    mosta7akat_tableTableAdapter1.Insert(cst_nameTXT.Text, dateTimePicker1.Value, new_matloob, new_madfoo3, Convert.ToDecimal(matloobTXT.Text), Convert.ToDecimal(madfoo3TXT.Text), usertxt.Text
                        , old_7esab, ba2y_el7esab, "مسدد فاتورة رقم " + salesID_TXT.Text, "مدين", Convert.ToInt32(salesID_TXT.Text));
                }
                else if (Convert.ToDecimal(madfoo3TXT.Text) > Convert.ToDecimal(matloobTXT.Text) && old_7esab >= far2_madfoo3_akbar)
                {

                    //  MessageBox.Show("2");
                    //madeen small report update
                    madeen_small_reportTableAdapter1.Update_matloob_AND_madfoo3_by_name(0, far2_madfoo3_akbar, cst_nameTXT.Text);
                    madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet11.madeen_small_report, cst_nameTXT.Text);
                    decimal new_matloob = Convert.ToDecimal(dataSet11.madeen_small_report.Rows[0]["madeen_small_matloob"]);
                    decimal new_madfoo3 = Convert.ToDecimal(dataSet11.madeen_small_report.Rows[0]["madeen_small_madfoo3"]);

                    ba2y_el7esab = Convert.ToDecimal(dataSet11.madeen_small_report.Rows[0]["madeen_small_ba2y"]);

                    //madeen details insert

                    mosta7akat_tableTableAdapter1.Insert(cst_nameTXT.Text, dateTimePicker1.Value, new_matloob, new_madfoo3, Convert.ToDecimal(matloobTXT.Text), far2_madfoo3_akbar, usertxt.Text
                       , old_7esab, new_matloob - new_madfoo3, "تنزيل من الحساب مع فاتورة رقم " + salesID_TXT.Text, "دائن", Convert.ToInt32(salesID_TXT.Text));


                    //   income
                    string income_details1 = "تنزيل من الحساب مع فاتورة رقم " + salesID_TXT.Text;
                    decimal income_cost1 = 0;
                    string source1 = "";

                    income_cost1 = Convert.ToDecimal(far2_madfoo3_akbar);
                    source1 = "دفعات مدينين";
                    safeTableAdapter1.Update_add_to_safe(income_cost1);


                    //safe status daily
                    safeTableAdapter1.Insert_safe(dateTimePicker1.Value.ToShortDateString(), income_cost1);




                    income_tableTableAdapter1.Insert_income(dateTimePicker1.Value.ToShortDateString(), income_details1, income_cost1, Convert.ToInt32(salesID_TXT.Text), source1, cst_nameTXT.Text, usertxt.Text, "  " + "", far3txt.Text, 0);

                    //madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet11.madeen_small_report, cst_nameTXT.Text);
                    //hesab_sab2_txt.Text = dataSet11.madeen_small_report.Rows[0]["madeen_small_ba2y"].ToString();

                }


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
                    // string madeen_byan = "مدفوع وقت الفاتورة " + salesID_TXT.Text;
                    // madeen_tableTableAdapter1.Insert_madeen_details(dateTimePicker1.Value.ToShortDateString(), cst_nameTXT.Text, madeen_byan, Convert.ToDecimal(matloobTXT.Text), Convert.ToDecimal(madfoo3TXT.Text), notesTXT.Text, usertxt.Text, ""
                    //, Convert.ToDecimal(matloobTXT.Text), Convert.ToDecimal(madfoo3TXT.Text), Convert.ToInt32(salesID_TXT.Text), 1, dateTimePicker1.Value.ToShortDateString(), Convert.ToDecimal(madfoo3TXT.Text), "paid", dateTimePicker1.Value.ToShortDateString(), "");

                    mosta7akat_tableTableAdapter1.Insert(cst_nameTXT.Text, dateTimePicker1.Value, Convert.ToDecimal(matloobTXT.Text), Convert.ToDecimal(madfoo3TXT.Text), Convert.ToDecimal(matloobTXT.Text), Convert.ToDecimal(madfoo3TXT.Text), usertxt.Text
                  , old_7esab, ba2y_el7esab, "مسدد فاتورة رقم " + salesID_TXT.Text, "مدين", Convert.ToInt32(salesID_TXT.Text));

                    //madeen_tableTableAdapter1.Insert_madeen_details(dateTimePicker1.Value.ToShortDateString(), cst_nameTXT.Text, "", Convert.ToDecimal(matloobTXT.Text), Convert.ToDecimal(matloobTXT.Text) - Convert.ToDecimal(madfoo3TXT.Text), notesTXT.Text, usertxt.Text, ""
                    //     , Convert.ToDecimal(matloobTXT.Text), Convert.ToDecimal(madfoo3TXT.Text), Convert.ToInt32(salesID_TXT.Text), 2, DateTime.Today.AddDays(3).ToString(), Convert.ToDecimal(matloobTXT.Text) - Convert.ToDecimal(madfoo3TXT.Text), "not paid", "", "");


                }
                else { ba2y_el7esab = 0; }


            }

            //}
            //ma5zoon
            decimal total_taklefa = 0;
            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {

                products_tableTableAdapter1.FillBy_int_code_and_far3(dataSet11.products_table, dgr.Cells[1].Value.ToString(), far3txt.Text);
                decimal pro_count = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);
                if (pro_count == 0)
                {
                    mo3adalat_tasnee3_tableTableAdapter1.FillBy_pro_name(dataSet11.mo3adalat_tasnee3_table, dgr.Cells[2].Value.ToString());
                    if (dataSet11.mo3adalat_tasnee3_table.Rows.Count > 0)
                    {
                        //decimal sum_cost = 0;
                        decimal pro_cost_all = 0;
                        foreach (DataRow dr in dataSet11.mo3adalat_tasnee3_table.Rows)
                        {

                            string material_name = dr["mo3adalat_tasnee3_material_name"].ToString();
                            decimal pro_count_in_mo3adalt = Convert.ToDecimal(dr["mo3adalat_tasnee3_material_count"]);
                            products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, material_name, far3txt.Text);


                            pro_count = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);
                            if (pro_count <= 0)
                            {
                                mo3adalat_tasnee3_tableTableAdapter1.FillBy_pro_name(dataSet12.mo3adalat_tasnee3_table, material_name);
                                if (dataSet12.mo3adalat_tasnee3_table.Rows.Count > 0)
                                {
                                    foreach (DataRow dr2 in dataSet12.mo3adalat_tasnee3_table.Rows)
                                    {
                                        decimal pro_count_in_mo3adalt2 = 0;
                                        string material_name_2 = dr2["mo3adalat_tasnee3_material_name"].ToString();
                                        products_tableTableAdapter1.FillBy_name_and_far3(dataSet12.products_table, material_name_2, far3txt.Text);

                                        //if (dataSet12.products_table.Rows.Count <= 0)
                                        //{
                                        //    MessageBox.Show("الصنف " + material_name_2 + " غير موجود في الفرع " + far3txt.Text, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                        //    return;
                                        //}

                                        decimal pro_count2 = Convert.ToDecimal(dataSet12.products_table.Rows[0]["pro_count"]);
                                        pro_count_in_mo3adalt2 = Convert.ToDecimal(dr2["mo3adalat_tasnee3_material_count"]);
                                        string pro_code = dataSet12.products_table.Rows[0]["pro_ID"].ToString();
                                        string pro_int_code = dataSet12.products_table.Rows[0]["pro_int_code"].ToString();
                                        string unit_price = dataSet12.products_table.Rows[0]["pro_bee3"].ToString();

                                        decimal pro_count_after = pro_count2 - ((pro_count_in_mo3adalt2 *pro_count_in_mo3adalt)* Convert.ToDecimal(dgr.Cells[3].Value));

                                        total_taklefa += Convert.ToDecimal(dataSet12.products_table.Rows[0]["pro_cost_price"]) * ((pro_count_in_mo3adalt2 * pro_count_in_mo3adalt) * Convert.ToDecimal(dgr.Cells[3].Value));

                                        ma5zoon_movesTableAdapter1.Insert_ma5zoon_moves_all(dateTimePicker1.Value.ToShortDateString(), pro_int_code, material_name_2, ((pro_count_in_mo3adalt2 * pro_count_in_mo3adalt) * Convert.ToDecimal(dgr.Cells[3].Value)),
                                            Convert.ToDecimal(dgr.Cells[6].Value), pro_count2, pro_count_after, "بيـع", Convert.ToInt32(salesID_TXT.Text), cst_nameTXT.Text, usertxt.Text, far3txt.Text);
                                        //products
                                        products_tableTableAdapter1.Update_count_BY_ID_bee3(Convert.ToDecimal(dgr.Cells[3].Value) * (pro_count_in_mo3adalt2 * pro_count_in_mo3adalt), Convert.ToDecimal(dgr.Cells[3].Value) * (pro_count_in_mo3adalt2 * pro_count_in_mo3adalt), pro_int_code, far3txt.Text);

                                        pro_cost_all += Convert.ToDecimal(dataSet12.products_table.Rows[0]["pro_cost_price"]) * ((pro_count_in_mo3adalt2 * pro_count_in_mo3adalt) * Convert.ToDecimal(dgr.Cells[3].Value));
                           
                                        //if ((Convert.ToDecimal(countTXT.Text) * pro_count_in_mo3adalt2) > pro_count2)
                                        //{
                                        //    MessageBox.Show("الكمية من " + material_name_2 + " الخاصة بالصنف " + product_name + " غير متاحه في " + far3txt.Text + "  برجاء اضافة الكمية الصحيحة  ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                        //    return;
                                        //}
                                    }
                                }
                            }
                            else
                            {
                                 pro_count_in_mo3adalt = Convert.ToDecimal(dr["mo3adalat_tasnee3_material_count"]);

                                string pro_code = dataSet11.products_table.Rows[0]["pro_ID"].ToString();
                                string pro_int_code = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                                string unit_price = dataSet11.products_table.Rows[0]["pro_bee3"].ToString();

                                decimal pro_count_after = pro_count - (pro_count_in_mo3adalt * Convert.ToDecimal(dgr.Cells[3].Value));

                                total_taklefa += Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_cost_price"]) * (pro_count_in_mo3adalt * Convert.ToDecimal(dgr.Cells[3].Value));

                                ma5zoon_movesTableAdapter1.Insert_ma5zoon_moves_all(dateTimePicker1.Value.ToShortDateString(), pro_int_code, material_name, (pro_count_in_mo3adalt * Convert.ToDecimal(dgr.Cells[3].Value)),
                                    Convert.ToDecimal(dgr.Cells[6].Value), pro_count, pro_count_after, "بيـع", Convert.ToInt32(salesID_TXT.Text), cst_nameTXT.Text, usertxt.Text, far3txt.Text);
                                //products
                                products_tableTableAdapter1.Update_count_BY_ID_bee3(Convert.ToDecimal(dgr.Cells[3].Value) * pro_count_in_mo3adalt, Convert.ToDecimal(dgr.Cells[3].Value) * pro_count_in_mo3adalt, pro_int_code, far3txt.Text);

                                pro_cost_all += Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_cost_price"]) * (pro_count_in_mo3adalt * Convert.ToDecimal(dgr.Cells[3].Value));
                            }
                        }

                        // pro_cost_all = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_cost_price"]) * Convert.ToDecimal(dgr.Cells[3].Value);
                        decimal pro_bee3_all = Convert.ToDecimal(dgr.Cells[4].Value) * Convert.ToDecimal(dgr.Cells[3].Value);

                        arba7_cat_tableTableAdapter1.Insert(DateTime.Today, dgr.Cells[2].Value.ToString(), pro_bee3_all - pro_cost_all, dgr.Cells[7].Value.ToString(), Convert.ToInt32(salesID_TXT.Text), "", far3txt.Text);


                        string cat = dgr.Cells[7].Value.ToString();
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
                         , pro_bee3_all - pro_cost_all, Convert.ToDecimal(madfoo3TXT.Text), usertxt.Text, Convert.ToDecimal(discountTXT.Text), old_7esab_sab2, ba2y_el7esab_new, dgr.Cells[1].Value.ToString(), dgr.Cells[2].Value.ToString(),
                         Convert.ToDecimal(dgr.Cells[3].Value), Convert.ToDecimal(dgr.Cells[4].Value), notesTXT.Text, Convert.ToDouble(nesba_discount_txt.Text), (Convert.ToDecimal(dgr.Cells[4].Value) * Convert.ToDecimal(dgr.Cells[5].Value)) * Convert.ToDecimal(dgr.Cells[3].Value), cat, Convert.ToDecimal(egmaly_kest_txt.Text), btn_gomla.Text, far3txt.Text
                         , mandoob_txt.Text, "", DateTime.Now.TimeOfDay, 0, 0, 0, Convert.ToInt32(day_num_txt.Text));

                    }
                }
                else
                {
                    string pro_code = dataSet11.products_table.Rows[0]["pro_ID"].ToString();
                    string unit_price = dataSet11.products_table.Rows[0]["pro_bee3"].ToString();

                    decimal pro_count_after = pro_count - Convert.ToDecimal(dgr.Cells[3].Value);
                    ma5zoon_movesTableAdapter1.Insert_ma5zoon_moves_all(dateTimePicker1.Value.ToShortDateString(), dgr.Cells[1].Value.ToString(), dgr.Cells[2].Value.ToString(), Convert.ToDecimal(dgr.Cells[3].Value),
                        Convert.ToDecimal(dgr.Cells[6].Value), pro_count, pro_count_after, "بيـع", Convert.ToInt32(salesID_TXT.Text), cst_nameTXT.Text, usertxt.Text, far3txt.Text);

                    //products
                    products_tableTableAdapter1.Update_count_BY_ID_bee3(Convert.ToDecimal(dgr.Cells[3].Value), Convert.ToDecimal(dgr.Cells[3].Value), dgr.Cells[1].Value.ToString(), far3txt.Text);
                    decimal pro_cost_all = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_cost_price"]) * Convert.ToDecimal(dgr.Cells[3].Value);
                    decimal pro_bee3_all = Convert.ToDecimal(dgr.Cells[4].Value) * Convert.ToDecimal(dgr.Cells[3].Value);

                    arba7_cat_tableTableAdapter1.Insert(DateTime.Today, dgr.Cells[2].Value.ToString(), pro_bee3_all - pro_cost_all, dgr.Cells[6].Value.ToString(), Convert.ToInt32(salesID_TXT.Text), "", far3txt.Text);
                    total_taklefa += Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_cost_price"]) * Convert.ToDecimal(dgr.Cells[3].Value);


                    string cat = dgr.Cells[7].Value.ToString();
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
                        , pro_bee3_all - pro_cost_all, Convert.ToDecimal(madfoo3TXT.Text), usertxt.Text, Convert.ToDecimal(discountTXT.Text), old_7esab_sab2, ba2y_el7esab_new, dgr.Cells[1].Value.ToString(), dgr.Cells[2].Value.ToString(),
                        Convert.ToDecimal(dgr.Cells[3].Value), Convert.ToDecimal(dgr.Cells[4].Value), notesTXT.Text, Convert.ToDouble(nesba_discount_txt.Text), (Convert.ToDecimal(dgr.Cells[4].Value) * Convert.ToDecimal(dgr.Cells[5].Value)) * Convert.ToDecimal(dgr.Cells[3].Value), cat, Convert.ToDecimal(egmaly_kest_txt.Text), btn_gomla.Text, far3txt.Text
                        , mandoob_txt.Text, "", DateTime.Now.TimeOfDay, 0, 0, 0, Convert.ToInt32(day_num_txt.Text));
                }

            }


            ////reb7 arba7

            decimal reb7 = Convert.ToDecimal(matloobTXT.Text) - total_taklefa - Convert.ToDecimal(egmaly_dariba_txt.Text);
            //arba7

            string arba7_details = "ربح فاتورة بيع رقم " + salesID_TXT.Text;
            arba7_tableTableAdapter1.Insert_arba7(dateTimePicker1.Value.ToShortDateString(), arba7_details, reb7, "مبيعات", Convert.ToInt32(salesID_TXT.Text), "", usertxt.Text, Convert.ToDecimal(matloobTXT.Text), total_taklefa, far3txt.Text);



            //sales
            if (egmaly_kest_txt.Text == "")
            {
                egmaly_kest_txt.Text = "0";
            }
            string note = "";
            if (Convert.ToDecimal(madfoo3TXT.Text) >= Convert.ToDecimal(matloobTXT.Text))
            {
                //    note="كاش";
            }
            else
            {
                //     note="قسط على "+number_of_aksat_txt.Text+" "+comboBox1.Text;
            }



            //foreach (DataGridViewRow dgr in dataGridView1.Rows)
            //{
            //    //try
            //    //{
            //    products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, dgr.Cells[2].Value.ToString(), far3txt.Text);
            //    //string cat = dgr.Cells[7].Value.ToString();
            //    //decimal old_7esab_sab2;
            //    //decimal ba2y_el7esab_new;
            //    //if (Convert.ToDecimal(madfoo3TXT.Text) < Convert.ToDecimal(matloobTXT.Text))
            //    //{
            //    //    ba2y_el7esab_new = Convert.ToDecimal(matloobTXT.Text) - Convert.ToDecimal(madfoo3TXT.Text);
            //    //}
            //    //else
            //    //{
            //    //    ba2y_el7esab_new = 0;
            //    //}
            //    //if (hesab_sab2_txt.Text != "")
            //    //{
            //    //    old_7esab_sab2 = Convert.ToDecimal(hesab_sab2_txt.Text);
            //    //}
            //    //else
            //    //{
            //    //    old_7esab_sab2 = 0;
            //    //}
            //    cancelled
            //    //sales_tableTableAdapter1.Insert(Convert.ToInt32(salesID_TXT.Text), dateTimePicker1.Value, cst_nameTXT.Text, cst_phoneTXT.Text, cst_addressTXT.Text
            //    //         , reb7, Convert.ToDecimal(madfoo3TXT.Text), usertxt.Text, Convert.ToDecimal(discountTXT.Text), old_7esab_sab2, ba2y_el7esab_new, dgr.Cells[1].Value.ToString(), dgr.Cells[2].Value.ToString(),
            //    //         Convert.ToDecimal(dgr.Cells[3].Value), Convert.ToDecimal(dgr.Cells[4].Value), note + "  " + notesTXT.Text, Convert.ToDouble(nesba_discount_txt.Text), (Convert.ToDecimal(dgr.Cells[4].Value) * Convert.ToDecimal(dgr.Cells[5].Value)) * Convert.ToDecimal(dgr.Cells[3].Value), cat, Convert.ToDecimal(egmaly_kest_txt.Text), "", far3txt.Text
            //    //         , mandoob_txt.Text, "", DateTime.Now.TimeOfDay);

            //    try
            //    {

            //        serial_tableTableAdapter1.Delete_by_serial_serial_no(dgr.Cells[6].Value.ToString());
            //    }
            //    catch { }
            //    //}
            //    //catch { }
            //    //decimal nesba = Convert.ToDecimal(dataSet11.products_table.Rows[0]["nesba_saydaly"]);
            //    //decimal bee3 = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_bee3"]);
            //    //decimal count = Convert.ToDecimal(dgr.Cells[3].Value);

            //    //saydaly_nesbaTableAdapter1.Insert(dateTimePicker1.Value, usertxt.Text, dgr.Cells[2].Value.ToString(), nesba, bee3, count, Convert.ToInt32(salesID_TXT.Text));
            //}


            //income
            string income_details = "مبلغ من فاتورة بيع رقم " + salesID_TXT.Text;
            decimal income_cost = 0;
            string source = "";
            if (Convert.ToDecimal(madfoo3TXT.Text) < Convert.ToDecimal(matloobTXT.Text))
            {
                income_cost = Convert.ToDecimal(madfoo3TXT.Text);
                source = "آجل";
                safeTableAdapter1.Update_add_to_safe(income_cost);


                //safe status daily
                safeTableAdapter1.Insert_safe(dateTimePicker1.Value.ToShortDateString(), income_cost);


            }
            else if (Convert.ToDecimal(madfoo3TXT.Text) >= Convert.ToDecimal(matloobTXT.Text) && radioButton1.Checked == true)
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
            decimal ba2y_fatora;
            if (Convert.ToDecimal(ba2y_txt.Text) < 0)
            {
                ba2y_fatora = Convert.ToDecimal(ba2y_txt.Text) * -1;
            }
            else
            {
                ba2y_fatora = 0;// Convert.ToDecimal(ba2y_txt.Text);
            }
            income_tableTableAdapter1.Insert_income(dateTimePicker1.Value.ToShortDateString(), income_details, income_cost, Convert.ToInt32(salesID_TXT.Text), source, cst_nameTXT.Text, usertxt.Text, "  " + "", far3txt.Text, ba2y_fatora);

            //safe_status  current

            resp_tableTableAdapter1.FillBy_name(dataSet11.resp_table, mandoob_txt.Text);

            if (dataSet11.resp_table.Rows.Count > 0)
            {
                try
                {
                    decimal bonus = Convert.ToDecimal(bonus_txt.Text) / 100;
                    decimal added_value = bonus * Convert.ToDecimal(matloobTXT.Text);


                    string da2n_byan = "نسبة فاتورة رقم " + sales_num;


                    //  da2n_small_reportsTableAdapter1.FillBy_da2n_small_name(dataSet11.resp_table, cst_nameTXT.Text);
                    decimal matloob_before2 = Convert.ToDecimal(dataSet11.resp_table.Rows[0]["mas2ool_matloob"]);
                    decimal madfoo3_before2 = Convert.ToDecimal(dataSet11.resp_table.Rows[0]["mas2ool_madfoo3"]);
                    decimal ba2y_before2 = matloob_before2 - madfoo3_before2;



                    decimal matloob_all2 = Convert.ToDecimal(dataSet11.resp_table.Rows[0]["mas2ool_matloob"]) + added_value;
                    // decimal madfoo3_all2 = Convert.ToDecimal(dataSet11.resp_table.Rows[0]["da2n_small_madfoo3"]) + Convert.ToDecimal(madfoo3TXT.Text);
                    decimal ba2y_all2 = matloob_all2;// -madfoo3_all2;

                    mosta7akat_mas2oleen_tableTableAdapter1.Insert(mandoob_txt.Text, dateTimePicker1.Value, matloob_all2, madfoo3_before2, added_value, 0, usertxt.Text
                     , ba2y_before2, ba2y_all2, da2n_byan, "دائن", Convert.ToInt32(sales_num));

                    //da2n small report update
                    resp_tableTableAdapter1.Update_matloob_added_amount_by_name(added_value, mandoob_txt.Text);

                }
                catch { }
            }

            //sales number
            if (type_txt.Text != "تعديل")
            {
                numbers_tableTableAdapter1.Update_sales_id(far3txt.Text);
                day_numbersTableAdapter1.Update_day_num_by_date(dateTimePicker1.Value.ToShortDateString());
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

            if (cst_nameTXT.Focused == true)
            {
                customersTableAdapter1.FillBy_name(dataSet11.customers, cst_nameTXT.Text);
                try
                {
                    cst_phoneTXT.Text = dataSet11.customers.Rows[0]["cst_phone"].ToString();
                    cst_addressTXT.Text = dataSet11.customers.Rows[0]["cst_address"].ToString();
                    cst_notes_txt.Text = dataSet11.customers.Rows[0]["cst_notes"].ToString();
                    max_limit_txt.Text = dataSet11.customers.Rows[0]["cst_price_category"].ToString();
                    cst_code.Text = dataSet11.customers.Rows[0]["cst_ID"].ToString();
                    //fatora_type.Text = dataSet11.customers.Rows[1]["cst_price_category"].ToString();
                }
                catch
                {
                    //cst_phoneTXT.Text = "";
                    //cst_addressTXT.Text = "";
                    //   fatora_type.Text = "";
                }

                try
                {
                    madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet11.madeen_small_report, cst_nameTXT.Text);
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

                        hesab_sab2_txt.Text = "0";


                    }


                }


            }
            try
            {
                if (cst_nameTXT.Text != "نقدي")
                {
                    sales_tableTableAdapter1.FillBy_LAST_FATORA_TYPE_BY_CST_NAME(dataSet11.sales_table, cst_nameTXT.Text);
                    if (dataSet11.sales_table.Rows.Count > 0)
                    {
                        string type = dataSet11.sales_table.Rows[0]["sales_fatora_type"].ToString();
                        if (type == "جملة")
                        {
                            btn_gomla.Text = "جملة";
                        }
                        else
                        {
                            btn_gomla.Text = "قطاعي";
                        }
                    }
                }
                else
                {
                    btn_gomla.Text = "قطاعي";
                }
            }
            catch { }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    //if (type_txt.Text != "تعديل")
            //    //{
            //        int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            //        DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

            //        decimal old_count = Convert.ToDecimal(selectedRow.Cells[3].Value);
            //        string id = selectedRow.Cells[2].Value.ToString();
            //        products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, id, far3txt.Text);
            //        decimal pro_count;



            //            pro_count = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);

            //            if (Convert.ToDecimal(selectedRow.Cells[3].Value) > pro_count)
            //            {

            //                 //selectedRow.Cells[3].Value = "0";
            //                //selectedRow.Cells[6].Value = "0";
            //                dataGridView1.Rows.RemoveAt(selectedrowindex);
            //                MessageBox.Show("الكمية غير متاحه في المخزن تم حذف الصنف برجاء اضافة الكمية الصحيحة مرة اخرى", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            //                //selectedRow.Selected = false;
            //               // MessageBox.Show("gomla");
            //                return;

            //            }
            //            else { return; }


            //        //    products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, (selectedRow.Cells[2].Value.ToString()));
            //        //    string category_name = "";
            //        //    try
            //        //    {
            //        //        category_name = dataSet11.products_table.Rows[0]["pro_category"].ToString();
            //        //    }
            //        //    catch { }
            //        //    categoryTableAdapter1.FillBy_name(dataSet11.Category, category_name);

            //        //}
            //   // }
            //}
            //catch { }
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
            //        if (dgr.Cells[1].Value.ToString() != "")
            //        {
            //            dgr.Cells[3].Value = kest_cost.ToString();
            //        }
            //    }
            //}
            //catch { }
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedrowindex = dataGridView2.SelectedCells[1].RowIndex;
                DataGridViewRow selectedRow = dataGridView2.Rows[selectedrowindex];

                int x = selectedRow.Index - 1;
                int ready = Convert.ToInt32(dataGridView2.Rows[x].Cells[1].Value) + 1;
                selectedRow.Cells[1].Value = ready.ToString();

                try
                {
                    string selected_string = selectedRow.Cells[4].Value.ToString();
                    //MessageBox.Show(selected_string);
                }
                catch
                {
                    selectedRow.Cells[4].Value = "new";
                }


                //  string selected_string = selectedRow.Cells["Column11"].Value.ToString();
                //MessageBox.Show(selected_string);
                //if ( selected_string== "")
                //{
                // MessageBox.Show("aaaa");
                // selectedRow.Cells[4].Value = "new";
                //  MessageBox.Show(selectedRow.Cells[1].Value.ToString());
                //   }


            }
            catch { }
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

                products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, selectedRow.Cells[2].Value.ToString(), far3txt.Text);
                string product_name = dataSet11.products_table.Rows[0]["pro_name"].ToString();
                decimal count = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);
                if (count <= 0)
                {
                    mo3adalat_tasnee3_tableTableAdapter1.FillBy_pro_name(dataSet11.mo3adalat_tasnee3_table, product_name);
                    if (dataSet11.mo3adalat_tasnee3_table.Rows.Count > 0)
                    {
                        decimal cost_for_mo3adlat = 0;
                        foreach (DataRow dr in dataSet11.mo3adalat_tasnee3_table.Rows)
                        {
                            string material_name = dr["mo3adalat_tasnee3_material_name"].ToString();
                            products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, material_name, far3txt.Text);

                            decimal pro_count_in_mo3adalt = Convert.ToDecimal(dr["mo3adalat_tasnee3_material_count"]);

                            cost_for_mo3adlat += Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_cost_price"]) * pro_count_in_mo3adalt;

                        }
                        // dataGridView1.Rows[i].Cells[3].Value = count_in.ToString();
                        taklefa_txt.Text = (cost_for_mo3adlat).ToString();
                        timer_hide_taklefa.Start();

                    }
                }
                else
                {
                    raseed_now_txt.Text = dataSet11.products_table.Rows[0]["pro_count"].ToString();
                    taklefa_txt.Text = dataSet11.products_table.Rows[0]["pro_cost_price"].ToString();
                    we7dat_txt.Text = dataSet11.products_table.Rows[0]["pro_pieces_in_packet"].ToString();
                    timer_hide_taklefa.Start();
                }
            }
            catch { }
            try
            {
                if (e.ColumnIndex == 8)
                {
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                    DialogResult re = MessageBox.Show("هل تريد حذف الصنف  " + selectedRow.Cells[2].Value.ToString() + " ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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

            //        cst_nameTXT.Text = dataSet11.sales_table.Rows[1]["sales_cst_name"].ToString();
            //        cst_phoneTXT.Text = dataSet11.sales_table.Rows[1]["sales_cst_phone"].ToString();
            //        cst_addressTXT.Text = dataSet11.sales_table.Rows[1]["sales_cst_address"].ToString();

            //        dateTimePicker1.Value = Convert.ToDateTime(dataSet11.sales_table.Rows[1]["sales_date"]);

            //        //discountTXT.Text = dataSet11.sales_table.Rows[1]["sales_discount"].ToString();
            //        //nesba_discount_txt.Text = dataSet11.sales_table.Rows[1]["sales_nesba_discount"].ToString();
            //      //  reb7TXT.Text = dataSet11.sales_table.Rows[1]["sales_profit"].ToString();
            //       // hesab_sab2TXT.Text = dataSet11.sales_table.Rows[1]["sales_7esab_sabe2"].ToString();
            //      //  ba2y_el7esabTXT.Text = dataSet11.sales_table.Rows[1]["sales_ba2y_el7esab"].ToString();

            //      old_madfoo3= dataSet11.sales_table.Rows[1]["sales_madfoo3"].ToString();
            //      madfoo3TXT.Text = dataSet11.sales_table.Rows[1]["sales_madfoo3"].ToString();
            //      //  mwazafTXT.Text = dataSet11.sales_table.Rows[1]["sales_user"].ToString();

            //        notesTXT.Text = dataSet11.sales_table.Rows[1]["sales_notes"].ToString();


            //        egmaly_kest_txt.Text = dataSet11.sales_table.Rows[1]["sales_egmaly_kest_cost"].ToString();
            //        foreach (DataRow dr in dataSet11.sales_table.Rows)
            //        {
            //            dataGridView1.Rows.Add((dataGridView1.Rows.Count + 1).ToString(), dr["sales_product_ID"].ToString(), dr["sales_product_name"].ToString(), dr["sales_product_count"].ToString(), dr["sales_unit_price"].ToString(), dr["sales_price_for_sell"].ToString(), dr["sales_dariba"].ToString());
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
            //                dataGridView1.Rows[i].Cells[5].Value = Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value) * Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
            //                //sum_dariba += Convert.ToDecimal(dataGridView1.Rows[i].Cells[6].Value);

            //                sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);

            //            }

            //            decimal egmaly_after = sum + Convert.ToDecimal(egmaly_kest_txt.Text);
            //            egmaly_se3r_txt.Text = sum.ToString();
            //           // egmaly_dariba_txt.Text = sum_dariba.ToString();
            //            egmaly_elfatoraTXT.Text = Convert.ToString(egmaly_after);


            //            foreach (DataGridViewRow dgr in dataGridView2.Rows)
            //            {
            //                if (dgr.Cells[1].Value.ToString() != "")
            //                {
            //                    dgr.Cells[4].Value = "new";
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

       
        private void egmaly_elfatoraTXT_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (type_txt.Text != "تعديل")
            //    {
            //        madeen_tableTableAdapter1.FillBy_by_madeen(dataSet11.madeen_table, cst_nameTXT.Text);

            //        hesab_sab2_txt.Text = dataSet11.madeen_small_report.Rows[0]["madeen_small_ba2y"].ToString();

            //        //decimal sabek = (Convert.ToDecimal(dataSet11.madeen_table.Rows[1]["madden_ba2y"]) + Convert.ToDecimal(old_madfoo3)) - Convert.ToDecimal(egmaly_elfatoraTXT.Text);
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
                    if (dgr.Cells[1].Value.ToString() != "")
                    {
                        dgr.Cells[3].Value = kest_cost.ToString();
                    }
                }
            }
            catch { }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedrowindex = dataGridView3.SelectedCells[1].RowIndex;
                DataGridViewRow selectedRow = dataGridView3.Rows[selectedrowindex];
                cst_nameTXT.Text = selectedRow.Cells[1].Value.ToString();
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

                _intergerValue = Convert.ToInt32(splits[1]);

                if (splits.Length > 1)
                    _decimalValue = Convert.ToInt32(GetDecimalValue(splits[2]));
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
                    retVal = String.Format("{0} {1}", englishOnes[hundreds], englishGroup[1]);
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
                    retVal = englishOnes[1];
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
                        retVal = String.Format("{0}", arabicAppendedTwos[1]);
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
            public_label.Text = control.Name.ToString();
            //delete_label_txt.Text = control.Name.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }


       

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void sell_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                if (madfoo3TXT.Text == "")
                {
                    madfoo3TXT.Text = matloobTXT.Text;
                }
                savebtn_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F10)
            {
                //if (madfoo3TXT.Text == "")
                //{
                madfoo3TXT.Text = "0";
                //}
                savebtn_Click(sender, e);
            }

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
            //    //    if (dgr.Cells[6].Value.ToString() != "0")
            //    //    {
            //    //        try
            //    //        {
            //    //            if (l.Items.Contains(dgr.Cells[6].Value.ToString()))
            //    //            {
            //    //            }
            //    //            else
            //    //            {
            //    //                l.Items.Add(dgr.Cells[6].Value.ToString());
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


            if (e.KeyCode == Keys.F9)
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
            //        dgr.Cells[4].Value = Convert.ToDecimal(dgr.Cells[4].Value) - (_last_discount / Convert.ToDecimal(dgr.Cells[3].Value));
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
            //        products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, dgr.Cells[2].Value.ToString());
            //        // raseed_now_txt.Text = dataSet11.products_table.Rows[0]["pro_count"].ToString();
            //        if (fatora_type.Text == "قطاعي")
            //        {
            //            dgr.Cells[4].Value =(Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_bee3_2"])/Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_pieces_in_packet"])).ToString();
            //        }
            //        else if (fatora_type.Text == "جمله")
            //        {
            //           dgr.Cells[4].Value = dataSet11.products_table.Rows[0]["pro_bee3"].ToString();
            //        }
            //        else if (fatora_type.Text == "جملة الجمله")
            //        {
            //           dgr.Cells[4].Value =  dataSet11.products_table.Rows[0]["pro_gomla_gomla"].ToString();
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
                madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet11.madeen_small_report, cst_nameTXT.Text);
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

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (product_nameTXT.Text == "")
            {
                MessageBox.Show("ادخل اسم المنتج");
                product_nameTXT.Focus();
                return;
            }

            if (countTXT.Text == "")
            {
                MessageBox.Show("أدخل الكمية");
                countTXT.Select();
                return;
            }



            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells[1].Value.ToString() == product_nameTXT.Text || dataGridView1.Rows[i].Cells[2].Value.ToString() == product_nameTXT.Text)
                {
                    decimal count_in = Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value) + Convert.ToDecimal(countTXT.Text);
                    products_tableTableAdapter1.FillBy_int_code_and_far3(dataSet11.products_table, dataGridView1.Rows[i].Cells[1].Value.ToString(), far3txt.Text);

                    string product_name = dataSet11.products_table.Rows[0]["pro_name"].ToString();
                    decimal count = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);

                    if (count <= 0)
                    {
                        mo3adalat_tasnee3_tableTableAdapter1.FillBy_pro_name(dataSet11.mo3adalat_tasnee3_table, product_name);
                        if (dataSet11.mo3adalat_tasnee3_table.Rows.Count > 0)
                        {
                            decimal cost_for_mo3adlat = 0;
                            foreach (DataRow dr in dataSet11.mo3adalat_tasnee3_table.Rows)
                            {
                                string material_name = dr["mo3adalat_tasnee3_material_name"].ToString();
                                products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, material_name, far3txt.Text);

                                if (dataSet11.products_table.Rows.Count <= 0)
                                {
                                    MessageBox.Show("الصنف " + material_name + " غير موجود في الفرع " + far3txt.Text, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    return;
                                }

                                decimal pro_count_in_mo3adalt = Convert.ToDecimal(dr["mo3adalat_tasnee3_material_count"]);
                                decimal pro_count1 = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);
                                decimal pro_count_in_mo3adalt2 = 0;
                                if (pro_count1 <= 0)
                                {
                                    mo3adalat_tasnee3_tableTableAdapter1.FillBy_pro_name(dataSet12.mo3adalat_tasnee3_table, material_name);
                                    if (dataSet12.mo3adalat_tasnee3_table.Rows.Count > 0)
                                    {
                                        foreach (DataRow dr2 in dataSet12.mo3adalat_tasnee3_table.Rows)
                                        {
                                            string material_name_2 = dr2["mo3adalat_tasnee3_material_name"].ToString();
                                            products_tableTableAdapter1.FillBy_name_and_far3(dataSet12.products_table, material_name_2, far3txt.Text);

                                            if (dataSet12.products_table.Rows.Count <= 0)
                                            {
                                                MessageBox.Show("الصنف " + material_name_2 + " غير موجود في الفرع " + far3txt.Text, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                                return;
                                            }

                                            decimal pro_count2 = Convert.ToDecimal(dataSet12.products_table.Rows[0]["pro_count"]);
                                             pro_count_in_mo3adalt2 = Convert.ToDecimal(dr2["mo3adalat_tasnee3_material_count"]);

                                            if ((Convert.ToDecimal(countTXT.Text) * pro_count_in_mo3adalt2) > pro_count2)
                                            {
                                                MessageBox.Show("الكمية من " + material_name_2 + " الخاصة بالصنف " + product_name + " غير متاحه في " + far3txt.Text + "  برجاء اضافة الكمية الصحيحة  ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                                return;
                                            }
                                        }
                                    }
                                }
                                else if ((Convert.ToDecimal(countTXT.Text) * pro_count_in_mo3adalt) > pro_count1)
                                {
                                    MessageBox.Show("الكمية من " + material_name + " الخاصة بالصنف " + product_name + " غير متاحه في " + far3txt.Text + "  برجاء اضافة الكمية الصحيحة  ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    return;
                                }

                                try
                                {
                                    cost_for_mo3adlat += Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_cost_price"]) * pro_count_in_mo3adalt;
                                }
                                catch
                                {
                                    cost_for_mo3adlat += Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_cost_price"]) * pro_count_in_mo3adalt2;
                                }
                            }

                            dataGridView1.Rows[i].Cells[3].Value = count_in.ToString();
                            product_nameTXT.Clear();
                            product_nameTXT.Focus();
                            return;
                        }
                    }
                    else if (count_in > count)
                    {
                        MessageBox.Show("الكمية غير متاحه في المخزن", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells[3].Value = count_in.ToString();
                        product_nameTXT.Clear();
                        product_nameTXT.Focus();
                        return;
                    }
                }
            }



            try
            {

                string pro_code = "";
                string product_name;
                string unit_price = "";
                string category_name1;
                string stock1;
                    int pro_id;
                   // MessageBox.Show("1");
                products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, product_nameTXT.Text, far3txt.Text);
                if (dataSet11.products_table.Rows.Count <= 0)
                {
                    products_tableTableAdapter1.FillBy_int_code_and_far3(dataSet11.products_table, product_nameTXT.Text, far3txt.Text);

                }
               // MessageBox.Show("2");
                pro_code = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                pro_id = Convert.ToInt32(dataSet11.products_table.Rows[0]["pro_ID"]);
                product_name = dataSet11.products_table.Rows[0]["pro_name"].ToString();
                if (btn_gomla.Text == "جملة") 
                {
                    unit_price = dataSet11.products_table.Rows[0]["pro_bee3_2"].ToString();
                }
                else
                {
                    unit_price = dataSet11.products_table.Rows[0]["pro_bee3"].ToString();
                }

              //  decimal cost_price = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_cost_price"]);
              //  MessageBox.Show("3");
                category_name1 = dataSet11.products_table.Rows[0]["pro_category"].ToString();

                categoryTableAdapter1.FillBy_name(dataSet11.Category, category_name1);
                decimal dariba = Convert.ToDecimal(dataSet11.Category.Rows[0]["Category_dariba"]) / 100;

                double unit_price_after = Convert.ToDouble(unit_price);
                //+dariba;
                decimal pro_count1 = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);
                decimal pro_limit = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_limit"]);
                decimal count_in_fatora = Convert.ToDecimal(countTXT.Text);
                foreach (DataGridViewRow dgr in dataGridView1.Rows)
                {
                    if (dgr.Cells[1].Value.ToString() == product_nameTXT.Text || dgr.Cells[2].Value.ToString() == product_nameTXT.Text)
                    {
                        count_in_fatora += Convert.ToDecimal(dgr.Cells[3].Value);
                    }
                }
               // MessageBox.Show("4");
                mo3adalat_tasnee3_tableTableAdapter1.FillBy_pro_name(dataSet11.mo3adalat_tasnee3_table, product_name);

               // MessageBox.Show(pro_count1.ToString() + " " + pro_limit.ToString());
                if (pro_count1 <= pro_limit&&dataSet11.mo3adalat_tasnee3_table.Rows.Count<=0 &&pro_count1>0)
                {
                    MessageBox.Show("الصنف " + product_name + " اوشك على النفاذ " , "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                if (count_in_fatora > pro_count1)
                {
                    mo3adalat_tasnee3_tableTableAdapter1.FillBy_pro_name(dataSet11.mo3adalat_tasnee3_table, product_name);
                    decimal cost_for_mo3adlat = 0;
                    if (dataSet11.mo3adalat_tasnee3_table.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dataSet11.mo3adalat_tasnee3_table.Rows)
                        {
                            string material_name = dr["mo3adalat_tasnee3_material_name"].ToString();
                            products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, material_name, far3txt.Text);
                            if (dataSet11.products_table.Rows.Count <= 0)
                            {
                                MessageBox.Show("الصنف " + material_name + " غير موجود في الفرع " + far3txt.Text, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                return;
                            }
                            else
                            {
                                decimal pro_count_in_mo3adalt = Convert.ToDecimal(dr["mo3adalat_tasnee3_material_count"]);
                                decimal pro_count_in_mo3adalt2 = 0;
                               // MessageBox.Show(material_name);
                                pro_count1 = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);
                                if (pro_count1 <= 0)
                                {
                                    //MessageBox.Show("55");
                                    mo3adalat_tasnee3_tableTableAdapter1.FillBy_pro_name(dataSet12.mo3adalat_tasnee3_table, material_name);
                                    //MessageBox.Show(material_name + " " + dataSet12.mo3adalat_tasnee3_table.Rows.Count.ToString());
                                    if (dataSet12.mo3adalat_tasnee3_table.Rows.Count > 0)
                                    {
                                        foreach (DataRow dr2 in dataSet12.mo3adalat_tasnee3_table.Rows)
                                        {
                                          
                                            string material_name_2 = dr2["mo3adalat_tasnee3_material_name"].ToString();
                                            products_tableTableAdapter1.FillBy_name_and_far3(dataSet12.products_table, material_name_2, far3txt.Text);
                                            decimal pro_count2 = Convert.ToDecimal(dataSet12.products_table.Rows[0]["pro_count"]);
                                             pro_count_in_mo3adalt2 = Convert.ToDecimal(dr2["mo3adalat_tasnee3_material_count"]);
                                           //  MessageBox.Show(material_name_2);
                                            if ((Convert.ToDecimal(countTXT.Text) * pro_count_in_mo3adalt2) > pro_count2)
                                            {
                                                MessageBox.Show("الكمية من " + material_name_2 + " الخاصة بالصنف " + product_name + " غير متاحه في " + far3txt.Text + "  برجاء اضافة الكمية الصحيحة  ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                                                return;
                                            }
                                        }
                                    }
                                }
                                else if ((Convert.ToDecimal(countTXT.Text) * pro_count_in_mo3adalt) > pro_count1)
                                {

                                    //selectedRow.Cells[3].Value = "0";
                                    //selectedRow.Cells[6].Value = "0";
                                    // dataGridView1.Rows.RemoveAt(selectedrowindex);
                                    //  dgr.Selected = true;
                                    MessageBox.Show("الكمية من " + material_name + " الخاصة بالصنف " + product_name + " غير متاحه في " + far3txt.Text + "  برجاء اضافة الكمية الصحيحة  ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                                    return;
                                }
                                try
                                {
                                    cost_for_mo3adlat += Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_cost_price"]) * pro_count_in_mo3adalt;
                                }
                                catch 
                                {
                                    cost_for_mo3adlat += Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_cost_price"]) * pro_count_in_mo3adalt2;
                                }
                            }

                        }

                        if (cost_for_mo3adlat >= Convert.ToDecimal(unit_price))
                        {
                            DialogResult re = MessageBox.Show("يجب تعديل سعر البيع أولاً.\nاضغط yes للتعديل الآن\nأو no للاستمرار بنفس السعر الحالي", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (re == DialogResult.Yes)
                           {
                               edit_product pe = new edit_product();
                               pe.code_txt.Text = pro_id.ToString();
                               pe.far3txt.Text = far3txt.Text;
                               pe.usertxt.Text = usertxt.Text;
                               //  pe.stock_txt.Text = far3;
                               pe.Text = "تعديل صنف";
                               pe.ShowDialog();


                               products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, product_nameTXT.Text, far3txt.Text);
                               if (dataSet11.products_table.Rows.Count <= 0)
                               {
                                   products_tableTableAdapter1.FillBy_int_code_and_far3(dataSet11.products_table, product_nameTXT.Text, far3txt.Text);

                               }
                               
                               product_name = dataSet11.products_table.Rows[0]["pro_name"].ToString();
                               if (btn_gomla.Text == "جملة")
                               {
                                   unit_price = dataSet11.products_table.Rows[0]["pro_bee3_2"].ToString();
                               }
                               else
                               {
                                   unit_price = dataSet11.products_table.Rows[0]["pro_bee3"].ToString();
                               }

                             
                                unit_price_after = Convert.ToDouble(unit_price);

                             // addbtn_Click(sender, e);
                           }
                           else 
                           {
                              
                           }
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("الكمية غير متاحه في المخزن", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        countTXT.Focus();
                        return;
                    }
                }
                //else
                //{
                dataGridView1.Rows.Add((dataGridView1.Rows.Count + 1).ToString(), pro_code, product_name, countTXT.Text, unit_price_after, dariba.ToString(), "", category_name1);
                if (dataGridView1.Columns.Count == 8)
                {
                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

                    btn.Width = 100;
                    btn.Text = "حذف";
                    btn.DefaultCellStyle.BackColor = Color.Red;
                    btn.Name = "الحذف";
                    btn.UseColumnTextForButtonValue = true;


                    dataGridView1.Columns.Add(btn);
                }
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1;
                try
                {
                    serial_tableTableAdapter1.FillBy_serial_pro_id(dataSet11.serial_table, dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value.ToString());
                }
                catch { }
                if (dataSet11.serial_table.Rows.Count > 0)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[6];
                    dataGridView1.BeginEdit(true);
                    product_nameTXT.Clear();
                }
                else
                {
                    product_nameTXT.Clear();
                    product_nameTXT.Focus();
                }
                // }



            }

            catch
            {

                using (pro_suggest_for_sell p = new pro_suggest_for_sell())
                {
                    //   pro_suggest_for_sell p = new pro_suggest_for_sell();
                    p.product_nameTXT.Text = product_nameTXT.Text;
                    p.stock_txt.Text = far3txt.Text;
                    if (countTXT.Text == "")
                    {
                        p.count_label.Text = "0";
                    }
                    else
                    {
                        p.count_label.Text = countTXT.Text;
                    }
                    p.ShowDialog();
                    string r = p.Result;
                    product_nameTXT.Text = r;
                }
                addbtn_Click(sender, e);
            }


        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                value_before_change = selectedRow.Cells[3].Value.ToString();

                price_before_change = selectedRow.Cells[4].Value.ToString();
                //  dariba_before_change = selectedRow.Cells[6].Value.ToString();
            }
            catch { }
        }
        string value_before_change = "";
        string dariba_before_change = "";
        string price_before_change = "";
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                if (e.ColumnIndex == 4)
                {
                    if (allow_price_edit_or_not.Text == "no")
                    {
                        MessageBox.Show("غير مسموح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        selectedRow.Cells[4].Value = price_before_change;
                        return;
                    }
                    else
                    {
                        if (lower_allow_or_not.Text == "no")
                        {
                            products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, selectedRow.Cells[2].Value.ToString(), far3txt.Text);
                            decimal cost_price = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_cost_price"]);
                            decimal current_price = Convert.ToDecimal(selectedRow.Cells[4].Value);
                            if (current_price <= cost_price)
                            {
                                MessageBox.Show("السعر مرفوض", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                selectedRow.Cells[4].Value = price_before_change;
                                return;
                            }

                        }
                    }
                    //  MessageBox.Show("aaa");
                }
                else if (e.ColumnIndex == 3)
                {

                    decimal old_count = Convert.ToDecimal(selectedRow.Cells[3].Value);
                    string pro_name = selectedRow.Cells[2].Value.ToString();
                    products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, pro_name,far3txt.Text);
                    decimal pro_count = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);


                    if (type_txt.Text != "تعديل")
                    {
                        decimal count_in_fatora = 0;
                        foreach (DataGridViewRow dgr in dataGridView1.Rows)
                        {
                            if (dgr.Cells[2].Value.ToString() == pro_name)
                            {
                                count_in_fatora += Convert.ToDecimal(dgr.Cells[3].Value);
                            }
                        }

                        if (count_in_fatora > pro_count)
                        {

                            MessageBox.Show("الكمية غير متاحه في المخزن", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            selectedRow.Cells[3].Value = value_before_change;
                            // selectedRow.Cells[6].Value = dariba_before_change;

                            // dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                            return;

                        }



                        products_tableTableAdapter1.FillBy_name(dataSet11.products_table, (selectedRow.Cells[2].Value.ToString()));
                        string category_name = "";
                        try
                        {
                            category_name = dataSet11.products_table.Rows[0]["pro_category"].ToString();
                        }
                        catch { }
                        categoryTableAdapter1.FillBy_name(dataSet11.Category, category_name);
                        //  dataGridView1.Rows[i].Cells[3].Value = count_in.ToString();
                        double dariba = 0;
                        try
                        {
                            dariba = Convert.ToDouble(dataSet11.Category.Rows[0]["Category_dariba"]) * Convert.ToDouble(selectedRow.Cells[4].Value) * Convert.ToDouble((selectedRow.Cells[3].Value));
                            // MessageBox.Show(dariba.ToString());

                            //   selectedRow.Cells[6].Value = dariba.ToString();
                        }
                        catch { }
                    }
                }
            }
            catch { }
        }

        private void cst_nameTXT_KeyDown(object sender, KeyEventArgs e)
        {
            //try
            //{

            //if (e.KeyCode == Keys.Return)
            //{
            //    using (customers_show p = new customers_show())
            //    {
            //       //   pro_suggest_for_sell p = new pro_suggest_for_sell();
            //        p.cst_nameTXT.Text = cst_nameTXT.Text;
            //        p.Text = "اختر عميل";
            //        p.ShowDialog();
            //        string r = p.Result;
            //        cst_nameTXT.Text = r;
            //    }
            //}
            //}
            //catch { }
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void cst_phoneTXT_TextChanged(object sender, EventArgs e)
        {
            
              
            
        }

        private void cst_phoneTXT_Leave(object sender, EventArgs e)
        {
            if (cst_phoneTXT.Focused == true && cst_nameTXT.Text == "")
            {
                customersTableAdapter1.FillBy_phone(dataSet11.customers, cst_phoneTXT.Text);
                if (dataSet11.customers.Rows.Count > 0)
                {
                    try
                    {
                        cst_nameTXT.Text = dataSet11.customers.Rows[0]["cst_name"].ToString();
                        //  cst_phoneTXT.Text = dataSet11.customers.Rows[0]["cst_phone"].ToString();
                       // cst_addressTXT.Text = dataSet11.customers.Rows[0]["cst_address"].ToString();
                        cst_nameTXT_TextChanged(sender, e);
                        madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet11.madeen_small_report, cst_nameTXT.Text);

                        if (dataSet11.madeen_small_report.Rows.Count > 0)
                        {
                            hesab_sab2_txt.Text = dataSet11.madeen_small_report.Rows[0]["madeen_small_ba2y"].ToString();

                        }
                        else
                        {
                            hesab_sab2_txt.Text = "0";
                        }
                    }
                    catch { }
                }
                else
                {
                    //  notesTXT.Text = "";
                    ////  daftartxt.Text = "";
                    //  // hesab_sab2_txt.Text = "";
                    //  cst_nameTXT.Text = "";
                    //  cst_addressTXT.Text = "";
                }
            }
        }

        private void cst_code_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                customersTableAdapter1.FillBy_id(dataSet11.customers, Convert.ToInt32(cst_code.Text));

                    cst_nameTXT.Text = dataSet11.customers.Rows[0]["cst_name"].ToString();

                    cst_nameTXT_TextChanged(sender, e);

                    //cst_phoneTXT.Text = dataSet11.customers.Rows[0]["cst_phone"].ToString();
                    //cst_addressTXT.Text = dataSet11.customers.Rows[0]["cst_address"].ToString();
                    //notesTXT.Text = dataSet11.customers.Rows[0]["cst_notes"].ToString();
                    try
                    {
                        madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet11.madeen_small_report, cst_nameTXT.Text);
                        hesab_sab2_txt.Text = dataSet11.madeen_small_report.Rows[0]["madeen_small_ba2y"].ToString();
                    }
                    catch
                    { hesab_sab2_txt.Text = "0"; }

            }
            catch 
            {

                cst_nameTXT.Text = "";
                cst_phoneTXT.Text = "";
                cst_addressTXT.Text = "";
                notesTXT.Text = "";
                hesab_sab2_txt.Text = "";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (madfoo3TXT.Text == "")
            {
                madfoo3TXT.Text = "0";
            }
            savebtn_Click(sender, e);
        }

        private void mandoob_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mandoob_txt.Focused == true)
            {
                resp_tableTableAdapter1.FillBy_NAME_OR_PHONE(dataSet11.resp_table, mandoob_txt.Text, mandoob_txt.Text);
                if (dataSet11.resp_table.Rows.Count > 0)
                {
                    resp_phone_txt.Text = dataSet11.resp_table.Rows[0]["resp_phone"].ToString();
                    bonus_txt.Text = dataSet11.resp_table.Rows[0]["resp_bonus"].ToString();
                }
                else
                {
                    //resp_phone_txt.Text = "";
                    //bonus_txt.Text = "";
                }
            }
        }

        private void mandoob_txt_TextChanged(object sender, EventArgs e)
        {
            mandoob_txt_SelectedIndexChanged(sender, e);
        }

        private void resp_phone_txt_TextChanged(object sender, EventArgs e)
        {
            if (resp_phone_txt.Focused == true)
            {
                resp_tableTableAdapter1.FillBy_NAME_OR_PHONE(dataSet11.resp_table, resp_phone_txt.Text, resp_phone_txt.Text);
                if (dataSet11.resp_table.Rows.Count > 0)
                {
                    mandoob_txt.Text = dataSet11.resp_table.Rows[0]["resp_name"].ToString();
                    bonus_txt.Text = dataSet11.resp_table.Rows[0]["resp_bonus"].ToString();
                }
                else
                {
                    //mandoob_txt.Text = "";
                    //bonus_txt.Text = "";
                }
            }
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void max_limit_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_gomla_Click(object sender, EventArgs e)
        {
            if (btn_gomla.Text == "جملة")
            {
                btn_gomla.Text = "قطاعي";
            }
            else 
            {
                btn_gomla.Text = "جملة";
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 3 || dataGridView1.CurrentCell.ColumnIndex == 4 || dataGridView1.CurrentCell.ColumnIndex == 5)
            {
                TextBox textBox = e.Control as TextBox;

                if (textBox != null)
                {
                    // Attach an event handler to the TextBox.KeyPress event
                    textBox.KeyPress += new KeyPressEventHandler(DigitOnly_KeyPress);
                }
            }
        }
        private void DigitOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, control characters, and a single decimal point
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Ignore the key press
            }

            // Allow only one decimal point
            TextBox textBox = (TextBox)sender;
            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true; // Ignore additional decimal points
            }
        }

        private void timer_hide_taklefa_Tick(object sender, EventArgs e)
        {
            if (taklefa_txt.Text != "")
            {
                taklefa_txt.Text = "";
                timer_hide_taklefa.Stop();
            }
        }

        private void reb7_txt_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                decimal total_taklefa = 0;
                foreach (DataGridViewRow dgr in dataGridView1.Rows)
                {
                    products_tableTableAdapter1.FillBy_int_code_and_far3(dataSet11.products_table, dgr.Cells[1].Value.ToString(), far3txt.Text);
                    decimal pro_count = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);
                    if (pro_count == 0)
                    {
                        mo3adalat_tasnee3_tableTableAdapter1.FillBy_pro_name(dataSet11.mo3adalat_tasnee3_table, dgr.Cells[2].Value.ToString());
                        if (dataSet11.mo3adalat_tasnee3_table.Rows.Count > 0)
                        {
                            //decimal sum_cost = 0;
                            decimal pro_cost_all = 0;
                            foreach (DataRow dr in dataSet11.mo3adalat_tasnee3_table.Rows)
                            {

                                string material_name = dr["mo3adalat_tasnee3_material_name"].ToString();

                                products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, material_name, far3txt.Text);

                                //pro_count = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);
                                decimal pro_count_in_mo3adalt = Convert.ToDecimal(dr["mo3adalat_tasnee3_material_count"]);


                                total_taklefa += Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_cost_price"]) * (pro_count_in_mo3adalt * Convert.ToDecimal(dgr.Cells[3].Value));


                                pro_cost_all += Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_cost_price"]) * (pro_count_in_mo3adalt * Convert.ToDecimal(dgr.Cells[3].Value));

                            }

                            // pro_cost_all = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_cost_price"]) * Convert.ToDecimal(dgr.Cells[3].Value);
                            decimal pro_bee3_all = Convert.ToDecimal(dgr.Cells[4].Value) * Convert.ToDecimal(dgr.Cells[3].Value);


                        }
                    }
                    else
                    {
                        string pro_code = dataSet11.products_table.Rows[0]["pro_ID"].ToString();
                        string unit_price = dataSet11.products_table.Rows[0]["pro_bee3"].ToString();

                        total_taklefa += Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_cost_price"]) * Convert.ToDecimal(dgr.Cells[3].Value);
                    }

                }


                ////reb7 arba7

                decimal reb7 = Convert.ToDecimal(matloobTXT.Text) - total_taklefa - Convert.ToDecimal(egmaly_dariba_txt.Text);

                reb7_txt.Text = reb7.ToString("0.00");
            }
            catch { reb7_txt.Text = ""; }
        }

        private void reb7_txt_MouseLeave(object sender, EventArgs e)
        {
            reb7_txt.Text = "";
        }

        private void sell_with_icons_Shown(object sender, EventArgs e)
        {
            lower_allow_or_not.Text = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\l").First();
            allow_price_edit_or_not.Text = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\ape").First();

            dates_ed = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\dates_ed.txt").First();
            if (dates_ed == "yes")
            {
                dateTimePicker1.Enabled = true;
            }
            else
            {
                dateTimePicker1.Enabled = false;
            }

            string gomla = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\gomla.txt").First();
            if (gomla == "yes")
            {
                btn_gomla.Visible = true;
            }
            else
            {
                btn_gomla.Visible = false;
            }

            this.user_previligesTableAdapter1.FillBy_name(dataSet11.user_previliges, usertxt.Text);
            // read_mandoob();
            // mandoob_txt.Text = usertxt.Text;
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

                    // dataGridView1.Columns[4].ReadOnly = true;

                }
            }

            madeen_small_reportTableAdapter1.Delete_when0();
            //  madeen_tableTableAdapter1.Delete_when0();
            //  this.pharmacy_dataTableAdapter.Fill(this.DataSet1.pharmacy_data);
            // timer1.Stop();
            check_date(dateTimePicker1, notesTXT); //this.dateTimePicker1.Value = DateTime.Today;
            suggest_cst_name();
            suggest_product();
            //  timer1.Start();
            try
            {
                this.numbers_tableTableAdapter1.FillBy_stock(this.dataSet11.Numbers_table, far3txt.Text);
                salesID_TXT.Text = dataSet11.Numbers_table.Rows[0]["sales_ID"].ToString();
            }
            catch { }

            try
            {
                day_numbersTableAdapter1.FillBy_date(dataSet11.day_numbers, dateTimePicker1.Value.ToShortDateString());
                if (dataSet11.day_numbers.Rows.Count > 0)
                {
                    day_num_txt.Text = dataSet11.day_numbers.Rows[0]["day_num"].ToString();
                }
                else
                {
                    day_numbersTableAdapter1.Insert(dateTimePicker1.Value, 1);
                }
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

            this.resp_tableTableAdapter1.Fill(this.dataSet11.resp_table);
            foreach (DataRow dr in dataSet11.resp_table.Rows)
            {
                mandoob_txt.Items.Add(dr["resp_name"].ToString());
            }



            flowLayoutPanel1.Controls.Clear();

            // MessageBox.Show("aa");
            //  Form1 f = new Form1();
            //  MessageBox.Show(f.category_list_items.Items.Count.ToString());
            foreach (var item in category_list_items.Items)
            {
                Button buttton = new Button();

                buttton.Text = item.ToString();
                buttton.Name = item.ToString();
                buttton.Width = flowLayoutPanel1.Width;// / 7;// 80;
                buttton.Height = flowLayoutPanel1.Height / category_list_items.Items.Count;//45;
                buttton.Click += new EventHandler(buttton_Click);
                buttton.FlatStyle = FlatStyle.Flat;
                buttton.BackColor = Color.Green;
                buttton.ForeColor = Color.White;

                buttton.Font = new Font("Tahoma", 17, FontStyle.Bold);
                buttton.BackColor = System.Drawing.Color.Green;
                buttton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
                buttton.FlatAppearance.BorderSize = 2;
                // buttton.Padding = new System.Windows.Forms.Padding(0);
                buttton.Margin = new System.Windows.Forms.Padding(0);
                // buttton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                buttton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                buttton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                // buttton.Size = new System.Drawing.Size(114, 23);
                buttton.UseVisualStyleBackColor = false;
                buttton.Cursor = Cursors.Hand;
                //  buttton.DragOver += new DragEventHandler(button_DragOver);
                // button.FlatAppearance.BorderColor

                // buttton.AutoSize = true;

                this.flowLayoutPanel1.Controls.Add(buttton);
                buttton = new System.Windows.Forms.Button();

            }


            string tax = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\tax.txt").First();
            if (tax == "yes")
            {
                dataGridView1.Columns[5].Visible = true;
            }
            else
            {
                dataGridView1.Columns[5].Visible = false;
            }


            groupBox5.Location = new Point(groupBox3.Width + 2, groupBox6.Location.Y);
            groupBox5.Width = this.Width - groupBox3.Width - flowLayoutPanel1.Width - 5;
            groupBox5.SendToBack();

            groupBox1.Location = new Point(4, 1);
            groupBox1.Width = this.Width - flowLayoutPanel1.Width - 40;

           

        }


        bool TimeBetween(DateTime datetime, TimeSpan start, TimeSpan end)
        {
            // convert datetime to a TimeSpan
            TimeSpan now = datetime.TimeOfDay;
            // see if start comes before end
            if (start < end)
                return start <= now && now <= end;
            // start is after end, so do the inverse comparison
            return !(end < now && now < start);
        }


        public void check_date(DateTimePicker dtp, TextBox notes)
        {
            // MessageBox.Show("aa");
            dtp.Value = DateTime.Today;
            //   MessageBox.Show(DateTime.Now.ToString());
            TimeSpan now = DateTime.Now.TimeOfDay;
            // MessageBox.Show(now.ToString());
            TimeSpan start = new TimeSpan(00, 00, 00);
            //   MessageBox.Show(start.ToString());

            string day_end = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\day_end").First();

            TimeSpan end = TimeSpan.Parse(day_end);
            // TimeSpan end = new TimeSpan(05, 30, 00);
            // MessageBox.Show(end.ToString());

            bool silenceAlarm = TimeBetween(DateTime.Now, start, end);

            if (silenceAlarm == true)
            {
                dtp.Value = DateTime.Today.AddDays(-1);
                notes.Text = "بعد منتصف الليل";
            }
            else
            {
                dtp.Value = DateTime.Today;
                notes.Text = "";
            }

        }
        







    }
}

