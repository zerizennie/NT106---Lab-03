using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Client1 : Form
    {
        public Client1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient();

            int port = Convert.ToInt32(tbPort.Text);
            string IP = tbIP.Text;
            IPEndPoint IPEP = new IPEndPoint(IPAddress.Parse(IP), port);  

            Byte[] sendBytes = Encoding.ASCII.GetBytes(tbMes.Text);

            udpClient.Send(sendBytes, sendBytes.Length, IPEP);

        }
    }
}
