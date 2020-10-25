 using System;

//Условие: Пользователь вводит 2 числа. Найдите их наибольший общий делитель используя алгоритм Евклида.


namespace HomeWorkCycles6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1-е число");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2-е число");
            int B = Convert.ToInt32(Console.ReadLine());
            int C;

            if (A > B)
            {
                while (B != 0)
                {
                    C = A % B;
                    A = B;
                    B = C;
                }
                Console.Write($"НОД {A}");
            }
            else
            {
                while (A != 0)
                {
                    C = B % A;
                    B = A;
                    A = C;
                }
                Console.Write($"НОД {B}");
            }
        }
    }
}
