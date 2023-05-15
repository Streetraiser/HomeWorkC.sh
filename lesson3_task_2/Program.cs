using System;

namespace lesson3_task_2
{
    class Program
    {
        static void Main(string[] args)
        /*  ЗАДАЧА 2. 
          Напишите программу, которая принимает на вход 
          координаты двух точек и находит расстояние 
          между ними в 3D пространстве.*/
        {
            int valueX1 = Prompt("Введите координату Х первой точки: ");
            int valueY1 = Prompt("Введите координату Y первой точки: ");
            int valueZ1 = Prompt("Введите координату Z первой точки: ");
            int valueX2 = Prompt("Введите координату Х второй точки: ");
            int valueY2 = Prompt("Введите координату Y второй точки: ");
            int valueZ2 = Prompt("Введите координату Z второй точки: ");
            
            double d = FindDistansePoint(valueX1, valueY1, valueZ1, valueX2, valueY2, valueZ2);

            int Prompt(string message)
            {
                Console.Write(message);
                int coordValue =Convert.ToInt32(Console.ReadLine());
                return coordValue;
            }

            double FindDistansePoint(int x1, int y1, int z1, int x2, int y2, int z2)
            {
                double result = Convert.ToDouble(Math.Round(Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1)), 3));
                Console.Write(result);
                return result;
            }
        }
    }
}
