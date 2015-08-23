/*Problem 2. Float-Double
            Which of the following values can be assigned to a variable of type  
            * float  and which to a variable of type  double :  34.567839023, 12.345, 
            * 8923.1234857, 3456.091 ? Write a program to assign the numbers in variables and 
            *print them to ensure no precision is lost.*/
using System;

namespace Float_Double
{
    class Program
    {
        static void Main()
        {
            float x = 3456.091f;
            float g = 12.345f;
            double z = 34.567839023;
            double s = 8923.1234857;
            Console.WriteLine(
                "Oтпечатай:\n{0}\n{1}\n{2}\n{3}\n", x, g, z, s);
            //Използвам "dynamic", защото има универсална функция
            //Сумирам двата типа рпоменливи от тип "double и float" без разлика в дебъгера
            dynamic sumf = x + g;
            Console.WriteLine(
                "Изчисли сума от тип - float: {0}", sumf);
            dynamic sumd = z + s;
            Console.WriteLine(
                "Изчисли сума от тип - double:{0}", sumd);
            // В този случай сумирам " double и float" 
            // в дебъгера показва разлика межу конзолата
            // 3490.658903476125
            // 3490.65890347613
            dynamic sumfd1 = x + z;
            Console.WriteLine(
                "Изчисли float-double x+z :{0}", sumfd1);
            dynamic sumfd2 = g + s;
            Console.WriteLine(
                "Изчисли float-double g+s :{0}", sumfd2);
        }
    }
}
