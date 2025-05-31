using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace pharma_manage
{
    public partial class outcome : Form
    {
        public outcome()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
        }


        private void suggest_cst_name()
        {
            this.outcome_tableTableAdapter.Fill(this.dataSet1.outcome_table);
            cst_nameTXT.AutoCompleteMode = AutoCompleteMode.Suggest;
            cst_nameTXT.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet1.outcome_table.Rows)
            {
                DataCollection.Add(dr["outcome_esm_elmashroo3"].ToString());
                DataCollection.Add(dr["outcome_user"].ToString());
                DataCollection.Add(dr["outcome_source"].ToString());
                DataCollection.Add(dr["outcome_details"].ToString());

            }

          
            cst_nameTXT.AutoCompleteCustomSource = DataCollection;

        }
        private void outcome_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                decimal sum = 0;
                decimal nathryat = 0;
                decimal purchases = 0;
                decimal mortaga3at = 0;
                decimal others= 0;

                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
                    if (dataGridView1.Rows[i].Cells[5].Value.ToString().Contains("نثريات")) 
                    {
                        nathryat += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
                    }
                    else if (dataGridView1.Rows[i].Cells[5].Value.ToString().Contains("مرتجع"))
                    {
                        mortaga3at += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
                    }
                   else if (dataGridView1.Rows[i].Cells[5].Value.ToString().Contains("شراء"))
                    {
                        purchases += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
                    }
                    else
                    {
                        others += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
                    }
                }
                nathryat_txt.Text = nathryat.ToString();
                mortaga3at_txt.Text = mortaga3at.ToString();
                purchases_txt.Text = purchases.ToString();
                others_txt.Text = others.ToString();
                textBox1.Text = sum.ToString();
                // MessageBox.Show(sum.ToString());
            }
            catch { }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            cst_nameTXT_TextChanged(sender, e);

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

            cst_nameTXT_TextChanged(sender, e);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //outcome_print o = new outcome_print();
            //o.Text = "طباعة الصادر من الخزينة";
            //o.dateTimePicker1.Value = dateTimePicker1.Value;
            //o.dateTimePicker2.Value = dateTimePicker2.Value;
            //o.ShowDialog();

            outcome_report_form o = new outcome_report_form();
           // o.Text = "طباعة الصادر من الخزينة";
            o.dateTimePicker1.Value = dateTimePicker1.Value;
            o.dateTimePicker2.Value = dateTimePicker2.Value;
            o.cst_nameTXT.Text = cst_nameTXT.Text;
            o.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

            if (selectedRow.Cells[4].Value.ToString() != "0")
            {
                if (selectedRow.Cells[5].Value.ToString().Contains("بيع"))
                {
                    sales_fatora s = new sales_fatora();
                    s.Text = "مراجعة فاتورة مبيعات";
                    s.salesID_TXT.Text = selectedRow.Cells[4].Value.ToString();
                    s.far3txt.Text = far3_txt.Text;
                    s.ShowDialog();
                }
                else if (selectedRow.Cells[5].Value.ToString().Contains("شراء"))
                {

                    purchases_fatora s = new purchases_fatora();
                    s.Text = "مراجعة فاتورة مشتريات";
                    s.salesID_TXT.Text = selectedRow.Cells[4].Value.ToString();
                    s.far3txt.Text = far3_txt.Text;
                    s.ShowDialog();
                }
            }
        }

        private void cst_nameTXT_TextChanged(object sender, EventArgs e)
        {
            //dateTimePicker1_ValueChanged(sender, e);
            dataGridView1.DataSource = dataSet1.outcome_table;
            if (far3_txt.Text == "")
            {
                if (cst_nameTXT.Text == "")
                {
                    outcome_tableTableAdapter.FillBy_fatra(dataSet1.outcome_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
                }
                else 
                {
                    outcome_tableTableAdapter.FillBy_esm_elmashroo3_in_fatra(dataSet1.outcome_table, cst_nameTXT.Text,dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
                    if (dataSet1.outcome_table.Rows.Count <= 0)
                    {// 1. Split and format the source list
                        string[] sources = cst_nameTXT.Text.Split(new[] { '+' }, StringSplitOptions.RemoveEmptyEntries);
                        string sourcesList = string.Join(",", sources.Select(s => "'" + s.Trim().Replace("'", "''") + "'"));

                        // 2. Prepare SQL query
                        string query = @"
    SELECT outcome_cost, outcome_date, outcome_details, outcome_esm_elmashroo3, 
           outcome_far3, outcome_fator_id, outcome_id, outcome_notes, 
           outcome_source, outcome_user
    FROM outcome_table
    WHERE outcome_source IN (" + sourcesList + @")
      AND outcome_date BETWEEN @date1 AND @date2";

                        // 3. Execute query using SqlCommand
                        using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.Pharma_Manage_DBConnectionString))
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@date1", dateTimePicker1.Value.Date);
                            cmd.Parameters.AddWithValue("@date2", dateTimePicker2.Value.Date);
                          //  cmd.Parameters.AddWithValue("@far3", far3_txt.Text);

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataSet ds = new DataSet();
                            adapter.Fill(ds, "outcome_table");

                            // Bind result to DataGridView or any control
                            dataGridView1.DataSource = ds.Tables["outcome_table"];
                        }
                       // outcome_tableTableAdapter.FillBy_src_in_fatra(dataSet1.outcome_table, cst_nameTXT.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
                    }
                    if (dataSet1.outcome_table.Rows.Count <= 0)
                    {
                        outcome_tableTableAdapter.FillBy_user_in_fatra(dataSet1.outcome_table, cst_nameTXT.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
                    }
                    if (dataSet1.outcome_table.Rows.Count <= 0)
                    {
                        outcome_tableTableAdapter.FillBy_details_like_in_fatra(dataSet1.outcome_table, cst_nameTXT.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
                    }
                }
            }
            else 
            {
                if (cst_nameTXT.Text == "")
                {
                    outcome_tableTableAdapter.FillBy_fatra_far3(dataSet1.outcome_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(),far3_txt.Text);
                }
                else 
                {
                    outcome_tableTableAdapter.FillBy_esm_elmashroo3_in_fatra_far3(dataSet1.outcome_table, cst_nameTXT.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(),far3_txt.Text);
                    if (dataSet1.outcome_table.Rows.Count <= 0)
                    {
                        // 1. Split and format the source list
                        string[] sources = cst_nameTXT.Text.Split(new[] { '+' }, StringSplitOptions.RemoveEmptyEntries);
                        string sourcesList = string.Join(",", sources.Select(s => "'" + s.Trim().Replace("'", "''") + "'"));

                        // 2. Prepare SQL query
                        string query = @"
    SELECT outcome_cost, outcome_date, outcome_details, outcome_esm_elmashroo3, 
           outcome_far3, outcome_fator_id, outcome_id, outcome_notes, 
           outcome_source, outcome_user
    FROM outcome_table
    WHERE outcome_source IN (" + sourcesList + @")
      AND outcome_date BETWEEN @date1 AND @date2
      AND outcome_far3 = @far3";

                        // 3. Execute query using SqlCommand
                        using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.Pharma_Manage_DBConnectionString))
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@date1", dateTimePicker1.Value.Date);
                            cmd.Parameters.AddWithValue("@date2", dateTimePicker2.Value.Date);
                            cmd.Parameters.AddWithValue("@far3", far3_txt.Text);

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataSet ds = new DataSet();
                            adapter.Fill(ds, "outcome_table");

                            // Bind result to DataGridView or any control
                            dataGridView1.DataSource = ds.Tables["outcome_table"];
                       }
                     //outcome_tableTableAdapter.FillBy_src_in_fatra_far3(dataSet1.outcome_table, cst_nameTXT.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(),far3_txt.Text);
                    }
                    if (dataSet1.outcome_table.Rows.Count <= 0)
                    {
                        outcome_tableTableAdapter.FillBy_user_in_fatra_far3(dataSet1.outcome_table, cst_nameTXT.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(),far3_txt.Text);
                    }
                    if (dataSet1.outcome_table.Rows.Count <= 0)
                    {
                        outcome_tableTableAdapter.FillBy_details_like_in_fatra_far3(dataSet1.outcome_table, cst_nameTXT.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(),far3_txt.Text);
                    }
                }
            }
        }

        private void far3_txt_SelectedIndexChanged(object sender, EventArgs e)
        {

            cst_nameTXT_TextChanged(sender, e);
        }

        private void far3_txt_TextChanged(object sender, EventArgs e)
        {

            cst_nameTXT_TextChanged(sender, e);
        }
        private void delete_Click(object sender, EventArgs e)
        {


            DialogResult re = MessageBox.Show("هل تريد حذف البيان " + byan + " ?", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (re == DialogResult.Yes)
            {
                outcome_tableTableAdapter.Delete_by_id(local_id);
                deleted_tableTableAdapter1.Insert(DateTime.Today, local_id.ToString(), byan, "", usertxt.Text, "الصادر من الخزينة");
                MessageBox.Show("تم الحذف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateTimePicker1_ValueChanged(sender, e);
            }
        }
        int local_id;
        int selectedrowindex;
        string byan;
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                selectedrowindex = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                dataGridView1.ClearSelection();
                dataGridView1.Rows[selectedrowindex].Selected = true;


                //int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                local_id = Convert.ToInt32(selectedRow.Cells[0].Value);
                // MessageBox.Show(pro_id_pub.ToString());
                byan = Convert.ToString(selectedRow.Cells[2].Value) + "بقيمة " + selectedRow.Cells[3].Value.ToString();
                //far3 = selectedRow.Cells[4].Value.ToString();

                // MessageBox.Show(pro_name_pub.ToString());
                var m = new ContextMenu();

                //var ma5zoon = new MenuItem("حركة المخزون");
                //var show_picture = new MenuItem("عرض الصورة");
                //var add_halek_ = new MenuItem("اضافة هالك");
                //ma5zoon.Click += go_to_ma5zoon;
                //show_picture.Click += show_picture_click;
                //add_halek_.Click += add_halek_click;

                //m.MenuItems.Add(ma5zoon);
                //m.MenuItems.Add(show_picture);
                //m.MenuItems.Add(add_halek_);


                if (listBox1.Items.Contains("إضافة مستخدم"))
                {
                    if (selectedRow.Cells[5].Value.ToString() != "شراء" && selectedRow.Cells[5].Value.ToString() != "مرتجع بيع" && selectedRow.Cells[5].Value.ToString() != "دفعات دائنين" &&  selectedRow.Cells[5].Value.ToString() != "سلف" && selectedRow.Cells[5].Value.ToString() != "رواتب")
                    {
                        var delete = new MenuItem("حذف");
                        m.MenuItems.Add(delete);
                        delete.Click += delete_Click;
                    }

                }
                //  (mi);
                // handle menu item click event here [as required]

                int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                m.Show(dataGridView1, new Point(e.X, e.Y));
            }
        }

        private void outcome_Shown(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.outcome_table' table. You can move, or remove it, as needed.
            //this.outcome_tableTableAdapter.Fill(this.dataSet1.outcome_table);



            suggest_cst_name();

            this.stock_tableTableAdapter1.Fill(this.dataSet1.stock_table);
            foreach (DataRow dr in dataSet1.stock_table.Rows)
            {
                if (far3_txt.Items.Contains(dr["stock_name"].ToString()))
                { }
                else
                {
                    far3_txt.Items.Add(dr["stock_name"].ToString());
                }
            }


            dateTimePicker1_ValueChanged(sender, e);

            if (usertxt.Text != "admin")
            {
                user_previligesTableAdapter1.FillBy_name(dataSet1.user_previliges, usertxt.Text);



                foreach (DataRow dr in dataSet1.user_previliges.Rows)
                {
                    listBox1.Items.Add(dr["user_previliges"].ToString());

                }
            }
        }
    }
}
