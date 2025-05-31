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
    public partial class pro_suggest_for_sell : Form
    {
        public pro_suggest_for_sell()
        {
            InitializeComponent();
            Form1 f1 = new Form1();
            f1.SubscribeToLoadEvent(this);
            f1.ApplyFormStyling(this);
        }

       public string btn_txt;

        private void pro_suggest_for_sell_Load(object sender, EventArgs e)
        {

            
            try 
            {
                if (stock_txt.Text == "")
                {
                    products_tableTableAdapter.FillBy_like_pro_name_and_far3_not_0(dataSet1.products_table, product_nameTXT.Text,stock_txt.Text);
                    if (dataSet1.products_table.Rows.Count <= 0)
                    {
                        products_tableTableAdapter.FillBy_pro_int_code(dataSet1.products_table, product_nameTXT.Text);

                    }
                }
                else 
                {
                    products_tableTableAdapter.FillBy_like_pro_name_and_far3_not_0(dataSet1.products_table, product_nameTXT.Text, stock_txt.Text);
                    if (dataSet1.products_table.Rows.Count <= 0)
                    {
                        products_tableTableAdapter.FillBy_pro_int_code(dataSet1.products_table, product_nameTXT.Text);

                    }
                }
                //foreach (DataGridViewRow dgr in dataGridView1.Rows)
                //{
                //    if (dataGridView1.Columns.Count == 6)
                //    {
                //        DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

                //        btn.Width = 75;
                //        if (btn_txt==null)
                //        {
                //            btn.Text = "كرتونة";
                //        }
                //        else
                //        {
                //            btn.Text = btn_txt;

                //        }
                //        btn.DefaultCellStyle.BackColor = Color.Red;
                //        btn.Name = "النوع";
                //        btn.UseColumnTextForButtonValue = true;


                //        dataGridView1.Columns.Add(btn);
                //    }

                //}
          


            this.dataGridView1.Sort(this.dataGridView1.Columns[1], ListSortDirection.Ascending);
            dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[1];
            }
            catch { }

           // dataGridView1.Rows[0].Cells[1].Selected = true;
        }
        public string Result;
        public string Result_stock;
        public string Result_type;
        public string Result_int_code;

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                Result = selectedRow.Cells[1].Value.ToString();
                Result_stock = selectedRow.Cells[2].Value.ToString();
                // Result_type = selectedRow.Cells[6].Value.ToString();
                Result_int_code = selectedRow.Cells[0].Value.ToString();

                


                if (Convert.ToDecimal(count_label.Text) > Convert.ToDecimal(selectedRow.Cells[3].Value))
                {

                    MessageBox.Show("الكمية غير متاحه");
                    return;
                }


                this.Close();
            }
            catch { }
        }

        private void product_nameTXT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                products_tableTableAdapter.FillBy_like_pro_name_and_far3_not_0(dataSet1.products_table, product_nameTXT.Text,stock_txt.Text);

               
            }
            catch { }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            try 
            {
                if (e.KeyCode ==Keys.Return)
                {
                    try
                    {
                        int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                        Result = selectedRow.Cells[1].Value.ToString();
                        Result_stock = selectedRow.Cells[2].Value.ToString();
                       // Result_type = selectedRow.Cells[6].Value.ToString();

                       


                        this.Close();
                    }
                    catch { }
                }

                //if (e.KeyCode == Keys.Space)
                //{
                //    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                //    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];



                //    // MessageBox.Show(selectedRow.Cells[5].Value.ToString());

                   
                //}
            }
            catch { }
        }

        private void pro_suggest_for_sell_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (Result_type == "")
            //{
            //    Result_type = "كرتونة";
            //}

        }

       
    }
}
