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
    public partial class products_moves : Form
    {
        public products_moves()
        {
            InitializeComponent();
            Form1 f1 = new Form1();
            f1.SubscribeToLoadEvent(this);
            f1.ApplyFormStyling(this);
        }

        private void products_moves_Load(object sender, EventArgs e)
        {
            this.ma5zoon_movesTableAdapter.Fill(this.dataSet1.ma5zoon_moves);
            suggest_product();

        }
        private void suggest_product()
        {
            this.products_tableTableAdapter1.Fill(this.dataSet1.products_table);
            search_text.AutoCompleteMode = AutoCompleteMode.Suggest;
            search_text.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet1.products_table.Rows)
            {
                DataCollection.Add(dr["pro_name"].ToString());
            }

            search_text.AutoCompleteCustomSource = DataCollection;

            try
            {
                if (search_text.Text != "")
                {
                    ma5zoon_movesTableAdapter.FillBy_pro_name(dataSet1.ma5zoon_moves, search_text.Text,stock_txt.Text);
                    if (dataGridView1.Rows.Count <= 0)
                    {
                        ma5zoon_movesTableAdapter.FillBy_pro_code(dataSet1.ma5zoon_moves, search_text.Text,stock_txt.Text);
                    }
                }

            }
            catch { }
            

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (search_text.Text != "")
                {
                    ma5zoon_movesTableAdapter.FillBy_pro_name(dataSet1.ma5zoon_moves, search_text.Text, stock_txt.Text);
                    if (dataGridView1.Rows.Count <= 0) 
                    {
                        ma5zoon_movesTableAdapter.FillBy_pro_code(dataSet1.ma5zoon_moves, search_text.Text, stock_txt.Text);
                    }
                }

            }
            catch { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow dgr in dataGridView1.Rows)
                {
                    if (dgr.Cells[8].Value.ToString() == "بيـع")
                    {
                        dgr.DefaultCellStyle.BackColor = Color.Green;
                        dgr.DefaultCellStyle.ForeColor = Color.White;
                    }
                    else if (dgr.Cells[8].Value.ToString() == "شراء")
                    {
                        dgr.DefaultCellStyle.BackColor = Color.Red;
                        dgr.DefaultCellStyle.ForeColor = Color.White;
                    }
                    
                }
            }
            catch { }
        }

        private void search_text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
