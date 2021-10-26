using System;
using System.Collections.Generic;

namespace ConsoleCalculator
{
    public static class Calc
    {
        static public double Sum(double x, double y)
        {
            return x + y;
        }

        static public double Subtract(double x, double y)
        {
            return x - y;
        }

        static public double Multiply(double x, double y)
        {
            return x * y;
        }

        static public double RestOfDivide(double x, double y)
        {
            if (y == 0)
            {
                throw new ArgumentException("Division by 0 is not possible.");
            }
            return x % y;
        }

        static public double Divide(double x, double y)
        {
            if (y == 0)
            {
<<<<<<< HEAD
                Console.Write("The number should not be 0. Enter second number again: ");
                y = Calc.NumInput();
                Console.WriteLine();
=======
                throw new ArgumentException("Division by 0 is not possible.");
>>>>>>> main
            }
            return x / y;
        }

        static public double Sqrt(double num)
        {
<<<<<<< HEAD
            while(num < 0)
            {
                Console.Write("The number should not be negative. Enter number again: ");
                num = Calc.NumInput();
                Console.WriteLine();
=======
            if (num < 0)
            {
                throw new ArgumentException("A negative root is not possible.");
>>>>>>> main
            }
            if (num == 0)
            {
                return 0;
            }
            double root = 1;
            int i = 0;
            while (true)
            {
                i = i + 1;
                root = (num / root + root) / 2;
                if (i == num + 1)
<<<<<<< HEAD
                { 
=======
                {
>>>>>>> main
                    break;
                }
            }
            return Math.Round(root, 8);
        }

        static public double Factorial(double num)
        {
            if (num < 1)
            {
<<<<<<< HEAD
                Console.Write("Enter a number in the range 1-20 to calculate the factorial: ");
                num = Calc.NumInput();
                Console.WriteLine();
=======
                throw new ArgumentException("The factorial of a negative number and 0 is not possible.");
>>>>>>> main
            }
            if (num > 20)
            {
                throw new ArgumentException("The calculator can calculate the factorial of a number less than 21.");
            }
            long factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        static public double Power(double num)
        {
            return num * num;
        }

        static public double NumInput()
        {
            string numberString = Console.ReadLine();
            bool isDoubleInput = double.TryParse(numberString, out double numberDouble);
            while (!isDoubleInput)
            {
                Console.Write("Wrong input! Try again: ");
                numberString = Console.ReadLine();
                isDoubleInput = double.TryParse(numberString, out numberDouble);
            }
            return numberDouble;
        }

        static public bool OperatorInput(out string mathOperator)
        {
            List<string> operatorWithSecondArgument = new List<string> { "+", "-", "*", "/", "%", "^" };
            List<string> operatorWithOneArgument = new List<string> { "sqrt", "!", "pow" };
            while (true)
            {
                mathOperator = Console.ReadLine();
                if (operatorWithSecondArgument.Contains(mathOperator))
                {
                    return true;
                }
                else if (operatorWithOneArgument.Contains(mathOperator))
                {
                    return false;
                }
                Console.WriteLine();
                Console.Write("Wrong input! Try again: ");
            }
        }
    }
}