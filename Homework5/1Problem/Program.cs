﻿//Problem 1. Exchange If Greater
        //Write an if-statement that takes two double variables a and b and exchanges their values if 
        //the first one is greater than the second one. 
        //As a result print the values a and b, separated by a space.


using System;

namespace Homework4
{
    class Program
    {
        static void Main()
        { 
       int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        if (a > b)
        {
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;
            Console.WriteLine(a + " " + b);
        }
        else
        {
            Console.WriteLine(a + " " + b);
        }
        }
    }
}
