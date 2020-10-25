using System;

//Пользователь вводит 2 числа. Возведите число A в степень B

namespace HomeWorkCycles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число в переменную A");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число в переменную B");
            int B = Convert.ToInt32(Console.ReadLine());
            double Result = 1;

            if (B >= 0)
            {
                for (int i = 0; i < B; i++)
                {
                    Result *= A;
                }
            }
            else
            {
                for (int i = 0; i < B; i++)
                {
                    Result /= A;
                }
            }
            Console.WriteLine($"A в степени B = {Result}");
        }
    }
}
