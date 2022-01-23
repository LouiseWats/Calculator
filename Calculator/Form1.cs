using System;
using System.Globalization;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.inputLabel.ResetText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.inputLabel.Text = this.inputLabel.Text + "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.inputLabel.Text = this.inputLabel.Text + "1";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.inputLabel.Text = this.inputLabel.Text + "2";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.inputLabel.Text = this.inputLabel.Text + "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.inputLabel.Text = this.inputLabel.Text + "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.inputLabel.Text = this.inputLabel.Text + "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.inputLabel.Text = this.inputLabel.Text + "6";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.inputLabel.Text = this.inputLabel.Text + "7";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.inputLabel.Text = this.inputLabel.Text + "8";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.inputLabel.Text = this.inputLabel.Text + "9";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            this.operatorLabel.Text = "+";
            if (this.inputLabel.Text != "")
            {
                this.firstCalculate.Text = this.inputLabel.Text;
            }
            this.inputLabel.Text = "";
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            this.operatorLabel.Text = "-";
            if (this.inputLabel.Text != "")
            {
                this.firstCalculate.Text = this.inputLabel.Text;
            }
            this.inputLabel.Text = "";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            this.operatorLabel.Text = "*";
            if (this.inputLabel.Text != "")
            {
                this.firstCalculate.Text = this.inputLabel.Text;
            }
            this.inputLabel.Text = "";
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            this.operatorLabel.Text = "%";
            if (this.inputLabel.Text != "")
            {
                this.firstCalculate.Text = this.inputLabel.Text;
            }
            this.inputLabel.Text = "";
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            double firstNumber;
            double secondNumber;
            double result;

            double.TryParse(this.firstCalculate.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out firstNumber);
            double.TryParse(this.inputLabel.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out secondNumber);

            result = 0;

            this.inputLabel.Text = this.inputLabel.Text.Replace(",", ".");

            if (this.operatorLabel.Text == "+")
            {
                result = firstNumber + secondNumber;
            }

            if (this.operatorLabel.Text == "-")
            {
                result = firstNumber - secondNumber;
            }

            if (this.operatorLabel.Text == "*")
            {
                result = firstNumber * secondNumber;
            }

            if (this.operatorLabel.Text == "%")
            {
                result = firstNumber / secondNumber;
            }

            this.inputLabel.Text = result.ToString();
            this.operatorLabel.Text = "";
            this.firstCalculate.ResetText();
        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            this.inputLabel.Text = this.inputLabel.Text + ".";
        }
    }
}
