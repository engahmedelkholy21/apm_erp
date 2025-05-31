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
    public partial class syana_tanfeez : Form
    {
        public syana_tanfeez()
        {
            InitializeComponent();
            Form1 f1 = new Form1();
            f1.SubscribeToLoadEvent(this);
            f1.ApplyFormStyling(this);
        }

        private void syana_tanfeez_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.dataSet1.Category);
            suggest_product();

        }
        private void suggest_product()
        {
            try
            {
                this.products_tableTableAdapter1.Fill(this.dataSet11.products_table);
                product_nameTXT.AutoCompleteMode = AutoCompleteMode.Suggest;
                product_nameTXT.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection DataCollection1 = new AutoCompleteStringCollection();
                foreach (DataRow dr in dataSet11.products_table.Rows)
                {
                    if (dr["pro_category"].ToString().Contains("قطع غيار"))
                    {
                        DataCollection1.Add(dr["pro_name"].ToString());
                    }
                }

                product_nameTXT.AutoCompleteCustomSource = DataCollection1;
            }
            catch { }
        }
        private void savebtn_Click(object sender, EventArgs e)
        {
            try 
            {
               
                


                decimal all_cost=0;
                    // insert ma5zoon
                foreach (DataGridViewRow dgr in dataGridView1.Rows)
                {
                    
                products_tableTableAdapter1.FillBy_int_code_and_far3(dataSet11.products_table,dgr.Cells[0].Value.ToString(), far3txt.Text);
                    string pro_code = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                    string unit_price = dataSet11.products_table.Rows[0]["pro_bee3"].ToString();
                    decimal pro_count = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);
                    decimal pro_count_after = pro_count - Convert.ToDecimal(dgr.Cells[2].Value);
                    string cost_price = dataSet11.products_table.Rows[0]["pro_cost_price"].ToString();
                    ma5zoon_movesTableAdapter1.Insert_ma5zoon_moves_all(DateTime.Today.ToShortDateString(), dgr.Cells[0].Value.ToString(), dgr.Cells[1].Value.ToString(), Convert.ToDecimal(dgr.Cells[2].Value),
                        Convert.ToDecimal(dgr.Cells[4].Value), pro_count, pro_count_after, "تنفيذ صيانة", Convert.ToInt32(salesID_TXT.Text), cst_name.Text, usertxt.Text,far3txt.Text);

                    all_cost += Convert.ToDecimal(cost_price)*Convert.ToDecimal(dgr.Cells[2].Value);

                    decimal pro_cost_all=Convert.ToDecimal(cost_price)*Convert.ToDecimal(dgr.Cells[2].Value);
                     decimal pro_bee3_all=Convert.ToDecimal(unit_price)*Convert.ToDecimal(dgr.Cells[2].Value);

                     arba7_cat_tableTableAdapter1.Insert(DateTime.Today, dgr.Cells[1].Value.ToString(), pro_bee3_all - pro_cost_all, dgr.Cells[5].Value.ToString(), Convert.ToInt32(salesID_TXT.Text), "قطع غيار صيانة",far3txt.Text);

                }



                //update products  insert ket3 gheiar
                foreach (DataGridViewRow dgr in dataGridView1.Rows)
                {
                    products_tableTableAdapter1.Update_count_BY_ID_bee3(Convert.ToDecimal(dgr.Cells[2].Value), Convert.ToDecimal(dgr.Cells[2].Value), dgr.Cells[0].Value.ToString(), far3txt.Text);
                    syana_ket3_gheiarTableAdapter1.Insert(Convert.ToInt32(salesID_TXT.Text), dgr.Cells[1].Value.ToString(), Convert.ToDecimal(dgr.Cells[3].Value), Convert.ToDecimal(dgr.Cells[2].Value), usertxt.Text, far3txt.Text, dgr.Cells[0].Value.ToString());
                }


               // MessageBox.Show(all_cost.ToString());
                // update ket3 ghiar fe elsyana
                syana_tableTableAdapter1.Update_ket3_gheiar_by_syana_no(Convert.ToDecimal(matloobTXT.Text),Convert.ToInt32(salesID_TXT.Text));

                //insert arba7
                decimal profit=Convert.ToDecimal(matloobTXT.Text)-all_cost;
                arba7_tableTableAdapter1.Insert_arba7(DateTime.Today.ToShortDateString(),"ربح قطع غيار قاتورة صيانة رقم "+salesID_TXT.Text,profit,"قطع غيار",Convert.ToInt32(salesID_TXT.Text),
                   cst_name.Text,usertxt.Text,0,all_cost,far3txt.Text);

                // update status fe elsyana
                syana_tableTableAdapter1.Update_ready_for_delivery(Convert.ToInt32(salesID_TXT.Text));
               
               MessageBox.Show("تم الحفظ بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
               this.Close();
            }
            catch { }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            //try 
            //{
                foreach(DataGridViewRow dgr in dataGridView1.Rows)
                {
                    if(dgr.Cells[0].Value.ToString()==product_nameTXT.Text||dgr.Cells[1].Value.ToString()==product_nameTXT.Text)
                    {
                        MessageBox.Show("الصنف موجود مسبقا");
                        return;
                    }
                }

                products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, product_nameTXT.Text, far3txt.Text);
               
                if (dataSet11.products_table.Rows.Count <= 0) 
                {
                    products_tableTableAdapter1.FillBy_int_code_and_far3(dataSet11.products_table, product_nameTXT.Text, far3txt.Text);
               
                }

               string pro_code = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
               string product_name = dataSet11.products_table.Rows[0]["pro_name"].ToString();
               string unit_price = dataSet11.products_table.Rows[0]["pro_bee3"].ToString();
               string category = dataSet11.products_table.Rows[0]["pro_category"].ToString();

               decimal pro_count = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);
                if(Convert.ToDecimal(countTXT.Text)>pro_count)
                {
                     MessageBox.Show("الكمية غير موجوده");
                        return;
                }

                dataGridView1.Rows.Add(pro_code, product_name, countTXT.Text, unit_price, "", category);

                if (dataGridView1.Columns.Count == 6)
                {
                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

                    btn.Width = 75;
                    btn.Text = "حذف";
                    btn.DefaultCellStyle.BackColor = Color.Red;
                    btn.Name = "الحذف";
                    btn.UseColumnTextForButtonValue = true;


                    dataGridView1.Columns.Add(btn);
                }
            //}
            //catch { }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 6)
                {
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                    DialogResult re = MessageBox.Show("هل تريد حذف الصنف  " + selectedRow.Cells[1].Value.ToString() + " ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (re == DialogResult.Yes)
                    {
                        dataGridView1.Rows.Remove(selectedRow);
                    }
                }

            }
            catch { }
        }

        private void product_nameTXT_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = addbtn;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
                decimal sum = 0;
           // decimal sum_dariba = 0;

            try
            {
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    dataGridView1.Rows[i].Cells[4].Value = Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value) * Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value);
                   // sum_dariba += Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);
                    sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                }
                matloobTXT.Text=sum.ToString();
            }
            catch { }
        }
    }
}
