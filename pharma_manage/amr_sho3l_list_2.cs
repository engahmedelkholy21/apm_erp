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
    public partial class amr_sho3l_list_2 : Form
    {
        public amr_sho3l_list_2()
        {
            InitializeComponent();
            Form1 f1 = new Form1();
            f1.SubscribeToLoadEvent(this);
            f1.ApplyFormStyling(this);
        }

        private void amr_sho3l_list_Load(object sender, EventArgs e)
        {
           
            string param;
            string address_param = "امر شغل";

            param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";
            pharmacy_dataTableAdapter1.Fill(dataSet11.pharmacy_data);

           
            amr_material_tableTableAdapter1.Fill(dataSet11.amr_material_table);
            amr_masrofat_tableTableAdapter1.Fill(dataSet11.amr_masrofat_table);

            amr_masrofat_crystal1.Refresh();
            amr_masrofat_crystal1.SetDataSource(dataSet11);

            amr_materials_crystal1.Refresh();
            amr_materials_crystal1.SetDataSource(dataSet11);

            amr_tableTableAdapter1.Fill(dataSet11.amr_table);
            amr_crystal1.Refresh();
            amr_crystal1.SetDataSource(dataSet11);



            // MessageBox.Show(param);
            //amr_sho3l_report1.SetParameterValue("test", param);
            //amr_sho3l_report1.SetParameterValue("address_param", address_param);
            //amr_sho3l_tableTableAdapter1.Fill(dataSet11.amr_sho3l_table);
          
            crystalReportViewer1.RefreshReport();

            crystalReportViewer1.ReportSource = amr_crystal1;
           // 
            crystalReportViewer1.ReuseParameterValuesOnRefresh = false;

        }
    }
}
