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
    public partial class da2n_edit : Form
    {
        public da2n_edit()
        {
            InitializeComponent();
            Form1 f1 = new Form1();
            f1.SubscribeToLoadEvent(this);
            f1.ApplyFormStyling(this);
        }

        private void da2n_edit_Load(object sender, EventArgs e)
        {

            //suggest
            try
            {
                textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
                textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
                foreach (DataRow dr in dataSet11.da2n_table.Rows)
                {
                    DataCollection.Add(dr["da2n_name"].ToString());
                }

                textBox1.AutoCompleteCustomSource = DataCollection;
            }
            catch { }
        }
        int id;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                da2n_small_reportsTableAdapter1.FillBy_da2n_small_name(dataSet11.da2n_small_reports, textBox1.Text);
                madeen_nameTXT.Text = dataSet11.da2n_small_reports.Rows[0]["da2n_small_name"].ToString();
                matloobtxt.Text = dataSet11.da2n_small_reports.Rows[0]["da2n_small_matloob"].ToString();
                madfoo3txt.Text = dataSet11.da2n_small_reports.Rows[0]["da2n_small_madfoo3"].ToString();
                id = Convert.ToInt32(dataSet11.da2n_small_reports.Rows[0]["da2n_small_id"]);
            }
            catch { }
        }

        private void save_brn_Click(object sender, EventArgs e)
        {
            try 
            {
                da2n_small_reportsTableAdapter1.Update_all_by_id(madeen_nameTXT.Text, Convert.ToDecimal(matloobtxt.Text), Convert.ToDecimal(madfoo3txt.Text),id);

                da2n_tableTableAdapter1.FillBy_name(dataSet11.da2n_table, textBox1.Text);
                foreach(DataRow dr in dataSet11.da2n_table.Rows)
                {
                    int details_id = Convert.ToInt32(dr["da2n_id"]);
                    da2n_tableTableAdapter1.Update_matloob_madfoo3_by_id_for_edit(madeen_nameTXT.Text, Convert.ToDecimal(matloobtxt.Text), Convert.ToDecimal(madfoo3txt.Text), details_id);
                }
                MessageBox.Show("تم التعديل");
                this.Close();
            }
            catch { MessageBox.Show("تأكد من البيانات"); }
        }
    }
}
