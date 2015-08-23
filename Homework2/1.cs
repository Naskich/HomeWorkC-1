    /*Problem 12. Null Values Arithmetic
            • Create a program that assigns null values to an integer and to a double variable. 
            • Try to print these variables at the console. 
            • Try to add some number or the null literal to these variables and print the result.*/

    using System;

    namespace Arithmetic
    {
        class Program
        {
            static void Main()
            {
                int    a = 34;
                float  b = 3.01f;
                int    c = 0;
                double d = 76;
                int?   h = null;
                dynamic sum1 = a + d ;
                dynamic sum2 = b + d ;
                dynamic sum3 = b + d + h + c + a;
                dynamic sum4 = h + d;
                dynamic sum5 = c + d; 
                Console.WriteLine(
                    "Сума от a + d\n{0}",sum1);
                Console.WriteLine(
                    "Сума от b + d\n{0}", sum2);
                Console.WriteLine(
                    "Сума от b + d + h + c + a\n{0}", sum3);
                Console.WriteLine(
                    "Сума от d + h \n{0}", sum4);
                Console.WriteLine(
                    "Сума от d + c \n{0}", sum5);
            }
        }
    }
