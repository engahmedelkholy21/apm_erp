using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;


namespace pharma_manage
{
    public partial class buy_nesba : Form
    {
        public buy_nesba()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                decimal sum = 0;
                decimal sum_keta3 = 0;

                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    dataGridView1.Rows[i].Cells[6].Value =Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value)-(Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value)* Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value)/100) ;


                    dataGridView1.Rows[i].Cells[7].Value = Convert.ToDecimal(dataGridView1.Rows[i].Cells[6].Value) * Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);

                    sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[7].Value);

                    sum_keta3 += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
                }
                egmalyTXT.Text = Convert.ToString(sum.ToString("0.00"));
                count_pieces_txt.Text = sum_keta3.ToString();
            }
            catch { }
            try
            {
                if (discount_txt.Text == "")
                {
                    discount_txt.Text = "0";
                    matloobTXT.Text = (Convert.ToDecimal(egmalyTXT.Text) - Convert.ToDecimal(discount_txt.Text)).ToString();
                }
                else
                {
                    matloobTXT.Text = (Convert.ToDecimal(egmalyTXT.Text) - Convert.ToDecimal(discount_txt.Text)).ToString();

                }
            }
            catch { }
        }

        private void cst_nameTXT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                mwardeenTableAdapter1.FillBy_mwared_name(dataSet11.mwardeen, cst_nameTXT.Text);
                cst_phoneTXT.Text = dataSet11.mwardeen.Rows[0]["mwared_phone"].ToString();
                cst_addressTXT.Text = dataSet11.mwardeen.Rows[0]["mwared_address"].ToString();

                da2n_small_reportsTableAdapter1.FillBy_da2n_small_name(dataSet11.da2n_small_reports, cst_nameTXT.Text);
                if (dataSet11.da2n_small_reports.Rows.Count > 0) 
                {
                    hesab_sabek.Text = dataSet11.da2n_small_reports.Rows[0]["da2n_small_ba2y"].ToString();
                }
                else 
                {
                    hesab_sabek.Text = "0";
                }



            }
            catch { }
        }

        private void product_nameTXT_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = null;
            try
            {
                products_tableTableAdapter1.FillBy_name(dataSet11.products_table, product_nameTXT.Text);
                if (dataSet11.products_table.Rows.Count > 0)
                {
                    unit_price_txt.Text = dataSet11.products_table[0]["pro_bee3"].ToString();
                    cost_txt.Text = dataSet11.products_table.Rows[0]["pro_cost_price"].ToString();
                  
                    decimal nesba = 100 - ((Convert.ToDecimal(cost_txt.Text) / Convert.ToDecimal(unit_price_txt.Text)) * 100);
                    discount_nesba_txt.Text = nesba.ToString();
                    int_code_txt.Text = dataSet11.products_table[0]["pro_int_code"].ToString();
                    category_txt.Text = dataSet11.products_table[0]["pro_category"].ToString();
                   
                }
                //if (dataSet11.products_table.Rows.Count <= 0)
                //{
                //    //products_tableTableAdapter1.FillBy_pro_int_code(dataSet11.products_table, product_nameTXT.Text);
                //    //unit_price_txt.Text = dataSet11.products_table[0]["pro_cost_price"].ToString();
                //    //gomla_gomla_txt.Text = dataSet11.products_table.Rows[0]["pro_gomla_gomla"].ToString();
                //    //int_code_txt.Text = dataSet11.products_table[0]["pro_int_code"].ToString();
                //    //product_nameTXT.Text = dataSet11.products_table[0]["pro_name"].ToString();
                //    //category_txt.Text = dataSet11.products_table[0]["pro_category"].ToString();
                //}
                if (dataSet11.products_table.Rows.Count <= 0)
                {
                    unit_price_txt.Text = "";
                   // gomla_gomla_txt.Text ="";
                    int_code_txt.Text = "";
                   // product_nameTXT.Text = "";
                    category_txt.Text ="";
                }

                //pieces_in_packet_txt.Text = dataSet11.products_table[0]["pro_pieces_in_packet"].ToString();
            }
            catch
            {
                label18.Visible = false;
                //label16.Visible = false;
                ////pieces_in_packet_txt.Visible = false;
                stock_txt.Visible = false;
                category_txt.Visible = false;
                label19.Visible = false;
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString() == product_nameTXT.Text)
                    {
                        MessageBox.Show("المنتج موجود بالفعل");
                        product_nameTXT.Select();
                        return;
                    }


                }
                if (countTXT.Text == "")
                {
                    MessageBox.Show("أدخل الكمية");
                    countTXT.Select();
                    return;
                }

                if (unit_price_txt.Text == "")
                {
                    MessageBox.Show("أدخل سعر الوحدة");
                    unit_price_txt.Select();
                    return;
                }

                categoryTableAdapter.FillBy_name(dataSet11.Category, category_txt.Text);
                if (dataSet11.Category.Rows.Count <= 0)
                {
                    categoryTableAdapter.Insert(category_txt.Text, 0, "", 0);
                }
                category_txt.Items.Clear();
                this.categoryTableAdapter.Fill(this.dataSet11.Category);
                foreach (DataRow dr in dataSet11.Category.Rows)
                {
                    category_txt.Items.Add(dr["Category_name"].ToString());
                }


                string price_after;
                string price_before;
                string nesba;
                if (discount_nesba_txt.Text != "" && Convert.ToDecimal(discount_nesba_txt.Text) > 0)
                {
                    decimal price_after_discount_num = Convert.ToDecimal(unit_price_txt.Text) - (Convert.ToDecimal(unit_price_txt.Text) * (Convert.ToDecimal(discount_nesba_txt.Text) / 100));
                    price_after = price_after_discount_num.ToString();
                    price_before = unit_price_txt.Text;
                    nesba = discount_nesba_txt.Text;

                }
                else
                {
                    price_after = cost_txt.Text;
                    price_before = cost_txt.Text;
                    nesba = "0";
                }


                products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, product_nameTXT.Text, stock_txt.Text);
                if (dataSet11.products_table.Rows.Count <= 0)
                {
                    products_tableTableAdapter1.FillBy_int_code_and_far3(dataSet11.products_table, int_code_txt.Text, stock_txt.Text);
                }
                if (dataSet11.products_table.Rows.Count <= 0)
                {

                    // product doesn't exist
                    products_tableTableAdapter1.Insert_product(product_nameTXT.Text, category_txt.Text, Convert.ToDecimal(price_after), Convert.ToDecimal(unit_price_txt.Text), Convert.ToDecimal(0), Convert.ToDecimal(0), dateTimePicker1.Value.ToShortDateString(),
                              "", "", cst_nameTXT.Text, cst_phoneTXT.Text, usertxt.Text, Convert.ToDecimal(0), stock_txt.Text, Convert.ToDecimal(1)
                              , Convert.ToDecimal(0), Convert.ToDecimal(unit_price_txt.Text), Convert.ToDecimal(unit_price_txt.Text), "", "تم الجرد", dateTimePicker1.Value.ToShortDateString());
                  
                    products_tableTableAdapter1.FillBy_name(dataSet11.products_table, product_nameTXT.Text);
                    int intcode = Convert.ToInt32(dataSet11.products_table.Rows[0]["pro_ID"].ToString());
                    products_tableTableAdapter1.Update_int_code_by_id(intcode.ToString(), intcode);
                }
                else //product exist
                {
                    products_tableTableAdapter1.Update_cost_and_bee3_and_gmhour_and_gomla_gomla(Convert.ToDecimal(price_after), Convert.ToDecimal(unit_price_txt.Text), Convert.ToDecimal(unit_price_txt.Text), Convert.ToDecimal(unit_price_txt.Text), product_nameTXT.Text);

                }


                products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, product_nameTXT.Text, stock_txt.Text);
                if (dataSet11.products_table.Rows.Count <= 0)
                {
                    products_tableTableAdapter1.FillBy_int_code_and_far3(dataSet11.products_table, int_code_txt.Text, stock_txt.Text);
                }

                string pro_code = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                string product_name = dataSet11.products_table.Rows[0]["pro_name"].ToString();

                dataGridView1.Rows.Add((dataGridView1.Rows.Count + 1).ToString(), pro_code, product_name, countTXT.Text, price_before, nesba, price_after, "", true, countTXT.Text);
                product_nameTXT.Clear(); countTXT.Clear(); unit_price_txt.Clear(); int_code_txt.Clear(); cost_txt.Clear(); discount_nesba_txt.Clear();
                product_nameTXT.Focus();

                if (dataGridView1.Columns.Count == 10)
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
            catch { }
            //////////////////////////////////////////////////////////////
            //////////////////
            ///////////////////
            //////////////////////
            
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

        private void check_mwared()
        {
            this.mwardeenTableAdapter1.Fill(this.dataSet11.mwardeen);
            DataTable tbl = (DataTable)dataSet11.mwardeen;

            bool contains = tbl.AsEnumerable()
               .Any(row => cst_nameTXT.Text == row.Field<String>("mwared_name"));

            DataRow[] foundAuthors = tbl.Select("mwared_name = '" + cst_nameTXT.Text + "'");
            if (foundAuthors.Length == 0)
            {
                mwardeenTableAdapter1.Insert(cst_nameTXT.Text, cst_phoneTXT.Text, cst_addressTXT.Text, "");
            }

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
        }

        string fatora_id;
        private void save_fatora()
        {
            check_mwared();
            if (madfoo3TXT.Text == "")
            {
                MessageBox.Show("ادخل المبلغ المدفوع");
                madfoo3TXT.Focus();
                return;
            }
            if (salesID_TXT.Text == "")
            {
                MessageBox.Show("ادخل رقم الفاتورة");
                salesID_TXT.Focus();
                return;
            }

            try
            {
                decimal sum = 0;
                decimal sum_keta3 = 0;

                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    try
                    {
                        dataGridView1.Rows[i].Cells[6].Value = Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value) - (Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value) * Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value) / 100);


                        dataGridView1.Rows[i].Cells[7].Value = Convert.ToDecimal(dataGridView1.Rows[i].Cells[6].Value) * Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);

                        sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[7].Value);

                        sum_keta3 += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
                    }
                    catch 
                    {
                        MessageBox.Show("برجاء مراجعة الصنف " + dataGridView1.Rows[i].Cells[1].Value.ToString());
                       dataGridView1.Rows[i].Selected = true;;
                        return;
                    }
                }
                
            }
            catch 
            {

            }
            fatora_id = salesID_TXT.Text;
            //da2n 
            //  da2n_tableTableAdapter1.Delete_when_ba2y0();
            da2n_small_reportsTableAdapter1.Delete_when0();
            da2n_small_reportsTableAdapter1.FillBy_da2n_small_name(dataSet11.da2n_small_reports, cst_nameTXT.Text);

            try
            {
                //if da2n exist

                if (Convert.ToDecimal(madfoo3TXT.Text) > Convert.ToDecimal(matloobTXT.Text))
                {
                    decimal far2 = Convert.ToDecimal(madfoo3TXT.Text) - Convert.ToDecimal(matloobTXT.Text);

                    string _old_matloob = dataSet11.da2n_small_reports.Rows[0]["da2n_small_matloob"].ToString();
                    string _old_madfoo3 = dataSet11.da2n_small_reports.Rows[0]["da2n_small_madfoo3"].ToString();
                    string _old_ba2y = dataSet11.da2n_small_reports.Rows[0]["da2n_small_ba2y"].ToString();

                    /////////////
                    //////////
                    ////////////
                    string details = "مبلغ تنزيل من الحساب مع فاتورة رقم " + fatora_id;


                    da2n_small_reportsTableAdapter1.FillBy_da2n_small_name(dataSet11.da2n_small_reports, cst_nameTXT.Text);
                    decimal matloob_before = Convert.ToDecimal(dataSet11.da2n_small_reports.Rows[0]["da2n_small_matloob"]);
                    decimal madfoo3_before = Convert.ToDecimal(dataSet11.da2n_small_reports.Rows[0]["da2n_small_madfoo3"]);
                    decimal ba2y_before = matloob_before - madfoo3_before;





                    decimal matloob_all = Convert.ToDecimal(dataSet11.da2n_small_reports.Rows[0]["da2n_small_matloob"]);
                    decimal madfoo3_all = Convert.ToDecimal(dataSet11.da2n_small_reports.Rows[0]["da2n_small_madfoo3"]) + far2;
                    decimal ba2y_all = matloob_all - madfoo3_all;






                    //insert madeen details
                    // da2n_tableTableAdapter1.Insert_da2n_details(dateTimePicker1.Value.ToShortDateString(), da2n_nameTXT.Text, details, 0, Convert.ToDecimal(morad_daf3ohTXT.Text), notesTXT.Text, usertxt.Text, Convert.ToDecimal(matloobtxt.Text), Convert.ToDecimal(madfoo3txt.Text), 0);

                    mosta7akat_da2neen_tableTableAdapter1.Insert(cst_nameTXT.Text, dateTimePicker1.Value, matloob_all, madfoo3_all, 0, far2, usertxt.Text
                        , ba2y_before, ba2y_all, details, "دائن", 0);


                    //update madeen small report
                    da2n_small_reportsTableAdapter1.Update_madfoo3_by_name(far2, cst_nameTXT.Text);


                    //string outcome_details = "مبلغ من فاتورة شراء رقم " + fatora_id;




                    outcome_tableTableAdapter1.Insert_outcome(dateTimePicker1.Value.ToShortDateString(), details, far2, Convert.ToInt32(fatora_id), "دفعات دائنين", cst_nameTXT.Text, usertxt.Text, "", stock_txt.Text);


                    //safe_ upadate
                    safeTableAdapter1.Update_sarf_from_safe(Convert.ToDecimal(far2));

                    //current
                    safeTableAdapter1.Insert_safe(dateTimePicker1.Value.ToShortDateString(), -far2);



                    madfoo3TXT.Text = matloobTXT.Text;



                    /////////////
                    //////////
                    ////////////
                }




                string da2n_byan = "مبلغ فاتورة رقم " + fatora_id;


                da2n_small_reportsTableAdapter1.FillBy_da2n_small_name(dataSet11.da2n_small_reports, cst_nameTXT.Text);
                decimal matloob_before2 = Convert.ToDecimal(dataSet11.da2n_small_reports.Rows[0]["da2n_small_matloob"]);
                decimal madfoo3_before2 = Convert.ToDecimal(dataSet11.da2n_small_reports.Rows[0]["da2n_small_madfoo3"]);
                decimal ba2y_before2 = matloob_before2 - madfoo3_before2;





                decimal matloob_all2 = Convert.ToDecimal(dataSet11.da2n_small_reports.Rows[0]["da2n_small_matloob"]) + Convert.ToDecimal(matloobTXT.Text);
                decimal madfoo3_all2 = Convert.ToDecimal(dataSet11.da2n_small_reports.Rows[0]["da2n_small_madfoo3"]) + Convert.ToDecimal(madfoo3TXT.Text);
                decimal ba2y_all2 = matloob_all2 - madfoo3_all2;






                //insert madeen details
                // da2n_tableTableAdapter1.Insert_da2n_details(dateTimePicker1.Value.ToShortDateString(), da2n_nameTXT.Text, details, 0, Convert.ToDecimal(morad_daf3ohTXT.Text), notesTXT.Text, usertxt.Text, Convert.ToDecimal(matloobtxt.Text), Convert.ToDecimal(madfoo3txt.Text), 0);

                mosta7akat_da2neen_tableTableAdapter1.Insert(cst_nameTXT.Text, dateTimePicker1.Value, matloob_all2, madfoo3_all2, Convert.ToDecimal(matloobTXT.Text), Convert.ToDecimal(madfoo3TXT.Text), usertxt.Text
                    , ba2y_before2, ba2y_all2, da2n_byan, "دائن", Convert.ToInt32(fatora_id));

                //da2n small report update
                da2n_small_reportsTableAdapter1.Update_matloob_AND_madfoo3_BY_name(Convert.ToDecimal(matloobTXT.Text), Convert.ToDecimal(madfoo3TXT.Text), cst_nameTXT.Text);
                da2n_small_reportsTableAdapter1.FillBy_da2n_small_name(dataSet11.da2n_small_reports, cst_nameTXT.Text);

            }
            catch
            {
                //if da2n doesn't exist
                if (Convert.ToDecimal(madfoo3TXT.Text) < Convert.ToDecimal(matloobTXT.Text))
                {
                    //madeen small report
                    da2n_small_reportsTableAdapter1.Insert_da2n(cst_nameTXT.Text, Convert.ToDecimal(matloobTXT.Text), Convert.ToDecimal(madfoo3TXT.Text));

                    //madeen details insert
                    string da2n_byan = "مبلغ من فاتورة شراء رقم " + fatora_id;


                    decimal matloob_before = 0;
                    decimal madfoo3_before = 0;
                    decimal ba2y_before = 0;

                    decimal matloob_all = Convert.ToDecimal(matloobTXT.Text);
                    decimal madfoo3_all = Convert.ToDecimal(madfoo3TXT.Text);
                    decimal ba2y_all = matloob_all - madfoo3_all;

                    //insert most7kat da2neen
                    mosta7akat_da2neen_tableTableAdapter1.Insert(cst_nameTXT.Text, DateTime.Today, matloob_all, madfoo3_all, matloob_all, Convert.ToDecimal(madfoo3TXT.Text), usertxt.Text
                       , ba2y_before, ba2y_all, da2n_byan, "مدين", 0);

                }
            }





            //bonus
            //foreach (DataGridViewRow dgr in dataGridView1.Rows)
            //{
            //     products_tableTableAdapter1.FillBy_pro_int_code(dataSet11.products_table, Convert.ToInt32(dgr.Cells[1].Value.ToString()));
            //    string pro_id = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();

            //    products_tableTableAdapter1.Update_count_BY_ID_buy(Convert.ToDecimal(dgr.Cells[7].Value), pro_id);
            //}

            //ma5zoon

            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
                products_tableTableAdapter1.FillBy_name(dataSet11.products_table, dgr.Cells[2].Value.ToString());
                string pro_code = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                decimal pro_count = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);
                decimal pro_count_after = pro_count + Convert.ToDecimal(dgr.Cells[3].Value);
                ma5zoon_movesTableAdapter1.Insert_ma5zoon_moves_all(dateTimePicker1.Value.ToShortDateString(), dgr.Cells[1].Value.ToString(), dgr.Cells[2].Value.ToString(), Convert.ToDecimal(dgr.Cells[3].Value),
                    Convert.ToDecimal(dgr.Cells[7].Value), pro_count, pro_count_after, "شراء", Convert.ToInt32(salesID_TXT.Text), cst_nameTXT.Text, usertxt.Text, stock_txt.Text);
            }

            //products

            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
                try
                {
                    products_tableTableAdapter1.FillBy_pro_int_code(dataSet11.products_table, dgr.Cells[1].Value.ToString());
                    // MessageBox.Show(dgr.Cells[2].Value.ToString());

                    string pro_id = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                    products_tableTableAdapter1.Update_count_BY_ID_buy(Convert.ToDecimal(dgr.Cells[3].Value), Convert.ToDecimal(dgr.Cells[3].Value), pro_id, stock_txt.Text);
                }
                catch
                {
                    // products_tableTableAdapter1.Insert_product(
                }
            }
            //purchases
            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
                //purchases_tableTableAdapter1.Insert(Convert.ToInt32(salesID_TXT.Text), dateTimePicker1.Value.ToShortDateString(), cst_nameTXT.Text, cst_phoneTXT.Text, cst_addressTXT.Text
                //    , Convert.ToDecimal(madfoo3TXT.Text), usertxt.Text, dgr.Cells[1].Value.ToString(), dgr.Cells[2].Value.ToString(),
                //    Convert.ToDecimal(dgr.Cells[3].Value), Convert.ToDecimal(dgr.Cells[6].Value), notesTXT.Text, Convert.ToDecimal(discount_txt.Text), Convert.ToDecimal(dgr.Cells[4].Value), Convert.ToDecimal(dgr.Cells[5].Value));

                purchases_tableTableAdapter1.Insert_Purchases(Convert.ToInt32(salesID_TXT.Text), dateTimePicker1.Value.ToShortDateString(), cst_nameTXT.Text, cst_phoneTXT.Text, cst_addressTXT.Text
                     , Convert.ToDecimal(madfoo3TXT.Text), usertxt.Text, dgr.Cells[1].Value.ToString(), dgr.Cells[2].Value.ToString(),
                     Convert.ToDecimal(dgr.Cells[3].Value), Convert.ToDecimal(dgr.Cells[6].Value), notesTXT.Text, Convert.ToDecimal(discount_txt.Text), stock_txt.Text, Convert.ToDecimal(dgr.Cells[4].Value), Convert.ToDecimal(dgr.Cells[5].Value));
         
            }

            decimal outcome_cost;

            //if (Convert.ToDecimal(madfoo3TXT.Text) > Convert.ToDecimal(matloobTXT.Text))
            //{
            //    outcome_cost = Convert.ToDecimal(matloobTXT.Text);
            //}
            //else
            //{
            outcome_cost = Convert.ToDecimal(madfoo3TXT.Text);
            // }

            string outcome_details = "مبلغ من فاتورة شراء رقم " + salesID_TXT.Text;

            outcome_tableTableAdapter1.Insert_outcome(dateTimePicker1.Value.ToShortDateString(), outcome_details, outcome_cost, Convert.ToInt32(salesID_TXT.Text), "شراء", cst_nameTXT.Text, usertxt.Text, notesTXT.Text, stock_txt.Text);


            //safe_ upadate
            safeTableAdapter1.Update_sarf_from_safe(Convert.ToDecimal(madfoo3TXT.Text));

            //current
            safeTableAdapter1.Insert_safe(dateTimePicker1.Value.ToShortDateString(), -Convert.ToDecimal(madfoo3TXT.Text));

            string after_buy = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\after_buy.txt").First();
            if (after_buy == "yes")
            {

                DialogResult re = MessageBox.Show("تم الحفظ بنجاح هل تريد طباعة الباركود", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (re == DialogResult.Yes)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
        }
            //    else { this.Close(); }
            //}
            MessageBox.Show("تم الحفظ بنجاح");
            if (type_txt.Text != "تعديل")
            {
                numbers_tableTableAdapter1.Update_purchase_ID(stock_txt.Text);
            }


            //add_serial a = new add_serial();
            //a.usertxt.Text = usertxt.Text;
            //a.ShowDialog();


            this.Close();
        }
        //customers
        //-insert or no


        private void delete_fatora()
        {

            //da2n 
            da2n_small_reportsTableAdapter1.FillBy_da2n_small_name(dataSet11.da2n_small_reports, cst_nameTXT.Text);

            try
            {
                //if da2n exist

                //da2n small report update
                da2n_small_reportsTableAdapter1.Update_matloob_AND_madfoo3_BY_name(-oldmatloob, -oldmdfoo3, cst_nameTXT.Text);
                da2n_small_reportsTableAdapter1.FillBy_da2n_small_name(dataSet11.da2n_small_reports, cst_nameTXT.Text);
                decimal new_matloob = Convert.ToDecimal(dataSet11.da2n_small_reports.Rows[0]["da2n_small_matloob"]);
                decimal new_madfoo3 = Convert.ToDecimal(dataSet11.da2n_small_reports.Rows[0]["da2n_small_madfoo3"]);


                da2n_tableTableAdapter1.Update_matloob_AND_madfoo3_By_da2n_name(-oldmatloob, -oldmdfoo3, cst_nameTXT.Text);



                da2n_tableTableAdapter1.FillBy_name(dataSet11.da2n_table, cst_nameTXT.Text);
                //da2n details insert
                string da2n_byan = "مبلغ من فاتورة شراء رقم " + salesID_TXT.Text;
                da2n_tableTableAdapter1.Delete_by_fatora_id(Convert.ToInt32(salesID_TXT.Text));
                //da2n_tableTableAdapter1.Insert_da2n_details(dateTimePicker1.Value.ToShortDateString(), cst_nameTXT.Text, da2n_byan, Convert.ToDecimal(matloobTXT.Text), Convert.ToDecimal(madfoo3TXT.Text), notesTXT.Text, usertxt.Text,
                //     new_matloob, new_madfoo3, Convert.ToInt32(salesID_TXT.Text));
                da2n_tableTableAdapter1.Delete_when_ba2y0();
                //da2n details update matlob and madfo93

            }
            catch
            {
                //if da2n doesn't exist

                //if (Convert.ToDecimal(madfoo3TXT.Text) < Convert.ToDecimal(matloobTXT.Text))
                //{
                //    //madeen small report
                //    da2n_small_reportsTableAdapter1.Insert_da2n(cst_nameTXT.Text, Convert.ToDecimal(matloobTXT.Text), Convert.ToDecimal(madfoo3TXT.Text));

                //    //madeen details insert
                //    string da2n_byan = "مبلغ من فاتورة شراء رقم " + salesID_TXT.Text;
                //    da2n_tableTableAdapter1.Insert_da2n_details(dateTimePicker1.Value.ToShortDateString(), cst_nameTXT.Text, da2n_byan, Convert.ToDecimal(matloobTXT.Text), Convert.ToDecimal(madfoo3TXT.Text), notesTXT.Text, usertxt.Text,
                //     Convert.ToDecimal(matloobTXT.Text), Convert.ToDecimal(madfoo3TXT.Text), Convert.ToInt32(salesID_TXT.Text));
                //}
            }



            da2n_tableTableAdapter1.Delete_when_ba2y0();
            da2n_small_reportsTableAdapter1.Delete_when0();



            //bonus
            //foreach (DataGridViewRow dgr in dataGridView1.Rows)
            //{
            //     products_tableTableAdapter1.FillBy_pro_int_code(dataSet11.products_table, Convert.ToInt32(dgr.Cells[1].Value.ToString()));
            //    string pro_id = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();

            //    products_tableTableAdapter1.Update_count_BY_ID_buy(Convert.ToDecimal(dgr.Cells[7].Value), pro_id);
            //}


            //ma5zoon


            ma5zoon_movesTableAdapter1.Delete_by_fatora_ID(Convert.ToInt32(salesID_TXT.Text));




            //products
            purchases_tableTableAdapter1.FillBy_ID(dataSet11.Purchases_table, Convert.ToInt32(salesID_TXT.Text), stock_txt.Text);
            foreach (DataRow dgr in dataSet11.Purchases_table.Rows)
            {

                products_tableTableAdapter1.FillBy_pro_int_code(dataSet11.products_table, dgr["Purchases_product_ID"].ToString());

                // MessageBox.Show(dgr.Cells[2].Value.ToString());

                string pro_id = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                //    products_tableTableAdapter1.Update_count_BY_ID_bee3(Convert.ToDecimal(dgr["Purchases_product_count"]), Convert.ToInt32(pro_id));

            }
            //purchases
            purchases_tableTableAdapter1.Delete_by_id(Convert.ToInt32(salesID_TXT.Text));
            //foreach (DataGridViewRow dgr in dataGridView1.Rows)
            //{
            //    purchases_tableTableAdapter1.Insert_Purchases(Convert.ToInt32(salesID_TXT.Text), dateTimePicker1.Value.ToShortDateString(), cst_nameTXT.Text, cst_phoneTXT.Text, cst_addressTXT.Text
            //        , Convert.ToDecimal(madfoo3TXT.Text), usertxt.Text, dgr.Cells[1].Value.ToString(), dgr.Cells[2].Value.ToString(),
            //        Convert.ToDecimal(dgr.Cells[3].Value), Convert.ToDecimal(dgr.Cells[4].Value), notesTXT.Text, Convert.ToDecimal(0));
            //}



            outcome_tableTableAdapter1.Delete_by_fatora_id(Convert.ToInt32(salesID_TXT.Text),stock_txt.Text);



            //safe_ upadate
            safeTableAdapter1.Update_add_to_safe(oldmdfoo3);

            //current
            safeTableAdapter1.Insert_safe(dateTimePicker1.Value.ToShortDateString(), oldmdfoo3);

        }

        string param;
        private void savebtn_Click(object sender, EventArgs e)
        {
            settings_form cc = new settings_form();
            cc.colors_form_Load(sender, e);
          
            if (cc.checkBox1.Checked == true)
            {

                param = "yes";
            }
            else
            {
                param = "no";
            }

            if (type_txt.Text == "تعديل")
            {
                delete_fatora();

                save_fatora();
            }
            else
            {
                if (discount_txt.Text == "")
                {
                    discount_txt.Text = "0";
                }
                save_fatora();
            }
        }

        private void buy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.dataSet11.Category);
            foreach (DataRow dr in dataSet11.Category.Rows) 
            {
                category_txt.Items.Add(dr["Category_name"].ToString());
            }
            // TODO: This line of code loads data into the 'dataSet11.stock_table' table. You can move, or remove it, as needed.
            this.stock_tableTableAdapter.Fill(this.dataSet11.stock_table);
            dateTimePicker1.Value = DateTime.Today;
            suggest_mwared_name();
            suggest_product();

            pharmacy_dataTableAdapter1.Fill(dataSet11.pharmacy_data);
            label4.Text = dataSet11.pharmacy_data.Rows[0]["pharmacy_name"].ToString();

          

            if (type_txt.Text == "تعديل")
            {
                salesID_TXT.Text = "";
                salesID_TXT.Enabled = true;
                salesID_TXT.ReadOnly = false;
                salesID_TXT.Select();
            }

            try
            {
                this.numbers_tableTableAdapter1.Fill(this.dataSet11.Numbers_table);
                salesID_TXT.Text = dataSet11.Numbers_table.Rows[0]["purchases_ID"].ToString();
            }
            catch { }

            purchases_tableTableAdapter1.FillBy_ID(dataSet11.Purchases_table, Convert.ToInt32(salesID_TXT.Text),stock_txt.Text);
            if (dataSet11.Purchases_table.Rows.Count > 0)
            {
                numbers_tableTableAdapter1.Update_purchase_ID(stock_txt.Text);
            }
            try
            {
                this.numbers_tableTableAdapter1.Fill(this.dataSet11.Numbers_table);
                salesID_TXT.Text = dataSet11.Numbers_table.Rows[0]["purchases_ID"].ToString();
            }
            catch { }
        }

        private void suggest_product()
        {
            this.products_tableTableAdapter1.Fill(this.dataSet11.products_table);
            product_nameTXT.AutoCompleteMode = AutoCompleteMode.Suggest;
            product_nameTXT.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet11.products_table.Rows)
            {
                DataCollection.Add(dr["pro_name"].ToString());
            }

            product_nameTXT.AutoCompleteCustomSource = DataCollection;

        }
        private void suggest_mwared_name()
        {
            this.mwardeenTableAdapter1.Fill(this.dataSet11.mwardeen);
            cst_nameTXT.AutoCompleteMode = AutoCompleteMode.Suggest;
            cst_nameTXT.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet11.mwardeen.Rows)
            {
                DataCollection.Add(dr["mwared_name"].ToString());
            }

            cst_nameTXT.AutoCompleteCustomSource = DataCollection;

        }
        decimal oldmdfoo3;
        decimal oldmatloob;

        private void salesID_TXT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                purchases_tableTableAdapter1.FillBy_ID(dataSet11.Purchases_table, Convert.ToInt32(salesID_TXT.Text),stock_txt.Text);

                cst_nameTXT.Text = dataSet11.Purchases_table.Rows[0]["Purchases_mwared_name"].ToString();
                cst_phoneTXT.Text = dataSet11.Purchases_table.Rows[0]["Purchases_mwared_phone"].ToString();
                cst_addressTXT.Text = dataSet11.Purchases_table.Rows[0]["Purchases_mwared_address"].ToString();

                dateTimePicker1.Value = Convert.ToDateTime(dataSet11.Purchases_table.Rows[0]["Purchases_date"]);


                madfoo3TXT.Text = dataSet11.Purchases_table.Rows[0]["Purchases_madfoo3"].ToString();
                oldmdfoo3 = Convert.ToDecimal(dataSet11.Purchases_table.Rows[0]["Purchases_madfoo3"]);
                //mwazafTXT.Text = dataSet11.Purchases_table.Rows[0]["Purchases_user"].ToString();

                notesTXT.Text = dataSet11.Purchases_table.Rows[0]["sales_notes"].ToString();

                foreach (DataRow dr in dataSet11.Purchases_table.Rows)
                {
                    dataGridView1.Rows.Add((dataGridView1.Rows.Count + 1).ToString(), dr["Purchases_product_ID"].ToString(), dr["Purchases_product_name"].ToString(), dr["Purchases_product_count"].ToString(), dr["Purchases_unit_price"].ToString(), dr["sales_price_for_sell"].ToString());
                }

                decimal sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    dataGridView1.Rows[i].Cells[5].Value = Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value) * Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);

                    sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);
                }

                oldmatloob = sum;
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void countTXT_Enter(object sender, EventArgs e)
        {
            try
            {
                products_tableTableAdapter1.FillBy_name(dataSet11.products_table, product_nameTXT.Text);
               

                unit_price_txt.Text = dataSet11.products_table[0]["pro_bee3"].ToString();
                cost_txt.Text = dataSet11.products_table.Rows[0]["pro_cost_price"].ToString();

                decimal nesba = 100 - ((Convert.ToDecimal(cost_txt.Text) / Convert.ToDecimal(unit_price_txt.Text)) * 100);
                discount_nesba_txt.Text = nesba.ToString();
               
                //gomla_gomla_txt.Text = dataSet11.products_table.Rows[0]["pro_gomla_gomla"].ToString();
                //bee3_txt.Text = dataSet11.products_table[0]["pro_bee3"].ToString();
                //gmhour_txt.Text = (Convert.ToDecimal(dataSet11.products_table[0]["pro_bee3_2"]) / Convert.ToDecimal(dataSet11.products_table[0]["pro_pieces_in_packet"])).ToString();

            }
            catch
            {
                label18.Visible = true;
                //label16.Visible = true;
                //pieces_in_packet_txt.Visible = true;
                stock_txt.Visible = true;
                category_txt.Visible = true;
                label19.Visible = true;

                unit_price_txt.Text = "";
                //gomla_gomla_txt.Text = "";
                //bee3_txt.Text = "";
                //gmhour_txt.Text = "";

                //pieces_in_packet_txt.Text = "";
                int_code_txt.Text = "";
                category_txt.Text = "";
            }
        }

        private void countTXT_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = addbtn;
           
        }

        private void int_code_txt_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    products_tableTableAdapter1.FillBy_pro_int_code(dataSet11.products_table, int_code_txt.Text);
            //    unit_price_txt.Text = dataSet11.products_table[0]["pro_cost_price"].ToString();
            //    gomla_gomla_txt.Text = dataSet11.products_table.Rows[0]["pro_gomla_gomla"].ToString();
            //    //bee3_txt.Text = dataSet11.products_table[0]["pro_bee3"].ToString();
            //    //gmhour_txt.Text = (Convert.ToDecimal(dataSet11.products_table[0]["pro_bee3_2"]) / Convert.ToDecimal(dataSet11.products_table[0]["pro_pieces_in_packet"])).ToString();
            //    product_nameTXT.Text = dataSet11.products_table[0]["pro_name"].ToString();
            //    //pieces_in_packet_txt.Text = dataSet11.products_table[0]["pro_pieces_in_packet"].ToString();
            //}
            //catch
            //{ }
            ////    //label18.Visible = false;
            ////    //label16.Visible = false;
            ////    ////pieces_in_packet_txt.Visible = false;
            ////    //stock_txt.Visible = false;
            ////    //category_txt.Visible = false;
            ////    //label19.Visible = false;
            ////}
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                products_tableTableAdapter1.FillBy_name(dataSet11.products_table, selectedRow.Cells[2].Value.ToString());
                raseed_now_txt.Text = dataSet11.products_table.Rows[0]["pro_count"].ToString();
                //taklefa_txt.Text = dataSet11.products_table.Rows[0]["pro_cost_price"].ToString();
                //we7dat_txt.Text = dataSet11.products_table.Rows[0]["pro_pieces_in_packet"].ToString();
            }
            catch { }

            try
            {
                if (e.ColumnIndex == 10)
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

        private void product_nameTXT_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    this.AcceptButton = null;

                    products_tableTableAdapter1.FillBy_pro_int_code(dataSet11.products_table, product_nameTXT.Text);
                    unit_price_txt.Text = dataSet11.products_table[0]["pro_bee3"].ToString();
                    cost_txt.Text = dataSet11.products_table.Rows[0]["pro_cost_price"].ToString();
                    product_nameTXT.Text = dataSet11.products_table[0]["pro_name"].ToString();
                    decimal nesba = 100 - ((Convert.ToDecimal(cost_txt.Text) / Convert.ToDecimal(unit_price_txt.Text)) * 100);
                    discount_nesba_txt.Text = nesba.ToString();
                    int_code_txt.Text = dataSet11.products_table[0]["pro_int_code"].ToString();
                    category_txt.Text = dataSet11.products_table[0]["pro_category"].ToString();


                    countTXT.Focus();
                }
            }
            catch { }

        }

        private void unit_price_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (unit_price_txt.Focused == true)
                {
                    if (discount_nesba_txt.Text != "" && discount_nesba_txt.Text != "0")
                    {
                        decimal cost_price = Convert.ToDecimal(unit_price_txt.Text) - (Convert.ToDecimal(unit_price_txt.Text) * (Convert.ToDecimal(discount_nesba_txt.Text) / 100));
                        cost_txt.Text = cost_price.ToString();
                    }
                }

            }
            catch { }
        }

        private void discount_nesba_txt_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                if (discount_nesba_txt.Focused == true)
                {
                    if (discount_nesba_txt.Text != ""&&discount_nesba_txt.Text!="0")
                    {
                        decimal cost_price = Convert.ToDecimal(unit_price_txt.Text) - (Convert.ToDecimal(unit_price_txt.Text) * (Convert.ToDecimal(discount_nesba_txt.Text) / 100));
                        cost_txt.Text = cost_price.ToString();
                    }
                }

            }
            catch { }
        }

        private void cost_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cost_txt.Focused == true)
                {
                    if (cost_txt.Text != ""&&discount_nesba_txt.Text!="0")
                    {
                        decimal nesba =100-((Convert.ToDecimal(cost_txt.Text) / Convert.ToDecimal(unit_price_txt.Text)) * 100);
                        discount_nesba_txt.Text = nesba.ToString();
                        // decimal cost_price = Convert.ToDecimal(unit_price_txt.Text) - (Convert.ToDecimal(unit_price_txt.Text) * (Convert.ToDecimal(discount_nesba_txt.Text) / 100));
                       // cost_txt.Text = cost_price.ToString();
                    }
                }

            }
            catch { }
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                count_before_change = selectedRow.Cells[3].Value.ToString();

               // price_before_change = selectedRow.Cells[4].Value.ToString();
                //  dariba_before_change = selectedRow.Cells[6].Value.ToString();
            }
            catch { }
        }

        string count_before_change = "";

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                if (e.ColumnIndex == 3)
                {

                    if (selectedRow.Cells[3].Value.ToString() != "")
                    {
                        selectedRow.Cells[9].Value = selectedRow.Cells[3].Value.ToString();
                    }
                    else 
                    {
                        selectedRow.Cells[3].Value = count_before_change;
                    }
                }
                //  MessageBox.Show("aaa");
            }
            catch { }
        }

        private void discount_nesba_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, decimal point, backspace, and delete keys
            if (!char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.' &&
                e.KeyChar != '\b' &&
                e.KeyChar != '\u007F')
            {
                e.Handled = true;
                return;
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
                return;
            }

            // Allow only two decimal places
            if (e.KeyChar != '\b' && (sender as TextBox).Text.Contains("."))
            {
                int index = (sender as TextBox).Text.IndexOf(".");
                if ((sender as TextBox).Text.Length - index > 2)
                {
                    e.Handled = true;
                    return;
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            pharmacy_dataTableAdapter1.Fill(dataSet11.pharmacy_data);
            string ph_name = dataSet11.pharmacy_data.Rows[0]["pharmacy_name"].ToString();
            print_barcodeTableAdapter1.DeleteQuery();
            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(dgr.Cells[8].Value) == true)
                {
                    string name = dgr.Cells[2].Value.ToString();
                    products_tableTableAdapter1.FillBy_pro_int_code(dataSet11.products_table, dgr.Cells[1].Value.ToString());
                    decimal price = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_bee3"]);
                    int count = Convert.ToInt32(dgr.Cells[9].Value);
                    string pro_code = dataSet11.products_table.Rows[0]["pro_ID"].ToString();
                    for (int i = 1; i <= count; i++)
                    {
                        print_barcodeTableAdapter1.Insert("*" + pro_code + "*", name, price, ph_name);
                    }
                }
            }



            this.print_barcodeTableAdapter1.Fill(this.dataSet11.print_barcode);
            if (dataSet11.print_barcode.Rows.Count > 0)
            {
                StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode.txt");
                string printer_name = srr.ReadLine();


                string barcode_bc__yes_or_no = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_bc.txt").First();

                string barcode_type = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt").First();
                string decimals = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\decimals").First();

                if (barcode_type == "عادي")
                {

                    crystalReport21.SetDataSource(dataSet11);
                    crystalReport21.Refresh();
                    crystalReport21.SetParameterValue("price_yes_or_no", param);
                    crystalReport21.SetParameterValue("price_bc_color", barcode_bc__yes_or_no);
                    crystalReport21.SetParameterValue("decimals", decimals);

                    crystalReport21.PrintOptions.PrinterName = printer_name;
                    crystalReport21.PrintToPrinter(1, false, 0, 0);
                    crystalReport21.Dispose();
                    crystalReport21.Close();
                    crystalReport21.Refresh();
                }
                else if (barcode_type == "مقسوم")
                {

                    crystalReport2_small1.SetDataSource(dataSet11);
                    crystalReport2_small1.Refresh();
                    crystalReport2_small1.SetParameterValue("price_yes_or_no", param);
                    crystalReport2_small1.SetParameterValue("decimals", decimals);

                    crystalReport2_small1.PrintOptions.PrinterName = printer_name;
                    crystalReport2_small1.PrintToPrinter(1, false, 0, 0);
                    crystalReport2_small1.Dispose();
                    crystalReport2_small1.Close();
                    crystalReport2_small1.Refresh();
                }

            }
        }
     


    }
}

