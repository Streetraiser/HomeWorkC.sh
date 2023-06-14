using System;

namespace Final_task_3
{ // Напишите программу вычисления функции Аккермана
  // с помощью рекурсии. Даны два неотрицательных числа m и n.
 //  m = 2, n = 3 -> A(m,n) = 9
  //m = 3, n = 2 -> A(m,n) = 29 
  //      Рекурсия  Рекурсия
  /* AckermunFunc(2, 3) = 9
  ----   функция Аккермана является простым и безопасным методом 
  провоцирования переполнения стека, например, для проверки того, 
  обрабатывается ли этот случай ошибки и, если да, то как это делается.----*/ 

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
             int numberM = Prompt("Введите неотрицательное целое число: ");
             int numberN = Prompt("Введите неотрицательное целое число: ");
             Console.WriteLine($"Значение функции = {AckermunFunc(numberM, numberN)}");

             int AckermunFunc(int a, int n)
             {
                if(a == 0) return n + 1;
                else if (n == 0) return AckermunFunc(a - 1, 1);
                else return AckermunFunc(a -1, AckermunFunc(a, n - 1));
             } 
        }
    }
}
