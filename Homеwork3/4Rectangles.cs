
/* Problem 4. Rectangles
            Write an expression that calculates rectangle’s 
            *perimeter and area by given width and height.*/

using System;

namespace Rectangles
{
    class Program
    {
        static void Main()
        {
            string input; 
                Console.WriteLine("width");
                double width = double.Parse(Console.ReadLine());
                Console.WriteLine("height");
                double height = double.Parse(Console.ReadLine());
                        dynamic area = width * height;
                        dynamic piremeter = width*2 + height*2;
            Console.WriteLine(" area {0}",area);
            Console.WriteLine("piremeter {0}", piremeter);
        }
    }
}
