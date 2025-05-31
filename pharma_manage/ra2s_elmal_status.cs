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
    public partial class ra2s_elmal_status : Form
    {
        public ra2s_elmal_status()
        {
            InitializeComponent();
        }

        private void ra2s_elmal_status_Load(object sender, EventArgs e)
        {
            stock_tableTableAdapter1.Fill(dataSet11.stock_table);
           ListBox l=new ListBox();
            foreach(DataRow dr in dataSet11.stock_table.Rows)
            {
                l.Items.Add(dr["stock_name"].ToString());
            }
            foreach (var item in l.Items)
            {

                //     products_tableTableAdapter1.FillBy_stock_sum_cost(dataSet11.products_table, item.ToString());
                //     decimal sum_cost = Convert.ToDecimal(dataSet11.products_table.Rows[0]["sum_cost"]);
                //       products_tableTableAdapter1.FillBy_stock_sum_kata3y(dataSet11.products_table, item.ToString());
                //     decimal sum_kata3y=Convert.ToDecimal(dataSet11.products_table.Rows[0]["sum_kata3y"]);



                try
                {
                    this.products_tableTableAdapter1.FillBy_stock(this.dataSet11.products_table, item.ToString());
                    decimal sum = 0;
                    decimal sum2 = 0;
                    for (int i = 0; i < dataSet11.products_table.Rows.Count; ++i)
                    {
                        decimal price = Convert.ToDecimal(dataSet11.products_table.Rows[i]["pro_count"]) * Convert.ToDecimal(dataSet11.products_table.Rows[i]["pro_cost_price"]);
                        sum += price;
                        decimal price2 = Convert.ToDecimal(dataSet11.products_table.Rows[i]["pro_count"]) * Convert.ToDecimal(dataSet11.products_table.Rows[i]["pro_bee3"]);
                        sum2 += price2;


                    }
                    string sum_cost = Convert.ToString(sum.ToString("0.00"));
                    string sum_kata3y = Convert.ToString(sum2.ToString("0.00"));

               
                dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, item.ToString(), sum_cost, sum_kata3y);
                }
                catch { }

            }

            decimal sum_madeenen = 0;
            madeen_small_reportTableAdapter1.FillBy_TOTAL(dataSet11.madeen_small_report);
            if (dataSet11.madeen_small_report.Rows.Count > 0)
            {
                try
                {
                    sum_madeenen += Convert.ToDecimal(dataSet11.madeen_small_report.Rows[0]["TOTAL"]);
                }
                catch { }
            }
            decimal sum_aksat_ba2y = 0;
            aksat_tableTableAdapter1.FillBy_TOTAL_NOT_PAID(dataSet11.aksat_table);
            if (dataSet11.aksat_table.Rows.Count > 0)
            {
                try
                {
                    sum_aksat_ba2y += Convert.ToDecimal(dataSet11.aksat_table.Rows[0]["TOTAL_NOT_PAID"]);
                }
                catch { }
            }

            madeenen_txt.Text =(sum_aksat_ba2y+sum_madeenen).ToString();

            da2n_small_reportsTableAdapter1.FillBy_TOTAL(dataSet11.da2n_small_reports);
            da2neen_txt.Text = dataSet11.da2n_small_reports.Rows[0]["TOTAL"].ToString();


            assets_tableTableAdapter1.FillBy_TOTAL(dataSet11.assets_table);
            assets_txt.Text = dataSet11.assets_table.Rows[0]["TOTAL"].ToString();


            partners_share_tableTableAdapter1.FillBy_TOTAL(dataSet11.partners_share_table);
            try
            {
                ra2s_elmal_start_txt.Text = dataSet11.partners_share_table.Rows[0]["TOTAL"].ToString();
            }
            catch
            {
                ra2s_elmal_start_txt.Text = "0";

            }



            decimal total_income = 0;
            income_tableTableAdapter1.FillBy_income_total(dataSet11.income_table);
            try
            {
                 total_income = Convert.ToDecimal(dataSet11.income_table.Rows[0]["income_total"]);
            }
            catch
            {
              

            }

            decimal total_outcome =0;

            try
            {
                outcome_tableTableAdapter1.FillBy_outcome_total(dataSet11.outcome_table);
                total_outcome = Convert.ToDecimal(dataSet11.outcome_table.Rows[0]["outcome_total"]);
            }
            catch { }
            safe_raseed.Text = (total_income - total_outcome).ToString();



            foreach (GroupBox g in this.Controls.OfType<GroupBox>())
            {
                //g.BackColor = bc_color;
                //g.ForeColor = label_clr;
                foreach (TextBox b in g.Controls.OfType<TextBox>())
                {
                    if (b.Text == "") 
                    {
                        b.Text = "0";
                    }
                   // b.Cursor = Cursors.Hand;
                }
            }
           // safe_users_tableTableAdapter1.FillBy_TOTAL(dataSet11.safe_users_table);
           // safe_raseed.Text = dataSet11.safe_users_table.Rows[0]["TOTAL"].ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                decimal sum_cost = 0;
                decimal sum_bee3 = 0;


                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    sum_cost += Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value);
                    sum_bee3 += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);


                }
                total_cost_txt.Text = sum_cost.ToString("0.00");
                total_bee3_txt.Text = sum_bee3.ToString("0.00");
            }
            catch { }


            try 
            {
                ra2s_mal_current_with_osool_txt.Text= ((Convert.ToDecimal(assets_txt.Text)+Convert.ToDecimal(safe_raseed.Text) + Convert.ToDecimal(total_cost_txt.Text) + Convert.ToDecimal(madeenen_txt.Text)) - Convert.ToDecimal(da2neen_txt.Text)).ToString();
            }
            catch { }

            try
            {
                ra2s_mal_current_txt.Text = ((Convert.ToDecimal(safe_raseed.Text) + Convert.ToDecimal(total_cost_txt.Text) + Convert.ToDecimal(madeenen_txt.Text)) - Convert.ToDecimal(da2neen_txt.Text)).ToString();
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            safe_taswia s = new safe_taswia();
            s.current_txt.Text = safe_raseed.Text;
            s.far3_txt.Text = far3_txt.Text;
            s.user_txt.Text = user_txt.Text;
            Form1 f = new Form1();
            f.SubscribeToLoadEvent(s);
            f.ApplyFormStyling(s);
            s.ShowDialog();
            ra2s_elmal_status_Load(sender,e);
        }
    }
}
