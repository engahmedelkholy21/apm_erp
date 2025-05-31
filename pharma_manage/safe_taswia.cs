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
    public partial class safe_taswia : Form
    {
        public safe_taswia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (safe_raseed.Text != "")
            {
                if (Convert.ToDecimal(current_txt.Text) > 0)
                {
                    decimal cost = Convert.ToDecimal(current_txt.Text);
                    outcome_tableTableAdapter1.Insert_outcome("1-1-2000", "تسوية الخزينة", cost, 0, "تسوية", "", user_txt.Text, "", far3_txt.Text);
                    income_tableTableAdapter1.Insert_income("1-1-2000", "تسوية الخزينة", Convert.ToDecimal(safe_raseed.Text), 0, "تسوية", "", user_txt.Text, "", far3_txt.Text, 0);
                    MessageBox.Show("تمت تسوية الخزينة بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
                else
                {
                    decimal cost = Math.Abs(Convert.ToDecimal(current_txt.Text));
                    //MessageBox.Show(cost.ToString());
                    income_tableTableAdapter1.Insert_income("1-1-2000", "تسوية الخزينة", cost, 0, "تسوية", "", user_txt.Text, "", far3_txt.Text, 0);
                    income_tableTableAdapter1.Insert_income("1-1-2000", "تسوية الخزينة", Convert.ToDecimal(safe_raseed.Text), 0, "تسوية", "", user_txt.Text, "", far3_txt.Text, 0);
                    MessageBox.Show("تمت تسوية الخزينة بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
            }
        }
    }
}
