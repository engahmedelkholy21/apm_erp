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
    public partial class da2n_details : Form
    {
        public da2n_details()
        {
            InitializeComponent();
            Form1 f1 = new Form1();
            f1.SubscribeToLoadEvent(this);
            f1.ApplyFormStyling(this);
        }

        private void da2n_details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.da2n_table' table. You can move, or remove it, as needed.
          //  this.da2n_tableTableAdapter.Fill(this.dataSet1.da2n_table);


            // delete if ba2y 0
            da2n_tableTableAdapter.Delete_when_ba2y0();

            if (search_text.Text != "")
            {
                try
                {
                    da2n_tableTableAdapter.FillBy_name(dataSet1.da2n_table, search_text.Text);
                   
                    da2n_small_reportsTableAdapter1.FillBy_name(dataSet1.da2n_small_reports, search_text.Text);
                    matloobtxt.Text = dataSet1.da2n_small_reports.Rows[0]["da2n_small_matloob"].ToString();
                    madfoo3txt.Text = dataSet1.da2n_small_reports.Rows[0]["da2n_small_madfoo3"].ToString();
                    ba2ytxt.Text = dataSet1.da2n_small_reports.Rows[0]["da2n_small_ba2y"].ToString();
                }
                catch { }
            }
            this.WindowState = FormWindowState.Maximized;

            //suggest
            try
            {
                search_text.AutoCompleteMode = AutoCompleteMode.Suggest;
                search_text.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
                foreach (DataRow dr in dataSet1.da2n_table.Rows)
                {
                    DataCollection.Add(dr["da2n_name"].ToString());
                }

                search_text.AutoCompleteCustomSource = DataCollection;
            }
            catch { }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                da2n_tableTableAdapter.FillBy_name(dataSet1.da2n_table, search_text.Text);
                da2n_small_reportsTableAdapter1.FillBy_name(dataSet1.da2n_small_reports, search_text.Text);
                matloobtxt.Text = dataSet1.da2n_small_reports.Rows[0]["da2n_small_matloob"].ToString();
                madfoo3txt.Text = dataSet1.da2n_small_reports.Rows[0]["da2n_small_madfoo3"].ToString();
                ba2ytxt.Text = dataSet1.da2n_small_reports.Rows[0]["da2n_small_ba2y"].ToString();
            }
            catch { }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pharmacy_dataTableAdapter1.Fill(dataSet1.pharmacy_data);
            a5_crystal_da2n_details1.Refresh();
            a5_crystal_da2n_details1.SetDataSource(dataSet1);


            da2n_small_reportsTableAdapter1.FillBy_da2n_small_name(dataSet1.da2n_small_reports, search_text.Text);
            da2n_tableTableAdapter.FillBy_name(dataSet1.da2n_table, search_text.Text);
              
            a5_crystal_da2n_details1.PrintToPrinter(1, false, 0, 0);
            a5_crystal_da2n_details1.Dispose();
            searchbtn_Click(sender, e);
            //da2n_details_print ddp = new da2n_details_print();
            //ddp.Text = "طباعة تفاصيل دائن";
            //ddp.textBox1.Text = search_text.Text;
            //ddp.ShowDialog();
        }

        private void search_text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
