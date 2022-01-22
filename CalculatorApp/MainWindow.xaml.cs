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
        private string operation;
        private float n1, n2;
        private bool resultOn = false;
        private bool errorOn = false;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ClearInput(object sender, RoutedEventArgs e)
        {
            numberInput.Text = "";
        }
        private void SevenPressed(object sender, RoutedEventArgs e)
        {
            if (resultOn || errorOn)
            {
                resultOn = false;
                numberInput.Text = "";
                errorOn = false;
            }
            numberInput.Text += "7";
        }
        private void EightPressed(object sender, RoutedEventArgs e)
        {
            if (resultOn || errorOn)
            {
                resultOn = false;
                numberInput.Text = "";
                errorOn = false;
            }
            numberInput.Text += "8";
        }
        private void NinePressed(object sender, RoutedEventArgs e)
        {
            if (resultOn || errorOn)
            {
                resultOn = false;
                numberInput.Text = "";
                errorOn = false;
            }
            numberInput.Text += "9";
        }
        private void FourPressed(object sender, RoutedEventArgs e)
        {
            if (resultOn || errorOn)
            {
                resultOn = false;
                numberInput.Text = "";
                errorOn = false;
            }
            numberInput.Text += "4";
        }
        private void FivePressed(object sender, RoutedEventArgs e)
        {
            if (resultOn || errorOn)
            {
                resultOn = false;
                numberInput.Text = "";
                errorOn = false;
            }
            numberInput.Text += "5";
        }
        private void SixPressed(object sender, RoutedEventArgs e)
        {
            if (resultOn || errorOn)
            {
                resultOn = false;
                numberInput.Text = "";
                errorOn = false;
            }
            numberInput.Text += "6";
        }
        private void OnePressed(object sender, RoutedEventArgs e)
        {
            if (resultOn || errorOn)
            {
                resultOn = false;
                numberInput.Text = "";
                errorOn = false;
            }
            numberInput.Text += "1";
        }
        private void TwoPressed(object sender, RoutedEventArgs e)
        {
            if (resultOn || errorOn)
            {
                resultOn = false;
                numberInput.Text = "";
                errorOn = false;
            }
            numberInput.Text += "2";
        }
        private void ThreePressed(object sender, RoutedEventArgs e)
        {
            if (resultOn || errorOn)
            {
                resultOn = false;
                numberInput.Text = "";
                errorOn = false;
            }
            numberInput.Text += "3";
        }
        private void ZeroPressed(object sender, RoutedEventArgs e)
        {
            if (resultOn || errorOn)
            {
                resultOn = false;
                numberInput.Text = "";
                errorOn = false;
            }
            numberInput.Text += "0";
        }
        private void DecimalPressed(object sender, RoutedEventArgs e)
        {
            if (resultOn || errorOn)
            {
                resultOn = false;
                errorOn = false;
                numberInput.Text = "";
            }
            numberInput.Text += ".";
        }
        private void PlusPressed(object sender, RoutedEventArgs e)
        {
            try
            {
                n1 = float.Parse(numberInput.Text);
                numberInput.Text = "";
                operation = "+";
            }
            catch
            {
                numberInput.Text = "ERROR";
                errorOn = true;
            }
        }
        private void MinusPressed(object sender, RoutedEventArgs e)
        {
            try
            {
                n1 = float.Parse(numberInput.Text);
                numberInput.Text = "";
                operation = "-";
            }
            catch
            {
                numberInput.Text = "ERROR";
                errorOn = true;
            }
        }
        private void MultiplyPressed(object sender, RoutedEventArgs e)
        {
            try
            {
                n1 = float.Parse(numberInput.Text);
                numberInput.Text = "";
                operation = "*";
            }
            catch
            {
                numberInput.Text = "ERROR";
                errorOn = true;
            }
        }
        private void DividePressed(object sender, RoutedEventArgs e)
        {
            try
            {
                n1 = float.Parse(numberInput.Text);
                numberInput.Text = "";
                operation = "/";
            }
            catch
            {
                numberInput.Text = "ERROR";
                errorOn = true;
            }
        }
        private void EqualsPressed(object sender, RoutedEventArgs e)
        {
            float result = 0;
            try
            {
                n2 = float.Parse(numberInput.Text);
                switch (operation)
                {
                    case "+":
                        result = n1 + n2;
                        break;
                    case "-":
                        result = n1 - n2;
                        break;
                    case "*":
                        result = n1 * n2;
                        break;
                    case "/":
                        result = n1 / n2;
                        break;
                }
                numberInput.Text = Convert.ToString(result);
                resultOn = true;
            }
            catch
            {
                numberInput.Text = "ERROR";
                errorOn = true;
            }
        }
    }
}
