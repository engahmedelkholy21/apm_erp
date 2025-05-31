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
    public partial class attending_show : Form
    {
        public attending_show()
        {
            InitializeComponent();
            // Get the current date
            DateTime currentDate = DateTime.Today;

            // Set the date to the 1st day of the current month
            DateTime firstDayOfMonth = new DateTime(currentDate.Year, currentDate.Month, 1);

            // Set the value of the DateTimePicker control to the 1st day of the current month
            dateTimePicker1.Value = firstDayOfMonth;


            // Get the current date
          //  DateTime currentDate = DateTime.Today;

            // Set the date to the last day of the current month
            DateTime lastDayOfMonth = new DateTime(currentDate.Year, currentDate.Month, DateTime.DaysInMonth(currentDate.Year, currentDate.Month));

            // Set the value of the DateTimePicker control to the last day of the current month
            dateTimePicker2.Value = lastDayOfMonth;

        }

        private void attending_show_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.disocunts' table. You can move, or remove it, as needed.
           // this.disocuntsTableAdapter.Fill(this.dataSet1.disocunts);
            // TODO: This line of code loads data into the 'dataSet1.mokaf2at_table' table. You can move, or remove it, as needed.
           // this.mokaf2at_tableTableAdapter.Fill(this.dataSet1.mokaf2at_table);
           // // TODO: This line of code loads data into the 'dataSet12.extra_table' table. You can move, or remove it, as needed.
           //this.extra_tableTableAdapter.Fill(this.dataSet12.extra_table);
            //// TODO: This line of code loads data into the 'dataSet1.solfa_table' table. You can move, or remove it, as needed.
            //this.solfa_tableTableAdapter.Fill(this.dataSet1.solfa_table);
            //// TODO: This line of code loads data into the 'dataSet1.attending_table' table. You can move, or remove it, as needed.
            //this.attending_tableTableAdapter.Fill(this.dataSet1.attending_table);
            suggest_emp();
        }
        private void suggest_emp()
        {
            this.employee_tableTableAdapter1.Fill(this.dataSet11.employee_table);
            name_txt.AutoCompleteMode = AutoCompleteMode.Suggest;
            name_txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet11.employee_table.Rows)
            {
                DataCollection.Add(dr["employee_name"].ToString());


            }

            name_txt.AutoCompleteCustomSource = DataCollection;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.attending_tableTableAdapter.Fill(this.dataSet1.attending_table);

        }

        private void name_txt_TextChanged(object sender, EventArgs e)
        {

            try
            {
                attending_tableTableAdapter.FillBy_emp_in_fatra(dataSet1.attending_table, name_txt.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());

                employee_tableTableAdapter1.FillBy_name(dataSet1.employee_table, name_txt.Text);

                decimal daily_salary = Convert.ToDecimal(dataSet1.employee_table.Rows[0]["employee_daily_salary"]);

                decimal monthly_salary = Convert.ToDecimal(dataSet1.employee_table.Rows[0]["employee_monthly_salary"]);

                //int count = 0;
                //foreach (DataGridViewRow dgr in dataGridView1.Rows)
                //{
                //    if (dgr.Cells[2].Value.ToString() == "حضر" && dgr.Cells[3].Value.ToString() == "غير مسدد")
                //    {
                //        count += 1;
                //    }
                //}

                int days_attend_count = 0;
                int days_absent_no_permission_count = 0;
                int days_absent_with_permission_count = 0;
                int agazat = 0;

                
                foreach (DataGridViewRow dgr in dataGridView1.Rows)
                {
                  
                        if (dgr.Cells[2].Value.ToString() == "حضر")
                        {
                            days_attend_count += 1;
                        }
                        else if (dgr.Cells[2].Value.ToString() == "غياب باذن")
                        {
                            days_absent_with_permission_count += 1;
                        }
                        else if (dgr.Cells[2].Value.ToString() == "غياب بدون اذن")
                        {
                            days_absent_no_permission_count += 1;
                        }
                        else if (dgr.Cells[2].Value.ToString() == "اجازة")
                        {
                            agazat += 1;
                        }
                    
                }

                days_attend_txt.Text = days_attend_count.ToString();
                days_absent_no_permission_txt.Text = days_absent_no_permission_count.ToString();
                days_absent_with_permission_txt.Text = days_absent_with_permission_count.ToString();
                agaza_txt.Text = agazat.ToString();

            

                if (daily_salary != 0)
                {
                    decimal absent = Math.Round((days_absent_no_permission_count + days_absent_with_permission_count) *daily_salary, 0);
                    decimal salary = (days_attend_count) * daily_salary;
                    decimal safy = salary - absent;

                    cost_txt.Text = salary.ToString();
                }
                else if (monthly_salary != 0)
                {
                    decimal absent = Math.Round(((days_absent_no_permission_count + days_absent_with_permission_count) * (monthly_salary / 30)), 0);
                   
                    decimal salary = Math.Round(((days_attend_count + agazat) * (monthly_salary / 30)), 0);
                    decimal safy = salary - absent;

                    cost_txt.Text = salary.ToString();
                }
            }
            catch { }



            extra_tableTableAdapter.FillBy_emp_name_and_fatra(dataSet1.extra_table, name_txt.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());

            decimal extra = 0;
            foreach (DataGridViewRow dgr in dataGridView3.Rows)
            {
                try
                {
                    //if (dgr.Cells[2].Value.ToString() == "غير مسدد")
                    //{
                        extra += Convert.ToDecimal(dgr.Cells[1].Value);
                   // }
                }
                catch { }
            }

            extra_txt.Text = extra.ToString();

                solfa_tableTableAdapter.FillBy_emp_and_fatra(dataSet1.solfa_table, name_txt.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());

                decimal solf = 0;
                foreach (DataGridViewRow dgr in dataGridView2.Rows)
                {
                    try
                    {
                        //if (dgr.Cells[2].Value.ToString() == "غير مسدد")
                        //{
                            solf += Convert.ToDecimal(dgr.Cells[1].Value);

                      //  }
                    }
                    catch { }
                }

                solaf_txt.Text = solf.ToString();




                mokaf2at_tableTableAdapter.FillBy_emp_name_and_fatra(dataSet1.mokaf2at_table, name_txt.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());

                decimal mokafa2at = 0;
                foreach (DataGridViewRow dgr in dataGridView4.Rows)
                {
                    try
                    {
                        //if (dgr.Cells[2].Value.ToString() == "غير مسدد")
                        //{
                            mokafa2at += Convert.ToDecimal(dgr.Cells[1].Value);

                       // }
                    }
                    catch { }
                }

                mokafa2at_txt.Text = mokafa2at.ToString();


                disocuntsTableAdapter.FillBy_emp_and_fatra(dataSet1.disocunts, name_txt.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());

                decimal discounts = 0;
                foreach (DataGridViewRow dgr in dataGridView5.Rows)
                {
                    try
                    {
                        //if (dgr.Cells[2].Value.ToString() == "غير مسدد")
                        //{
                            discounts += Convert.ToDecimal(dgr.Cells[1].Value);

                       // }
                    }
                    catch { }
                }

                discounts_txt.Text = discounts.ToString();


                try
                {
                    final_cost_txt.Text = (Convert.ToDecimal(cost_txt.Text) + Convert.ToDecimal(extra_txt.Text) + Convert.ToDecimal(mokafa2at_txt.Text) - Convert.ToDecimal(solaf_txt.Text) - Convert.ToDecimal(discounts_txt.Text)).ToString();

                }
                catch { }


            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
                if (dgr.Cells[2].Value.ToString() == "غياب باذن")
                {
                    dgr.DefaultCellStyle.BackColor = Color.LightCoral;
                    dgr.DefaultCellStyle.ForeColor = Color.White;
                }
                else if (dgr.Cells[2].Value.ToString() == "غياب بدون اذن")
                {
                    dgr.DefaultCellStyle.BackColor = Color.Red;
                    dgr.DefaultCellStyle.ForeColor = Color.White;
                }
                else if (dgr.Cells[2].Value.ToString() == "حضر")
                {
                    dgr.DefaultCellStyle.BackColor = Color.Green;
                    dgr.DefaultCellStyle.ForeColor = Color.White;
                }
            }

            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
                if (dgr.Cells[3].Value.ToString() == "غير مسدد")
                {
                    button1.Visible = true;
                }
                else 
                {
                    button1.Visible = false;
                    return;
                }
            }
        }
        

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            name_txt_TextChanged(sender, e);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            name_txt_TextChanged(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;  // Set the cursor to indicate loading
                this.Enabled = false;              // Disable form to prevent interaction


                //foreach (DataGridViewRow dgr in dataGridView1.Rows) 
                //{
                //    if (dgr.Cells[5].Value.ToString().Contains("غير")) 
                //    {

                //        return;
                //    }
                //}
                if (name_txt.Text != "")
                {
                    outcome_tableTableAdapter1.Insert_outcome(DateTime.Today.ToShortDateString(), " راتب الموظف " + name_txt.Text + " عن الفتره من " + dateTimePicker1.Value.ToShortDateString() + " الى " + dateTimePicker2.Value.ToShortDateString(),
                        Convert.ToDecimal(final_cost_txt.Text), 0, "رواتب", name_txt.Text, usertxt.Text, "",far3txt.Text);
                    safeTableAdapter1.Update_sarf_from_safe(Convert.ToDecimal(cost_txt.Text));
                    decimal tarh = Convert.ToDecimal(cost_txt.Text) * -1;
                   
                    safeTableAdapter1.Insert_safe(DateTime.Today.ToShortDateString(), tarh);


                    foreach (DataGridViewRow dgr in dataGridView1.Rows) 
                    {
                        attending_tableTableAdapter.Update_by_attending_id("مسدد", Convert.ToInt32(dgr.Cells[0].Value.ToString()));
                    }

                    foreach (DataGridViewRow dgr in dataGridView2.Rows)
                    {
                        solfa_tableTableAdapter.Update_status_by_id("مسدد", Convert.ToInt32(dgr.Cells[5].Value.ToString()));
                    }

                    foreach (DataGridViewRow dgr in dataGridView3.Rows)
                    {
                        extra_tableTableAdapter.Update_status_by_id("مسدد", Convert.ToInt32(dgr.Cells[5].Value.ToString()));
                    }

                    foreach (DataGridViewRow dgr in dataGridView4.Rows)
                    {
                        mokaf2at_tableTableAdapter.Update_status_by_id("مسدد", Convert.ToInt32(dgr.Cells[5].Value.ToString()));
                    }

                    foreach (DataGridViewRow dgr in dataGridView5.Rows)
                    {
                        disocuntsTableAdapter.Update_status_by_id("مسدد", Convert.ToInt32(dgr.Cells[5].Value.ToString()));
                    }
                    MessageBox.Show("تم الصرف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    name_txt_TextChanged(sender, e);
                    cost_txt.Text = "0";
                    final_cost_txt.Text = "0";
                }




                this.Cursor = Cursors.Arrow;  // Set the cursor to indicate loading
                this.Enabled = true;              // Disable form to prevent interaction
            }
            catch { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        //private void ta3deel_(object sender, EventArgs e)
        //{
           
        //}
        //string id;
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try 
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
              string  id = selectedRow.Cells[0].Value.ToString();
                edit_attending ea = new edit_attending();
                ea.id_txt.Text = id;
                ea.user_txt.Text = usertxt.Text;
                ea.ShowDialog();
                name_txt_TextChanged(sender, e);

            }
            catch { }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
                if (dgr.Cells[2].Value.ToString() == "غياب باذن")
                {
                    dgr.DefaultCellStyle.BackColor = Color.LightCoral;
                    dgr.DefaultCellStyle.ForeColor = Color.White;
                }
                else if (dgr.Cells[2].Value.ToString() == "غياب بدون اذن")
                {
                    dgr.DefaultCellStyle.BackColor = Color.Red;
                    dgr.DefaultCellStyle.ForeColor = Color.White;
                }
                else if (dgr.Cells[2].Value.ToString() == "حضر")
                {
                    dgr.DefaultCellStyle.BackColor = Color.Green;
                    dgr.DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
                if (dgr.Cells[2].Value.ToString() == "غياب باذن")
                {
                    dgr.DefaultCellStyle.BackColor = Color.LightCoral;
                    dgr.DefaultCellStyle.ForeColor = Color.White;
                }
                else if (dgr.Cells[2].Value.ToString() == "غياب بدون اذن")
                {
                    dgr.DefaultCellStyle.BackColor = Color.Red;
                    dgr.DefaultCellStyle.ForeColor = Color.White;
                }
                else if (dgr.Cells[2].Value.ToString() == "حضر")
                {
                    dgr.DefaultCellStyle.BackColor = Color.Green;
                    dgr.DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            pharmacy_dataTableAdapter1.Fill(dataSet11.pharmacy_data);
            //madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet11.madeen_small_report, cst_name_txt.Text);
            //customersTableAdapter1.Fill(dataSet11.customers);
            employees_report_print1.Refresh();
            employees_report_print1.SetDataSource(dataSet11);


            string param;

            param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";
            // MessageBox.Show(param);
            //a5_fatora_crystal_report1.SetParameterValue("test", param);
            string title = "تقرير الموظف / "+name_txt.Text+" عن الفترة من " + dateTimePicker1.Value.ToShortDateString() + " الى " + dateTimePicker2.Value.ToShortDateString();
            employees_report_print1.SetParameterValue("title", title);

            attending_tableTableAdapter.FillBy_emp_in_fatra(dataSet11.attending_table, name_txt.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
            
            disocuntsTableAdapter.FillBy_emp_and_fatra(dataSet11.disocunts, name_txt.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
            solfa_tableTableAdapter.FillBy_emp_and_fatra(dataSet11.solfa_table, name_txt.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
            extra_tableTableAdapter.FillBy_emp_name_and_fatra(dataSet11.extra_table, name_txt.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
            mokaf2at_tableTableAdapter.FillBy_emp_name_and_fatra(dataSet11.mokaf2at_table, name_txt.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
            // name_txt_TextChanged(sender, e);



           // MessageBox.Show(dataSet11.attending_table.Rows.Count.ToString());

               //SaveFileDialog sf = new SaveFileDialog();
               // sf.Filter = "PDF (*.pdf)|*.pdf";
               // sf.FileName = name_txt.Text;
               // if (sf.ShowDialog() == DialogResult.OK)
               // {
               //     FileInfo path_file = new FileInfo(sf.FileName);
               //     string name = sf.FileName;
               //     //name = name.Replace("/", "-");

               //     //MessageBox.Show(name);
               //     employees_report_print1.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, path_file.ToString());
               //     System.Diagnostics.Process.Start(path_file.ToString());
               // }


            StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_a4.txt");
            string printer_name = srr.ReadLine();
            employees_report_print1.PrintOptions.PrinterName = printer_name;
            employees_report_print1.PrintToPrinter(1, false, 0, 0);
            employees_report_print1.Dispose();
            employees_report_print1.Close();
            employees_report_print1.Refresh();
        }


        private void delete_solfa_click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("هل تريد حذف السلفة بقيمة " + solfa_cost + "؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (re == DialogResult.Yes)
            {
                solfa_tableTableAdapter.Delete_by_id(solfa_id_in_dgv);
                outcome_tableTableAdapter1.Delete_details_src_ID_cost_far3("سلفه " + name_txt.Text, "سلف", 0, solfa_cost,far3txt.Text);
                deleted_tableTableAdapter1.Insert(DateTime.Today, "0", "سلفه " + name_txt.Text, "", usertxt.Text, "سلف");
                MessageBox.Show("تم الحذف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                name_txt_TextChanged(sender, e);
            }
        }
        int solfa_id_in_dgv=0;
        decimal solfa_cost = 0;
        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {

                    int selectedrowindex = dataGridView2.HitTest(e.X, e.Y).RowIndex;
                    dataGridView2.ClearSelection();
                    dataGridView2.Rows[selectedrowindex].Selected = true;


                    //int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView2.Rows[selectedrowindex];
                    solfa_id_in_dgv = Convert.ToInt32(selectedRow.Cells[5].Value);
                    solfa_cost = Convert.ToDecimal(selectedRow.Cells[1].Value);
                    var m = new ContextMenu();
                    var delete_solfa = new MenuItem("حذف السلفة");
                    // var ta3deel = new MenuItem("تعديل");
                    m.MenuItems.Add(delete_solfa);



                    delete_solfa.Click += delete_solfa_click;



                    int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                    m.Show(dataGridView2, new Point(e.X, e.Y));
                }
            }
            catch { }
        }

        
       

       

    }
}
