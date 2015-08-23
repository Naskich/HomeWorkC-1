
using System;

namespace Quadratic_Equation
{
    class Program
    {
        static void Main()
        {
            double coefficientA = double.Parse(Console.ReadLine());
            double coefficientB = double.Parse(Console.ReadLine());
            double coefficientC = double.Parse(Console.ReadLine());
            double determinant = (coefficientB * coefficientB) - (4 * coefficientA * coefficientC);

            if (determinant < 0)
            {
                Console.WriteLine("DETERMINANT < 0 - > NO X1 and X2");
            }
            else if (determinant > 0)
            {
                Console.WriteLine("X1 = {0}", (-coefficientB - Math.Sqrt(determinant)) / (2 * coefficientA));
                Console.WriteLine("X2 = {0}", (-coefficientB + Math.Sqrt(determinant)) / (2 * coefficientA));
            }
            else
            {
                Console.WriteLine("DETERMINANT = 0 - > X1 = X2 = {0}", (-coefficientB / (2 * coefficientA)));
            }
        }
    }
}
