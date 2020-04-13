using System;
public class SpiceHound : Ninja {
    public SpiceHound(){}

    public override bool IsFull {
        get
        {
            if (calorieIntake >= 1200) {
                return true;
            } else {
                return false;
            }
        }
    }

    public override void Consume(iConsumable item){
        bool AppetiteOrNoAppetite = this.IsFull;
        if ( AppetiteOrNoAppetite == false ) {
            calorieIntake = calorieIntake + item.calories;
            ConsumptionHistory.Add(item);
        }
        if ( AppetiteOrNoAppetite == true ) {
            Console.WriteLine("Is full!!!!!!!");
        }
    }
}