
/*Problem 3. Variable in Hexadecimal Format
        •Declare an integer variable and assign it with 
        * the value  254  in hexadecimal format ( 0x## ).
        • Use Windows Calculator to find its hexadecimal representation.
        • Print the variable and ensure that the result is  254 .*/
using System;


namespace VariableinHexadecimal
{
    class VariableinHexadecimal
    {
        static void Main()
        {
            int numberValue = (0xFE);
            Console.WriteLine(" Decimal : {0} дели се на 16 / 0x{0:X}", numberValue);
            //Получената стойност се получава от долният израз,
            // като в таблицата за 15=F, 14=E
            byte h = 254;
            byte r = 16;
            dynamic j = h / r;
            Console.WriteLine(" Първи остатък {0} \n Втори остатък {1}\n,", j, h - j * r);
            Console.WriteLine("15=F\n14=E");
        }
    }
}
