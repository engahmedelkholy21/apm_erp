using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using System.Management;
using System.Security.AccessControl;
using System.Security.Principal;

namespace pharma_manage
{
    public partial class settings_form : Form
    {
        public settings_form()
        {
            InitializeComponent();
        }

        public void colors_form_Load(object sender, EventArgs e)
        {
            
        }

        private void back_color_picture_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
           // cd.ShowDialog();
            if (cd.ShowDialog() == DialogResult.OK) 
            {
                 string fileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\" + "\\back_color";
                 File.WriteAllText(fileName, String.Empty); 
                FileStream stream = null;  
               
                back_color_picture.BackColor = cd.Color;
              
                //string back_color_name_new = 
               // sr.WriteLine(cd.Color.Name);

                 stream = new FileStream(fileName, FileMode.OpenOrCreate);  
         // Create a StreamWriter from FileStream  
                 using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                 {

                    writer.Write(cd.Color.R.ToString() + ", " + cd.Color.G.ToString() + ", " + cd.Color.B.ToString());
                 }

               //  MessageBox.Show("#"+cd.Color.Name);
            }
        }

        private static bool IsPrinterActive(string printerName)
        {
            // Escape backslashes in the printer name for the WMI query
            string query = string.Format("SELECT * FROM Win32_Printer WHERE Name = '{0}'", printerName.Replace("\\", "\\\\"));
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(query))
            using (ManagementObjectCollection printers = searcher.Get())
            {
                foreach (ManagementObject printer in printers)
                {
                    // Printer statuses: 3 = Idle, 4 = Printing, 5 = Warming Up
                    // Work Offline status: 1 = Offline, 0 = Online
                    int printerStatus = Convert.ToInt32(printer["PrinterStatus"]);
                    bool workOffline = Convert.ToBoolean(printer["WorkOffline"]);

                    // Check if the printer is online and not offline
                    if (!workOffline && (printerStatus == 3 || printerStatus == 4 || printerStatus == 5))
                    {
                        return true;
                    }
                }
            }

