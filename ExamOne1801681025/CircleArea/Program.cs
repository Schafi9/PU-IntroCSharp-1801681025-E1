using System;

namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter random number between 33 and 187! ");
            Random random = new Random();
            double randomNumber = random.Next(33, 188);
            randomNumber = double.Parse(Console.ReadLine());

            double p = (2 * Math.PI) * randomNumber;
            double a = Math.PI * (randomNumber * randomNumber);

            Console.WriteLine("Perimeter is: {0:f2}", p);
            Console.WriteLine("Area is : {0:f2} ", a);
        }
    }
}
