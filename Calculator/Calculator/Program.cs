using System;

namespace Calculator
{
    class Calculator1
    {
        string operation;
        double result;
        private double number1;
        private double number2;

        public Calculator1(double n1, double n2, string operation)
        {
            this.number1 = n1;
            this.number2 = n2;
            this.operation = operation;
        }

        public double calculate()
        {
            if (operation =="+")
            {
                result = number1 + number2;
            }
            else if (operation == "-")
            {
                result = number1 - number2;
            }
            else if (operation == "*")
            {
                result = number1 * number2;
            }
            else
            {
                if (this.number2 != 0)
                {
                    result = number1 / number2;
                }
                else
                {
                    throw new InvalidOperationException();
                }
            };

            return result;
        }
    }    
    
    internal class Program
    {
        static void Main(string[] args)
        {
            string action = "Y";

            while (action == "Y" || action == "y")
            {
                Console.WriteLine("Enter number1: ");
                double number1;
                number1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter number2: ");
                double number2;
                number2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter operation: ");
                string operation;
                operation = Console.ReadLine();

                Calculator1 calc = new Calculator1(number1, number2, operation);

                Console.WriteLine(calc.calculate());

                Console.WriteLine("Continue: Y/N? ");
                action = Console.ReadLine();
            }
        }
    }
}
