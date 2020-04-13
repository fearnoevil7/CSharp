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
            Wizard mickyMouse = new Wizard("Micky Mouse");
            Samurai jack = new Samurai("Samurai Jack");
            Ninja ryzu = new Ninja("Ryzu");
            Console.WriteLine(mickyMouse.Attack(jack));
            Console.WriteLine(ryzu.Attack(mickyMouse));
            Console.WriteLine(jack.Attack(mickyMouse));
            Console.WriteLine(ryzu.Attack(jack));
            Console.WriteLine(jack.Meditate());
            Console.WriteLine(mickyMouse.Heal(jack));
            Console.WriteLine(ryzu.Steal(jack));
            Console.WriteLine(jack.health);
        }
    }
}
