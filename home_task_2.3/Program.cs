using System;

namespace home_task_2._3
{
    class Program
    {
        static void Main(string[] args)
        //Задача 15: Напишите программу, которая 
        //принимает на вход цифру, обозначающую день 
        //недели, и проверяет, является ли этот день выходным.
        {
            Console.WriteLine("Введите число от 1 до 7");
            int number = int.Parse(Console.ReadLine()!);
            DayWeek(number);
            void DayWeek(int day)
            {
                if (0 < day && 6 > day)
                {
                     Console.WriteLine("Это рабочий чень!");
                }
                else if (5 < day && 8 > day)
                {
                    Console.WriteLine("Сегодня выходной!");
                }
                else
                {
                    Console.WriteLine("Неправильно ввели число!");
                }

            }
        }
    }
}
