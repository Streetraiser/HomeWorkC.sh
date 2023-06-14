using System;

namespace Final_task_2
{//Задайте значения M и N. Напишите программу, которая 
 //найдёт сумму натуральных элементов в промежутке от M до N. 

 //M = 1; N = 15 -> 120
  //M = 4; N = 8. -> 30
    class Program
    {
        static void Main(string[] args)
        {
            int Prompt(string message)
            {
                Console.WriteLine(message);
                int number = Convert.ToInt32(Console.ReadLine());
                return number;
            }
             int numberM = Prompt("Введите число: ");
             int numberN = Prompt("Введите число: ");
             Console.WriteLine($"Сумма натуральных элементов в промежутке от {numberM} до {numberN} \n = {SumNum(numberM, numberN)}");

             int SumNum(int m, int n)
             {
                if(m==n) return n;                       // условие выхода
                else return m + SumNum(m+1, n);          // обращение к подфункции с базовым вариантом функции
                Console.WriteLine(SumNum(m, n));
             }
        }
    }
}
