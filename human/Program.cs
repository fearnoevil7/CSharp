using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Human Jonathon = new Human("Jonathon");
            Human AfroSamurai = new Human("Afro");
            Jonathon.Attack(AfroSamurai);
            Console.WriteLine(Jonathon.Name);
            Console.WriteLine(AfroSamurai.Name);
            Console.WriteLine(AfroSamurai.showHealth());
            
        }
    }
}
