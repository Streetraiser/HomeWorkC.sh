using System;

namespace Lesson_5_task_3
{
    class Program
    { //Задайте массив вещественных чисел.
    //  Найдите разницу между максимальным и минимальным элементов массива.
        static void Main(string[] args)
        {
           int[] GetArray(int size, int minValue, int maxValue)
            {
                int[] res = new int[size];  
                for (int i = 0; i < size; i ++)
                {
                    res[i] = new Random().Next(minValue, maxValue);
                    Console.Write($"{res[i]} ");
                }
                return res;
            }
            
            
            

            int DiffValue(int[] arr)
            { 
                int diff = 0;
                int maxEl = arr[0];
                int minEl = arr[0];
                for (int i = 1; i <arr.Length; i++)
                {
                    if (arr[i] >= maxEl)
                    {
                         maxEl = arr[i];
                    }

                    if (arr[i] <= minEl)

                    {
                        minEl = arr[i];
                    }
                }

                return  diff = maxEl - minEl;
    
            }
            
            int[] array = GetArray(8, -15, 100);
            int diffEl = DiffValue(array);
           
            Console.WriteLine($"  Разница максимального и минимального значений : {diffEl} ");
        }
    }
}
