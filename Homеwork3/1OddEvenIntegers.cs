
//Problem 1. Odd or Even Integers
//• Write an expression that checks if given integer is odd or even.

using System;

namespace OddEvenIntegers
{
    class Program
    {
        static void Main()
        {
            Console.Write(
                "Insert number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(
                    (number % 2 == 0) ? "true" : "false"); 
        }
    }
}
