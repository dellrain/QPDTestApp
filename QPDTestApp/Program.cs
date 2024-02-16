using System;

namespace QPDTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int MaxSumOfDigits = 0;
            int NumberWithMaxSum = 0;

            while (true)
            {
                Console.Write("Введите число: ");
                int number = int.Parse(Console.ReadLine());

                if (number == 0)
                    break;

                int sum = GetSum(number);

                if (sum > MaxSumOfDigits)
                {
                    MaxSumOfDigits = sum;
                    NumberWithMaxSum = number;
                }
            }

            if (NumberWithMaxSum != 0)
                Console.WriteLine($"Число с максимальной суммой: {NumberWithMaxSum}   (Сумма = {MaxSumOfDigits})");
            else Console.WriteLine("Вы ничего не ввели");

            Console.ReadLine();
        }

        public static int GetSum(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }
    }
}