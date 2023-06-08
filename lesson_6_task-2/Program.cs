using System;

namespace lesson_6_task_2
{// Напишите программу, которая найдёт точку пересечения 
 // двух прямых, заданных уравнениями 
 // y = k1 * x + b1, y = k2 * x + b2;
 //  значения b1, k1, b2 и k2 задаются пользователем.
 // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

    class Program
    {
        static void Main(string[] args)
        {
            double coordB1 = Prompt("Введите число: ");
            double coordK1 = Prompt("Введите число: ");
            double coordB2 = Prompt("Введите число: ");
            double coordK2 = Prompt("Введите число: ");
        

            double Prompt(string message) //Преобразуем ввод от пользователя в число.
            {
                Console.WriteLine(message);
                string readInput = System.Console.ReadLine();
                int result = Convert.ToInt32(readInput);
                return result;
            }
            double FindeCoord( double x)//double coordB1, double coordB2, double coordK1, double coordK2);
            {
                double coordX = (coordB2 - coordB1) / (coordK1 - coordK2);
                double doordY = coordK1*coordX + coordB2;
                return coordX;
               
            }
            bool ValidateCoord(double x,double y)
            {
                if (coordK1 == coordK2)
                {
                    if (coordB1 == coordB2)
                    {
                        Console.WriteLine("Прямые совпадают.");
                        return false;
                    }
                    else
                    {
                        Console.WriteLine("Прямые параллельны.");
                        return false;
                    }
                }
                return true; 
            }
            

            double coordX = FindeCoord((coordB2 - coordB1) / (coordK1 - coordK2));
            double coordY = FindeCoord(coordK1*coordX + coordB2);
            if (ValidateCoord(coordX, coordY))
            {
                Console.WriteLine($"Координаты точки пересечения - X = {coordX} Y = {coordY}");
            }
            
            


       
        }
    }
}
