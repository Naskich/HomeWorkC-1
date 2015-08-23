//Problem 3. Circle Perimeter and Area
            //Write a program that reads the radius  r  of a circle and prints its perimeter 
            //and area formatted with  2  digits after the decimal point.
using System;

namespace CirclePerimeterArea
{
    class Program
    {
        static void Main()
        {
            double pi = 3.14;
            Console.Write(" for perimeter r  = ");
            double perimeter = double.Parse(Console.ReadLine());
            perimeter = 2*pi*perimeter;
            Console.WriteLine("P = {0: 0.00}",perimeter);
            Console.Write(" for area r = ");
            double area = double.Parse(Console.ReadLine());
            area = pi * area * area;
            Console.WriteLine("S = {0: 0.00}", area);
        }
    }
}
