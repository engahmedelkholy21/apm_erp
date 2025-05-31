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
    public partial class awzan_form : Form
    {
        public awzan_form()
        {
            InitializeComponent();
            Form1 f1 = new Form1();
            f1.SubscribeToLoadEvent(this);
            f1.ApplyFormStyling(this);
        }

        public string Result_count;
        private void button7_Click(object sender, EventArgs e)
        {
            Result_count = (Convert.ToDecimal(button7.Text)/1000).ToString();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Result_count = (Convert.ToDecimal(button5.Text) / 1000).ToString();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Result_count = (Convert.ToDecimal(button3.Text) / 1000).ToString();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Result_count = (Convert.ToDecimal(button1.Text) / 1000).ToString();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Result_count = (Convert.ToDecimal(button6.Text) / 1000).ToString();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Result_count = (Convert.ToDecimal(button4.Text) / 1000).ToString();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Result_count = (Convert.ToDecimal(button2.Text) / 1000).ToString();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Result_count = (Convert.ToDecimal(button8.Text) / 1000).ToString();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Result_count = (Convert.ToDecimal(button10.Text) / 1000).ToString();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Result_count = (Convert.ToDecimal(button9.Text) / 1000).ToString();
            this.Close();
        }

        private void awzan_form_Load(object sender, EventArgs e)
        {

        }
    }
}
