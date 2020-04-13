using System;
using System.Collections.Generic;

namespace boxing_and_unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<object> objectList = new List<object>();
            objectList.Add(7);
            objectList.Add(28);
            objectList.Add(-1);
            objectList.Add(true);
            objectList.Add("chair");

            for ( int i = 0; i < objectList.Count; i++ ) {
                Console.WriteLine(objectList[i]);
            }
            int sum = 0;
            for (int x = 0; x < objectList.Count; x++) {
                if ( objectList[x] is int ) {
                    int num = (int) objectList[x];
                    sum = sum + num;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
