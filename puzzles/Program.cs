using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {

        public static object randomArray() {
            Random rand = new Random();
            int[] newArray = new int[10];
            for (int i = 0; i < 10; i ++) {
                int randomNumber = rand.Next(5, 26);
                newArray[i] = randomNumber;
            }
            int max = 0;
            int min = 0;
            int sum = 0;
            for (int x = 0; x < newArray.Length; x++) {
                if (x == 0) {
                    sum = newArray[x];
                    min = newArray[x];
                }
                if (min > newArray[x]) {
                    min = newArray[x];
                }
                if (max < newArray[x]) {
                    max = newArray[x];
                }
                sum += newArray[x];
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(sum);
            return newArray;
        }

        public static string TossCoin() {
            Console.WriteLine("Flipping a coin!");
            string results1 = "";
            Random rand = new Random();
            int randomNumber = rand.Next(1, 101);
            if (randomNumber > 1 && randomNumber < 50) {
                results1 = "heads";
            }
            if (randomNumber > 50 && randomNumber < 100) {
                results1 = "tails";
            }
            return results1;
        }

        public static double TossMultipleCoins(int num) {
            int headCount = 0;
            int totalTosses = 0;
            for ( int i = 0; i < num; i ++) {
                string string1 = TossCoin();
                totalTosses++;
                Console.WriteLine(string1);
                if (string1 == "heads") {
                    headCount++;
                }
            }
            double results = headCount /= totalTosses;
            Console.WriteLine(totalTosses);
            Console.WriteLine(headCount);
            return results;
        }

        public static object ListValues() {
            List <string> myList = new List <string>();
            myList.Add("Todd");
            myList.Add("Tiffany");
            myList.Add("Charlie");
            myList.Add("Geneva");
            myList.Add("Sydney");
            fisherYatesShuffle( myList );
        }

        private static int GetRandomNumber(int i) {
            Random randomNumber = new Random();
            return randomNumber.Next(i + 1);
        }

        public static void fisherYatesShuffle(string[] theList) {
            for (int i = theList.Length - 1; i > 0; i--) {
                Swap(theList, i, GetRandomNumber(i));
            }
        }

        private static void Swap(string[] theList, int i, int j){
            string temp =  theList[i];
            theList[i] = theList[j];
            theList[j] = temp;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(randomArray());
            Console.WriteLine(TossCoin());
            Console.WriteLine(TossMultipleCoins(3));
        }
    }
}
