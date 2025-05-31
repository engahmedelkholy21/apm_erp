using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace pharma_manage
{
    public partial class sales_mortaga3 : Form
    {
        public sales_mortaga3()
        {
            InitializeComponent();
        }

        private void get_products_from_sales()
        {
            if (sales_fatora_id_txt.Visible == true && sales_fatora_id_txt.Text == "")
            {
                MessageBox.Show("ادخل رقم الفاتورة");
                sales_fatora_id_txt.Focus();
                return;
            }
            AcceptButton = admydbtn;
            if (countTXT.Text == "") 
            {
                MessageBox.Show("ادخل الكمية");
                countTXT.Focus();
                return;
            }

            if (sales_fatora_id_txt.Text == "")
            {
                sales_tableTableAdapter1.FillBy_pro_name_cst_name_count_akbar_0_stock(dataSet11.sales_table, product_nameTXT.Text, cst_nameTXT.Text, far3txt.Text);
                if (dataSet11.sales_table.Rows.Count <= 0)
                {
                    sales_tableTableAdapter1.FillBy_pro_id_cst_name_count_akbar_0_stock(dataSet11.sales_table, product_nameTXT.Text, cst_nameTXT.Text, far3txt.Text);
                }
                if (dataSet11.sales_table.Rows.Count <= 0)
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
                    // get_products_from_sales();
                    return;
                }
            }
            else 
            {
                sales_tableTableAdapter1.FillBy_pro_name_sales_id_count_akbar_0_stock(dataSet11.sales_table, product_nameTXT.Text,Convert.ToInt32(sales_fatora_id_txt.Text), far3txt.Text);
                if (dataSet11.sales_table.Rows.Count <= 0)
                {
                    sales_tableTableAdapter1.FillBy_pro_id_sales_id_count_akbar_0_stock(dataSet11.sales_table, product_nameTXT.Text, Convert.ToInt32(sales_fatora_id_txt.Text), far3txt.Text);
                }
                if (dataSet11.sales_table.Rows.Count <= 0)
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
                    // get_products_from_sales();
                    return;
                }
            }
            
                
            
            
            decimal sum_count = 0;
            decimal count_in = 0;

            foreach (DataGridViewRow dgr in dataGridView1.Rows) 
            {
                if (dgr.Cells[1].Value.ToString() == dataSet11.sales_table.Rows[0]["sales_product_name"].ToString()) 
                {
                    sum_count -= Convert.ToDecimal(dgr.Cells[2].Value);
                    count_in += Convert.ToDecimal(dgr.Cells[2].Value);
                }
            }

           
            
            products_tableTableAdapter1.FillBy_int_code_and_far3(dataSet11.products_table, dataSet11.sales_table.Rows[0]["sales_product_ID"].ToString(), dataSet11.sales_table.Rows[0]["sales_pro_stock"].ToString());
            if (dataSet11.products_table.Rows.Count <= 0) 
            {
                MessageBox.Show("لا يمكن استرجاع هذا الصنف");
                return;
            }

            for (int i = 0; i <= dataSet11.sales_table.Rows.Count; i++) 
            {
                try
                {
                    sum_count += Convert.ToDecimal(dataSet11.sales_table.Rows[i]["sales_product_count"]);
                   // MessageBox.Show(sum_count.ToString());
                }
                catch { }
            }




            if (Convert.ToDecimal(countTXT.Text) > sum_count)
            {
                MessageBox.Show("الكمية أكبر من المباع للعميل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                countTXT.Focus();
                return;
            }
            //else if (Convert.ToDecimal(countTXT.Text) + count_in > sum_count)
            //{
            //    MessageBox.Show("الكمية أكبر من المباع للعميل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    countTXT.Focus();
            //    return;
            //}
            else
            {
                bool exist =false;

                int dgr_index=0;

                foreach (DataGridViewRow dgr in dataGridView1.Rows)
                {

                    if (dgr.Cells[1].Value.ToString() == product_nameTXT.Text || dgr.Cells[0].Value.ToString() == product_nameTXT.Text)
                    {
                        exist = true;
                        dgr_index = dgr.Cells[1].RowIndex;
                      //  MessageBox.Show("dgr_index " + dgr.Cells[1].RowIndex.ToString());


                    }
                    else 
                    {
                        exist = false;
                    }

                  //  MessageBox.Show("new exist " + exist.ToString());
                }
                if (exist == true) 
                {
                    dataGridView1.Rows[dgr_index].Cells[2].Value = Convert.ToDecimal(dataGridView1.Rows[dgr_index].Cells[2].Value) + Convert.ToDecimal(countTXT.Text);
                }
                else if (exist == false)
                {
                    string pro_code = dataSet11.sales_table.Rows[0]["sales_product_ID"].ToString();
                    string pro_name = dataSet11.sales_table.Rows[0]["sales_product_name"].ToString();
                    string unit_price = dataSet11.sales_table.Rows[0]["sales_unit_price"].ToString();
                    string noo3_elbee3 = dataSet11.sales_table.Rows[0]["sales_pro_stock"].ToString();
                    string dariba = dataSet11.sales_table.Rows[0]["sales_dariba"].ToString();
                    string serial = "";// dataSet11.sales_table.Rows[0]["sales_id"].ToString();
                    if (sales_fatora_id_txt.Text == "") 
                    { } 
                    else 
                    {
                        serial = sales_fatora_id_txt.Text;
                    }
                  
                    string fatora_date = "";// Convert.ToDateTime(dataSet11.sales_table.Rows[0]["sales_date"]).ToShortDateString();

                    // MessageBox.Show("aaaa");

                    dataGridView1.Rows.Add(pro_code, pro_name, countTXT.Text, unit_price,dariba, "", noo3_elbee3, serial, fatora_date);
                    if (dataGridView1.Columns.Count == 9)
                    {
                        DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

                        btn.Width = 75;
                        btn.Text = "حذف";
                        btn.DefaultCellStyle.BackColor = Color.Red;
                        btn.Name = "الحذف";
                        btn.UseColumnTextForButtonValue = true;

                        dataGridView1.Columns.Add(btn);
                    }

                }


               

                product_nameTXT.Clear();
                countTXT.Text = "1";
                product_nameTXT.Focus();

                return;


            }
              
           // }


          
        }

        private void admydbtn_Click(object sender, EventArgs e)
        {
           

            try
            {

                get_products_from_sales();
            }
            catch 
            {
                
               } 
            

            //for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            //{
            //    if (dataGridView1.Rows[i].Cells[1].Value.ToString() == product_nameTXT.Text || dataGridView1.Rows[i].Cells[0].Value.ToString() == product_nameTXT.Text)
            //    {
            //        MessageBox.Show("المنتج موجود بالفعل");
            //        product_nameTXT.Select();
            //        return;
            //    }
            //}
            //try
            //{
            //    try
            //    {
            //        sales_tableTableAdapter1.FillBy_cst_name_AND_pro_name_sales_id(dataSet11.sales_table, cst_nameTXT.Text, product_nameTXT.Text, Convert.ToInt32(salesID_TXT.Text), far3txt.Text);
            //    }
            //    catch { }
            //    if (dataSet11.sales_table.Rows.Count <= 0)
            //    {
            //        try
            //        {
            //            sales_tableTableAdapter1.FillBy_cst_name_and_product_ID_sales_id(dataSet11.sales_table, cst_nameTXT.Text, product_nameTXT.Text, Convert.ToInt32(salesID_TXT.Text), far3txt.Text);
            //        }
            //        catch { }
            //    }
            //    if (dataSet11.sales_table.Rows.Count <= 0)
            //    {
            //        try
            //        {
            //            sales_tableTableAdapter1.FillBy_cst_name_sales_id_stock_serial(dataSet11.sales_table, cst_nameTXT.Text, Convert.ToInt32(salesID_TXT.Text), far3txt.Text, product_nameTXT.Text);

            //        }
            //        catch { }
            //    }

            //    string pro_code = dataSet11.sales_table.Rows[0]["sales_product_ID"].ToString();
            //    string pro_name = dataSet11.sales_table.Rows[0]["sales_product_name"].ToString();
            //    string unit_price = dataSet11.sales_table.Rows[0]["sales_unit_price"].ToString();
            //    string noo3_elbee3 = dataSet11.sales_table.Rows[0]["sales_pro_stock"].ToString();
            //    string serial = dataSet11.sales_table.Rows[0]["sales_id"].ToString();

            //    decimal pro_count = Convert.ToDecimal(dataSet11.sales_table.Rows[0]["sales_product_count"]);
            //    if (Convert.ToDecimal(countTXT.Text) > pro_count)
            //    {
            //        MessageBox.Show("الكمية أكبر من المباع في الفاتورة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //        countTXT.Focus();
            //        return;
            //    }
            //    else
            //    {
            //        dataGridView1.Rows.Add(pro_code, pro_name, countTXT.Text, unit_price, "", noo3_elbee3, serial);
            //        product_nameTXT.Clear();
            //        //countTXT.Clear();
            //        product_nameTXT.Focus();
            //        if (dataGridView1.Columns.Count == 7)
            //        {
            //            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

            //            btn.Width = 75;
            //            btn.Text = "حذف";
            //            btn.DefaultCellStyle.BackColor = Color.Red;
            //            btn.Name = "الحذف";
            //            btn.UseColumnTextForButtonValue = true;


            //            dataGridView1.Columns.Add(btn);
            //        }
            //    }


            //}
            //catch
            //{ }

            //    sales_tableTableAdapter1.FillBy_cst_name_and_product_ID_sales_id(dataSet11.sales_table, cst_nameTXT.Text, product_nameTXT.Text, Convert.ToInt32(salesID_TXT.Text), far3txt.Text);
            //    if (dataSet11.sales_table.Rows.Count<=0) 
            //    {
            //        sales_tableTableAdapter1.FillBy_cst_name_sales_id_stock_serial(dataSet11.sales_table, cst_nameTXT.Text, Convert.ToInt32(salesID_TXT.Text), far3txt.Text, product_nameTXT.Text);
               
            //    }
            //    string pro_code = dataSet11.sales_table.Rows[0]["sales_product_ID"].ToString();
            //    string pro_name = dataSet11.sales_table.Rows[0]["sales_product_name"].ToString();
            //    string unit_price = dataSet11.sales_table.Rows[0]["sales_unit_price"].ToString();
            //    string noo3_elbee3 = dataSet11.sales_table.Rows[0]["sales_pro_stock"].ToString();
            //    string serial = dataSet11.sales_table.Rows[0]["sales_serial"].ToString();
                
            //    decimal pro_count = Convert.ToDecimal(dataSet11.sales_table.Rows[0]["sales_product_count"]);
            //    if (Convert.ToDecimal(countTXT.Text) > pro_count)
            //    {
            //        MessageBox.Show("الكمية أكبر من المباع في الفاتورة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //        countTXT.Focus();
            //        return;
            //    }
            //    else
            //    {
            //        dataGridView1.Rows.Add(pro_code, pro_name, countTXT.Text, unit_price,"",noo3_elbee3,serial);
            //        product_nameTXT.Clear(); countTXT.Clear();
            //        product_nameTXT.Focus();

            //        if (dataGridView1.Columns.Count == 7)
            //        {
            //            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                        
            //            btn.Width = 75;
            //            btn.Text = "حذف";
            //            btn.DefaultCellStyle.BackColor = Color.Red;
            //            btn.Name = "الحذف";
            //            btn.UseColumnTextForButtonValue = true;


            //            dataGridView1.Columns.Add(btn);
            //        }
            //    }
            //}
                
        }

        private void product_nameTXT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                products_tableTableAdapter1.FillBy_pro_int_code(dataSet11.products_table, product_nameTXT.Text);
                if (dataSet11.products_table.Rows.Count <= 0)
                {
                    products_tableTableAdapter1.FillBy_name(dataSet11.products_table, product_nameTXT.Text);
                }
                if (dataSet11.products_table.Rows.Count > 0)
                {
                   // unit_price_txt.Text = dataSet11.products_table.Rows[0]["pro_cost_price"].ToString();
                    raseed_txt.Text = dataSet11.products_table.Rows[0]["pro_count"].ToString();
                }
                else
                {
                  //  unit_price_txt.Text = "";
                    raseed_txt.Text = "";
                }

                this.AcceptButton = admydbtn;
            }
            catch { }
        }

        private void salesID_TXT_TextChanged(object sender, EventArgs e)
        {

            try
            {
                //sales_tableTableAdapter1.FillBy_ID(dataSet11.sales_table, Convert.ToInt32(salesID_TXT.Text));
                cst_nameTXT.Text = dataSet11.sales_table.Rows[0]["sales_cst_name"].ToString();
                cst_phoneTXT.Text = dataSet11.sales_table.Rows[0]["sales_cst_phone"].ToString();
                cst_addressTXT.Text = dataSet11.sales_table.Rows[0]["sales_cst_address"].ToString();
                discountTXT.Text = dataSet11.sales_table.Rows[0]["sales_discount"].ToString();
                fatora_type.Text = dataSet11.sales_table.Rows[0]["sales_fatora_type"].ToString();
               
            }
            catch { }

        }
        private void suggest_product()
        {
            if (sales_fatora_id_txt.Text == "")
            {
                this.sales_tableTableAdapter1.FillBy_Cst_Name_IN_fatra(this.dataSet11.sales_table, cst_nameTXT.Text, "1/1/2000", DateTime.Today.ToShortDateString(), far3txt.Text);
            }
            else
            {
                this.sales_tableTableAdapter1.FillBy_ID_stock(this.dataSet11.sales_table,Convert.ToInt32(sales_fatora_id_txt.Text), far3txt.Text);
        
            }
            product_nameTXT.AutoCompleteMode = AutoCompleteMode.Suggest;
            product_nameTXT.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet11.sales_table.Rows)
            {
                DataCollection.Add(dr["sales_product_name"].ToString());
            }

            product_nameTXT.AutoCompleteCustomSource = DataCollection;

        }

        private void countTXT_TextChanged(object sender, EventArgs e)
        {
            
            this.AcceptButton = admydbtn;
        
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
                products_tableTableAdapter1.FillBy_pro_int_code(dataSet11.products_table, dgr.Cells[0].Value.ToString());
                if (dataSet11.products_table.Rows.Count <= 0)
                {
                    MessageBox.Show("تأكد من بيانات الصنف "+ dgr.Cells[1].Value.ToString());
                    return;
                }
            }
            save_mortaga3();

        }
        private void save_mortaga3()
        {
            int mortaga3_num=Convert.ToInt32(mortaga3_id_txt.Text);
            //madeen 

            madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet11.madeen_small_report, cst_nameTXT.Text);
            decimal old_7esab = 0;
            decimal ba2y_el7esab = 0;
            try
            {
                //if madeen exist
                old_7esab = Convert.ToDecimal(dataSet11.madeen_small_report.Rows[0]["madeen_small_ba2y"]);
                // MessageBox.Show("  الباقي قبل اي حاجه  "+old_7esab.ToString());

                //if el ba2y akbar mn el madfoo3
                if (old_7esab >= Convert.ToDecimal(matloobTXT.Text))
                {
                    //madeen small report update
                    madeen_small_reportTableAdapter1.Update_matloob_AND_madfoo3_by_name(0, Convert.ToDecimal(matloobTXT.Text), cst_nameTXT.Text);
                    madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet11.madeen_small_report, cst_nameTXT.Text);

                    decimal new_matloob = Convert.ToDecimal(dataSet11.madeen_small_report.Rows[0]["madeen_small_matloob"]);
                    decimal new_madfoo3 = Convert.ToDecimal(dataSet11.madeen_small_report.Rows[0]["madeen_small_madfoo3"]);

                    ba2y_el7esab = Convert.ToDecimal(dataSet11.madeen_small_report.Rows[0]["madeen_small_ba2y"]);

                    //madeen details insert
                    // MessageBox.Show("1");
                  //  sales_tableTableAdapter1.Update_discount_by_id(0, Convert.ToInt32(salesID_TXT.Text));


                    string madeen_byan = "مبلغ ناتج عن عملية مرتجع بيع ";// +salesID_TXT.Text;

                   //تعديل هنا
               //  madeen_tableTableAdapter1.Insert_madeen_details(dateTimePicker1.Value.ToShortDateString(), cst_nameTXT.Text, madeen_byan, Convert.ToDecimal(matloobTXT.Text), Convert.ToDecimal(matloobTXT.Text), notesTXT.Text, usertxt.Text, ""
                      //  , new_matloob, new_madfoo3, Convert.ToInt32(salesID_TXT.Text));

                    mosta7akat_tableTableAdapter1.Insert(cst_nameTXT.Text, dateTimePicker1.Value, new_matloob, new_madfoo3, 0, Convert.ToDecimal(matloobTXT.Text), usertxt.Text
                          , old_7esab, ba2y_el7esab, "مرتجع بيع", "دائن", mortaga3_num);
              
                    // MessageBox.Show("2");
                }
                else if (old_7esab < Convert.ToDecimal(matloobTXT.Text))
                {
                  //  madeen_tableTableAdapter1.Update_matloob_and_madfoo3_by_madeen_name(0, Convert.ToDecimal(matloobTXT.Text), cst_nameTXT.Text);
                    madeen_small_reportTableAdapter1.Update_matloob_AND_madfoo3_by_name(0, Convert.ToDecimal(matloobTXT.Text), cst_nameTXT.Text);

                    //sales_tableTableAdapter1.Update_discount_by_id(0, Convert.ToInt32(salesID_TXT.Text));

                    madeen_small_reportTableAdapter1.Delete_when0();
                    madeen_tableTableAdapter1.Delete_when0();
                    DialogResult re = MessageBox.Show("المبلغ المستحق على المدين أقل من قيمة المرتجع. هل تريد دفع باقي المبلغ الان ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (re == DialogResult.Yes)
                    {
                        decimal far2 = Convert.ToDecimal(matloobTXT.Text) - old_7esab;
                        string outcome_details = "مبلغ الفارق من مرتجع بيع  ";// +salesID_TXT.Text;


                        //insert outcome
                        outcome_tableTableAdapter1.Insert_outcome(dateTimePicker1.Value.ToShortDateString(), outcome_details, far2, mortaga3_num, "مرتجع بيع", cst_nameTXT.Text, usertxt.Text, notesTXT.Text, far3txt.Text);

                        //safe insert daily
                        safeTableAdapter1.Insert_safe(dateTimePicker1.Value.ToShortDateString(), -1 * far2);


                        //safe update current
                        safeTableAdapter1.Update_sarf_from_safe(far2);
                    }
                    else
                    {
                        try
                        {
                            //تحت الحساب هنا
                            decimal far2 = Convert.ToDecimal(matloobTXT.Text) - old_7esab;
                            string outcome_details = "مبلغ الفارق من مرتجع بيع  ";// +salesID_TXT.Text;

                            //insert to small madeen
                            da2n_small_reportsTableAdapter1.Insert_da2n(cst_nameTXT.Text, far2, 0);


                            //insert to madeen details
                            da2n_tableTableAdapter1.Insert_da2n_details(DateTime.Today.ToShortDateString(), cst_nameTXT.Text, outcome_details, far2, 0, "", usertxt.Text, far2, 0, mortaga3_num);

                            //insert most7kat da2neen
                            mosta7akat_da2neen_tableTableAdapter1.Insert(cst_nameTXT.Text, DateTime.Today, far2, 0, 0, 0, usertxt.Text, 0, far2, outcome_details, "مدين", 0);
                        }
                        catch { }
                        //اضافة دائن هنا
                    }
                }
            }
            catch
            {
                //if madeen doesn't exist
                old_7esab = 0;


                string outcome_details = "مبلغ مرتجع بيع  "; //+ salesID_TXT.Text;

                //insert outcome
                outcome_tableTableAdapter1.Insert_outcome(dateTimePicker1.Value.ToShortDateString(), outcome_details, Convert.ToDecimal(matloobTXT.Text), mortaga3_num, "مرتجع بيع", cst_nameTXT.Text, usertxt.Text, notesTXT.Text, far3txt.Text);

                //safe insert daily
                safeTableAdapter1.Insert_safe(dateTimePicker1.Value.ToShortDateString(), -Convert.ToDecimal(matloobTXT.Text));

                //safe update current
                safeTableAdapter1.Update_sarf_from_safe(Convert.ToDecimal(matloobTXT.Text));
            }





            //ma5zoon
            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
               
                    products_tableTableAdapter1.FillBy_pro_int_code(dataSet11.products_table,dgr.Cells[0].Value.ToString());
                    string pro_code = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                    string unit_price = dataSet11.products_table.Rows[0]["pro_bee3"].ToString();
                    decimal pro_count = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);
                    decimal pro_count_after = pro_count + Convert.ToDecimal(dgr.Cells[2].Value);
                    ma5zoon_movesTableAdapter1.Insert_ma5zoon_moves_all(dateTimePicker1.Value.ToShortDateString(), dgr.Cells[0].Value.ToString(), dgr.Cells[1].Value.ToString(), Convert.ToDecimal(dgr.Cells[2].Value),
                        Convert.ToDecimal(dgr.Cells[4].Value), pro_count, pro_count_after, "مرتجع بيع", mortaga3_num, cst_nameTXT.Text, usertxt.Text,far3txt.Text);
                
            }


            //products
            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
                
                    products_tableTableAdapter1.Update_count_BY_ID_bee3(-Convert.ToDecimal(dgr.Cells[2].Value), -Convert.ToDecimal(dgr.Cells[2].Value), dgr.Cells[0].Value.ToString(),far3txt.Text);
            }


            // update mabe3at
            decimal total_taklefa = 0;
            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
                try
                {
                    products_tableTableAdapter1.FillBy_int_code_and_far3(dataSet11.products_table, dgr.Cells[0].Value.ToString(), far3txt.Text);

                    // decimal basic_profit = Convert.ToDecimal(dataSet11.products_table.Rows[0]["nesba_saydaly"]) * Convert.ToDecimal(dgr.Cells[3].Value);
                    total_taklefa += Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_cost_price"]) * Convert.ToDecimal(dgr.Cells[2].Value);
                }
                catch
                {
                }
            }
            decimal reb7 = Convert.ToDecimal(matloobTXT.Text) - total_taklefa;


            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
                  products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, dgr.Cells[1].Value.ToString(), far3txt.Text);
                string cat = dataSet11.products_table.Rows[0]["pro_category"].ToString();

                try
                {
                //insert sales
                    sales_tableTableAdapter1.Insert_sales(mortaga3_num, dateTimePicker1.Value.ToShortDateString(), cst_nameTXT.Text, cst_phoneTXT.Text, cst_addressTXT.Text, reb7, Convert.ToDecimal(matloobTXT.Text), usertxt.Text, 0, Convert.ToDecimal(madeen_matloob_txt.Text), Convert.ToDecimal(total_txt.Text),
                        dgr.Cells[0].Value.ToString(), dgr.Cells[1].Value.ToString(), -Convert.ToDecimal(dgr.Cells[2].Value), Convert.ToDecimal(dgr.Cells[3].Value), "مرتجع", -Convert.ToDecimal(dgr.Cells[4].Value), cat
                        , 0, usertxt.Text, sales_fatora_id_txt.Text, far3txt.Text, DateTime.Now.TimeOfDay.ToString(),0);

                }
                catch { }

                int fatora_number = 0;
                if (sales_fatora_id_txt.Visible == true) 
                {
                    fatora_number = Convert.ToInt32(sales_fatora_id_txt.Text);
                }
                //insert mortaga3
                sales_mortaga3TableAdapter1.Insert_slaes_mortaga3(Convert.ToInt32(mortaga3_id_txt.Text), fatora_number, cst_nameTXT.Text, dateTimePicker1.Value.ToShortDateString(), dgr.Cells[0].Value.ToString(), dgr.Cells[1].Value.ToString(), Convert.ToDecimal(dgr.Cells[2].Value), Convert.ToDecimal(dgr.Cells[3].Value), usertxt.Text, notesTXT.Text,Convert.ToDecimal(discountTXT.Text));
         
            
            }
           
            //arba7
            string arba7_details = "خصم ربح فاتورة مرتجع " + salesID_TXT.Text;
            arba7_tableTableAdapter1.Insert_arba7(dateTimePicker1.Value.ToShortDateString(), arba7_details, -reb7, "مرتجع", mortaga3_num, "", usertxt.Text,- Convert.ToDecimal(matloobTXT.Text),-total_taklefa,far3txt.Text);

            //
            //
            
       
           //sssssssss
            
           // int num = Convert.ToInt32(mortaga3_id_txt.Text) + 1;

           // System.IO.File.WriteAllText(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\return.txt", num.ToString());

            numbers_tableTableAdapter1.Update_sales_id(far3txt.Text);

          //  MessageBox.Show("تم الحفظ بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult ree = MessageBox.Show("تم الحفظ بنجاح , هل تريد طباعة المرتجع ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ree == DialogResult.Yes)
            {


                pharmacy_dataTableAdapter1.Fill(dataSet11.pharmacy_data);
                madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet11.madeen_small_report, cst_nameTXT.Text);

                mortaga3_crystal1.Refresh();
                mortaga3_crystal1.SetDataSource(dataSet11);
                string param;

                
                param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";

                mortaga3_crystal1.SetParameterValue("test", param);


                sales_mortaga3TableAdapter1.FillBy_mortaga3_id(dataSet11.sales_mortaga3, mortaga3_num);

                StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_fwateer.txt");
                string printer_name = srr.ReadLine();

                mortaga3_crystal1.PrintOptions.PrinterName = printer_name;
                mortaga3_crystal1.PrintToPrinter(1, false, 0, 0);

               

            }
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            decimal sum = 0;
            decimal sum_keta3 = 0;
            decimal sum_dariba = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                dataGridView1.Rows[i].Cells[5].Value = (Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value) + Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value) )* Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value);

                sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);
                sum_dariba += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                sum_keta3 += Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value);



                //dataGridView1.Rows[i].Cells[6].Value = (Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value) * Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value)) + ((Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value) * Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value)) * Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value));
                //sum_dariba += Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value) * (Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value) * Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value));
                //sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value) * Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
                //sum_items += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
            }
            egmalyTXT.Text = Convert.ToString(sum);
            total_tax_txt.Text = sum_dariba.ToString("0.00");
            matloobTXT.Text = (sum+sum_dariba).ToString("0.00");

            items_count_txt.Text = dataGridView1.Rows.Count.ToString();
            keta3_txt.Text = sum_keta3.ToString();

            try
            {
                if (discountTXT.Text == "")
                {
                    discountTXT.Text = "0";
                }
                decimal matloob = Convert.ToDecimal(egmalyTXT.Text) - Convert.ToDecimal(discountTXT.Text);
                matloobTXT.Text = matloob.ToString();
            }
            catch { }

            try 
            {
                total_txt.Text = (Convert.ToDecimal(madeen_matloob_txt.Text) - Convert.ToDecimal(matloobTXT.Text)).ToString();
            }
            catch { }

            try
            {
                numbers_tableTableAdapter1.FillBy_stock(dataSet11.Numbers_table,far3txt.Text);
                mortaga3_id_txt.Text = dataSet11.Numbers_table.Rows[0]["sales_ID"].ToString();
            }
            catch { }
        }

        private void find_cst() 
        {
            try
            {


                madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet11.madeen_small_report, cst_nameTXT.Text);
                madeen_matloob_txt.Text = dataSet11.madeen_small_report.Rows[0]["madeen_small_ba2y"].ToString();

                dataGridView2.Rows.Clear();
                madeen_tableTableAdapter1.FillBy_by_madeen(dataSet11.madeen_table, cst_nameTXT.Text);

                if (dataSet11.madeen_table.Rows.Count > 0)
                {
                    foreach (DataRow dr in dataSet11.madeen_table)
                    {
                        if (dr["pay_status"].ToString() == "not paid")
                        {
                            dataGridView2.Rows.Add(dr["kest_number"].ToString(), Convert.ToDateTime(dr["est7kak_date"]).ToShortDateString(), dr["kest_cost"].ToString(), "old");
                        }
                    }
                }
            }
            catch
            {
                madeen_matloob_txt.Text = "0";
            }



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

            suggest_product();
        }
        private void cst_nameTXT_TextChanged(object sender, EventArgs e)
        {
            if (cst_nameTXT.Focused == true)
            {
                find_cst();
            }
        }

        private void matloobTXT_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void egmalyTXT_TextChanged(object sender, EventArgs e)
        {
            try
            {

                dataGridView2.AllowUserToAddRows = false;
               
                decimal matloob_gdeed=Convert.ToDecimal(madeen_matloob_txt.Text) - Convert.ToDecimal(egmalyTXT.Text);
                decimal kest_cost = matloob_gdeed / (Convert.ToDecimal(dataGridView2.Rows.Count));
               
                foreach (DataGridViewRow dgr in dataGridView2.Rows)
                {
                    dgr.Cells[2].Value = kest_cost.ToString();

                }
                dataGridView2.AllowUserToAddRows = true;
               
            }
            catch { }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                }
            }
            catch { MessageBox.Show("قم بتحديد العنصرالمراد حذفه"); }
        }

        private void sales_mortaga3_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;

            suggest_cst_name();

            try
            {
                numbers_tableTableAdapter1.FillBy_stock(dataSet11.Numbers_table,far3txt.Text);
                mortaga3_id_txt.Text = dataSet11.Numbers_table.Rows[0]["sales_ID"].ToString();
            }
            catch { }
            find_cst();

            string tax = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\tax.txt").First();
            if (tax == "yes")
            {
                dataGridView1.Columns[4].Visible = true;
                total_tax_txt.Visible = true;
                label21.Visible = true;
            }
            else
            {
                dataGridView1.Columns[4].Visible = false;

                total_tax_txt.Visible = false;
                label21.Visible = false;
            }

            string mortaga3_type = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\mortaga3_type.txt").First();

            if (mortaga3_type == "برقم الفاتورة")
            {
                label20.Visible = true;
                sales_fatora_id_txt.Visible = true;
                sales_fatora_id_txt.Focus();
            }
            else
            {
                label20.Visible = false;
                sales_fatora_id_txt.Visible = false;
            }
        }
        //private void read_num()
        //{
        //    int counter = 0;
        //    string line;

        //    // Read the file and display it line by line.  
        //    System.IO.StreamReader file =
        //        new System.IO.StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\return.txt", Encoding.Default, true);
        //    while ((line = file.ReadLine()) != null)
        //    {
        //        mortaga3_id_txt.Text = line.ToString();
        //        counter++;
        //    }

        //    file.Close();
        //}



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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                try
                {
                    products_tableTableAdapter1.FillBy_pro_int_code(dataSet11.products_table, selectedRow.Cells[0].Value.ToString());
                    if (dataSet11.products_table.Rows.Count > 0)
                    {
                        raseed_txt.Text = dataSet11.products_table.Rows[0]["pro_count"].ToString();
                        sales_tableTableAdapter1.FillBy_last_sell_date(dataSet11.sales_table,cst_nameTXT.Text,selectedRow.Cells[1].Value.ToString());
                        last_date_txt.Value =Convert.ToDateTime(dataSet11.sales_table.Rows[0]["sales_date"]);//.ToString();
                    }
                    else
                    {
                        raseed_txt.Text = "";
                    }

                }
                catch { }
                if (e.ColumnIndex == 9)
                {
                   

                    DialogResult re = MessageBox.Show("هل تريد حذف الصنف  " + selectedRow.Cells[1].Value.ToString() + " ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (re == DialogResult.Yes)
                    {
                        dataGridView1.Rows.Remove(selectedRow);
                    }
                }
            }
            catch { }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            get_products_from_sales();
        }

        private void cst_phoneTXT_TextChanged(object sender, EventArgs e)
        {
            if (cst_phoneTXT.Focused == true)
            {
                customersTableAdapter1.FillBy_phone(dataSet11.customers, cst_phoneTXT.Text);
                if (dataSet11.customers.Rows.Count > 0)
                {
                    try
                    {
                        cst_nameTXT.Text = dataSet11.customers.Rows[0]["cst_name"].ToString();
                        //  cst_phoneTXT.Text = dataSet11.customers.Rows[0]["cst_phone"].ToString();
                        cst_addressTXT.Text = dataSet11.customers.Rows[0]["cst_address"].ToString();

                        madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet11.madeen_small_report, cst_nameTXT.Text);

                        if (dataSet11.madeen_small_report.Rows.Count > 0)
                        {
                            madeen_matloob_txt.Text = dataSet11.madeen_small_report.Rows[0]["madeen_small_ba2y"].ToString();

                        }
                        else
                        {
                            madeen_matloob_txt.Text = "0";
                        }
                    }
                    catch { }
                }
                else
                {
                    //notesTXT.Text = "";
                    ////  daftartxt.Text = "";
                    //// hesab_sab2_txt.Text = "";
                    //cst_nameTXT.Text = "";
                    //cst_addressTXT.Text = "";
                }

                suggest_product();
            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            raseed_txt.Text = "";
        }

        private void cst_code_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                customersTableAdapter1.FillBy_id(dataSet11.customers, Convert.ToInt32(cst_code_txt.Text));

                cst_nameTXT.Text = dataSet11.customers.Rows[0]["cst_name"].ToString();
                cst_nameTXT_TextChanged(sender, e);
                //cst_phoneTXT.Text = dataSet11.customers.Rows[0]["cst_phone"].ToString();
                //cst_addressTXT.Text = dataSet11.customers.Rows[0]["cst_address"].ToString();
                //notesTXT.Text = dataSet11.customers.Rows[0]["cst_notes"].ToString();
                //try
                //{
                //    madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet11.madeen_small_report, cst_nameTXT.Text);
                //    madeen_matloob_txt.Text = dataSet11.madeen_small_report.Rows[0]["madeen_small_ba2y"].ToString();

                //}
                //catch
                //{ }

                suggest_product();
            }
            catch
            {

                cst_nameTXT.Text = "";
                cst_phoneTXT.Text = "";
                cst_addressTXT.Text = "";
                notesTXT.Text = "";
                madeen_matloob_txt.Text = "0";
            }
            
        }

        private void sales_fatora_id_txt_TextChanged(object sender, EventArgs e)
        {

            try
            {
                sales_tableTableAdapter1.FillBy_ID_stock(dataSet11.sales_table, Convert.ToInt32(sales_fatora_id_txt.Text),far3txt.Text);
                cst_nameTXT.Text = dataSet11.sales_table.Rows[0]["sales_cst_name"].ToString();
                cst_phoneTXT.Text = dataSet11.sales_table.Rows[0]["sales_cst_phone"].ToString();
                cst_addressTXT.Text = dataSet11.sales_table.Rows[0]["sales_cst_address"].ToString();
                discountTXT.Text = dataSet11.sales_table.Rows[0]["sales_discount"].ToString();
                fatora_type.Text = dataSet11.sales_table.Rows[0]["sales_fatora_type"].ToString();
                find_cst();
                suggest_product();
            }
            catch { }
        }

        private void total_tax_txt_TextChanged(object sender, EventArgs e)
        {

        }

        

    }
}
