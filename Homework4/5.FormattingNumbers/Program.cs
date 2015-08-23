
/*Problem 5. Formatting Numbers
        • Write a program that reads 3 numbers: ◦ integer  a  (0 <= a <= 500)
        ◦ floating-point  b  
        ◦ floating-point  c  
        • The program then prints them in 4 virtual columns on the console. Each column 
            should have a width of 10 characters. ◦ The number  a  should be printed in hexadecimal, left aligned
        ◦ Then the number  a  should be printed in binary form, padded with zeroes
        ◦ The number  b  should be printed with 2 digits after the decimal point, right aligned
        ◦ The number c should be printed with 3 digits after the decimal point, left aligned.*/


using System;

namespace FormattingNumbers
{
    class Program
    {
        static void Main()
        {
              int numberA = int.Parse(Console.ReadLine());
            double numberB = double.Parse(Console.ReadLine());
            double numberC = double.Parse(Console.ReadLine());
            Console.WriteLine("a = {0} ; b = {1} ; c = {2} ;", numberA, numberB, numberC);
             Console.WriteLine(
             "Insert for (0 < a < 500), a floating b, a floating c,"+"Еnter for each:");
            Console.Clear();
            Console.WriteLine("{0,-10}{1,-10}{2,-10}{3}", "a", "b", "c", "result");
            Console.WriteLine("{0,-10}{1,-10}{2,-10}  {3,-10:X}  {4,-10}  {5,10:0.00}  {6,-10:0.000} ",
                numberA, numberB, numberC, numberA, Convert.ToString(numberA, 2).PadLeft(10, '0'), numberB, numberC);
             Console.WriteLine();
        }
    }
}
