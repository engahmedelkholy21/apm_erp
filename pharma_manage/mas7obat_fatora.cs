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
    public partial class mas7obat_fatora : Form
    {
        public mas7obat_fatora()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
        }

        private void mas7obat_fatora_Load(object sender, EventArgs e)
        {
            try
            {
                this.numbers_tableTableAdapter1.FillBy_stock(this.dataSet11.Numbers_table,far3txt.Text);
                salesID_TXT.Text = dataSet11.Numbers_table.Rows[0]["mas7obat_ID"].ToString();
            }
            catch { }

            suggest_product();

            cst_nameTXT.SelectAll();
            cst_nameTXT.Focus();
          
        }

        

        private void suggest_product()
        {
            this.products_tableTableAdapter1.Fill(this.dataSet11.products_table);
            product_nameTXT.AutoCompleteMode = AutoCompleteMode.Suggest;
            product_nameTXT.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet11.products_table.Rows)
            {
                DataCollection.Add(dr["pro_name"].ToString());
               // category_txt.Items.Add(dr["materials_category"].ToString());
            }


            product_nameTXT.AutoCompleteCustomSource = DataCollection;


            this.employee_tableTableAdapter1.Fill(this.dataSet11.employee_table);
            cst_nameTXT.AutoCompleteMode = AutoCompleteMode.Suggest;
            cst_nameTXT.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection2 = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet11.employee_table.Rows)
            {
                DataCollection2.Add(dr["employee_name"].ToString());
                // category_txt.Items.Add(dr["materials_category"].ToString());
            }

            cst_nameTXT.AutoCompleteCustomSource = DataCollection2;

        }

        string pro_id = "";
        decimal pro_count = 0;

        private void product_nameTXT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, product_nameTXT.Text,far3txt.Text);
                pro_id = dataSet11.products_table.Rows[0]["pro_ID"].ToString();
                pro_count = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);
                category_txt.Text = dataSet11.products_table.Rows[0]["pro_category"].ToString();
                raseed_now_txt.Text = dataSet11.products_table.Rows[0]["pro_count"].ToString();
                unit_price_txt.Text = dataSet11.products_table.Rows[0]["pro_cost_price"].ToString();
                this.AcceptButton = addbtn;
            }
            catch
            {
                pro_id = "";
                pro_count = 0;
                category_txt.Text = "";
                 unit_price_txt.Text = "";
                raseed_now_txt.Text = "";
                //limit_txt.Text = "";
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString() == product_nameTXT.Text)
                    {
                        MessageBox.Show("الصنف موجود بالفعل");
                        product_nameTXT.Select();
                        return;
                    }
                }

                if (countTXT.Text == "")
                {
                    MessageBox.Show("أدخل الكمية");
                    countTXT.Select();
                    return;
                }

                if (Convert.ToDecimal(countTXT.Text) > pro_count)
                {
                    MessageBox.Show("الكمية غير متاحة في مخزن الخامات");
                    countTXT.Select();
                    return;
                }
                else 
                {
                    dataGridView1.Rows.Add(pro_id.ToString(), product_nameTXT.Text, countTXT.Text,unit_price_txt.Text,"",category_txt.Text);
                    product_nameTXT.Clear(); countTXT.Clear();
                    product_nameTXT.Focus();

                }
               




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
            }
            catch 
            {

            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, selectedRow.Cells[1].Value.ToString(),far3txt.Text);

                raseed_now_txt.Text = dataSet11.products_table.Rows[0]["pro_count"].ToString();
            }
            catch { }

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

        private void savebtn_Click(object sender, EventArgs e)
        {
            //try 
            //{
                //update materials

                //insert ma5zoon
                foreach (DataGridViewRow dgr in dataGridView1.Rows)
                {

                    //insert ma5zoon
                    products_tableTableAdapter1.FillBy_int_code_and_far3(dataSet11.products_table, dgr.Cells[0].Value.ToString(),far3txt.Text);
                    decimal count_before = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);
                    decimal current_count = Convert.ToDecimal(dgr.Cells[2].Value);
                    decimal count_after = count_before -current_count;

                    ma5zoon_movesTableAdapter1.Insert_ma5zoon_moves_all(dateTimePicker1.Value.ToShortDateString(), dgr.Cells[0].Value.ToString(), dgr.Cells[1].Value.ToString(), current_count,
                        0, count_before, count_after, "سحب للانتاج", Convert.ToInt32(salesID_TXT.Text), cst_nameTXT.Text, user_txt.Text, far3txt.Text);

                     //insert mas7obat
                    mas7obat_tableTableAdapter1.Insert(Convert.ToInt32(salesID_TXT.Text), dateTimePicker1.Value, cst_nameTXT.Text, dgr.Cells[0].Value.ToString(), dgr.Cells[1].Value.ToString()
                        , Convert.ToDecimal(dgr.Cells[2].Value), dgr.Cells[5].Value.ToString(), amr_sho3l_txt.Text, user_txt.Text,Convert.ToDecimal(dgr.Cells[3].Value));

                   
                    // update materials
                    products_tableTableAdapter1.Update_count_BY_ID_bee3(Convert.ToDecimal(dgr.Cells[2].Value), Convert.ToDecimal(dgr.Cells[2].Value), dgr.Cells[0].Value.ToString(),far3txt.Text);


                }



                DialogResult d = MessageBox.Show("تم الحفظ بنجاح هل تريد طباعة الفاتورة ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (d == DialogResult.Yes)
                {
                    StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_a4.txt");
                    string printer_name = srr.ReadLine();

                    string param;
                    string address_param = "فاتورة مسحوبات";

                    param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";
                    pharmacy_dataTableAdapter1.Fill(dataSet11.pharmacy_data);
                    try
                    {
                        mas7obat_fatora_report1.Refresh();
                        mas7obat_fatora_report1.SetDataSource(dataSet11);


                        // MessageBox.Show(param);
                        mas7obat_fatora_report1.SetParameterValue("test", param);

                        mas7obat_fatora_report1.SetParameterValue("address_param", address_param);

                        mas7obat_tableTableAdapter1.FillBy_mas7obat_no(dataSet11.mas7obat_table, Convert.ToInt32(salesID_TXT.Text));
                        mas7obat_fatora_report1.PrintOptions.PrinterName = printer_name;
                        mas7obat_fatora_report1.PrintToPrinter(1, false, 0, 0);
                        mas7obat_fatora_report1.Dispose();
                        mas7obat_fatora_report1.Close();
                       mas7obat_fatora_report1.Refresh();
                    }
                    catch
                    { }
                }
                //update numbers
                numbers_tableTableAdapter1.Update_mas7obat_ID(far3txt.Text);

                dataGridView1.Rows.Clear();
                cst_nameTXT.Clear();
               

                mas7obat_fatora_Load(sender, e);
            //}
            //catch { }
        }

        private void amr_sho3l_txt_TextChanged(object sender, EventArgs e)
        {
            if (amr_sho3l_txt.Text == "")
            {
                dataGridView1.Rows.Clear();
            }
            else 
            {
                amr_material_tableTableAdapter1.FillBy_amr_num(dataSet11.amr_material_table, Convert.ToInt32(amr_sho3l_txt.Text));
                foreach (DataRow dr in dataSet11.amr_material_table.Rows)
                {
                    string material_name = dr["amr_material_material_name"].ToString();
                    decimal count_needed = Convert.ToDecimal(dr["amr_material_material_amount"]);
                    decimal cost = Convert.ToDecimal(dr["amr_material_unit_cost"]);
                    products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, material_name,far3txt.Text);
                    decimal count_exist = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);
                    string material_code = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();

                 //   MessageBox.Show(count_needed.ToString() + "   s  " + count_exist.ToString());
                    string material_category = dataSet11.products_table.Rows[0]["pro_category"].ToString();
                    if (count_needed > count_exist)
                    {
                        MessageBox.Show("كمية " + material_name + " غير كافية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        amr_sho3l_txt.Text = "";
                        dataGridView1.Rows.Clear();
                        return;
                    }
                    else
                    {
                        dataGridView1.Rows.Add(material_code, material_name, count_needed.ToString(),cost.ToString(),"", material_category);
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
                    }
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            decimal sum = 0;
            try
            {
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    dataGridView1.Rows[i].Cells[4].Value = (Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value) * Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value));
                  
                    sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                }
              
               textBox1.Text = sum.ToString("0.00");

                //decimal egmaly_after = sum + sum_dariba;
                //egmalyTXT.Text = egmaly_after.ToString("0.00"); ;
                //items_count_txt.Text = sum_items.ToString();

            }
            catch { }
        }
    }
}
