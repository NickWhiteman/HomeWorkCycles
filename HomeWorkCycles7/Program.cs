using System;

//Условие: Пользователь вводит целое положительное число, которое является кубом целого числа N. Найти число методом половинного деления.

namespace HomeWorkCycles7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное число");
            int A = Convert.ToInt32(Console.ReadLine());
            int N = 0;
            int LeftBound = 0;
            int RightBound = A;

            while (Math.Pow(N,3) != A)
            {
                N = (LeftBound + RightBound) / 2;
                if (Math.Pow(N, 3) > A)
                {
                    RightBound = N;
                }
                else
                {
                    LeftBound = N;
                }
            }
            Console.WriteLine($"Вывод обратной величины числа из куба = {N}");

        }
    }
}
