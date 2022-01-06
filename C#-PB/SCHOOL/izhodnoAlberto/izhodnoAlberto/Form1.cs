using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace izhodnoAlberto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int chislo = int.Parse(textBox2.Text);
            int currentDigit = 0;

            while (n!=0)
            {
                currentDigit = n % 10;
                n /= 10;

                if (currentDigit==chislo)
                {
                    MessageBox.Show("Yes");
                    return;
                    
                }
                
                
                    
                    
                    
                
               
            }
            MessageBox.Show("No");

        }
    }
}
