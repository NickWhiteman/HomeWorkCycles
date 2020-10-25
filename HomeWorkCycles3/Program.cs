using System;

//Условие: Пользователь вводит одно число А. Найдите наибольший делитель числа А кроме самого А.

namespace HomeWorkCycles3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число А");
            int A = Convert.ToInt32(Console.ReadLine());


            if (A <= 1)
            {
                Console.WriteLine("Ошибка!");
            }
            else if (A % 2 == 0)
            {
                int LargeDivisor = A / 2;
                Console.WriteLine($"Наибольший делитель {LargeDivisor}");
            }
            else
            {
                if (A % 2 !=0)
                {
                    Console.WriteLine($"Наибольший делитель {A}");
                }
            }
        }
    }
}