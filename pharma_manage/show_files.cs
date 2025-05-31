using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace pharma_manage
{
    public partial class show_files : Form
    {
        public show_files()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;

            webBrowser1.Print();// ShowPrintDialog = true;
        }

        private void show_files_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.uploaded_files_table' table. You can move, or remove it, as needed.
           // this.uploaded_files_tableTableAdapter.Fill(this.dataSet1.uploaded_files_table);
            suggestions();
            temporaryFilePaths.Clear();

            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void suggestions()
        {



            try
            {
                this.uploaded_files_tableTableAdapter.Fill(this.dataSet1.uploaded_files_table);
                txt_search.AutoCompleteMode = AutoCompleteMode.Suggest;
                txt_search.AutoCompleteSource = AutoCompleteSource.CustomSource;


                AutoCompleteStringCollection DataCollection1 = new AutoCompleteStringCollection();
                foreach (DataRow dr in dataSet1.uploaded_files_table.Rows)
                {
                    DataCollection1.Add(dr["uploaded_warehouse"].ToString());
                    DataCollection1.Add(dr["uploaded_type"].ToString());
                    DataCollection1.Add(dr["uploaded_file_name"].ToString());
                    //DataCollection1.Add(dr["tawreed_item_code"].ToString());
                    //DataCollection1.Add(dr["tawreed_item_name"].ToString());
                    //DataCollection1.Add(dr["tawreed_item_work_order"].ToString());
                    //DataCollection1.Add(dr["tawreed_item_reservation"].ToString());
                    //DataCollection1.Add(dr["tawreed_item_warehouse"].ToString());

                }

                txt_search.AutoCompleteCustomSource = DataCollection1;
            }
            catch { }
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // Calculate the zoom level to fit the content within the WebBrowser control
            double zoomLevel = Math.Min(webBrowser1.ClientSize.Width / (double)webBrowser1.Document.Body.ScrollRectangle.Width,
                                        webBrowser1.ClientSize.Height / (double)webBrowser1.Document.Body.ScrollRectangle.Height);

            // Set the calculated zoom level
            webBrowser1.Document.Body.Style = "zoom:" + (zoomLevel * 100) + "%";
        }

        private List<string> temporaryFilePaths = new List<string>();
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ////try
            ////{
            //int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            //DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];  
            //webBrowser1.Url = new Uri(selectedRow.Cells[7].Value.ToString());

            ////}
            ////catch { }

            try
            {
                dataGridView1.Enabled = false;
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                //DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex]; 
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string ftpUrl = selectedRow.Cells[7].Value.ToString(); // FTP URL from the database

                // Create a temporary local file path to download the file
                string tempFilePath = Path.GetTempFileName();
                string tempFileExtension = Path.GetExtension(ftpUrl);
               // string tempLocalFilePath = ;//Path.ChangeExtension(tempFilePath, tempFileExtension);
               
                // Download the file from FTP to the local temporary path
               //jjjjjj DownloadFileFromFtp(ftpUrl, tempLocalFilePath,Properties.Resources.ftp_username,Properties.Resources.ftp_password);
               
                //// Save the path of the temporary file
                // temporaryFilePaths.Add(tempLocalFilePath);
                //// Display the file using WebBrowser
                webBrowser1.Url = new Uri(ftpUrl);
                webBrowser1.ScrollBarsEnabled = true;
                webBrowser1.ScriptErrorsSuppressed = true;
                webBrowser1.DocumentCompleted += WebBrowser1_DocumentCompleted;



                dataGridView1.Enabled = true;

            }
            catch { dataGridView1.Enabled = true; }
        }
        private void DownloadFileFromFtp(string ftpUrl, string localFilePath,string user_name,string password)
        {
            using (WebClient client = new WebClient())
            {
                client.Credentials = new NetworkCredential(user_name, password);
                client.DownloadFile(ftpUrl, localFilePath);
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void show_files_FormClosing(object sender, FormClosingEventArgs e)
        {
            //webBrowser1.Url = null;
            //foreach (string tempFilePath in temporaryFilePaths)
            //{
            //    try
            //    {
            //        File.Delete(tempFilePath);
            //    }
            //    catch (Exception ex)
            //    {
            //        // Handle or log any exceptions during cleanup
            //      MessageBox.Show("Error deleting temporary file: "+ex.Message);
            //    }
            //}
        }

        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) 
            {
                search_method();
            }

        }
        private void search_method()
        {
            try
            {
                if (txt_search.Text == "")
                {
                    //  work_order_tableTableAdapter.Fill(dataSet11.work_order_table);
                    uploaded_files_tableTableAdapter.FillBy_FATRA(dataSet1.uploaded_files_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
                }
                else
                {

                    uploaded_files_tableTableAdapter.FillBy_WAREHOUSE_FATRA(dataSet1.uploaded_files_table,txt_search.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
                    if (dataSet1.uploaded_files_table.Rows.Count <= 0) 
                    {
                        uploaded_files_tableTableAdapter.FillBy_type_fatra(dataSet1.uploaded_files_table, txt_search.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
                   
                    }
                    if (dataSet1.uploaded_files_table.Rows.Count <= 0)
                    {
                        uploaded_files_tableTableAdapter.FillBy_uploaded_file_name_fatra(dataSet1.uploaded_files_table, txt_search.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());

                    }
                }
                //  txt_total.Text = dataGridView1.Rows.Count.ToString();
            }
            catch { }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            search_method();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            search_method();
        }
      
    }
}
