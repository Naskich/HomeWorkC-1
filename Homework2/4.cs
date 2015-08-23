 /*Problem 10. Employee Data          
            A marketing company wants to keep record of its employees. Each record would have the following characteristics:
            • First name
            • Last name
            • Age (0...100)
            • Gender (m or f)
            • Personal ID number (e.g. 8306112507)
            • Unique employee number (27560000…27569999)
            Declare the variables needed to keep the information for a single 
            employee using appropriate primitive data types. 
            Use descriptive names. Print the data at the console.*/
    using System;

    namespace Employeedata
    {
        class Program
        {
            static void Main()
            {
                string input;
                Console.WriteLine(
                    " First name (Name):");
                            input = Console.ReadLine();
                Console.WriteLine(
                    " Last name (Name):");
                             input = Console.ReadLine();
                Console.WriteLine(
                    " Age (0...100):");
                            input = Console.ReadLine();
                Console.WriteLine(
                    "Gender (m or f):");
                             input = Console.ReadLine();
                Console.WriteLine(
                    "Personal ID number(e.g.8306112507):");
                             input = Console.ReadLine();
                Console.WriteLine(
                    "Unique employee number(27560000…27569999):");
                             input = Console.ReadLine();
            }
        }
    }
