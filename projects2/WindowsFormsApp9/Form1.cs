using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, sqr, x1, x2;
            a = Convert.ToDouble(textBox11.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);

            sqr = (b * b) - ((4) * (a) * (c));
            x1 = ((((-1) * (b)) + (sqr)) / ((2) * (a)));
            x2 = ((((-1) * (b)) - (sqr)) / ((2) * (a)));

            label1.Text = x1.ToString();
            label2.Text = x2.ToString();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
