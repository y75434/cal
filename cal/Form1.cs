using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int number1 = 0;
        int number2 = 0;
        String oper = "";

        private void numClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void operClick(object sender, EventArgs e)
        {
            number1 = int.Parse(textBox1.Text);
            Button button = (Button)sender;
            oper += button.Text;
            textBox1.Text = "";
        }

        private void equalClick(object sender, EventArgs e)
        {
            number2 = int.Parse(textBox1.Text);
            int result = 0;
            switch (oper)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
            }
            textBox1.Text = result.ToString();
        }
    }
}
