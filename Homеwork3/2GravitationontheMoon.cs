using System;

namespace _2GravitationontheMoon
{
    class Program
    {
        static void Main()
        {
            double input;
                Console.WriteLine(
                    "insert weight");
                     double weight = double.Parse(Console.ReadLine());
                        double diferent = 0.17;
                            dynamic weightr = weight * diferent;
                     Console.WriteLine(
                         "Write weight on the Moon{0}",weightr);
        }
    }
}
