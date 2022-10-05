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

namespace Portfolio_Calc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PressNumber(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string Number = button.Tag.ToString ();
            switch (Number)
            {
                case "Nine":
                    NumberTextBox.Text += "9";
                    break;
                case "Eight":
                    NumberTextBox.Text += "8";
                    break;
                case "Seven":
                    NumberTextBox.Text += "7";
                    break;
                case "Six":
                    NumberTextBox.Text += "6";
                    break;
                case "Five":
                    NumberTextBox.Text += "5";
                    break;
                case "Four":
                    NumberTextBox.Text += "4";
                    break;
                case "Three":
                    NumberTextBox.Text += "3";
                    break;
                case "Two":
                    NumberTextBox.Text += "2";
                    break;
                case "One":
                    NumberTextBox.Text += "1";
                    break;
                case "Zero":
                    NumberTextBox.Text += "0";
                    break;
                case "Decimal":
                    if (string.IsNullOrWhiteSpace(NumberTextBox.Text))
                        NumberTextBox.Text = "0.";
                    else 
                        NumberTextBox.Text += ".";
                    break;
                case "DoubleZero":
                    if (NumberTextBox.Text.Contains ("."))
                        NumberTextBox.Text += "00";
                    break;
                default:
                    break;
            }
        }

        private void PressAdd(object sender, RoutedEventArgs e)
        {

        }

        private void PressSubtract(object sender, RoutedEventArgs e)
        {

        }

        private void PressEquals(object sender, RoutedEventArgs e)
        {

        }

        private void NumberTextBoxValidation(object sender, TextCompositionEventArgs e)
        {

        }
    }
}
