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
    public partial class sales : Form
    {
        public sales()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
            dateTimePicker3.Value = DateTime.Today;
            dateTimePicker4.Value = DateTime.Today;

            dateTimePicker6.Value = DateTime.Today;
            dateTimePicker5.Value = DateTime.Today;
            
            dateTimePicker8.Value = DateTime.Today;
            dateTimePicker7.Value = DateTime.Today;
    
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            search_text.AutoCompleteMode = AutoCompleteMode.None;
         //   search_text.AutoCompleteSource = AutoCompleteSource.CustomSource;
            if (comboBox1.Text == "بحث في يوم او فترة")
            {
                dateGroup.Visible = true;
                groupBox1.Visible = false;
                dateTimePicker1_ValueChanged(sender, e);
            }
            
            else
            {
                dateGroup.Visible = false;
                groupBox1.Visible = true;
                group_category.Visible = false;
            }
            if (comboBox1.Text == "بحث باسم المنتج")
            {
                groupBox1.Text = "بحث باسم المنتج";

                this.sales_tableTableAdapter.Fill(this.dataSet1.sales_table);
                search_text.AutoCompleteMode = AutoCompleteMode.Suggest;
                search_text.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
                foreach (DataRow dr in dataSet1.sales_table.Rows)
                {
                    DataCollection.Add(dr["sales_product_name"].ToString());
                }

                search_text.AutoCompleteCustomSource = DataCollection;
                group_category.Visible = false;
                dateTimePicker7.Visible = true;
                dateTimePicker8.Visible = true;

                search_text.Focus();

            }
            else if (comboBox1.Text == "بحث باسم العميل")
            {
                groupBox1.Text = "بحث باسم العميل";

                this.sales_tableTableAdapter.Fill(this.dataSet1.sales_table);
                search_text.AutoCompleteMode = AutoCompleteMode.Suggest;
                search_text.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
                foreach (DataRow dr in dataSet1.sales_table.Rows)
                {
                    DataCollection.Add(dr["sales_cst_name"].ToString());
                }

                search_text.AutoCompleteCustomSource = DataCollection;
                group_category.Visible = false;
                label10.Visible = true;
                label9.Visible = true;
                dateTimePicker7.Visible = true;
                dateTimePicker8.Visible = true;
                search_text.Focus();
            }
            else if (comboBox1.Text == "بحث بالموظف")
            {
                groupBox1.Text = "بحث بالموظف";

                this.sales_tableTableAdapter.Fill(this.dataSet1.sales_table);
                search_text.AutoCompleteMode = AutoCompleteMode.Suggest;
                search_text.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
                foreach (DataRow dr in dataSet1.sales_table.Rows)
                {
                    DataCollection.Add(dr["sales_user"].ToString());
                    DataCollection.Add(dr["sales_mandoob"].ToString());
                    DataCollection.Add(dr["sales_pro_stock"].ToString());
                }

                search_text.AutoCompleteCustomSource = DataCollection;
                group_category.Visible = false;
                label10.Visible = true;
                label9.Visible = true;
                dateTimePicker7.Visible = true;
                dateTimePicker8.Visible = true;
                search_text.Focus();
            }
            else if (comboBox1.Text == "بحث بنوع الفاتورة")
            {
                groupBox1.Text = "بحث بنوع الفاتورة";

                this.sales_tableTableAdapter.Fill(this.dataSet1.sales_table);
                search_text.AutoCompleteMode = AutoCompleteMode.Suggest;
                search_text.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
                
                    DataCollection.Add("رسمية");
                    DataCollection.Add("عادية");
                   
                

                search_text.AutoCompleteCustomSource = DataCollection;
                group_category.Visible = false;
                label10.Visible = true;
                label9.Visible = true;
                dateTimePicker7.Visible = true;
                dateTimePicker8.Visible = true;
                search_text.Focus();
            }
            else if (comboBox1.Text == "بحث برقم الفاتورة")
            {
                groupBox1.Text = "بحث برقم الفاتورة";
                group_category.Visible = false;
                label10.Visible = false;
                label9.Visible = false;
                dateTimePicker7.Visible = false;
                dateTimePicker8.Visible = false;
                search_text.Focus();
            }
            else if (comboBox1.Text == "بحث بعنوان العميل")
            {
                groupBox1.Text = "بحث بعنوان العميل";
                this.sales_tableTableAdapter.Fill(this.dataSet1.sales_table);
                search_text.AutoCompleteMode = AutoCompleteMode.Suggest;
                search_text.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
                foreach (DataRow dr in dataSet1.sales_table.Rows)
                {
                    DataCollection.Add(dr["sales_cst_address"].ToString());
                }

                search_text.AutoCompleteCustomSource = DataCollection;
                group_category.Visible = false;
                label10.Visible = false;
                label9.Visible = false;
                dateTimePicker7.Visible = false;
                dateTimePicker8.Visible = false;
                search_text.Focus();
            }
            else if (comboBox1.Text == "بحث بالفئة")
            {

                group_category.Visible = true;
                groupBox1.Visible = false;
                dateGroup.Visible = false;
                label10.Visible = false;
                label9.Visible = false;
                //dateTimePicker7.Visible = false;
                //dateTimePicker8.Visible = false;
                comboBox2.Focus();
            }
            else
            {
                group_category.Visible = false;
            }
            if (comboBox1.Text == "بحث كاش او قسط")
            {
                kashorkest_group.Visible = true;

                group_category.Visible = false;
                groupBox1.Visible = false;
                dateGroup.Visible = false;
                label10.Visible = false;
                label9.Visible = false;
                comboBox3.Focus();
            }
           
            else
            {
                kashorkest_group.Visible = false;
            }
           
        }

        private void search_text_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "بحث باسم العميل")
            {
                sales_tableTableAdapter.FillBy_Cst_Name_IN_fatra(dataSet1.sales_table, search_text.Text, dateTimePicker8.Value.ToShortDateString(), dateTimePicker7.Value.ToShortDateString(), far3_txt.Text);
                if (dataSet1.sales_table.Rows.Count <= 0) 
                {
                    try
                    {
                        customersTableAdapter1.FillBy_id(dataSet1.customers, Convert.ToInt32(search_text.Text));
                        if (dataSet1.customers.Rows.Count > 0)
                        {
                            string cst_name = dataSet1.customers.Rows[0]["cst_name"].ToString();
                            sales_tableTableAdapter.FillBy_Cst_Name_IN_fatra(dataSet1.sales_table, cst_name, dateTimePicker8.Value.ToShortDateString(), dateTimePicker7.Value.ToShortDateString(), far3_txt.Text);

                        }
                    }
                    catch { }
                }
            }
            else if (comboBox1.Text == "بحث باسم المنتج")
            {
                // لو هتبحث بالكود يبقى هنا
                sales_tableTableAdapter.FillBy_Product_Name_IN_fatra(dataSet1.sales_table, search_text.Text, dateTimePicker8.Value.ToShortDateString(), dateTimePicker7.Value.ToShortDateString(), far3_txt.Text);
                if (dataGridView1.Rows.Count <= 0) 
                {
                    sales_tableTableAdapter.FillBy_pro_id_and_fatra(dataSet1.sales_table, search_text.Text, dateTimePicker8.Value.ToShortDateString(), dateTimePicker7.Value.ToShortDateString(), far3_txt.Text);
               
                }
            }
            else if (comboBox1.Text == "بحث بالموظف")
            {
                sales_tableTableAdapter.FillBy_user(dataSet1.sales_table, search_text.Text, far3_txt.Text, dateTimePicker8.Value.ToShortDateString(), dateTimePicker7.Value.ToShortDateString());
                if (dataGridView1.Rows.Count <= 0) 
                {
                    sales_tableTableAdapter.FillBy_mandoob(dataSet1.sales_table, search_text.Text, far3_txt.Text, dateTimePicker8.Value.ToShortDateString(), dateTimePicker7.Value.ToShortDateString());
                }
                 if (dataGridView1.Rows.Count <= 0) 
                {
                    sales_tableTableAdapter.FillBy_far3(dataSet1.sales_table, search_text.Text, dateTimePicker8.Value.ToShortDateString(), dateTimePicker7.Value.ToShortDateString());
                }

            }
            //else if (comboBox1.Text == "بحث بنوع الفاتورة")
            //{
            //    sales_tableTableAdapter.FillBy_fatora_type_in_fatra(dataSet1.sales_table, dateTimePicker8.Value.ToShortDateString(), dateTimePicker7.Value.ToShortDateString(), search_text.Text);
            
 
            //}
            else if (comboBox1.Text == "بحث بعنوان العميل")
            {
                sales_tableTableAdapter.FillBy_cst_address(dataSet1.sales_table, search_text.Text, far3_txt.Text);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dateTimePicker1.Value == dateTimePicker2.Value)
                {
                    sales_tableTableAdapter.FillBy_Date(dataSet1.sales_table, dateTimePicker1.Value.ToShortDateString(), far3_txt.Text);
                }
                else if (dateTimePicker1.Value != dateTimePicker2.Value)
                {
                    sales_tableTableAdapter.FillBy_Fatra(dataSet1.sales_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text);
                }


            }
            catch { }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dateTimePicker1.Value == dateTimePicker2.Value)
                {
                    sales_tableTableAdapter.FillBy_Date(dataSet1.sales_table, dateTimePicker1.Value.ToShortDateString(), far3_txt.Text);
                }
                else if (dateTimePicker1.Value != dateTimePicker2.Value)
                {
                    sales_tableTableAdapter.FillBy_Fatra(dataSet1.sales_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text);
                }
            }
            catch { }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.sales_tableTableAdapter.Fill(this.dataSet1.sales_table);
     
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

            string a = Convert.ToString(selectedRow.Cells[0].Value);
            //try
            //{
                sales_fatora ff = new sales_fatora();

                ff.salesID_TXT.Text = a;
                ff.Text = "مراجعة فاتورة بيع";
                ff.usertxt.Text = usertxt.Text;
                ff.far3txt.Text = far3_txt.Text;
                ff.ShowDialog();

            //}
            //catch
            //{
            //    MessageBox.Show("تأكد من رقم الفاتورة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //}
        }

        private void sales_Load(object sender, EventArgs e)
        {

         

        }
        private void DoSomethingAfterComponentsAreLoaded()
        {
            try
            {
                this.stock_tableTableAdapter.Fill(this.dataSet1.stock_table);
                foreach (DataRow dr in dataSet1.stock_table.Rows)
                {
                    if (far3_txt.Items.Contains(dr["stock_name"].ToString()))
                    { }
                    else
                    {
                        far3_txt.Items.Add(dr["stock_name"].ToString());
                    }
                }
                // TODO: This line of code loads data into the 'dataSet1.Category' table. You can move, or remove it, as needed.
                this.categoryTableAdapter.Fill(this.dataSet1.Category);
                if (far3_txt.Items.Count > 1)
                {
                    sales_tableTableAdapter.FillBy_stock(dataSet1.sales_table, far3_txt.Text);
                }
                else
                {
                    sales_tableTableAdapter.FillBy_stock(dataSet1.sales_table, far3_txt.Text);
                }
            }
            catch { }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try 
            {
                sales_tableTableAdapter.FillBy_category_in_fatra(dataSet1.sales_table, comboBox2.Text, dateTimePicker4.Value.ToShortDateString(), dateTimePicker3.Value.ToShortDateString(),far3_txt.Text);
            }
            catch { }
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                sales_tableTableAdapter.FillBy_category_in_fatra(dataSet1.sales_table, comboBox2.Text, dateTimePicker4.Value.ToShortDateString(), dateTimePicker3.Value.ToShortDateString(),far3_txt.Text);
            }
            catch { }
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                sales_tableTableAdapter.FillBy_category_in_fatra(dataSet1.sales_table, comboBox2.Text, dateTimePicker4.Value.ToShortDateString(), dateTimePicker3.Value.ToShortDateString(), far3_txt.Text);
            }
            catch { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                decimal sum = 0;
                decimal sum_dariba = 0;

                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[7].Value);
                    sum_dariba += Convert.ToDecimal(dataGridView1.Rows[i].Cells[8].Value);
                }
                textBox1.Text = sum.ToString("0.00");
                dariba_txt.Text = sum_dariba.ToString("0.00");
                total_all_txt.Text = (sum + sum_dariba).ToString("0.00");
            }
            catch { }
        }

        private void search_text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comboBox1.Text == "بحث برقم الفاتورة")
                {
                    try
                    {
                        sales_fatora ff = new sales_fatora();

                        ff.salesID_TXT.Text = search_text.Text;
                        ff.Text = "مراجعة فاتورة بيع";
                        ff.usertxt.Text = usertxt.Text;
                        ff.far3txt.Text = far3_txt.Text;
                        ff.ShowDialog();

                    }
                    catch
                    {
                        MessageBox.Show("تأكد من رقم الفاتورة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else if (comboBox1.Text == "بحث بالموظف")
                {
                    sales_tableTableAdapter.FillBy_user(dataSet1.sales_table, search_text.Text, far3_txt.Text ,dateTimePicker8.Value.ToShortDateString(), dateTimePicker7.Value.ToShortDateString());
                    if (dataGridView1.Rows.Count <= 0)
                    {
                        sales_tableTableAdapter.FillBy_mandoob(dataSet1.sales_table, search_text.Text, far3_txt.Text, dateTimePicker8.Value.ToShortDateString(), dateTimePicker7.Value.ToShortDateString());
                    }
                    if (dataGridView1.Rows.Count <= 0)
                    {
                        sales_tableTableAdapter.FillBy_far3(dataSet1.sales_table, search_text.Text, dateTimePicker8.Value.ToShortDateString(), dateTimePicker7.Value.ToShortDateString());
                    }
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try 
            {
                sales_tableTableAdapter.FillBy_kash_or_kest_in_fatra(dataSet1.sales_table, comboBox3.Text, dateTimePicker6.Value.ToShortDateString(), dateTimePicker5.Value.ToShortDateString(), far3_txt.Text);
            }
            catch { }
        }

        private void dateTimePicker6_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                sales_tableTableAdapter.FillBy_kash_or_kest_in_fatra(dataSet1.sales_table, comboBox3.Text, dateTimePicker6.Value.ToShortDateString(), dateTimePicker5.Value.ToShortDateString(), far3_txt.Text);
            }
            catch { }
        }

        private void dateTimePicker5_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                sales_tableTableAdapter.FillBy_kash_or_kest_in_fatra(dataSet1.sales_table, comboBox3.Text, dateTimePicker6.Value.ToShortDateString(), dateTimePicker5.Value.ToShortDateString(), far3_txt.Text);
            }
            catch { }
        }

        private void dateTimePicker8_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "بحث باسم المنتج")
            {
                sales_tableTableAdapter.FillBy_Product_Name_IN_fatra(dataSet1.sales_table, search_text.Text, dateTimePicker8.Value.ToShortDateString(), dateTimePicker7.Value.ToShortDateString(), far3_txt.Text);
                if (dataGridView1.Rows.Count <= 0)
                {
                    sales_tableTableAdapter.FillBy_pro_id_and_fatra(dataSet1.sales_table, search_text.Text, dateTimePicker8.Value.ToShortDateString(), dateTimePicker7.Value.ToShortDateString(), far3_txt.Text);

                }
            }
            else if (comboBox1.Text == "بحث باسم العميل")
            {
                sales_tableTableAdapter.FillBy_Cst_Name_IN_fatra(dataSet1.sales_table, search_text.Text, dateTimePicker8.Value.ToShortDateString(), dateTimePicker7.Value.ToShortDateString(), far3_txt.Text);
            }
            else if (comboBox1.Text == "بحث بالموظف")
            {
                sales_tableTableAdapter.FillBy_user(dataSet1.sales_table, search_text.Text, far3_txt.Text, dateTimePicker8.Value.ToShortDateString(), dateTimePicker7.Value.ToShortDateString());
                if (dataGridView1.Rows.Count <= 0)
                {
                    sales_tableTableAdapter.FillBy_mandoob(dataSet1.sales_table, search_text.Text, far3_txt.Text, dateTimePicker8.Value.ToShortDateString(), dateTimePicker7.Value.ToShortDateString());
                }
                if (dataGridView1.Rows.Count <= 0)
                {
                    sales_tableTableAdapter.FillBy_far3(dataSet1.sales_table, search_text.Text, dateTimePicker8.Value.ToShortDateString(), dateTimePicker7.Value.ToShortDateString());
                }
            }

        }

        private void dateTimePicker7_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "بحث باسم المنتج")
            {
                sales_tableTableAdapter.FillBy_Product_Name_IN_fatra(dataSet1.sales_table, search_text.Text, dateTimePicker8.Value.ToShortDateString(), dateTimePicker7.Value.ToShortDateString(), far3_txt.Text);
                if (dataGridView1.Rows.Count <= 0)
                {
                    sales_tableTableAdapter.FillBy_pro_id_and_fatra(dataSet1.sales_table, search_text.Text, dateTimePicker8.Value.ToShortDateString(), dateTimePicker7.Value.ToShortDateString(), far3_txt.Text);

                }
            }
            else if (comboBox1.Text == "بحث باسم العميل")
            {
                sales_tableTableAdapter.FillBy_Cst_Name_IN_fatra(dataSet1.sales_table, search_text.Text, dateTimePicker8.Value.ToShortDateString(), dateTimePicker7.Value.ToShortDateString(),far3_txt.Text);
            }
            else if (comboBox1.Text == "بحث بالموظف")
            {
                sales_tableTableAdapter.FillBy_user(dataSet1.sales_table, search_text.Text, far3_txt.Text, dateTimePicker8.Value.ToShortDateString(), dateTimePicker7.Value.ToShortDateString());
                if (dataGridView1.Rows.Count <= 0)
                {
                    sales_tableTableAdapter.FillBy_mandoob(dataSet1.sales_table, search_text.Text, far3_txt.Text, dateTimePicker8.Value.ToShortDateString(), dateTimePicker7.Value.ToShortDateString());
                }
                if (dataGridView1.Rows.Count <= 0)
                {
                    sales_tableTableAdapter.FillBy_far3(dataSet1.sales_table, search_text.Text, dateTimePicker8.Value.ToShortDateString(), dateTimePicker7.Value.ToShortDateString());
                }
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sales_print s = new sales_print();
            s.Text = "طباعة المبيعات";
            if (dateGroup.Visible == true) 
            {
                DialogResult re = MessageBox.Show("هل تريد طباعة تقرير", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (re == DialogResult.Yes)
                {
                    StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_fwateer.txt");
                    string printer_name = srr.ReadLine();

                    string param;
                    string title;
                    if (dateTimePicker1.Value == dateTimePicker2.Value)
                    {
                        title = "تقرير مبيعات يوم " + dateTimePicker1.Value.ToShortDateString();
                    }
                    else 
                    {
                        title = "تقرير مبيعات من " + dateTimePicker1.Value.ToShortDateString()+" الى " + dateTimePicker2.Value.ToShortDateString();
                    }

                    param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";
                    pharmacy_dataTableAdapter1.Fill(dataSet1.pharmacy_data);

                    try
                    {
                        // madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet11.madeen_small_report, cst_name_txt.Text);

                        sales_detailed_report_grouped1.Refresh();
                        sales_detailed_report_grouped1.SetDataSource(dataSet1);

                        // MessageBox.Show(param);
                        sales_detailed_report_grouped1.SetParameterValue("test", param);
                         sales_detailed_report_grouped1.SetParameterValue("title",title);
                        
                        sales_tableTableAdapter.FillBy_Fatra(dataSet1.sales_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text);
                        SaveFileDialog sf = new SaveFileDialog();
                        sf.Filter = "PDF (*.pdf)|*.pdf";
                        string ss = dateTimePicker1.Value.ToShortDateString().Replace("/","-");
                       
                        if (dateTimePicker1.Value == dateTimePicker2.Value)
                        {
                            sf.FileName = "تقرير مبيعات يوم " + ss;
                           
                        }
                        else
                        {
                            string ss2 = dateTimePicker2.Value.ToShortDateString().Replace("/", "-");
                             sf.FileName  = "تقرير مبيعات من " +ss + " الى " + ss2;
                        }
                        
                     
                        if (sf.ShowDialog() == DialogResult.OK)
                        {
                            FileInfo path_file = new FileInfo(sf.FileName);
                            string name = sf.FileName;
                            //name = name.Replace("/", "-");

                            //MessageBox.Show(name);
                            sales_detailed_report_grouped1.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, path_file.ToString());
                            System.Diagnostics.Process.Start(path_file.ToString());
                        }
                        sales_detailed_report_grouped1.PrintOptions.PrinterName = printer_name;
                        sales_detailed_report_grouped1.PrintToPrinter(1, false, 0, 0);
                        //sales_detailed_report_grouped1.Dispose();


                    }
                    catch { }
                }
                s.label1.Text = "fatra";
                s.dateTimePicker1.Value = dateTimePicker1.Value;
                s.dateTimePicker2.Value = dateTimePicker2.Value;
                s.far3txt.Text = far3_txt.Text;
                s.ShowDialog();
            }
            else if (comboBox1.Text == "بحث باسم العميل")
            {
                s.label1.Text = "cst";
                s.textBox1.Text = search_text.Text;
                s.dateTimePicker1.Value = dateTimePicker8.Value;
                s.dateTimePicker2.Value = dateTimePicker7.Value;
                s.far3txt.Text = far3_txt.Text;
           

                StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_fwateer.txt");
                string printer_name = srr.ReadLine();

                string param;

                param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";
                pharmacy_dataTableAdapter1.Fill(dataSet1.pharmacy_data);

                try
                {
                    // madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet11.madeen_small_report, cst_name_txt.Text);

                    sales_report_crystal_grouped1.Refresh();
                    sales_report_crystal_grouped1.SetDataSource(dataSet1);

                    // MessageBox.Show(param);
                    sales_report_crystal_grouped1.SetParameterValue("test", param);

                    sales_tableTableAdapter.FillBy_CST_And_Fatra(dataSet1.sales_table, search_text.Text, dateTimePicker8.Value.ToShortDateString(), dateTimePicker7.Value.ToShortDateString(),far3_txt.Text);


                    sales_report_crystal_grouped1.PrintOptions.PrinterName = printer_name;
                    sales_report_crystal_grouped1.PrintToPrinter(1, false, 0, 0);
                    sales_report_crystal_grouped1.Dispose();


                }
                catch { }



                s.ShowDialog();
            }
            else if (comboBox1.Text == "بحث باسم المنتج")
            {
                s.label1.Text = "pro";
                s.textBox1.Text = search_text.Text;
                s.dateTimePicker1.Value = dateTimePicker8.Value;
                s.dateTimePicker2.Value = dateTimePicker7.Value;
                s.far3txt.Text = far3_txt.Text;
                s.ShowDialog();
            }
        }

        private void far3_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sales_tableTableAdapter.FillBy_stock(dataSet1.sales_table, far3_txt.Text);
            }
            catch { }
        }

        private void far3_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                far3_txt_SelectedIndexChanged(sender, e);
            }
            catch { }
        }

        private void sales_Shown(object sender, EventArgs e)
        {
            DoSomethingAfterComponentsAreLoaded();
        }

        private void btn_gomla_Click(object sender, EventArgs e)
        {
            sales_best_selling ss = new sales_best_selling();
            ss.Text = btn_gomla.Text;
            ss.far3_txt.Text = far3_txt.Text;
            Form1 f = new Form1();
            f.SubscribeToLoadEvent(ss);
            f.ApplyFormStyling(ss);
            ss.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sales_best_selling_category ss = new sales_best_selling_category();
            ss.Text = btn_gomla.Text;
            ss.far3_txt.Text = far3_txt.Text;
            Form1 f = new Form1();
            f.SubscribeToLoadEvent(ss);
            f.ApplyFormStyling(ss);
            ss.ShowDialog();
        }

        
        
    }
}
