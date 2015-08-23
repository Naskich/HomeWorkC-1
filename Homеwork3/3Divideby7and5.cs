
using System;

namespace Divide_by7and5
{
    class Program
    {
        static void Main()
        {
            Console.Write(
                "Divided of 7 and 5: ");
            int numberone = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(
                    (numberone % 7 == 0) & (numberone % 5 == 0)  ? "true" : "false");
        }
    }
}
