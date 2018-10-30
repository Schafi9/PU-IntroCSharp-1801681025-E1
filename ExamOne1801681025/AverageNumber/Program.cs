using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number from 0 to 255: ");

            List<int> evenNumbers = new List<int>();

            bool isZero = false;

                while(!isZero)
            {
                Console.WriteLine("Enter number: ");
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber == 0) break;
                if (currentNumber % 2 == 0) evenNumbers.Add(currentNumber);
            
            }
            if (evenNumbers.Count>0)
            {
                Console.WriteLine($"Total even numbers:{evenNumbers.Count} => Avarage sum: {evenNumbers.Average()}");
                
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}
