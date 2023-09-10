using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class menu1 : Form
    {
        public menu1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Server1 frm2 = new Server1();
            frm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Client1 frm3 = new Client1();
            frm3.Show();
        }
    }
}
