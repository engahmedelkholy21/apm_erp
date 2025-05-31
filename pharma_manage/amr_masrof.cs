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
    public partial class amr_masrof : Form
    {
        public amr_masrof()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;

            Form1 f1 = new Form1();
            f1.SubscribeToLoadEvent(this);
            f1.ApplyFormStyling(this);
        }

        private void amr_masrof_Load(object sender, EventArgs e)
        {

        }

        decimal total_amr_masrofat;
        private void amr_num_txt_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                byan_txt.Items.Clear();
                amr_masrofat_tableTableAdapter1.FillBy_amr_num(dataSet11.amr_masrofat_table, Convert.ToInt32(amr_num_txt.Text));
                foreach (DataRow dr in dataSet11.amr_masrofat_table.Rows) 
                {
                    byan_txt.Items.Add(dr["amr_masrofat_byan"].ToString());

                   
                }

                try
                {
                    amr_masrofat_tableTableAdapter1.FillBy_amr_num_TOTAL_COST(dataSet11.amr_masrofat_table, Convert.ToInt32(amr_num_txt.Text));

                    total_amr_masrofat = Convert.ToDecimal(dataSet11.amr_masrofat_table.Rows[0]["TOTAL_COST"]);
                    //   MessageBox.Show(total_amr_masrofat.ToString());
                }
                catch { }
            }
            catch { }
        }

        private void byan_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                amr_masrofat_tableTableAdapter1.FillBy_amr_num_and_byan(dataSet11.amr_masrofat_table, Convert.ToInt32(amr_num_txt.Text), byan_txt.Text);
                cost_txt.Text = dataSet11.amr_masrofat_table.Rows[0]["amr_masrofat_cost"].ToString();
            }
            catch { }

        }

        private void byan_txt_TextChanged(object sender, EventArgs e)
        {
            byan_txt_SelectedIndexChanged(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (amr_num_txt.Text == "") 
            {
                MessageBox.Show("ادخل رقم امر الشغل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                amr_num_txt.Focus();
                return;
            }
            if (cost_txt.Text == "")
            {
                MessageBox.Show("ادخل المبلغ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cost_txt.Focus();
                return;
            }
            if (byan_txt.Text == "")
            {
                MessageBox.Show("ادخل البيان", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                byan_txt.Focus();
                return;
            }
            //اتاكد ان المصروف علي امر الشغل دا مش مصروف قبل كدا او اكتر
            outcome_tableTableAdapter1.FillBy_src_and_esm_TOTAL_OUTCOME(dataSet11.outcome_table, "امر شغل", "امر شغل رقم " + amr_num_txt.Text);
            decimal total_outcome = 0;
            decimal far2 = 0;
            try
            {
                 total_outcome = Convert.ToDecimal(dataSet11.outcome_table.Rows[0]["TOTAL_OUTCOME"]);
                far2 = total_amr_masrofat - total_outcome;
            }
            catch { }

            if (total_outcome >= total_amr_masrofat) 
            {
                MessageBox.Show("تم صرف جمع مستحقات هذا الامر مسبقا","خطأ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else if (total_outcome < total_amr_masrofat && (Convert.ToDecimal(cost_txt.Text) + total_outcome) > total_amr_masrofat) 
            {
                MessageBox.Show("لا يمكن سداد هذا المبلغ لهذا الامر المبلغ المسموح للسداد هو "+far2.ToString(), "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            outcome_tableTableAdapter1.Insert_outcome(dateTimePicker1.Value.ToShortDateString(),byan_txt.Text + " امر شغل رقم "+amr_num_txt.Text, Convert.ToDecimal(cost_txt.Text), Convert.ToInt32(amr_num_txt.Text), "امر شغل", "امر شغل رقم "+amr_num_txt.Text, notes_txt.Text, usertxt.Text,far3txt.Text);
            safeTableAdapter1.Update_sarf_from_safe(Convert.ToDecimal(cost_txt.Text));
            decimal tarh = Convert.ToDecimal(cost_txt.Text) * -1;
            safeTableAdapter1.Insert_safe(dateTimePicker1.Value.ToShortDateString(), tarh);
            MessageBox.Show("تمت الصرف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            byan_txt.ResetText(); cost_txt.Clear(); dateTimePicker1.Value = DateTime.Today;
            notes_txt.Clear();
            amr_num_txt.Focus();
            total_amr_masrofat = 0;
            amr_num_txt_TextChanged(sender, e);
        }
    }
}
