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
    public partial class gard_form : Form
    {
        public gard_form()
        {
            InitializeComponent();
        }

        private void gard_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.temp_gard' table. You can move, or remove it, as needed.
            this.temp_gardTableAdapter.Fill(this.dataSet1.temp_gard);
            // TODO: This line of code loads data into the 'dataSet1.temp_gard' table. You can move, or remove it, as needed.
            this.temp_gardTableAdapter.Fill(this.dataSet1.temp_gard);

        }

        private void chart_btn_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("هل تريد تفريغ الجدول بعد الجرد ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (re == DialogResult.Yes)
            {
                temp_gardTableAdapter.Delete_all();
                this.temp_gardTableAdapter.Fill(this.dataSet1.temp_gard);
                dataGridView1.Rows.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            temp_gardTableAdapter.Delete_all();
            this.temp_gardTableAdapter.Fill(this.dataSet1.temp_gard);

            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
                try
                {
                    if (dgr.Cells[1].Value == null || string.IsNullOrEmpty(dgr.Cells[1].Value.ToString()))
                    {
                        dgr.Cells[1].Value = "1";
                    }

                    if (Convert.ToDecimal(dgr.Cells[1].Value) == 1)
                    {
                        temp_gardTableAdapter.InsertQuery(dgr.Cells[0].Value.ToString(), far3txt.Text);
                    }
                    else
                    {
                        for (int i = 0; i < Convert.ToInt32(dgr.Cells[1].Value); i++)
                        {
                            try
                            {
                                temp_gardTableAdapter.InsertQuery(dgr.Cells[0].Value.ToString(), far3txt.Text);
                            }
                            catch { }
                        }
                    }
                }
                catch { }
             
            }

            this.temp_gardTableAdapter.Fill(this.dataSet1.temp_gard);

            foreach (DataGridViewRow dgr in dataGridView2.Rows)
            {
                try
                {
                    if (dgr.Cells[5].Value != null && Convert.ToDecimal(dgr.Cells[5].Value) == 0)
                    {
                        dgr.Cells[6].Value = true;
                    }
                }
                catch { }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgr in dataGridView2.Rows)
            {
                int id;
                if (Convert.ToBoolean(dgr.Cells[6].Value) == true) 
                {
                    products_tableTableAdapter1.FillBy_pro_int_code(dataSet1.products_table, dgr.Cells[1].Value.ToString());
                    if (dataSet1.products_table.Rows.Count > 0)
                    {
                         id = Convert.ToInt32(dataSet1.products_table.Rows[0]["pro_ID"]);
                    }
                    else 
                    {
                         id = Convert.ToInt32(dgr.Cells[0].Value);
                    }
                    products_tableTableAdapter1.Update_gard_status_to_done_by_id(DateTime.Today.ToShortDateString(),id);
                }
            }
            MessageBox.Show("تم الجرد");
            product_list P = new product_list();
            P.far3_txt.Text = far3txt.Text;
            P.ShowDialog();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                int selectedrowindex = dataGridView2.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView2.Rows[selectedrowindex];
                if (Convert.ToBoolean(selectedRow.Cells[6].Value) == true)
                {
                    selectedRow.Cells[6].Value = false;
                }
                else { selectedRow.Cells[6].Value = true; }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgr in dataGridView2.Rows) 
            {
                try
                {
                    if (Convert.ToDecimal(dgr.Cells[5].Value) == 0)
                    {
                        dgr.DefaultCellStyle.BackColor = Color.Green;
                    }
                    else
                    {
                        dgr.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
                catch { }
            }
            try
            {

                txt_count_dgv1.Text = (dataGridView1.Rows.Count-1).ToString();
            }
            catch { }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                // Check if there is any data in the clipboard
                if (Clipboard.GetDataObject() != null)
                {
                    // Get the data from the clipboard
                    string clipboardData = Clipboard.GetText();

                    // Split the data into individual rows
                    string[] rows = clipboardData.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);

                    // Loop through each row and paste the data into the DataGridView
                    foreach (string row in rows)
                    {
                        if (!string.IsNullOrEmpty(row))
                        {
                            // Split the row into individual cells
                            string[] cells = row.Split('\t');

                            // Create a new row in the DataGridView
                            DataGridViewRow dataGridViewRow = new DataGridViewRow();

                            // Set theColumnCount property of the DataGridView to the number of cells in the row
                            dataGridView1.ColumnCount = cells.Length;

                            // Loop through each cell in the row and add it to the DataGridView
                            foreach (string cell in cells)
                            {
                                // Check if the cell value can be parsed as a double
                                double cellValue;
                                if (double.TryParse(cell, out cellValue))
                                {
                                    // Add the cell value to the new row
                                    dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell { Value = cellValue });
                                }
                                else
                                {
                                    // Add the cell value to the new row
                                    dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell { Value = cell });
                                }
                            }

                            // Add the new row to the DataGridView
                            dataGridView1.Rows.Add(dataGridViewRow);
                        }
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("هل تريد تفريغ الجدول ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (re == DialogResult.Yes)
            {
               
                dataGridView1.Rows.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("هل تريد تفريغ الجدول؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (re == DialogResult.Yes)
            {
                temp_gardTableAdapter.Delete_all();
                this.temp_gardTableAdapter.Fill(this.dataSet1.temp_gard);
              
            }
        }

       
       
    }
}
