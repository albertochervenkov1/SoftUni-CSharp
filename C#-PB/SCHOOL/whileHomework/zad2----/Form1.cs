using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad2____
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nums = int.Parse(textBox1.Text);
            int currentDigit = 0;
            while (nums!=0)
            {
                currentDigit = nums % 10;
                nums /= 10;
                listBox1.Items.Add(currentDigit);
                
            }
        }
    }
}
