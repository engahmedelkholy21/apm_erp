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
    public partial class tawreedat_list : Form
    {
        public tawreedat_list()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
        }

        private void tawreedat_list_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.tawreedat_table' table. You can move, or remove it, as needed.
            this.tawreedat_tableTableAdapter.Fill(this.dataSet1.tawreedat_table);
            suggest_cst_name();

        }

        private void suggest_cst_name()
        {
            this.tawreedat_tableTableAdapter.Fill(this.dataSet1.tawreedat_table);
            name_txt.AutoCompleteMode = AutoCompleteMode.Suggest;
            name_txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet1.tawreedat_table.Rows)
            {
                DataCollection.Add(dr["tawreedat_material_name"].ToString());
            }


            name_txt.AutoCompleteCustomSource = DataCollection;

        }

        private void name_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (name_txt.Text == "")
                {
                    tawreedat_tableTableAdapter.FillBy_fatra(dataSet1.tawreedat_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
                }
                else
                {
                    delete_btn.Visible = false;
                    tawreedat_tableTableAdapter.FillBy_amr_sho3l(dataSet1.tawreedat_table, name_txt.Text);
                    if (dataSet1.tawreedat_table.Rows.Count <= 0)
                    {
                        tawreedat_tableTableAdapter.FillBy_fatra_book(dataSet1.tawreedat_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), name_txt.Text);
                    }

                    if (dataSet1.tawreedat_table.Rows.Count <= 0)
                    {
                        tawreedat_tableTableAdapter.FillBy_tawreedat_no(dataSet1.tawreedat_table,Convert.ToInt32(name_txt.Text));
                        delete_btn.Visible = true;
                        if (dataSet1.tawreedat_table.Rows.Count <= 0)
                        {
                            delete_btn.Visible = false;
                        }
                    }


                }

            }
            catch { }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            name_txt_TextChanged(sender, e);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            name_txt_TextChanged(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                decimal sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);

                }
                total_txt.Text = sum.ToString();
                // MessageBox.Show(sum.ToString());
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_a4.txt");
            string printer_name = srr.ReadLine();

            string param;
            string address_param = "تقرير توريدات";

            param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";
            pharmacy_dataTableAdapter1.Fill(dataSet1.pharmacy_data);
            try
            {

                tawreedat_report1.Refresh();
                tawreedat_report1.SetDataSource(dataSet1);


                // MessageBox.Show(param);
                tawreedat_report1.SetParameterValue("test", param);

                tawreedat_report1.SetParameterValue("address_param", address_param);


              name_txt_TextChanged(sender, e);
                tawreedat_report1.PrintOptions.PrinterName = printer_name;
                tawreedat_report1.PrintToPrinter(1, false, 0, 0);
                tawreedat_report1.Dispose();
                tawreedat_report1.Close();
                tawreedat_report1.Refresh();


            }
            catch
            { }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("هل تريد حذف الفاتورة رقم " + name_txt.Text, "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (d == DialogResult.Yes)
            {
                int fatora_no;
                fatora_no = Convert.ToInt32(name_txt.Text);
                //update materials

                //insert ma5zoon
                foreach (DataGridViewRow dgr in dataGridView1.Rows)
                {

                    //insert ma5zoon
                    products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, dgr.Cells[4].Value.ToString(), dgr.Cells[8].Value.ToString());
                    decimal count_before = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);
                    decimal current_count = Convert.ToDecimal(dgr.Cells[5].Value);
                    decimal count_after = count_before - current_count;

                    ma5zoon_movesTableAdapter1.Insert_ma5zoon_moves_all(dateTimePicker1.Value.ToShortDateString(), dgr.Cells[3].Value.ToString(), dgr.Cells[4].Value.ToString(), current_count,
                        0,  count_before, count_after, " حذف توريد رقم "+name_txt.Text, Convert.ToInt32(name_txt.Text), dgr.Cells[2].Value.ToString(), user_txt.Text, dgr.Cells[8].Value.ToString());

                    ////insert mas7obat
                    //tawreedat_tableTableAdapter1.Insert(Convert.ToInt32(salesID_TXT.Text), dateTimePicker1.Value, cst_nameTXT.Text, dgr.Cells[0].Value.ToString(), dgr.Cells[1].Value.ToString()
                    //    , Convert.ToDecimal(dgr.Cells[2].Value), "", amr_sho3l_txt.Text, user_txt.Text, stock_txt.Text);


                    // update materials
                    products_tableTableAdapter1.Update_count_BY_ID_bee3(current_count, current_count, dgr.Cells[8].Value.ToString(), dgr.Cells[4].Value.ToString());

                    tawreedat_tableTableAdapter.Delete_by_tawreedat_no(Convert.ToInt32(name_txt.Text));
                }

                MessageBox.Show("تم الحذف بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                name_txt_TextChanged(sender, e);
            }
        }
    }
}
