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

        String number1 = "";
        String number2 = "";
        String oper = "";

        private void numClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void operClick(object sender, EventArgs e)
        {
            number1 = textBox1.Text;
            Button button = (Button)sender;
            oper += button.Text;
            textBox1.Text = "";
        }

        private void equalClick(object sender, EventArgs e)
        {
            number2 = textBox1.Text;
            int result = 0;

            //Score score = new Score();
            //score.name = "s";
            //score.Value = 600;
            //score.printScore();

            Cal cal = new Cal();
            cal.Number1 = number1;
            cal.Number2 = number2;
            cal.Oper = oper;
            result = cal.Result();
            textBox1.Text = result.ToString();
            //textBox1.Text = resultValue(number1, number2, oper).ToString();




        }

        public int resultValue(String number1,String number2,String oper)
        {
            return 0;
        }
    }
}
