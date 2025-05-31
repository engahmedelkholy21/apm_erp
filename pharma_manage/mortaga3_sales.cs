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
    public partial class mortaga3_sales : Form
    {
        public mortaga3_sales()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
        }

        private void mortaga3_sales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.sales_mortaga3' table. You can move, or remove it, as needed.
            dateTimePicker1_ValueChanged(sender, e);
    
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.sales_mortaga3TableAdapter.Fill(this.dataSet1.sales_mortaga3);
    
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dateTimePicker1.Value == dateTimePicker2.Value)
                {
                    sales_mortaga3TableAdapter.FillBy_date(dataSet1.sales_mortaga3, dateTimePicker1.Value.ToShortDateString());
                }
                else if (dateTimePicker1.Value != dateTimePicker2.Value)
                {
                    sales_mortaga3TableAdapter.FillBy_fatra(dataSet1.sales_mortaga3, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
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
                    sales_mortaga3TableAdapter.FillBy_date(dataSet1.sales_mortaga3, dateTimePicker1.Value.ToShortDateString());
                }
                else if (dateTimePicker1.Value != dateTimePicker2.Value)
                {
                    sales_mortaga3TableAdapter.FillBy_fatra(dataSet1.sales_mortaga3, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
                }
            }
            catch { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try 
            {
                try
                {
                    decimal sum = 0;
                    decimal sum2 = 0;

                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[8].Value);

                        sum2 += Convert.ToDecimal(dataGridView1.Rows[i].Cells[6].Value);
                    }
                    textBox1.Text = sum.ToString();
                    textBox2.Text = sum2.ToString();
                }
                catch { }
            }
            catch { }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult ree = MessageBox.Show("هل تريد طباعة المرتجع ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ree == DialogResult.Yes)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                int mortaga3_id = Convert.ToInt32(selectedRow.Cells[0].Value);
                string cst_name = selectedRow.Cells[2].Value.ToString();

                pharmacy_dataTableAdapter1.Fill(dataSet1.pharmacy_data);
                madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet1.madeen_small_report, cst_name);

                mortaga3_crystal1.Refresh();
                mortaga3_crystal1.SetDataSource(dataSet1);
                string param;


                param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";

                mortaga3_crystal1.SetParameterValue("test", param);


                sales_mortaga3TableAdapter.FillBy_mortaga3_id(dataSet1.sales_mortaga3, mortaga3_id);

                StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_fwateer.txt");
                string printer_name = srr.ReadLine();

                mortaga3_crystal1.PrintOptions.PrinterName = printer_name;
                mortaga3_crystal1.PrintToPrinter(1, false, 0, 0);

                dateTimePicker1_ValueChanged(sender, e);



            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                sales_mortaga3TableAdapter.FillBy_mortaga3_id(dataSet1.sales_mortaga3, Convert.ToInt32(textBox3.Text));
            }
            catch { }
        }
    }
}
