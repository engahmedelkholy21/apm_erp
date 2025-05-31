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
    public partial class most7kat_da2neen_show : Form
    {
        public most7kat_da2neen_show()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;

            Form1 f1 = new Form1();
            f1.SubscribeToLoadEvent(this);
            f1.ApplyFormStyling(this);
        }

        private void most7kat_da2neen_show_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.mosta7akat_da2neen_table' table. You can move, or remove it, as needed.
           // this.mosta7akat_da2neen_tableTableAdapter.Fill(this.dataSet1.mosta7akat_da2neen_table);
            cst_name_txt_TextChanged(sender, e);
        }

        private void cst_name_txt_TextChanged(object sender, EventArgs e)
        {
            mosta7akat_da2neen_tableTableAdapter.FillBy_da2n_name_fatra(dataSet1.mosta7akat_da2neen_table, cst_name_txt.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
            try
            {
                dataGridView4.Rows[dataGridView4.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;

                string x = dataGridView4.Rows[dataGridView4.Rows.Count - 1].Cells[7].Value.ToString();

                dataGridView4.Rows.Add("", "", "", x);
            }
            catch { }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            cst_name_txt_TextChanged(sender, e);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            cst_name_txt_TextChanged(sender, e);
        }

        private void dataGridView4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedrowindex = dataGridView4.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView4.Rows[selectedrowindex];

                if (selectedRow.Cells[9].Value.ToString() != "0")
                {
                    //if (selectedRow.Cells[3].Value.ToString().Contains("مرتجع"))
                    //{
                    //    sell_mortaga3_reports s = new sell_mortaga3_reports();
                    //    s.cst_nameTXT.Text = selectedRow.Cells[9].Value.ToString();
                    //    s.ShowDialog();
                    //}
                    //else
                    //{

                    purchases_fatora s = new purchases_fatora();
                        s.Text = "مراجعة فاتورة مشتريات";
                        s.salesID_TXT.Text = selectedRow.Cells[9].Value.ToString();
                        s.ShowDialog();
                   // }
                }
            }
            catch { }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pharmacy_dataTableAdapter1.Fill(dataSet1.pharmacy_data);
            kashf_7esab_da2n_report1.Refresh();
            kashf_7esab_da2n_report1.SetDataSource(dataSet1);

            string param;

            param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";
            // MessageBox.Show(param);
            kashf_7esab_da2n_report1.SetParameterValue("test", param);


            string title = "عن الفترة من " + dateTimePicker1.Value.ToString("yyyy/MM/dd") + " الى " + dateTimePicker2.Value.ToString("yyyy/MM/dd");
            kashf_7esab_da2n_report1.SetParameterValue("title", title);
           // mosta7akat_tableTableAdapter.FillBy_cst_name_and_fatra(dataSet1.mosta7akat_table, cst_name_txt.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
            cst_name_txt_TextChanged(sender, e);
            StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_a4.txt");
            string printer_name = srr.ReadLine();
            kashf_7esab_da2n_report1.PrintOptions.PrinterName = printer_name;

            kashf_7esab_da2n_report1.PrintToPrinter(1, false, 0, 0);
            kashf_7esab_da2n_report1.Dispose();
            kashf_7esab_da2n_report1.Close();
        }

        private void dataGridView4_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
