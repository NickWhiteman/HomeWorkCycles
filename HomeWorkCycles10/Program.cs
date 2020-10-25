using System;

//Условие: Пользователь вводит целое число. Вывести количество чисел в диапозоне от 1 до N, сумма четныз цифр больше суммы нечетных Решить

namespace HomeWorkCycles10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное число: ");
            int A = Convert.ToInt32(Console.ReadLine());
            int Even = 0;
            int UnEven = 0;

            for (int i = 0; i < A; i++)
            {
                if (i % 2 == 0)
                {
                    Even += i;
                }
                else
                {
                    UnEven += i;
                }
            }

            if (Even > UnEven)
            {
                for (int i = 0; i < A; i++)
                {
                    if(i % 2 == 0)
                    {
                        Console.Write($"{i}, ");
                    }
                }
            }
        }
    }
}
