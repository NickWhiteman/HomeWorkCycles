using System;

//Условие: Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, квадрат которых меньше A

namespace HomeWorkCycles2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число в переменную A");
            int A = Convert.ToInt32(Console.ReadLine());
            double Result = 1;

            if (A > 0)
            {
                for (int i = 1; i < A; i++)
                {
                    Result = Math.Pow(i, 2);

                    if (A > Result)
                    {
                        Console.WriteLine($"положительное целое число квадрат которых меньше A {i}");
                    }

                }
            }
            else
            {
                Console.WriteLine($"Не вводите отрицательные числа или равные 0");
            }

        }
    }
}
