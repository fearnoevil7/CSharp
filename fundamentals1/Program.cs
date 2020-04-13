using System;

namespace fundamentals1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 1.......       ");
            for(int i = 1; i < 256; i++) {
                Console.WriteLine(i);
            }
            Console.WriteLine("Question 2.......       ");

            for(int q = 1; q < 101; q++) {
                if(q % 5 == 0 && q % 3 == 0) {
                    Console.WriteLine(q + " is divisible by both 3 and 5");
                } else if ( q % 5 == 0 && q % 3 != 0) {
                    Console.WriteLine(q);
                }   else if ( q % 3 == 0 && q % 5 != 0 ) {
                    Console.WriteLine(q);
                }
            }
            Console.WriteLine("Question 3......       ");

            for(int q = 1; q < 101; q++) {
                if(q % 5 == 0 && q % 3 == 0) {
                    Console.WriteLine("FizzBuzz");
                } else if ( q % 5 == 0 && q % 3 != 0) {
                    Console.WriteLine("Fizz");
                }   else if ( q % 3 == 0 && q % 5 != 0 ) {
                    Console.WriteLine("Buzz");
                }
            }
        }
    }
}
