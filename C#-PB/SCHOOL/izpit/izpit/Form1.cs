using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace izpit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);

           
            int tempNum = num;
            string strNum = "";
            strNum += num;
            int sum = 0;

            for (int i = 0; i < strNum.Length; i++)
            {
                int currentDigit = tempNum % 10;
                tempNum = (tempNum - currentDigit) / 10;
                
                
            }
            if (num == sum)
            {
                MessageBox.Show("симетрично");
            }
            else
            {
                MessageBox.Show("не");
            }






        }
    }
}