            return false;
        }


        private void label_color_picture_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            // cd.ShowDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                string fileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\" + "\\label_color";
                File.WriteAllText(fileName, String.Empty);
                FileStream stream = null;

                label_color_picture.BackColor = cd.Color;

                //string back_color_name_new = 
                // sr.WriteLine(cd.Color.Name);

                stream = new FileStream(fileName, FileMode.OpenOrCreate);
                // Create a StreamWriter from FileStream  
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(cd.Color.R.ToString() + ", " + cd.Color.G.ToString() + ", " + cd.Color.B.ToString());
                }
               // MessageBox.Show()

               
            }
        }

        private void dgv_back_color_picture_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            // cd.ShowDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                string fileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\" + "\\dgv_forecolor";
                File.WriteAllText(fileName, String.Empty);
                FileStream stream = null;

                dgv_forecolor_picture.BackColor = cd.Color;

                //string back_color_name_new = 
                // sr.WriteLine(cd.Color.Name);

                stream = new FileStream(fileName, FileMode.OpenOrCreate);
                // Create a StreamWriter from FileStream  
                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                {

                    writer.Write(cd.Color.R.ToString() + ", " + cd.Color.G.ToString() + ", " + cd.Color.B.ToString());
                }

                //  MessageBox.Show("#"+cd.Color.Name);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          //  StreamReader sr_r = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\price.txt");

            string fileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\price.txt";
            File.WriteAllText(fileName, String.Empty);
            FileStream stream = null;


            //string back_color_name_new = 
            // sr.WriteLine(cd.Color.Name);

            stream = new FileStream(fileName, FileMode.OpenOrCreate);
            // Create a StreamWriter from FileStream  
            using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
            {
                if (checkBox1.Checked == true)
                {
                    writer.Write("yes");

                }
                else
                {
                    writer.Write("no");
                }
            }
        }

        private void fatora_type_txt_SelectedIndexChanged(object sender, EventArgs e)
        {

            string fileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\main_printer.txt";
            File.WriteAllText(fileName, String.Empty);
            FileStream stream = null;


            //string back_color_name_new = 
            // sr.WriteLine(cd.Color.Name);

            stream = new FileStream(fileName, FileMode.OpenOrCreate);
            // Create a StreamWriter from FileStream  
            using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
            {
                
                    writer.Write(fatora_type_txt.Text);

            }
        }

        private void fwateer_printer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_fwateer.txt";
            File.WriteAllText(fileName, String.Empty);
            FileStream stream = null;


            //string back_color_name_new = 
            // sr.WriteLine(cd.Color.Name);

            stream = new FileStream(fileName, FileMode.OpenOrCreate);
            // Create a StreamWriter from FileStream  
            using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
            {

                writer.Write(fwateer_printer.Text);

            }

            //PrinterSettings printerSettings = new PrinterSettings();
            //printerSettings.PrinterName = fwateer_printer.Text;
            //PaperSize customPaperSize = new PaperSize("Custom", 1, 5);
            //printerSettings.DefaultPageSettings.PaperSize = customPaperSize;

            

            //  283  pos
            //300 apm
        }

        private void barcode_printer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode.txt";
            File.WriteAllText(fileName, String.Empty);
            FileStream stream = null;


            //string back_color_name_new = 
            // sr.WriteLine(cd.Color.Name);

            stream = new FileStream(fileName, FileMode.OpenOrCreate);
            // Create a StreamWriter from FileStream  
            using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
            {

                writer.Write(barcode_printer.Text);

            }
        }

        private void A4_printer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_a4.txt";
            File.WriteAllText(fileName, String.Empty);
            FileStream stream = null;


            //string back_color_name_new = 
            // sr.WriteLine(cd.Color.Name);

            stream = new FileStream(fileName, FileMode.OpenOrCreate);
            // Create a StreamWriter from FileStream  
            using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
            {

                writer.Write(A4_printer.Text);

            }
        }

        private void barcode_type_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt";
            File.WriteAllText(fileName, String.Empty);
            FileStream stream = null;


            //string back_color_name_new = 
            // sr.WriteLine(cd.Color.Name);

            stream = new FileStream(fileName, FileMode.OpenOrCreate);
            // Create a StreamWriter from FileStream  
            using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
            {
                
                    writer.Write(barcode_type_txt.Text);

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //  StreamReader sr_r = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\price.txt");

            string fileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_bc.txt";
            File.WriteAllText(fileName, String.Empty);
            FileStream stream = null;


            //string back_color_name_new = 
            // sr.WriteLine(cd.Color.Name);

            stream = new FileStream(fileName, FileMode.OpenOrCreate);
            // Create a StreamWriter from FileStream  
            using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
            {
                if (checkBox2.Checked == true)
                {
                    writer.Write("yes");

                }
                else
                {
                    writer.Write("no");
                }
            }
        }

        private void mortaga3_combo_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\mortaga3_type.txt";
            File.WriteAllText(fileName, String.Empty);
            FileStream stream = null;


            //string back_color_name_new = 
            // sr.WriteLine(cd.Color.Name);

            stream = new FileStream(fileName, FileMode.OpenOrCreate);
            // Create a StreamWriter from FileStream  
            using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
            {

                writer.Write(mortaga3_combo_txt.Text);

            }
        }

        private void logo_name_txt_SelectedIndexChanged(object sender, EventArgs e)
        {

            string fileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\logo_name.txt";
            File.WriteAllText(fileName, String.Empty);
            FileStream stream = null;


            //string back_color_name_new = 
            // sr.WriteLine(cd.Color.Name);

            stream = new FileStream(fileName, FileMode.OpenOrCreate);
            // Create a StreamWriter from FileStream  
            using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
            {

                writer.Write(logo_name_txt.Text);

            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            string fileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\ezn.txt";
            File.WriteAllText(fileName, String.Empty);
            FileStream stream = null;


            //string back_color_name_new = 
            // sr.WriteLine(cd.Color.Name);

            stream = new FileStream(fileName, FileMode.OpenOrCreate);
            // Create a StreamWriter from FileStream  
            using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
            {
                if (checkBox3.Checked == true)
                {
                    writer.Write("yes");

                }
                else
                {
                    writer.Write("no");
                }
            }
        }

        private void ezn_combobox_txt_SelectedIndexChanged(object sender, EventArgs e)
        {

            string fileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\ezn_type.txt";
            File.WriteAllText(fileName, String.Empty);
            FileStream stream = null;


            //string back_color_name_new = 
            // sr.WriteLine(cd.Color.Name);

            stream = new FileStream(fileName, FileMode.OpenOrCreate);
            // Create a StreamWriter from FileStream  
            using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
            {

                writer.Write(ezn_combobox_txt.Text);

            }
        }

        private void dariba_checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            string fileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\tax.txt";
            File.WriteAllText(fileName, String.Empty);
            FileStream stream = null;


            //string back_color_name_new = 
            // sr.WriteLine(cd.Color.Name);

            stream = new FileStream(fileName, FileMode.OpenOrCreate);
            // Create a StreamWriter from FileStream  
            using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
            {
                if (dariba_checkBox4.Checked == true)
                {
                    writer.Write("yes");

                }
                else
                {
                    writer.Write("no");
                }
            }
        }

        private void after_buy_checkBox4_CheckedChanged(object sender, EventArgs e)
        {

            string fileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\after_buy.txt";
            File.WriteAllText(fileName, String.Empty);
            FileStream stream = null;


            //string back_color_name_new = 
            // sr.WriteLine(cd.Color.Name);

            stream = new FileStream(fileName, FileMode.OpenOrCreate);
            // Create a StreamWriter from FileStream  
            using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
            {
                if (after_buy_checkBox4.Checked == true)
                {
                    writer.Write("yes");

                }
                else
                {
                    writer.Write("no");
                }
            }
        }

        private void lower_price_checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            string fileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\l";
            File.WriteAllText(fileName, String.Empty);
            FileStream stream = null;


            //string back_color_name_new = 
            // sr.WriteLine(cd.Color.Name);

            stream = new FileStream(fileName, FileMode.OpenOrCreate);
            // Create a StreamWriter from FileStream  
            using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
            {
                if (lower_price_checkBox4.Checked == true)
                {
                    writer.Write("yes");

                }
                else
                {
                    writer.Write("no");
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                bee3_type_txt.Text = "عادي";
            }
            else 
            {
                bee3_type_txt.Text = "نسبة";
            }
            string fileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\bee3_type_txt";
            File.WriteAllText(fileName, String.Empty);
            FileStream stream = null;


            //string back_color_name_new = 
            // sr.WriteLine(cd.Color.Name);

            stream = new FileStream(fileName, FileMode.OpenOrCreate);
            // Create a StreamWriter from FileStream  
            using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
            {

                writer.Write(bee3_type_txt.Text);

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                bee3_type_txt.Text = "نسبة";
            }
            else
            {
                bee3_type_txt.Text = "عادي";
            }

            string fileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\bee3_type_txt";
            File.WriteAllText(fileName, String.Empty);
            FileStream stream = null;


            //string back_color_name_new = 
            // sr.WriteLine(cd.Color.Name);

            stream = new FileStream(fileName, FileMode.OpenOrCreate);
            // Create a StreamWriter from FileStream  
            using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
            {

                writer.Write(bee3_type_txt.Text);

            }
        }

        private void cst_qr_txt_CheckedChanged(object sender, EventArgs e)
        {
            string fileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\cst_qr_txt";
            File.WriteAllText(fileName, String.Empty);
            FileStream stream = null;


            //string back_color_name_new = 
            // sr.WriteLine(cd.Color.Name);

            stream = new FileStream(fileName, FileMode.OpenOrCreate);
            // Create a StreamWriter from FileStream  
            using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
            {
                if (cst_qr_txt.Checked == true)
                {
                    writer.Write("yes");

                }
                else
                {
                    writer.Write("no");
                }
            }
        }

        private void ksoor_txt_CheckedChanged(object sender, EventArgs e)
        {
            //  StreamReader sr_r = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\price.txt");

            string fileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\decimals";
            File.WriteAllText(fileName, String.Empty);
            FileStream stream = null;


            //string back_color_name_new = 
            // sr.WriteLine(cd.Color.Name);

            stream = new FileStream(fileName, FileMode.OpenOrCreate);
            // Create a StreamWriter from FileStream  
            using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
            {
                if (ksoor_txt.Checked == true)
                {
                    writer.Write("yes");

                }
                else
                {
                    writer.Write("no");
                }
            }
        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                avg_txt.Text = "اخر سعر";
            }
            else
            {
                avg_txt.Text = "متوسط";
            }

            string fileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\avg_or_new.txt";
            File.WriteAllText(fileName, String.Empty);
            FileStream stream = null;


            //string back_color_name_new = 
            // sr.WriteLine(cd.Color.Name);

            stream = new FileStream(fileName, FileMode.OpenOrCreate);
            // Create a StreamWriter from FileStream  
            using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
            {

                writer.Write(avg_txt.Text);

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                avg_txt.Text = "متوسط";
            }
            else
            {
                avg_txt.Text = "اخر سعر";
            }

            string fileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\avg_or_new.txt";
            File.WriteAllText(fileName, String.Empty);
            FileStream stream = null;


            //string back_color_name_new = 
            // sr.WriteLine(cd.Color.Name);

            stream = new FileStream(fileName, FileMode.OpenOrCreate);
            // Create a StreamWriter from FileStream  
            using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
            {

                writer.Write(avg_txt.Text);

            }
        }

        private void bee3_type_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                buy_type_txt.Text = "عادي";
            }
            else
            {
                buy_type_txt.Text = "نسبة";
            }
            string fileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\buy_type_txt";
            File.WriteAllText(fileName, String.Empty);
            FileStream stream = null;


            //string back_color_name_new = 
            // sr.WriteLine(cd.Color.Name);

            stream = new FileStream(fileName, FileMode.OpenOrCreate);
            // Create a StreamWriter from FileStream  
            using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
            {

                writer.Write(buy_type_txt.Text);

            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                buy_type_txt.Text = "نسبة";
            }
            else
            {
                buy_type_txt.Text = "عادي";
            }
            string fileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\buy_type_txt";
            File.WriteAllText(fileName, String.Empty);
            FileStream stream = null;


            //string back_color_name_new = 
            // sr.WriteLine(cd.Color.Name);

            stream = new FileStream(fileName, FileMode.OpenOrCreate);
            // Create a StreamWriter from FileStream  
            using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
            {

                writer.Write(buy_type_txt.Text);

            }
        }

        private void edit_bee3_price_checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            string fileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\ape";
            File.WriteAllText(fileName, String.Empty);
            FileStream stream = null;


            //string back_color_name_new = 
            // sr.WriteLine(cd.Color.Name);

            stream = new FileStream(fileName, FileMode.OpenOrCreate);
            // Create a StreamWriter from FileStream  
            using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
            {
                if (edit_bee3_price_checkBox4.Checked == true)
                {
                    writer.Write("yes");

                }
                else
                {
                    writer.Write("no");
                }
            }
        }

        private void short_cuts_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\shorts.txt";
            File.WriteAllText(fileName, String.Empty);
            FileStream stream = null;


            //string back_color_name_new = 
            // sr.WriteLine(cd.Color.Name);

            stream = new FileStream(fileName, FileMode.OpenOrCreate);
            // Create a StreamWriter from FileStream  
            using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
            {

                writer.Write(short_cuts_comboBox1.Text);

            }

            
        }

        private void page_size_txt_SelectedIndexChanged(object sender, EventArgs e)
        {

            string fileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\page_size.txt";
            File.WriteAllText(fileName, String.Empty);
            FileStream stream = null;


            //string back_color_name_new = 
            // sr.WriteLine(cd.Color.Name);

            stream = new FileStream(fileName, FileMode.OpenOrCreate);
            // Create a StreamWriter from FileStream  
            using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
            {

                writer.Write(page_size_txt.Text);

            }
        }

        private void gomla_checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            string fileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\gomla.txt";
            File.WriteAllText(fileName, String.Empty);
            FileStream stream = null;


            //string back_color_name_new = 
            // sr.WriteLine(cd.Color.Name);

            stream = new FileStream(fileName, FileMode.OpenOrCreate);
            // Create a StreamWriter from FileStream  
            using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
            {
                if (gomla_checkBox4.Checked == true)
                {
                    writer.Write("yes");

                }
                else
                {
                    writer.Write("no");
                }
            }
        }

        private void takseet_active_checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            string fileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\tk_active";
            File.WriteAllText(fileName, String.Empty);
            FileStream stream = null;


            //string back_color_name_new = 
            // sr.WriteLine(cd.Color.Name);

            stream = new FileStream(fileName, FileMode.OpenOrCreate);
            // Create a StreamWriter from FileStream  
            using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
            {
                if (takseet_active_checkBox4.Checked == true)
                {
                    writer.Write("yes");

                }
                else
                {
                    writer.Write("no");
                }
            }
        }

        private void bee3_default_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\bee3_default";
            File.WriteAllText(fileName, String.Empty);
            FileStream stream = null;


            //string back_color_name_new = 
            // sr.WriteLine(cd.Color.Name);

            stream = new FileStream(fileName, FileMode.OpenOrCreate);
            // Create a StreamWriter from FileStream  
            using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
            {

                writer.Write(bee3_default_combobox.Text);

            }
        }

        private void settings_form_Shown(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;  // Set the cursor to indicate loading
            this.Enabled = false;              // Disable form to prevent interaction

            //try 
            //{

            //  string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\" + t.Text + ".png";

            StreamReader sr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\" + "\\back_color");
            string back_color_name = sr.ReadLine();
            var splitString = back_color_name.Split(',');
            var splitInts = splitString.Select(item => int.Parse(item)).ToArray();


            //takes each element of the array of 3 and passes it in to the correct slot
            Color bc_color = System.Drawing.Color.FromArgb(splitInts[0], splitInts[1], splitInts[2]);
            back_color_picture.BackColor = bc_color;


            StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\" + "\\label_color");
            string label_color_name = srr.ReadLine();

            var splitString1 = label_color_name.Split(',');
            var splitInts1 = splitString1.Select(item => int.Parse(item)).ToArray();

            //takes each element of the array of 3 and passes it in to the correct slot
            Color label_clr = System.Drawing.Color.FromArgb(splitInts1[0], splitInts1[1], splitInts1[2]);
            label_color_picture.BackColor = label_clr;




            StreamReader srrr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\" + "\\dgv_forecolor");
            string dgv_forecolor_name = srrr.ReadLine();
            var splitString2 = dgv_forecolor_name.Split(',');
            var splitInts2 = splitString2.Select(item => int.Parse(item)).ToArray();

            //takes each element of the array of 3 and passes it in to the correct slot
            Color dgv_fore_clr = System.Drawing.Color.FromArgb(splitInts2[0], splitInts2[1], splitInts2[2]);
            dgv_forecolor_picture.BackColor = dgv_fore_clr;



            //  dgv_back_color_picture.BackColor =Color.FromArgb(Convert.ToInt32(dgv_back_color_name));

            //}
            //catch { }

            page_size_txt.Text = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\page_size.txt").First();


            backup_path_txt.Text = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\backup_path").First();

            //    string line1 = 
            //   StreamReader sr_r = new StreamReader();
            string barcode_yes_or_no = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\price.txt").First();
            if (barcode_yes_or_no == "yes")
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }

            string gomla = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\gomla.txt").First();
            if (gomla == "yes")
            {
                gomla_checkBox4.Checked = true;
            }
            else
            {
                gomla_checkBox4.Checked = false;
            }

            string tk_active = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\tk_active").First();
          
            if (tk_active == "yes")
            {
                takseet_active_checkBox4.Checked = true;
            }
            else
            {
                takseet_active_checkBox4.Checked = false;
            }

            string decimals = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\decimals").First();
            if (decimals == "yes")
            {
                ksoor_txt.Checked = true;
            }
            else
            {
                ksoor_txt.Checked = false;
            }


            string barcode_bc__yes_or_no = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_bc.txt").First();
            if (barcode_bc__yes_or_no == "yes")
            {
                checkBox2.Checked = true;
            }
            else
            {
                checkBox2.Checked = false;
            }



            string ezn = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\ezn.txt").First();
            if (ezn == "yes")
            {
                checkBox3.Checked = true;
            }
            else
            {
                checkBox3.Checked = false;
            }

            string cst_qr = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\cst_qr_txt").First();
            if (cst_qr == "yes")
            {
                cst_qr_txt.Checked = true;
            }
            else
            {
                cst_qr_txt.Checked = false;
            }


            string auto_print = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\auto_print").First();
            if (auto_print == "yes")
            {
                auto_print_txt.Checked = true;
            }
            else
            {
                auto_print_txt.Checked = false;
            }


            try
            {

                string tax = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\tax.txt").First();
                if (tax == "yes")
                {
                    dariba_checkBox4.Checked = true;
                }
                else
                {
                    dariba_checkBox4.Checked = false;
                }
            }
            catch { }

            try
            {
                string after_buy = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\after_buy.txt").First();
                if (after_buy == "yes")
                {
                    after_buy_checkBox4.Checked = true;
                }
                else
                {
                    after_buy_checkBox4.Checked = false;
                }
            }
            catch { }





            string lower_price = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\l").First();
            if (lower_price == "yes")
            {
                lower_price_checkBox4.Checked = true;
            }
            else
            {
                lower_price_checkBox4.Checked = false;
            }

            string ape = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\ape").First();
            if (ape == "yes")
            {
                edit_bee3_price_checkBox4.Checked = true;
            }
            else
            {
                edit_bee3_price_checkBox4.Checked = false;
            }

            string bee3_type_txt = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\bee3_type_txt").First();
            if (bee3_type_txt == "نسبة")
            {
                radioButton2.Checked = true;
            }
            else
            {
                radioButton1.Checked = true;
            }


            string buy_type_txt = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\buy_type_txt").First();
            if (buy_type_txt == "نسبة")
            {
                radioButton5.Checked = true;
            }
            else
            {
                radioButton6.Checked = true;
            }

            string avg_or_new = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\avg_or_new.txt").First();
            if (avg_or_new == "متوسط")
            {
                radioButton3.Checked = true;
            }
            else
            {
                radioButton4.Checked = true;
            }

            try
            {
                string printer_fwateer = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_fwateer.txt").First();
                fwateer_printer.Text = printer_fwateer;
            }
            catch { }

            try
            {
                string printer_a4 = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_a4.txt").First();
                A4_printer.Text = printer_a4;
            }
            catch { }

            try
            {
                string barcode = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode.txt").First();
                barcode_printer.Text = barcode;
            }
            catch { }

            try
            {

                string main_printer = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\main_printer.txt").First();
                fatora_type_txt.Text = main_printer;
            }
            catch { }


            try
            {

                string bee3_default = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\bee3_default").First();
                bee3_default_combobox.Text = bee3_default;
            }
            catch { }
            try
            {
                barcode_type_txt.Text = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt").First();
            }
            catch { }
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                // Check if the printer is active (online and ready)
                if (IsPrinterActive(printer))
                {
                    // Add the active printer to the comboboxes
                    fwateer_printer.Items.Add(printer);
                    A4_printer.Items.Add(printer);
                    barcode_printer.Items.Add(printer);
                }
            }


            string mortaga3_type = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\mortaga3_type.txt").First();
            mortaga3_combo_txt.Text = mortaga3_type;

            string ezn_type = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\ezn_type.txt").First();
            ezn_combobox_txt.Text = ezn_type;


            logo_name_txt.Text = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\logo_name.txt").First();

            short_cuts_comboBox1.Text = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\shorts.txt").First();



            string pieces_param = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\pieces_param").First();
            if (pieces_param == "yes")
            {
                pieces_checkBox.Checked = true;
            }
            else
            {
                pieces_checkBox.Checked = false;
            }


            string matloob_param = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\matloob_param").First();
            if (matloob_param == "yes")
            {
                matloob_checkBox.Checked = true;
            }
            else
            {
                matloob_checkBox.Checked = false;
            }


            string safy_param = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\safy_param").First();
            if (safy_param == "yes")
            {
                safy_checkBox.Checked = true;
            }
            else
            {
                safy_checkBox.Checked = false;
            }


            string mosadad_param = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\mosadad_param").First();
            if (mosadad_param == "yes")
            {
                mosadad_checkBox.Checked = true;
            }
            else
            {
                mosadad_checkBox.Checked = false;
            }



            string day_end = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\day_end").First();
           

            // Replace Arabic AM/PM with English equivalents
            day_end = day_end.Replace("ص", "AM").Replace("م", "PM");
            DateTime time=new DateTime();
            time=Convert.ToDateTime(day_end);
            day_end_txt.Value = time;

            this.Cursor = Cursors.Arrow;  // Set the cursor to indicate loading
            this.Enabled = true;              // Disable form to prevent interaction
            
        }

        private void pieces_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            string fileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\pieces_param";
            File.WriteAllText(fileName, String.Empty);
            FileStream stream = null;


            //string back_color_name_new = 
            // sr.WriteLine(cd.Color.Name);

            stream = new FileStream(fileName, FileMode.OpenOrCreate);
            // Create a StreamWriter from FileStream  
            using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
            {
                if (pieces_checkBox.Checked == true)
                {
                    writer.Write("yes");

                }
                else
                {
                    writer.Write("no");
                }
            }
        }

        private void matloob_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            string fileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\matloob_param";
            File.WriteAllText(fileName, String.Empty);
            FileStream stream = null;


            //string back_color_name_new = 
            // sr.WriteLine(cd.Color.Name);

            stream = new FileStream(fileName, FileMode.OpenOrCreate);
            // Create a StreamWriter from FileStream  
            using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
            {
                if (matloob_checkBox.Checked == true)
                {
                    writer.Write("yes");

                }
                else
                {
                    writer.Write("no");
                }
            }
        }

        private void safy_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            string fileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\safy_param";
            File.WriteAllText(fileName, String.Empty);
            FileStream stream = null;


            //string back_color_name_new = 
            // sr.WriteLine(cd.Color.Name);

            stream = new FileStream(fileName, FileMode.OpenOrCreate);
            // Create a StreamWriter from FileStream  
            using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
            {
                if (safy_checkBox.Checked == true)
                {
                    writer.Write("yes");

                }
                else
                {
                    writer.Write("no");
                }
            }
        }

        private void mosadad_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            string fileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\mosadad_param";
            File.WriteAllText(fileName, String.Empty);
            FileStream stream = null;


            //string back_color_name_new = 
            // sr.WriteLine(cd.Color.Name);

            stream = new FileStream(fileName, FileMode.OpenOrCreate);
            // Create a StreamWriter from FileStream  
            using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
            {
                if (mosadad_checkBox.Checked == true)
                {
                    writer.Write("yes");

                }
                else
                {
                    writer.Write("no");
                }
            }
        }

        private void day_end_txt_ValueChanged(object sender, EventArgs e)
        {
            string fileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\day_end";
            File.WriteAllText(fileName, String.Empty);
            FileStream stream = null;

            string end_ = day_end_txt.Value.TimeOfDay.ToString();
            //string back_color_name_new = 
            // sr.WriteLine(cd.Color.Name);

            stream = new FileStream(fileName, FileMode.OpenOrCreate);
            // Create a StreamWriter from FileStream  
            using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
            {

                writer.Write(end_);

            }
        }

        private void auto_print_txt_CheckedChanged(object sender, EventArgs e)
        {
            string fileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\auto_print";
            File.WriteAllText(fileName, String.Empty);
            FileStream stream = null;


            //string back_color_name_new = 
            // sr.WriteLine(cd.Color.Name);

            stream = new FileStream(fileName, FileMode.OpenOrCreate);
            // Create a StreamWriter from FileStream  
            using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
            {
                if (auto_print_txt.Checked == true)
                {
                    writer.Write("yes");

                }
                else
                {
                    writer.Write("no");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string credPath = Path.Combine(Application.StartupPath, "google_token");
                if (Directory.Exists(credPath))
                {
                    Directory.Delete(credPath, true);
                    MessageBox.Show("تم مسح بيانات تسجيل الدخول لجوجل. ستحتاج إلى تسجيل الدخول مرة أخرى.", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("لا توجد بيانات مسجلة لمسحها.", "ملاحظة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء مسح البيانات: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDlg = new FolderBrowserDialog())
            {
                folderDlg.Description = "Select a folder";
                folderDlg.ShowNewFolderButton = true;

               

                if (folderDlg.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderDlg.SelectedPath;

                    // Prevent selecting the root of C:\
                    if (string.Equals(selectedPath.TrimEnd('\\'), "C:", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("اختر درايف اخر غير ال C ",
                                        "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Try to apply full control permissions to current user
                    try
                    {
                        SetFolderFullAccess(selectedPath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to set folder permissions:\n" + ex.Message,
                                        "Permission Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    backup_path_txt.Text = folderDlg.SelectedPath;


                    string fileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\backup_path";
                    File.WriteAllText(fileName, String.Empty);
                    FileStream stream = null;


                    //string back_color_name_new = 
                    // sr.WriteLine(cd.Color.Name);

                    stream = new FileStream(fileName, FileMode.OpenOrCreate);
                    // Create a StreamWriter from FileStream  
                    using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                    {

                        writer.Write(backup_path_txt.Text);

                       
                    }

                }
            }
        }

        private void SetFolderFullAccess(string folderPath)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);
            DirectorySecurity security = directoryInfo.GetAccessControl();

            // Grant full control to the current user
            string currentUser = WindowsIdentity.GetCurrent().Name;

            FileSystemAccessRule accessRule = new FileSystemAccessRule(
                currentUser,
                FileSystemRights.FullControl,
                InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit,
                PropagationFlags.None,
                AccessControlType.Allow);

            bool modified;
            security.ModifyAccessRule(AccessControlModification.Add, accessRule, out modified);
            if (modified)
            {
                directoryInfo.SetAccessControl(security);
            }
        }

       

        

        

        

        
    }
}
