using System;

//Условие: Пользователь вводит 1 число. Найти число, которое является зеркальным отображением последовательности цифр, заданного числа, например, задано число 123, вывести 321.

namespace HomeWorkCycles9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int A = Convert.ToInt32(Console.ReadLine());
            int Revers = 0;

            while (A > 0)
            {
                int Remains = A % 10;
                Revers = Revers * 10 + Remains;
                A = A / 10;
            }
            
            Console.WriteLine($"{Revers}");
        }
    }
}
