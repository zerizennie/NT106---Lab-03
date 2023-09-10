﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Lab03
{
    public partial class menu2 : Form
    {
        public menu2()
        {
            InitializeComponent();
        }

        private void UnsafeThread()
        {

            IPEndPoint IPEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8081);

            byte[] receive = new byte[1];
            Socket ClientSocket;

            Socket ListenerSocket = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp );

            ListenerSocket.Bind(IPEP);
            ListenerSocket.Listen(-1);
            ClientSocket = ListenerSocket.Accept();

            while (ClientSocket.Connected)
            {
                string text = "";
                ClientSocket.Receive(receive);
                text += Encoding.ASCII.GetString(receive);
                rtbMess.AppendText(text);
            }
            ListenerSocket.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(UnsafeThread));
            serverThread.IsBackground = true;
            serverThread.Start();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
