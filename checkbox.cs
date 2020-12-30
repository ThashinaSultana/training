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
    public partial class checkbox : Form
    {
        public checkbox()
        {
            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = "";

            if (checkBox1.Checked == true)
            {
                msg = "MBBS";
            }

            if (checkBox2.Checked == true)
            {
                msg = msg +
                    "  BTECH";
            }
            if (checkBox3.Checked == true)
            {
                msg = msg +
                    " and MCA";
            }
            if (msg.Length > 0)
            {
                MessageBox.Show(msg + "selected");
            }
            else
            {
                MessageBox.Show("No checkbox selected");
            }




        }
    }
}
