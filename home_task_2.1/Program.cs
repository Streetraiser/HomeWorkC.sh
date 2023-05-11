using System;

namespace home_task_2._1
{
    class Program
    {
        static void Main(string[] args)
        {   
           //Задача 10: Напишите программу, которая принимает на вход'''
           //трёхзначное число и на выходе показывает вторую цифру этого числа. 
            int a1 = new Random().Next(100,1000);
            Console.WriteLine("трехзначное число: " + a1);
            int b1 = new Random().Next(100,1000); 
            Console.WriteLine("трехзначное число: " + b1);
           
            FindSecondDigitNumber(a1);
            FindSecondDigitNumber(b1);
            void FindSecondDigitNumber(int a)
            {
  
                Console.WriteLine("Вторая цифра числа = " + ((a / 10) % 10));
                
            }
        }
    }
}
