using System;

//Условие: Пользователь вводит 2 числа. Сообщите, если в написании двух чисел одинаковые цифры то вывести "Да", если нет то "Нет". 
//Задача не решена.  Для себя все очевидные возможности решения перебрал, решить пока не смог, но к ней я еще вернусь!

namespace HomeWorkCycles11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первые число");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int B = Convert.ToInt32(Console.ReadLine());
            string StrA = Convert.ToString(A);
            string StrB = Convert.ToString(B);

            if (A == B)
            {
                Console.WriteLine("Да");
            }
            else
            {
                while (StrA != StrB)
                {
                    if (StrA.Length > StrB.Length)
                    {
                        for (int i = 0; i < StrA.Length; i++)
                        {
                            for (int j = 0; i < StrB.Length; j++)
                            {
                                if (StrA[i] == StrB[j])
                                {
                                    Console.WriteLine("Да");

                                }
                                else 
                                {
                                    Console.WriteLine("Нет");
                                }
                            }
                        }

                    }
                    else
                    {
                        for (int i = 0; i < StrB.Length; i++)
                        {
                            for (int j = 0; i < StrA.Length; j++)
                            {
                                if (StrA[j] == StrB[i])
                                {
                                    Console.WriteLine("Да");

                                }
                                else
                                {
                                    Console.WriteLine("Нет");
                                }
                            }
                        }

                    }
                }
            }
        }
    }
}
