using System;

namespace Lesson6Homework3
{
    class Program
    {
        static int Add (int a, int b)
        {
            return a + b;
        }
        static int Sub(int a, int b)
        {
            return a - b;
        }
        static int Mul(int a, int b)
        {
            return a * b;
        }
      
        static int Div(int a, int b)
        {
            return a / b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please, put your number 1:");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please, put your number 2:");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your operation (+; -; *; /):");
            string operation = Console.ReadLine();

            switch(operation)
            {
                case "+":
                    {
                        int result = Add(number1, number2);
                        Console.WriteLine($"Result:{result}");
                        break;
                    }
                case "-":
                    {
                        int result = Sub(number1, number2);
                        Console.WriteLine($"Result:{result}");
                        break;
                    }
                case "*":
                    {
                        int result = Mul(number1, number2);
                        Console.WriteLine($"Result:{result}");
                        break;
                    }
                case "/":
                    {
                        if (number2 == 0)
                        {
                            Console.WriteLine("You cannot divide by 0");
                            break;
                        }
                        else
                        {
                            int result = Div(number1, number2);
                            Console.WriteLine($"Result:{result}");
                            break;
                        }
                    }
            }
        }
    }
}
