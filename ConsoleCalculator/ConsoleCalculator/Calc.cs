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
            return x % y;
        }

        static public double Divide(double x, double y)
        {
            while (y == 0)
            {
                Console.Write("The number should not be 0. Enter second number again: ");
                y = Calc.NumInput();
                Console.WriteLine();
            }
            return x / y;
        }

        static public double Sqrt(double num)
        {
            while(num < 0)
            {
                Console.Write("The number should not be negative. Enter number again: ");
                num = Calc.NumInput();
                Console.WriteLine();
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
                { 
                    break;
                }
            }
            return Math.Round(root, 8);
        }

        static public double Factorial(double num)
        {
            long factorial = 1;
            while (!(num >= 1 && num <= 20))
            {
                Console.Write("Enter a number in the range 1-20 to calculate the factorial: ");
                num = Calc.NumInput();
                Console.WriteLine();
            }
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