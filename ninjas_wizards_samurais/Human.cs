public class Human {
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    public int health;

    int getHealth {
        get
        {
            return health;
        }
    }

    public int showHealth() {
        return health;
    }

    public Human(string nombre) {
        Name = nombre;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3;
        health = 100;
    }

    public Human (string nombre, int fuerza, int intelligencia, int reflexes, int vitality) {
        Name = nombre;
        Strength = fuerza;
        Intelligence = intelligencia;
        Dexterity = reflexes;
        health = vitality;
    }

    public virtual int Attack(Human target){
        target.health = target.health - (5 * this.Strength);
        return target.health;
    }
}