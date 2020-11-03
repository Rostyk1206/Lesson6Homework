using System;

namespace Lesson6Homework5
{
    class Program
    {
        static void PositiveNegative(int a)
        {
            if (a > 0)
            {
                Console.WriteLine("Your number is Positive");
            }
            else
            {
                Console.WriteLine("You number is Negetive");
            }
        }
        static void Simple(int a)
        {
            if (a > 1)
            {
                for (int i = 2; i < Math.Sqrt(a); i++)
                {
                    if (a % i == 0)
                    {
                        Console.WriteLine("Your number is not Simple");
                        
                    }
                }
            }
            
            else
            {
                Console.WriteLine("You number is  Simple");
            }
        }
        static void Div(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("Yes, its divided on 2 without rest");

            }
            else if (a % 2 != 0)
            {
                Console.WriteLine("Yes, its divided on 2 with rest");
            }
             if (a % 5 == 0)
            {
                Console.WriteLine("Yes, its divided on 5 without rest");

            }
            else if (a % 5 != 0)
            {
                Console.WriteLine("Yes, its divided on 5 with rest");
            }
             if (a % 3 == 0)
            {
                Console.WriteLine("Yes, its divided on 3 without rest");

            }
            else if (a % 3 != 0)
            {
                Console.WriteLine("Yes, its divided on 3 with rest");
            }
             if (a % 6 == 0)
            {
                Console.WriteLine("Yes, its divided on 6 without rest");

            }
            else if (a % 6 != 0)
            {
                Console.WriteLine("Yes, its divided on 6 with rest");
            }
             if (a % 9 == 0)
            {
                Console.WriteLine("Yes, its divided on 9 without rest");

            }
            else if (a % 9 != 0)
            {
                Console.WriteLine("Yes, its divided on 9 with rest");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Plese, enter your number:");
            int number = int.Parse(Console.ReadLine());
            PositiveNegative(number);
            Simple(number);
            Div(number);
        }
    }
}
