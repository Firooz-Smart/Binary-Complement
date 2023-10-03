using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Complement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            Complementor com = new Complementor();
            try
            {
                if (isValidate(long.Parse(textBox1.Text), 2))
                {
                    textBox2.Text = com.doComplement(long.Parse(textBox1.Text), 1);
                    textBox3.Text = com.doComplement(long.Parse(textBox1.Text), 2);
                    lblerr.Text = "";
                }
                else
                    lblerr.Text = "Not in base 2 !";
            }
            catch
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
         }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        public  Boolean isValidate(long number, int b)
        {
            while (number != 0)
            {
                if (number % 10 > b - 1)
                {
                    return false;
                }
                else
                    number /= 10;

            }


            return true;
        }

    }
}
