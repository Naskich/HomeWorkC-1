//Problem 7. Point in a Circle
         //Write an expression that checks if 
        //given point (x, y) is inside a circle  K({0, 0}, 2) .

    using System;

    namespace PointinaCircle
    {
        class Program
        {
            static void Main()
            {
                Console.Write("x = ");
                Console.Write("y = ");
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                bool insidec = (x * x) + (y * y) <= (2 * 2);
                Console.WriteLine(
                    "These coordinates  = " + insidec);
            }
        }
}
