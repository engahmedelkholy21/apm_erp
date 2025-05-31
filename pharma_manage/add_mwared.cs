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
    public partial class add_mwared : Form
    {
        public add_mwared()
        {
            InitializeComponent();
        }

        private void save_brn_Click(object sender, EventArgs e)
        {
            this.mwardeenTableAdapter1.Fill(this.dataSet11.mwardeen);
            for (int n = 0; n < dataSet11.mwardeen.Rows.Count; ++n)
            {
                try
                {
                    if (dataSet11.mwardeen.Rows[n]["mwared_name"].ToString() == cst_nameTXT.Text)
                    {
                        MessageBox.Show("إسم المورد موجود بالفعل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        cst_nameTXT.Focus();
                        return;
                    }
                }
                catch { }
            }


            mwardeenTableAdapter1.Insert(cst_nameTXT.Text, cst_phoneTXT.Text, cst_addressTXT.Text, notesTXT.Text);
            MessageBox.Show("تمت الاضافة بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cst_addressTXT.Clear(); cst_nameTXT.Clear(); cst_phoneTXT.Clear(); notesTXT.Clear();
            cst_nameTXT.Focus();
        
        }
    }
}
