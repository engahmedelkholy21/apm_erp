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
    public partial class mas7obat_list : Form
    {
        public mas7obat_list()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
        }

        private void mas7obat_list_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.mas7obat_table' table. You can move, or remove it, as needed.
            this.mas7obat_tableTableAdapter.Fill(this.dataSet1.mas7obat_table);
            suggest_cst_name();

        }

        private void suggest_cst_name()
        {
            this.mas7obat_tableTableAdapter.Fill(this.dataSet1.mas7obat_table);
            name_txt.AutoCompleteMode = AutoCompleteMode.Suggest;
            name_txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet1.mas7obat_table.Rows)
            {
                DataCollection.Add(dr["mas7obat_material_name"].ToString());
            }


            name_txt.AutoCompleteCustomSource = DataCollection;

        }

        private void name_txt_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                if (name_txt.Text == "")
                {
                    mas7obat_tableTableAdapter.FillBy_fatra(dataSet1.mas7obat_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
                }
                else 
                {
                    mas7obat_tableTableAdapter.FillBy_amr_sho3l(dataSet1.mas7obat_table, name_txt.Text);
                    if (dataSet1.mas7obat_table.Rows.Count <= 0) 
                    {
                        mas7obat_tableTableAdapter.FillBy_fatra_pro_name(dataSet1.mas7obat_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), name_txt.Text);
                         


                    }

                }

            }
            catch { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                decimal sum = 0;
                decimal sum_money = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);
                    sum_money += Convert.ToDecimal(dataGridView1.Rows[i].Cells[7].Value);
                }
                total_txt.Text = sum.ToString();
                textBox1.Text = sum_money.ToString();
                // MessageBox.Show(sum.ToString());
            }
            catch { }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            name_txt_TextChanged(sender, e);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            name_txt_TextChanged(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_a4.txt");
            string printer_name = srr.ReadLine();

            string param;
            string address_param = "تقرير مسحوبات";

            param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";
            pharmacy_dataTableAdapter1.Fill(dataSet1.pharmacy_data);
            //try
            //{
                mas7obat_list_report1.Refresh();
                mas7obat_list_report1.SetDataSource(dataSet1);


                // MessageBox.Show(param);
                mas7obat_list_report1.SetParameterValue("test", param);

                mas7obat_list_report1.SetParameterValue("address_param", address_param);

                dateTimePicker1_ValueChanged(sender, e);

                mas7obat_list_report1.PrintOptions.PrinterName = printer_name;
                mas7obat_list_report1.PrintToPrinter(1, false, 0, 0);
                mas7obat_list_report1.Dispose();
                mas7obat_list_report1.Close();
                mas7obat_list_report1.Refresh();
            //}
            //catch
            //{ }
        }
    }
}
