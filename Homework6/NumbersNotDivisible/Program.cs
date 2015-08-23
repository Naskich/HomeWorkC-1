//Problem 2. Numbers Not Divisible by 3 and 7
            //Write a program that enters from the console a positive integer  n  
            //and prints all the numbers from  1  to  n  not divisible by  3  and  7 , 
            //on a single line, separated by a space.
using System;

namespace NumbersNotDivisible
{
    class Program
    {
        static void Main()
        {
            Console.Write("Insert number for 10000>i = ");
            int maxnumber=9999;
            int i = int.Parse(Console.ReadLine());
            int number = i;
            {    
                for (int n = 1; n <= number; n++)
                      if (n % 3 != 0 && n % 7 != 0) 
                        if (i <= maxnumber)
                    Console.WriteLine(n);
                }
        }
    }
}
