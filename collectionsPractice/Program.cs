using System;
using System.Collections.Generic;

namespace collectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("question 1........       ");
            int[] numArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
            string[] names = { "Tim", "Martin", "Nikki", "Sarah" };

            bool[] guess = { true, false, true, false, true, true, false, true, false, true };

            Console.WriteLine("Question 2........        ");

            List <string> iceCreamFlavors = new List<string>();
            iceCreamFlavors.Add("Butter Pecan");
            iceCreamFlavors.Add("Mint Chocolate Chip");
            iceCreamFlavors.Add("Mango");
            iceCreamFlavors.Add("Blueberry");
            iceCreamFlavors.Add("Chocolate");

            Console.WriteLine(iceCreamFlavors.Count);
            Console.WriteLine(iceCreamFlavors[2]);
            iceCreamFlavors.RemoveAt(2);
            Console.WriteLine(iceCreamFlavors.Count);
            Console.WriteLine("Question 3........        ");
            Dictionary <string, string> newDict = new Dictionary <string, string>();
            for ( int i = 0; i < iceCreamFlavors.Count; i++ ) {
                newDict.Add(names[i], iceCreamFlavors[i]);
            }
            foreach ( KeyValuePair<string, string> entry in newDict ) {
                Console.WriteLine(entry.Key + "-" + entry.Value);
            }
        }
    }
}
