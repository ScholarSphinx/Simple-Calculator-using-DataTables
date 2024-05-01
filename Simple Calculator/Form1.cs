using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayText(string addition)
        {
            textBox1.Text = textBox1.Text + addition;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            if ((textBox1.Text == "") || (text[text.Length - 1] == ' '))
            {
                MessageBox.Show("Please add a valid number first!");
            }
            else if (text[text.Length - 1] == ',')
            {
                DisplayText("0 - ");
            }
            else
            {
                DisplayText(" - ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayText("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayText("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DisplayText("3");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DisplayText("4");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DisplayText("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DisplayText("6");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DisplayText("7");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DisplayText("8");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DisplayText("9");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DisplayText("0");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            if (textBox1.Text == "")
            {
                DisplayText("0,");
            }
            else if (text[text.Length - 1] == ',')
            {               
                MessageBox.Show("Please put a number prior to adding a comma!");
            }
            else if (text[text.Length - 1] == ' ')
            {
                DisplayText("0,");
            }
            else
            {
                DisplayText(",");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            if ((textBox1.Text == "") || (text[text.Length - 1] == ' '))
            {
                MessageBox.Show("Please add a valid number first!");
            }
            else if (text[text.Length -1] == ',')
            {
                DisplayText("0 + ");
            }
            else
            {
                DisplayText(" + ");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            if ((textBox1.Text == "") || (text[text.Length - 1] == ' '))
            {
                MessageBox.Show("Please add a valid number first!");
            }
            else if (text[text.Length - 1] == ',')
            {
                DisplayText("0 * ");
            }
            else
            {
                DisplayText(" * ");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            if ((textBox1.Text == "") || (text[text.Length - 1] == ' '))
            {
                MessageBox.Show("Please add a valid number first!");
            }
            else if (text[text.Length - 1] == ',')
            {
                DisplayText("0 / ");
            }
            else
            {
                DisplayText(" / ");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string equation = textBox1.Text;

            equation = equation.Replace(',', '.');

            
            if (equation[equation.Length - 1] == ' ')
            {
                MessageBox.Show("Please add a valid number after the operander");
            }
            else if (!(equation == ""))
            {
                DataTable table = new DataTable();
                double result = Convert.ToDouble(table.Compute(equation, String.Empty));
                MessageBox.Show("The result is " + result);
            }
            else
            {
                MessageBox.Show("Please put a valid equation to work with!");
            }


            
        }
    }
}


//string equation = textBox1.Text;
//string[] numbers = equation.Split('+');
//double result = 0;
//foreach (string number in numbers)
//{
//    result += double.Parse(number);
//}

//MessageBox.Show("The result is " + result);
