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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ReceiveSms.StartListeningForIncomingSMS();

            // Subscribe to the MessageReceived event to handle incoming SMS
            ReceiveSms.MessageReceived += ReceiveSms_MessageReceived;
        }
        private void ReceiveSms_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            // e.Sender will have the sender's phone number, and e.Message will have the incoming SMS message.
            // Add your desired logic here to process the incoming SMS.
            MessageBox.Show("New SMS from: " + e.Sender + "\nMessage: " + e.Message);

        }
    }
}
