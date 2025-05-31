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
    public partial class pharmacy_data : Form
    {
        public pharmacy_data()
        {
            InitializeComponent();
        }

        private void pharmacy_data_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.pharmacy_data' table. You can move, or remove it, as needed.
            button2.BackColor = this.BackColor;
            this.pharmacy_dataTableAdapter.Fill(this.dataSet1.pharmacy_data);
            name_txt.Text = dataSet1.pharmacy_data.Rows[0]["pharmacy_name"].ToString();
            address_txt.Text = dataSet1.pharmacy_data.Rows[0]["pharmacy_address"].ToString();
            phone_txt.Text = dataSet1.pharmacy_data.Rows[0]["pharmacy_phone"].ToString();
            phone2_txt.Text = dataSet1.pharmacy_data.Rows[0]["phone_2"].ToString();
            rakam_dariby_txt.Text = dataSet1.pharmacy_data.Rows[0]["pharmacy_rakam_dariby"].ToString();
            notes_txt.Text = dataSet1.pharmacy_data.Rows[0]["pharmacy_note1"].ToString();
            notes_2.Text = dataSet1.pharmacy_data.Rows[0]["pharmacy_note2"].ToString();
            mail_txt.Text = dataSet1.pharmacy_data.Rows[0]["pharmacy_mail"].ToString();
            sender_email_txt.Text = dataSet1.pharmacy_data.Rows[0]["pharmacy_sender_mail"].ToString();
            sender_password_txt.Text = dataSet1.pharmacy_data.Rows[0]["pharmacy_sender_password"].ToString();
            try
            {
                Byte[] data = new Byte[0];
                data = (Byte[])(dataSet1.pharmacy_data.Rows[0]["qr_pic"]);
                MemoryStream mem = new MemoryStream(data);
                pictureBox1.Image = Image.FromStream(mem);
            }
            catch
            {
                pictureBox1.Image = Properties.Resources.blank_white;
            }
            //MessageBox.Show(dataSet1.pharmacy_data.Rows[0]["qr_pic"].ToString().ToArray());
        }

        private void save_brn_Click(object sender, EventArgs e)
        {
            System.IO.MemoryStream defaultImageStream = new System.IO.MemoryStream();
            Bitmap img = new Bitmap(pictureBox1.Image);
            Image b = (Image)img;
            b.Save(defaultImageStream, System.Drawing.Imaging.ImageFormat.Bmp);
            byte[] defaultImageData = new byte[defaultImageStream.Length];
            //assign byte array the content of image
            defaultImageData = defaultImageStream.ToArray();

            pharmacy_dataTableAdapter.Insert(name_txt.Text, address_txt.Text, phone_txt.Text, rakam_dariby_txt.Text, notes_txt.Text, notes_2.Text, defaultImageData,phone2_txt.Text,mail_txt.Text,sender_email_txt.Text,sender_password_txt.Text);
            MessageBox.Show("تم", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.pharmacy_dataTableAdapter.Fill(this.dataSet1.pharmacy_data);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.MemoryStream defaultImageStream = new System.IO.MemoryStream();
            Bitmap img = new Bitmap(pictureBox1.Image);
            Image b = (Image)img;
            b.Save(defaultImageStream, System.Drawing.Imaging.ImageFormat.Bmp);
            byte[] defaultImageData = new byte[defaultImageStream.Length];
            //assign byte array the content of image
            defaultImageData = defaultImageStream.ToArray();
            pharmacy_dataTableAdapter.Update_by_id(name_txt.Text, address_txt.Text, phone_txt.Text, rakam_dariby_txt.Text, notes_txt.Text, notes_2.Text, phone2_txt.Text, defaultImageData, mail_txt.Text, sender_email_txt.Text, sender_password_txt.Text, 1);
            MessageBox.Show("تم التعديل", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.pharmacy_dataTableAdapter.Fill(this.dataSet1.pharmacy_data);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Files|*.jpg;*.jpeg;*.png";// " |*.jpg &&images files |*.png";
            // openFileDialog1.ShowDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = null;
                string ppath = openFileDialog1.FileName;
                pictureBox1.ImageLocation = ppath;
            }
        }
    }
}

