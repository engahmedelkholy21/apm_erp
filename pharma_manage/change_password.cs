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
    public partial class change_password : Form
    {
        public change_password()
        {
            InitializeComponent();
        }

        private void change_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void change_password_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.user_previliges' table. You can move, or remove it, as needed.
            this.user_previligesTableAdapter.Fill(this.dataSet1.user_previliges);

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try 
            {
                user_previligesTableAdapter.FillBy_name(dataSet1.user_previliges, username_txt.Text);

                string old_password = dataSet1.user_previliges.Rows[0]["password"].ToString();

                if (old_password != old_password_txt.Text) 
                {
                     MessageBox.Show("كلمة السر القديمة خاطئة. حاول مره اخري", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
             return;
                }
                if (passwordTXT.Text != confirm_password_TXT.Text) 
                {
                    MessageBox.Show("كلمة السر الجديدة غير متطابقة . حاول مره اخري", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                }
                user_previligesTableAdapter.Update_password(passwordTXT.Text, username_txt.Text);

                MessageBox.Show("تم التعديل بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                this.Close();
           
            }
            catch { }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
