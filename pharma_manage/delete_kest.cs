using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace pharma_manage
{
    public partial class delete_kest : Form
    {
        public delete_kest()
        {
            InitializeComponent();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (type_txt.Text != "print")
            {
                try
                {
                    if (kest_num_txt.Text == "0" && comboBox1.Text == "")
                    {
                        MessageBox.Show("تأكد من اختيار القسط", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return;
                    }
                    DialogResult re = MessageBox.Show("هل تريد حذف القسط نهائيا؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (re == DialogResult.Yes)
                    {
                        loans_requests_tableTableAdapter1.FillBy_check_if_exist_and_may_finished(dataSet11.loans_requests_table, cst_name_text.Text, far3_txt.Text);
                        if (dataSet11.loans_requests_table.Rows.Count > 0)
                        {
                            aksat_tableTableAdapter1.FillBy_kest_num_and_loan_code_far3_paid(dataSet11.aksat_table, Convert.ToInt32(kest_num_txt.Text), loan_code_txt.Text, far3_txt.Text);
                            if (dataSet11.aksat_table.Rows.Count > 0)
                            {
                                int fatora_num = Convert.ToInt32(dataSet11.loans_requests_table.Rows[0]["fatora_num"]);
                                string loan_status = dataSet11.loans_requests_table.Rows[0]["loan_agreed_or_not"].ToString();
                              //  MessageBox.Show(fatora_num.ToString());
                                string income_details = "";
                               // Clipboard.SetText(income_details);
                              
                                if (kest_num_txt.Text == "0")
                                {
                                    string numberPart = Regex.Match(comboBox1.Text, @"\d+(\.\d+)?").Value;
                                    int orignal_kest = Convert.ToInt32(numberPart);
                                    //MessageBox.Show(orignal_kest.ToString());
                                    aksat_tableTableAdapter1.Delete_kest_0(Convert.ToInt32(kest_num_txt.Text), loan_code_txt.Text, cst_name_text.Text, far3_txt.Text,comboBox1.Text);

                                    aksat_tableTableAdapter1.Update_original_kest_after_deletion(Convert.ToDecimal(kest_amount_txt.Text), orignal_kest, loan_code_txt.Text, cst_name_text.Text, far3_txt.Text);
                                     income_details = "قيمة سداد جزء من قسط رقم " + orignal_kest.ToString() + " للعميل " + cst_name_text.Text;
                                }
                                else
                                {
                                     income_details = "قيمة قسط رقم " + kest_num_txt.Text + " للعميل " + cst_name_text.Text;
                                    aksat_tableTableAdapter1.Update_for_delete(null, user_txt.Text, "", Convert.ToInt32(kest_num_txt.Text), loan_code_txt.Text, cst_name_text.Text, far3_txt.Text);
                                }
                                safe_income_tableTableAdapter1.FillBy_details_src_ID(dataSet11.income_table, income_details, "سداد اقساط",fatora_num, far3_txt.Text);
                                //MessageBox.Show(income_details);
                                //MessageBox.Show(dataSet11.income_table.Rows.Count.ToString());
                               
                                safe_income_tableTableAdapter1.Delete_details_src_ID(income_details, "سداد اقساط", fatora_num, far3_txt.Text);
                                //update safe
                                safe_tableTableAdapter1.Update_sarf_from_safe(Convert.ToDecimal(kest_amount_txt.Text));

                                //insert to safe by minus
                                safe_tableTableAdapter1.Insert(-Convert.ToDecimal(kest_amount_txt.Text), DateTime.Today, -Convert.ToDecimal(kest_amount_txt.Text));

                                if (loan_status == "متسرب")
                                {
                                    loans_requests_tableTableAdapter1.Update_mandoob_and_status_by_loan_code("", "تم الصرف", cst_name_text.Text);
                                }
                                string details = "قسط رقم " + kest_num_txt.Text + " للعميل " + cst_name_text.Text + " قيمته " + kest_amount_txt.Text;
                                deleted_tableTableAdapter1.Insert(DateTime.Today, loan_code_txt.Text, details, "", user_txt.Text, this.Text);
                                MessageBox.Show("تم حذف القسط بنجاح");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("القسط غير موجود او غير مسدد","خطأ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("تأكد من كود التقسيط او القسط", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else 
            {
                aksat_tableTableAdapter1.FillBy_kest_num_and_cst_code(dataSet11.aksat_table, Convert.ToInt32(kest_num_txt.Text), loan_code_txt.Text, far3_txt.Text);


                try
                {
                    crystalReport11.SetDataSource(dataSet11);
                }
                catch { crystalReport11.SetDataSource(dataSet11); }
                crystalReport11.Refresh();

                StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\kest_printer.txt");
                string printer_name = srr.ReadLine();

                try
                {
                    crystalReport11.PrintOptions.PrinterName = printer_name;
                    crystalReport11.PrintToPrinter(1, false, 0, 0);
                }
                catch { crystalReport11.PrintToPrinter(1, false, 0, 0); }

            }
        }

        private void loan_code_txt_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                aksat_tableTableAdapter1.FillBy_kest_num_and_cst_code(dataSet11.aksat_table, Convert.ToInt32(kest_num_txt.Text), loan_code_txt.Text, far3_txt.Text);
                cst_name_text.Text = dataSet11.aksat_table.Rows[0]["kest_cst_name"].ToString();
                kest_amount_txt.Text = dataSet11.aksat_table.Rows[0]["kest_amount"].ToString();
            }
            catch { }
        }

        private void kest_num_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (kest_num_txt.Text == "0")
                {
                    comboBox1.Items.Clear();
                    aksat_tableTableAdapter1.FillBy_kest_num_and_cst_code(dataSet11.aksat_table, Convert.ToInt32(kest_num_txt.Text), loan_code_txt.Text, far3_txt.Text);
                    foreach (DataRow dr in dataSet11.aksat_table.Rows) 
                    {
                        comboBox1.Items.Add(dr["kest_notes"].ToString());
                    }
                    cst_name_text.Text = dataSet11.aksat_table.Rows[0]["kest_cst_name"].ToString();
                }
                else
                {
                    aksat_tableTableAdapter1.FillBy_kest_num_and_cst_code(dataSet11.aksat_table, Convert.ToInt32(kest_num_txt.Text), loan_code_txt.Text, far3_txt.Text);
                    cst_name_text.Text = dataSet11.aksat_table.Rows[0]["kest_cst_name"].ToString();
                    kest_amount_txt.Text = dataSet11.aksat_table.Rows[0]["kest_amount"].ToString();
                }
            }
            catch { }
        }

        private void delete_kest_Load(object sender, EventArgs e)
        {
            if (type_txt.Text == "print") 
            {
                delete_btn.Text = "طباعة";
                delete_btn.BackColor = Color.Green;
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try 
            {
                if (kest_num_txt.Text == "0") 
                {
                    aksat_tableTableAdapter1.FillBy_kest_num_and_cst_code_notes(dataSet11.aksat_table, Convert.ToInt32(kest_num_txt.Text), loan_code_txt.Text, far3_txt.Text,comboBox1.Text);
                    kest_amount_txt.Text = dataSet11.aksat_table.Rows[0]["kest_amount"].ToString();
                }
            }
            catch { }

        }

    }
}
