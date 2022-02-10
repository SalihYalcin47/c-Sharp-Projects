using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.Yellow;
            button2.BackColor = Color.Yellow;
            button3.BackColor = Color.Yellow;
            button4.BackColor = Color.Red;
            button5.BackColor = Color.Yellow;
            button6.BackColor = Color.Yellow;
            button7.BackColor = Color.Yellow;
            button8.BackColor = Color.Red;
            button9.BackColor = Color.Yellow;
            button10.BackColor = Color.Yellow;
            this.BackColor = Color.ForestGreen;
            button11.BackColor = Color.Yellow;
            button12.BackColor = Color.DarkOrange;
            button13.BackColor = Color.Orange;
            button14.BackColor = Color.White;
            button15.BackColor = Color.White;
            button16.BackColor = Color.White;
            button17.BackColor = Color.White;
            button18.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.TextLength - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++) textBox1.Text = textBox1.Text + text[i];
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }
        double sayi1, sayi2;
        int count;
        string text1, text2;

        private void button17_Click(object sender, EventArgs e)
        {
            count = 3;
            text1 = textBox1.Text;
            sayi1 = Convert.ToDouble(text1);
            textBox1.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            count = 4;
            text1 = textBox1.Text;
            sayi1 = Convert.ToDouble(text1);
            textBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                text2 = textBox1.Text;
                sayi2 = Convert.ToDouble(text2);
                textBox1.Clear();
                textBox1.Text = (sayi1 + sayi2).ToString();
            }
            else if (count == 2)
            {
                text2 = textBox1.Text;
                sayi2 = Convert.ToDouble(text2);
                textBox1.Clear();
                textBox1.Text = (sayi1 - sayi2).ToString();
            }
            else if (count == 3)
            {
                text2 = textBox1.Text;
                sayi2 = Convert.ToDouble(text2);
                textBox1.Clear();
                textBox1.Text = (sayi1 * sayi2).ToString();
            }
            else if (count == 4)
            {
                text2 = textBox1.Text;
                sayi2 = Convert.ToDouble(text2);
                textBox1.Clear();
                textBox1.Text = (sayi1 / sayi2).ToString();
            }
            else
            {
                MessageBox.Show("Yanlış Islem...");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            count = 2;
            text1 = textBox1.Text;
            sayi1 = Convert.ToDouble(text1);
            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            count = 1;
            text1 = textBox1.Text;
            sayi1 = Convert.ToDouble(text1);
            textBox1.Clear();
        }

    }
}
