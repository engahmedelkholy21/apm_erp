using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace pharma_manage
{
    public partial class ta7weel : Form
    {
        public ta7weel()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (stock_from.Text == "" || stock_to_txt.Text == "")
            {
                MessageBox.Show("ادخل الفروع");
                return;
            }


            if (product_nameTXT.Text == "")
            {
                MessageBox.Show("ادخل اسم المنتج");
                product_nameTXT.Focus();
                return;
            }

            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == product_nameTXT.Text)
                {
                    decimal count_in = Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value) + Convert.ToDecimal(countTXT.Text);
                    products_tableTableAdapter1.FillBy_int_code_and_far3(dataSet11.products_table, dataGridView1.Rows[i].Cells[0].Value.ToString(), stock_from.Text);

                    dataGridView1.Rows[i].Cells[2].Value = count_in.ToString();

                    products_tableTableAdapter1.FillBy_int_code_and_far3(dataSet11.products_table, product_nameTXT.Text, stock_from.Text);
                    decimal pro_count = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);
                    product_nameTXT.Clear();
                    product_nameTXT.Focus();
                    countTXT.Text = "1";
                    return;

                }


                if (dataGridView1.Rows[i].Cells[1].Value.ToString() == product_nameTXT.Text )
                {
                    try
                    {
                        decimal count_in = Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value) + Convert.ToDecimal(countTXT.Text);
                        string category_name = "";
                        products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, dataGridView1.Rows[i].Cells[1].Value.ToString(), stock_from.Text);

                        dataGridView1.Rows[i].Cells[2].Value = count_in.ToString();

                        product_nameTXT.Clear();
                        product_nameTXT.Focus();
                        countTXT.Text = "1";
                        return;

                    }
                    catch { }
                }
            }


            if (countTXT.Text == "")
            {
                MessageBox.Show("أدخل الكمية");
                countTXT.Select();
                return;
            }


            {

                string pro_code = "";
                string product_name;
               
                products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, product_nameTXT.Text, stock_from.Text);
                if (dataSet11.products_table.Rows.Count <= 0) 
                {
                    products_tableTableAdapter1.FillBy_int_code_and_far3(dataSet11.products_table,product_nameTXT.Text, stock_from.Text);
               
                }
                if (dataSet11.products_table.Rows.Count <= 0)
                {
                    MessageBox.Show("الصنف غير متاح في الفرع", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    product_nameTXT.Focus();
                    return;
                }
                pro_code = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                product_name = dataSet11.products_table.Rows[0]["pro_name"].ToString();
                decimal pro_count1 = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);
                decimal pro_cost = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_cost_price"]);


                if (Convert.ToDecimal(countTXT.Text) > pro_count1)
                {
                    MessageBox.Show("الكمية غير متاحه في الفرع", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    countTXT.Focus();
                    return;
                }
                else
                {
                    dataGridView1.Rows.Add(pro_code, product_name, countTXT.Text,pro_cost.ToString());
                    if (dataGridView1.Columns.Count == 5)
                    {
                        DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

                        btn.Width = 75;
                        btn.Text = "حذف";
                        btn.DefaultCellStyle.BackColor = Color.Red;
                        btn.Name = "الحذف";
                        btn.UseColumnTextForButtonValue = true;
                        dataGridView1.Columns.Add(btn);
                    }
                }
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1;
                countTXT.Text = "1";
                product_nameTXT.Clear();
                product_nameTXT.Focus();
            }
        }

        private void ta7weel_Load(object sender, EventArgs e)
        {
            this.stock_tableTableAdapter1.Fill(this.dataSet11.stock_table);
            foreach (DataRow dr in dataSet11.stock_table.Rows)
            {
                stock_from.Items.Add(dr["stock_name"].ToString());
                stock_to_txt.Items.Add(dr["stock_name"].ToString());
            }

            suggest_product();

            this.numbers_tableTableAdapter1.Fill(this.dataSet11.Numbers_table);
            salesID_TXT.Text = dataSet11.Numbers_table.Rows[0]["ta7weel_ID"].ToString();

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
                    DataCollection1.Add(dr["pro_name"].ToString());
                }

                product_nameTXT.AutoCompleteCustomSource = DataCollection1;
            }
            catch { }
        }

        private void product_nameTXT_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = addbtn;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
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

        private void savebtn_Click(object sender, EventArgs e)
        {
            save_ta7weel();

            DialogResult re = MessageBox.Show("تم التحويل بنجاح هل تريد طباعة الأمر ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (re == DialogResult.Yes)
            {
                pharmacy_dataTableAdapter1.Fill(dataSet11.pharmacy_data);

                a5_ta7weel_crystal_report1.Refresh();
                a5_ta7weel_crystal_report1.SetDataSource(dataSet11);


                //string param;

                //param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";
                //// MessageBox.Show(param);
                //a5_ta7weel_crystal_report1.SetParameterValue("test", param);

                ta7weel_tableTableAdapter1.FillBy_ta7weel_number(dataSet11.ta7weel_table, Convert.ToInt32(salesID_TXT.Text));


                StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_a4.txt");
                string printer_name = srr.ReadLine();
                a5_ta7weel_crystal_report1.PrintOptions.PrinterName = printer_name;
                a5_ta7weel_crystal_report1.PrintToPrinter(1, false, 0, 0);
            }
            this.Close();
        }

        private void save_ta7weel()
        {
            if (stock_from.Text == stock_to_txt.Text)
            {
                MessageBox.Show("لا يمكن التحويل من الفرع لنفسه");
                return;
            }
            if (stock_from.Text == "" || stock_to_txt.Text == "")
            {
                MessageBox.Show("ادخل الفروع");
                return;
            }
            //insert ma5zoon from
            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
               
                    products_tableTableAdapter1.FillBy_int_code_and_far3(dataSet11.products_table, dgr.Cells[0].Value.ToString(),stock_from.Text );
                    string pro_code = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                    string unit_price = dataSet11.products_table.Rows[0]["pro_bee3"].ToString();
                    decimal pro_count = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);
                    decimal pro_count_after = pro_count - Convert.ToDecimal(dgr.Cells[2].Value);
                    ma5zoon_movesTableAdapter1.Insert_ma5zoon_moves_all(dateTimePicker1.Value.ToShortDateString(), dgr.Cells[0].Value.ToString(), dgr.Cells[1].Value.ToString(), Convert.ToDecimal(dgr.Cells[2].Value),
                        0, pro_count, pro_count_after, "تحويل ل " + stock_to_txt.Text, Convert.ToInt32(salesID_TXT.Text),"", usertxt.Text, stock_from.Text);

               
            }


            //update from stock
            //products
            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
                
                    products_tableTableAdapter1.Update_count_BY_ID_bee3(Convert.ToDecimal(dgr.Cells[2].Value), Convert.ToDecimal(dgr.Cells[2].Value), dgr.Cells[0].Value.ToString(), stock_from.Text);
               
            }





           

            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {


                //insert product
                products_tableTableAdapter1.FillBy_int_code_and_far3(dataSet11.products_table, dgr.Cells[0].Value.ToString(), stock_to_txt.Text);
                if (dataSet11.products_table.Rows.Count <= 0)
                {
                    products_tableTableAdapter1.FillBy_int_code_and_far3(dataSet11.products_table, dgr.Cells[0].Value.ToString(), stock_from.Text);

                    string name_txt = dataSet11.products_table.Rows[0]["pro_name"].ToString();
                    string category_txt = dataSet11.products_table.Rows[0]["pro_category"].ToString();
                    string cost_txt = dataSet11.products_table.Rows[0]["pro_cost_price"].ToString();
                    string bee3_txt = dataSet11.products_table.Rows[0]["pro_bee3"].ToString();
                    string count_txt = "0";
                    string limit_txt = dataSet11.products_table.Rows[0]["pro_limit"].ToString();
                    //dateTimePicker1.Value = Convert.ToDateTime(dataSet11.products_table.Rows[0]["pro_expiration_date"]);
                    string mada_fa3ala_txt = dataSet11.products_table.Rows[0]["pro_mada_fa3ala"].ToString();
                    string marad_txt = dataSet11.products_table.Rows[0]["pro_marad"].ToString();
                    string nesba_saydaly_txt = dataSet11.products_table.Rows[0]["nesba_saydaly"].ToString();
                    string int_code_txt = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                    string pieces_in_packet_txt = dataSet11.products_table.Rows[0]["pro_pieces_in_packet"].ToString();
                    // string stock_txt = stock_to_txt.Text;
                    string gmhour_txt = dataSet11.products_table.Rows[0]["pro_bee3_2"].ToString();/// Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_pieces_in_packet"])).ToString();
                    string kata3y_txt = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_bee3"]).ToString();// / Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_pieces_in_packet"])).ToString();
                    string notes_txt = dataSet11.products_table.Rows[0]["pro_mada_fa3ala"].ToString();

                    decimal count_in_pieces = 0;



                    products_tableTableAdapter1.Insert_product(name_txt, category_txt, Convert.ToDecimal(cost_txt), Convert.ToDecimal(gmhour_txt), Convert.ToDecimal(count_txt),
                        Convert.ToDecimal(limit_txt), dateTimePicker1.Value.ToShortDateString(), mada_fa3ala_txt, marad_txt, "", "", usertxt.Text, Convert.ToDecimal(nesba_saydaly_txt), stock_to_txt.Text,
                        Convert.ToDecimal(pieces_in_packet_txt), count_in_pieces, Convert.ToDecimal(gmhour_txt), Convert.ToDecimal(kata3y_txt), int_code_txt, "تم الجرد", dateTimePicker1.Value.ToShortDateString());
                }


                // insert ma5zoon to
                try
                {
                    products_tableTableAdapter1.FillBy_int_code_and_far3(dataSet11.products_table, dgr.Cells[0].Value.ToString(), stock_to_txt.Text);
                    string pro_code = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                    string unit_price = dataSet11.products_table.Rows[0]["pro_bee3"].ToString();
                    decimal pro_count = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);
                    decimal pro_count_after = pro_count + Convert.ToDecimal(dgr.Cells[2].Value);
                    ma5zoon_movesTableAdapter1.Insert_ma5zoon_moves_all(dateTimePicker1.Value.ToShortDateString(), dgr.Cells[0].Value.ToString(), dgr.Cells[1].Value.ToString(), Convert.ToDecimal(dgr.Cells[2].Value),
                        Convert.ToDecimal(dgr.Cells[4].Value), pro_count, pro_count_after, "تحويل من " + stock_from.Text, Convert.ToInt32(salesID_TXT.Text), "", usertxt.Text, stock_to_txt.Text);
                }
                catch
                {


                    products_tableTableAdapter1.FillBy_int_code_and_far3(dataSet11.products_table, dgr.Cells[0].Value.ToString(), stock_to_txt.Text);
                    string pro_code = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                    string unit_price = dataSet11.products_table.Rows[0]["pro_bee3"].ToString();
                    decimal pro_count = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);
                    decimal pro_count_after = pro_count + Convert.ToDecimal(dgr.Cells[2].Value);
                    ma5zoon_movesTableAdapter1.Insert_ma5zoon_moves_all(dateTimePicker1.Value.ToShortDateString(), dgr.Cells[0].Value.ToString(), dgr.Cells[1].Value.ToString(), Convert.ToDecimal(dgr.Cells[2].Value),
                        0, pro_count, pro_count_after, "تحويل من " + stock_from.Text, Convert.ToInt32(salesID_TXT.Text), "", usertxt.Text, stock_to_txt.Text);

                }
              
            }


            //update to stock

            //products
            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
               
                    products_tableTableAdapter1.Update_count_BY_ID_buy(Convert.ToDecimal(dgr.Cells[2].Value), Convert.ToDecimal(dgr.Cells[2].Value), dgr.Cells[0].Value.ToString(), stock_to_txt.Text);
                
            }

            //insert ta7weelat


            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
                ta7weel_tableTableAdapter1.Insert(Convert.ToInt32(salesID_TXT.Text), dateTimePicker1.Value, stock_from.Text, stock_to_txt.Text, dgr.Cells[0].Value.ToString(), dgr.Cells[1].Value.ToString(), Convert.ToDecimal(dgr.Cells[2].Value), usertxt.Text,Convert.ToDecimal(dgr.Cells[3].Value));

            }

            numbers_tableTableAdapter1.Update_ta7weel_id();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                decimal old_count = Convert.ToDecimal(selectedRow.Cells[2].Value);
                string id = selectedRow.Cells[1].Value.ToString();
                products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, id, stock_from.Text);
                decimal pro_count;


                pro_count = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);

                if (Convert.ToDecimal(selectedRow.Cells[2].Value) > pro_count)
                {

                    //selectedRow.Cells[2].Value = "0";
                    //selectedRow.Cells[5].Value = "0";
                    dataGridView1.Rows.RemoveAt(selectedrowindex);
                    MessageBox.Show("الكمية غير متاحه في الفرع تم حذف الصنف برجاء اضافة الكمية الصحيحة مرة اخرى", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    //selectedRow.Selected = false;
                    // MessageBox.Show("gomla");
                    return;

                }
                else { return; }
            }
            catch { }
                    
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try 
            {
                decimal sum = 0;
                foreach (DataGridViewRow dgr in dataGridView1.Rows) 
                {
                    dgr.Cells[4].Value = (Convert.ToDecimal(dgr.Cells[2].Value) * Convert.ToDecimal(dgr.Cells[3].Value)).ToString();
                    sum += Convert.ToDecimal(dgr.Cells[4].Value);
                }
                matloobTXT.Text = sum.ToString();
            }
            catch { }
        }
    }
}
