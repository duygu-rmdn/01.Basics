﻿using System;
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

namespace MyFirstCoolCalculator
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
        // operation
        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            double Firstnum = 0;
            if (OperandDisplay.Text != "")
            {
                Firstnum = double.Parse(OperandDisplay.Text);
            }
            double Secondnum = 0;
            if (DisplayBox.Text != "")
            {
                Secondnum = double.Parse(DisplayBox.Text);
            }

            string operatorSing = OperatorDisplay.Text;
            double result = 0;

            if (operatorSing == "+")
            {
                result = Firstnum + Secondnum;
            }
            else if (operatorSing == "-")
            {
                result = Firstnum - Secondnum;
            }
            else if (operatorSing == "x")
            {
                result = Firstnum * Secondnum;
            }
            else if (operatorSing == "/")
            {
                if (Secondnum == 0)
                {
                    result = 0;
                }
                else
                {
                    result = Firstnum / Secondnum;
                }
            }

            DisplayBox.Text = result.ToString();
            OperatorDisplay.Text = "";
            OperandDisplay.Text = "";
        }

        private void Delite_Click(object sender, RoutedEventArgs e)
        {
            string tempNum = DisplayBox.Text;
            //string item = "";
            //string newTemp = "";
            //for (int i = tempNum.Length - 1; i > 0; i--)
            //{
            //    item += tempNum[i];
            //}
            //newTemp += item.Reverse();
            //DisplayBox.Text = item.ToString();
        }
        private void DeliteAll_Click(object sender, RoutedEventArgs e)
        {
            DisplayBox.Text = "0";
        }


        //sing
        private void Add_Click(object sender, RoutedEventArgs e)

        {
            if (DisplayBox.Text != "")
            {
                OperatorDisplay.Text = "+";
                OperandDisplay.Text = DisplayBox.Text;
                DisplayBox.Text = "";
            }
            else
            {
                OperatorDisplay.Text = "+";
            }
        }

        private void Subtraction_Click(object sender, RoutedEventArgs e)
        {
            if (OperandDisplay.Text == "")
            {
                OperatorDisplay.Text = "-";
                OperandDisplay.Text = DisplayBox.Text;
                DisplayBox.Text = "";
            }
            else
            {
                OperatorDisplay.Text = "-";
            }
        }
        private void Multiplication_Click(object sender, RoutedEventArgs e)
        {
            if (OperandDisplay.Text == "")
            {
                OperatorDisplay.Text = "x";
                OperandDisplay.Text = DisplayBox.Text;
                DisplayBox.Text = "";
            }
            else
            {
                OperatorDisplay.Text = "x";
            }
        }
        private void Division_Click(object sender, RoutedEventArgs e)
        {
            if (OperandDisplay.Text == "")
            {
                OperatorDisplay.Text = "/";
                OperandDisplay.Text = DisplayBox.Text;
                DisplayBox.Text = "";
            }
            else
            {
                OperatorDisplay.Text = "/";
            }
        }

        // numbers
        private void num0_Click(object sender, RoutedEventArgs e)
        {
            Nums("0");
        }
        private void num1_Click(object sender, RoutedEventArgs e)
        {
            Nums("1");
        }

        private void num2_Click(object sender, RoutedEventArgs e)
        {
            Nums("2");
        }

        private void num3_Click(object sender, RoutedEventArgs e)
        {
            Nums("3");
        }

        private void num4_Click(object sender, RoutedEventArgs e)
        {
            Nums("4");
        }

        private void num5_Click(object sender, RoutedEventArgs e)
        {
            Nums("5");
        }

        private void num6_Click(object sender, RoutedEventArgs e)
        {
            Nums("6");
        }

        private void num7_Click(object sender, RoutedEventArgs e)
        {
            Nums("7");
        }

        private void num8_Click(object sender, RoutedEventArgs e)
        {
            Nums("8");
        }

        private void num9_Click(object sender, RoutedEventArgs e)
        {
            Nums("9");
        }

        private void Nums(string num)
        {
            if (DisplayBox.Text == "0")
            {
                DisplayBox.Text = "";
            }
            DisplayBox.Text += num;
        }

    }
}

