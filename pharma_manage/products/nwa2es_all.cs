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
    public partial class nwa2es_all : Form
    {
        public nwa2es_all()
        {
            InitializeComponent();
        }

        private void edit_productbtn_Click(object sender, EventArgs e)
        {
            if (this.Text.Contains("نواقص"))
            {
                nwa2esTableAdapter1.Delete_all();
                foreach (DataGridViewRow dgr in dataGridView1.Rows)
                {
                    if (Convert.ToBoolean(dgr.Cells[6].Value) == true)
                    {
                        nwa2esTableAdapter1.Insert(dgr.Cells[0].Value.ToString(), dgr.Cells[3].Value.ToString(), dgr.Cells[2].Value.ToString(), Convert.ToDecimal(dgr.Cells[7].Value), Convert.ToDecimal(dgr.Cells[5].Value), dgr.Cells[1].Value.ToString());
                    }
                }
                MessageBox.Show("تمت الاضافة بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nwa2es_print n = new nwa2es_print();
                n.Show();
            }
            else 
            {
                nwa2esTableAdapter1.Delete_all();


                foreach (DataGridViewRow dgr in dataGridView1.Rows)
                {
                    if (Convert.ToBoolean(dgr.Cells[6].Value) == true)
                    {
                        nwa2esTableAdapter1.Insert(dgr.Cells[0].Value.ToString(), dgr.Cells[3].Value.ToString(), dgr.Cells[2].Value.ToString(), Convert.ToDecimal(0),Convert.ToDecimal(dgr.Cells[5].Value), dgr.Cells[1].Value.ToString());
                    }
                }

                pharmacy_dataTableAdapter1.Fill(dataSet11.pharmacy_data);

                se3r_offer1.Refresh();
                se3r_offer1.SetDataSource(dataSet11);


                string param;

                param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";
                // MessageBox.Show(param);
                se3r_offer1.SetParameterValue("test", param);
                nwa2esTableAdapter1.Fill(dataSet11.nwa2es);

                StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_a4.txt");
                string printer_name = srr.ReadLine();
                se3r_offer1.PrintOptions.PrinterName = printer_name;
                se3r_offer1.PrintToPrinter(1, false, 0, 0);
                se3r_offer1.Dispose();
            }
        }

        private void nwa2s_Load(object sender, EventArgs e)
        {
            suggest_product();

            if (this.Text.Contains("نواقص"))
            {
                fatora_type.Visible = false;
                checkBox1.Visible = true;
                checkBox1.ForeColor = Color.White;
            }
            else 
            {
                fatora_type.Visible = true;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].HeaderText="السعر";
                dataGridView1.Columns[1].Width = 120;
                dataGridView1.Columns[3].Width = 120;
                dataGridView1.Columns[4].Width = 120;
                dataGridView1.Columns[5].Width = 120;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nwa2esTableAdapter1.Delete_all();
            
        }
        private void suggest_product()
        {
            this.products_tableTableAdapter1.Fill(this.dataSet11.products_table);
            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet11.products_table.Rows)
            {
                DataCollection.Add(dr["pro_name"].ToString());


            }

            textBox1.AutoCompleteCustomSource = DataCollection;

        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    dr.Selected = false;
                }

                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    if (dr.Cells[2].Value.ToString() == textBox1.Text)
                    {
                        dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Blue;
                        dr.Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.SelectedRows[0].Index;
                        dataGridView1.CurrentCell = dataGridView1.SelectedRows[0].Cells[6];
                       // dataGridView1.BeginEdit(true);
                        
                    }
                    else if(dr.Cells[1].Value.ToString() == textBox1.Text)
                    {
                        dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Blue;
                        dr.Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.SelectedRows[0].Index;
                        dataGridView1.CurrentCell = dataGridView1.SelectedRows[0].Cells[6];
                       // dataGridView1.BeginEdit(true);

                    }
                    else if (dr.Cells[3].Value.ToString() == textBox1.Text)
                    {
                        dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Blue;
                        dr.Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.SelectedRows[0].Index;
                        dataGridView1.CurrentCell = dataGridView1.SelectedRows[0].Cells[6];
                        //dataGridView1.BeginEdit(true);

                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow dgr in dataGridView1.Rows)
                {
                    if (Convert.ToDecimal(dgr.Cells[4].Value) == 0)
                    {
                        dgr.DefaultCellStyle.BackColor = Color.Red;
                    }
                    else
                    {
                        dgr.DefaultCellStyle.BackColor = Color.Tomato;
                    }
                }

            }
            catch { }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fatora_type_Click(object sender, EventArgs e)
        {
            if (fatora_type.Text == "جمله")
            {
                fatora_type.Text = "قطاعي";


                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                products_tableTableAdapter1.FillBy_name(dataSet11.products_table, selectedRow.Cells[2].Value.ToString());

                selectedRow.Cells[5].Value = dataSet11.products_table.Rows[0]["pro_bee3_2"].ToString();
                
            }
            else if (fatora_type.Text == "قطاعي")
            {
                fatora_type.Text = "جملة الجمله";

                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                products_tableTableAdapter1.FillBy_name(dataSet11.products_table, selectedRow.Cells[2].Value.ToString());

                selectedRow.Cells[5].Value = dataSet11.products_table.Rows[0]["pro_gomla_gomla"].ToString();
                
            }
            else if (fatora_type.Text == "جملة الجمله")
            {
                fatora_type.Text = "جمله";
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                products_tableTableAdapter1.FillBy_name(dataSet11.products_table, selectedRow.Cells[2].Value.ToString());

                selectedRow.Cells[5].Value = dataSet11.products_table.Rows[0]["pro_bee3"].ToString();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try 
            {
                if (checkBox1.Checked == true)
                {
                    foreach (DataGridViewRow dgr in dataGridView1.Rows)
                    {
                        dgr.Cells[6].Value = true;
                    }
                }
                else
                {
                    foreach (DataGridViewRow dgr in dataGridView1.Rows)
                    {
                        dgr.Cells[6].Value = false;
                    }
                }
            }
            catch { }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
             this.products_tableTableAdapter1.Fill(this.dataSet11.products_table);
            int i = 0;
            //MessageBox.Show("جرب من بره البرنامج");
            foreach (DataRow dr in dataSet11.products_table.Rows)
            {

                try
                {
                    if (Convert.ToDecimal(dr["pro_count"]) <= Convert.ToDecimal(textBox2.Text))
                    {

                        i += 1;
                        // MessageBox.Show(i.ToString());
                        dataGridView1.Rows.Add(i.ToString(), dr["pro_ID"].ToString(), dr["pro_name"].ToString(), dr["pro_category"].ToString(), Convert.ToDecimal(dr["pro_count"]), 0,null,Convert.ToDecimal(dr["pro_cost_price"]));
                        //  nwa2es_tableTableAdapter1.Insert_nwa2es(dr["pro_id_company"].ToString(), dr["pro_name"].ToString(), Convert.ToDecimal(dr["pro_count"]), 0);
                    }
                }
                catch { }
            }
                
        }

       

        
    }
}
