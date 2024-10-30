using System;
using System.Windows;
using ClassLibrary1;

namespace SumCalculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateSum_Click(object sender, RoutedEventArgs e)
        {
            int numberOfNumbers;
            if (!int.TryParse(NumberOfNumbers.Text, out numberOfNumbers))
            {
                MessageBox.Show("Некорректно введено количество чисел. Введите целое число.");
                return;
            }

            if (numberOfNumbers < 1)
            {
                MessageBox.Show("Количество чисел должно быть не меньше 1.");
                return;
            }

            string[] inputNumbers = InputNumbers.Text.Split(' ',StringSplitOptions.RemoveEmptyEntries);

            if (inputNumbers.Length != numberOfNumbers)
            {
                MessageBox.Show("Введено неверное количество чисел. Введите " + numberOfNumbers + " чисел.");
                return;
            }

            if (inputNumbers.Length == 0)
            {
                MessageBox.Show("Необходимо ввести хотя бы одно число.");
                return;
            }

            int sum = 0;
            for (int i = 0; i < numberOfNumbers; i++)
            {
                int number;
                if (!int.TryParse(inputNumbers[i], out number))
                {
                    MessageBox.Show("Некорректно введено число. Введите целые числа, разделенные пробелами.");
                    return;
                }

                if (number < 8)
                {
                    sum += number;
                }
            }
            Result.Text = sum.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Автор: Цыпленков Кирилл" + "\n" + "Группа ИСП-34" + "\n" + "Ввести n целых чисел. Найти сумму чисел < 8.");
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}