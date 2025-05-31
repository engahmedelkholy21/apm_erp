using System;
using System.Windows.Forms;
using GsmComm.GsmCommunication;
using GsmComm.Interfaces;
using GsmComm.PduConverter;

namespace pharma_manage
{
    public static class ReceiveSms
    {
        private static int Comm_Port = 0;
        private static int Comm_BaudRate = 9600;
        private static int Comm_TimeOut = 2000;
        private static GsmCommMain comm;

        public static event EventHandler<MessageReceivedEventArgs> MessageReceived;

        public static void StartListeningForIncomingSMS()
        {
            string exePath = Application.ExecutablePath;

            try
            {
                using (var srr = new System.IO.StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\port.txt"))
                {
                    Comm_Port = Convert.ToInt32(srr.ReadLine());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading port.txt: " + ex.Message);
                return;
            }

            comm = new GsmCommMain(Comm_Port, Comm_BaudRate, Comm_TimeOut);

            comm.MessageReceived += Comm_MessageReceived;

            comm.Open();
            if (comm.IsConnected())
            {
                MessageBox.Show("Listening for incoming SMS...");
            }
            else
            {
                MessageBox.Show("Failed to open the port. Check if the modem is connected and the correct port is selected.");
            }
        }

        private static void Comm_MessageReceived(object sender, GsmComm.GsmCommunication.MessageReceivedEventArgs e)
        {
            try
            {
                SmsPdu pdu = e.IndicationObject as SmsPdu;
                if (pdu is SmsDeliverPdu)
                {
                    SmsDeliverPdu data = (SmsDeliverPdu)pdu;
                    string senderNumber = data.OriginatingAddress;
                    string message = data.UserDataText;
                    OnMessageReceived(senderNumber, message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static void OnMessageReceived(string sender, string message)
        {
            var handler = MessageReceived;
            if (handler != null)
            {
                var args = new MessageReceivedEventArgs(sender, message);
                handler.Invoke(null, args);
            }
        }
    }

    public class MessageReceivedEventArgs : EventArgs
    {
        public string Sender { get; private set; }
        public string Message { get; private set; }

        public MessageReceivedEventArgs(string sender, string message)
        {
            Sender = sender;
            Message = message;
        }
    }
}
