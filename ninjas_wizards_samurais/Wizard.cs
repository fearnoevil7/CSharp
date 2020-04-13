public class Wizard : Human {
    public Wizard (string name) : base(name) {
        this.health = 50;
        this.Intelligence = 25;
    }

    public override int Attack(Human target){
        int temp = target.health - ( 5 * this.Intelligence);
        target.health = target.health - ( 5 * this.Intelligence );
        this.health += temp;
        return target.health;
    }

    public int Heal(Human person) {
        person.health += (this.Intelligence * 10);
        return person.health;
    }
}