
//Problem 7. Sum of 5 Numbers
//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;


namespace Sum_of_5Numbers
{
    class Program
    {
        static void Main()
        {
            Console.Write("a = ");
            double number1 = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double number2 = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double number3 = double.Parse(Console.ReadLine());
            Console.Write("d = ");
            double number4 = double.Parse(Console.ReadLine());
            Console.Write("e = ");
            double number5 = double.Parse(Console.ReadLine());
            dynamic sum = number1 + number2 + number3 + number4 + number5;
            Console.WriteLine("Sum a + b + c = {0}", sum);
        }
    }
}
