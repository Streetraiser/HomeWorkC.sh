using System;

namespace home_tack_2._2
{
    class Program
    {
        static void Main(string[] args)
        //Задача 13: Напишите программу, которая 
        //выводит третью цифру заданного числа 
        //или сообщает, что третьей цифры нет.
        {
            Console.WriteLine("Введите число:"  );
            int number = int.Parse(Console.ReadLine()!);
            
            ThirdDigitsNumber(number);

            void ThirdDigitsNumber(int x)
            {
                if (0 < x && 100 > x)
                {
                    Console.WriteLine("Третьей цифры нет!");
                }
                else if (99 < x && 1000 > x)
                { 
                    Console.WriteLine("Третья цифра: " + (x%10));
                }
                else if (999 < x && 10000 > x)
                {
                    Console.WriteLine("Третья цифра: " + ((x/10)%10));
                }
                else if (9999 < x && 100000 > x)
                {
                    Console.WriteLine("Третья цифра: " + ((x/100)%10));
                } 
                else if (99999 < x && 1000000 > x)
                {
                    Console.WriteLine("Третья цифра: " + ((x/1000)%10));

                }  
                else if (999999 < x && 10000000 > x)
                {
                    Console.WriteLine("Третья цифра: " + ((x/10000)%10));

                }
                else if (9999999 < x && 100000000 > x)
                {
                    Console.WriteLine("Третья цифра: " + ((x/100000)%10));

                }
                else
                {
                   Console.WriteLine("Для цифр длиннее 100000000 код не прописан! "); 
                }

            }
        }   
    }
}
