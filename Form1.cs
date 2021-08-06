using System;
using System.Windows.Forms;

namespace Calculator_WinForm
{
    public partial class Form1 : Form
    {
        public string Action;
        public string FirstNumGroup;
        public bool SecondNumGroup;
        public Form1()
        {
            InitializeComponent();
        }

        private void Num0_Click(object sender, EventArgs e)
        {
            if (SecondNumGroup == true)
            {
                SecondNumGroup = false;
                textBox1.Text = "0";
            }
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text == "0" ? b.Text : textBox1.Text + b.Text;
        }

        private void GlobalClear_Click(object sender, EventArgs e)
        {
            SecondNumGroup = true;
            FirstNumGroup = null;
            textBox1.Text = "0";
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            Action = B.Text;
            FirstNumGroup = textBox1.Text;
            textBox1.Text = "";
            SecondNumGroup = true;
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            double num1, num2, result;
            result = 0;
            num1 = FirstNumGroup == null ? 0 : double.Parse(FirstNumGroup) ;
            num2 = double.Parse(textBox1.Text);
            switch (Action)
            {
                case "+":
                    result = num1 + num2;
                        break;
                case "-":
                    result = num1 - num2;
                    break;
                case "✕":
                    result = num1 * num2;
                    break;
                case "÷":
                    result = num1 / num2;
                    break;
                case "%":
                    result = num1 * num2 / 100;
                    break;
                default:
                    break;
            }
            textBox1.Text = result.ToString();
        }

        private void Root_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Sqrt(double.Parse(textBox1.Text)).ToString();
        }

        private void Negate_Click(object sender, EventArgs e)
        {
            textBox1.Text = (-double.Parse(textBox1.Text)).ToString();
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Contains(".") ? textBox1.Text : textBox1.Text + ".";
        }

        private void RemoveSymbol_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text == "" ^ textBox1.TextLength == 1 ? "0" : textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

        private void CurrentClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void Square_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Pow(double.Parse(textBox1.Text), 2).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = (1 / double.Parse(textBox1.Text)).ToString();
        }
    }
}
