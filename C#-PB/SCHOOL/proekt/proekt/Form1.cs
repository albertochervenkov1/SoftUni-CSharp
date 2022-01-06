using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            byte[] ba = new byte[20];
            rnd.NextBytes(ba);
            int sumOdd = 0;
            int sumEven = 0;

            for (int i = 0; i < 20; i++)
            {
                listBox1.Items.Add(ba[i].ToString());
                if (i%2==0)
                {
                    sumEven += ba[i];
                        
                }
                else
                {
                    sumOdd += ba[i];
                }
            }
            label3.Text=(sumEven.ToString());
            label4.Text=(sumOdd.ToString());






        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label3.Text=string.Empty;
            label4.Text = string.Empty;

        }
    }
}
