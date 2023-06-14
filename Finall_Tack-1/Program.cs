using System;

namespace Finall_Tack_1
{
    class Program
    { //Задайте значения M и N. Напишите программу,
      // которая выведет все натуральные числа в промежутке от M до N.
      //  M = 1; N = 5. -> "1, 2, 3, 4, 5"
     //M = 4; N = 8. -> "4, 5, 6, 7, 8"   Рекурсия, Рекурсия, Рекурсия
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
             int nums = AllNaturalNumMtoN(numberM, numberN);
             Console.Write($"все натуральные числа от {numberM} до {numberN}: {nums}");//{AllNaturalNumMtoN(numberM, numberN)}");
            
           int AllNaturalNumMtoN(int m, int n)
           {
               if(m == n)
               {
                   return m;
               }
               else if(m < n)
               {
                    AllNaturalNumMtoN(m, n - 1);
                    
                    Console.Write(n + " ");
                    return n;
               }
               else
               {
                    AllNaturalNumMtoN(m - 1, n);
                    Console.Write(m + " ");
                    return m;
                    
               }
                         
           }
        }
    }
}
