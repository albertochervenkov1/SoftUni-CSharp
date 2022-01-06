using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nutsova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number=0;
            int min = 1001;
            int max = 9999;

            while (number<50)
            {
                Random r = new Random();
                r.Next(min, max);
                listBox1.Items.Add(r);
                number++;
            }

        }
    }
}
