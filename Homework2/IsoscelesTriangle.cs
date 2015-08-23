/*Problem 8. Isosceles Triangle
• Write a program that prints an isosceles triangle 
 * of 9 copyright symbols  © , something like this:
   ©
  © ©
 ©   ©
© © © ©
Note: The  ©  symbol may be displayed incorrectly at 
the console so you may need to change the console character 
 * encoding to  UTF-8  and assign a Unicode-friendly font in the console.
Note: Under old versions of Windows the  ©  symbol may still be 
 * displayed incorrectly, regardless of how much effort 
 * you put to fix it.*/
using System;

namespace IsoscelesTriangle
{
    class IsoscelesTriangle
    {
        static void Main()
        {
            char simbol = '©';
            Console.WriteLine("The code of {0} is {1}",
                simbol, (int)simbol);
             char   simbols='©';
             char     sim = '©';
             char     sims = '©';
             char       simss = '©';
             char        simbolss = '©';
            Console.WriteLine("        {0}   ",simbols);
            Console.WriteLine("       {0} {1}  ", simbols,sim);
            Console.WriteLine("      {0}   {1}  ", simbols,sims);
            Console.WriteLine("     {0} {1} {2} {3} ", simbols,sims,simss,simbolss);
        }
    }
}
