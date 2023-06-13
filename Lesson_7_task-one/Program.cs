using System;

namespace Lesson_7_task_one
{
    class Program
    { //Задайте двумерный массив размером m×n, 
      //заполненный случайными вещественными числами.

        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Введите число строк: ");
            int inputRows = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число столбцов: ");
            int inputColumns = int.Parse(Console.ReadLine());
            double[,] array = GetArray(inputRows, inputColumns);
            PrintArray(array);

            double[,] GetArray(int row, int columns)
            {
                double[,] arr = new double[row, columns];  //массив внутри цикла, куда складываются рандомные числа.
                for (int i = 0; i < row; i ++)
                {
                    for (int j=0; j < columns; j++)
                    {
                         
                        arr[i,j] = new Random().NextDouble()*100;
                        
                    }
                
                }
                   
                return arr;

            }

              void PrintArray(double[,] arr)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j=0; j < arr.GetLength(1); j++)
                    {
                        Console.Write($"{arr[i,j]}  ");
                    }

                   Console.WriteLine();
                }
                 
            }
           /* Console.Clear();
            Console.WriteLine("Введите число строк: ");
            int inputRows = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число столбцов: ");
            int inputColumns = int.Parse(Console.ReadLine());
            double[,] array = GetArray(inputRows, inputColumns);
            PrintArray(array);

            double GetArray(int rows, int columns)
            {
                double[,] arr = new double[rows, columns];
                
                for (int i = 0; i < rows; i++)
                {
                    for (int j=0; j < columns; j++)
                    {
                         
                        arr[i,j] = new Random().NextDouble()*100;
                    }
                    
                  
                }
                return arr;
            }

            void PrintArray(double[,] arr)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j=0; j < arr.GetLength(1); j++)
                    {
                        Console.Write($"{arr[i,j]}");
                    }
                    Console.WriteLine();
                }
                
            }*/
        }
    }
}
