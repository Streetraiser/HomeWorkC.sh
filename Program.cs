using System;

namespace C_
{
    class Program
    { /*Задача 25: Напишите цикл, который принимает 
        на вход два числа (A и B) и возводит число 
        A в натуральную степень B.  */
        static void Main(string[] args)
        {
            int Prompt(string message)
            {
                Console.WriteLine(message);
                string readinput = Console.ReadLine();
                int userNum = int.Parse(readinput);
                return userNum ;
            }        
                
            int NumberAtExponent(int number, int exponent)
            {
                if (exponent > 0)
                {
                    int number = 1;
                    for (int i = 1; i <= exponent; i++)   
                    {
                        power *=number;
                         
                    }
                     return power; 
                }    
               
                else
               
                {
                    Console.WriteLine("Число не может быть меньше нуля.");
                   
                }
                 return;

                int number = Prompt("Введите число: ");
                int exponent = Prompt("Введите степень числа: ");
                Console.WriteLine($"Число {number} в степени {exponent} равно {NumberAtExponent(number, exponent)}");
                      
            }
        
        }
    }
}