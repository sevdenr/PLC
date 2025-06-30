using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace CarkiFelek
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // form1 = new Form1();

            if (checkBox1.Checked)
            {
                Form1.ZorlukSeviyesi = "1";
            }

            else if (checkBox2.Checked)
            {
                Form1.ZorlukSeviyesi = "2";
            }

            else if (checkBox3.Checked)
            {
                Form1.ZorlukSeviyesi = "3";
            }

            else if (checkBox4.Checked)
            {
                Form1.ZorlukSeviyesi = "4";
            }

            else if (checkBox5.Checked)
            {
                Form1.ZorlukSeviyesi = "5";
            }

            else
            {
                Form1.ZorlukSeviyesi = "0";
            }
            this.Close(); // H
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
