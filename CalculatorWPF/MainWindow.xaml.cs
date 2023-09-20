using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace CalculatorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double firstNumber = 0;
        private double secondNumber = 0;
        private string operation = "";
        private string point = "";
        double result = 0.0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void buttonC_Click(object sender, RoutedEventArgs e)
        {
            previousOperationsTextBox.Text = "";
            currentNumberTextBox.Text = "";
        }

        private void buttonDeleteSymbol_Click(object sender, RoutedEventArgs e)
        {
            if (currentNumberTextBox.Text.Length > 0)
            {
                currentNumberTextBox.Text = currentNumberTextBox.Text.Substring(0, currentNumberTextBox.Text.Length - 1);
                previousOperationsTextBox.Text = previousOperationsTextBox.Text.Substring(0, previousOperationsTextBox.Text.Length - 1);
            }
        }
        private void buttonNegativePositive_Click(object sender, RoutedEventArgs e)
        {
            if (currentNumberTextBox.Text.Length > 0)
            {
                double number = double.Parse(currentNumberTextBox.Text.Replace(',', '.'), CultureInfo.InvariantCulture);
                number = -number;
                currentNumberTextBox.Text = number.ToString();
                previousOperationsTextBox.Text = number.ToString();
            }
        }
        private void buttonMinus_Click(object sender, RoutedEventArgs e)
        {
            if (currentNumberTextBox.Text.Length == 0)
            {
                currentNumberTextBox.Text += "-";
                previousOperationsTextBox.Text += "-";
            }
            else if (currentNumberTextBox.Text == "-")
            {
            }
            else
            {
                firstNumber = double.Parse(currentNumberTextBox.Text.Replace(',', '.'), CultureInfo.InvariantCulture);
                currentNumberTextBox.Text += "-";
                previousOperationsTextBox.Text += "-";
                operation = "-";
            }
        }
        private void buttonPlus_Click(object sender, RoutedEventArgs e)
        {
            if (currentNumberTextBox.Text.Length > 0)
            {
                currentNumberTextBox.Text += "+";
                previousOperationsTextBox.Text += "+";
                operation = "+";
                point = "";
            }
        }
        private void buttonMultiply_Click(object sender, RoutedEventArgs e)
        {
            if (currentNumberTextBox.Text.Length > 0)
            {
                firstNumber = double.Parse(currentNumberTextBox.Text);
                currentNumberTextBox.Text += "*";
                previousOperationsTextBox.Text += "*";
                operation = "*";
                point = "";
            }
        }
        private void buttonDivide_Click(object sender, RoutedEventArgs e)
        {
            if (currentNumberTextBox.Text.Length > 0)
            {
                firstNumber = double.Parse(currentNumberTextBox.Text);
                currentNumberTextBox.Text += "/";
                previousOperationsTextBox.Text += "/";
                operation = "/";
                point = "";
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (result == 0.0 && operation == "" && point != "." && currentNumberTextBox.Text.ToString() == "")
            {
                currentNumberTextBox.Text = "1";
                previousOperationsTextBox.Text = "1";
            }
            else if (operation == "" && result != 0.0 && point == "")
            {
                currentNumberTextBox.Text = "";
                previousOperationsTextBox.Text = "";
                currentNumberTextBox.Text = "1";
                previousOperationsTextBox.Text = "1";
            }
            else
            {
                currentNumberTextBox.Text += "1";
                previousOperationsTextBox.Text += "1";
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (result == 0.0 && operation == "" && point != "." && currentNumberTextBox.Text.ToString() == "")
            {
                currentNumberTextBox.Text = "2";
                previousOperationsTextBox.Text = "2";
            }
            else if (operation == "" && result != 0.0 && point == "")
            {
                currentNumberTextBox.Text = "";
                previousOperationsTextBox.Text = "";
                currentNumberTextBox.Text = "2";
                previousOperationsTextBox.Text = "2";
            }
            else
            {
                currentNumberTextBox.Text += "2";
                previousOperationsTextBox.Text += "2";
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (result == 0.0 && operation == "" && point != "." && currentNumberTextBox.Text.ToString() == "")
            {
                currentNumberTextBox.Text = "3";
                previousOperationsTextBox.Text = "3";
            }
            else if (operation == "" && result != 0.0 && point == "")
            {
                currentNumberTextBox.Text = "";
                previousOperationsTextBox.Text = "";
                currentNumberTextBox.Text = "3";
                previousOperationsTextBox.Text = "3";
            }
            else
            {
                currentNumberTextBox.Text += "3";
                previousOperationsTextBox.Text += "3";
            }
        }
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (result == 0.0 && operation == "" && point != "." && currentNumberTextBox.Text.ToString() == "")
            {
                currentNumberTextBox.Text = "4";
                previousOperationsTextBox.Text = "4";
            }
            else if (operation == "" && result != 0.0 && point == "")
            {
                currentNumberTextBox.Text = "";
                previousOperationsTextBox.Text = "";
                currentNumberTextBox.Text = "4";
                previousOperationsTextBox.Text = "4";
            }
            else
            {
                currentNumberTextBox.Text += "4";
                previousOperationsTextBox.Text += "4";
            }
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (result == 0.0 && operation == "" && point != "." && currentNumberTextBox.Text.ToString() == "")
            {
                currentNumberTextBox.Text = "5";
                previousOperationsTextBox.Text = "5";
            }
            else if (operation == "" && result != 0.0 && point == "")
            {
                currentNumberTextBox.Text = "";
                previousOperationsTextBox.Text = "";
                currentNumberTextBox.Text = "5";
                previousOperationsTextBox.Text = "5";
            }
            else
            {
                currentNumberTextBox.Text += "5";
                previousOperationsTextBox.Text += "5";
            }
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (result == 0.0 && operation == "" && point != "." && currentNumberTextBox.Text.ToString() == "")
            {
                currentNumberTextBox.Text = "6";
                previousOperationsTextBox.Text = "6";
            }
            else if (operation == "" && result != 0.0 && point == "")
            {
                currentNumberTextBox.Text = "";
                previousOperationsTextBox.Text = "";
                currentNumberTextBox.Text = "6";
                previousOperationsTextBox.Text = "6";
            }
            else
            {
                currentNumberTextBox.Text += "6";
                previousOperationsTextBox.Text += "6";
            }
        }
        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (result == 0.0 && operation == "" && point != "." && currentNumberTextBox.Text.ToString() == "")
            {
                currentNumberTextBox.Text = "7";
                previousOperationsTextBox.Text = "7";
            }
            else if (operation == "" && result != 0.0 && point == "")
            {
                currentNumberTextBox.Text = "";
                previousOperationsTextBox.Text = "";
                currentNumberTextBox.Text = "7";
                previousOperationsTextBox.Text = "7";
            }
            else
            {
                currentNumberTextBox.Text += "7";
                previousOperationsTextBox.Text += "7";
            }
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (result == 0.0 && operation == "" && point != "." && currentNumberTextBox.Text.ToString() == "")
            {
                currentNumberTextBox.Text = "8";
                previousOperationsTextBox.Text = "8";

            }
            else if (operation == "" && result != 0.0 && point == "")
            {
                currentNumberTextBox.Text = "";
                previousOperationsTextBox.Text = "";
                currentNumberTextBox.Text = "8";
                previousOperationsTextBox.Text = "8";
            }
            else
            {
                currentNumberTextBox.Text += "8";
                previousOperationsTextBox.Text += "8";
            }
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            if (result == 0.0 && operation == "" && point != "." && currentNumberTextBox.Text.ToString() == "")
            {
                currentNumberTextBox.Text = "9";
            }
            else if (operation == "" && result != 0.0 && point == "")
            {
                currentNumberTextBox.Text = "";
                previousOperationsTextBox.Text = "";
                currentNumberTextBox.Text = "9";
                previousOperationsTextBox.Text = "9";
            }
            else
            {
                currentNumberTextBox.Text += "9";
                previousOperationsTextBox.Text += "9";
            }
        }
        private void button0_Click(object sender, RoutedEventArgs e)
        {
            if (result == 0.0 && operation == "" && point != "." && currentNumberTextBox.Text.ToString() == "")
            {
                currentNumberTextBox.Text = "0";
            }
            else if (operation == "" && result != 0.0 && point == "")
            {
                currentNumberTextBox.Text = "";
                previousOperationsTextBox.Text = "";
                currentNumberTextBox.Text = "0";
                previousOperationsTextBox.Text = "0";
            }
            else
            {
                currentNumberTextBox.Text += "0";
                previousOperationsTextBox.Text += "0";
            }
        }

        private void buttonPoint_Click(object sender, RoutedEventArgs e)
        {
            point = ".";
            currentNumberTextBox.Text += ".";
            previousOperationsTextBox.Text += ".";
        }

        private void buttonEquals_Click(object sender, RoutedEventArgs e)
        {
            if (currentNumberTextBox.Text.Length > 0 && operation != "")
            {
                if (currentNumberTextBox.Text[0] == '-')
                {
                    string[] numbers = currentNumberTextBox.Text.Substring(1).Split(operation);
                    if (numbers.Length == 2)
                    {
                        firstNumber = -double.Parse(numbers[0].Replace(',', '.'), CultureInfo.InvariantCulture);
                        secondNumber = double.Parse(numbers[1].Replace(',', '.'), CultureInfo.InvariantCulture);
                        switch (operation)
                        {
                            case "+":
                                result = firstNumber + secondNumber;
                                point = "";
                                break;
                            case "-":
                                result = firstNumber - secondNumber;
                                point = "";
                                break;
                            case "*":
                                result = firstNumber * secondNumber;
                                point = "";
                                break;
                            case "/":
                                result = firstNumber / secondNumber;
                                point = "";
                                break;
                            default:
                                result = 0.0;
                                break;
                        }
                        currentNumberTextBox.Text = result.ToString();
                        operation = "";
                    }
                }
                else
                {
                    string[] numbers = currentNumberTextBox.Text.Split(operation);
                    if (numbers.Length == 2)
                    {
                        firstNumber = double.Parse(numbers[0].Replace(',', '.'), CultureInfo.InvariantCulture);
                        secondNumber = double.Parse(numbers[1].Replace(',', '.'), CultureInfo.InvariantCulture);
                        switch (operation)
                        {
                            case "+":
                                result = firstNumber + secondNumber;
                                point = "";
                                break;
                            case "-":
                                result = firstNumber - secondNumber;
                                point = "";
                                break;
                            case "*":
                                result = firstNumber * secondNumber;
                                point = "";
                                break;
                            case "/":
                                result = firstNumber / secondNumber;
                                point = "";
                                break;
                            default:
                                result = 0.0;
                                break;
                        }
                        currentNumberTextBox.Text = result.ToString();
                        previousOperationsTextBox.Text += " = " + result.ToString();
                        operation = "";
                    }
                }
            }
        }
    }
}
