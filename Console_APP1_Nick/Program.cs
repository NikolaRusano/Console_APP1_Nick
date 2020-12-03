using System;
using System.Collections.Generic;

namespace Console_APP1_Nick
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Make a choice: \n 1. Create new account; \n 2. Get info about my account \n 3. Exit ");
            Console.WriteLine("Input choice functions number");
            int choice = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();

            Dictionary<int, string> accountdata = new Dictionary<int, string>(5);
            accountdata.Add(rnd.Next(), "Person1");
            accountdata.Add(rnd.Next(), "Person2");
            accountdata.Add(rnd.Next(), "Person3");
            accountdata.Add(rnd.Next(), "Person4");
            accountdata.Add(rnd.Next(), "Person5");
            while (choice != 3){
               
                
                switch (choice)
                {
                    case 1:

                        int newAccount = rnd.Next();
                        Console.WriteLine($"New account number is: {newAccount}");
                        break;
                    case 2:
                        
                        
                        Console.WriteLine("Accounts Numbers and its owners:");
                        foreach (KeyValuePair<int, string> keyValue in accountdata)
                        {
                            Console.WriteLine(keyValue.Key + " - " + keyValue.Value);

                        }
                        break;
                    default:
                        Console.WriteLine("Inncorrect input, please input 1,2 or 3 value");
                        break;
                }
                Console.WriteLine("Input choice functions number");
                choice = Convert.ToInt32(Console.ReadLine());
            }

        }


    }

}