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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int sum = num + num2;
            textBox3.Text = sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int sub = num - num2;
            textBox3.Text = sub.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int mul = num * num2;
            textBox3.Text = mul.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float num = int.Parse(textBox1.Text);
            float num2 = int.Parse(textBox2.Text);
            float div = num / num2;
            textBox3.Text = div.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
