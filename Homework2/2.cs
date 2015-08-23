 /*Problem 11. Bank Account Data
            • A bank account has a holder name 
            (first name, middle name and last name), 
            available amount of money (balance), 
            bank name, IBAN, 3 credit card numbers 
            associated with the account.
            • Declare the variables needed to keep the information 
            for a single bank account using the appropriate 
            data types and descriptive names.*/

using System;

namespace BankAccount
{
    class Program
    {
        static void Main()
        {
            string input;
            Console.WriteLine(
                    " first name (Name):");
            string firstname = Console.ReadLine();
            Console.WriteLine(
                    " middle name (Name):");
            string middlename = Console.ReadLine();
            Console.WriteLine(
                               " last name (Name):");
            string lastname = Console.ReadLine();
            Console.WriteLine(
                    " Bank name (Name):");
            string bankname = Console.ReadLine();
            Console.WriteLine(
                    " IBAN (IBAN):");
            string iban = Console.ReadLine();
            Console.WriteLine(
                    "Enter number of first credit card:");
                                string firstCard = Console.ReadLine(); 
            Console.WriteLine(
                    "Enter number of second credit card:"); 
                                string secondCard = Console.ReadLine(); 
            Console.WriteLine(
                    "Enter number of third credit card :"); 
                                string thirdtCard = Console.ReadLine(); 
            ushort  amountmaxto  = 43878;
            sbyte withdrawto = 100;
            Console.WriteLine(
                    " available amount of money (balance) {0}:", amountmaxto);
            Console.WriteLine(
                    " withdraw to (1...100):");
            input = Console.ReadLine();
            dynamic balance = amountmaxto - withdrawto;
            Console.WriteLine(
                    "amount of money (balance){0}", balance);
         Console.WriteLine("first name:{0}",firstname); 
         Console.WriteLine("middle name:{0}",middlename); 
         Console.WriteLine("last name:{0}",lastname); 
         Console.WriteLine("balance:{0}", balance); 
         Console.WriteLine("bank name:{0}",bankname); 
         Console.WriteLine("IBAN: {0}",iban); 
         Console.WriteLine("first credit card:{0}",firstCard); 
         Console.WriteLine("second credit card:{0}", secondCard); 
         Console.WriteLine("third credit card:{0}", thirdtCard);
        }
    }
}