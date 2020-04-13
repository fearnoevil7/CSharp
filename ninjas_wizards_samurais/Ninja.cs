using System;
public class Ninja : Human {
    public Ninja (string name) : base(name) {
        this.Dexterity = 175;
    }

    public override int Attack(Human target){
        Random rando = new Random();
        int randomNum = rando.Next(1, 11);
        int temp = target.health - ( 5 * this.Dexterity);
        if (randomNum <= 2) {
            Console.WriteLine("Its a Critical Hit!!!!!!!!");
            target.health = target.health - ( 5 * this.Dexterity ) - 10;
        } else {
            Console.WriteLine("Ninja strikes!!!!!!!!!");
            target.health = target.health - ( 5 * this.Dexterity );
        }
        return target.health;
    }

    public int Steal(Human person) {
        person.health -= 5;
        this.health += 5;
        return this.health;
    }
}