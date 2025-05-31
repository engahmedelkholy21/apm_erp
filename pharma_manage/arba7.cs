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
    public partial class arba7 : Form
    {
        public arba7()
        {
            InitializeComponent();
            this.dateTimePicker1.Value = DateTime.Today;
            this.dateTimePicker2.Value = DateTime.Today;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2_ValueChanged(sender, e);
        }

        private void arba7_Load(object sender, EventArgs e)
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
 
            // TODO: This line of code loads data into the 'dataSet1.arba7_table' table. You can move, or remove it, as needed.
            arba7_tableTableAdapter1.FillBy_date_stock(dataSet1.arba7_table, dateTimePicker1.Value.ToShortDateString(),far3_txt.Text);
       
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (far3_txt.Text == "")
            {
                arba7_tableTableAdapter1.FillBy_fatra(dataSet1.arba7_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
            }
            else
            {
                arba7_tableTableAdapter1.FillBy_fatra_stock(dataSet1.arba7_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text);
            }
     
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                decimal sum_reb7 = 0;
                decimal sum_fwateer = 0;
                decimal sum_taklefa = 0;


                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    sum_reb7 += Convert.ToDecimal(dataGridView1.Rows[i].Cells[8].Value);
                    sum_fwateer += Convert.ToDecimal(dataGridView1.Rows[i].Cells[6].Value);

                    sum_taklefa += Convert.ToDecimal(dataGridView1.Rows[i].Cells[7].Value);

                }
                total_fatora_txt.Text = sum_fwateer.ToString();
                total_taklefa_txt.Text = sum_taklefa.ToString();
                total_reb7_txt.Text = sum_reb7.ToString();
            }
            catch { }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            arba7_report a = new arba7_report();
            a.dateTimePicker1.Value = dateTimePicker1.Value;
            a.dateTimePicker2.Value = dateTimePicker2.Value;
            a.far3txt.Text = far3_txt.Text;
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_a4.txt");
            //    string printer_name = srr.ReadLine();

            //    string param;
            //    string address = "تقرير الارباح في الفترة من " + dateTimePicker1.Value.ToString("yyyy/MM/dd") + " الى " + dateTimePicker2.Value.ToString("yyyy/MM/dd");

            //    param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";
            //    pharmacy_dataTableAdapter1.Fill(dataSet1.pharmacy_data);
               
            //        try
            //        {
            //            dateTimePicker2_ValueChanged(sender, e);
            //            arba7_egmaly_report1.Refresh();
            //            arba7_egmaly_report1.SetDataSource(dataSet1);

                       
            //            // MessageBox.Show(param);
            //            arba7_egmaly_report1.SetParameterValue("test", param);

            //            arba7_egmaly_report1.SetParameterValue("ket3", ket3_txt.Text);
            //            arba7_egmaly_report1.SetParameterValue("syana", syana_txt.Text);
            //            arba7_egmaly_report1.SetParameterValue("bee3", bee3_txt.Text);
            //            arba7_egmaly_report1.SetParameterValue("address", address);



            //            arba7_egmaly_report1.PrintOptions.PrinterName = printer_name;
            //            arba7_egmaly_report1.PrintToPrinter(1, false, 0, 0);
            //            arba7_egmaly_report1.Dispose();
                        
                        

            //        }catch{}
        }

        private void far3_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTimePicker2_ValueChanged(sender, e);
        }

        private void far3_txt_TextChanged(object sender, EventArgs e)
        {
            dateTimePicker2_ValueChanged(sender, e);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

            if (selectedRow.Cells[4].Value.ToString() != "0")
            {
                sales_fatora s = new sales_fatora();
                s.Text = "مراجعة فاتورة مبيعات";
                s.salesID_TXT.Text = selectedRow.Cells[4].Value.ToString();
                s.far3txt.Text = far3_txt.Text;
                s.ShowDialog();
            }
        }
    }
}
