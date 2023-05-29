using System;

namespace Lesson_5_task_1
{
    class Program
    { //Задача 34: Задайте массив заполненный случайными 
      //положительными трёхзначными числами. Напишите программу, 
      //которая покажет количество чётных чисел в массиве.
        static void Main(string[] args)
        {
            int[] GetArray(int size, int minValue, int maxValue)
            {
                int[] res = new int[size];  //массив внутри цикла, куда складываются рандомные числа.
                for (int i = 0; i < size; i ++)
                {
                    res[i] = new Random().Next(minValue, maxValue);
                    Console.Write($"{res[i]} ");
                }
                return res;
            }

            int[] array = GetArray(12, 100, 1000);

            int CountEvenNum(int[] array)
            {
                int evenNum = 0;
                for (int i=0; i < array.Length; i++)
                {
                    //int n =array[i];
                    //int evenNum = 0;
                    if (array[i]%2 == 0)
                    {
                        evenNum += 1;
                    }
                    //return evenNum;
                }
                return evenNum;

            }
            int evenNumArray = CountEvenNum(array);
            Console.WriteLine($"Количество чётных элементов в массива равно {evenNumArray}");

            
        }
    }
}
