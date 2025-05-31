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
    public partial class add_halek : Form
    {
        public add_halek()
        {
            InitializeComponent();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            //if (this.Text == "إضافة هالك")
            //{
                halek_tableTableAdapter1.Insert(name_txt.Text, Convert.ToInt32(id_txt.Text), Convert.ToDecimal(count_txt.Text), DateTime.Today, notes_txt.Text, user_txt.Text,stock_txt.Text);

                products_tableTableAdapter1.FillBy_id(dataSet11.products_table, Convert.ToInt32(id_txt.Text));
                decimal old_count = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);
                decimal cost = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_cost_price"]);
                string int_code_txt = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                products_tableTableAdapter1.Update_count_BY_ID_bee3(Convert.ToDecimal(count_txt.Text), Convert.ToDecimal(count_txt.Text), int_code_txt, stock_txt.Text);
               
            products_tableTableAdapter1.FillBy_id(dataSet11.products_table, Convert.ToInt32(id_txt.Text));

                decimal new_count = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);
                ma5zoon_movesTableAdapter1.Insert(DateTime.Today, int_code_txt, name_txt.Text, Convert.ToDecimal(count_txt.Text), Convert.ToDecimal(count_txt.Text) * cost
                    , 0, old_count, new_count, "هالك", 0, user_txt.Text, user_txt.Text,stock_txt.Text);

                MessageBox.Show("تم الحفظ بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            //}
            //else 
            //{
                
            //}

        }

        private void add_halek_Load(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.SubscribeToLoadEvent(this);
            f1.ApplyFormStyling(this);
        }
    }
}
