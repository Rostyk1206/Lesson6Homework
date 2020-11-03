using System;

namespace Lesson6Homework4
{
    class Program
    {
        static double Con(double a, double b)
        {
            return a*b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter your quantity of money in dollar:");
            double quantity = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your convertion rate in accordance to hryvnia:");
            double con = double.Parse(Console.ReadLine());
            double result = Con(quantity, con);
            Console.WriteLine($"You have {result} hryvnias");
        }
    }
}
