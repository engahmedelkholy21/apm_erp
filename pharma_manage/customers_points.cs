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
    public partial class customers_points : Form
    {
        public customers_points()
        {
            InitializeComponent();
        }

        private void customers_points_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.customer_points_table' table. You can move, or remove it, as needed.
          //  this.customer_points_tableTableAdapter.Fill(this.dataSet1.customer_points_table);
            suggest_cst_name();
        }
        private void suggest_cst_name()
        {
            this.customer_points_tableTableAdapter.Fill(this.dataSet1.customer_points_table);
            cst_nameTXT.AutoCompleteMode = AutoCompleteMode.Suggest;
            cst_nameTXT.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet1.customer_points_table.Rows)
            {
                DataCollection.Add(dr["cst_points_cst_name"].ToString());
                DataCollection.Add(dr["cst_points_cst_phone"].ToString());
            }

           

            cst_nameTXT.AutoCompleteCustomSource = DataCollection;

        }

        private void cst_nameTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) 
            {
                try 
                {
                    if (cst_nameTXT.Text == "") 
                    {
                        this.customer_points_tableTableAdapter.Fill(this.dataSet1.customer_points_table);
                    }
                    else
                    {
                        customer_points_tableTableAdapter.FillBy_cst_name(dataSet1.customer_points_table, cst_nameTXT.Text);
                        if (dataSet1.customer_points_table.Rows.Count <= 0)
                        {
                            customer_points_tableTableAdapter.FillBy_cst_phone(dataSet1.customer_points_table, cst_nameTXT.Text);
                        }
                    }
                }
                catch { }
            }
        }
    }
}
