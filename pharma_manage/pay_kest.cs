using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Management;
using System.IO;


namespace pharma_manage
{
    public partial class pay_kest : Form 
    {
        public pay_kest()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;

            substringAutoCompleteTextBox1.TextBox_.KeyDown += substringAutoCompleteTextBox1_KeyDown;

            substringAutoCompleteTextBox1.TextBox_.Enter += substringAutoCompleteTextBox1_Enter;
            substringAutoCompleteTextBox1.Enter += substringAutoCompleteTextBox1_Enter;
            substringAutoCompleteTextBox1.TextBox_.Leave += substringAutoCompleteTextBox1_Leave;
            substringAutoCompleteTextBox1.Leave += substringAutoCompleteTextBox1_Leave;
            substringAutoCompleteTextBox1.Listbox_.KeyDown += substringAutoCompleteTextBox1_KeyDown;

            substringAutoCompleteTextBox1.AttachListBoxToParent(this);
        }


        int fatora_num;

        public void search_method(string name, string far3) 
        {
            try
            {
                string tamweel_code = "";
                aksat_tableTableAdapter1.FillBy_kest_cst_code_not_paid(dataSet1.aksat_table, name, far3);
                if (dataSet1.aksat_table.Rows.Count <= 0)
                {
                    aksat_tableTableAdapter1.FillBy_kest_cst_name_and_not_paid(dataSet1.aksat_table, name, far3);

                     tamweel_code = dataSet1.aksat_table.Rows[0]["kest_loan_code"].ToString();
                    name = tamweel_code;
                    substringAutoCompleteTextBox1.TextBox_.Text = tamweel_code;
                }


                cst_code_txt.Text = dataSet1.aksat_table.Rows[0]["kest_cst_code"].ToString();
                if (dataSet1.aksat_table.Rows.Count <= 0)
                {
                    aksat_tableTableAdapter1.FillBy_kest_cst_name_and_not_paid(dataSet1.aksat_table, name, far3);
                    cst_code_txt.Text = dataSet1.aksat_table.Rows[0]["kest_cst_code"].ToString();
                }

                 tamweel_code = dataSet1.aksat_table.Rows[0]["kest_loan_code"].ToString();
                name = tamweel_code;
                substringAutoCompleteTextBox1.TextBox_.Text = tamweel_code;


                cst_name_txt.Text = dataSet1.aksat_table.Rows[0]["kest_cst_name"].ToString();
                kest_num_txt.Text = dataSet1.aksat_table.Rows[0]["kest_number"].ToString();
                est7kak_date_txt.Text = Convert.ToDateTime(dataSet1.aksat_table.Rows[0]["kest_est7kak_date"]).ToString("yyyy/MM/dd");
                kest_amount_txt.Text = dataSet1.aksat_table.Rows[0]["kest_amount"].ToString();
                kest_pay_amount_txt.Text = dataSet1.aksat_table.Rows[0]["kest_amount"].ToString();

                cst_code_text.Text = dataSet1.aksat_table.Rows[0]["kest_cst_code"].ToString();
                cst_code_txt.Text = dataSet1.aksat_table.Rows[0]["kest_cst_code"].ToString();
                mandoob_txt.Text = dataSet1.aksat_table.Rows[0]["kest_mandoob_name"].ToString();

                if (dateTimePicker1.Value > Convert.ToDateTime(est7kak_date_txt.Text))
                {
                    kest_cst_status_txt.Text = "متأخر";
                    kest_cst_status_txt.BackColor = Color.Red;
                    delay_days_txt.Text = (dateTimePicker1.Value - Convert.ToDateTime(est7kak_date_txt.Text)).TotalDays.ToString();
                }
                else
                {
                    kest_cst_status_txt.Text = "غير متأخر";
                    kest_cst_status_txt.BackColor = Color.Green;
                    kest_cst_status_txt.ForeColor = Color.White;
                    delay_days_txt.Text = "0";
                }


                loans_requests_tableTableAdapter1.FillBy_loan_code_and_far3(dataSet1.loans_requests_table, name, far3);




                loan_amount_txt.Text = dataSet1.loans_requests_table.Rows[0]["loan_amount"].ToString();
                loan_masareef_txt.Text = dataSet1.loans_requests_table.Rows[0]["loans_msareef"].ToString();
                sarf_date_txt.Text = Convert.ToDateTime(dataSet1.loans_requests_table.Rows[0]["loan_sarf_date"]).ToString("yyyy/MM/dd");
                loan_period_txt.Text = "/ " + dataSet1.loans_requests_table.Rows[0]["loan_period"].ToString();

                try
                {
                    fatora_num = Convert.ToInt32(dataSet1.loans_requests_table.Rows[0]["fatora_num"]);
                }
                catch
                {
                    fatora_num = 0;
                }
                //emp_tableTableAdapter1.FillBy_emp_name_far3(dataSet1.emp_table, mandoob_txt.Text, far3);

                //mandoob_code_txt.Text = dataSet1.emp_table.Rows[0]["emp_code"].ToString();

                substringAutoCompleteTextBox1.TextBox_.Enabled = false;


                customers_tableTableAdapter1.Fill(dataSet12.customers);
                try
                {
                    crystalReportViewer1.Visible = true;
                    // groupBox1.Visible = true;
                    // crystalReportViewer2.Visible = true;
                    aksat_tableTableAdapter1.FillBy_kest_cst_code_for_all(dataSet12.aksat_table, name, far3);
                    cst_name_txt.Text = dataSet12.aksat_table.Rows[0]["kest_cst_name"].ToString();
                    string kest_loan_code = dataSet12.aksat_table.Rows[0]["kest_loan_code"].ToString();
                    // loans_requests_tableTableAdapter1.FillBy_loan_code_and_far3(dataSet11.loans_requests_table, kest_loan_code, far3);
                    byan_7ala_tableTableAdapter1.FillBy_loan_code(dataSet12.byan_7ala_table, name);

                    string damen_for_test = dataSet12.aksat_table.Rows[0]["kest_1st_damen_code"].ToString();
                    aksat_show_for_all_report1.SetDataSource(dataSet12);
                    aksat_show_for_all_report1.Refresh();
                    crystalReportViewer1.RefreshReport();
                    crystalReportViewer1.Zoom(75);
                }
                catch { }
            }
            catch
            {
               
               


                    MessageBox.Show("تأكد من كود التقسيط");
                    foreach (Control t in groupBox1.Controls)
                    {
                        if (t is TextBox)
                        {
                            t.Text = "";
                        }
                    }
                    
                    substringAutoCompleteTextBox1.TextBox_.SelectAll();
                    substringAutoCompleteTextBox1.TextBox_.Focus();
                    return;
                
            }
        }
        //public void substringAutoCompleteTextBox1.TextBox__KeyDown(object sender, KeyEventArgs e)
        //{

