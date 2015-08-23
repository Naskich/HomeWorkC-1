//Problem 4. Number Comparer
        //Write a program that gets two numbers from the console and prints the greater of them.
        //Try to implement this without if statements.

using System;

namespace NumberComparer
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insert number for a and b from type double:");
            double a= double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("a = {0}; b = {1} ", a, b);
            double c = a = b; 
                Console.WriteLine("greater = {0}", c);
                (а > b) ? a : b;
            //if (a>b)
            //    Console.WriteLine("greater = {0}", a);
              //  if (b>a)
                //    Console.WriteLine("greater = {0}", b);
            Console.WriteLine();                
        }
    }
}
