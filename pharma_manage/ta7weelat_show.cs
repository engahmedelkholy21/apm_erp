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
    public partial class ta7weelat_show : Form
    {
        public ta7weelat_show()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
        }

        private void ta7weelat_show_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.ta7weel_table' table. You can move, or remove it, as needed.
            this.ta7weel_tableTableAdapter.Fill(this.dataSet1.ta7weel_table);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            salesID_TXT.Clear();
            ta7weel_tableTableAdapter.FillBy_fatra(dataSet1.ta7weel_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1_ValueChanged(sender, e);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            //    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            //    int num = Convert.ToInt32(selectedRow.Cells[0].Value);
            //    DialogResult re = MessageBox.Show(" هل تريد طباعة الأمر ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //    if (re == DialogResult.Yes)
            //    {
            //        pharmacy_dataTableAdapter1.Fill(dataSet1.pharmacy_data);

            //        a5_ta7weel_crystal_report1.Refresh();
            //        a5_ta7weel_crystal_report1.SetDataSource(dataSet1);


            //        //string param;

            //        //param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";
            //        //// MessageBox.Show(param);
            //        //a5_ta7weel_crystal_report1.SetParameterValue("test", param);

            //        ta7weel_tableTableAdapter.FillBy_ta7weel_number(dataSet1.ta7weel_table, num);


            //        StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_a4.txt");
            //        string printer_name = srr.ReadLine();
            //        a5_ta7weel_crystal_report1.PrintOptions.PrinterName = printer_name;
            //        a5_ta7weel_crystal_report1.PrintToPrinter(1, false, 0, 0);
            //    }
            //}
            //catch { }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dateTimePicker1_ValueChanged(sender, e);
        }

        private void salesID_TXT_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                ta7weel_tableTableAdapter.FillBy_ta7weel_number(dataSet1.ta7weel_table,Convert.ToInt32(salesID_TXT.Text));
            }
            catch { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                decimal sum = 0;
                foreach (DataGridViewRow dgr in dataGridView1.Rows)
                {
                       sum += Convert.ToDecimal(dgr.Cells[8].Value);
                }
                matloobTXT.Text = sum.ToString();
            }
            catch { }
        }

        private void print_a4_click(object sender, EventArgs e)
        {
            try
            {

                DialogResult re = MessageBox.Show(" هل تريد طباعة الأمر ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (re == DialogResult.Yes)
                {
                    pharmacy_dataTableAdapter1.Fill(dataSet1.pharmacy_data);

                    a4_ta7weel_crystal_report1.Refresh();
                    a4_ta7weel_crystal_report1.SetDataSource(dataSet1);


                    //string param;

                    //param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";
                    //// MessageBox.Show(param);
                    //a5_ta7weel_crystal_report1.SetParameterValue("test", param);

                    ta7weel_tableTableAdapter.FillBy_ta7weel_number(dataSet1.ta7weel_table, ta7weel_id);


                    StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_a4.txt");
                    string printer_name = srr.ReadLine();
                    a4_ta7weel_crystal_report1.PrintOptions.PrinterName = printer_name;
                    a4_ta7weel_crystal_report1.PrintToPrinter(1, false, 0, 0);
                    a4_ta7weel_crystal_report1.Close();
                    a4_ta7weel_crystal_report1.Dispose();
                }
            }
            catch { }
        }
        private void print_a5_click(object sender, EventArgs e)
        {
            try
            {
               
                DialogResult re = MessageBox.Show(" هل تريد طباعة الأمر ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (re == DialogResult.Yes)
                {
                    pharmacy_dataTableAdapter1.Fill(dataSet1.pharmacy_data);

                    a5_ta7weel_crystal_report1.Refresh();
                    a5_ta7weel_crystal_report1.SetDataSource(dataSet1);


                    //string param;

                    //param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";
                    //// MessageBox.Show(param);
                    //a5_ta7weel_crystal_report1.SetParameterValue("test", param);

                    ta7weel_tableTableAdapter.FillBy_ta7weel_number(dataSet1.ta7weel_table, ta7weel_id);


                    StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_a4.txt");
                    string printer_name = srr.ReadLine();
                    a5_ta7weel_crystal_report1.PrintOptions.PrinterName = printer_name;
                    a5_ta7weel_crystal_report1.PrintToPrinter(1, false, 0, 0);
                    a5_ta7weel_crystal_report1.Close();
                    a5_ta7weel_crystal_report1.Dispose();
                }
            }
            catch { }
        }

        private void reciept_click(object sender, EventArgs e)
        {
            try
            {

                DialogResult re = MessageBox.Show(" هل تريد طباعة الأمر ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (re == DialogResult.Yes)
                {
                    pharmacy_dataTableAdapter1.Fill(dataSet1.pharmacy_data);

                    reciept_ta7weel_crystal_report1.Refresh();
                    reciept_ta7weel_crystal_report1.SetDataSource(dataSet1);


                    //string param;

                    //param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";
                    //// MessageBox.Show(param);
                    //a5_ta7weel_crystal_report1.SetParameterValue("test", param);

                    ta7weel_tableTableAdapter.FillBy_ta7weel_number(dataSet1.ta7weel_table, ta7weel_id);


                    StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_fwateer.txt");
                    string printer_name = srr.ReadLine();
                    reciept_ta7weel_crystal_report1.PrintOptions.PrinterName = printer_name;
                    reciept_ta7weel_crystal_report1.PrintToPrinter(1, false, 0, 0);
                    reciept_ta7weel_crystal_report1.Close();
                    reciept_ta7weel_crystal_report1.Dispose();
                }
            }
            catch { }
        }
        //string pro_name = "";
        int ta7weel_id;
        //string far3;
        //int local_id;
        int selectedrowindex;
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
               
                    selectedrowindex = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[selectedrowindex].Selected = true;


                    //int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                    ta7weel_id = Convert.ToInt32(selectedRow.Cells[0].Value);
                    // MessageBox.Show(pro_id_pub.ToString());
                    //pro_name = Convert.ToString(selectedRow.Cells[1].Value);
                    //far3 = selectedRow.Cells[4].Value.ToString();

                    // MessageBox.Show(pro_name_pub.ToString());
                    var m = new ContextMenu();

                    var print_a4 = new MenuItem("طباعة A4");
                    var print_reciept = new MenuItem("طباعة فاتورة");
                    var print_a5= new MenuItem("طباعة a5");
                    print_a4.Click += print_a4_click;
                    print_reciept.Click += reciept_click;
                    print_a5.Click += print_a5_click;

                    m.MenuItems.Add(print_a4);
                    m.MenuItems.Add(print_reciept);
                    m.MenuItems.Add(print_a5);

                  
                    //  (mi);
                    // handle menu item click event here [as required]

                    int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                    m.Show(dataGridView1, new Point(e.X, e.Y));
                
            }
        }
    }
}
