using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul2_1302200097
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text == "1";
            }
            else
            {
                label1.Text == label1.Text + "1";
            }
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text == "2";
            }
            else
            {
                label1.Text == label1.Text + "2";
            }
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text == "3";
            }
            else
            {
                label1.Text == label1.Text + "3";
            }
        }

        private void button8_MouseClick(object sender, MouseEventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text == "4";
            }
            else
            {
                label1.Text == label1.Text + "4";
            }
        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text == "5";
            }
            else
            {
                label1.Text == label1.Text + "5";
            }
        }

        private void button7_MouseClick(object sender, MouseEventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text == "6";
            }
            else
            {
                label1.Text == label1.Text + "6";
            }
        }

        private void button10_MouseClick(object sender, MouseEventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text == "7";
            }
            else
            {
                label1.Text == label1.Text + "7";
            }
        }

        private void button6_MouseClick(object sender, MouseEventArgs e)
        {
            if (label1.Text == 0 && label1.Text != null)
            {
                label1.Text == "8";
            }
            else
            {
                label1.Text == label1.Text + "8";
            }
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            if (label1.Text == 0 && label1.Text != null)
            {
                label1.Text == "9";
            }
            else
            {
                 = label1.Text == label1.Text + "9";
            }
        }

        private void button9_MouseClick(object sender, MouseEventArgs e)
        {
            this.label1.Text = this.label1.Text + "0";
        }

        private void button12_MouseClick(object sender, MouseEventArgs e)
        {
            FirstNumber = Convert.ToDouble(label1.Text);
            label1.Text = "0";
            Operation = "+";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double Secondnumber;
            double Result;

            Secondnumber = Convert.ToDouble(label1.Text);

            if (Operation == "+")
            {
                Result = (Firstnumber + Secondnumber);
                label1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
        }
    }
}
