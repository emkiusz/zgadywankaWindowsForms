using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace theGra
{
    public partial class Form1 : Form
    {
        int maks;
        int dbl;
        int skok = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Random nowy = new Random();
            maks = nowy.Next(10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (skok<100)
            {
                skok += 10;
                if (dbl > maks)
                {
                    MessageBox.Show("ZA DUZO");
                }
                else if (dbl < maks)
                {
                    MessageBox.Show("ZA MALO");
                }
                else if(dbl==maks)
                {
                    MessageBox.Show("WYGRALES! SZUKANA LICZBA TO " + dbl);
                    dbl = 0;
                    maks = 0;
                    skok = 0;
                }
            }
            else
            {
                MessageBox.Show("PRZEGRALES");
                maks = 0;
                dbl = 0;
                skok = 0;
            }
            progressBar1.Value = skok;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Random nowy = new Random();
            maks = nowy.Next(100);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Random nowy = new Random();
            maks = nowy.Next(1000);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dbl = int.Parse(textBox1.Text);
        }
    }
}
