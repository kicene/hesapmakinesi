using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapmakine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        int sayi = 0;
        int sonuc = 0;
        int onceki = 0;
        string op = "";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1";
            sayi = Convert.ToInt32(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "2";
            sayi = Convert.ToInt32(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3";
            sayi = Convert.ToInt32(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "4";
            sayi = Convert.ToInt32(textBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "5";
            sayi = Convert.ToInt32(textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "6";
            sayi = Convert.ToInt32(textBox1.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "7";
            sayi = Convert.ToInt32(textBox1.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "8";
            sayi = Convert.ToInt32(textBox1.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "9";
            sayi = Convert.ToInt32(textBox1.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "-";
            op = "-";
            onceki = sayi;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            sayi = Convert.ToInt32(textBox1.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "*";
            op = "*";
            onceki = sayi;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "+";
            op = "+";
            onceki = sayi;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if(op=="+")
            {
                sonuc = onceki+sayi;
                textBox1.Text = sonuc.ToString();
            }


            if (op == "-")
            {
                sonuc = onceki - sayi;
                textBox1.Text = sonuc.ToString();
            }

            if (op == "*")
            {
                sonuc = onceki * sayi;
                textBox1.Text = sonuc.ToString();
            }

            if (op == "/")
            {
                sonuc = onceki / sayi;
                textBox1.Text = sonuc.ToString();
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "/";
            op = "/";
            onceki = sayi;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            op = "";
            sayi = 0;
        }
    }

}