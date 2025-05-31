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
    public partial class add_serial : Form
    {
        public add_serial()
        {
            InitializeComponent();
            Form1 f1 = new Form1();
            f1.SubscribeToLoadEvent(this);
            f1.ApplyFormStyling(this);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                added_serials_txt.Text = dataGridView1.Rows.Count.ToString();
            }
            catch { }
        }

        private void add_serial_Load(object sender, EventArgs e)
        {
            suggest_product();


        }
        private void suggest_product()
        {
            this.products_tableTableAdapter1.Fill(this.dataSet1.products_table);
            name_txt.AutoCompleteMode = AutoCompleteMode.Suggest;
            name_txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet1.products_table.Rows)
            {
                DataCollection.Add(dr["pro_name"].ToString());
                //DataCollection.Add(dr["pro_category"].ToString());
                //DataCollection.Add(dr["pro_mada_fa3ala"].ToString());
                //DataCollection.Add(dr["pro_marad"].ToString());
                //DataCollection.Add(dr["pro_mwared"].ToString());

            }

            name_txt.AutoCompleteCustomSource = DataCollection;

        }

        

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (serial_txt.Text == "")
            {
                MessageBox.Show("ادخل السيريال");
                serial_txt.Focus();
                return;
            }
            if (Convert.ToDecimal(added_serials_txt.Text) < Convert.ToDecimal(pro_count_txt.Text))
            {
                serial_tableTableAdapter.FillBy_serial_no(dataSet1.serial_table, serial_txt.Text);
                if (dataSet1.serial_table.Rows.Count <= 0)
                {
                    serial_tableTableAdapter.Insert(pro_id_txt.Text, name_txt.Text, serial_txt.Text, usertxt.Text, DateTime.Today);
                    serial_txt.Clear();
                    serial_txt.Focus();
                    serial_tableTableAdapter.FillBy_serial_pro_id(dataSet1.serial_table, pro_id_txt.Text);
                }
                else
                {
                    MessageBox.Show("السيريال موجود مسبقا");
                    return;
                }
            }
            else
            {
                MessageBox.Show("لا يمكن اضافة سيريالات اكثر من الكمية الموجودة في الفرع");
                return;
            }
        }

        private void name_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) 
            {
                try
                {
                    products_tableTableAdapter1.FillBy_name(dataSet1.products_table, name_txt.Text);
                    pro_id_txt.Text = dataSet1.products_table.Rows[0]["pro_ID"].ToString();
                    pro_count_txt.Text = dataSet1.products_table.Rows[0]["pro_count"].ToString();
                    serial_txt.Focus();
                    serial_tableTableAdapter.FillBy_serial_pro_id(dataSet1.serial_table, pro_id_txt.Text);
                }
                catch { }
            }
        }

        private void pro_id_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                try
                {
                    products_tableTableAdapter1.FillBy_id(dataSet1.products_table, Convert.ToInt32(pro_id_txt.Text));
                    pro_id_txt.Text = dataSet1.products_table.Rows[0]["pro_name"].ToString();
                    pro_count_txt.Text = dataSet1.products_table.Rows[0]["pro_count"].ToString();
                    serial_txt.Focus();
                    serial_tableTableAdapter.FillBy_serial_pro_id(dataSet1.serial_table, pro_id_txt.Text);
                }
                catch { }
            }
        }

        private void name_txt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void serial_txt_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = addbtn;
        }

        private void serial_txt_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }
    }
}
