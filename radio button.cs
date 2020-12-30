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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //radioButton1.Checked = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                MessageBox.Show("You have selected CSE !! ");
                return;
            }
            else if (radioButton2.Checked == true)
            {
                MessageBox.Show("You have selected ISE!! ");
                return;
            }
            else if (radioButton3.Checked == true)
            {
                MessageBox.Show("You have selected MECH!! ");
                return;
            }
            else if (radioButton4.Checked == true)
            {
                MessageBox.Show("You have selected EC!! ");
                return;
            }
            else
            {
                MessageBox.Show("Not SELECTED!! ");
                return;
            }
        }
    }
}
