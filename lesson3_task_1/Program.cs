using System;

namespace lesson3_task_1
{
    class Program
    {
        static void Main(string[] args)
        /*Задача 19.Напишите программу, которая принимает на вход пятизначное '''
        число и проверяет, является ли оно палиндромом. */


        {
            string fiveSignsNumber = Prompt("Введите пятизначное число: ");
            FindPolendromNumber(fiveSignsNumber);

            string Prompt(string message)
            {
                Console.WriteLine("Введите пятизначное число: ");
                string  fiveSignsNumber = Console.ReadLine();
                return fiveSignsNumber;
            }
          
           
            void FindPolendromNumber(string number)
            {
                        
                if (number[0] == number[4] && number[1] ==  number[3])
                {
                     Console.WriteLine("Да!");
                }
                else //dotif (number[0] != number[4] && number[1] != number[3])
                {
                    Console.WriteLine("Not!");
                }
                        
            }
        }
    }
}
