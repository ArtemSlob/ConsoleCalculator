using System;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple console calculator\n");
            Console.Write("Input first operand: ");
            double firstOperand = Calc.NumInput();
            Console.WriteLine();
            Console.Write("Input operator (+ - * / % sqrt ! pow): ");
            bool isSecondNeed = Calc.OperatorInput(out string mathOperator);
            Console.WriteLine();
            double secondOperand = 0;
            if (isSecondNeed == true)
            {
                Console.WriteLine("Input second operand: ");
                secondOperand = Calc.NumInput();
                Console.WriteLine();
            }
            double result = 0;
            switch (mathOperator)
            {
                case "+":
                    result = Calc.Sum(firstOperand, secondOperand);
                    break;
                case "-":
                    result = Calc.Subtract(firstOperand, secondOperand);
                    break;
                case "*":
                    result = Calc.Multiply(firstOperand, secondOperand);
                    break;
                case "/":
                    result = Calc.Divide(firstOperand, secondOperand);
                    break;
                case "%":
                    result = Calc.RestOfDivide(firstOperand, secondOperand);
                    break;
                case "sqrt":
                    result = Calc.Sqrt(firstOperand);
                    break;
                case "!":
                    result = Calc.Factorial(firstOperand);
                    break;
                case "pow":
                    result = Calc.Power(firstOperand);
                    break;
                default:
                    Console.WriteLine("No such operator!");
                    break;
            }
            Console.WriteLine($"Your result is: {result}");
        }
    }
}