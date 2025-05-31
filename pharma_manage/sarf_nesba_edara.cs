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
    public partial class sarf_nesba_edara : Form
    {
        public sarf_nesba_edara()
        {
            InitializeComponent();

            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
        }

        private void sarf_nesba_edara_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.partners_share_table' table. You can move, or remove it, as needed.
            this.partners_share_tableTableAdapter.Fill(this.dataSet1.partners_share_table);
          

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            decimal arba7_total;
            decimal nathryat=0;
           
            decimal safy_arba7;
           
            try
            {
                this.arba7_tableTableAdapter1.FillBy_fatra_stock(dataSet1.arba7_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3txt.Text);

                decimal sum = 0;

                for (int i = 0; i < dataSet1.arba7_table.Rows.Count; ++i)
                {
                    decimal profit = Convert.ToDecimal(dataSet1.arba7_table.Rows[i]["arba7_cost"]);
                    sum += profit;
                }
                arba7_total = sum;

            }
            catch {
                arba7_total = 0; 
            }

            //nathryat
           
                outcome_tableTableAdapter1.FillBy_TOTAL_in_fatra_far3(dataSet11.outcome_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(),far3txt.Text);

                try
                {
                    nathryat = Convert.ToDecimal(dataSet11.outcome_table.Rows[0]["TOTAL"]);

                    if (nathryat == null)
                    {
                        nathryat = 0;
                    }
                }
                catch { }
            try
            {
                safy_arba7 = arba7_total - nathryat;
            }
            catch
            {
                safy_arba7 = 0;
            }

            reb7_txt.Text = arba7_total.ToString();
            masrofat_txt.Text = nathryat.ToString();
            safy_txt.Text = safy_arba7.ToString();
            decimal most7ak = 0;
            try
            {
                 most7ak = (Convert.ToDecimal(nesba_txt.Text) / 100) * Convert.ToDecimal(safy_arba7);
            }
            catch { }
            mosta7ak_txt.Text = most7ak.ToString("0.00");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1_ValueChanged(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
             DialogResult r = MessageBox.Show("هل تريد صرف مبلغ "+mosta7ak_txt.Text+" من الخزينة علي مصدر إدارة ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
             if (r == DialogResult.Yes)
             {
                 //safe_users_tableTableAdapter1.FillBy_user(dataSet11.safe_users_table, usertxt.Text);

                 //if (Convert.ToDecimal(dataSet11.safe_users_table.Rows[0]["safe_users_amount"]) >= Convert.ToDecimal(cost_txt.Text))
                 //{
                 //    safe_users_tableTableAdapter1.Update_sarf_from_safe_users(Convert.ToDecimal(cost_txt.Text), usertxt.Text);
                 //}
                 //else
                 //{
                 //    MessageBox.Show("رصيد خزينتك لا يسمح برجاء المراجعة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 //    return;
                 //}

                 outcome_tableTableAdapter1.Insert_outcome(DateTime.Today.ToShortDateString(),"نسبة ادارة للشريك "+ partner_txt.Text, Convert.ToDecimal(mosta7ak_txt.Text), 0, "إدارة", partner_txt.Text, usertxt.Text, "عن الفترة من "+dateTimePicker1.Value.ToShortDateString()+" إلى "+ dateTimePicker2.Value.ToShortDateString(), far3txt.Text);
                 safeTableAdapter1.Update_sarf_from_safe(Convert.ToDecimal(mosta7ak_txt.Text));
                 decimal tarh = Convert.ToDecimal(mosta7ak_txt.Text) * -1;
                 safeTableAdapter1.Insert_safe(dateTimePicker1.Value.ToShortDateString(), tarh);
                 MessageBox.Show("تم الصرف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 this.Close();
             }
        }
    }
}
