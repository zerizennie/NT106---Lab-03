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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu1 frm1 = new menu1();
            frm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menu2 frm2 = new menu2();
            frm2.Show();
        }
    }
}
