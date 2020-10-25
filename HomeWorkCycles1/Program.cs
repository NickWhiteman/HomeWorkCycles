using System;

//Условие: Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые делятся на A.

namespace HomeWorkCycles1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int A = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 1000; i++)
            {
                if (i % A == 0)
                {
                    Console.WriteLine($"{i} Делится на А.");
                }
            }
        }
    }
}
