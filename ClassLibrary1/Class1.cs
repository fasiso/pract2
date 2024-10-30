using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
     public static class SumCalculator
    {
        public static int CalculateSum(string[] inputNumbers, int numberOfNumbers)
        {
            if (inputNumbers.Length != numberOfNumbers)
            {
                throw new ArgumentException("Неверное количество чисел.");
            }

            if (inputNumbers.Length == 0)
            {
                throw new ArgumentException("Необходимо ввести хотя бы одно число.");
            }

            int sum = 0;
            for (int i = 0; i < numberOfNumbers; i++)
            {
                int number;
                if (!int.TryParse(inputNumbers[i], out number))
                {
                    throw new ArgumentException("Некорректно введено число.");
                }

                if (number < 8)
                {
                    sum += number;
                }
            }

            return sum;
        }
    }
}
        