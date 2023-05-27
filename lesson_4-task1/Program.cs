using System;

namespace lesson_4_task1
{
    class Program
    { /*Задача 25: Напишите цикл, который принимает 
        на вход два числа (A и B) и возводит число 
        A в натуральную степень B.  */
        static void Main(string[] args)
        {
            
            int Prompt(string message)
            {
                System.Console.Write(message);
                
                int userNum = System.Convert.ToInt32(Console.ReadLine());
                return userNum ;
            }        
                
            int NumberAtExponent(int num, int expNum)
            {
               
               if(expNum > 0)
               {
                   int power = 1;
                  
                    for (int i = 1; i <= expNum; i++)   
                    {
                        power *=num;
                         
                    }
                    return power; 
                }    
               
                else
               
                {
                    System.Console.WriteLine("Число не может быть меньше нуля.");
                   
                }
                return 0;
            }


                
            int numberBase = Prompt("Введите число: ");
            int exponentBase = Prompt("Введите степень числа: ");
            System.Console.WriteLine($"Число {numberBase} в степени {exponentBase} равно {NumberAtExponent(numberBase, exponentBase)}");
                    
            
        }
    }
}
