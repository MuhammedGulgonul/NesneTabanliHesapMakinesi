using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void btntoplama_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                int s2 = Convert.ToInt32(textBox1.Text);
                lblsonuc.Text = s2.ToString();
            }
           
            textBox1.Clear();
           
            lblislem.Text = "+";


        }

        public void btncikarma_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int s2 = Convert.ToInt32(textBox1.Text);
                lblsonuc.Text = s2.ToString();
            }
            textBox1.Clear();
            
            lblislem.Text = "-";
        }
        private void btnbolme_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int s2 = Convert.ToInt32(textBox1.Text);
                lblsonuc.Text = s2.ToString();
            }
            textBox1.Clear();
            
            lblislem.Text = "/";
        }
        private void btncarpma_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int s2 = Convert.ToInt32(textBox1.Text);
                lblsonuc.Text = s2.ToString();
            }
            textBox1.Clear();
            
            lblislem.Text = "x";
        }

       

        private void btnsifir_Click(object sender, EventArgs e)
        {
            lblsonuc.Text = "0";
            textBox1.Clear();

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text=textBox1.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void btnsonuc_Click(object sender, EventArgs e)
        {
            if(lblislem.Text== "x")
            {
                int s1 = Convert.ToInt32(lblsonuc.Text);
                int s2 = Convert.ToInt32(textBox1.Text);
                int sonuc = s1 * s2;
                textBox1.Clear();
                lblsonuc.Text = sonuc.ToString();
                lblislem.Text = "x";
            }
            else if (lblislem.Text == "+")
            {
                int s1 = Convert.ToInt32(lblsonuc.Text);
                int s2 = Convert.ToInt32(textBox1.Text);
                int sonuc = s1 + s2;
                textBox1.Clear();
                lblsonuc.Text = sonuc.ToString();
                lblislem.Text = "+";
            }
            else if (lblislem.Text == "-")
            {
                int s1 = Convert.ToInt32(lblsonuc.Text);
                int s2 = Convert.ToInt32(textBox1.Text);
                int sonuc = s1 - s2;
                textBox1.Clear();
                lblsonuc.Text = sonuc.ToString();
                lblislem.Text = "-";
            }
            else if (lblislem.Text == "/")
            {
                int s1 = Convert.ToInt32(lblsonuc.Text);
                int s2 = Convert.ToInt32(textBox1.Text);
                int sonuc = s1 / s2;
                textBox1.Clear();
                lblsonuc.Text = sonuc.ToString();
                lblislem.Text = "/";
            }
        }
    }
}
