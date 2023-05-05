using System;

namespace C__0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int numberA = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число: ");
            int numberB = int.Parse(Console.ReadLine());
            if(numberA > numberB)
            {
                Console.WriteLine("max= " + numberA);
            }
                
            else
            {
                Console.WriteLine("max= " + numberB);
            }
            
            

        }
    }
}
