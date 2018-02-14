using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double result = 0;
        string operatorClicked = " ";
        bool isOperatorClicked = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            resultValueTB.Clear();
            result = 0;
        }

        private void click_button(object sender, EventArgs e)
        {
            if (resultValueTB.Text == "0" || (isOperatorClicked))
                 resultValueTB.Clear();

            isOperatorClicked = false;
            Button button = (Button)sender;

            if (button.Text == ".")
            {
                if (!resultValueTB.Text.Contains("."))
                    resultValueTB.Text = resultValueTB + button.Text;

            }

                else

                resultValueTB.Text = resultValueTB.Text + button.Text;
        }

         private void click_operator(object sender, EventArgs e)
        {

            Button button = (Button)sender;

            if (result != 0)
            {
                equalBTN.PerformClick();
                operatorClicked = button.Text;
                isOperatorClicked = true;
            }
            else
            {
                operatorClicked = button.Text;
                result = Double.Parse(resultValueTB.Text);
                isOperatorClicked = true;
            }

            operatorClicked = button.Text;
            result = Double.Parse(resultValueTB.Text);
        }

        private void equalBTN_Click(object sender, EventArgs e)
        {
            switch (operatorClicked)

            {
                case "+":
                    resultValueTB.Text = (result + Double.Parse(resultValueTB.Text)).ToString();
                    break;
                case "-":
                    resultValueTB.Text = (result - Double.Parse(resultValueTB.Text)).ToString();
                    break;
                case "*":
                    resultValueTB.Text = (result * Double.Parse(resultValueTB.Text)).ToString();
                    break;
                case "/":
                    resultValueTB.Text = (result / Double.Parse(resultValueTB.Text)).ToString();
                    break;
                default:
                    break;

            }
        }
    }
}
