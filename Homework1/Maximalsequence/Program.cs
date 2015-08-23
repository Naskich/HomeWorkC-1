//Problem 4. Maximal sequence
            //Write a program that finds the maximal sequence of equal elements in an array.

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maximalsequence
{
    class Program
    {
        static void Main()
        {
            Console.Write("array = ");
            int lenght = int.Parse(Console.ReadLine());
            int[] array = new int[lenght];
          int besnumber = 1; 
          int numberrseq = 1; 
          int bestnum = 0; 
            for (int i = 0; i < lenght; i++)
            {
                Console.Write("arr1[{0}]=", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            foreach (var number in array)
            {
                for (int i = 0; i < number - 1; i++)
                {
                    if (array[i] == array[i + 1])
                    {
                        numberrseq++;
                    }
                    else
                    {
                        numberrseq = 1;
                    }
                    if (numberrseq >= besnumber)
                    {
                        besnumber = numberrseq;
                        bestnum = array[i];
                    for (int a = 0; a < bestnum; a++)
                        Console.Write("{0} ", bestnum);
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
