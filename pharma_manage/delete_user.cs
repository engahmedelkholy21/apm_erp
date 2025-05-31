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
    public partial class delete_user : Form
    {
        public delete_user()
        {
            InitializeComponent();
        }

        private void delete_user_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.user_previliges' table. You can move, or remove it, as needed.
            this.user_previligesTableAdapter1.Fill(this.dataSet11.user_previliges);

            foreach (DataRow dr in dataSet11.user_previliges.Rows) 
            {
                if (comboBox1.Items.Contains(dr["user_name"].ToString()))
                {

                }
                else 
                {
                    comboBox1.Items.Add(dr["user_name"].ToString());
                }
            }
        }

        private void save_brn_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("هل انت متأكد من حذف  " + comboBox1.Text, "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (d == DialogResult.Yes)
            {
                user_previligesTableAdapter1.Delete_by_name(comboBox1.Text);
                MessageBox.Show("تم الحذف بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               
                comboBox1.Items.Clear();
                comboBox1.Text = "";
                this.user_previligesTableAdapter1.Fill(this.dataSet11.user_previliges);
                foreach (DataRow dr in dataSet11.user_previliges.Rows)
                {
                    if (comboBox1.Items.Contains(dr["user_name"].ToString()))
                    {

                    }
                    else
                    {
                        comboBox1.Items.Add(dr["user_name"].ToString());
                    }
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void delete_user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
