using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ZXing;

namespace pharma_manage
{
    public partial class select_printer_kashf_7esab : Form
    {
        public select_printer_kashf_7esab()
        {
            InitializeComponent();
            Form1 f1 = new Form1();
            f1.SubscribeToLoadEvent(this);
            f1.ApplyFormStyling(this);
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {


            if (reset_print.Checked == true) 
            {
                StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_fwateer.txt");
                string printer_name = srr.ReadLine();

                string param;

               
                param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";
                pharmacy_dataTableAdapter1.Fill(dataSet1.pharmacy_data);



                try
                {



                    pharmacy_dataTableAdapter1.Fill(dataSet1.pharmacy_data);
                    kashf_7esab_report_reset1.Refresh();
                    kashf_7esab_report_reset1.SetDataSource(dataSet1);

                    //string param;

                   // param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";
                    // MessageBox.Show(param);
                    kashf_7esab_report_reset1.SetParameterValue("test", param);


                    string title = "عن الفترة من " + dateTimePicker1.Value.ToString("yyyy/MM/dd") + " الى " + dateTimePicker2.Value.ToString("yyyy/MM/dd");
                    kashf_7esab_report_reset1.SetParameterValue("title", title);
                    mosta7akat_tableTableAdapter.FillBy_cst_name_and_fatra(dataSet1.mosta7akat_table, cst_name_txt.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());


                    kashf_7esab_report_reset1.PrintOptions.PrinterName = printer_name;

                    kashf_7esab_report_reset1.PrintToPrinter(1, false, 0, 0);
                    kashf_7esab_report_reset1.Dispose();
                    kashf_7esab_report_reset1.Close();


                    
                }
                catch { }
                
                   

            }
            else if (a5_print.Checked == true)
            {
                pharmacy_dataTableAdapter1.Fill(dataSet1.pharmacy_data);
                kashf_7esab_report_a52.Refresh();
                kashf_7esab_report_a52.SetDataSource(dataSet1);

                string param;

                param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";
                // MessageBox.Show(param);
                kashf_7esab_report_a52.SetParameterValue("test", param);


                string title = "عن الفترة من " + dateTimePicker1.Value.ToString("yyyy/MM/dd") + " الى " + dateTimePicker2.Value.ToString("yyyy/MM/dd");
                kashf_7esab_report_a52.SetParameterValue("title", title);
                mosta7akat_tableTableAdapter.FillBy_cst_name_and_fatra(dataSet1.mosta7akat_table, cst_name_txt.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());

                StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_a4.txt");
                string printer_name = srr.ReadLine();
                kashf_7esab_report_a52.PrintOptions.PrinterName = printer_name;

                kashf_7esab_report_a52.PrintToPrinter(1, false, 0, 0);
                kashf_7esab_report_a52.Dispose();
                kashf_7esab_report_a52.Close();

               



            }
            else if (a4_print.Checked == true)
            {
                pharmacy_dataTableAdapter1.Fill(dataSet1.pharmacy_data);
                kashf_7esab_report1.Refresh();
                kashf_7esab_report1.SetDataSource(dataSet1);

                string param;

                param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";
                // MessageBox.Show(param);
                kashf_7esab_report1.SetParameterValue("test", param);


                string title = "عن الفترة من " + dateTimePicker1.Value.ToString("yyyy/MM/dd") + " الى " + dateTimePicker2.Value.ToString("yyyy/MM/dd");
                kashf_7esab_report1.SetParameterValue("title", title);
                mosta7akat_tableTableAdapter.FillBy_cst_name_and_fatra(dataSet1.mosta7akat_table, cst_name_txt.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());

                StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_a4.txt");
                string printer_name = srr.ReadLine();
                kashf_7esab_report1.PrintOptions.PrinterName = printer_name;

                kashf_7esab_report1.PrintToPrinter(1, false, 0, 0);
                kashf_7esab_report1.Dispose();
                kashf_7esab_report1.Close();
            }
            this.Close();
        }

        private void select_printer_Load(object sender, EventArgs e)
        {

        }
    }
}
