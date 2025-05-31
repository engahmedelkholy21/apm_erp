using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge;


namespace pharma_manage
{
    public partial class Capture_picture : Form
    {
        public Capture_picture()
        {
            InitializeComponent();
        }

        private FilterInfoCollection CaptureDevice; // list of webcam
        private VideoCaptureDevice FinalFrame;

 
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = null;
                FinalFrame.Stop();
                FinalFrame = new VideoCaptureDevice(CaptureDevice[comboBox1.SelectedIndex].MonikerString);// specified web cam and its filter moniker string
                FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);// click button event is fired, 
                FinalFrame.Start();
            }
            catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);//constructor
            foreach (FilterInfo Device in CaptureDevice)
            {
                comboBox1.Items.Add(Device.Name);
            }

            comboBox1.SelectedIndex = 0; // default
            FinalFrame = new VideoCaptureDevice();

            button1_Click(sender, e);
        }

        void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs) // must be void so that it can be accessed everywhere.
        // New Frame Event Args is an constructor of a class
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();// clone the bitmap
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }


        public string Result;
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning == true) FinalFrame.Stop();
    
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void btnCaptureImage_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = (Bitmap)pictureBox1.Image.Clone();

            string ppath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\pic\\temp\\" + name_txt.Text + ".jpg";

            pictureBox2.Image.Save(ppath);

            File.Copy(ppath, System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\pic\\" + name_txt.Text + ".jpg", true);


            File.Delete(ppath);

            //  this.ParentForm
           
            //add_player a = new add_player();
          //  this.Owner = a;
            // add_player parent = (add_player)this.Owner;
            //  a.NotifyMe(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\pic\\" + name_txt.Text + ".jpg");
            // add_player a = new add_player();
            // a.pictureBox1.ImageLocation = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\pic\\" + name_txt.Text + ".jpg";
            Result = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\pic\\" + name_txt.Text + ".jpg";

            this.Close();
        }




    }
}
