/*Problem 2. Compare arrays
            • Write a program that reads two  integer  arrays 
            from the console and compares them element by element.*/

using System;

namespace CompareArrays
{
    class Program
    {
        static void Main()
        {
            //Задавм чрез Parse -n на брой елемента  по желание за масив-1
            Console.Write("elements of arrays1 = ");
            int lenght = int.Parse(Console.ReadLine());
            //Задавм чрез Parse -n на брой елемента  по желание за масив-2
            Console.Write("elements of arrays2 = ");
            int lenght2 = int.Parse(Console.ReadLine());
            // Декларирам масивите да са от тип int
            int[] array1 = new int[lenght];
            int[] array2 = new int[lenght2];
            // Въвеждам цикъл за изреждане на стойности на масива и отпечатване на масива
            for (int i = 0; i < lenght; i++)
            {
                Console.Write("arr1[{0}]=", i);
                array1[i] = int.Parse(Console.ReadLine());
            }
            for (int a = 0; a < lenght2; a++)
            {
                Console.Write("arr2[{0}]=", a);
                array2[a] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            // Задавам разпознаване на стойностите на масива като въвеждам логически операции за сравнение
            foreach (var number1 in array1)
            {
                foreach (var number2 in array2)
                {
                   if (number1 == number2)  
                   Console.WriteLine("{0} = {1} = true", number1, number2);
                   if (number1>number2 || number1<number2 )
                   Console.WriteLine("{0} not = {1} = false", number1, number2);
                }
            }
        }
    }
}
