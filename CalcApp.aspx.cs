using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyCalculator
{
    public partial class CalcApp : System.Web.UI.Page
    {
        double resultValue = 0; //session
        string operationPerformed = ""; //operation
        bool isOperationPerformed = false;
        protected void Button_click(object sender, EventArgs e)
        {
            if ((TextBox1.Text=="0") || (isOperationPerformed ))
            {
                TextBox1.Text = "";
            }

            
            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!TextBox1.Text.Contains("."))
                    TextBox1.Text = TextBox1.Text + button.Text;
            }
            else
                TextBox1.Text = TextBox1.Text + button.Text;


        }
        
        protected void perator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            resultValue = double.Parse(TextBox1.Text);
            labelCurrentOperation.Text = resultValue + " " + operationPerformed;
            isOperationPerformed = true;
            if (resultValue != 0)
            {

                operationPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {

                operationPerformed = button.Text;
                resultValue = double.Parse(TextBox1.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }
 
     
        protected void Button13_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "0";
            resultValue = 0;
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button17_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    {
                         TextBox1.Text = (resultValue + double.Parse(TextBox1.Text)).ToString();
                       // if (TextBox1.Text == "") { TextBox1.Text = "0"; }
                       
                    }
                    break;
                case "-":
                    {
                        TextBox1.Text = (resultValue - double.Parse(TextBox1.Text)).ToString();
                    }
                    break;
                case "*":
                    {
                        TextBox1.Text = (resultValue * double.Parse(TextBox1.Text)).ToString();
                    }
                    break;
                case "/":
                    {
                        TextBox1.Text = (resultValue / double.Parse(TextBox1.Text)).ToString();
                    }
                    break;
                   
            }
            resultValue = double.Parse(TextBox1.Text);
            labelCurrentOperation.Text = "";
        }
    }
}