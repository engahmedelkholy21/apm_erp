using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


using GsmComm.GsmCommunication;
using GsmComm.Interfaces;
using GsmComm.PduConverter;
using GsmComm.Server;
using System.IO;
//using System.Data.OleDb;
using System.Management;


using System.Threading;


namespace pharma_manage
{


    public static class send_sms_class
    {
        public static Int16 Comm_Port =0;
        public static Int32 Comm_BaudRate = 9600;
        public static Int32 Comm_TimeOut = 2000;
        public static GsmCommMain comm;



        public static void send_sms_msg(string msg, string phone)
        {
            string exePath = Application.ExecutablePath;

            StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\port.txt");
            Comm_Port = Convert.ToInt16(srr.ReadLine());
            comm = new GsmCommMain(Comm_Port, Comm_BaudRate, Comm_TimeOut);
            

            comm.Open();

            SmsSubmitPdu pdu1;
          
            //try
            //{

            if (comm.IsConnected() == true)
            {
                try
                {
                    if (msg == "")
                    {
                        //   MessageBox.Show("ادخل الرسالة", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }


                    byte dcs = (byte)DataCodingScheme.GeneralCoding.Alpha16Bit;

                    OutgoingSmsPdu[] pdus = null;
                    pdus = GsmComm.PduConverter.SmartMessaging.SmartMessageFactory.CreateConcatTextMessage(msg, true, phone);


                    comm.SendMessages(pdus);

                    SmsDeliverMessageFlags sdmf = new SmsDeliverMessageFlags();
                    string DeliverRpt = sdmf.MessageType.ToString();


                    MessageBox.Show(DeliverRpt);

                    Thread.Sleep(500);
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }
            comm.Close();
        }




    }
}
