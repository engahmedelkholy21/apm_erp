using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;


namespace pharma_manage
{
    public partial class show_tas3eer : Form
    {
        public show_tas3eer()
        {
            InitializeComponent();
        }

        private void show_tas3eer_Load(object sender, EventArgs e)
        {

            string param;
            string address_param = "امر شغل";

            param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";
            pharmacy_dataTableAdapter1.Fill(dataSet11.pharmacy_data);

            if (salesID_TXT.Text == "")
            {
                tas3eer_tableTableAdapter1.FillBy_stock(dataSet11.tas3eer_table,far3txt.Text);
            }
            else 
            {
                tas3eer_tableTableAdapter1.FillBy_tas3eer_id_and_stock(dataSet11.tas3eer_table,Convert.ToInt32(salesID_TXT.Text),far3txt.Text);
            }
            a4_fatora_tas3eer1.Refresh();
            a4_fatora_tas3eer1.SetDataSource(dataSet11);



            // MessageBox.Show(param);
            a4_fatora_tas3eer1.SetParameterValue("test", param);
            //amr_sho3l_report1.SetParameterValue("address_param", address_param);
            //amr_sho3l_tableTableAdapter1.Fill(dataSet11.amr_sho3l_table);

            crystalReportViewer1.RefreshReport();

            crystalReportViewer1.ReportSource = a4_fatora_tas3eer1;
            // 
            crystalReportViewer1.ReuseParameterValuesOnRefresh = true;




        }

        private void crystalReportViewer1_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
        {
            crystalReportViewer1.ReportRefresh += crystalReportViewer1_ReportRefresh;

        }
      
       
    }
}
