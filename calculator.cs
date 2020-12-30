using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CS : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;

        public object Result { get; private set; }

        public CS()
        {

            InitializeComponent();
        }











        private void n1_Click_1(object sender, EventArgs e)
        {

            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;


        }

        private void n2_Click_1(object sender, EventArgs e)
        {

            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;

        }

        private void n3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
        }



        private void n4_Click_1(object sender, EventArgs e)
        {


            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;

        }

        private void n5_Click_1(object sender, EventArgs e)
        {

            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
        }

        private void n6_Click_1(object sender, EventArgs e)
        {

            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
        }



        private void n7_Click_1(object sender, EventArgs e)
        {

            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;

        }

        private void n8_Click_1(object sender, EventArgs e)
        {

            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;

        }

        private void n9_Click_1(object sender, EventArgs e)
        {

            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;


        }

        private void ndot_Click_1(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + ".";

        }

        private void n0_Click_1(object sender, EventArgs e)
        {

            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input;

        }

        private void nc_Click(object sender, EventArgs e)
        {

            this.textBox1.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;

        }
        private void bad_Click_1(object sender,EventArgs e)
        {
            operand1 = input;
            operation = '+';
           input = string.Empty;
        }

        private void bsub_Click_1(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }
        private void bmul_Click_1(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }
        private void bdiv_Click_1(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
        
           input = string.Empty;
        }



        private void bequal_Click(object sender, EventArgs e)
        {

            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);
            if (operation == '+')
            {
                result = num1 + num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "DIV/Zero!";
                }
            }


        }

       
    }
}

