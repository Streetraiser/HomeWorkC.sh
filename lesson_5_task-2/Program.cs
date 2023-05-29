using System;

namespace lesson_5_task_2
{
    class Program
    {
        static void Main(string[] args)
        {   /*Задайте одномерный массив, заполненный случайными числами.
              Найдите сумму элементов, стоящих на нечётных позициях.*/

             int[] GetArray(int size, int minValue, int maxValue)
            {
                int[] res = new int[size];  //массив внутри цикла, куда складываются рандомные числа.
                for (int i = 0; i < size; i ++)
                {
                    res[i] = new Random().Next(minValue, maxValue+1);
                    Console.Write($"{res[i]} ");
                }
                return res;
            }
            

            int SumOddNum(int[] array)
            {
                int sum = 0;
                //int i = 0;
                for (int i=0; i < array.Length; i++)
                {
                    if (i%2 == 0)  // нечётная позиция, но индекс чётный.  
                    {
                        sum += array[i];
                    }
                }
                    
                return sum;
            }

            int[] array = GetArray(30, 1, 100);
            int sumOddStayNumber = SumOddNum(array);
            Console.WriteLine($"Sum of elements they're staying at odd positions is {sumOddStayNumber}");

        }
    }
}
