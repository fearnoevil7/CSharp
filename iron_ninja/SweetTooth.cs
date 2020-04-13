using System;
public class SweetTooth : Ninja {
    public SweetTooth(){}

    public override bool IsFull {
        get
        {
            if (calorieIntake >= 1500) {
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