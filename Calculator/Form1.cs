using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {   
        public Form1()
        {
            InitializeComponent();
        }

        float a, b;
        int count;
        bool znak = true;

        private void button2_Click(object sender, EventArgs e)
        {
            a = float.Parse(Vvod.Text);
            Vvod.Clear();
            count = 1;
            Vvod.Text = a.ToString() + "+";
            znak = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = float.Parse(Vvod.Text);
            Vvod.Clear();
            count = 2;
            label1.Text = a.ToString() + "-";
            znak = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            a = float.Parse(Vvod.Text);
            Vvod.Clear();
            count = 4;
            label1.Text = a.ToString() + "/";
            znak = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = float.Parse(Vvod.Text);
            Vvod.Clear();
            count = 3;
            label1.Text = a.ToString() + "*";
            znak = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            string vvod = Vvod.Text;
            Vvod.Text = vvod.ToString() + "1";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string vvod = Vvod.Text;
            Vvod.Text = vvod.ToString() + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string vvod = Vvod.Text;
            Vvod.Text = vvod.ToString() + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string vvod = Vvod.Text;
            Vvod.Text = vvod.ToString() + "9";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string vvod = Vvod.Text;
            Vvod.Text = vvod.ToString() + "4";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            string vvod = Vvod.Text;
            Vvod.Text = vvod.ToString() + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string vvod = Vvod.Text;
            Vvod.Text = vvod.ToString() + "6";
        }

        private void button00_Click(object sender, EventArgs e)
        {
            string vvod = Vvod.Text;
            Vvod.Text = vvod.ToString() + ",";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string vvod = Vvod.Text;
            Vvod.Text = vvod.ToString() + "2";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string vvod = Vvod.Text;
            Vvod.Text = vvod.ToString() + "3";
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Vvod.Text = "";
            label1.Text = "";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            string vvod = Vvod.Text;
            Vvod.Text = vvod.ToString() + "0";
        }

        private void buttonPM_Click(object sender, EventArgs e)
        {
            switch (znak)
            {
                case true:
                    Vvod.Text = "-" + Vvod.Text;
                    znak = false;
                    break;

                case false:
                    Vvod.Text = "+" + Vvod.Text;
                    znak = true;
                    break;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int leight = Vvod.Text.Length - 1;
            string vvod = Vvod.Text;
            Vvod.Clear();
            for (int i = 0; i < leight; i++)
            {
                Vvod.Text = Vvod.Text + Text[i];
            }

        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }

        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(Vvod.Text);
                    Vvod.Text = b.ToString();
                    break;

                case 2:
                    b = a - float.Parse(Vvod.Text);
                    Vvod.Text = b.ToString();
                    break;

                case 3:
                    b = a * float.Parse(Vvod.Text);
                    Vvod.Text = b.ToString();
                    break;

                case 4:
                    b = a / float.Parse(Vvod.Text);
                    Vvod.Text = b.ToString();
                    break;

                default:
                    break;
            }

        }

        private void Vvod_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
