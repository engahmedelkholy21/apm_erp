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
    public partial class sadad_mo3agal : Form
    {
        public sadad_mo3agal()
        {
            InitializeComponent();
        }

        private void cst_name_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) 
            {
                loans_requests_tableTableAdapter1.FillBy_check_if_exist_and_still(dataSet11.loans_requests_table, cst_name_txt.Text,far3_txt.Text);
                if (dataSet11.loans_requests_table.Rows.Count > 0) 
                {
                    string code = dataSet11.loans_requests_table.Rows[0]["loan_code"].ToString();
                    string fatora = dataSet11.loans_requests_table.Rows[0]["fatora_num"].ToString();

                    code_txt.Text = code;
                    fatora_num_txt.Text = fatora;



                    aksat_tableTableAdapter1.FillBy_TOTAL_NOT_PAID_by_loan_code_far3(dataSet11.aksat_table, code, far3_txt.Text);
                    decimal total_mosta7k = Convert.ToDecimal(dataSet11.aksat_table.Rows[0]["TOTAL_NOT_PAID"]);
                    int AKSAT_COUNT = Convert.ToInt32(dataSet11.aksat_table.Rows[0]["AKSAT_COUNT"]);
                    mosta7k_txt.Text = total_mosta7k.ToString();

                    aksat_count_txt.Text = AKSAT_COUNT.ToString();
                    
                }
            }
        }

        private void discount_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal final_amount = Convert.ToDecimal(mosta7k_txt.Text) - Convert.ToDecimal(discount_txt.Text);

                final_amount_txt.Text = final_amount.ToString();

            }
            catch { }
        }

        private void sadad_mo3agal_Load(object sender, EventArgs e)
        {
            suggest_cst_name();
        }
        private void suggest_cst_name()
        {
            this.loans_requests_tableTableAdapter1.FillBy_agreed_or_not_and_sarf_date(dataSet11.loans_requests_table, "تم الصرف", Convert.ToDateTime("1-1-2000").ToShortDateString(), DateTime.Today.ToShortDateString(), far3_txt.Text);
          
            cst_name_txt.AutoCompleteMode = AutoCompleteMode.Suggest;
            cst_name_txt.AutoCompleteSource = AutoCompleteSource.CustomSource;

         

            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet11.loans_requests_table.Rows)
            {
                DataCollection.Add(dr["loan_cst_name"].ToString());
            }


            cst_name_txt.AutoCompleteCustomSource = DataCollection;

          

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (cst_name_txt.Text == "")
                {
                    MessageBox.Show("أدخل اسم العميل");
                    return;
                }
                if (code_txt.Text == "")
                {
                    MessageBox.Show("أدخل كود التقسيط");
                    return;
                }
                //تعديل الاقساط المتبقيه
                aksat_tableTableAdapter1.FillBy_kest_cst_code_not_paid(dataSet11.aksat_table, code_txt.Text, far3_txt.Text);
                if (dataSet11.aksat_table.Rows.Count > 0)
                {
                    foreach (DataRow dr in dataSet11.aksat_table.Rows)
                    {
                        int kest_num = Convert.ToInt32(dr["kest_number"]);
                        decimal old_amount = Convert.ToDecimal(dr["kest_amount"]);
                        decimal new_amount = old_amount - (Convert.ToDecimal(discount_txt.Text) / Convert.ToDecimal(aksat_count_txt.Text));
                        // MessageBox.Show(dgr.Cells[0].Value.ToString());
                        aksat_tableTableAdapter1.Update_for_sadad_mo3agal(new_amount, "سداد مبكر", kest_num, code_txt.Text, cst_name_txt.Text, far3_txt.Text);
                        // سداد الاقساط المتبقية 
                        aksat_tableTableAdapter1.Update_kest_status(DateTime.Today.ToShortDateString(), new_amount, 0, user_txt.Text, 0, 0, kest_num, code_txt.Text, cst_name_txt.Text, far3_txt.Text);


                        
                     
                    }

                    loans_requests_tableTableAdapter1.Update_mandoob_and_status_by_loan_code("", "متسرب", code_txt.Text);

                    try
                    {

                        int cst_code = Convert.ToInt32(dataSet11.aksat_table.Rows[0]["kest_cst_code"]);
                        customersTableAdapter1.Update_Customer_status_by_Customer_code("لا توجد التزامات", cst_code);
                    }
                    catch { }

                    try
                    {
                        int damen_1 = Convert.ToInt32(dataSet11.aksat_table.Rows[0]["kest_1st_damen_code"]);
                        customersTableAdapter1.Update_Customer_status_by_Customer_code("لا توجد التزامات", damen_1);
                    }
                    catch { }

                    try
                    {
                        int damen_2 = Convert.ToInt32(dataSet11.aksat_table.Rows[0]["kest_2nd_damen_code"]);
                        customersTableAdapter1.Update_Customer_status_by_Customer_code("لا توجد التزامات", damen_2);
                    }
                    catch { }
                }
                else 
                {
                    return;
                }
             //  تعديل ربح الفاتورة
                //arba7_cat

                //arba7
                try
                {
                    arba7_tableTableAdapter1.Update_arba7_for_sadad_mo3agal(Convert.ToDecimal(discount_txt.Text), Convert.ToInt32(fatora_num_txt.Text));
                }
                catch { }
                    // تعديل قيمة الفاتورة

                try
                {
                    decimal nesba_ = Convert.ToDecimal(discount_txt.Text) / Convert.ToDecimal(mosta7k_txt.Text);
                    arba7_cat_tableTableAdapter1.Update_for_sadad_mo3agal(nesba_, Convert.ToInt32(fatora_num_txt.Text), far3_txt.Text);
                }
                catch { }

            // تعديل قيمة التقسيط
            //loans_requests_tableTableAdapter1.up
                //income kest
                income_tableTableAdapter1.Insert(DateTime.Today,"سداد مبكر أقساط العميل "+cst_name_txt.Text+" تقسيط فاتورة رقم "+fatora_num_txt.Text,Convert.ToDecimal(final_amount_txt.Text)
                    ,Convert.ToInt32(fatora_num_txt.Text), "سداد اقساط", cst_name_txt.Text,
                    user_txt.Text, "", far3_txt.Text, 0);
                MessageBox.Show("تم السداد بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch { }
        }
    }
}
