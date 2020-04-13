using System;

namespace hungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rando = new Random();
            Console.WriteLine("Hello World!");

            Ninja ninja1 = new Ninja();
            Buffet buffet1 = new Buffet();
            Food food1 = buffet1.serve(rando.Next(1, 7));
            Food food2 = buffet1.serve(rando.Next(1, 7));
            Food food3 = buffet1.serve(rando.Next(1, 7));
            Food food4 = buffet1.serve(rando.Next(1, 7));
            Food food5 = buffet1.serve(rando.Next(1, 7));
            Food food6 = buffet1.serve(rando.Next(1, 7));
            Food food7 = buffet1.serve(rando.Next(1, 7));
            Console.WriteLine("Menu       !!!!!!!!");
            for (int x = 0; x < buffet1.menu.Count; x++) {
                Console.WriteLine(buffet1.menu[x].name);
            }

            ninja1.Eat(food1);
            ninja1.Eat(food2);
            ninja1.Eat(food3);
            ninja1.Eat(food4);
            ninja1.Eat(food5);
            ninja1.Eat(food6);
            ninja1.Eat(food7);

            Console.WriteLine(ninja1.isFull);
            Console.WriteLine("Food History       !!!!!!!!");
            for (int i = 0; i < ninja1.FoodHistory.Count; i++) {
                Console.WriteLine(ninja1.FoodHistory[i].name);
            }
        }
    }
}
