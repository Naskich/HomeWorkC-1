    /*Problem 3. Compare char arrays
                • Write a program that compares two  char 
                 * arrays lexicographically (letter by letter).*/

using System;
using System.Collections.Generic;

namespace Comparechararrays
{
    class Program
    {
        static void Main()
        {
            char[] alfab1 = new char[] { 'a', 'b', 'c', 'd', 'e' };
            char[] alfab2 = new char[] { 'm', 'b', 's', 'd', 'n' };
            foreach (char simbol1 in alfab1)
            {
                System.Console.Write("{0}", simbol1);
            }
            Console.WriteLine(" - аrray1");
            foreach (char simbol2 in alfab2)
            {
                System.Console.Write("{0}", simbol2);
            }
            Console.WriteLine(" - array2");
            {
                bool equal = alfab1[0] == alfab2[0];
                Console.WriteLine("false = {0}", alfab1[0]);
            }
            {
                bool equal = alfab1[1] == alfab2[1];
                Console.WriteLine("true = {0}", alfab1[1]);
            }
            {
                bool equal = alfab1[2] == alfab2[2];
                Console.WriteLine("false = {0}", alfab1[2]);
            }
            {
                bool equal = alfab1[3] == alfab2[3];
                Console.WriteLine("true = {0}", alfab1[3]);
            }
            {
                bool equal = alfab1[4] == alfab2[4];
                Console.WriteLine("false = {0}", alfab1[4]);
            }
        }
    }
}
