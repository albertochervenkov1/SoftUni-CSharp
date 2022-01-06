using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace izpiNiko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m = 100;
            int counter = 0;
            do
            {
                m -= 20;
                counter++;
            } while (m!=-20);
            label1.Text = (counter.ToString());

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
