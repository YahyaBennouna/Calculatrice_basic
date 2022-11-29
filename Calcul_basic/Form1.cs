using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calcul_basic
{
    public partial class Form1 : Form
    {
        char op;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "0";
            else
                textBox1.Text += "0";
        }

        private void BtnV_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void BtnEgale_Click(object sender, EventArgs e)
        {
            double resultat1 = 0;
            string[] operation = textBox1.Text.Split(op);
            switch (op)
            {
                case '+': resultat1 = double.Parse(operation[0]) + double.Parse(operation[1]); break;
                case '-': resultat1 = double.Parse(operation[0]) - double.Parse(operation[1]); break;
                case '/': resultat1 = double.Parse(operation[0]) / double.Parse(operation[1]); break;
                case 'x': resultat1 = double.Parse(operation[0]) * double.Parse(operation[1]); break;
                case '@': resultat1 = (Convert.ToDouble(textBox1.Text)* Convert.ToDouble(textBox1.Text)); break;
                case '√': resultat1 = (Math.Sqrt(Double.Parse(textBox1.Text))); break;
               
               

            }

            textBox1.Text = resultat1.ToString();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "1";
            else
                textBox1.Text += "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "2";
            else
                textBox1.Text += "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "3";
            else
                textBox1.Text += "3";
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
            op = '+';
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "4";
            else
                textBox1.Text += "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "5";
            else
                textBox1.Text += "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "6";
            else
                textBox1.Text += "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "7";
            else
                textBox1.Text += "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "8";
            else
                textBox1.Text += "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "9";
            else
                textBox1.Text += "9";
        }

        private void BtnM_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
            op = '-';
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            textBox1.Text += "x";
            op = 'x';
        }

        private void BtbnSpaceM_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            if (textBox1.Text == String.Empty) textBox1.Text = "0";
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void BtnCarre_Click(object sender, EventArgs e)
        {
            textBox1.Text += "^2";
             op = '@';

        }

        private void BtnRacine_Click(object sender, EventArgs e)
        {
            textBox1.Text += "√";
            op = '√';
        }

        private void BtnPOU_Click(object sender, EventArgs e)
        {
            textBox1.Text += "%";

            textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) / 100);

        }

        private void BtnPm_Click(object sender, EventArgs e)
        {
           
            textBox1.Text =Convert.ToString(-1 * Convert.ToDouble(textBox1.Text)) ; 
          
        }

        private void Btn1X_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(1.0 / Convert.ToDouble(textBox1.Text));
        }
    }
}
