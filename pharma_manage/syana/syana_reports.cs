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
    public partial class syana_reports : Form
    {
        public syana_reports()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
        }

        private void suggest_syana()
        {
            this.syana_tableTableAdapter.Fill(this.dataSet1.syana_table);
            search_text.AutoCompleteMode = AutoCompleteMode.Suggest;
            search_text.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet1.syana_table.Rows)
            {
                DataCollection.Add(dr["syana_cst_name"].ToString());
                DataCollection.Add(dr["syana_device_type"].ToString());
                DataCollection.Add(dr["syana_type"].ToString());
                
                
            }

            search_text.AutoCompleteCustomSource = DataCollection;

            


        }

        private void syana_reports_Load(object sender, EventArgs e)
        {
            suggest_syana();
            // TODO: This line of code loads data into the 'dataSet1.syana_table' table. You can move, or remove it, as needed.
            this.syana_tableTableAdapter.Fill(this.dataSet1.syana_table);
            // TODO: This line of code loads data into the 'dataSet1.Category' table. You can move, or remove it, as needed.

          // dateTimePicker1_ValueChanged(sender, e);


            int sum_green = 0;
            int sum_yellow = 0;
            int sum_red = 0;
            foreach (DataGridViewRow dgr in dataGridView1.Rows) 
            {
                if (dgr.Cells[14].Value.ToString() == "قيد الاصلاح") 
                {
                    dgr.DefaultCellStyle.BackColor=Color.Red;
                    sum_red += 1;
                }else if (dgr.Cells[14].Value.ToString() == "جاهزه للتسليم") 
                {
                    dgr.DefaultCellStyle.BackColor=Color.Yellow;
                    dgr.DefaultCellStyle.ForeColor = Color.Black;
                    sum_yellow += 1;

                }
                else if (dgr.Cells[14].Value.ToString() == "تم التسليم")
                {
                    dgr.DefaultCellStyle.BackColor = Color.Green;
                    dgr.DefaultCellStyle.ForeColor = Color.White;
                    sum_green+=1;
                }
            }
            red_txt.Text = sum_red.ToString();
            yellow_txt.Text = sum_yellow.ToString();
            green_txt.Text = sum_green.ToString();
        }


        private void delete_product_Click(object sender, EventArgs e)
        {
           
                if (status == "قيد الاصلاح") 
                {
                    syana_tanfeez t = new syana_tanfeez();
                    t.usertxt.Text = usertxt.Text;
                    t.far3txt.Text = far3txt.Text;
                    t.salesID_TXT.Text = fatora_id.ToString();
                    t.deliver_date.Value = delivery_date;
                    t.cst_name.Text = cst_name;
                    t.ShowDialog();
                }
                else if (status == "جاهزه للتسليم")
                {
                    tasleem_syana t = new tasleem_syana();
                    t.salesID_TXT.Text = fatora_id.ToString();
                    t.usertxt.Text = usertxt.Text;
                    t.far3txt.Text = far3txt.Text;
                    t.ShowDialog();
 
                }
               
               // 

            
            this.syana_tableTableAdapter.Fill(this.dataSet1.syana_table);

            int sum_green = 0;
            int sum_yellow = 0;
            int sum_red = 0;
            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
                if (dgr.Cells[14].Value.ToString() == "قيد الاصلاح")
                {
                    dgr.DefaultCellStyle.BackColor = Color.Red;
                    sum_red += 1;
                }
                else if (dgr.Cells[14].Value.ToString() == "جاهزه للتسليم")
                {
                    dgr.DefaultCellStyle.BackColor = Color.Yellow;
                    dgr.DefaultCellStyle.ForeColor = Color.Black;
                    sum_yellow += 1;

                }
                else if (dgr.Cells[14].Value.ToString() == "تم التسليم")
                {
                    dgr.DefaultCellStyle.BackColor = Color.Green;
                    dgr.DefaultCellStyle.ForeColor = Color.White;
                    sum_green += 1;
                }
            }
            red_txt.Text = sum_red.ToString();
            yellow_txt.Text = sum_yellow.ToString();
            green_txt.Text = sum_green.ToString();

        }

        private void delete_syana_click(object sender, EventArgs e) 
        {
              DialogResult re = MessageBox.Show("هل تريد حذف الفاتورة", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
              if (re == DialogResult.Yes)
              {
                  income_tableTableAdapter1.Delete_syana_by_fatora_no(fatora_id);
                  //decimal income_cost = Convert.ToDecimal(ba2y_txt.Text);
                  safeTableAdapter1.Update_sarf_from_safe(mosadad);

                  arba7_tableTableAdapter1.Delete_fatora_id_stock(fatora_id,far3txt.Text);
                  arba7_cat_tableTableAdapter1.Delete_fatora_id_stock(fatora_id,far3txt.Text);
                  //safe status daily
                  safeTableAdapter1.Insert_safe(DateTime.Today.ToShortDateString(), mosadad);
                  syana_ket3_gheiarTableAdapter1.FillBy_syana_no(dataSet1.syana_ket3_gheiar,fatora_id);

                  //insert ma5zoon
                  foreach (DataRow dr in dataSet1.syana_ket3_gheiar.Rows) 
                  { 
                      
                    

                      products_tableTableAdapter1.FillBy_int_code_and_far3(dataSet1.products_table, dr["syana_ket3_gheiar_int_code"].ToString(), far3txt.Text);
                      string pro_code = dataSet1.products_table.Rows[0]["pro_int_code"].ToString();
                     
                      decimal pro_count = Convert.ToDecimal(dataSet1.products_table.Rows[0]["pro_count"]);
                      decimal pro_count_after = pro_count + Convert.ToDecimal(dr["syana_ket3_gheiar_count"]);
                      string cost_price = dataSet1.products_table.Rows[0]["pro_cost_price"].ToString();

                      decimal unit_price = Convert.ToDecimal(dr["syana_ket3_gheiar_cost"]) / Convert.ToDecimal(dr["syana_ket3_gheiar_count"]);
                      ma5zoon_movesTableAdapter1.Insert_ma5zoon_moves_all(DateTime.Today.ToShortDateString(), dr["syana_ket3_gheiar_int_code"].ToString(), dr["syana_ket3_gheiar"].ToString(), Convert.ToDecimal(dr["syana_ket3_gheiar_count"]),
                         Convert.ToDecimal(dr["syana_ket3_gheiar_cost"]), pro_count, pro_count_after, "حذف صيانة", fatora_id, cst_name, usertxt.Text, far3txt.Text);
                  }

                  //update products
                  foreach (DataRow dr in dataSet1.syana_ket3_gheiar.Rows)
                  {
                      
                      products_tableTableAdapter1.Update_count_BY_ID_buy(Convert.ToDecimal(dr["syana_ket3_gheiar_count"]), Convert.ToDecimal(dr["syana_ket3_gheiar_count"]), dr["syana_ket3_gheiar_int_code"].ToString(), far3txt.Text);
                  }
                  syana_ket3_gheiarTableAdapter1.Delete_by_syana_no(fatora_id);
                  syana_tableTableAdapter.Delete_by_syana_no(fatora_id);

                  MessageBox.Show("تم الحذف بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  dateTimePicker1_ValueChanged(sender, e);
              }
        }
        int fatora_id;
        string status;
        DateTime delivery_date;
        string cst_name;
        decimal mosadad;
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {

                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                    fatora_id = Convert.ToInt32(selectedRow.Cells[0].Value);
                    status = selectedRow.Cells[14].Value.ToString();
                    cst_name = selectedRow.Cells[2].Value.ToString();
                    delivery_date = Convert.ToDateTime(selectedRow.Cells[6].Value);
                    mosadad = Convert.ToDecimal(selectedRow.Cells[12].Value);
                    var m = new ContextMenu();

                    if (status == "قيد الاصلاح")
                    {
                        var apply = new MenuItem("جاهزه للتسليم");
                        m.MenuItems.Add(apply);
                        apply.Click += delete_product_Click;
                    }
                    else if (status == "جاهزه للتسليم")
                    {
                        var apply = new MenuItem("تسليم");
                        m.MenuItems.Add(apply);
                        apply.Click += delete_product_Click;
                    }

                    var delete_syana = new MenuItem("حذف");
                    m.MenuItems.Add(delete_syana);
                    delete_syana.Click += delete_syana_click;
                    //  (mi);
                    // handle menu item click event here [as required]



                    int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                    m.Show(dataGridView1, new Point(e.X, e.Y));
                }
                catch { }
            }
        
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            search_text_TextChanged(sender, e);
            //if (comboBox1.Text != "")
            //{
            //    syana_tableTableAdapter.FillBy_recieve_date_fatra_status(dataSet1.syana_table, comboBox1.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
            //}
            //else 
            //{
            //    syana_tableTableAdapter.FillBy_recived_in_fatra(dataSet1.syana_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
            //}
            

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1_ValueChanged(sender, e);
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            dateTimePicker1_ValueChanged(sender, e);
        }

        private void search_text_TextChanged(object sender, EventArgs e)
        {
            try
            {
            syana_tableTableAdapter.FillBy_recived_fatra_and_cst_name(dataSet1.syana_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), search_text.Text);

            if (dataSet1.syana_table.Rows.Count <= 0)
            {
                syana_tableTableAdapter.FillBy_recived_fatra_device_type(dataSet1.syana_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), search_text.Text);

            }
            if (dataSet1.syana_table.Rows.Count <= 0)
            {
                syana_tableTableAdapter.FillBy_recieved_fatra_and_syana_type(dataSet1.syana_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), search_text.Text);

            }
            if (dataSet1.syana_table.Rows.Count <= 0)
            {
                try
                {
                    syana_tableTableAdapter.FillBy_syana_no(dataSet1.syana_table, Convert.ToInt32(search_text.Text));
                }
                catch 
                {
                    syana_tableTableAdapter.FillBy_recived_in_fatra(dataSet1.syana_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
                }
            }


               
                int sum_green = 0;
                int sum_yellow = 0;
                int sum_red = 0;
                foreach (DataGridViewRow dgr in dataGridView1.Rows)
                {
                    if (dgr.Cells[14].Value.ToString() == "قيد الاصلاح")
                    {
                        dgr.DefaultCellStyle.BackColor = Color.Red;
                        sum_red += 1;
                    }
                    else if (dgr.Cells[14].Value.ToString() == "جاهزه للتسليم")
                    {
                        dgr.DefaultCellStyle.BackColor = Color.Yellow;
                        dgr.DefaultCellStyle.ForeColor = Color.Black;
                        sum_yellow += 1;

                    }
                    else if (dgr.Cells[14].Value.ToString() == "تم التسليم")
                    {
                        dgr.DefaultCellStyle.BackColor = Color.Green;
                        dgr.DefaultCellStyle.ForeColor = Color.White;
                        sum_green += 1;
                    }
                }
                red_txt.Text = sum_red.ToString();
                yellow_txt.Text = sum_yellow.ToString();
                green_txt.Text = sum_green.ToString();
            }
            catch { }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTimePicker1_ValueChanged(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                int sum_green = 0;
                int sum_yellow = 0;
                int sum_red = 0;
                decimal sum_ket3 = 0;
                decimal sum_syana = 0;
                decimal sum_all = 0;

                foreach (DataGridViewRow dgr in dataGridView1.Rows)
                {
                    try
                    {
                        sum_all += Convert.ToDecimal(dgr.Cells[11].Value);
                        sum_ket3 += Convert.ToDecimal(dgr.Cells[9].Value);
                        sum_syana += Convert.ToDecimal(dgr.Cells[10].Value);
                    }
                    catch { }

                    if (dgr.Cells[14].Value.ToString() == "قيد الاصلاح")
                    {
                        dgr.DefaultCellStyle.BackColor = Color.Red;
                        sum_red += 1;
                    }
                    else if (dgr.Cells[14].Value.ToString() == "جاهزه للتسليم")
                    {
                        dgr.DefaultCellStyle.BackColor = Color.Yellow;
                        dgr.DefaultCellStyle.ForeColor = Color.Black;
                        sum_yellow += 1;

                    }
                    else if (dgr.Cells[14].Value.ToString() == "تم التسليم")
                    {
                        dgr.DefaultCellStyle.BackColor = Color.Green;
                        dgr.DefaultCellStyle.ForeColor = Color.White;
                        sum_green += 1;
                    }
                }
                red_txt.Text = sum_red.ToString();
                yellow_txt.Text = sum_yellow.ToString();
                green_txt.Text = sum_green.ToString();

                ket3_ghiar_total_txt.Text = sum_ket3.ToString();
                syana_total_txt.Text = sum_syana.ToString();
                total_all_txt.Text = sum_all.ToString();
            }
            catch { }
        }
    }
}
