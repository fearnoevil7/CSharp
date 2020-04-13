public class Samurai : Human {
    public Samurai (string name) : base(name){
        this.health = 200;
    }

    public override int Attack(Human target){
        if ( target.health < 50 ) {
            target.health = 0;
            return target.health;
        }
        return base.Attack(target);
    }

    public int Meditate(){
        this.health = 200;
        return this.health;
    }
}