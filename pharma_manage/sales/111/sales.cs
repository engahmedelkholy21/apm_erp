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
            }
            else if (comboBox1.Text == "بحث برقم الفاتورة")
            {
                groupBox1.Text = "بحث برقم الفاتورة";
                group_category.Visible = false;
                label10.Visible = false;
                label9.Visible = false;
                dateTimePicker7.Visible = false;
                dateTimePicker8.Visible = false;
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
            try
            {
                sales_fatora ff = new sales_fatora();

                ff.salesID_TXT.Text = a;
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

        private void sales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.stock_table' table. You can move, or remove it, as needed.
            this.stock_tableTableAdapter.Fill(this.dataSet1.stock_table);
            // TODO: This line of code loads data into the 'dataSet1.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.dataSet1.Category);

            this.sales_tableTableAdapter.Fill(this.dataSet1.sales_table);
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

                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[7].Value);


                }
                textBox1.Text = sum.ToString();
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
                        ff.usertxt.Text = usertxt.Text;
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
        
    }
}
