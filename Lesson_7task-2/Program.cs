using System;

namespace Lesson_7task_2
{
    class Program
    {// Напишите программу, которая на вход принимает 
     //позиции элемента в двумерном массиве, и возвращает значение 
     // этого элемента или же указание, что такого элемента нет.


        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Введите число строк: ");
            int inputRows = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число столбцов: ");
            int inputColumns = int.Parse(Console.ReadLine());
            int[,] array = GetArray(inputRows, inputColumns, 0, 10);
            PrintArray(array);
            Console.WriteLine("Введите число индекса строки: ");
            int inputX = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число индекса столбца: ");
            int inputY = int.Parse(Console.ReadLine());
            ResultCheckValue(array, inputX, inputY);

            

            int[,] GetArray(int row, int columns, int minValue, int maxValue)
            {
                int[,] res = new int[row, columns];  //массив внутри цикла, куда складываются рандомные числа.
                for (int i = 0; i < row; i ++)
                {
                    for (int j=0; j < columns; j++)
                    {
                         
                        res[i,j] = new Random().Next(minValue, maxValue+1);
                        
                    }
                
                }
                   
                   
                   
                return res;

            }

            void PrintArray(int[,] inArray)
            {
                for (int i = 0; i < inArray.GetLength(0); i++)
                {
                    for (int j=0; j < inArray.GetLength(1); j++)
                    {
                        Console.Write($"{inArray[i,j]}  ");
                    }

                    Console.WriteLine();
                }
                
            }

            void ResultCheckValue(int[,] arr, int m, int n)
            {
                //int value = 0;
                //arr[m,n] = value;
                
                
                if (m < arr.GetLength(0) && n < arr.GetLength(1))
                {
                                    
                    Console.WriteLine($"Значение - {arr[m, n]}");
                                
                }
                else
                {
                   
                    Console.WriteLine($"[{m},{n}] -Такого значения в масиве нет. ");
                }
                Console.WriteLine();         
            }
                
                
               
        }
    }
}
