using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Server1 : Form
    {
        public Server1()
        {
            InitializeComponent();
        }

        private void Server1_Load(object sender, EventArgs e)
        {
            
        }

        public void serverThread()
        {
            int Port = Convert.ToInt32(tbPort.Text);
            UdpClient udpClient = new UdpClient(Port);

            IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);

            while (true)
            {
                
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.ASCII.GetString(receiveBytes);
                string mess = RemoteIpEndPoint.Address.ToString() + ":" + returnData.ToString() + "\n";
                rtbMess.AppendText(mess + Environment.NewLine);
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            tbPort.Enabled = false;

            CheckForIllegalCrossThreadCalls = false;
            Thread thdUDPServer = new Thread(new ThreadStart(serverThread));
            thdUDPServer.Start();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
