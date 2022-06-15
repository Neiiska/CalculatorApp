using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculatorApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string first = "";
        string second = "";
        char function;
        double result = 0.0;
        string userInput = "";




        public MainWindow()
        {
            InitializeComponent();
        }


        private void num1_Click(object sender, RoutedEventArgs e)
        {
            //it is clearing the previous input from the display
            calculatorDisplay.Content = "";
            userInput += "1";
            calculatorDisplay.Content += userInput;
        }

        private void num2_Click(object sender, RoutedEventArgs e)
        {
            calculatorDisplay.Content = "";
            userInput += "2";
            calculatorDisplay.Content += userInput;
        }

        private void num3_Click(object sender, RoutedEventArgs e)
        {
            calculatorDisplay.Content = "";
            userInput += "3";
            calculatorDisplay.Content += userInput;
        }

        private void num4_Click(object sender, RoutedEventArgs e)
        {
            calculatorDisplay.Content = "";
            userInput += "4";
            calculatorDisplay.Content += userInput;
        }

        private void num5_Click(object sender, RoutedEventArgs e)
        {
            calculatorDisplay.Content = "";
            userInput += "5";
            calculatorDisplay.Content += userInput;
        }

        private void num6_Click(object sender, RoutedEventArgs e)
        {
            calculatorDisplay.Content = "";
            userInput += "6";
            calculatorDisplay.Content += userInput;
        }

        private void num7_Click(object sender, RoutedEventArgs e)
        {
            calculatorDisplay.Content = "";
            userInput += "7";
            calculatorDisplay.Content += userInput;
        }

        private void num8_Click(object sender, RoutedEventArgs e)
        {
            calculatorDisplay.Content = "";
            userInput += "8";
            calculatorDisplay.Content += userInput;
        }

        private void num9_Click(object sender, RoutedEventArgs e)
        {
            calculatorDisplay.Content = "";
            userInput += "9";
            calculatorDisplay.Content += userInput;
        }

        private void num0_Click(object sender, RoutedEventArgs e)
        {
            calculatorDisplay.Content = "";
            userInput += "0";
            calculatorDisplay.Content += userInput;
        }

        private void dot_Click(object sender, RoutedEventArgs e)
        {
            calculatorDisplay.Content = "";
            userInput += ".";
            calculatorDisplay.Content += userInput;
        }

        private void equal_Click(object sender, RoutedEventArgs e)
        {
            
            second = userInput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);

            //Plus
            if (function == '+')
            {
                result = firstNum + secondNum;
                calculatorDisplay.Content = result.ToString();
            }
            //Minus
            else if(function == '-')
            {
                result = firstNum - secondNum;
                calculatorDisplay.Content = result.ToString();
            }
            //Divide
            else if(function == '/')
            {
                if (secondNum == 0.0)
                {
                    calculatorDisplay.Content = "You can't divide by 0";
                }
                else
                {
                    result = firstNum / secondNum;
                    calculatorDisplay.Content = result.ToString();
                }
            }
            //Multiply
            else if (function == '*')
            {
                result = firstNum * secondNum;
                calculatorDisplay.Content = result.ToString();
            }
            //Percent
            else if (function == '%')
            {
                result = firstNum / 100 * secondNum ;
                calculatorDisplay.Content = result.ToString();
            }


        }

        private void addition_Click(object sender, RoutedEventArgs e)
        {
            function = '+';
            first = userInput;
            userInput = "";
        }

        private void subtract_Click(object sender, RoutedEventArgs e)
        {
            function = '-';
            first = userInput;
            userInput = "";
        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            function = '*';
            first = userInput;
            userInput = "";
        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            function = '/';
            first = userInput;
            userInput = "";
        }

        private void percent_Click(object sender, RoutedEventArgs e)
        {
            function = '%';
            first = userInput;
            userInput = "";
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            
            first = "";
            second = "";
            userInput = "";
            result = 0.0;
            calculatorDisplay.Content = "0";
        }


    }
}
