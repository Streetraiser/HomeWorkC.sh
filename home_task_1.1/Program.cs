using System;

namespace home_task_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
            Console.WriteLine("Введите число: ");
            int number_A = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число: ");
            int number_B = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число: ");
            int number_C = int.Parse(Console.ReadLine());
            int max = number_A;
            if(number_B > max)
            {
               max = number_B;
            }   
            if(number_C > max)
            {
                max = number_C;
            }  
            
            Console.WriteLine("Максимальное число: " + max);
        }
    }
}
