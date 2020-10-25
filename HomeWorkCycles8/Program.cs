using System;

//Условие: Пользователь вводит 1 число. Найти количество нечетных цифр этого числа.

namespace HomeWorkCycles8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int A = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < A; i++)
            {
                if (i % 2 != 0)
                {
                    sum++;
                }
            }
            Console.WriteLine($"Колличество нечетных цифр числа {A} : {sum} шт.");
        }
    }
}
