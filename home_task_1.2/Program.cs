using System;

namespace home_task_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
            Console.WriteLine("Введите любое число от 1");
            int number = int.Parse(Console.ReadLine());
            while (number > 0)

            {
               if(number%2 == 0)
               {
                Console.WriteLine(number);
               } 
               number = number - 1; 
            }
        }
    }
}
