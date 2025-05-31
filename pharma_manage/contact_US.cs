using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Configuration;

namespace pharma_manage
{
    public partial class contact_US : Form
    {
        public contact_US()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MailAddress from = new MailAddress(unTXT.Text + outlookTXT.Text, "from");
                MailAddress to = new MailAddress("elkholy488@gmail.com", "to");

                //mm.Subject = subject;
                //mm.Body = body;
                //  mm.IsBodyHtml = false;

                //SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                //smtp.UseDefaultCredentials = false;

                ////  smtp.Host = ConfigurationManager.AppSettings["smtp.gmail.com"];
                //smtp.EnableSsl = true;
                //NetworkCredential NetworkCred = new NetworkCredential("nonalesb0@gmail.com", "ahmed2010");
                ////  ConfigurationManager.AppSettings["Username"], ConfigurationManager.AppSettings["Password"]);
                //smtp.Credentials = NetworkCred;
                //// smtp.Port = int.Parse(ConfigurationManager.AppSettings["587"]);


                SmtpClient client = new SmtpClient();
                client.Host = "outlook.com";
                client.Port = 587;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;

                client.Credentials = new NetworkCredential(unTXT.Text + outlookTXT.Text, pwtxt.Text);
                client.EnableSsl = true;
                MessageBox.Show("...جاري الارسال  يرجى الانتظار");

                string msg = msgTXT.Text + "\n" + usertxt.Text;
                client.Send(from.ToString(), to.ToString(), "رسالة خاصه ببرنامج G Board", msg);
                MessageBox.Show("تم الارسال بنجاح سنتواصل معكم قريبا", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("تأكد من الايميل وكلمة السر و المحاولة لاحقا", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/X-programming-724559681018406");
     
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/a7medelkholy1");
  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void msgTXT_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = button2;
        }
    }
}
