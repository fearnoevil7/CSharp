using System;

namespace hungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rando = new Random();
            Console.WriteLine("Hello World!");

            SpiceHound Jonathon = new SpiceHound();
            SweetTooth AJ = new SweetTooth();
            Buffet buffet1 = new Buffet();
            iConsumable food1 = buffet1.serve(rando.Next(1, 7));
            iConsumable food2 = buffet1.serve(rando.Next(1, 7));
            iConsumable food3 = buffet1.serve(rando.Next(1, 7));
            iConsumable food4 = buffet1.serve(rando.Next(1, 7));
            iConsumable food5 = buffet1.serve(rando.Next(1, 7));
            iConsumable food6 = buffet1.serve(rando.Next(1, 7));
            iConsumable food7 = buffet1.serve(rando.Next(1, 7));
            Console.WriteLine("Menu       !!!!!!!!");
            for (int x = 0; x < buffet1.menu.Count; x++) {
                Console.WriteLine(buffet1.menu[x].name);
            }

            Jonathon.Consume(food1);
            Jonathon.Consume(food2);
            Jonathon.Consume(food3);
            Jonathon.Consume(food4);
            Jonathon.Consume(food5);
            Jonathon.Consume(food6);
            Jonathon.Consume(food7);


            AJ.Consume(food1);
            AJ.Consume(food2);
            AJ.Consume(food3);
            AJ.Consume(food4);
            AJ.Consume(food5);
            AJ.Consume(food6);
            AJ.Consume(food7);
            Console.WriteLine(Jonathon.IsFull);
            Console.WriteLine(AJ.IsFull);
            Console.WriteLine("Consumption History       !!!!!!!!");
            for (int i = 0; i < Jonathon.ConsumptionHistory.Count; i++) {
                Console.WriteLine(Jonathon.ConsumptionHistory[i]);
            }
            if (Jonathon.ConsumptionHistory.Count > AJ.ConsumptionHistory.Count) {
                Console.WriteLine("Jonathon consumed the most items        : " + Jonathon.ConsumptionHistory.Count);
            }
            if (Jonathon.ConsumptionHistory.Count < AJ.ConsumptionHistory.Count) {
                Console.WriteLine("AJ consumed the most items        : " + AJ.ConsumptionHistory.Count);
            }

        }
    }
}
