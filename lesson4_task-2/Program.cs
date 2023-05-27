using System;

namespace lesson4_task_2
  //Задача 29: Напишите программу, которая задаёт
  // массив из 8 элементов и выводит их на экран.
{
    class Program
    {
        static void Main(string[] args)
        {
           int Prompt(string message)
           {
            Console.Write(message);
            string readInput = Console.ReadLine();
            int result = int.Parse(readInput);
            return result;
           }

           int[] BuildArray(int length, int minValue, int maxValue)
           {
               int[] array = new int [length];
               Random random = new Random();
               for(int i =0;  i < array.Length -1; i++ )
               {
                   array[i] = random.Next(minValue, maxValue + 1);
               }
               return array;
           }
           void PrintArray(int[] array)
           {
               Console.Write("[");
               for (int i = 0; i < array.Length - 1; i++)
               {
                   Console.Write($"{array[i]}, ");
               }
               Console.WriteLine($"{array[array.Length - 1]} ");
               Console.WriteLine("]");
            }

            int arrayLength = Prompt("Длина массива: ");
            int minNum = Prompt("Начальное значение для диапазона случайных чисел: ");
            int maxNum = Prompt("Крайнее число: ");
            int[] array = BuildArray(arrayLength, minNum, maxNum);
            PrintArray(array);                 
           
        }
    }
}
