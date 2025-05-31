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
    public partial class outcome_report_form : Form
    {
        public outcome_report_form()
        {
            InitializeComponent();
        }

        private void outcome_report_form_Load(object sender, EventArgs e)
        {
            //if (far3_txt.Text != "")
            //{
            //    outcome_tableTableAdapter1.FillBy_fatra_far3(dataSet111.outcome_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text);

            //}
            //else
            //{
            //    if (cst_nameTXT.Text == "")
            //    {

            //        if (dateTimePicker1.Value == dateTimePicker2.Value)
            //        {
            //            outcome_tableTableAdapter1.FillBy_date(dataSet111.outcome_table, dateTimePicker1.Value.ToShortDateString());
            //        }
            //        else if (dateTimePicker1.Value != dateTimePicker2.Value)
            //        {
            //            outcome_tableTableAdapter1.FillBy_fatra(dataSet111.outcome_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());

            //        }
            //    }
            //    else
            //    {
            //        outcome_tableTableAdapter1.FillBy_esm_elmashroo3_in_fatra(dataSet111.outcome_table, cst_nameTXT.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
            //    }
            //}

            string title = "";
            if (far3_txt.Text == "")
            {
                if (cst_nameTXT.Text == "")
                {
                    outcome_tableTableAdapter1.FillBy_fatra(dataSet11.outcome_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
                    title = "تقرير الصادر من الخزينة في الفترة من "+dateTimePicker1.Value.ToShortDateString() +"الى "+dateTimePicker2.Value.ToShortDateString();
                }
                else
                {
                    outcome_tableTableAdapter1.FillBy_esm_elmashroo3_in_fatra(dataSet11.outcome_table, cst_nameTXT.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
                    title = "تقرير الصادر من الخزينة في الفترة من " + dateTimePicker1.Value.ToShortDateString() + "الى " + dateTimePicker2.Value.ToShortDateString() + " لحساب - " + cst_nameTXT.Text + " - ";
                    if (dataSet11.outcome_table.Rows.Count <= 0)
                    {
                        outcome_tableTableAdapter1.FillBy_src_in_fatra(dataSet11.outcome_table, cst_nameTXT.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
                    }
                    if (dataSet11.outcome_table.Rows.Count <= 0)
                    {
                        outcome_tableTableAdapter1.FillBy_user_in_fatra(dataSet11.outcome_table, cst_nameTXT.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
                    }
                    if (dataSet11.outcome_table.Rows.Count <= 0)
                    {
                        outcome_tableTableAdapter1.FillBy_details_like_in_fatra(dataSet11.outcome_table, cst_nameTXT.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
                    }
                }
            }
            else
            {
                if (cst_nameTXT.Text == "")
                {
                    outcome_tableTableAdapter1.FillBy_fatra_far3(dataSet11.outcome_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text);
                    title = "تقرير الصادر من الخزينة في الفترة من " + dateTimePicker1.Value.ToShortDateString() + "الى " + dateTimePicker2.Value.ToShortDateString();
              
                }
                else
                {

                    outcome_tableTableAdapter1.FillBy_esm_elmashroo3_in_fatra_far3(dataSet11.outcome_table, cst_nameTXT.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text);
                    title = "تقرير الصادر من الخزينة في الفترة من " + dateTimePicker1.Value.ToShortDateString() + "الى " + dateTimePicker2.Value.ToShortDateString() + " لحساب - " + cst_nameTXT.Text+" - ";
                  
                    if (dataSet11.outcome_table.Rows.Count <= 0)
                    {
                        outcome_tableTableAdapter1.FillBy_src_in_fatra_far3(dataSet11.outcome_table, cst_nameTXT.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text);
                    }
                    if (dataSet11.outcome_table.Rows.Count <= 0)
                    {
                        outcome_tableTableAdapter1.FillBy_user_in_fatra_far3(dataSet11.outcome_table, cst_nameTXT.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text);
                    }
                    if (dataSet11.outcome_table.Rows.Count <= 0)
                    {
                        outcome_tableTableAdapter1.FillBy_details_like_in_fatra_far3(dataSet11.outcome_table, cst_nameTXT.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text);
                    }
                }
            }

          //  crystalReportViewer1.ReportSource = dataSet111;
           string  param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";
             outcome_report1.SetParameterValue("test", param);
          
            // MessageBox.Show("a");
             outcome_report1.Refresh();
             outcome_report1.SetDataSource(dataSet11);


             outcome_report1.SetParameterValue("test", param);
             outcome_report1.SetParameterValue("title", title);
            crystalReportViewer1.Refresh();
            crystalReportViewer1.RefreshReport();
            crystalReportViewer1.ReportSource = outcome_report1;

            crystalReportViewer1.ReuseParameterValuesOnRefresh = true;
        }
    }
}
