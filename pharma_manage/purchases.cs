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
    public partial class purchases : Form
    {
        public purchases()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;

            dateTimePicker8.Value = DateTime.Today;
            dateTimePicker7.Value = DateTime.Today;
        }

        private void purchases_Load(object sender, EventArgs e)
        {
           
        }
        private void DoSomethingAfterComponentsAreLoaded()
        {
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

            this.purchases_tableTableAdapter1.Fill(this.dataSet1.Purchases_table);

            if (comboBox1.Text == "بحث في يوم او فترة")
            {
                dateGroup.Visible = true;
                groupBox1.Visible = false;
            }
            else
            {
                dateGroup.Visible = false;
                groupBox1.Visible = true;
            }
            if (comboBox1.Text == "بحث باسم المنتج")
            {
                groupBox1.Text = "بحث باسم المنتج";

                this.purchases_tableTableAdapter1.Fill(this.dataSet1.Purchases_table);
                search_text.AutoCompleteMode = AutoCompleteMode.Suggest;
                search_text.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
                foreach (DataRow dr in dataSet1.Purchases_table.Rows)
                {
                    DataCollection.Add(dr["Purchases_product_name"].ToString());
                }

                search_text.AutoCompleteCustomSource = DataCollection;

            }
            else if (comboBox1.Text == "بحث باسم المورد")
            {
                groupBox1.Text = "بحث باسم المورد";

                this.purchases_tableTableAdapter1.Fill(this.dataSet1.Purchases_table);
                search_text.AutoCompleteMode = AutoCompleteMode.Suggest;
                search_text.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
                foreach (DataRow dr in dataSet1.Purchases_table.Rows)
                {
                    DataCollection.Add(dr["Purchases_mwared_name"].ToString());
                }

                search_text.AutoCompleteCustomSource = DataCollection;
            }
            else if (comboBox1.Text == "بحث برقم الفاتورة")
            {
                groupBox1.Text = "بحث برقم الفاتورة";
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dateTimePicker1.Value == dateTimePicker2.Value)
                {
                    purchases_tableTableAdapter1.FillBy_date(dataSet1.Purchases_table, dateTimePicker1.Value.ToShortDateString(),far3_txt.Text);
                }
                else if (dateTimePicker1.Value != dateTimePicker2.Value)
                {
                    purchases_tableTableAdapter1.FillBy_fatra(dataSet1.Purchases_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(),far3_txt.Text);
                }
            }
            catch { }
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (dateTimePicker1.Value == dateTimePicker2.Value)
                {
                    purchases_tableTableAdapter1.FillBy_date(dataSet1.Purchases_table, dateTimePicker1.Value.ToShortDateString(),far3_txt.Text);
                }
                else if (dateTimePicker1.Value != dateTimePicker2.Value)
                {
                    purchases_tableTableAdapter1.FillBy_fatra(dataSet1.Purchases_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(),far3_txt.Text);
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
                    purchases_tableTableAdapter1.FillBy_date(dataSet1.Purchases_table, dateTimePicker1.Value.ToShortDateString(),far3_txt.Text);
                }
                else if (dateTimePicker1.Value != dateTimePicker2.Value)
                {
                    purchases_tableTableAdapter1.FillBy_fatra(dataSet1.Purchases_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(),far3_txt.Text);
                }
            }
            catch { }
        }

        private void search_text_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "بحث باسم المورد")
            {
                purchases_tableTableAdapter1.FillBy_mwared_name_and_fatra(dataSet1.Purchases_table, search_text.Text, dateTimePicker8.Value.ToShortDateString(), dateTimePicker7.Value.ToShortDateString(),far3_txt.Text);
            }
            else if (comboBox1.Text == "بحث باسم المنتج")
            {
                purchases_tableTableAdapter1.FillBy_product_name(dataSet1.Purchases_table, search_text.Text,far3_txt.Text);
                if (dataGridView1.Rows.Count <= 0)
                {
                    purchases_tableTableAdapter1.FillBy_product_id(dataSet1.Purchases_table, search_text.Text,far3_txt.Text);
                    
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.purchases_tableTableAdapter1.Fill(this.dataSet1.Purchases_table);
      
        }

        private void search_text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comboBox1.Text == "بحث برقم الفاتورة")
                {
                    try
                    {
                        purchases_fatora ff = new purchases_fatora();

                        ff.salesID_TXT.Text = search_text.Text;
                        ff.Text = "مراجعة فاتورة شراء";
                        ff.far3txt.Text = far3_txt.Text;
                        ff.usertxt.Text = usertxt.Text;
                        ff.ShowDialog();

                    }
                    catch
                    {
                        MessageBox.Show("تأكد من رقم الفاتورة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

            string a = Convert.ToString(selectedRow.Cells[0].Value);
            //try
            //{
                purchases_fatora ff = new purchases_fatora();

                ff.salesID_TXT.Text = a;
                ff.Text = "مراجعة فاتورة شراء";
                ff.far3txt.Text = far3_txt.Text;
                ff.usertxt.Text = usertxt.Text;
                ff.ShowDialog();

            //}
            //catch
            //{
            //    MessageBox.Show("تأكد من رقم الفاتورة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //}
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "بحث في يوم او فترة")
            {
                dateGroup.Visible = true;
                groupBox1.Visible = false;
            }
            else
            {
                dateGroup.Visible = false;
                groupBox1.Visible = true;
            }
            if (comboBox1.Text == "بحث باسم المنتج")
            {
                groupBox1.Text = "بحث باسم المنتج";

                this.purchases_tableTableAdapter1.Fill(this.dataSet1.Purchases_table);
                search_text.AutoCompleteMode = AutoCompleteMode.Suggest;
                search_text.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
                foreach (DataRow dr in dataSet1.Purchases_table.Rows)
                {
                    DataCollection.Add(dr["Purchases_product_name"].ToString());
                }

                search_text.AutoCompleteCustomSource = DataCollection;
                label10.Visible = false;
                label9.Visible = false;
                dateTimePicker7.Visible = false;
                dateTimePicker8.Visible = false;

            }
            else if (comboBox1.Text == "بحث باسم المورد")
            {
                groupBox1.Text = "بحث باسم المورد";

                this.purchases_tableTableAdapter1.Fill(this.dataSet1.Purchases_table);
                search_text.AutoCompleteMode = AutoCompleteMode.Suggest;
                search_text.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
                foreach (DataRow dr in dataSet1.Purchases_table.Rows)
                {
                    DataCollection.Add(dr["Purchases_mwared_name"].ToString());
                }

                search_text.AutoCompleteCustomSource = DataCollection;
                label10.Visible = true;
                label9.Visible = true;
                dateTimePicker7.Visible = true;
                dateTimePicker8.Visible = true;

            }
            else if (comboBox1.Text == "بحث برقم الفاتورة")
            {
                groupBox1.Text = "بحث برقم الفاتورة";
                label10.Visible = false;
                label9.Visible = false;
                dateTimePicker7.Visible = false;
                dateTimePicker8.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                decimal sum = 0;
                decimal sum_keta3 = 0;

                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[7].Value);
                    sum_keta3 += Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);


                }
                textBox1.Text = sum.ToString();
                textBox2.Text = sum_keta3.ToString();
            }
            catch { }
        }

        private void dateTimePicker8_ValueChanged(object sender, EventArgs e)
        {
            purchases_tableTableAdapter1.FillBy_mwared_name_and_fatra(dataSet1.Purchases_table, search_text.Text, dateTimePicker8.Value.ToShortDateString(), dateTimePicker7.Value.ToShortDateString(),far3_txt.Text);
        
        }

        private void dateTimePicker7_ValueChanged(object sender, EventArgs e)
        {
            purchases_tableTableAdapter1.FillBy_mwared_name_and_fatra(dataSet1.Purchases_table, search_text.Text, dateTimePicker8.Value.ToShortDateString(), dateTimePicker7.Value.ToShortDateString(),far3_txt.Text);
        
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            purchases_print s = new purchases_print();
            s.Text = "طباعة المشتريات";
            s.far3txt.Text = far3_txt.Text;
            if (dateGroup.Visible == true)
            {
                s.label1.Text = "fatra";
                s.dateTimePicker1.Value = dateTimePicker1.Value;
                s.dateTimePicker2.Value = dateTimePicker2.Value;
               
                s.ShowDialog();
            }
            else if (comboBox1.Text == "بحث باسم المورد")
            {
                s.label1.Text = "cst";
                s.textBox1.Text = search_text.Text;
                s.dateTimePicker1.Value = dateTimePicker8.Value;
                s.dateTimePicker2.Value = dateTimePicker7.Value;
                s.ShowDialog();
            }
            else if (comboBox1.Text == "بحث باسم المنتج")
            {
                s.label1.Text = "pro";
                s.textBox1.Text = search_text.Text;
                //s.dateTimePicker1.Value = dateTimePicker8.Value;
                //s.dateTimePicker2.Value = dateTimePicker7.Value;
                s.ShowDialog();
            }

        }

        private void purchases_Shown(object sender, EventArgs e)
        {
            DoSomethingAfterComponentsAreLoaded();
        }

        private void far3_txt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
