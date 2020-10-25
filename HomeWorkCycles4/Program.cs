using System;

//Условие: Пользователь вводит  2 числа. Вывести сумму всех чисел из диапозона от А до B, которые дебятся без остатка на 7.
//Я неуверен в своем решении, но в свою очерень обязуюсь отточить эти алгоритмы и запомнить.

namespace HomeWorkCycles4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число А");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B");
            int B = Convert.ToInt32(Console.ReadLine());
            int C = 0;
            int Sum = 0;

            if(B > A)
            {
                for(int i = A; i <= B; i++)
                {
                    if (i % 7 == 0)
                    {
                        Sum += i;
                    }    
                }
               
                Console.WriteLine($"Сумма всех чисел из диапозона от А до B, которые делятся на 7 без остатка : {Sum}");
            }
            else
            {
                C = A;
                A = B;
                B = C;

                for (int i = A; i <= B; i++)
                {
                    if (i % 7 == 0)
                    {
                        Sum += i;
                    }
                    
                }
                
                Console.WriteLine($"Сумма всех чисел из диапозона от А до B, которые делятся на 7 без остатка : {Sum}");

            }
        }
    }
}
