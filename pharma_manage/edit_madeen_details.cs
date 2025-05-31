using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pharma_manage
{
    public partial class edit_madeen_details : Form
    {
        public edit_madeen_details()
        {
            InitializeComponent();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (old_status_txt.Text == "paid" && status_txt.Text == "paid"&&Convert.ToDecimal(kest_cost.Text)> Convert.ToDecimal(old_kest_txt.Text))
            {
                
                    decimal far2 = Convert.ToDecimal(kest_cost.Text) - Convert.ToDecimal(old_kest_txt.Text);
                    // update madeen small report

                    madeen_small_reportTableAdapter1.Update_matloob_AND_madfoo3_by_name(0, far2, madeen_name_txt.Text);
                    //  MessageBox.Show(selectedRow.Cells[8].Value.ToString());

                    //update madeen table ,e5sem men elly ba3do, update matloob ,update  madfoo3 feeh


                    madeen_tableTableAdapter1.Update_status_and_paid_date_and_notes__and_cost_By_kest_no_and_name("paid", paid_date_txt.Text
                        , Convert.ToDecimal(kest_cost.Text), notes_txt.Text,est7kak_txt.Text,Convert.ToInt32(kest_num_txt.Text),madeen_name_txt.Text);

                    madeen_tableTableAdapter1.Update_daftar_for_edit(daftartxt.Text, madeen_name_txt.Text);
                    
                        

                    madeen_tableTableAdapter1.Update_matloob_and_madfoo3_by_madeen_name(0, far2, madeen_name_txt.Text);
                
                    madeen_tableTableAdapter1.FillBy_madeen_name_AND_kest_num(dataSet11.madeen_table, Convert.ToInt32(kest_num_txt.Text) + 1, madeen_name_txt.Text);
                    //decimal mora7al = Convert.ToDecimal(morad_daf3ohTXT.Text) - Convert.ToDecimal(kest_cost.Text_txt.Text);
                    try
                    {
                        decimal new_mosta7ak = Convert.ToDecimal(dataSet11.madeen_table.Rows[0]["kest_cost"]) - far2;
                        string status_for_second_kest = dataSet11.madeen_table.Rows[0]["pay_status"].ToString();
                        madeen_tableTableAdapter1.Update_kest_only_by_kest_no_and_madeen_name(new_mosta7ak, Convert.ToInt32(kest_num_txt.Text)+1, madeen_name_txt.Text);
                
                    }
                    catch { }

                    //update income if current kest paid
                    string details;
                    if (tafaseel_txt.Text == "مدفوع وقت الفاتورة "+fatora_id_txt.Text)
                    {
                        income_tableTableAdapter1.Update_cost_and_date_by_fatora(Convert.ToDecimal(kest_cost.Text), paid_date_txt.Text, Convert.ToInt32(fatora_id_txt.Text),far3txt.Text);
                        sales_tableTableAdapter1.FillBy_ID_stock(dataSet11.sales_table, Convert.ToInt32(fatora_id_txt.Text),far3txt.Text);
                        try
                        {
                            decimal sum = 0;
                            decimal sum_dariba = 0;
                            for (int i = 0; i < dataSet11.sales_table.Rows.Count; ++i)
                            {
                                //dataGridView1.Rows[i].Cells[4].Value = Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value) * Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value);
                                sum_dariba += Convert.ToDecimal(dataSet11.sales_table.Rows[i]["sales_dariba"]);

                                sum += Convert.ToDecimal(dataSet11.sales_table.Rows[i]["sales_price_for_sell"]);

                            }

                            decimal egmaly_after = (sum_dariba + sum + Convert.ToDecimal(dataSet11.sales_table.Rows[0]["sales_egmaly_kest_cost"]) - Convert.ToDecimal(dataSet11.sales_table.Rows[0]["sales_discount"]));
                            // decimal  egmaly_elfatora = egmaly_after;
                            decimal new_ba2y = egmaly_after - Convert.ToDecimal(kest_cost.Text);
                            sales_tableTableAdapter1.Update_madfoo3_and_ba2y_by_sales_ID(Convert.ToDecimal(kest_cost.Text), new_ba2y, Convert.ToInt32(fatora_id_txt.Text),far3txt.Text);
                        }
                        catch { }
                      //  sales_tableTableAdapter1.Update_madfoo3_by_sales_ID(Convert.ToDecimal(kest_cost.Text), Convert.ToInt32(fatora_id_txt.Text));
                    }
                    else
                    {

                        details = "مبلغ قسط رقم " + kest_num_txt.Text + " للعميل " + madeen_name_txt.Text;
                        income_tableTableAdapter1.Update_cost_and_date_by_details(Convert.ToDecimal(kest_cost.Text), paid_date_txt.Text, details);

                    }
                    ////update income if next kest paid
                    //if (status_for_second_kest == "paid")
                    //{
                    //     int selectedrowindex1 = dataGridView1.SelectedCells[0].RowIndex;
                    //     DataGridViewRow new_selected_row = dataGridView1.Rows[selectedrowindex+1];//feh hena moshkela  non negative index
                    //     madeen_tableTableAdapter.Update_status_and_paid_date_and_notes__and_cost_By_kest_no_and_name(status_for_second_kest, new_selected_row.Cells[10].Value.ToString(), ""
                    //        , new_mosta7ak, "تم دفع مبلغ " + far2.ToString() + " مع القسط السابق", Convert.ToInt32(kest_no) + 1, search_text.Text);
                    //    int new_kest_num = Convert.ToInt32(kest_no) + 1;
                    //    //income update
                    //     string details1="مبلغ قسط رقم "+new_kest_num.ToString() +" للعميل "+search_text.Text;


                    //     income_tableTableAdapter1.Update_cost_and_date_by_details(Convert.ToDecimal(current_kest), new_selected_row.Cells[10].Value.ToString(), details1);


                    //}
                    //else 
                    //{
                    //    madeen_tableTableAdapter.Update_status_and_paid_date_and_notes__and_cost_By_kest_no_and_name(status_for_second_kest, "", ""
                    //       , new_mosta7ak, "تم دفع مبلغ " + far2.ToString() + " مع القسط السابق", Convert.ToInt32(kest_no) + 1, search_text.Text);

                    //}


                    //update safe in date paid
                    safeTableAdapter1.Update_add_to_safe(far2);
                    safeTableAdapter1.Insert_safe(paid_date_txt.Text, far2);

                    MessageBox.Show("تم التعديل بنجاح");
                    this.Close();

            }

            if (old_status_txt.Text == "paid" && status_txt.Text == "paid" && Convert.ToDecimal(kest_cost.Text) == Convert.ToDecimal(old_kest_txt.Text))
            {

                decimal far2 = Convert.ToDecimal(kest_cost.Text) - Convert.ToDecimal(old_kest_txt.Text);
                // update madeen small report

                madeen_small_reportTableAdapter1.Update_matloob_AND_madfoo3_by_name(0, far2, madeen_name_txt.Text);
                //  MessageBox.Show(selectedRow.Cells[8].Value.ToString());

                //update madeen table ,e5sem men elly ba3do, update matloob ,update  madfoo3 feeh


                madeen_tableTableAdapter1.Update_status_and_paid_date_and_notes__and_cost_By_kest_no_and_name("paid", paid_date_txt.Text,
                    Convert.ToDecimal(kest_cost.Text), notes_txt.Text, est7kak_txt.Text, Convert.ToInt32(kest_num_txt.Text), madeen_name_txt.Text);

                madeen_tableTableAdapter1.Update_daftar_for_edit(daftartxt.Text, madeen_name_txt.Text);

                madeen_tableTableAdapter1.Update_matloob_and_madfoo3_by_madeen_name(0, far2, madeen_name_txt.Text);

                madeen_tableTableAdapter1.FillBy_madeen_name_AND_kest_num(dataSet11.madeen_table, Convert.ToInt32(kest_num_txt.Text) + 1, madeen_name_txt.Text);
                //decimal mora7al = Convert.ToDecimal(morad_daf3ohTXT.Text) - Convert.ToDecimal(kest_cost.Text_txt.Text);
                try
                {
                    decimal new_mosta7ak = Convert.ToDecimal(dataSet11.madeen_table.Rows[0]["kest_cost"]) - far2;
                    string status_for_second_kest = dataSet11.madeen_table.Rows[0]["pay_status"].ToString();
                    madeen_tableTableAdapter1.Update_kest_only_by_kest_no_and_madeen_name(new_mosta7ak, Convert.ToInt32(kest_num_txt.Text) + 1, madeen_name_txt.Text);

                }
                catch { }

                //update income if current kest paid
                string details;
                if (tafaseel_txt.Text == "مدفوع وقت الفاتورة " + fatora_id_txt.Text)
                {
                    income_tableTableAdapter1.Update_cost_and_date_by_fatora(Convert.ToDecimal(kest_cost.Text), paid_date_txt.Text, Convert.ToInt32(fatora_id_txt.Text),far3txt.Text);
                    sales_tableTableAdapter1.FillBy_ID_stock(dataSet11.sales_table, Convert.ToInt32(fatora_id_txt.Text),far3txt.Text);
                    try
                    {
                        decimal sum = 0;
                        decimal sum_dariba = 0;
                        for (int i = 0; i < dataSet11.sales_table.Rows.Count; ++i)
                        {
                            //dataGridView1.Rows[i].Cells[4].Value = Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value) * Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value);
                            sum_dariba += Convert.ToDecimal(dataSet11.sales_table.Rows[i]["sales_dariba"]);

                            sum += Convert.ToDecimal(dataSet11.sales_table.Rows[i]["sales_price_for_sell"]);

                        }

                        decimal egmaly_after = (sum_dariba + sum + Convert.ToDecimal(dataSet11.sales_table.Rows[0]["sales_egmaly_kest_cost"]) - Convert.ToDecimal(dataSet11.sales_table.Rows[0]["sales_discount"]));
                        // decimal  egmaly_elfatora = egmaly_after;
                        decimal new_ba2y = egmaly_after - Convert.ToDecimal(kest_cost.Text);
                        sales_tableTableAdapter1.Update_madfoo3_and_ba2y_by_sales_ID(Convert.ToDecimal(kest_cost.Text), new_ba2y, Convert.ToInt32(fatora_id_txt.Text),far3txt.Text);
                    }
                    catch { }
                    //  sales_tableTableAdapter1.Update_madfoo3_by_sales_ID(Convert.ToDecimal(kest_cost.Text), Convert.ToInt32(fatora_id_txt.Text));
                }
                else
                {

                    details = "مبلغ قسط رقم " + kest_num_txt.Text + " للعميل " + madeen_name_txt.Text;
                    income_tableTableAdapter1.Update_cost_and_date_by_details(Convert.ToDecimal(kest_cost.Text), paid_date_txt.Text, details);

                }
                ////update income if next kest paid
                //if (status_for_second_kest == "paid")
                //{
                //     int selectedrowindex1 = dataGridView1.SelectedCells[0].RowIndex;
                //     DataGridViewRow new_selected_row = dataGridView1.Rows[selectedrowindex+1];//feh hena moshkela  non negative index
                //     madeen_tableTableAdapter.Update_status_and_paid_date_and_notes__and_cost_By_kest_no_and_name(status_for_second_kest, new_selected_row.Cells[10].Value.ToString(), ""
                //        , new_mosta7ak, "تم دفع مبلغ " + far2.ToString() + " مع القسط السابق", Convert.ToInt32(kest_no) + 1, search_text.Text);
                //    int new_kest_num = Convert.ToInt32(kest_no) + 1;
                //    //income update
                //     string details1="مبلغ قسط رقم "+new_kest_num.ToString() +" للعميل "+search_text.Text;


                //     income_tableTableAdapter1.Update_cost_and_date_by_details(Convert.ToDecimal(current_kest), new_selected_row.Cells[10].Value.ToString(), details1);


                //}
                //else 
                //{
                //    madeen_tableTableAdapter.Update_status_and_paid_date_and_notes__and_cost_By_kest_no_and_name(status_for_second_kest, "", ""
                //       , new_mosta7ak, "تم دفع مبلغ " + far2.ToString() + " مع القسط السابق", Convert.ToInt32(kest_no) + 1, search_text.Text);

                //}


                //update safe in date paid
                safeTableAdapter1.Update_add_to_safe(far2);
                safeTableAdapter1.Insert_safe(paid_date_txt.Text, far2);

                MessageBox.Show("تم التعديل بنجاح");
                this.Close();

            }
            else if (old_status_txt.Text == "paid" && status_txt.Text == "paid" && Convert.ToDecimal(kest_cost.Text) < Convert.ToDecimal(old_kest_txt.Text))
           
            {

                //   update madeen small report
                decimal far2 = Convert.ToDecimal(old_kest_txt.Text) - Convert.ToDecimal(kest_cost.Text);
                //  MessageBox.Show(far2.ToString());
                // update madeen small report

                madeen_small_reportTableAdapter1.Update_matloob_AND_madfoo3_by_name(0, -far2, madeen_name_txt.Text);
                //   update madeen table ,ra7al 3ala  elly ba3do, update matloob ,update  madfoo3 feeh
                //  update safe in date paid
                //  update income if paid


                //update madeen table ,ra7al ala elly ba3do, update matloob ,update  madfoo3 feeh

                madeen_tableTableAdapter1.Update_status_and_paid_date_and_notes__and_cost_By_kest_no_and_name("paid",paid_date_txt.Text, 
                    Convert.ToDecimal(kest_cost.Text),notes_txt.Text,est7kak_txt.Text, Convert.ToInt32(kest_num_txt.Text), madeen_name_txt.Text);

                madeen_tableTableAdapter1.Update_daftar_for_edit(daftartxt.Text, madeen_name_txt.Text);

                madeen_tableTableAdapter1.Update_matloob_and_madfoo3_by_madeen_name(0, -far2, madeen_name_txt.Text);


                madeen_tableTableAdapter1.FillBy_madeen_name_AND_kest_num(dataSet11.madeen_table, Convert.ToInt32(kest_num_txt.Text) + 1, madeen_name_txt.Text);
                //decimal mora7al = Convert.ToDecimal(morad_daf3ohTXT.Text) - Convert.ToDecimal(kest_cost.Text_txt.Text);
                try
                {
                    decimal new_mosta7ak = Convert.ToDecimal(dataSet11.madeen_table.Rows[0]["kest_cost"]) + far2;
                    string status_for_second_kest = dataSet11.madeen_table.Rows[0]["pay_status"].ToString();
                   // madeen_tableTableAdapter1.Update_status_and_paid_date_and_notes__and_cost_By_kest_no_and_name(status_for_second_kest,
                    madeen_tableTableAdapter1.Update_kest_only_by_kest_no_and_madeen_name(new_mosta7ak, Convert.ToInt32(kest_num_txt.Text)+1, madeen_name_txt.Text);
                }
                catch { }
                //update income if current kest paid
                string details;
                if (tafaseel_txt.Text == "مدفوع وقت الفاتورة " + fatora_id_txt.Text)
                {
                    income_tableTableAdapter1.Update_cost_and_date_by_fatora(Convert.ToDecimal(kest_cost.Text), paid_date_txt.Text, Convert.ToInt32(fatora_id_txt.Text), far3txt.Text);
                    sales_tableTableAdapter1.FillBy_ID_stock(dataSet11.sales_table, Convert.ToInt32(fatora_id_txt.Text),far3txt.Text);
                    try
                    {
                        decimal sum = 0;
                        decimal sum_dariba = 0;
                        for (int i = 0; i < dataSet11.sales_table.Rows.Count; ++i)
                        {
                            //dataGridView1.Rows[i].Cells[4].Value = Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value) * Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value);
                            sum_dariba += Convert.ToDecimal(dataSet11.sales_table.Rows[i]["sales_dariba"]);

                            sum += Convert.ToDecimal(dataSet11.sales_table.Rows[i]["sales_price_for_sell"]);

                        }

                        decimal egmaly_after = (sum_dariba + sum + Convert.ToDecimal(dataSet11.sales_table.Rows[0]["sales_egmaly_kest_cost"]) - Convert.ToDecimal(dataSet11.sales_table.Rows[0]["sales_discount"]));
                        // decimal  egmaly_elfatora = egmaly_after;
                        decimal new_ba2y = egmaly_after - Convert.ToDecimal(kest_cost.Text);
                        sales_tableTableAdapter1.Update_madfoo3_and_ba2y_by_sales_ID(Convert.ToDecimal(kest_cost.Text), new_ba2y, Convert.ToInt32(fatora_id_txt.Text),far3txt.Text);
                    }
                    catch { }
                }
                else
                {
                    details = "مبلغ قسط رقم " + kest_num_txt.Text + " للعميل " + madeen_name_txt.Text;
                    income_tableTableAdapter1.Update_cost_and_date_by_details(Convert.ToDecimal(kest_cost.Text), paid_date_txt.Text, details);

                }
                //update income if next kest paid
                //if (status_for_second_kest == "paid")
                //{
                //    int selectedrowindex1 = dataGridView1.SelectedCells[0].RowIndex;
                //    DataGridViewRow new_selected_row = dataGridView1.Rows[selectedrowindex + 1];
                //    madeen_tableTableAdapter.Update_status_and_paid_date_and_notes__and_cost_By_kest_no_and_name(status_for_second_kest, new_selected_row.Cells[10].Value.ToString(), ""
                //       , new_mosta7ak, "تم دفع مبلغ " + far2.ToString() + " مع القسط السابق", Convert.ToInt32(kest_no) + 1, search_text.Text);
                //    int new_kest_num = Convert.ToInt32(kest_no) + 1;
                //    //income update
                //    string details1 = "مبلغ قسط رقم " + new_kest_num.ToString() + " للعميل " + search_text.Text;


                //    income_tableTableAdapter1.Update_cost_and_date_by_details(Convert.ToDecimal(current_kest), new_selected_row.Cells[10].Value.ToString(), details1);


                //}
                //else
                //{
                //    madeen_tableTableAdapter.Update_status_and_paid_date_and_notes__and_cost_By_kest_no_and_name(status_for_second_kest, "", ""
                //       , new_mosta7ak, "تم ترحيل مبلغ " + far2.ToString() + " من القسط السابق", Convert.ToInt32(kest_no) + 1, search_text.Text);

                //}

                //update safe in date paid

                safeTableAdapter1.Update_sarf_from_safe(far2);
                safeTableAdapter1.Insert_safe(paid_date_txt.Text, -far2);

                MessageBox.Show("تم التعديل بنجاح");
                this.Close();

            }
            else if (old_status_txt.Text == "paid" && status_txt.Text != "paid" )//&& Convert.ToDecimal(kest_cost.Text) < Convert.ToDecimal(old_kest_txt.Text))
            {
                madeen_tableTableAdapter1.Update_status_and_paid_date_and_notes__and_cost_By_kest_no_and_name("not paid", "",Convert.ToDecimal(kest_cost.Text),
                    notes_txt.Text,est7kak_txt.Text, Convert.ToInt32(kest_num_txt.Text), madeen_name_txt.Text);

                madeen_tableTableAdapter1.Update_daftar_for_edit(daftartxt.Text, madeen_name_txt.Text);
                decimal far2 = Convert.ToDecimal(old_kest_txt.Text) - Convert.ToDecimal(kest_cost.Text);
                //  MessageBox.Show(far2.ToString());
                // update madeen small report

                madeen_small_reportTableAdapter1.Update_matloob_AND_madfoo3_by_name(0, -Convert.ToDecimal(old_kest_txt.Text), madeen_name_txt.Text);
                //   update madeen table ,ra7al 3ala  elly ba3do, update matloob ,update  madfoo3 feeh
                //  update safe in date paid
                //  update income if paid

                madeen_tableTableAdapter1.Update_matloob_and_madfoo3_by_madeen_name(0, -Convert.ToDecimal(old_kest_txt.Text), madeen_name_txt.Text);
                string details;
                if (tafaseel_txt.Text == "مدفوع وقت الفاتورة " + fatora_id_txt.Text)
                {
                    income_tableTableAdapter1.Update_cost_and_date_by_fatora(0, paid_date_txt.Text, Convert.ToInt32(fatora_id_txt.Text), far3txt.Text);
                }
                else
                {

                    details = "مبلغ قسط رقم " + kest_num_txt.Text + " للعميل " + madeen_name_txt.Text;
                    income_tableTableAdapter1.Delete_details_src_ID(details, "دفعات مدينين", Convert.ToInt32(fatora_id_txt.Text), far3txt.Text);
                        //Update_cost_and_date_by_details(Convert.ToDecimal(kest_cost.Text), paid_date_txt.Text, details);

                }

                safeTableAdapter1.Update_sarf_from_safe(Convert.ToDecimal(old_kest_txt.Text));
                safeTableAdapter1.Insert_safe(paid_date_txt.Text, -Convert.ToDecimal(old_kest_txt.Text));
                MessageBox.Show("تم التعديل بنجاح");
                this.Close();
            }
            else if (old_status_txt.Text == "not paid" )//&& status_txt.Text != "paid")//&& Convert.ToDecimal(kest_cost.Text) < Convert.ToDecimal(old_kest_txt.Text))
            {
                madeen_tableTableAdapter1.Update_status_and_paid_date_and_notes__and_cost_By_kest_no_and_name("not paid", "", Convert.ToDecimal(kest_cost.Text),
                    notes_txt.Text, est7kak_txt.Text,Convert.ToInt32(kest_num_txt.Text), madeen_name_txt.Text);

                madeen_tableTableAdapter1.Update_daftar_for_edit(daftartxt.Text, madeen_name_txt.Text);

                decimal far2 = Convert.ToDecimal(old_kest_txt.Text) - Convert.ToDecimal(kest_cost.Text);
                //  MessageBox.Show(far2.ToString());
                // update madeen small report

                madeen_small_reportTableAdapter1.Update_matloob_AND_madfoo3_by_name(-far2, 0, madeen_name_txt.Text);
                //   update madeen table ,ra7al 3ala  elly ba3do, update matloob ,update  madfoo3 feeh
                //  update safe in date paid
                //  update income if paid

                madeen_tableTableAdapter1.Update_matloob_and_madfoo3_by_madeen_name(-far2,0, madeen_name_txt.Text);
                
                MessageBox.Show("تم التعديل بنجاح");
                this.Close();
            }
        }

        private void edit_madeen_details_Load(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.SubscribeToLoadEvent(this);
            f1.ApplyFormStyling(this);
        }

        private void kest_num_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
