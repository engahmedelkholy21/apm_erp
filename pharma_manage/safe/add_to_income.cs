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
    public partial class add_to_income : Form
    {
        public add_to_income()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
        }

        private void suggest_cst_name()
        {
            this.income_tableTableAdapter1.Fill(this.dataSet11.income_table);
            person_name_txt.AutoCompleteMode = AutoCompleteMode.Suggest;
            person_name_txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet11.income_table.Rows)
            {
                DataCollection.Add(dr["income_esm_elmashroo3"].ToString());
            }

            da2n_small_reportsTableAdapter1.Fill(dataSet11.da2n_small_reports);
            foreach (DataRow dr in dataSet11.madeen_small_report.Rows)
            {
                DataCollection.Add(dr["da2n_small_name"].ToString());
            }


            person_name_txt.AutoCompleteCustomSource = DataCollection;

        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;  // Set the cursor to indicate loading
                this.Enabled = false;              // Disable form to prevent interaction


                DialogResult r = MessageBox.Show("هل تريد اضافة مبلغ "+cost_txt.Text+" للخزينة "+" ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (r == DialogResult.Yes)
                {
                    income_tableTableAdapter1.Insert_income(dateTimePicker1.Value.ToShortDateString(), details_txt.Text, Convert.ToDecimal(cost_txt.Text), 0, "عمليات سريعه", person_name_txt.Text, usertxt.Text, notes_txt.Text,far3txt.Text,0);
                    safeTableAdapter1.Update_add_to_safe(Convert.ToDecimal(cost_txt.Text));
                    safeTableAdapter1.Insert_safe(dateTimePicker1.Value.ToShortDateString(), Convert.ToDecimal(cost_txt.Text));

                    //safe_users_tableTableAdapter1.FillBy_user(dataSet11.safe_users_table, usertxt.Text);
                    //if (dataSet11.safe_users_table.Rows.Count <= 0)
                    //{
                    //    safe_users_tableTableAdapter1.Insert(Convert.ToDecimal(cost_txt.Text), usertxt.Text);
                    //}
                    //else
                    //{
                    //    safe_users_tableTableAdapter1.Update_add_to_safe_users(Convert.ToDecimal(cost_txt.Text), usertxt.Text);
                    //}

                    da2n_small_reportsTableAdapter1.FillBy_da2n_small_name(dataSet11.da2n_small_reports, person_name_txt.Text);

                    if (dataSet11.da2n_small_reports.Rows.Count > 0)
                    {


                        DialogResult re = MessageBox.Show("يوجد دائن بنفس الاسم , هل تريد اضافة المبلغ للحساب ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (re == DialogResult.Yes)
                        {

                            //da2n small report update
                            da2n_small_reportsTableAdapter1.Update_matloob_AND_madfoo3_BY_name(Convert.ToDecimal(cost_txt.Text), 0, person_name_txt.Text);
                            da2n_small_reportsTableAdapter1.FillBy_da2n_small_name(dataSet11.da2n_small_reports, person_name_txt.Text);
                            decimal new_matloob = Convert.ToDecimal(dataSet11.da2n_small_reports.Rows[0]["da2n_small_matloob"]);
                            decimal new_madfoo3 = Convert.ToDecimal(dataSet11.da2n_small_reports.Rows[0]["da2n_small_madfoo3"]);


                            //da2n details insert
                            string da2n_byan = "مبلغ مضاف للخزينة";
                            da2n_tableTableAdapter1.Insert_da2n_details(dateTimePicker1.Value.ToShortDateString(), person_name_txt.Text, da2n_byan, Convert.ToDecimal(cost_txt.Text), 0, details_txt.Text, usertxt.Text,
                                 new_matloob, new_madfoo3, 0);

                            //da2n details update matlob and madfo93
                            da2n_tableTableAdapter1.Update_matloob_AND_madfoo3_By_da2n_name(Convert.ToDecimal(cost_txt.Text), 0, person_name_txt.Text);

                        }


                    }
                    MessageBox.Show("تمت الاضافة بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    details_txt.Clear(); cost_txt.Clear(); dateTimePicker1.Value = DateTime.Today; person_name_txt.Clear(); notes_txt.Clear();
                    cost_txt.Focus();
                }




                this.Cursor = Cursors.Arrow;  // Set the cursor to indicate loading
                this.Enabled = true;              // Disable form to prevent interaction
            }
            catch
            {

            }
        }

        private void add_to_income_Load(object sender, EventArgs e)
        {
            suggest_cst_name();

            cost_txt.KeyPress += DigitOnly_KeyPress;
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
    }
}
