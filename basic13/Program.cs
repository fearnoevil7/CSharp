using System;
using System.Collections.Generic;

namespace basic13
{
    class Program
    {
        public static void PrintNumbers() {
            for (int i = 1; i < 256; i++) {
                Console.WriteLine(i);
            }
        }

        public static void PrintOdds() {
            for ( int i = 1; i < 256; i++ ) {
                if ( i % 2 == 1 ) {
                    Console.WriteLine(i);
                }
            }
        }

        public static void PrintSum() {
            int sum = 0;
            for ( var i = 1; i < 256; i++ ) {
                sum += i;
                Console.WriteLine("New Number: " + i + "       Sum: " + sum);
            }
        }

        public static void LoopArray(int[] array) {
            for ( int i = 0; i < array.Length; i++ ) {
                Console.WriteLine(array[i]);
            }
        }

        public static int FindMax(int[] array) {
            int count = 0;
            int max = 0;
            for ( int i = 0; i < array.Length; i++ ) {
                if ( count == 0 ) {
                    max = array[i];
                }
                if ( array[i] > max ) {
                    max = array[i];
                }
                count++;
            }
            return max;
        }

        public static int GetAverage(int[] array) {
            int sum = 0;
            for ( int i = 0; i < array.Length; i++ ) {
                sum += array[i];
            }
            int average = sum / array.Length;
            return average;
        }

        public static object OddArray() {
            List<int> oddNumber = new List<int>();
            for ( int x = 1; x < 256; x++ ) {
                if ( x % 2 == 1 ) {
                    oddNumber.Add(x);
                }
            }
            return oddNumber;
        }

        public static int GreaterThanY(int[] array, int y) {
            int count = 0;
            for ( int i = 0; i < array.Length; i++ ) {
                if ( array[i] > y ) {
                    count++;
                }
            }
            return count;
        }

        public static void squareArrayValues(int[] array) {
            for ( int i = 0; i < array.Length; i++ ) {
                array[i] = array[i] * array[i];
            }
            Console.WriteLine(array);
        }

        public static void EliminateNegatives(int[] array) {
            for ( int x = 0; x < array.Length; x++ ) {
                if ( array[x] < 0 ) {
                    array[x] = 0;
                }
            }
        }

        public static void MinMaxAverage(int[] array) {
            int max = 0;
            int min = 0;
            int sum = 0;
            for (int i = 0; i < array.Length; i++) {
                if ( array[i] < min ) {
                    min = array[i];
                }
                if ( array[i] > max ) {
                    max = array[i];
                }
                sum += array[i];
            }
            int average = sum / array.Length;
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(average);
        }

        public static void shiftValues(int[] array) {
            int temp;
            for (int i = array.Length; i >= 0; i--) {
                if ( i > 0 ) {
                    temp = array[i - 1];
                    array[i] = temp;
                    if ( i - 1 == array.Length ) {
                        array[i] = 0;
                    }
                }
            }
        }

        public static object NumToString(int[] array) {
            List <object> objectArray = new List <object>();
            for ( int i = 0; i < array.Length; i++ ) {
                objectArray.Add(array[i]);
                if ( array[i] < 0 ) {
                    objectArray.Add("Dojo");
                }
            }
            return objectArray;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PrintNumbers();
            PrintOdds();
            PrintSum();
            int[] test1 = {10, 3, 8, 7, -6};
            LoopArray(test1);
            Console.WriteLine(FindMax(test1));
            Console.WriteLine(GetAverage(test1));
            Console.WriteLine(OddArray());
            Console.WriteLine(GreaterThanY(test1, 7));
            squareArrayValues(test1);
            Console.WriteLine(test1);
            EliminateNegatives(test1);
            Console.WriteLine(test1);
            MinMaxAverage(test1);
            // shiftValues(test1);
            // Console.WriteLine(test1);
            Console.WriteLine(NumToString(test1));
        }
    }
}
