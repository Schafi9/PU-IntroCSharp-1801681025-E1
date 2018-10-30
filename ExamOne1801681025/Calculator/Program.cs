using System;

namespace Calculator
{
    class Program
    {
        public static object MessageBox { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Do u want to calculate some numbers?");
            string answer = Console.ReadLine();
            if (answer == "Yes")
            {
                int operation = 0;

                double result = 0;

                Console.WriteLine("Enter your first number :");
                string stringFirstNumber = Console.ReadLine();
                double firstNumber = Convert.ToDouble(stringFirstNumber);

                Console.WriteLine("Enter your second number :");
                string stringSecondNumber = Console.ReadLine();
                double secondNumber = Convert.ToDouble(stringSecondNumber);

                Console.WriteLine("Enter the operation + , - , * , / :");
                string stringOperation = Console.ReadLine();

                if (stringOperation == "+")
                {
                    operation = 1;
                }
                else if (stringOperation == "-")
                {
                    operation = 2;
                }
                else if (stringOperation == "*")
                {
                    operation = 3;
                }
                else if (stringOperation == "/")
                {
                    operation = 4;
                }
                switch (operation)
                {
                    case 1:
                        result = (firstNumber + secondNumber) * 0.1;
                        break;

                    case 2:
                        if (firstNumber > secondNumber)
                        {
                            result = (firstNumber * firstNumber)-secondNumber;
                            
                        }
                        else if (secondNumber > firstNumber)
                        {
                            result = (secondNumber * secondNumber)-firstNumber;
                            
                        }


                        break;

                    case 3:
                        result = firstNumber * Math.Sqrt(secondNumber);
                        break;

                    case 4:
                        if (secondNumber > 0)
                        {
                            result = firstNumber / secondNumber;
                        }
                        else if(secondNumber==0)
                        {
                            Console.WriteLine("Invalid number, cant be 0!");
                        }
                        break;
                }
                Console.WriteLine("\nResult of " + firstNumber + " " + stringOperation + " " + secondNumber + " = " + result + ".");
            }
            else if (answer == "No")
            {
                Console.WriteLine("Goodbye!");
            }
            Console.ReadKey();
        }
    }
}
