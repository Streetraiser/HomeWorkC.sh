using System;

namespace Lesson_6_task_1
{
    class Program
    {// Пользователь вводит с клавиатуры M чисел. 
     //Посчитайте, сколько чисел больше 0 ввёл пользователь.
     //0, 7, 8, -2, -2 -> 2
     //1, -7, 567, 89, 223-> 3


        static void Main(string[] args)
        {
            int Prompt(string message) //Преобразуем ввод от пользователя в число.
            {
                Console.WriteLine(message);
                string readInput = System.Console.ReadLine();
                int result = Convert.ToInt32(readInput);
                return result;
            }
       

            int[] InputArray(int length)  // Получение чисел от пользователя для создания массива.
            {
                int[] array = new int[length];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = Prompt($"Введите число {i + 1}: ");
                }
                return array;
            }
            /*void PrintArray(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"a[{i}] = {array}");
                }
            }*/
            int CountPositiveNumbers(int[] array)
            {
                int countNum = 0;
                for (int i = 0; i < array.Length; i++)
                {    
                    if (array[i] > 0)
                    {
                        countNum ++;
                    }
                    
                }
                return countNum;
            }
        
       
            int length = Prompt("Введите количество элементов массива: ");
            int[] array = InputArray(length);
            //PrintArray(array);
            Console.WriteLine($"Количество чисел больше нуля: {CountPositiveNumbers(array)}");

       }

    }
}
