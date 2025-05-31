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
    public partial class nwa2es_print : Form
    {
        public nwa2es_print()
        {
            InitializeComponent();
        }

        private void nwa2es_print_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.nwa2es' table. You can move, or remove it, as needed.
            this.nwa2esTableAdapter.Fill(this.DataSet1.nwa2es);
            // TODO: This line of code loads data into the 'DataSet1.pharmacy_data' table. You can move, or remove it, as needed.
            this.pharmacy_dataTableAdapter.Fill(this.DataSet1.pharmacy_data);

            this.reportViewer1.RefreshReport();

            //crystal_nwa2es1.Refresh();
            //crystal_nwa2es1.SetDataSource(DataSet1);

            //crystalReportViewer1.RefreshReport();
        }

        private void edit_productbtn_Click(object sender, EventArgs e)
        {
            this.nwa2esTableAdapter.Fill(this.DataSet1.nwa2es);

            crystal_nwa2es1.Refresh();
            crystal_nwa2es1.SetDataSource(DataSet1);

            string param;

            param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";
            // MessageBox.Show(param);
            crystal_nwa2es1.SetParameterValue("test", param);


            StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_fwateer.txt");
            string printer_name = srr.ReadLine();


            crystal_nwa2es1.PrintOptions.PrinterName = printer_name;
            crystal_nwa2es1.PrintToPrinter(1, false, 0, 0);
        }
    }
}
