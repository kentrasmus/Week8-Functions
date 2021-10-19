using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("siesta esimene number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sisesta teine number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("vali tehe ('+', '-', '*', või '/'");
            char userOperation = Convert.ToChar(Console.ReadLine());

            switch (userOperation)
            {
                case '+':
                    AddTwoNumber(firstNumber, secondNumber);
                    break;
                case '/':
                    DivideTwoNumber(firstNumber, secondNumber);
                    break;
                case '-':
                    SubstractTwoNumbers(firstNumber, secondNumber);
                    break;
                case '*':
                    Multiply(firstNumber, secondNumber);
                    break;
                default:
                
                    Console.WriteLine("vale tehe");
                    break;
            }







        }

        private static void AddTwoNumber(int x, int y)
        {
            int result = x + y;
            Console.WriteLine($"{x} + {y} = {result}");

        }

        private static void DivideTwoNumber(double x, double y)
        {
            double result = x / y;
            Console.WriteLine($"{x} / {y} = {result}");
        }

        private static void SubstractTwoNumbers(double x, double y)
        {
            double result = x - y;
            Console.WriteLine($"{x} - {y} = {result}");
        }

        private static void Multiply(double x, double y)
        {
            double result = x * y;
            Console.WriteLine($"{x} * {y} = {result}");
        }

    }
}
