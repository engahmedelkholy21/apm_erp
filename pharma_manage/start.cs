using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Management;
using System.IO;


namespace pharma_manage
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();

            

            var culture = System.Globalization.CultureInfo.GetCultureInfo("ar-EG");

            //var language = InputLanguage.FromCulture(culture);
            //InputLanguage.CurrentInputLanguage = language;

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void enter_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text != "admin")
                {
                    progressBar1.Value = 0;
                    progressBar1.Value += 20;
                    progressBar1.Update();
                    user_previligesTableAdapter1.Fill(this.dataSet11.user_previliges);
                    progressBar1.Value += 20;
                    progressBar1.Update();
                    foreach (DataRow dr in dataSet11.user_previliges.Rows)
                    {

                    }
                    user_previligesTableAdapter1.FillBy_name(dataSet11.user_previliges, comboBox1.Text);
                    progressBar1.Value += 20;
                    progressBar1.Update();
                    if (textBox1.Text == Convert.ToString(dataSet11.user_previliges.Rows[0]["password"]))// && textBox3.Text == "aassdd")
                    {

                        Form1 F1 = new Form1();
                        progressBar1.Value += 20;
                        progressBar1.Update();
                        this.Hide();
                        F1.usertxt.Text = comboBox1.Text;
                        //F1.permissiontxt.Text = dataSet11.users.Rows[0]["user_permission"].ToString();
                        F1.Show();


                    }
                    else MessageBox.Show("تأكد من الاسم وكلمة السر");
                }
                else
                {
                    if (textBox1.Text == "xmanage")
                    {
                        Form1 F1 = new Form1();
                        this.Hide();
                        F1.usertxt.Text = comboBox1.Text;
                        //F1.permissiontxt.Text = dataSet11.users.Rows[0]["user_permission"].ToString();
                        F1.Show();
                    }
                }
            }
            catch { }
        }


        string sdf;
        private void check_pc()
        {
            try
            {
                ManagementObjectSearcher MOS = new ManagementObjectSearcher("Select * From Win32_BaseBoard");
                foreach (ManagementObject getserial in MOS.Get())
                {
                    sdf = getserial["SerialNumber"].ToString();
                }


                StreamReader sr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\b.txt");
                string txt = sr.ReadLine();
                string board = sdf + "5PRaS";
                //Read the first line of text
                //MessageBox.Show("txt  "+txt);
                //MessageBox.Show("board  "+board);

                if (board != txt)
                {
                    timer1.Stop();
                    MessageBox.Show("You are not licensed to use this application . please contact us 01015065484", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Diagnostics.Process.Start("https://www.facebook.com/X-programming-724559681018406");

                    Application.Exit();
                }

                //if (sdf != "CBG1603733                      ")
                //{
                //    timer1.Stop();
                //    MessageBox.Show("You are not licensed to use this application . please contact us 01015065484", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    System.Diagnostics.Process.Start("https://www.facebook.com/X-programming-724559681018406");

                //    Application.Exit();
                //}
                string cpuInfo = "";
                ManagementClass managClass = new ManagementClass("win32_processor");
                ManagementObjectCollection managCollec = managClass.GetInstances();

                foreach (ManagementObject managObj in managCollec)
                {
                    if (cpuInfo == "")
                    {
                        //Get only the first CPU's ID
                        cpuInfo = managObj.Properties["processorID"].Value.ToString();
                        break;
                    }
                }
                StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\c.txt");
                string txtt = srr.ReadLine();
                string cp = cpuInfo + "A783";

                if (txtt != cp)
                {
                    timer1.Stop();
                    MessageBox.Show("You are not licensed to use this application . please contact us 01015065484", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Diagnostics.Process.Start("https://www.facebook.com/X-programming-724559681018406");


                    Application.Exit();

                }
            }
            catch 
            {
                MessageBox.Show("something Wrong Contact Us");
                this.Close();
            }
            //if (cpuInfo != "BFEBFBFF0001067A")
            //{
            //    timer1.Stop();
            //    MessageBox.Show("You are not licensed to use this application . please contact us 01015065484", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    System.Diagnostics.Process.Start("https://www.facebook.com/X-programming-724559681018406");


            //    Application.Exit();
            //}
        }
        private void start_Load(object sender, EventArgs e)
        {
           check_pc();
            this.user_previligesTableAdapter1.Fill(this.dataSet11.user_previliges);
            foreach (DataRow dr in dataSet11.user_previliges.Rows)
            {
                if (comboBox1.Items.Contains(dr["user_name"].ToString()))
                {
                }
                else
                {
                    comboBox1.Items.Add(dr["user_name"].ToString());
                    try
                    {
                        if (progressBar1.Value < 100 && progressBar1.Value + (progressBar1.Maximum / dataSet11.user_previliges.Rows.Count) <= 100)
                        {

                            progressBar1.Value += progressBar1.Maximum / dataSet11.user_previliges.Rows.Count;

                            //  MessageBox.Show(progressBar1.Value.ToString());
                            progressBar1.Update();
                            Thread.Sleep(10);
                        }

                    }
                    catch
                    {

                    }
                }
            }
            progressBar1.Value = 100;
            // MessageBox.Show(progressBar1.Value.ToString());
            progressBar1.Update();
            try
            {
                comboBox1.Text = comboBox1.Items[0].ToString();
            }
            catch { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icon.ico";
                this.Icon = new Icon(path);
            }
            catch { }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
