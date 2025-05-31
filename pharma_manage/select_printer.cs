using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ZXing;
using CrystalDecisions.CrystalReports.Engine;

namespace pharma_manage
{
    public partial class select_printer : Form
    {
        public select_printer()
        {
            InitializeComponent();
            Form1 f1 = new Form1();
            f1.SubscribeToLoadEvent(this);
            f1.ApplyFormStyling(this);
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            backgroundWorker_print.RunWorkerAsync();

            this.Close();
        }

        private void select_printer_Load(object sender, EventArgs e)
        {
           
            if (type_txt.Text == "بيع")
            {
                string main_printer = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\main_printer.txt").First();
                foreach (RadioButton b in groupBox1.Controls.OfType<RadioButton>())
                {
                    if (b.Text == main_printer)
                    {
                        b.Checked = true;
                    }

                }

                    string auto_print = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\auto_print").First();
                    if (auto_print == "yes")
                    {
                        button_WOC1_Click(sender, e);
                    }
               // backgroundWorker_sms_sending.RunWorkerAsync();
                
            }
            else 
            {
                show_tas3eer ss = new show_tas3eer();
                ss.salesID_TXT.Text = sales_num.Text;
                ss.far3txt.Text = far3txt.Text;
                ss.ShowDialog();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (type_txt.Text == "بيع")
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "PDF (*.pdf)|*.pdf";
                sf.FileName = "فاتورة بيع رقم " + sales_num.Text + " " + cst_name_txt.Text;
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    FileInfo path_file = new FileInfo(sf.FileName);
                    // MessageBox.Show(path_file.ToString());
                    string qr = "";
                    try
                    {

                        BarcodeWriter b = new BarcodeWriter();
                        ZXing.Common.EncodingOptions encoding = new ZXing.Common.EncodingOptions() { Width = 500, Height = 500, Margin = 0, PureBarcode = false };
                        b.Renderer = new ZXing.Rendering.BitmapRenderer();

                        encoding.Hints.Add(EncodeHintType.ERROR_CORRECTION, ZXing.QrCode.Internal.ErrorCorrectionLevel.L);
                        encoding.Hints.Add(EncodeHintType.CHARACTER_SET, "UTF-8");
                        b.Options = encoding;
                        b.Format = BarcodeFormat.QR_CODE;


                        Bitmap pic = b.Write("copyright reserved © Advanced Programming Maintenance Smart Solutins (A.P.M Smart Solutins) tel: +201015065484 & +201025220349");
                        //pictureBox1.Image = pic;
                        pic.Save(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "//aaa.jpg");



                        qr = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "//aaa.jpg";
                    }
                    catch { }


                    if (reset_print.Checked == true)
                    {
                        StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_fwateer.txt");
                        string printer_name = srr.ReadLine();

                        string param;
                        string logo_or_name;


                        logo_or_name = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\logo_name.txt").First();


                        param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";
                        pharmacy_dataTableAdapter1.Fill(dataSet11.pharmacy_data);

                        string apm_qr = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\apm_qr.txt").First();
                        string cst_qr = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\cst_qr_txt").First();

                        string page_size = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\page_size.txt").First();

                        Boolean pieces_param;

                        string pieces_param1 = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\pieces_param").First();
                        if (pieces_param1 == "yes")
                        {
                            pieces_param = true;
                        }
                        else
                        {
                            pieces_param = false;
                        }

                        Boolean matloob_param;
                        string matloob_param1 = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\matloob_param").First();
                        if (matloob_param1 == "yes")
                        {
                            matloob_param = true;
                        }
                        else
                        {
                            matloob_param = false;
                        }

                        Boolean safy_param;
                        string safy_param1 = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\safy_param").First();
                        if (safy_param1 == "yes")
                        {
                            safy_param = true;
                        }
                        else
                        {
                            safy_param = false;
                        }

                        Boolean mosadad_param;
                        string mosadad_param1 = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\mosadad_param").First();
                        if (mosadad_param1 == "yes")
                        {
                            mosadad_param = true;
                        }
                        else
                        {
                            mosadad_param = false;
                        }
                        //try
                        //{

                        if (printer_name == "")
                        {
                            madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet11.madeen_small_report, cst_name_txt.Text);
                            customersTableAdapter1.Fill(dataSet11.customers);

                            string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\CrystalReport1_pos.rpt";
                            CrystalDecisions.CrystalReports.Engine.ReportDocument doc = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                            doc.Load(path);

                            try
                            {
                                doc.SetDataSource(dataSet11);
                            }
                            catch { doc.SetDataSource(dataSet11); }
                            doc.Refresh();
                            // crystalReport11.PrintOptions.PrinterName = "BIXOLON SRP-350II";
                            //  crystalReport11.PrintToPrinter(1, false, 0, 0);

                            doc.SetParameterValue("test", param);

                            doc.SetParameterValue("qr", qr);
                            doc.SetParameterValue("apm_qr", apm_qr);
                            doc.SetParameterValue("logo_or_name", logo_or_name);

                            doc.SetParameterValue("cst_qr", cst_qr);


                            doc.SetParameterValue("pieces_param", pieces_param);
                            doc.SetParameterValue("matloob_param", matloob_param);
                            doc.SetParameterValue("safy_param", safy_param);
                            doc.SetParameterValue("mosadad_param", mosadad_param);

                          

                            sales_tableTableAdapter1.FillBy_ID_stock(dataSet11.sales_table, Convert.ToInt32(sales_num.Text), far3txt.Text);


                            string name = sf.FileName;
                            //name = name.Replace("/", "-");

                            //MessageBox.Show(name);
                            doc.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, path_file.ToString());
                            System.Diagnostics.Process.Start(path_file.ToString());
                            // MessageBox.Show("aa");
                        }
                        else
                        {

                            crystalReport1_pos1.Dispose();
                            crystalReport1_pos1.Close();
                            //  crystalReport11.Refresh();

                            madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet11.madeen_small_report, cst_name_txt.Text);
                            customersTableAdapter1.Fill(dataSet11.customers);

                            crystalReport1_pos1.Refresh();
                            crystalReport1_pos1.SetDataSource(dataSet11);


                            // MessageBox.Show(param);


                            crystalReport1_pos1.SetParameterValue("apm_qr", apm_qr);
                            crystalReport1_pos1.SetParameterValue("test", param);

                            crystalReport1_pos1.SetParameterValue("qr", qr);
                            crystalReport1_pos1.SetParameterValue("logo_or_name", logo_or_name);
                            crystalReport1_pos1.SetParameterValue("cst_qr", cst_qr);

                            crystalReport1_pos1.SetParameterValue("pieces_param", pieces_param);
                            crystalReport1_pos1.SetParameterValue("matloob_param", matloob_param);
                            crystalReport1_pos1.SetParameterValue("safy_param", safy_param);
                            crystalReport1_pos1.SetParameterValue("mosadad_param", mosadad_param);


                            sales_tableTableAdapter1.FillBy_ID_stock(dataSet11.sales_table, Convert.ToInt32(sales_num.Text), far3txt.Text);


                            string name = sf.FileName;
                            //name = name.Replace("/", "-");

                            //MessageBox.Show(name);
                            crystalReport1_pos1.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, path_file.ToString());
                            System.Diagnostics.Process.Start(path_file.ToString());
                            //crystalReport11.PrintOptions.PrinterName = printer_name;
                            //crystalReport11.PrintToPrinter(1, false, 0, 0);
                            //crystalReport11.Dispose();
                            //crystalReport11.Close();
                            //crystalReport11.Refresh();



                        }
                        //}
                        //catch { }



                    }
                    else if (a5_print.Checked == true)
                    {
                        pharmacy_dataTableAdapter1.Fill(dataSet11.pharmacy_data);
                        madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet11.madeen_small_report, cst_name_txt.Text);
                        customersTableAdapter1.Fill(dataSet11.customers);
                        a5_fatora_crystal_report1.Refresh();
                        a5_fatora_crystal_report1.SetDataSource(dataSet11);


                        string param;

                        param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";
                        // MessageBox.Show(param);
                        a5_fatora_crystal_report1.SetParameterValue("test", param);
                        a5_fatora_crystal_report1.SetParameterValue("qr", qr);

                        sales_tableTableAdapter1.FillBy_ID_stock(dataSet11.sales_table, Convert.ToInt32(sales_num.Text), far3txt.Text);



                        string name = sf.FileName;
                        //name = name.Replace("/", "-");

                        //MessageBox.Show(name);
                        a5_fatora_crystal_report1.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, path_file.ToString());
                        System.Diagnostics.Process.Start(path_file.ToString());



                    }
                    else if (a4_print.Checked == true)
                    {
                        if (nesba_or_not_txt.Text == "نسبة")
                        {
                            pharmacy_dataTableAdapter1.Fill(dataSet11.pharmacy_data);
                            madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet11.madeen_small_report, cst_name_txt.Text);

                            a4_fatora_nesba1.Refresh();
                            a4_fatora_nesba1.SetDataSource(dataSet11);


                            string param;

                            param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";
                            // MessageBox.Show(param);
                            a4_fatora_nesba1.SetParameterValue("test", param);
                            sales_tableTableAdapter1.FillBy_ID_stock(dataSet11.sales_table, Convert.ToInt32(sales_num.Text), far3txt.Text);


                            string name = sf.FileName;
                            //name = name.Replace("/", "-");

                            //MessageBox.Show(name);
                            a4_fatora_nesba1.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, path_file.ToString());
                            System.Diagnostics.Process.Start(path_file.ToString());
                        }
                        else 
                        {
                            pharmacy_dataTableAdapter1.Fill(dataSet11.pharmacy_data);
                            madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet11.madeen_small_report, cst_name_txt.Text);

                            a4_fatora1.Refresh();
                            a4_fatora1.SetDataSource(dataSet11);


                            string param;

                            param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";
                            // MessageBox.Show(param);
                            a4_fatora1.SetParameterValue("test", param);
                            sales_tableTableAdapter1.FillBy_ID_stock(dataSet11.sales_table, Convert.ToInt32(sales_num.Text), far3txt.Text);


                            string name = sf.FileName;
                            //name = name.Replace("/", "-");

                            //MessageBox.Show(name);
                            a4_fatora1.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, path_file.ToString());
                            System.Diagnostics.Process.Start(path_file.ToString());
                        }
                       

                    }
                    this.Close();
                }
            }
           
        }

        private void backgroundWorker_print_DoWork(object sender, DoWorkEventArgs e)
        {
            if (type_txt.Text == "بيع")
            {
                string qr = "";
                try
                {

                    BarcodeWriter b = new BarcodeWriter();
                    ZXing.Common.EncodingOptions encoding = new ZXing.Common.EncodingOptions() { Width = 500, Height = 500, Margin = 0, PureBarcode = false };
                    b.Renderer = new ZXing.Rendering.BitmapRenderer();

                    encoding.Hints.Add(EncodeHintType.ERROR_CORRECTION, ZXing.QrCode.Internal.ErrorCorrectionLevel.L);
                    encoding.Hints.Add(EncodeHintType.CHARACTER_SET, "UTF-8");
                    b.Options = encoding;
                    b.Format = BarcodeFormat.QR_CODE;


                    Bitmap pic = b.Write("copyright reserved © Advanced Programming Maintenance Smart Solutins (A.P.M Smart Solutins) tel: +201015065484 & +201025220349");
                    //pictureBox1.Image = pic;
                    pic.Save(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "//aaa.jpg");



                    qr = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "//aaa.jpg";
                }
                catch { }


                if (reset_print.Checked == true)
                {
                    StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_fwateer.txt");
                    string printer_name = srr.ReadLine();

                    string param;
                    string logo_or_name;

                   
                    logo_or_name = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\logo_name.txt").First();


                    param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";
                    pharmacy_dataTableAdapter1.Fill(dataSet11.pharmacy_data);

                    string apm_qr = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\apm_qr.txt").First();
                    string cst_qr = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\cst_qr_txt").First();

                    string page_size = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\page_size.txt").First();

                    Boolean pieces_param;
                    
                    string pieces_param1 = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\pieces_param").First();
                    if (pieces_param1 == "yes")
                    {
                        pieces_param = true;
                    }
                    else
                    {
                        pieces_param = false;
                    }

                    Boolean matloob_param;
                    string matloob_param1 = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\matloob_param").First();
                    if (matloob_param1 == "yes")
                    {
                       matloob_param = true;
                    }
                    else
                    {
                        matloob_param = false;
                    }

                    Boolean safy_param;
                    string safy_param1 = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\safy_param").First();
                    if (safy_param1 == "yes")
                    {
                        safy_param = true;
                    }
                    else
                    {
                        safy_param = false;
                    }

                    Boolean mosadad_param;
                    string mosadad_param1 = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\mosadad_param").First();
                    if (mosadad_param1 == "yes")
                    {
                        mosadad_param = true;
                    }
                    else
                    {
                        mosadad_param = false;
                    }

                    //try
                    //{

                   // if (printer_name == "")

                    try
                    {
                        madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet11.madeen_small_report, cst_name_txt.Text);
                        customersTableAdapter1.Fill(dataSet11.customers);
                        string path = "";
                        CrystalDecisions.CrystalReports.Engine.ReportDocument doc = new CrystalDecisions.CrystalReports.Engine.ReportDocument();

                        if (page_size == "all")
                        {
                            //path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\CrystalReport1_pos.rpt";
                            doc = crystalReport1_pos1;
                        }
                        else
                        {
                            // path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\CrystalReport1_apm.rpt";
                            //MessageBox.Show("aaa");
                            doc = crystalReport1_apm1;
                        }
                        // doc.Load(path);

                        try
                        {
                            doc.SetDataSource(dataSet11);
                        }
                        catch { doc.SetDataSource(dataSet11); }
                        doc.Refresh();
                        // crystalReport11.PrintOptions.PrinterName = "BIXOLON SRP-350II";
                        //  crystalReport11.PrintToPrinter(1, false, 0, 0);

                        doc.SetParameterValue("test", param);
                        doc.SetParameterValue("apm_qr", apm_qr);
                        doc.SetParameterValue("qr", qr);
                        doc.SetParameterValue("cst_qr", cst_qr);
                        doc.SetParameterValue("logo_or_name", logo_or_name);
                        doc.SetParameterValue("pieces_param", pieces_param);
                        doc.SetParameterValue("matloob_param", matloob_param);
                        doc.SetParameterValue("safy_param", safy_param);
                        doc.SetParameterValue("mosadad_param", mosadad_param);
                        sales_tableTableAdapter1.FillBy_ID_stock(dataSet11.sales_table, Convert.ToInt32(sales_num.Text), far3txt.Text);

                        //   MessageBox.Show("aaa");
                        //CrystalDecisions.ReportAppServer.Controllers.PrintReportOptions p = new CrystalDecisions.ReportAppServer.Controllers.PrintReportOptions();

                        //doc.ReportClientDocument.PrintOutputController.PrintReport(p);
                        doc.PrintOptions.PrinterName = printer_name;
                        doc.PrintToPrinter(1, false, 0, 0);
                        // MessageBox.Show("aa");
                    }
                    catch
                    {

                        //MessageBox.Show(page_size);

                        crystalReport1_pos1.Dispose();
                        crystalReport1_pos1.Close();
                        //  crystalReport11.Refresh();

                        madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet11.madeen_small_report, cst_name_txt.Text);
                        customersTableAdapter1.Fill(dataSet11.customers);

                        crystalReport1_pos1.Refresh();
                        crystalReport1_pos1.SetDataSource(dataSet11);

                        crystalReport1_pos1.SetParameterValue("apm_qr", apm_qr);
                        // MessageBox.Show(param);
                        crystalReport1_pos1.SetParameterValue("test", param);
                        crystalReport1_pos1.SetParameterValue("cst_qr", cst_qr);
                        crystalReport1_pos1.SetParameterValue("qr", qr);
                        crystalReport1_pos1.SetParameterValue("logo_or_name", logo_or_name);
                        crystalReport1_pos1.SetParameterValue("pieces_param", pieces_param);
                        crystalReport1_pos1.SetParameterValue("matloob_param", matloob_param);
                        crystalReport1_pos1.SetParameterValue("safy_param", safy_param);
                        crystalReport1_pos1.SetParameterValue("mosadad_param", mosadad_param);
                        sales_tableTableAdapter1.FillBy_ID_stock(dataSet11.sales_table, Convert.ToInt32(sales_num.Text), far3txt.Text);


                        crystalReport1_pos1.PrintOptions.PrinterName = printer_name;
                        crystalReport1_pos1.PrintToPrinter(1, false, 0, 0);
                        crystalReport1_pos1.Dispose();
                        crystalReport1_pos1.Close();
                        crystalReport1_pos1.Refresh();



                    }
                    //}
                    //catch { }

                    string ezn_yes_or_no = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\ezn.txt").First();
                    if (ezn_yes_or_no == "yes")
                    {


                        foreach (var item in listBox1.Items)
                        {
                            // MessageBox.Show(item.ToString());
                            //try
                            //{
                            try
                            {
                                copy_of_CrystalReport11.Refresh();
                                copy_of_CrystalReport11.SetDataSource(dataSet11);
                            }
                            catch
                            {
                                copy_of_CrystalReport11.Refresh();
                                copy_of_CrystalReport11.SetDataSource(dataSet11);
                            }

                            copy_of_CrystalReport11.SetParameterValue("test", param);
                            // MessageBox.Show("aa");
                            string ezn_type = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\ezn_type.txt").First();
                            if (ezn_type == "الفئة")
                            {
                                sales_tableTableAdapter1.FillBy_ID_stock_category(dataSet11.sales_table, Convert.ToInt32(sales_num.Text), far3txt.Text, item.ToString());
                            }
                            else if (ezn_type == "الفرع")
                            {
                                sales_tableTableAdapter1.FillBy_ID_stock(dataSet11.sales_table, Convert.ToInt32(sales_num.Text), item.ToString());
                            }

                            copy_of_CrystalReport11.PrintOptions.PrinterName = printer_name;
                            copy_of_CrystalReport11.PrintToPrinter(1, false, 0, 0);
                            copy_of_CrystalReport11.Dispose();
                            copy_of_CrystalReport11.Close();
                            //}
                            //catch { }
                        }
                    }

                }
                else if (a5_print.Checked == true)
                {
                    pharmacy_dataTableAdapter1.Fill(dataSet11.pharmacy_data);
                    madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet11.madeen_small_report, cst_name_txt.Text);
                    customersTableAdapter1.Fill(dataSet11.customers);
                    a5_fatora_crystal_report1.Refresh();
                    a5_fatora_crystal_report1.SetDataSource(dataSet11);


                    string param;

                    param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";
                    // MessageBox.Show(param);
                    a5_fatora_crystal_report1.SetParameterValue("test", param);
                    a5_fatora_crystal_report1.SetParameterValue("qr", qr);

                    sales_tableTableAdapter1.FillBy_ID_stock(dataSet11.sales_table, Convert.ToInt32(sales_num.Text), far3txt.Text);


                    StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_a4.txt");
                    string printer_name = srr.ReadLine();
                    a5_fatora_crystal_report1.PrintOptions.PrinterName = printer_name;
                    a5_fatora_crystal_report1.PrintToPrinter(1, false, 0, 0);
                    a5_fatora_crystal_report1.Dispose();
                    a5_fatora_crystal_report1.Close();
                    a5_fatora_crystal_report1.Refresh();


                    string ezn_yes_or_no = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\ezn.txt").First();
                    if (ezn_yes_or_no == "yes")
                    {


                        foreach (var item in listBox1.Items)
                        {
                            // MessageBox.Show(item.ToString());
                            try
                            {
                            try
                            {
                                a5_ezn_fatora_crystal_report1.Refresh();
                                a5_ezn_fatora_crystal_report1.SetDataSource(dataSet11);
                            }
                            catch
                            {
                                a5_ezn_fatora_crystal_report1.Refresh();
                                a5_ezn_fatora_crystal_report1.SetDataSource(dataSet11);
                            }

                            a5_ezn_fatora_crystal_report1.SetParameterValue("test", param);
                            // MessageBox.Show("aa");
                            string ezn_type = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\ezn_type.txt").First();
                            if (ezn_type == "الفئة")
                            {
                                sales_tableTableAdapter1.FillBy_ID_stock_category(dataSet11.sales_table, Convert.ToInt32(sales_num.Text), far3txt.Text, item.ToString());
                            }
                            else if (ezn_type == "الفرع")
                            {
                                sales_tableTableAdapter1.FillBy_ID_stock(dataSet11.sales_table, Convert.ToInt32(sales_num.Text), item.ToString());
                            }

                            a5_ezn_fatora_crystal_report1.PrintOptions.PrinterName = printer_name;
                            a5_ezn_fatora_crystal_report1.PrintToPrinter(1, false, 0, 0);
                            a5_ezn_fatora_crystal_report1.Dispose();
                            a5_ezn_fatora_crystal_report1.Close();
                            }
                            catch { }
                        }
                    }


                }
                else if (a4_print.Checked == true)
                {
                    string param;

                    param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";

                    StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_a4.txt");
                    string printer_name = srr.ReadLine();

                    if (nesba_or_not_txt.Text == "نسبة")
                    {
                        pharmacy_dataTableAdapter1.Fill(dataSet11.pharmacy_data);
                        madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet11.madeen_small_report, cst_name_txt.Text);
                        a4_fatora_nesba1.Refresh();
                        a4_fatora_nesba1.SetDataSource(dataSet11);


                       
                        // MessageBox.Show(param);
                        a4_fatora_nesba1.SetParameterValue("test", param);
                        sales_tableTableAdapter1.FillBy_ID_stock(dataSet11.sales_table, Convert.ToInt32(sales_num.Text), far3txt.Text);


                       
                        a4_fatora_nesba1.PrintOptions.PrinterName = printer_name;
                        a4_fatora_nesba1.PrintToPrinter(1, false, 0, 0);
                        a4_fatora_nesba1.Dispose();
                        a4_fatora_nesba1.Close();
                        a4_fatora_nesba1.Refresh();
                    }
                    else
                    {

                        pharmacy_dataTableAdapter1.Fill(dataSet11.pharmacy_data);
                        madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet11.madeen_small_report, cst_name_txt.Text);
                        a4_fatora1.Refresh();
                        a4_fatora1.SetDataSource(dataSet11);


                        //string param;

                        //param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";
                        // MessageBox.Show(param);
                        a4_fatora1.SetParameterValue("test", param);
                        sales_tableTableAdapter1.FillBy_ID_stock(dataSet11.sales_table, Convert.ToInt32(sales_num.Text), far3txt.Text);


                        //StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_a4.txt");
                        //string printer_name = srr.ReadLine();
                        a4_fatora1.PrintOptions.PrinterName = printer_name;
                        a4_fatora1.PrintToPrinter(1, false, 0, 0);
                        a4_fatora1.Dispose();
                        a4_fatora1.Close();
                        a4_fatora1.Refresh();
                    }

                    string ezn_yes_or_no = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\ezn.txt").First();
                    if (ezn_yes_or_no == "yes")
                    {


                        foreach (var item in listBox1.Items)
                        {
                            // MessageBox.Show(item.ToString());
                            try
                            {
                            try
                            {
                                a4_ezn_fatora1.Refresh();
                                a4_ezn_fatora1.SetDataSource(dataSet11);
                            }
                            catch
                            {
                                a4_ezn_fatora1.Refresh();
                                a4_ezn_fatora1.SetDataSource(dataSet11);
                            }

                            a4_ezn_fatora1.SetParameterValue("test", param);
                            // MessageBox.Show("aa");
                            string ezn_type = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\ezn_type.txt").First();
                            if (ezn_type == "الفئة")
                            {
                                sales_tableTableAdapter1.FillBy_ID_stock_category(dataSet11.sales_table, Convert.ToInt32(sales_num.Text), far3txt.Text, item.ToString());
                            }
                            else if (ezn_type == "الفرع")
                            {
                                sales_tableTableAdapter1.FillBy_ID_stock(dataSet11.sales_table, Convert.ToInt32(sales_num.Text), item.ToString());
                            }

                            a4_ezn_fatora1.PrintOptions.PrinterName = printer_name;
                            a4_ezn_fatora1.PrintToPrinter(1, false, 0, 0);
                            a4_ezn_fatora1.Dispose();
                            a4_ezn_fatora1.Close();
                            }
                            catch { }
                        }
                    }

                }
            }
        }

        private void backgroundWorker_save_pdf_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void backgroundWorker_sms_sending_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                pharmacy_dataTableAdapter1.Fill(dataSet11.pharmacy_data);
                string ph_name = dataSet11.pharmacy_data.Rows[0]["pharmacy_name"].ToString();
                customersTableAdapter1.FillBy_name(dataSet11.customers, cst_name_txt.Text);

                string phone_num = dataSet11.customers.Rows[0]["cst_phone"].ToString();
                if (phone_num != "")
                {
                    string msg = "عميلنا العزيز فاتورتك رقم " + sales_num.Text + " قيمتها " + sales_total_txt.Text + Environment.NewLine +
                        "شكرا علشان انت جزء من عيلتنا واحنا دايما في خدمتك" + Environment.NewLine + ph_name;
                    send_sms_class.send_sms_msg(msg, phone_num);
                }
            }
            catch { }
        }

      
    }
}
