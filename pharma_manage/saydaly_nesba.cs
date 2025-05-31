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
    public partial class saydaly_nesba : Form
    {
        public saydaly_nesba()
        {
            InitializeComponent();
            this.dateTimePicker1.Value = DateTime.Today;
            this.dateTimePicker2.Value = DateTime.Today;
        }

        private void saydaly_nesba_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.saydaly_nesba' table. You can move, or remove it, as needed.
            

            this.saydaly_nesbaTableAdapter.Fill(this.dataSet1.saydaly_nesba);
            suggest_saydaly();

        }
        private void suggest_saydaly()
        {
            this.saydaly_nesbaTableAdapter.Fill(this.dataSet1.saydaly_nesba);
            name_txt.AutoCompleteMode = AutoCompleteMode.Suggest;
            name_txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet1.saydaly_nesba.Rows)
            {
                DataCollection.Add(dr["saydaly_name"].ToString());
            }

            name_txt.AutoCompleteCustomSource = DataCollection;

        }

        private void name_txt_TextChanged(object sender, EventArgs e)
        {
             sales_tableTableAdapter1.FillBy_ID_stock(dataSet1.sales_table, Convert.ToInt32(textBox1.Text),far3_txt.Text);

             try
             {

                 CrystalReport11.SetDataSource(dataSet1);
             }
             catch { }
            //saydaly_nesbaTableAdapter.FillBy_name_and_fatra(dataSet1.saydaly_nesba, name_txt.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            saydaly_nesbaTableAdapter.FillBy_name_and_fatra(dataSet1.saydaly_nesba, name_txt.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
       
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            saydaly_nesbaTableAdapter.FillBy_name_and_fatra(dataSet1.saydaly_nesba, name_txt.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
       
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                double sum=0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                  
                    sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                }
                egmaly_txt.Text = Convert.ToString(sum);
            }
            catch { }
        }
    }
}
