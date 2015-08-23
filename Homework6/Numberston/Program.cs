//Problem 1. Numbers from 1 to N
            //Write a program that enters from the console a positive integer  n  
            //and prints all the numbers from  1  to  n , 
            //on a single line, separated by a space.

using System;


namespace HomeworkCikly
{
    class Program
    {
        static void Main()
        {
            Console.Write("Въведи число до 10000 а = ");
            int maxnumber = 10000;
            int a = int.Parse(Console.ReadLine());
            int number = a; 
            {
                for (int n = 1; n <= number; n++)
                {
                    if (a > maxnumber)   
                        break;
                    if (a <= maxnumber)
                  Console.WriteLine(n);
                }
            }
        }
    }
}
