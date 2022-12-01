using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace descompunereinfactoriprimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n, d, m;

            n = int.Parse(textBox1.Text);

            for (d = 2; n > 1; d++)
            {
                for (m = 0; n % d == 0; m++, n /= d)
                {
                    if (m>0)
                    {
                        textBox2.Text += "\r\n divizor " + " : " + "multiplicitate \r\n";
                        textBox2.Text += d.ToString() + " : " + m.ToString();
                    }

                }
            }
        }
    }
}
