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
    public partial class loan_delete : Form
    {
        public loan_delete()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            aksat_tableTableAdapter1.FillBy_loan_code_and_paid(dataSet11.aksat_table, loan_name_txt.Text, far3_txt.Text);
            if (dataSet11.aksat_table.Rows.Count > 1) 
            {
                MessageBox.Show("لا يمكن حذف التقسيط بسبب سداد اكثر من قسط", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            loans_requests_tableTableAdapter1.FillBy_loan_code_and_far3(dataSet11.loans_requests_table, loan_name_txt.Text, far3_txt.Text);
            

            string name = dataSet11.loans_requests_table.Rows[0]["loan_cst_name"].ToString();
             string cost = dataSet11.loans_requests_table.Rows[0]["loan_amount"].ToString();
            string msg="هل تريد حذف تمويل العميل "+ name +" بقيمة "+ cost + "نهائيا؟";

             DialogResult re = MessageBox.Show(msg, "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
             if (re == DialogResult.Yes)
             {
                 try
                 {
                     //update cst status
                     loans_requests_tableTableAdapter1.FillBy_loan_code_and_far3(dataSet11.loans_requests_table, loan_name_txt.Text,far3_txt.Text);

                     string cst_code = dataSet11.loans_requests_table.Rows[0]["loan_cst_code"].ToString();

                     string damen_awel_code = dataSet11.loans_requests_table.Rows[0]["loan_1st_damen_code"].ToString();
                     string damen_tany_code = dataSet11.loans_requests_table.Rows[0]["loan_2nd_damen_code"].ToString();

                     string loan_cost = dataSet11.loans_requests_table.Rows[0]["loan_amount"].ToString();

                     string loan_status = dataSet11.loans_requests_table.Rows[0]["loan_agreed_or_not"].ToString();

                     deleted_tableTableAdapter1.Insert(DateTime.Today, loan_name_txt.Text, " تمويل كود " + loan_name_txt.Text + " بقيمة " + loan_cost, "", user_txt.Text, this.Text);
                     try
                     {
                         customers_tableTableAdapter1.Update_Customer_status_by_Customer_code("لا توجد التزامات", Convert.ToInt32(cst_code));
                     }
                     catch { }
                    try
                     {
                         customers_tableTableAdapter1.Update_Customer_status_by_Customer_code("لا توجد التزامات", Convert.ToInt32(damen_awel_code));
                     }
                     catch { }
                     try
                     {
                         customers_tableTableAdapter1.Update_Customer_status_by_Customer_code("لا توجد التزامات", Convert.ToInt32(damen_tany_code));
                     }
                     catch { }

                        int  fatora_num = Convert.ToInt32(dataSet11.loans_requests_table.Rows[0]["fatora_num"]);

                       
                        sales_fatora ff = new sales_fatora();

                        ff.salesID_TXT.Text = fatora_num.ToString();
                        ff.Text = "مراجعة فاتورة بيع";
                        ff.usertxt.Text = user_txt.Text;
                        ff.far3txt.Text = far3_txt.Text;
                        ff.to_delete.Text = "delete";
                        ff.ShowDialog();

                        string income_details1="مبلغ من فاتورة بيع رقم "+fatora_num.ToString();
                        safe_income_tableTableAdapter1.Delete_details_src_ID(income_details1, "آجل", fatora_num, far3_txt.Text);

                        safe_income_tableTableAdapter1.Delete_by_id(fatora_num);
                     //delete loan
                     loans_requests_tableTableAdapter1.Delete_by_loan_code_and_far3(loan_name_txt.Text,far3_txt.Text);



                     // delete from sader
                   //  safe_outcome_tableTableAdapter1.Delete_by_loan_code(loan_name_txt.Text);

                     //delete from entagya
                     try
                     {
                       //  productivity_tableTableAdapter1.Delete_by_loan_code_and_far3(loan_name_txt.Text, far3_txt.Text);
                     }
                     catch { }

                     try
                     {
                       //  pay_order_tableTableAdapter1.Deleteby_cst_code_and_far3(loan_name_txt.Text, far3_txt.Text);
                     }
                     catch { }

                     try
                     {

                         aksat_tableTableAdapter1.Delete_cst_code_and_far3(loan_name_txt.Text, far3_txt.Text);
                     }
                     catch { }

                     //if (loan_status == "تم الصرف")
                     //{
                     //    //update raseed in safe

                     //    safe_tableTableAdapter1.Update_add_to_safe(Convert.ToDecimal(loan_cost));

                     //    safe_tableTableAdapter1.Insert(Convert.ToDecimal(loan_cost), DateTime.Today, Convert.ToDecimal(loan_cost));
                     //}

                    // safe_income_tableTableAdapter1.Delete_details_src_ID("قيمة قسط رقم 1 للعميل "+name,"سداد اقساط",far3_txt.Text);
                     //safe_income_tableTableAdapter1.Delete_details_src_ID Delete_by_cst_code_and_far3_and_source();
                  //   safe_income_tableTableAdapter1.Delete_by_cst_code_and_far3_and_source(loan_name_txt.Text, far3_txt.Text, "فرق سعر");

                  

                     deleted_tableTableAdapter1.Insert(DateTime.Today, loan_name_txt.Text, this.Text, "", user_txt.Text, this.Text);
                     MessageBox.Show("تم حذف التقسيط بنجاح");
                     this.Close();
                 }
                 catch
                 {
                     MessageBox.Show("تأكد من كود التقسيط", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     return;
                 }
             }
        }
    }
}
