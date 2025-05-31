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
    public partial class add_customer : Form
    {
        public add_customer()
        {
            InitializeComponent();
            Form1 f1 = new Form1();
            f1.SubscribeToLoadEvent(this);
            f1.ApplyFormStyling(this);
        }

        private void save_brn_Click(object sender, EventArgs e)
        {
            this.customersTableAdapter1.Fill(this.dataSet11.customers);
            for (int n = 0; n < dataSet11.customers.Rows.Count; ++n)
            {
                if (dataSet11.customers.Rows[n]["cst_name"].ToString() == cst_nameTXT.Text)
                {
                    MessageBox.Show("إسم العميل موجود بالفعل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    cst_nameTXT.Focus();
                    return;
                }
            }

            if (url_txt.Text != "")
            {
                //  MessageBox.Show("aaaa");
                try
                {
                    Form1 f = new Form1();
                    f.upload_file_local("صورة بطاقة "+cst_nameTXT.Text, Path.GetExtension(url_txt.Text), DateTime.Today, url_txt.Text, usertxt.Text, this.Text, "", far3txt.Text, "صورة بطاقة");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            uploaded_files_tableTableAdapter1.FillBy_last_added_one(dataSet11.uploaded_files_table);

            if (dataSet11.uploaded_files_table.Rows.Count > 0)
            {
                url_txt.Text = dataSet11.uploaded_files_table.Rows[0]["uploaded_file_path"].ToString();
            }

            customersTableAdapter1.Insert(cst_nameTXT.Text, cst_phoneTXT.Text, cst_addressTXT.Text, notesTXT.Text,price_txt.Text,national_id_txt.Text,takseet_status.Text,url_txt.Text);
            MessageBox.Show("تمت الاضافة بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cst_addressTXT.Clear(); cst_nameTXT.Clear(); cst_phoneTXT.Clear(); notesTXT.Clear();
            cst_nameTXT.Focus();
      
        }

        private void add_customer_Load(object sender, EventArgs e)
        {
            price_txt.KeyPress += DigitOnly_KeyPress;
            national_id_txt.KeyPress += DigitOnly_KeyPress;

        }
        private void DigitOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, control characters, and a single decimal point
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Ignore the key press
            }

            // Allow only one decimal point
            TextBox textBox = (TextBox)sender;
            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true; // Ignore additional decimal points
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "All Supported Files (*.pdf;*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.pdf;*.png;*.jpg;*.jpeg;*.gif;*.bmp|PDF Files (*.pdf)|*.pdf|Image Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    // Check if it's a PDF file
                    //if (Path.GetExtension(filePath).Equals(".pdf", StringComparison.OrdinalIgnoreCase))
                    //{
                    //webBrowser1.Url = new Uri(openFileDialog.FileName);
                    //webBrowser1.ScrollBarsEnabled = true;
                    //webBrowser1.ScriptErrorsSuppressed = true;
                    //webBrowser1.DocumentCompleted += WebBrowser1_DocumentCompleted;

                    url_txt.Text = openFileDialog.FileName;

                    pictureBox1.Image = Image.FromFile(url_txt.Text);
                    // }
                }
                else
                {
                    url_txt.Text = "";
                }
            }
        }
    }
}
