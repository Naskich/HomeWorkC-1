//Problem 5. Third Digit is 7?
        //Write an expression that checks for
        //given integer if its third digit from 
        //right-to-left is  7 
using System;


namespace Third_Digitis7
{
    class ThirdDigit
    {
        static void Main()
        {
            Console.WriteLine("number");
            int a = int.Parse(Console.ReadLine());
            int b = a / 100 ;
            int c = (b %10 ) ;
                if (c %7 ==0)
                Console.Write("True: {0},", c);
            else
                Console.Write("False {0},", c);
        }
    }
}