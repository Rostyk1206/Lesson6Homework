using System;

namespace Lesson6Homework1
{
    class Program
    {
        static int Calculate (int a, int b, int c)
        {
           int result= (a+b+c)/3;
            return result;
        }
        static void Main(string[] args)
        {
            int result = Calculate(2, 4, 6);
            Console.WriteLine(result);
        }
    }
}
