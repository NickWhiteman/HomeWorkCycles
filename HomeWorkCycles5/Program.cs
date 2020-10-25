using System;

//Условие: Пользователь вводит 1 число.Выведите N-ое число ряда фибоначчи. В ряду фибоначчи каждое следующее число является суммой двух предыдущих. Первое и второе считаются равными 1.

namespace HomeWorkCycles5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N");
            int N = Convert.ToInt32(Console.ReadLine());

            int Fibonacci1 = 1;
            int Fibonacci2 = 2;

            Console.Write($"Последовательность чисел Фибоначчи 0, {Fibonacci1}, ");
            
            for (int i = 0; i < N - 2; i++)
            {
                int B = Fibonacci1;
                Fibonacci1 = Fibonacci2;
                Fibonacci2 = B + Fibonacci1;
                Console.Write($"{B}, ");
            }

            
        }
    }
}
