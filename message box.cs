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
    public partial class Form3 : Form
    {
        int x;
        int y;
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = Int32.Parse(textBox1.Text);
            y = Int32.Parse(textBox2.Text);
            int z = x + y;
            //MessageBox.Show("Result:" + z);
            textBox3.Text = z.ToString();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            String val1 = textBox1.Text;
            String val2 = textBox2.Text;
            if (val1.Trim().Equals("") || val2.Trim().Equals(""))
            {
                DialogResult dresult = MessageBox.Show("Are you sure ", "Alert"
                              , MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (dresult == DialogResult.OK)
                {
                    
                    int x = 100;
                    int y = 100;
                    int z = 100;
                    textBox1.Text = x.ToString();
                    textBox2.Text = y.ToString();
                    textBox3.Text = z.ToString();
                }
                else
                {
                    int x = 0;
                    int y = 0;
                    int z = 0;
                    textBox1.Text = x.ToString();
                    textBox2.Text = y.ToString();
                    textBox3.Text = z.ToString();
                }
            }
        }
    }
    }

