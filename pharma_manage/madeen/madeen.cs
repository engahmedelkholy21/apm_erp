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
    public partial class madeen : Form
    {
        public madeen()
        {
            InitializeComponent();
        }

        private void madeen_Load(object sender, EventArgs e)
        {
            if (usertxt.Text != "admin")
            {
                
                user_previligesTableAdapter1.FillBy_name(dataSet1.user_previliges, usertxt.Text);



                foreach (DataRow dr in dataSet1.user_previliges.Rows)
                {
                    listBox1.Items.Add(dr["user_previliges"].ToString());

                }
                if (listBox1.Items.Contains("إضافة مستخدم"))
                {
                    button1.Visible = true;
                }
                else
                {
                    button1.Visible = false;
                }
            }
                //delete if ba2y 0
            madeen_small_reportTableAdapter.Delete_when0();
            // TODO: This line of code loads data into the 'dataSet1.madeen_small_report' table. You can move, or remove it, as needed.
            this.madeen_small_reportTableAdapter.Fill(this.dataSet1.madeen_small_report);

            
            //suggest
            try
            {
                search_text.AutoCompleteMode = AutoCompleteMode.Suggest;
                search_text.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
                foreach (DataRow dr in dataSet1.madeen_small_report.Rows)
                {
                    DataCollection.Add(dr["madeen_small_name"].ToString());
                }

                search_text.AutoCompleteCustomSource = DataCollection;
            }
            catch { }
            foreach (DataGridViewRow dgr in dataGridView1.Rows) 
            {
                //dgr.Cells[5].Value = true;
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            madeen_small_reportTableAdapter.FillBy_madeen_small_name(dataSet1.madeen_small_report, search_text.Text);
            
           if (dataSet1.madeen_small_report.Rows.Count <= 0)
            {
                customersTableAdapter1.FillBy_id(dataSet1.customers, Convert.ToInt32(search_text.Text));
                string name = dataSet1.customers.Rows[0]["cst_name"].ToString();
                madeen_small_reportTableAdapter.FillBy_madeen_small_name(dataSet1.madeen_small_report, name);
                  
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                decimal sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                }
                egmalyTXT.Text = sum.ToString();

                //delete if ba2y 0
                madeen_small_reportTableAdapter.Delete_when0();

            }
            catch { }
        }

        private void madeen_details_move_click(object sender, EventArgs e)
        {
            mosta7kat_show md = new mosta7kat_show();

            md.usertxt.Text = usertxt.Text;
            md.Text = "تفاصيل حساب مدين";
            md.cst_name_txt.Text = madeen_name;
            md.far3txt.Text = far3txt.Text;
            md.ShowDialog();
        }

        private void madeen_pay_click(object sender, EventArgs e)
        {
            pay_madeen pm = new pay_madeen();

            pm.usertxt.Text = usertxt.Text;
            pm.Text = "دفع مبلغ من الحساب";
            pm.madeen_nameTXT.Text = madeen_name;
            pm.far3txt.Text = far3txt.Text;
            Form1 f = new Form1();
            f.SubscribeToLoadEvent(pm);
            f.ApplyFormStyling(pm);
            pm.ShowDialog();
          pictureBox1_Click(sender, e);
        }

        private void madeen_add_click(object sender, EventArgs e)
        {
            pay_madeen pm = new pay_madeen();

            pm.usertxt.Text = usertxt.Text;
            pm.Text = "اضافة مبلغ للحساب";
            pm.madeen_nameTXT.Text = madeen_name;
            pm.far3txt.Text = far3txt.Text;
            Form1 f = new Form1();
            f.SubscribeToLoadEvent(pm);
            f.ApplyFormStyling(pm);
            pm.ShowDialog();
            pictureBox1_Click(sender, e);
        }
        private void delete_Click(object sender, EventArgs e)
        {


            DialogResult re = MessageBox.Show("هل تريد حذف المدين " + madeen_name + " ?  سيتم حذف كشف الحساب نهائيا", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (re == DialogResult.Yes)
            {
                madeen_small_reportTableAdapter.Delete_by_name(madeen_name);
                mosta7akat_tableTableAdapter1.Delete_by_name(madeen_name);
                deleted_tableTableAdapter1.Insert(DateTime.Today,"", madeen_name, byan, usertxt.Text, "قائمة المدينين");
                MessageBox.Show("تم الحذف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                search_text_TextChanged(sender, e);
            }
        }
        string madeen_name;
        string byan;
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {

                    int selectedrowindex = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[selectedrowindex].Selected = true;


                    //int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                    madeen_name = selectedRow.Cells[1].Value.ToString();
                    byan = "المبلغ المستحق وقتها" + Convert.ToString(selectedRow.Cells[4].Value);
                    var m = new ContextMenu();
                    var madeen_details_move = new MenuItem("تفاصيل حساب مدين");
                    var madeen_pay = new MenuItem("دفع مبلغ من الحساب");
                    // var ta3deel = new MenuItem("تعديل");
                    m.MenuItems.Add(madeen_details_move);
                    m.MenuItems.Add(madeen_pay);
                    // m.MenuItems.Add(ta3deel);

                    var madeen_add = new MenuItem("اضافة مبلغ للحساب");
                    m.MenuItems.Add(madeen_add);
                    madeen_add.Click += madeen_add_click;
                    madeen_details_move.Click += madeen_details_move_click;
                    madeen_pay.Click += madeen_pay_click;
                    if (listBox1.Items.Contains("إضافة مستخدم"))
                    {

                        var delete = new MenuItem("حذف");
                        m.MenuItems.Add(delete);
                        delete.Click += delete_Click;


                    }

                    int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                    m.Show(dataGridView1, new Point(e.X, e.Y));
                }
                catch { }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            madeen_small_reportTableAdapter.Delete_when0();
            // TODO: This line of code loads data into the 'dataSet1.madeen_small_report' table. You can move, or remove it, as needed.
            this.madeen_small_reportTableAdapter.Fill(this.dataSet1.madeen_small_report);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            madeen_print_2 m = new madeen_print_2();
            // m.textBox1.Text = search_text.Text;
            m.ShowDialog();



            //StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_a4.txt");
            //string printer_name = srr.ReadLine();

            //string param;

            //param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";
            ////pharmacy_dataTableAdapter1.Fill(dataSet1.pharmacy_data);
            //customersTableAdapter1.Fill(dataSet1.customers);
            //try
            //{

            //    madeen_list_report1.Refresh();
            //    madeen_list_report1.SetDataSource(dataSet1);

               
            //   // sales_detailed_report_grouped1.SetParameterValue("test", param);

            //    madeen_small_reportTableAdapter.Fill(dataSet1.madeen_small_report);

            //    madeen_list_report1.PrintOptions.PrinterName = printer_name;
            //    madeen_list_report1.PrintToPrinter(1, false, 0, 0);
            //    madeen_list_report1.Dispose();
            //    madeen_list_report1.Close();

            //}
            //catch { }
        }






        private void search_text_TextChanged(object sender, EventArgs e)
        {
           
            madeen_small_reportTableAdapter.FillBy_NAME_LIKE(dataSet1.madeen_small_report, search_text.Text);
           
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Apps)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                madeen_name = selectedRow.Cells[1].Value.ToString();
                byan = "المبلغ المستحق وقتها" + Convert.ToString(selectedRow.Cells[4].Value);
                //  pro_name_pub = Convert.ToString(selectedRow.Cells[2].Value);
                var m = new ContextMenu();
                var madeen_details_move = new MenuItem("تفاصيل حساب مدين");
                var madeen_pay = new MenuItem("دفع مبلغ من الحساب");
                // var ta3deel = new MenuItem("تعديل");
                m.MenuItems.Add(madeen_details_move);
                m.MenuItems.Add(madeen_pay);
                // m.MenuItems.Add(ta3deel);


                madeen_details_move.Click += madeen_details_move_click;
                madeen_pay.Click += madeen_pay_click;

                if (listBox1.Items.Contains("إضافة مستخدم"))
                {

                    var delete = new MenuItem("حذف");
                    
                    m.MenuItems.Add(delete);
                    delete.Click += delete_Click;


                }
                try
                {
                    m.Show(dataGridView1, new Point(dataGridView1.Location.X + dataGridView1.Width, dataGridView1.Location.Y +
                   dataGridView1.GetCellDisplayRectangle(0, selectedrowindex + 1, true).Location.Y));
                }
                catch
                {
                    m.Show(dataGridView1, new Point(0, 0));
                }
                //int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                //m.Show(dataGridView1, new Point(e.X, e.Y));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal sum = 0;
            decimal selected_count = 0;
            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(dgr.Cells[7].Value) == true)
                {
                    selected_count += 1;
                    sum += Convert.ToDecimal(dgr.Cells[4].Value);
                }
            }
            if (selected_count <= 0) 
            {
                return;
            }
             DialogResult d= MessageBox.Show("هل تريد سداد جميع المدينين  المحددين بإجمالي مبلغ "+sum.ToString()+" ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
             if (d == DialogResult.Yes)
             {

                 foreach (DataGridViewRow dgr in dataGridView1.Rows)
                 {
                     if (Convert.ToBoolean(dgr.Cells[7].Value)== true)
                     {

                         madeen_small_reportTableAdapter.FillBy_madeen_small_name(dataSet11.madeen_small_report, dgr.Cells[1].Value.ToString());

                         //update madeen small report
                         madeen_small_reportTableAdapter.Update_madfoo3_by_name(Convert.ToDecimal(dgr.Cells[4].Value), dgr.Cells[1].Value.ToString());



                         mosta7akat_tableTableAdapter1.Insert(dgr.Cells[1].Value.ToString(), DateTime.Today, Convert.ToDecimal(dgr.Cells[2].Value), Convert.ToDecimal(dgr.Cells[3].Value) + Convert.ToDecimal(dgr.Cells[4].Value), 0, Convert.ToDecimal(dgr.Cells[4].Value)
                             , usertxt.Text, Convert.ToDecimal(dgr.Cells[4].Value), Convert.ToDecimal(dgr.Cells[4].Value) - Convert.ToDecimal(dgr.Cells[4].Value), "سداد من الحساب", "دائن", 0);

                         mosta7akat_tableTableAdapter1.FillBy_date_last_record(dataSet11.mosta7akat_table, DateTime.Today.ToShortDateString());

                         int most7kat_id = Convert.ToInt32(dataSet11.mosta7akat_table.Rows[0]["mosta7akat_id"]);

                         //insert to income
                         income_tableTableAdapter1.Insert_income(DateTime.Today.ToShortDateString(), "سداد من الحساب للعميل " + dgr.Cells[1].Value.ToString(), Convert.ToDecimal(dgr.Cells[4].Value), 0, "دفعات مدينين", dgr.Cells[1].Value.ToString(), usertxt.Text, "", far3txt.Text, 0);

                         //update current safe
                         safeTableAdapter1.Update_add_to_safe(Convert.ToDecimal(dgr.Cells[4].Value));

                         //update day safe
                         safeTableAdapter1.Insert_safe(DateTime.Today.ToShortDateString(), Convert.ToDecimal(dgr.Cells[4].Value));

                     }

                     //customersTableAdapter1.Update_notes_by_name(notesTXT.Text, madeen_nameTXT.Text);
                 }

                 MessageBox.Show("تم الدفع بنجاح ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
             } 

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Focused == true) 
            {
                if (checkBox1.Checked == true)
                {
                    foreach (DataGridViewRow dgr in dataGridView1.Rows)
                    {
                        dgr.Cells[7].Value = true;
                    }
                }
                else 
                {
                    foreach (DataGridViewRow dgr in dataGridView1.Rows)
                    {
                        dgr.Cells[7].Value = false;
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                if (checkBox1.Checked == true) 
                {
                    checkBox1.Checked = false;
                }
            }
        }

       
    }
}
