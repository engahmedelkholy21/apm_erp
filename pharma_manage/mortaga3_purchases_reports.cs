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
    public partial class mortaga3_purchases_reports : Form
    {
        public mortaga3_purchases_reports()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
       
        }

        private void mortaga3_purchases_reports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.mortaga3_purchases' table. You can move, or remove it, as needed.
            this.mortaga3_purchasesTableAdapter.Fill(this.dataSet1.mortaga3_purchases);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.mortaga3_purchasesTableAdapter.Fill(this.dataSet1.mortaga3_purchases);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dateTimePicker1.Value == dateTimePicker2.Value)
                {
                    mortaga3_purchasesTableAdapter.FillBy_date(dataSet1.mortaga3_purchases, dateTimePicker1.Value.ToShortDateString());
                }
                else if (dateTimePicker1.Value != dateTimePicker2.Value)
                {
                    mortaga3_purchasesTableAdapter.FillBy_fatra(dataSet1.mortaga3_purchases, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
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
                    mortaga3_purchasesTableAdapter.FillBy_date(dataSet1.mortaga3_purchases, dateTimePicker1.Value.ToShortDateString());
                }
                else if (dateTimePicker1.Value != dateTimePicker2.Value)
                {
                    mortaga3_purchasesTableAdapter.FillBy_fatra(dataSet1.mortaga3_purchases, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
                }
            }
            catch { }
        
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult ree = MessageBox.Show("هل تريد طباعة المرتجع ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ree == DialogResult.Yes)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                int mortaga3_id = Convert.ToInt32(selectedRow.Cells[1].Value);
                string cst_name = selectedRow.Cells[3].Value.ToString();

                pharmacy_dataTableAdapter1.Fill(dataSet1.pharmacy_data);
                da2n_small_reportsTableAdapter1.FillBy_da2n_small_name(dataSet1.da2n_small_reports, cst_name);

                mortaga3_purchases_crystal1.Refresh();
                mortaga3_purchases_crystal1.SetDataSource(dataSet1);
                string param;


                param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";

                mortaga3_purchases_crystal1.SetParameterValue("test", param);


                mortaga3_purchasesTableAdapter.FillBy_mortaga3_id(dataSet1.mortaga3_purchases, mortaga3_id);

                StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_fwateer.txt");
                string printer_name = srr.ReadLine();

                mortaga3_purchases_crystal1.PrintOptions.PrinterName = printer_name;
                mortaga3_purchases_crystal1.PrintToPrinter(1, false, 0, 0);
            }
            dateTimePicker1_ValueChanged(sender, e);
        }
    }
}
