 /*Problem 1. Allocate array
                • Write a program that allocates array of  20  
                integers and initializes each element by its index multiplied by  5 .
                • Print the obtained array on the console.*/
    
using System;

namespace HomeworkArrays
{
    class Program
    {
        static void Main()
        {
            int[] arr1 = new int[20] { 
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            for (int index = 0; index < 20; index++)
                Console.WriteLine("Element multiplied by 5 * {0} = {1}", arr1[index], arr1[index]* 5);
        }
    }
}
