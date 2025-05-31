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
    public partial class add_resp : Form
    {
        public add_resp()
        {
            InitializeComponent();
        }

        private void save_brn_Click(object sender, EventArgs e)
        {
            resp_tableTableAdapter1.FillBy_NAME_OR_PHONE(dataSet11.resp_table, cst_nameTXT.Text, cst_phoneTXT.Text);
            if (dataSet11.resp_table.Rows.Count > 0)
            {
                MessageBox.Show("اسم المسئول او رقم التليفون موجود مسبقا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else 
            {
                resp_tableTableAdapter1.Insert(cst_nameTXT.Text, cst_phoneTXT.Text, cst_addressTXT.Text,Convert.ToDecimal(bounus_txt.Text), notesTXT.Text,Convert.ToDecimal(matloob_txt.Text),Convert.ToDecimal(madfoo3_txt.Text));


                decimal matloob_before = 0;
                decimal madfoo3_before = 0;
                decimal ba2y_before = 0;

                decimal matloob_all = Convert.ToDecimal(matloob_txt.Text);
                decimal madfoo3_all = Convert.ToDecimal(madfoo3_txt.Text);
                decimal ba2y_all = matloob_all - madfoo3_all;

                mosta7akat_mas2oleen_tableTableAdapter1.Insert(cst_nameTXT.Text, DateTime.Today, matloob_all, madfoo3_all, 0, Convert.ToDecimal(madfoo3_txt.Text), usertxt.Text
                     , ba2y_before, ba2y_all, notesTXT.Text, "دائن", 0);
                
                MessageBox.Show("تمت الاضافة بنجاح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cst_nameTXT.Clear(); cst_phoneTXT.Clear(); bounus_txt.Clear(); notesTXT.Clear(); matloob_txt.Clear(); madfoo3_txt.Clear();
                cst_nameTXT.Focus();
            }
        }

        private void add_resp_Load(object sender, EventArgs e)
        {

        }
    }
}
