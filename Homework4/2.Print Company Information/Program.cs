// Problem 2. Print Company Information
/*A company has name, address, phone number, fax number, web site and manager. 
The manager has first name, last name, age and a phone number.
• Write a program that reads the information about a company and 
its manager and prints it back on the console.*/

using System;

namespace PrintCompanyInformation
{
    class Program
    {
        static void Main()
        {
            string input;
                Console.WriteLine(" Company name:");
                    string companyname = Console.ReadLine();
                    Console.WriteLine(" Company address:");
                    string companyaddress = Console.ReadLine();
                    Console.WriteLine(" Phone number:");
                    string phonenumber = Console.ReadLine();
                    Console.WriteLine("Fax numbe:");
                    string faxnumber = Console.ReadLine();
                    Console.WriteLine("Web site:");
                    string website = Console.ReadLine();
                    Console.WriteLine("Manager age:");
                    string managerage = Console.ReadLine();
                    Console.WriteLine("Manager phone:");
                    string managerphone = Console.ReadLine();
                    Console.WriteLine("Manager last name:");
                    string namesfirst = Console.ReadLine();
                    Console.WriteLine("Manager first name:");
                    string namessecond = Console.ReadLine();
               Console.WriteLine("Company name:     {0} " , companyname);
               Console.WriteLine("Company address:  {0} ", companyaddress);
               Console.WriteLine("Phone number:     {0} ", phonenumber);
               Console.WriteLine("Fax number:       {0} ", faxnumber);
               Console.WriteLine("Web site:         {0} ", website);
               Console.WriteLine("Manager:          {0} {1} (Age: {2}, tel. {3})",namesfirst,namessecond,managerage, managerphone);
        }
    }
}
