/*Problem 3. Min, Max, Sum and Average of N Numbers
            • Write a program that reads from the console a sequence of  n  integer numbers and returns the minimal, 
            the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
            • The input starts by the number  n  (alone in a line) followed by  n  lines, each holding an integer number.
            • The output is like in the examples below.*/

using System;

namespace MinMaxSumAverageofN
{
    class Program
    {
        static void Main()
        {
            int count = 0;
            Console.Write("input1 = ");
            int input1 = int.Parse(Console.ReadLine());
            if (-10 < input1 && input1 < 9)
                Console.Write("input2 = ");
            int input2 = int.Parse(Console.ReadLine());
            if (-10 < input2 && input2 < 9)
                Console.Write("input3 = ");
            int input3 = int.Parse(Console.ReadLine());
            if (-10 < input3 && input3 < 9)
                Console.Write("input4 = ");
            int input4 = int.Parse(Console.ReadLine());
            if (-10 < input4 && input4 < 9)
                Console.WriteLine("number  {0} , {1} , {2} , {3}", input1, input2, input3, input4);
            dynamic avg = (input1 + input2 + input3 + input4);
            if (input4 == 0)
            {
                Console.WriteLine("avg = {0:0.00}", avg / 4.00);
            }
            else
                Console.WriteLine("avg = {0:0.00}", avg / 3.00);
            count = input1 + input2 + input3 + input4 ;
            Console.WriteLine("sum = {0}",count );
            if (input3 > input4 && input4 > input2 && input1 > input3)
                Console.WriteLine("max = {0} and min = {1}",input1,input2);
            if (input3 < input4 && input3 > input2 && input2 > input1)
                Console.WriteLine("max = {0} and min = {1}", input4, input1);
            if (input4 < input1 && input3 > input2 && input2 > input1)
                Console.WriteLine("max = {0} and min = {1}", input3, input1);
            if (input4 < input3 && input3 < input2 && input4 > input1)
                Console.WriteLine("max = {0} and min = {1}", input2, input1);
            if (input3 < input4 && input1 < input3 && input1 > input2)
                Console.WriteLine("max = {0} and min = {1}", input4, input2);
            Console.WriteLine();
        }
    }
}
