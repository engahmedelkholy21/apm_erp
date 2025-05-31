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
    public partial class pay_mas2ool : Form
    {
        public pay_mas2ool()
        {
            InitializeComponent();
            Form1 f1 = new Form1();
            f1.SubscribeToLoadEvent(this);
            f1.ApplyFormStyling(this);
        }

        private void pay_mas2ool_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
            if (da2n_nameTXT.Text != "")
            {
                resp_tableTableAdapter1.FillBy_NAME_OR_PHONE(dataSet11.resp_table, da2n_nameTXT.Text, da2n_nameTXT.Text);
                try
                {
                    matloobtxt.Text = dataSet11.resp_table.Rows[0]["mas2ool_matloob"].ToString();
                    madfoo3txt.Text = dataSet11.resp_table.Rows[0]["mas2ool_madfoo3"].ToString();
                    ba2ytxt.Text = dataSet11.resp_table.Rows[0]["mas2ool_ba2y"].ToString();
                }
                catch { }
            }
            morad_daf3ohTXT.KeyPress += DigitOnly_KeyPress;
        }


        private void DigitOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, control characters, and a single decimal point
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Ignore the key press
            }

            // Allow only one decimal point
            TextBox textBox = (TextBox)sender;
            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true; // Ignore additional decimal points
            }
        }
        private void morad_daf3ohTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (morad_daf3ohTXT.Text == "")
                {
                    morad_daf3ohTXT.Focus();
                    MessageBox.Show("المبلغ المدفوع فارغ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                if (Convert.ToDecimal(morad_daf3ohTXT.Text) > Convert.ToDecimal(ba2ytxt.Text)) 
                {
                    morad_daf3ohTXT.Focus();
                    MessageBox.Show("المبلغ المدفوع اكبر من الباقي", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                string details = "مبلغ مدفوع من الحساب";

            DialogResult re = MessageBox.Show("هل تريد سداد مبلغ "+ morad_daf3ohTXT.Text, "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (re == DialogResult.Yes)
            {

                

                //insert to outcome
                outcome_tableTableAdapter1.Insert_outcome(dateTimePicker1.Value.ToShortDateString(), details, Convert.ToDecimal(morad_daf3ohTXT.Text), 0, "دفعات مسئولين", da2n_nameTXT.Text, usertxt.Text, notesTXT.Text,far3txt.Text);

                //update current safe
                safeTableAdapter1.Update_sarf_from_safe(Convert.ToDecimal(morad_daf3ohTXT.Text));

                //update day safe
                safeTableAdapter1.Insert_safe(dateTimePicker1.Value.ToShortDateString(), -1 * Convert.ToDecimal(morad_daf3ohTXT.Text));


                resp_tableTableAdapter1.FillBy_NAME_OR_PHONE(dataSet11.resp_table, da2n_nameTXT.Text, da2n_nameTXT.Text);

                decimal matloob_before = Convert.ToDecimal(dataSet11.resp_table.Rows[0]["mas2ool_matloob"]);
                decimal madfoo3_before = Convert.ToDecimal(dataSet11.resp_table.Rows[0]["mas2ool_madfoo3"]);
                decimal ba2y_before =matloob_before-madfoo3_before;





                decimal matloob_all = Convert.ToDecimal(dataSet11.resp_table.Rows[0]["mas2ool_matloob"]);
                decimal madfoo3_all = Convert.ToDecimal(dataSet11.resp_table.Rows[0]["mas2ool_madfoo3"]) + Convert.ToDecimal(morad_daf3ohTXT.Text);
                decimal ba2y_all =matloob_all-madfoo3_all;



                


                //insert madeen details
               // da2n_tableTableAdapter1.Insert_da2n_details(dateTimePicker1.Value.ToShortDateString(), da2n_nameTXT.Text, details, 0, Convert.ToDecimal(morad_daf3ohTXT.Text), notesTXT.Text, usertxt.Text, Convert.ToDecimal(matloobtxt.Text), Convert.ToDecimal(madfoo3txt.Text), 0);

                mosta7akat_mas2oleen_tableTableAdapter1.Insert(da2n_nameTXT.Text, dateTimePicker1.Value, matloob_all, madfoo3_all, 0, Convert.ToDecimal(morad_daf3ohTXT.Text), usertxt.Text
                    , ba2y_before, ba2y_all,"سداد من الحساب"+" " +notesTXT.Text, "دائن", 0);

                //da2n_tableTableAdapter1.FillBy_name(dataSet11.da2n_table, da2n_nameTXT.Text);

                ////update matloob and madfoo3 madeen details   
                //da2n_tableTableAdapter1.Update_matloob_AND_madfoo3_By_da2n_name(0, Convert.ToDecimal(morad_daf3ohTXT.Text), da2n_nameTXT.Text);
                //matloobtxt.Text = dataSet11.da2n_table.Rows[0]["da2n_matloob"].ToString();
                //madfoo3txt.Text = dataSet11.da2n_table.Rows[0]["da2n_madfoo3"].ToString();
                //ba2ytxt.Text = dataSet11.da2n_table.Rows[0]["da2n_ba2y"].ToString();


                //update madeen small report
                resp_tableTableAdapter1.Update_madfoo3_added_amount_by_name(Convert.ToDecimal(morad_daf3ohTXT.Text), da2n_nameTXT.Text);


                MessageBox.Show("تم الدفع بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else 
            {
                return;
            }

            //}
            //catch { }
        }
    }
}
