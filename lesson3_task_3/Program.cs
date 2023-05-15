using System;

namespace lesson3_task_3
{
    class Program
    {
        static void Main(string[] args)
        /*Напишите программу, которая принимает
           на вход число (N) и выдаёт таблицу 
           кубов чисел от 1 до N. */
        {
           int number = Prompt("Введите число N: ");
           TableCubes(number);

           int Prompt(string message)
           {
            Console.Write(message);
            int num = Convert.ToInt32(Console.ReadLine());
            return Math.Abs(num);         //Число по модулю, для отрицательных чисел.
           }

           void TableCubes(int number)
           {
               int currentNum = 1;
               int cubeNum =1;
               while (currentNum <= number)
               {
                   cubeNum = currentNum*currentNum*currentNum;
                   Console.WriteLine(cubeNum);
                   currentNum++;
                 
               }
               
              
            }
           
        }
    }
}
