﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace зад7
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
            int br = 0;
            int k = 0;

            while (n!=0)
            {
                 k= n % 10;
                if (k%2==1)
                {
                    br++;
                    n = n / 10;
                }
            }
            label1.Text = br.ToString();

        }
    }
}
