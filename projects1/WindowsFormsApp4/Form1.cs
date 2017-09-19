using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "";
        bool operation_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((sonuç.Text == "0")||(operation_pressed))
                sonuç.Clear();
            operation_pressed = false;
            Button b = (Button)sender;
            sonuç.Text = sonuç.Text + b.Text;

        }

        private void button18_Click(object sender, EventArgs e)
        {
            sonuç.Clear();
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = double.Parse(sonuç.Text);
            operation_pressed = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
          switch (operation)
            {
                case "+":
                    sonuç.Text = (value + double.Parse(sonuç.Text)).ToString();
                    break;
                case "-":
                    sonuç.Text = (value - double.Parse(sonuç.Text)).ToString();
                    break;
                case "*":
                    sonuç.Text = (value * double.Parse(sonuç.Text)).ToString();
                    break;
                case "/":
                    sonuç.Text = (value / double.Parse(sonuç.Text)).ToString();
                    break;
                default:
                    break;
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            sonuç.Clear();
            value = 0;

        }
    }
}
