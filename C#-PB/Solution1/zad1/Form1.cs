using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            
           
            
            int number = int.Parse(textBox1.Text);
            for (int i = number-1; i >0; i--)
            {

                 number*= i;
            }
            MessageBox.Show(number.ToString());
        }
    }
}
