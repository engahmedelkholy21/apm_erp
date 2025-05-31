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
    public partial class deleted_form : Form
    {
        public deleted_form()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
        }

        private void deleted_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.deleted_table' table. You can move, or remove it, as needed.
            this.deleted_tableTableAdapter.Fill(this.dataSet1.deleted_table);
            if (usertxt.Text != "admin")
            {

                user_previligesTableAdapter1.FillBy_name(dataSet1.user_previliges, usertxt.Text);



                foreach (DataRow dr in dataSet1.user_previliges.Rows)
                {
                    listBox1.Items.Add(dr["user_previliges"].ToString());

                }
                if (listBox1.Items.Contains("إضافة مستخدم"))
                {
                    button1.Visible = true;
                }
                else
                {
                    button1.Visible = false;
                }
            }
        }

        private void cst_name_txt_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                if (cst_name_txt.Text == "")
                {
                    deleted_tableTableAdapter.FillBy_fatra(dataSet1.deleted_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
                }
                else 
                {
                    deleted_tableTableAdapter.FillBy_fatra_and_like_details(dataSet1.deleted_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(),cst_name_txt.Text);
          
                }
            }
            catch { }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            cst_name_txt_TextChanged(sender, e);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            cst_name_txt_TextChanged(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deleted_tableTableAdapter.Delete_fatra_user(dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), usertxt.Text);
            cst_name_txt_TextChanged(sender, e);
        }
    }
}
