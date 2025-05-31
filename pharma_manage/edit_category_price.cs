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
    public partial class edit_category_price : Form
    {
        public edit_category_price()
        {
            InitializeComponent();
        }

        private void edit_category_price_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.dataSet1.Category);
            category_txt_SelectedIndexChanged(sender, e);

            this.stock_tableTableAdapter1.Fill(this.dataSet1.stock_table);
            foreach (DataRow dr in dataSet1.stock_table.Rows)
            {
                if (far3_txt.Items.Contains(dr["stock_name"].ToString()))
                { }
                else
                {
                    far3_txt.Items.Add(dr["stock_name"].ToString());
                }
            }

        }

        private void category_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            products_tableTableAdapter1.FillBy_category_stock(dataSet1.products_table, category_txt.Text,far3_txt.Text);
            if (dataSet1.products_table.Rows.Count > 0)
            {
                try
                {
                    pro_name_txt.Text = dataSet1.products_table.Rows[0]["pro_name"].ToString();
                    cost_before_txt.Text = dataSet1.products_table.Rows[0]["pro_cost_price"].ToString();
                    bee3_before_txt.Text = dataSet1.products_table.Rows[0]["pro_bee3"].ToString();
                    if (added_radio.Checked == true)
                    {
                        if (amount_radio.Checked == true)
                        {
                            cost_after_txt.Text = (Convert.ToDecimal(cost_before_txt.Text) + Convert.ToDecimal(cost_txt.Text)).ToString();
                            bee3_after_txt.Text = (Convert.ToDecimal(bee3_before_txt.Text) + Convert.ToDecimal(bee3_txt.Text)).ToString();

                        }
                        else if (nesba_radio.Checked == true)
                        {
                            decimal cost_nesba = Convert.ToDecimal(cost_before_txt.Text) + (Convert.ToDecimal(cost_before_txt.Text) * (Convert.ToDecimal(cost_txt.Text) / 100));
                            cost_after_txt.Text = cost_nesba.ToString();

                            decimal bee3_nesba = Convert.ToDecimal(bee3_before_txt.Text) + (Convert.ToDecimal(bee3_before_txt.Text) * (Convert.ToDecimal(bee3_txt.Text) / 100));

                            bee3_after_txt.Text = bee3_nesba.ToString();

                        }
                    }
                    else if (minus_radio.Checked == true)
                    {
                        if (amount_radio.Checked == true)
                        {
                            cost_after_txt.Text = (Convert.ToDecimal(cost_before_txt.Text) - Convert.ToDecimal(cost_txt.Text)).ToString();
                            bee3_after_txt.Text = (Convert.ToDecimal(bee3_before_txt.Text) - Convert.ToDecimal(bee3_txt.Text)).ToString();

                        }
                        else if (nesba_radio.Checked == true)
                        {
                            decimal cost_nesba = Convert.ToDecimal(cost_before_txt.Text) - (Convert.ToDecimal(cost_before_txt.Text) * (Convert.ToDecimal(cost_txt.Text) / 100));
                            cost_after_txt.Text = cost_nesba.ToString();

                            decimal bee3_nesba = Convert.ToDecimal(bee3_before_txt.Text) - (Convert.ToDecimal(bee3_before_txt.Text) * (Convert.ToDecimal(bee3_txt.Text) / 100));

                            bee3_after_txt.Text = bee3_nesba.ToString();

                        }
                    }
                }
                catch { }
            }
            else 
            {
                pro_name_txt.Clear(); cost_before_txt.Clear(); cost_after_txt.Clear(); bee3_before_txt.Clear(); bee3_after_txt.Clear();
               


            }
        }

        private void category_txt_TextChanged(object sender, EventArgs e)
        {
            category_txt_SelectedIndexChanged(sender, e);
        }

        private void amount_radio_CheckedChanged(object sender, EventArgs e)
        {
            category_txt_SelectedIndexChanged(sender, e);
        }

        private void nesba_radio_CheckedChanged(object sender, EventArgs e)
        {
            category_txt_SelectedIndexChanged(sender, e);
        }

        private void added_radio_CheckedChanged(object sender, EventArgs e)
        {
            category_txt_SelectedIndexChanged(sender, e);
        }

        private void minus_radio_CheckedChanged(object sender, EventArgs e)
        {
            category_txt_SelectedIndexChanged(sender, e);
        }

        private void cost_txt_TextChanged(object sender, EventArgs e)
        {
            category_txt_SelectedIndexChanged(sender, e);
        }

        private void bee3_txt_TextChanged(object sender, EventArgs e)
        {
            category_txt_SelectedIndexChanged(sender, e);
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            products_tableTableAdapter1.FillBy_category_stock(dataSet1.products_table, category_txt.Text,far3_txt.Text);
            try
            {
              
                foreach (DataRow dr in dataSet1.products_table.Rows)
                {
                    decimal cost_before = 0;
                    decimal bee3_before = 0;
                    decimal cost_after = 0;
                    decimal bee3_after = 0;

                    string pro_name= dr["pro_name"].ToString();
                    cost_before =Convert.ToDecimal(dr["pro_cost_price"]);
                    bee3_before=Convert.ToDecimal( dr["pro_bee3"]);
                    if (added_radio.Checked == true)
                    {
                        
                        if (amount_radio.Checked == true)
                        {
                            cost_after = cost_before + Convert.ToDecimal(cost_txt.Text);
                            bee3_after= bee3_before + Convert.ToDecimal(bee3_txt.Text);

                        }
                        else if (nesba_radio.Checked == true)
                        {
                            decimal cost_nesba = cost_before + (cost_before * (Convert.ToDecimal(cost_txt.Text) / 100));
                            cost_after = cost_nesba;

                            decimal bee3_nesba = bee3_before + (bee3_before * (Convert.ToDecimal(bee3_txt.Text) / 100));

                            bee3_after = bee3_nesba;

                        }
                    }
                    else if (minus_radio.Checked == true)
                    {
                        if (amount_radio.Checked == true)
                        {
                            cost_after= cost_before - Convert.ToDecimal(cost_txt.Text);//).ToString();
                            bee3_after = bee3_before- Convert.ToDecimal(bee3_txt.Text);

                        }
                        else if (nesba_radio.Checked == true)
                        {
                            decimal cost_nesba = cost_before - (cost_before * (Convert.ToDecimal(cost_txt.Text) / 100));
                            cost_after= cost_nesba;

                            decimal bee3_nesba = bee3_before - (bee3_before* (Convert.ToDecimal(bee3_txt.Text) / 100));

                            bee3_after = bee3_nesba;

                        }
                    }

                    products_tableTableAdapter1.Update_cost_and_bee3_and_gmhour_and_gomla_gomla(cost_after, bee3_after, bee3_after, bee3_after, pro_name);

                }
                MessageBox.Show("تم تعديل سعر الفئة بنجاح");
                category_txt_SelectedIndexChanged(sender, e);
                cost_txt.Text = "0"; bee3_txt.Text = "0";
            }
            catch { }
        }
    }
}
