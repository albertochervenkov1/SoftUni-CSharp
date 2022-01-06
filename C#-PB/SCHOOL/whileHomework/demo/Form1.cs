using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { int counter = 0;

            int n = -5;
            while (n < 10)
            {
                listBox1.Items.Add(n);
                n += 2;
                counter++;


            }
            MessageBox.Show(counter.ToString());
        } 
    }
}
