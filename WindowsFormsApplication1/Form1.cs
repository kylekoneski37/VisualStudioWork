using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
           
            if((textBox1.Text == "0") || (isOperationPerformed))
                 textBox1.Clear();
            
            isOperationPerformed = false;
            Button button = (Button)sender;
            if(button.Text == ".")
            {
               if(!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + button.Text;
            }else
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
         
            Button button = (Button)sender;
            if (resultValue != 0)
            {
                button5.PerformClick();
                operationPerformed = button.Text;
                labelCurrent.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {

                operationPerformed = button.Text;
                resultValue = Double.Parse(textBox1.Text);
                labelCurrent.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resultValue = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            switch(operationPerformed)
            {
                case "+":
                    textBox1.Text = (resultValue + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "X":
                    textBox1.Text = (resultValue * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (resultValue - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (resultValue / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(textBox1.Text);
            labelCurrent.Text = "";
        }

        private void labelCurrentOperation(object sender, EventArgs e)
        {

        }
    }
}
