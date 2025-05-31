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
    public partial class mosta7kat_show : Form
    {
        public mosta7kat_show()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;

            Form1 f1 = new Form1();
            f1.SubscribeToLoadEvent(this);
            f1.ApplyFormStyling(this);
        }

        private void mosta7kat_show_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.mosta7akat_table' table. You can move, or remove it, as needed.
            //this.mosta7akat_tableTableAdapter.Fill(this.dataSet1.mosta7akat_table);

            suggest_cst();
            cst_name_txt_TextChanged(sender, e);
            dataGridView4.AllowUserToOrderColumns = false;

            // Disable sorting for each column in the DataGridView
            foreach (DataGridViewColumn column in dataGridView4.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void suggest_cst()
        {
            this.mosta7akat_tableTableAdapter.Fill(this.dataSet1.mosta7akat_table);
            cst_name_txt.AutoCompleteMode = AutoCompleteMode.Suggest;
            cst_name_txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet1.mosta7akat_table.Rows)
            {

                DataCollection.Add(dr["mosta7akat_cst_name"].ToString());
                

            }

            cst_name_txt.AutoCompleteCustomSource = DataCollection;

        }

        private void cst_name_txt_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                mosta7akat_tableTableAdapter.FillBy_cst_name_and_fatra(dataSet1.mosta7akat_table, cst_name_txt.Text,dateTimePicker1.Value.ToShortDateString(),dateTimePicker2.Value.ToShortDateString());

                customersTableAdapter1.FillBy_name(dataSet1.customers, cst_name_txt.Text);
                address_txt.Text = dataSet1.customers.Rows[0]["cst_address"].ToString();

                try
                {
                    decimal sum = 0;
                    decimal sum2 = 0;
                    

                    // for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    foreach (DataGridViewRow dgr in dataGridView4.Rows)
                    {
                        sum += Convert.ToDecimal(dgr.Cells[5].Value);
                        sum2 += Convert.ToDecimal(dgr.Cells[6].Value);
                        


                    }
                    textBox1.Text = sum.ToString();
                    textBox2.Text = sum2.ToString();
                }
                catch { }
            }
            catch { }

            try 
            {
                dataGridView4.Rows[dataGridView4.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;

                string x=dataGridView4.Rows[dataGridView4.Rows.Count - 1].Cells[7].Value.ToString();

                dataGridView4.Rows.Add("","","",x);
            }
            catch { }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pharmacy_dataTableAdapter1.Fill(dataSet1.pharmacy_data);

            sales_tableTableAdapter1.Insert(0, DateTime.Today, cst_name_txt.Text, "", "", 0, 0, "", 0, 0, 0, "", "", 0, 0, "", 0, 0, "", 0, "بيع", "", "", "", DateTime.Now.TimeOfDay,0,0,0,0);

            select_printer_kashf_7esab s = new select_printer_kashf_7esab();
            s.dateTimePicker1.Value = dateTimePicker1.Value;
            s.dateTimePicker2.Value = dateTimePicker2.Value;
            s.cst_name_txt.Text = cst_name_txt.Text;
            s.ShowDialog();

            //a5_fatora_crystal_report1.Refresh();
            //a5_fatora_crystal_report1.SetDataSource(dataSet1);
            
            //kashf_7esab_report_reset1.Refresh();
            //kashf_7esab_report_reset1.SetDataSource(dataSet1);

            //string param;

            //param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";
            //// MessageBox.Show(param);
            //kashf_7esab_report_reset1.SetParameterValue("test", param);


            //string title = "عن الفترة من " + dateTimePicker1.Value.ToString("yyyy/MM/dd") + " الى " + dateTimePicker2.Value.ToString("yyyy/MM/dd");
            //kashf_7esab_report_reset1.SetParameterValue("title", title);
            //mosta7akat_tableTableAdapter.FillBy_cst_name_and_fatra(dataSet1.mosta7akat_table, cst_name_txt.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());

            //sales_tableTableAdapter1.FillBy_CST_FATRA(dataSet1.sales_table, cst_name_txt.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());


            //StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_fwateer.txt");
            //string printer_name = srr.ReadLine();
            //kashf_7esab_report_reset1.PrintOptions.PrinterName = printer_name;

            //kashf_7esab_report_reset1.PrintToPrinter(1, false, 0, 0);
            //kashf_7esab_report_reset1.Dispose();
            //kashf_7esab_report_reset1.Close();

            sales_tableTableAdapter1.Delete_by_ID(0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgr in dataGridView4.Rows) 
            {
                if (Convert.ToDecimal(dgr.Cells[7].Value) == 0) 
                {
                    dgr.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            cst_name_txt_TextChanged(sender, e);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            cst_name_txt_TextChanged(sender, e);
        }

        private void dataGridView4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
                int selectedrowindex = dataGridView4.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView4.Rows[selectedrowindex];

                if (selectedRow.Cells[9].Value.ToString() != "0")
                {
                    sales_fatora s = new sales_fatora();
                    s.Text = "مراجعة فاتورة مبيعات";
                    s.salesID_TXT.Text = selectedRow.Cells[9].Value.ToString();
                    s.far3txt.Text = far3txt.Text;
                    s.ShowDialog();
                }
            }
            catch { }
        }
        private void delete_click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("هل تريد حذف البيان ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (d == DialogResult.Yes)
            {
                //if (type == "دائن")
                //{
                    madeen_small_reportTableAdapter1.Update_matloob_AND_madfoo3_by_name(-matloob_fatora_for_delete, -dof3a, cst_name_txt.Text);
                    mosta7akat_tableTableAdapter.Delete_by_id(local_id);
                    MessageBox.Show("تم الحذف بنجاح", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    cst_name_txt_TextChanged(sender, e);
               // }
            }
        }
        private void print_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("هل تريد طباعة ايصال ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (d == DialogResult.Yes)
            {
                StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_fwateer.txt");
                string printer_name = srr.ReadLine();

                string param;


                param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";
                pharmacy_dataTableAdapter1.Fill(dataSet1.pharmacy_data);



                try
                {



                    pharmacy_dataTableAdapter1.Fill(dataSet1.pharmacy_data);
                    sadad_print_reset1.Refresh();
                    sadad_print_reset1.SetDataSource(dataSet1);

                    //string param;

                    // param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";
                    // MessageBox.Show(param);
                    sadad_print_reset1.SetParameterValue("test", param);


                    // string title = "عن الفترة من " + dateTimePicker1.Value.ToString("yyyy/MM/dd") + " الى " + dateTimePicker2.Value.ToString("yyyy/MM/dd");
                    // sadad_print_reset1.SetParameterValue("title", title);
                    mosta7akat_tableTableAdapter.FillBy_id(dataSet1.mosta7akat_table, local_id);

                    sadad_print_reset1.PrintOptions.PrinterName = printer_name;

                    sadad_print_reset1.PrintToPrinter(1, false, 0, 0);
                    sadad_print_reset1.Dispose();
                    sadad_print_reset1.Close();

                }
                catch { }
            }

        }
        int local_id;
        decimal dof3a;
        decimal matloob_fatora_for_delete;
        string type;
        private void dataGridView4_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                int selectedrowindex = dataGridView4.HitTest(e.X, e.Y).RowIndex;
                dataGridView4.ClearSelection();
                dataGridView4.Rows[selectedrowindex].Selected = true;


                //int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView4.Rows[selectedrowindex];
                local_id = Convert.ToInt32(selectedRow.Cells[0].Value);
                // MessageBox.Show(pro_id_pub.ToString());

                // MessageBox.Show(pro_name_pub.ToString());
                var m = new ContextMenu();


                var print_ = new MenuItem("طباعة الايصال");
                print_.Click += print_Click;

                m.MenuItems.Add(print_);

                if (selectedrowindex == dataGridView4.Rows.Count - 1 &&selectedRow.Cells[9].Value.ToString()=="0")
                {
                    type = selectedRow.Cells[1].Value.ToString();
                    matloob_fatora_for_delete = Convert.ToDecimal(selectedRow.Cells[5].Value);
                    dof3a = Convert.ToDecimal(selectedRow.Cells[6].Value);
                    var delete_ = new MenuItem("حذف");
                    delete_.Click +=delete_click;
                    m.MenuItems.Add(delete_);
                }



                //  (mi);
                // handle menu item click event here [as required]

                int currentMouseOverRow = dataGridView4.HitTest(e.X, e.Y).RowIndex;
                m.Show(dataGridView4, new Point(e.X, e.Y));

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        
    }
}
