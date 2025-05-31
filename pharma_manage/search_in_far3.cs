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
    public partial class search_in_far3 : Form
    {
        public search_in_far3()
        {
            InitializeComponent();
        }

        private void name_txt_KeyDown(object sender, KeyEventArgs e)
        {
            try 
            {
                products_tableTableAdapter.FillBy_name(dataSet1.products_table, name_txt.Text);
                if (dataGridView1.Rows.Count <= 0) 
                {
                    products_tableTableAdapter.FillBy_pro_int_code(dataSet1.products_table,name_txt.Text);
                }
            }
            catch { }
        }

        private void search_in_far3_Load(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.SubscribeToLoadEvent(this);
            f1.ApplyFormStyling(this);
        }

     
    }
}