        //    if (e.KeyCode == Keys.Return)
        //    {
        //        search_method(substringAutoCompleteTextBox1.TextBox_.Text, far3_txt.Text);
        //    }
        //}

        //private void substringAutoCompleteTextBox1.TextBox__Enter(object sender, EventArgs e)
        //{
        //    this.AcceptButton = null;
        //}

        //private void substringAutoCompleteTextBox1.TextBox__Leave(object sender, EventArgs e)
        //{
        //    this.AcceptButton = button1;
        //}

        private void button1_Click(object sender, EventArgs e)
        {


            if (kest_pay_amount_txt.Text == "" || kest_amount_txt.Text == "")
            {
                MessageBox.Show("تأكد من ادخال القيمه المسدده بطريقة صحيحه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kest_pay_amount_txt.SelectAll();
                kest_pay_amount_txt.Focus();
                return;
            }

            if (Convert.ToDecimal(kest_pay_amount_txt.Text) > Convert.ToDecimal(kest_amount_txt.Text))
            {
                MessageBox.Show("لا يمكن سداد قيمة أكبر من قيمة القسط", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kest_pay_amount_txt.SelectAll();
                kest_pay_amount_txt.Focus();
                return;
            }
            if (kest_num_txt.Text == "")
            {
                MessageBox.Show("تأكد من ادخال اسم العميل او الكود بطريقة صحيحه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                substringAutoCompleteTextBox1.TextBox_.SelectAll();
                substringAutoCompleteTextBox1.TextBox_.Focus();
                return;
            }
            if (sarf_date_txt.Text == "")
            {
                MessageBox.Show("تأكد ان العميل قام بالصرف أولا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                substringAutoCompleteTextBox1.TextBox_.SelectAll();
                substringAutoCompleteTextBox1.TextBox_.Focus();
                return;
            }
            aksat_tableTableAdapter1.FillBy_cst_code_kest_num_far3_paid(dataSet11.aksat_table, substringAutoCompleteTextBox1.TextBox_.Text, far3_txt.Text, Convert.ToInt32(kest_num_txt.Text));
            if (dataSet11.aksat_table.Rows.Count > 0)
            {
                MessageBox.Show("هذا القسط مسدد مسبقا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                substringAutoCompleteTextBox1.TextBox_.SelectAll();
                substringAutoCompleteTextBox1.TextBox_.Focus();
                return;
            }
            if (Convert.ToDecimal(kest_pay_amount_txt.Text) < Convert.ToDecimal(kest_amount_txt.Text))
            {
                string damen_awel_code = "";
                string damen_awel_name = "";
                string damen_tany_code = "";
                string damen_tany_name = "";

                aksat_tableTableAdapter1.FillBy_kest_cst_code_for_all(dataSet11.aksat_table, substringAutoCompleteTextBox1.TextBox_.Text, far3_txt.Text);
                try
                {
                    damen_awel_code = dataSet11.aksat_table.Rows[0]["kest_1st_damen_code"].ToString();
                    damen_awel_name = dataSet11.aksat_table.Rows[0]["kest_1st_damen_name"].ToString();
                }
                catch { }


                try
                {
                    damen_tany_code = dataSet11.aksat_table.Rows[0]["kest_2nd_damen_code"].ToString();
                    damen_tany_name = dataSet11.aksat_table.Rows[0]["kest_2nd_damen_name"].ToString();

                }
                catch { }

                //string message = "kest_cst_code: " + cst_code_text.Text + " (Length: " + cst_code_text.Text.Length + ")\n" +
                // "kest_cst_name: " + cst_name_txt.Text + " (Length: " + cst_name_txt.Text.Length + ")\n" +
                // "kest_1st_damen_code: " + damen_awel_code + " (Length: " + damen_awel_code.Length + ")\n" +
                // "kest_1st_damen_name: " + damen_awel_name + " (Length: " + damen_awel_name.Length + ")\n" +
                // "kest_2nd_damen_code: " + damen_tany_code + " (Length: " + damen_tany_code.Length + ")\n" +
                // "kest_2nd_damen_name: " + damen_tany_name + " (Length: " + damen_tany_name.Length + ")\n" +
                // "kest_amount: " + kest_pay_amount_txt.Text + " (Length: " + kest_pay_amount_txt.Text.Length + ")\n" +
                // "kest_est7kak_date: " + est7kak_date_txt.Text + " (Length: " + est7kak_date_txt.Text.Length + ")\n" +
                // "kest_pay_date: " + dateTimePicker1.Value.ToString("yyyy-MM-dd") + " (Length: " + dateTimePicker1.Value.ToString("yyyy-MM-dd").Length + ")\n" +
                // "kest_notes: " + "سداد جزء من قسط رقم " + kest_num_txt.Text + " (Length: " + ("سداد جزء من قسط رقم " + kest_num_txt.Text).Length + ")\n" +
                // "kest_user: " + user_txt.Text + " (Length: " + user_txt.Text.Length + ")\n" +
                // "kest_status: " + "مسدد" + " (Length: " + "مسدد".Length + ")\n" +
                // "kest_delay_days: " + delay_days_txt.Text + " (Length: " + delay_days_txt.Text.Length + ")\n" +
                // "kest_mandoob_name: " + mandoob_txt.Text + " (Length: " + mandoob_txt.Text.Length + ")\n" +
                // "kest_mandoob_code: " + mandoob_code_txt.Text + " (Length: " + mandoob_code_txt.Text.Length + ")\n" +
                // "kest_far3: " + far3_txt.Text + " (Length: " + far3_txt.Text.Length + ")\n" +
                // "kest_modat_eltamweel: " + loan_period_txt.Text + " (Length: " + loan_period_txt.Text.Length + ")\n" +
                // "kest_loan_code: " + substringAutoCompleteTextBox1.TextBox_.Text + " (Length: " + substringAutoCompleteTextBox1.TextBox_.Text.Length + ")\n" +
                // "kest_delay_penalty_all: (null)\n" +
                // "kest_delay_penalty_mosadad: (null)";

                //MessageBox.Show(message, "Insert Data Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Clipboard.SetText(message);


                aksat_tableTableAdapter1.Insert(0, cst_code_text.Text, cst_name_txt.Text, damen_awel_code, damen_awel_name, damen_tany_code, damen_tany_name, Convert.ToDecimal(kest_pay_amount_txt.Text), Convert.ToDateTime(est7kak_date_txt.Text),
                    dateTimePicker1.Value, "سداد جزء من قسط رقم " + kest_num_txt.Text, user_txt.Text, "مسدد", Convert.ToDecimal(delay_days_txt.Text), mandoob_txt.Text, mandoob_code_txt.Text,
                    far3_txt.Text, loan_period_txt.Text, substringAutoCompleteTextBox1.TextBox_.Text, null, null);

                aksat_tableTableAdapter1.Update_kest_amount_for_partial(Convert.ToDecimal(kest_amount_txt.Text) - Convert.ToDecimal(kest_pay_amount_txt.Text), Convert.ToInt32(kest_num_txt.Text), substringAutoCompleteTextBox1.TextBox_.Text, cst_name_txt.Text, far3_txt.Text);

                //aksat_tableTableAdapter1.Update_kest_status(dateTimePicker1.Value.ToShortDateString(), Convert.ToDecimal(kest_pay_amount_txt.Text), Convert.ToDecimal(delay_days_txt.Text)
                //   , user_txt.Text, Convert.ToInt32(kest_num_txt.Text), substringAutoCompleteTextBox1.TextBox_.Text, cst_name_txt.Text, far3_txt.Text);


                // insert to safe
                string details = "قيمة سداد جزء من قسط رقم " + kest_num_txt.Text + " للعميل " + cst_name_txt.Text;
                string far2_details = "مصاريف قسط رقم " + kest_num_txt.Text;

                kest_num_txt.Text = "0";

                try
                {
                    //decimal masareef_nesba = Convert.ToDecimal(loan_masareef_txt.Text) / Convert.ToDecimal(loan_amount_txt.Text);
                    //decimal far2_se3r = Math.Round((masareef_nesba * Convert.ToDecimal(kest_pay_amount_txt.Text)), 0);
                    //safe_income_tableTableAdapter1.Insert(dateTimePicker1.Value, far2_details, far2_se3r, 0, "مصاريف ادارية", cst_name_txt.Text,
                    //    user_txt.Text,"مصاريف ادارية", far3_txt.Text, 0);
                }
                catch
                { }



                decimal kest_nesba;
                decimal kest;

                try
                {
                    kest_nesba = 1;// (Convert.ToDecimal(loan_amount_txt.Text) - Convert.ToDecimal(loan_masareef_txt.Text)) / Convert.ToDecimal(loan_amount_txt.Text);

                    kest = Math.Round((kest_nesba * Convert.ToDecimal(kest_pay_amount_txt.Text)), 0);
                }
                catch
                {
                    kest_nesba = 1;// (Convert.ToDecimal(loan_amount_txt.Text)) / Convert.ToDecimal(loan_amount_txt.Text);

                    kest = Math.Round((kest_nesba * Convert.ToDecimal(kest_pay_amount_txt.Text)), 0);
                }
                // MessageBox.Show(kest.ToString());
                //income far2 se3r

                //income kest
                safe_income_tableTableAdapter1.Insert(dateTimePicker1.Value, details, kest, fatora_num, "سداد اقساط", cst_name_txt.Text,
                     user_txt.Text,"" , far3_txt.Text, 0);

                //update safe
                safe_tableTableAdapter1.Update_add_to_safe(Convert.ToDecimal(kest_pay_amount_txt.Text));

                //insert to safe by minus
                safe_tableTableAdapter1.Insert(Convert.ToDecimal(kest_pay_amount_txt.Text), dateTimePicker1.Value, Convert.ToDecimal(kest_pay_amount_txt.Text));



                DialogResult re = MessageBox.Show("تم السداد بنجاح هل تريد طباعة الايصال ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (re == DialogResult.Yes)
                {
                    aksat_tableTableAdapter1.FillBy_kest_num_and_cst_code_and_pay_date_for_partial(dataSet1.aksat_table, Convert.ToInt32(kest_num_txt.Text), substringAutoCompleteTextBox1.TextBox_.Text, far3_txt.Text, dateTimePicker1.Value.ToShortDateString());




                    try
                    {
                        CrystalReport_kest1.SetDataSource(dataSet1);
                    }
                    catch { CrystalReport_kest1.SetDataSource(dataSet1); }
                    CrystalReport_kest1.Refresh();

                    StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_fwateer.txt");
                    string printer_name = srr.ReadLine();

                    try
                    {
                        CrystalReport_kest1.PrintOptions.PrinterName = printer_name;
                        CrystalReport_kest1.PrintToPrinter(1, false, 0, 0);
                    }
                    catch { CrystalReport_kest1.PrintToPrinter(1, false, 0, 0); }
                }
                else 
                {

                    //sssssssssss
                }
                crystalReportViewer1.Visible = false;
                sms_msgs();
                try
                {
                    aksat_tableTableAdapter1.FillBy_kest_cst_code_not_paid(dataSet1.aksat_table, substringAutoCompleteTextBox1.TextBox_.Text, far3_txt.Text);

                    if (dataSet1.aksat_table.Rows.Count <= 0)
                    {
                        aksat_tableTableAdapter1.FillBy_kest_cst_code_for_all(dataSet11.aksat_table, substringAutoCompleteTextBox1.TextBox_.Text, far3_txt.Text);
                        try
                        {
                             damen_awel_code = dataSet11.aksat_table.Rows[0]["kest_1st_damen_code"].ToString();
                            customers_tableTableAdapter1.Update_Customer_status_by_Customer_code("لا توجد التزامات", Convert.ToInt32(damen_awel_code));
                        }
                        catch { }


                        try
                        {
                             damen_tany_code = dataSet11.aksat_table.Rows[0]["kest_2nd_damen_code"].ToString();

                            customers_tableTableAdapter1.Update_Customer_status_by_Customer_code("لا توجد التزامات", Convert.ToInt32(damen_tany_code));
                        }
                        catch { }



                        //string loan_cost = dataSet11.aksat_table.Rows[0]["loan_amount"].ToString();

                        //string loan_status = dataSet11.aksat_table.Rows[0]["loan_agreed_or_not"].ToString();

                        customers_tableTableAdapter1.Update_Customer_status_by_Customer_code("لا توجد التزامات", Convert.ToInt32(cst_code_text.Text));



                        loans_requests_tableTableAdapter1.Update_mandoob_and_status_by_loan_code("متسرب", "متسرب", substringAutoCompleteTextBox1.TextBox_.Text);

                    }
                     this.Close();
                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //  this.Close();

                }
            }
            else
            {
                decimal penalty = Math.Round(((Convert.ToDecimal(1) / 100) * Convert.ToDecimal(kest_amount_txt.Text)) * Convert.ToDecimal(delay_days_txt.Text), 0);


                aksat_tableTableAdapter1.Update_kest_status(dateTimePicker1.Value.ToShortDateString(), Convert.ToDecimal(kest_pay_amount_txt.Text), Convert.ToDecimal(delay_days_txt.Text)
                    , user_txt.Text, penalty, 0, Convert.ToInt32(kest_num_txt.Text), substringAutoCompleteTextBox1.TextBox_.Text, cst_name_txt.Text, far3_txt.Text);


                // insert to safe
                string details = "قيمة قسط رقم " + kest_num_txt.Text + " للعميل " + cst_name_txt.Text;

                string far2_details = "مصاريف قسط رقم " + kest_num_txt.Text;


                //income far2 se3r
                try
                {
               //     decimal masareef_nesba = Convert.ToDecimal(loan_masareef_txt.Text) / Convert.ToDecimal(loan_amount_txt.Text);
               //     decimal far2_se3r = Math.Round((masareef_nesba * Convert.ToDecimal(kest_pay_amount_txt.Text)), 0);
               //     safe_income_tableTableAdapter1.Insert(dateTimePicker1.Value,far2_details, far2_se3r,0,"مصاريف ادارية", cst_name_txt.Text, 
               //user_txt.Text,"", far3_txt.Text, 0);
                }
                catch
                { }

                decimal kest_nesba;
                decimal kest;

                try
                {
                    kest_nesba = 1;// (Convert.ToDecimal(loan_amount_txt.Text) - Convert.ToDecimal(loan_masareef_txt.Text)) / Convert.ToDecimal(loan_amount_txt.Text);


                    kest = Math.Round((kest_nesba * Convert.ToDecimal(kest_pay_amount_txt.Text)), 0);
                }
                catch
                {
                    kest_nesba = 1;//(Convert.ToDecimal(loan_amount_txt.Text)) / Convert.ToDecimal(loan_amount_txt.Text);


                    kest = Math.Round((kest_nesba * Convert.ToDecimal(kest_pay_amount_txt.Text)), 0);
                }


                //income kest
                safe_income_tableTableAdapter1.Insert(dateTimePicker1.Value, details, kest, fatora_num, "سداد اقساط", cst_name_txt.Text,
                    user_txt.Text, "", far3_txt.Text, 0);

                //update safe
                safe_tableTableAdapter1.Update_add_to_safe(Convert.ToDecimal(kest_pay_amount_txt.Text));

                //insert to safe by minus
                safe_tableTableAdapter1.Insert(Convert.ToDecimal(kest_pay_amount_txt.Text), dateTimePicker1.Value, Convert.ToDecimal(kest_pay_amount_txt.Text));

                 DialogResult re = MessageBox.Show("تم السداد بنجاح هل تريد طباعة الايصال ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                 if (re == DialogResult.Yes)
                 {
                     aksat_tableTableAdapter1.FillBy_kest_num_and_cst_code(dataSet1.aksat_table, Convert.ToInt32(kest_num_txt.Text), substringAutoCompleteTextBox1.TextBox_.Text, far3_txt.Text);




                     try
                     {
                         CrystalReport_kest1.SetDataSource(dataSet1);
                     }
                     catch { CrystalReport_kest1.SetDataSource(dataSet1); }
                     CrystalReport_kest1.Refresh();

                     StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_fwateer.txt");
                     string printer_name = srr.ReadLine();

                     try
                     {
                         CrystalReport_kest1.PrintOptions.PrinterName = printer_name;
                         CrystalReport_kest1.PrintToPrinter(1, false, 0, 0);
                     }
                     catch { CrystalReport_kest1.PrintToPrinter(1, false, 0, 0); }


                 }
                 else 
                 {


                     //sssssssssss
                 }
              
                 crystalReportViewer1.Visible = false;
                 sms_msgs();
                 try
                 {
                     aksat_tableTableAdapter1.FillBy_kest_cst_code_not_paid(dataSet1.aksat_table, substringAutoCompleteTextBox1.TextBox_.Text, far3_txt.Text);

                     if (dataSet1.aksat_table.Rows.Count <= 0)
                     {
                         aksat_tableTableAdapter1.FillBy_kest_cst_code_for_all(dataSet11.aksat_table, substringAutoCompleteTextBox1.TextBox_.Text, far3_txt.Text);
                         try
                         {
                             string damen_awel_code = dataSet11.aksat_table.Rows[0]["kest_1st_damen_code"].ToString();
                             customers_tableTableAdapter1.Update_Customer_status_by_Customer_code("لا توجد التزامات", Convert.ToInt32(damen_awel_code));
                         }
                         catch { }


                         try
                         {
                            string  damen_tany_code = dataSet11.aksat_table.Rows[0]["kest_2nd_damen_code"].ToString();

                             customers_tableTableAdapter1.Update_Customer_status_by_Customer_code("لا توجد التزامات", Convert.ToInt32(damen_tany_code));
                         }
                         catch { }



                         //string loan_cost = dataSet11.aksat_table.Rows[0]["loan_amount"].ToString();

                         //string loan_status = dataSet11.aksat_table.Rows[0]["loan_agreed_or_not"].ToString();

                         customers_tableTableAdapter1.Update_Customer_status_by_Customer_code("لا توجد التزامات", Convert.ToInt32(cst_code_text.Text));



                         loans_requests_tableTableAdapter1.Update_mandoob_and_status_by_loan_code("متسرب", "متسرب", substringAutoCompleteTextBox1.TextBox_.Text);

                     }
                    // this.Close();
                 }
                 catch (Exception ex)
                 {
                     // MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                      // this.Close();

                 }
            }
            // insert to sada mandooben



          //  this.Close();


            foreach (Control t in groupBox1.Controls)
            {
                if (t is TextBox)
                {
                    t.Text = "";
                }
            }
             substringAutoCompleteTextBox1.TextBox_.Text = "";
             if (substringAutoCompleteTextBox1.TextBox_.Text != "")
             {
                 search_method(substringAutoCompleteTextBox1.TextBox_.Text, far3_txt.Text);
             }
            substringAutoCompleteTextBox1.TextBox_.Enabled = true;

        }

        private void pay_kest_Load(object sender, EventArgs e)
        {
            if (this.Text == "ترحيل قسط")
            {
                button1.Visible = false;
                button2.Visible = true;
            }
            else 
            {
                button1.Visible = true;
                button2.Visible = false;
            }
            substringAutoCompleteTextBox1.TextBox_.Focus();
            if (substringAutoCompleteTextBox1.TextBox_.Text != "")
            {
                try
                {
                    aksat_tableTableAdapter1.FillBy_kest_cst_code_not_paid(dataSet1.aksat_table, substringAutoCompleteTextBox1.TextBox_.Text, far3_txt.Text);
                    cst_name_txt.Text = dataSet1.aksat_table.Rows[0]["kest_cst_name"].ToString();
                    kest_num_txt.Text = dataSet1.aksat_table.Rows[0]["kest_number"].ToString();
                    est7kak_date_txt.Text = Convert.ToDateTime(dataSet1.aksat_table.Rows[0]["kest_est7kak_date"]).ToString("yyyy/MM/dd");
                    kest_amount_txt.Text = dataSet1.aksat_table.Rows[0]["kest_amount"].ToString();
                    kest_pay_amount_txt.Text = dataSet1.aksat_table.Rows[0]["kest_amount"].ToString();

                    cst_code_text.Text = dataSet1.aksat_table.Rows[0]["kest_cst_code"].ToString();
                    cst_code_txt.Text = dataSet1.aksat_table.Rows[0]["kest_cst_code"].ToString();


                    if (dateTimePicker1.Value > Convert.ToDateTime(est7kak_date_txt.Text))
                    {
                        kest_cst_status_txt.Text = "متأخر";
                        kest_cst_status_txt.BackColor = Color.Red;
                        delay_days_txt.Text = (dateTimePicker1.Value - Convert.ToDateTime(est7kak_date_txt.Text)).TotalDays.ToString();
                    }
                    else
                    {
                        kest_cst_status_txt.Text = "غير متأخر";
                        kest_cst_status_txt.BackColor = Color.Green;
                        kest_cst_status_txt.ForeColor = Color.White;
                        delay_days_txt.Text = "0";
                    }


                    loans_requests_tableTableAdapter1.FillBy_loan_code_and_far3(dataSet1.loans_requests_table, substringAutoCompleteTextBox1.TextBox_.Text, far3_txt.Text);




                    loan_amount_txt.Text = dataSet1.loans_requests_table.Rows[0]["loan_amount"].ToString();
                    sarf_date_txt.Text = Convert.ToDateTime(dataSet1.loans_requests_table.Rows[0]["loan_sarf_date"]).ToString("yyyy/MM/dd");


                    mandoob_txt.Text = dataSet1.loans_requests_table.Rows[0]["loan_mandoob"].ToString();

                    if (sarf_date_txt.Text == "")
                    {
                        MessageBox.Show("تأكد من صرف التقسيط اولا ");
                        foreach (Control t in groupBox1.Controls)
                        {
                            if (t is TextBox)
                            {
                                t.Text = "";
                            }
                        }
                        substringAutoCompleteTextBox1.TextBox_.SelectAll();
                        substringAutoCompleteTextBox1.TextBox_.Focus();
                        return;
                    }




                }
                catch
                {
                    try
                    {
                        aksat_tableTableAdapter1.FillBy_kest_cst_name_and_not_paid(dataSet1.aksat_table, substringAutoCompleteTextBox1.TextBox_.Text, far3_txt.Text);
                        cst_name_txt.Text = dataSet1.aksat_table.Rows[0]["kest_cst_name"].ToString();
                        kest_num_txt.Text = dataSet1.aksat_table.Rows[0]["kest_number"].ToString();
                        est7kak_date_txt.Text = Convert.ToDateTime(dataSet1.aksat_table.Rows[0]["kest_est7kak_date"]).ToString("yyyy/MM/dd");
                        kest_amount_txt.Text = dataSet1.aksat_table.Rows[0]["kest_amount"].ToString();
                        kest_pay_amount_txt.Text = dataSet1.aksat_table.Rows[0]["kest_amount"].ToString();

                        cst_code_text.Text = dataSet1.aksat_table.Rows[0]["kest_cst_code"].ToString();
                        cst_code_txt.Text = dataSet1.aksat_table.Rows[0]["kest_cst_code"].ToString();
                        if (dateTimePicker1.Value > Convert.ToDateTime(est7kak_date_txt.Text))
                        {
                            kest_cst_status_txt.Text = "متأخر";
                            kest_cst_status_txt.BackColor = Color.Red;
                            delay_days_txt.Text = (dateTimePicker1.Value - Convert.ToDateTime(est7kak_date_txt.Text)).TotalDays.ToString();
                        }
                        else
                        {
                            kest_cst_status_txt.Text = "غير متأخر";
                            kest_cst_status_txt.ForeColor = Color.White;
                            delay_days_txt.Text = "0";
                        }


                        loans_requests_tableTableAdapter1.FillBy_loan_code_and_far3(dataSet1.loans_requests_table, substringAutoCompleteTextBox1.TextBox_.Text, far3_txt.Text);




                        loan_amount_txt.Text = dataSet1.loans_requests_table.Rows[0]["loan_amount"].ToString();
                        sarf_date_txt.Text = Convert.ToDateTime(dataSet1.loans_requests_table.Rows[0]["loan_sarf_date"]).ToString("yyyy/MM/dd");



                        mandoob_txt.Text = dataSet1.loans_requests_table.Rows[0]["loan_mandoob"].ToString();


                        if (sarf_date_txt.Text == "")
                        {
                            MessageBox.Show("تأكد من صرف التقسيط اولا ");
                            foreach (Control t in groupBox1.Controls)
                            {
                                if (t is TextBox)
                                {
                                    t.Text = "";
                                }
                            }
                            substringAutoCompleteTextBox1.TextBox_.SelectAll();
                            substringAutoCompleteTextBox1.TextBox_.Focus();
                            return;
                        }

                    }
                    catch
                    {


                        MessageBox.Show("تأكد من كود التقسيط");
                        foreach (Control t in groupBox1.Controls)
                        {
                            if (t is TextBox)
                            {
                                t.Text = "";
                            }
                        }
                        substringAutoCompleteTextBox1.TextBox_.SelectAll();
                        substringAutoCompleteTextBox1.TextBox_.Focus();
                        return;
                    }
                }
            }

            suggestions();

            mandoob_code_txt.Text = "";


            //this.aksat_tableTableAdapter1.FillBy_far3(this.dataSet1.aksat_table, far3_txt.Text);

            ////substringAutoCompleteTextBox1.Height = Screen.PrimaryScreen.Bounds.Height;
            ////substringAutoCompleteTextBox1.BackColor = Color.Transparent;
            //substringAutoCompleteTextBox1.SetSuggestions(dataSet1.aksat_table, "kest_cst_name");

          
           

        }
        public void substringAutoCompleteTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) 
            {
                search_method(substringAutoCompleteTextBox1.TextBox_.Text, far3_txt.Text);
            }
        }
        private void substringAutoCompleteTextBox1_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = null;
           // MessageBox.Show(AcceptButton.ToString());
        }

        private void substringAutoCompleteTextBox1_Leave(object sender, EventArgs e)
        {
            if (substringAutoCompleteTextBox1.Listbox_.Visible == false)
            {
                this.AcceptButton = button1;
            }
        }
       
        private void suggestions()
        {
            this.aksat_tableTableAdapter1.FillBy_far3_and_not_paid(this.dataSet1.aksat_table, far3_txt.Text);

            substringAutoCompleteTextBox1.SetSuggestions(dataSet1.aksat_table, "kest_cst_name");
            //AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();


            //foreach (DataRow dr in dataSet1.aksat_table.Rows)
            //{
            //    DataCollection.Add(dr["kest_cst_name"].ToString());
            //}
            
            //substringAutoCompleteTextBox1.TextBox_.AutoCompleteMode = AutoCompleteMode.Suggest;
            //substringAutoCompleteTextBox1.TextBox_.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //substringAutoCompleteTextBox1.TextBox_.AutoCompleteCustomSource = DataCollection;

            
        }



      

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            total();
        }

        private void total()
        {
            try
            {
                aksat_tableTableAdapter1.FillBy_kest_cst_code_not_paid(dataSet1.aksat_table, substringAutoCompleteTextBox1.TextBox_.Text, far3_txt.Text);
                //   cst_name_txt.Text = dataSet11.aksat_table.Rows[0]["kest_cst_name"].ToString();
                //cst_code_txt.Text = dataSet11.aksat_table.Rows[0]["kest_cst_code"].ToString();
                //damen_1_txt.Text = dataSet11.aksat_table.Rows[0]["kest_1st_damen_name"].ToString();
                //damen_2_txt.Text = dataSet11.aksat_table.Rows[0]["kest_2nd_damen_name"].ToString();
                // damen_1_code = dataSet11.aksat_table.Rows[0]["kest_1st_damen_code"].ToString();
                // damen_2_code = dataSet11.aksat_table.Rows[0]["kest_2nd_damen_code"].ToString();
                // mandoob_name = dataSet11.aksat_table.Rows[0]["kest_mandoob_name"].ToString();
                // mandoob_code = dataSet11.aksat_table.Rows[0]["kest_mandoob_code"].ToString();
                //decimal osool = 0;
                //decimal fayda = 0;

                decimal kest_amount = Convert.ToDecimal(dataSet1.aksat_table.Rows[0]["kest_amount"]);
                DateTime date = Convert.ToDateTime(dataSet1.aksat_table.Rows[0]["kest_est7kak_date"]);
                //  string status = dgr.Cells[8].Value.ToString();
                //string mandoob = dgr.Cells[9].Value.ToString();
                //string phone = dgr.Cells[10].Value.ToString();
                //string address = dgr.Cells[11].Value.ToString();



                //loans_requests_tableTableAdapter1.FillBy_loan_code_and_far3(dataSet11.loans_requests_table, substringAutoCompleteTextBox1.TextBox_.Text, far3_txt.Text);

                //decimal months = Convert.ToDecimal(dataSet11.loans_requests_table.Rows[0]["loan_period"]);
                //decimal requested_amount = Convert.ToDecimal(dataSet11.loans_requests_table.Rows[0]["loan_amount"]);
                //decimal extra_amount = Convert.ToDecimal(dataSet11.loans_requests_table.Rows[0]["loan_extra_amount"]);
                ////  decimal requested_amount=Convert.ToDecimal(dataSet1.loans_requests_table.Rows[0]["loan_amount"]);


                //decimal nesba_asl = requested_amount / (requested_amount + extra_amount);
                //decimal nesba_fayda = extra_amount / (requested_amount + extra_amount);

                ////decimal asl_kest = requested_amount / months;
                ////decimal fayda_kest = extra_amount / months;


                //decimal asl_kest = kest_amount * nesba_asl;
                //decimal fayda_kest = kest_amount * nesba_fayda;

                ////decimal asl_kest = requested_amount / months;
                ////decimal fayda_kest = extra_amount / months;
                //osool += Math.Round(asl_kest, 0);
                //fayda += Math.Round(fayda_kest, 0);



                decimal matloob_sadad_tar7eel = kest_amount *Convert.ToDecimal(0.25);


                DialogResult re = MessageBox.Show("المطلوب سداده للترحيل مبلغ " + matloob_sadad_tar7eel.ToString("0.00") + " هل تريد المتابعة ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (re == DialogResult.Yes)
                {


                    aksat_tableTableAdapter1.FillBy_kest_cst_code_not_paid(dataSet11.aksat_table, substringAutoCompleteTextBox1.TextBox_.Text, far3_txt.Text);

                    int count = Convert.ToInt32(dataSet11.aksat_table.Rows[dataSet11.aksat_table.Rows.Count - 1]["kest_number"]);

                    DateTime last_kest_date = Convert.ToDateTime(dataSet11.aksat_table.Rows[dataSet11.aksat_table.Rows.Count - 1]["kest_est7kak_date"]);

                    DateTime new_kest_date = last_kest_date.AddMonths(1);

                    aksat_tableTableAdapter1.Update_for_estkmal(dateTimePicker1.Value.ToShortDateString(), matloob_sadad_tar7eel, 0, user_txt.Text, 0, 0, "مرحل"
                          , Convert.ToInt32(kest_num_txt.Text), substringAutoCompleteTextBox1.TextBox_.Text, cst_name_txt.Text, far3_txt.Text);


                    decimal penalty = Math.Round(((Convert.ToDecimal(1) / 100) * Convert.ToDecimal(kest_amount_txt.Text)) * Convert.ToDecimal(delay_days_txt.Text), 0);


                    aksat_tableTableAdapter1.Update_kest_status(dateTimePicker1.Value.ToShortDateString(), matloob_sadad_tar7eel, Convert.ToDecimal(delay_days_txt.Text)
                        , user_txt.Text, penalty, 0, Convert.ToInt32(kest_num_txt.Text), substringAutoCompleteTextBox1.TextBox_.Text, cst_name_txt.Text, far3_txt.Text);



                    //insert income

                    count += 1;

                    string damen_awel_code = "";
                    string damen_awel_name = "";
                    string damen_tany_code = "";
                    string damen_tany_name = "";

                    aksat_tableTableAdapter1.FillBy_kest_cst_code_for_all(dataSet11.aksat_table, substringAutoCompleteTextBox1.TextBox_.Text, far3_txt.Text);
                    try
                    {
                        damen_awel_code = dataSet11.aksat_table.Rows[0]["kest_1st_damen_code"].ToString();
                        damen_awel_name = dataSet11.aksat_table.Rows[0]["kest_1st_damen_name"].ToString();
                    }
                    catch { }


                    try
                    {
                        damen_tany_code = dataSet11.aksat_table.Rows[0]["kest_2nd_damen_code"].ToString();
                        damen_tany_name = dataSet11.aksat_table.Rows[0]["kest_2nd_damen_name"].ToString();

                    }
                    catch { }




                    aksat_tableTableAdapter1.Insert(count, cst_code_txt.Text, cst_name_txt.Text, damen_awel_code, damen_awel_name, damen_tany_code, damen_tany_name
                      , Convert.ToDecimal(kest_amount_txt.Text), new_kest_date, null, "", user_txt.Text, "غير مسدد", 0, mandoob_txt.Text, mandoob_code_txt.Text, far3_txt.Text, loan_period_txt.Text, substringAutoCompleteTextBox1.TextBox_.Text, null, null);


                    safe_income_tableTableAdapter1.Insert_income(dateTimePicker1.Value.ToShortDateString(), "سداد قيمة ترحيل القسط رقم " + kest_num_txt.Text + " للعميل " + cst_name_txt.Text, matloob_sadad_tar7eel, fatora_num, "سداد اقساط", cst_name_txt.Text, user_txt.Text, "مرحل"
                  , far3_txt.Text,0);

                    aksat_tableTableAdapter1.FillBy_kest_num_and_cst_code(dataSet1.aksat_table, Convert.ToInt32(kest_num_txt.Text), substringAutoCompleteTextBox1.TextBox_.Text, far3_txt.Text);




                    try
                    {
                        CrystalReport_kest1.SetDataSource(dataSet1);
                    }
                    catch { CrystalReport_kest1.SetDataSource(dataSet1); }
                    CrystalReport_kest1.Refresh();

                    StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_fwateer.txt");
                    string printer_name = srr.ReadLine();

                    try
                    {
                        CrystalReport_kest1.PrintOptions.PrinterName = printer_name;
                        CrystalReport_kest1.PrintToPrinter(1, false, 0, 0);
                    }
                    catch { CrystalReport_kest1.PrintToPrinter(1, false, 0, 0); }

                    MessageBox.Show("تم السداد بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    

                    this.Close();
                }
                else { return; }

              
            }
            catch { }
        }

        private void sms_msgs() 
        {
            try
            {
                customers_tableTableAdapter1.FillBy_name(dataSet11.customers, cst_name_txt.Text);
                string cst_phone = dataSet11.customers.Rows[0]["cst_phone"].ToString();
                if (kest_num_txt.Text == "1")
                {

                    send_sms_class.send_sms_msg(" ترحب بعملائها الجدد", cst_phone);

                    string msg = "تم سداد قيمة " + " " + kest_pay_amount_txt.Text + " كود " + substringAutoCompleteTextBox1.TextBox_.Text + Environment.NewLine + " - الادارة المالية - ";
                    // MessageBox.Show(msg + msg.Length.ToString());
                    send_sms_class.send_sms_msg(msg, cst_phone);
                }
                else 
                {
                    string msg = "تم سداد قيمة " + " " + kest_pay_amount_txt.Text + " كود " + substringAutoCompleteTextBox1.TextBox_.Text + Environment.NewLine + " - الادارة المالية - ";
                    // MessageBox.Show(msg + msg.Length.ToString());
                    send_sms_class.send_sms_msg(msg, cst_phone);
                }

               
            }
            catch { }
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Fill the DataTable with relevant data using the correct TableAdapter and filters
                loans_requests_tableTableAdapter1.FillBy_agreed_or_not_and_sarf_date(dataSet11.loans_requests_table, "تم الصرف",
                    Convert.ToDateTime("1-1-2000").ToShortDateString(), DateTime.Today.AddYears(20).ToShortDateString(), far3_txt.Text);

                // Check the number of rows returned
               // MessageBox.Show(dataSet11.loans_requests_table.Rows.Count.ToString());

                // Get the current loan code from substringAutoCompleteTextBox1
                string currentCode = substringAutoCompleteTextBox1.Text;

                // Use the DataSet you filled (dataSet11 in this case) to find the next loan code
                DataRow[] nextRows = dataSet11.loans_requests_table.Select(
                    String.Format("loan_code > '{0}'", currentCode), "loan_code ASC");

                // Check if any rows are found
                if (nextRows.Length > 0)
                {
                    // Get the next available loan code
                    string nextCode = nextRows[0]["loan_code"].ToString();

                    // Update the text box with the next loan code
                    substringAutoCompleteTextBox1.Text = nextCode;

                    // Show the next code in a message box (for testing purposes)
                 //   MessageBox.Show(nextCode);
                    // Call search_method with the updated loan code
                    search_method(nextCode, far3_txt.Text); // Assuming far3 is stored in far3_txt
                }
            }
            catch { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Fill the DataTable with relevant data using the correct TableAdapter and filters
                loans_requests_tableTableAdapter1.FillBy_agreed_or_not_and_sarf_date(
                    dataSet11.loans_requests_table, "تم الصرف",
                    Convert.ToDateTime("1-1-2000").ToShortDateString(),
                    DateTime.Today.AddYears(20).ToShortDateString(), far3_txt.Text);

                // Get the current loan code from substringAutoCompleteTextBox1
                string currentCode = substringAutoCompleteTextBox1.Text;

                // Use the DataSet you filled (dataSet11) to find the previous loan code
                DataRow[] previousRows = dataSet11.loans_requests_table.Select(
                    String.Format("loan_code < '{0}'", currentCode), "loan_code DESC");

                // Check if any rows are found
                if (previousRows.Length > 0)
                {
                    // Get the previous available loan code
                    string previousCode = previousRows[0]["loan_code"].ToString();

                    // Update the text box with the previous loan code
                    substringAutoCompleteTextBox1.Text = previousCode;

                    // Optionally call search_method with the updated loan code
                    search_method(previousCode, far3_txt.Text);
                }
                else
                {
                    MessageBox.Show("No previous loan code found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void crystalReportViewer1_VisibleChanged(object sender, EventArgs e)
        {
            if (crystalReportViewer1.Visible == false)
            {
                this.Height = substringAutoCompleteTextBox1.Height + groupBox1.Height + 100;
            }
            else 
            {
                this.Height = this.Height;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                crystalReportViewer1.Visible = true;
                checkBox1.BackColor = Color.Green;
            }
            else 
            {
                crystalReportViewer1.Visible = false;
                checkBox1.BackColor = Color.Red;
            }
        }

    }
}
