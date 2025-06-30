using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarkiFelek
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
           // Form1 form1 = new Form1();
         
            if (checkBox1.Checked)
            {
                Form1.Tur = "1";
            }
            else if (checkBox2.Checked)
            {
                Form1.Tur = "2";
            }
            else if (checkBox3.Checked)
            {
                Form1.Tur = "3";
            }           
           
            
            this.Close();
            
        }

       
    }
}
