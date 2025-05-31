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
    public partial class madeen_details : Form
    {
        public madeen_details()
        {
            InitializeComponent();
        }
        private void suggest_madeen_name()
        {
            this.madeen_small_reportTableAdapter1.Fill(this.dataSet1.madeen_small_report);
            search_text.AutoCompleteMode = AutoCompleteMode.Suggest;
            search_text.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet1.madeen_small_report.Rows)
            {
                DataCollection.Add(dr["madeen_small_name"].ToString());
            }

            search_text.AutoCompleteCustomSource = DataCollection;

        }
        private void madeen_details_Load(object sender, EventArgs e)
        {
           
            madeen_tableTableAdapter.Delete_when0();

            suggest_madeen_name();

            search_text.Select();
            if (search_text.Text != "")
            {
                try
                {
                    madeen_tableTableAdapter.FillBy_by_madeen(dataSet1.madeen_table, search_text.Text);
                    matloobtxt.Text = dataSet1.madeen_table.Rows[0]["madden_matloob"].ToString();
                    madfoo3txt.Text = dataSet1.madeen_table.Rows[0]["madden_madfoo3"].ToString();
                    ba2ytxt.Text = dataSet1.madeen_table.Rows[0]["madden_ba2y"].ToString();
                    customersTableAdapter1.FillBy_name(dataSet1.customers, search_text.Text);
                    address_txt.Text = dataSet1.customers.Rows[0]["cst_address"].ToString();
                }
                catch { }
            }
            this.WindowState = FormWindowState.Maximized;

            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
                if (dgr.Cells[9].Value.ToString() != "paid")
                {
                    dgr.DefaultCellStyle.BackColor = Color.Red;
                }
            }

            
            try
            {

                daftar_txt.Text = dataSet1.madeen_table.Rows[0]["cst_notes"].ToString();
            }
            catch { }

           
           
            this.dataGridView1.Sort(this.dataGridView1.Columns[1], ListSortDirection.Ascending);

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            madeen_tableTableAdapter.Delete_when0();
            madeen_small_reportTableAdapter1.Delete_when0();
            try
            {
                madeen_tableTableAdapter.FillBy_by_madeen(dataSet1.madeen_table, search_text.Text);
                matloobtxt.Text = dataSet1.madeen_table.Rows[0]["madden_matloob"].ToString();
                madfoo3txt.Text = dataSet1.madeen_table.Rows[0]["madden_madfoo3"].ToString();
                ba2ytxt.Text = dataSet1.madeen_table.Rows[0]["madden_ba2y"].ToString();

                customersTableAdapter1.FillBy_name(dataSet1.customers, search_text.Text);
                address_txt.Text = dataSet1.customers.Rows[0]["cst_address"].ToString();
            }
            catch { }

            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
                if (dgr.Cells[9].Value.ToString() != "paid")
                {
                    dgr.DefaultCellStyle.BackColor = Color.Red;
                }
            }
            try
            {
                daftar_txt.Text = dataSet1.madeen_table.Rows[0]["cst_notes"].ToString();
            }
            catch { }
            this.dataGridView1.Sort(this.dataGridView1.Columns[1], ListSortDirection.Ascending);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pharmacy_dataTableAdapter1.Fill(dataSet1.pharmacy_data);
            a5_crystal_madeen_details1.Refresh();
            a5_crystal_madeen_details1.SetDataSource(dataSet1);


          
            madeen_tableTableAdapter.FillBy_by_madeen(dataSet1.madeen_table, search_text.Text);

            a5_crystal_madeen_details1.PrintToPrinter(1, false, 0, 0);
            a5_crystal_madeen_details1.Dispose();
            searchbtn_Click(sender, e);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

            if (selectedRow.Cells[9].Value.ToString() == "not paid")
            {

                pay_madeen p = new pay_madeen();
                p.madeen_nameTXT.Text = search_text.Text;
                p.Text = "دفع قسط";
                p.usertxt.Text = usertxt.Text;
                p.far3txt.Text = far3txt.Text;
              //  p.kest_num_txt.Text = selectedRow.Cells[0].Value.ToString();
                p.fatora_id_txt.Text = selectedRow.Cells[2].Value.ToString();
                p.est7kak_date_txt.Text = selectedRow.Cells[7].Value.ToString();
                p.ShowDialog();

            }
            else
            {
                MessageBox.Show("هذا القسط مدفوع مسبقا");
                return;
            }
           
        }



        private void pay_method(object sender, EventArgs e)
        {

            if (kest_status == "not paid")
            {

                pay_madeen p = new pay_madeen();
                p.madeen_nameTXT.Text = search_text.Text;
                p.usertxt.Text = usertxt.Text;
                p.Text = "دفع قسط";
                //p.kest_num_txt.Text = kest_no;
                p.fatora_id_txt.Text = fatora_id;
                p.est7kak_date_txt.Text = old_est7kak;
                p.ShowDialog();

            }
            else
            {
                MessageBox.Show("هذا القسط مدفوع مسبقا");
                return;
            }
        }


        private void ta3deel_(object sender, EventArgs e) 
        {
            //dataGridView1.ReadOnly = false;
            edit_madeen_details ee = new edit_madeen_details();
            ee.Text = "تعديل تفاصيل مدين";
            ee.fatora_id_txt.Text = fatora_id;
            ee.kest_num_txt.Text = kest_no;
            ee.kest_cost.Text = old_kest;
            ee.tafaseel_txt.Text = kest_details;
            ee.est7kak_txt.Text =Convert.ToDateTime(old_est7kak).ToShortDateString();
            ee.paid_date_txt.Text = old_paid_date;
            ee.status_txt.Text = kest_status;
            ee.fatora_date.Value = Convert.ToDateTime(fatora_date);
            ee.notes_txt.Text = old_notes;

            ee.old_kest_txt.Text = old_kest;
            ee.old_paid_date_txt.Text = old_paid_date;
            ee.old_status_txt.Text = kest_status;
            ee.madeen_name_txt.Text = search_text.Text;
            ee.daftartxt.Text = daftarforedit;

            ee.ShowDialog();
        }

        private void show_fatora_(object sender, EventArgs e)
        {
            sales_fatora s = new sales_fatora();
            s.salesID_TXT.Text = fatora_id;
            s.ShowDialog();

        }

        string kest_no;
        string kest_status;


        string old_kest;
        string old_est7kak;
        string old_paid_date;
        string kest_details;
        string fatora_id;
        string fatora_date;
        string old_notes;
        string daftarforedit;

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {


                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                kest_no = selectedRow.Cells[0].Value.ToString();
                kest_status = selectedRow.Cells[9].Value.ToString();
                old_kest = selectedRow.Cells[8].Value.ToString();
                old_est7kak = selectedRow.Cells[7].Value.ToString();
                old_paid_date = selectedRow.Cells[10].Value.ToString();
                kest_details = selectedRow.Cells[3].Value.ToString();
                fatora_id = selectedRow.Cells[2].Value.ToString();
                fatora_date = selectedRow.Cells[1].Value.ToString();
                old_notes = selectedRow.Cells[5].Value.ToString();
                daftarforedit = daftar_txt.Text;
                // MessageBox.Show(pro_id_pub.ToString());
                // pro_name = Convert.ToString(selectedRow.Cells[1].Value);
                // MessageBox.Show(pro_name_pub.ToString());
                var m = new ContextMenu();
                var pay = new MenuItem("دفع");
                var ta3deel = new MenuItem("تعديل");
                var fatora_num_show = new MenuItem("عرض الفاتورة");
                m.MenuItems.Add(pay);
                m.MenuItems.Add(ta3deel);
                m.MenuItems.Add(fatora_num_show);


                //  (mi);
                // handle menu item click event here [as required]
                pay.Click += pay_method;
                ta3deel.Click += ta3deel_;
                fatora_num_show.Click += show_fatora_;

                int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                m.Show(dataGridView1, new Point(e.X, e.Y));
            }
        
        }

      
        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            
         }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
                if (dgr.Cells[9].Value.ToString() != "paid")
                {
                    dgr.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow dgr in dataGridView1.Rows)
                {
                    if (dgr.Cells[9].Value.ToString() != "paid")
                    {
                        dgr.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
            catch { }

           

        }

        private void madeen_details_FormClosing(object sender, FormClosingEventArgs e)
        {
            madeen_tableTableAdapter.Delete_when0();
            madeen_small_reportTableAdapter1.Delete_when0();
        }

        

      
        }
}
