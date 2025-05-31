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
    public partial class ezn_create : Form
    {
        public ezn_create()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
        }

        private void ezn_create_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try 
            {
                if (cost_txt.Text == "") 
                {
                    MessageBox.Show("ادخل القيمة");
                    cost_txt.Focus();
                    return;
                }
                if (mostalem_txt.Text == "")
                {
                    MessageBox.Show("ادخل المستلم");
                    mostalem_txt.Focus();
                    return;
                }

                if (details_txt.Text == "")
                {
                    MessageBox.Show("ادخل تفاصيل العملية");
                    details_txt.Focus();
                    return;
                }

                ezn_sarfTableAdapter1.Insert(dateTimePicker1.Value, Convert.ToDecimal(cost_txt.Text), details_txt.Text, notes_txt.Text, usertxt.Text, mostalem_txt.Text);


                ezn_crystal1.Refresh();
                ezn_crystal1.SetDataSource(dataSet11);
                string param;

                param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";
                // MessageBox.Show(param);
                ezn_crystal1.SetParameterValue("test", param);

                pharmacy_dataTableAdapter1.Fill(dataSet11.pharmacy_data);


                ezn_sarfTableAdapter1.FillBy_date_cost_details_mostalem(dataSet11.ezn_sarf, dateTimePicker1.Value.ToShortDateString(), Convert.ToDecimal(cost_txt.Text), details_txt.Text, mostalem_txt.Text);

               
               
                StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_fwateer.txt");
                string printer_name = srr.ReadLine();

                ezn_crystal1.PrintOptions.PrinterName = printer_name;
                ezn_crystal1.PrintToPrinter(1, false, 0, 0);
                ezn_crystal1.Dispose();


                MessageBox.Show("تم الحفظ بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                details_txt.Clear(); cost_txt.Clear(); dateTimePicker1.Value = DateTime.Today; mostalem_txt.Clear();
                cost_txt.Focus();
            }
            catch { }
        }
    }
}
