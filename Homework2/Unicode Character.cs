
 /*Problem 4. Unicode Character
               • Declare a character variable and assign it with the symbol that 
               * has Unicode code  42  (decimal) using the  
               * \u00XX  syntax, and then print it.
               Hint: first, use the Windows Calculator to find the 
               * hexadecimal representation of  42 . The output should be*/ 
 using System;

    namespace UnicodeCharacter
    {
        class Program
        {
            static void Main()
            {
                char simbol = '*';
                Console.WriteLine(
                   "The code of '{0}' is '{1}'",
               simbol, (int)simbol);
                char character = '\u002A';
                Console.WriteLine(
                   "Отпечатай символа {0}", character);
            }
        }
    }
