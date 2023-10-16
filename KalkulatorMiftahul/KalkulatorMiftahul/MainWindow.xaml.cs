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

namespace KalkulatorMiftahul
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
        private void zero_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "0";
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = "";
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "1";
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "2";
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "3";
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "4";
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "5";
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "6";
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "7";
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "8";
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "9";
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "-";
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "+";
        }

        private void mult_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "*";
        }

        private void div_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "/";
        }

        private void result_Click(object sender, RoutedEventArgs e)
        {
            string expression = screen.Text;
            string[] operators = new string[] { "+", "-", "*", "/" };

            try
            {
                // Mencari operator dalam ekspresi untuk memisahkan angka.
                foreach (string op in operators)
                {
                    string[] operands = expression.Split(new string[] { op }, StringSplitOptions.RemoveEmptyEntries);
                    if (operands.Length == 2)
                    {
                        double num1 = double.Parse(operands[0]);
                        double num2 = double.Parse(operands[1]);
                        double result = 0;

                        // Melakukan perhitungan sesuai operator.
                        switch (op)
                        {
                            case "+":
                                result = num1 + num2;
                                break;
                            case "-":
                                result = num1 - num2;
                                break;
                            case "*":
                                result = num1 * num2;
                                break;
                            case "/":
                                if (num2 != 0)
                                    result = num1 / num2;
                                else
                                {
                                    screen.Text = "Error: Division by zero";
                                    return;
                                }
                                break;
                        }

                        // Menampilkan hasil perhitungan pada layar.
                        screen.Text = result.ToString();
                        return;
                    }
                }

                // Jika tidak ada operator yang ditemukan, menampilkan pesan kesalahan.
                screen.Text = "Salah Input";
            }
            catch (Exception)
            {
                // Menampilkan pesan kesalahan jika terjadi pengecualian.
                screen.Text = "Salah Input";
            }
        }
    }
