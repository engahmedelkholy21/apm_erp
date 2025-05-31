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
    public partial class tasleem_syana : Form
    {
        public tasleem_syana()
        {
            InitializeComponent();
            Form1 f1 = new Form1();
            f1.SubscribeToLoadEvent(this);
            f1.ApplyFormStyling(this);
        }

        decimal ket3_gheiar;
        private void salesID_TXT_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                syana_tableTableAdapter1.FillBy_syana_no(dataSet11.syana_table,Convert.ToInt32(salesID_TXT.Text));
                if (dataSet11.syana_table.Rows[0]["syana_status"].ToString() == "جاهزه للتسليم")
                {
                    cst_nameTXT.Text = dataSet11.syana_table.Rows[0]["syana_cst_name"].ToString();
                    cst_phoneTXT.Text = dataSet11.syana_table.Rows[0]["syana_cst_phone"].ToString();
                    cst_addressTXT.Text = dataSet11.syana_table.Rows[0]["syana_address"].ToString();
                    recieve_date.Value = Convert.ToDateTime(dataSet11.syana_table.Rows[0]["syana_recieve_date"]);//.ToString();
                    deliver_date.Value = Convert.ToDateTime(dataSet11.syana_table.Rows[0]["syana_deliver_date"]);//.ToString();

                    device_type_txt.Text = dataSet11.syana_table.Rows[0]["syana_device_type"].ToString();
                    problem_txt.Text = dataSet11.syana_table.Rows[0]["syana_problem"].ToString();
                    mol7kat_txt.Text = dataSet11.syana_table.Rows[0]["syana_mol7kat"].ToString();
                    cost_txt.Text = dataSet11.syana_table.Rows[0]["syana_total_cost"].ToString();
                    paid_txt.Text = dataSet11.syana_table.Rows[0]["syana_paid"].ToString();
                    ba2y_txt.Text = dataSet11.syana_table.Rows[0]["syana_ba2y"].ToString();
                    notes_txt.Text = dataSet11.syana_table.Rows[0]["syana_notes"].ToString();

                    ket3_gheiar = Convert.ToDecimal(dataSet11.syana_table.Rows[0]["syana_ket3_gheiar_cost"]);
                    syana_type_txt.Text = dataSet11.syana_table.Rows[0]["syana_type"].ToString();
                }
                else 
                {
                    MessageBox.Show("تأكد ان الفاتورة جاهزه للتسليم");
                    return;
                }

            }
            catch
            {
                cst_nameTXT.Text="";
                cst_phoneTXT.Text = "";
                cst_addressTXT.Text = "";
                recieve_date.Value = DateTime.Today;
                deliver_date.Value = DateTime.Today;

                device_type_txt.Text = "";
                problem_txt.Text="";
                mol7kat_txt.Text="";
                cost_txt.Text = "";
                paid_txt.Text = "";
                ba2y_txt.Text = "";
                notes_txt.Text = "";
                ket3_gheiar = 0;
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            //update status user delivered
            syana_tableTableAdapter1.Update_delivered_user(usertxt.Text,Convert.ToDecimal(ba2y_txt.Text),DateTime.Today.ToShortDateString(),problem_txt.Text,Convert.ToDecimal(cost_txt.Text)
                ,Convert.ToInt32(salesID_TXT.Text));
            
            //insert income
            income_tableTableAdapter1.Insert_income(DateTime.Today.ToShortDateString(), "باقي فاتورة صيانة رقم " + salesID_TXT.Text, Convert.ToDecimal(ba2y_txt.Text),
                 Convert.ToInt32(salesID_TXT.Text), "صيانة", cst_nameTXT.Text, usertxt.Text, notes_txt.Text, far3txt.Text, Convert.ToDecimal(cost_txt.Text) - Convert.ToDecimal(paid_txt.Text)-Convert.ToDecimal(ba2y_txt.Text));

            decimal income_cost = Convert.ToDecimal(ba2y_txt.Text);
            safeTableAdapter1.Update_add_to_safe(income_cost);


            //safe status daily
            safeTableAdapter1.Insert_safe(deliver_date.Value.ToShortDateString(), income_cost);

            //insert arba7
            decimal profit = Convert.ToDecimal(cost_txt.Text) - ket3_gheiar;
            arba7_tableTableAdapter1.Insert_arba7(DateTime.Today.ToShortDateString(), "ربح قاتورة صيانة رقم " + salesID_TXT.Text, profit, "صيانة", Convert.ToInt32(salesID_TXT.Text),
               cst_nameTXT.Text, usertxt.Text, 0,0,far3txt.Text);
            DialogResult re = MessageBox.Show("تم تسليم الجهاز بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            salesID_TXT.Text = "";
            salesID_TXT.Focus();
            //cst_nameTXT.Text = "";
            //cst_phoneTXT.Text = "";
            //cst_addressTXT.Text = "";
            //recieve_date.Value = DateTime.Today;
            //deliver_date.Value = DateTime.Today;

            //device_type_txt.Text = "";
            //problem_txt.Text = "";
            //mol7kat_txt.Text = "";
            //cost_txt.Text = "";
            //paid_txt.Text = "";
            //ba2y_txt.Text = "";
            //notes_txt.Text = "";
        }

        private void tasleem_syana_Load(object sender, EventArgs e)
        {

        }

        private void cost_txt_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                ba2y_txt.Text = (Convert.ToDecimal(cost_txt.Text) - Convert.ToDecimal(paid_txt.Text)).ToString();
            }
            catch { }
        }
    }
}
