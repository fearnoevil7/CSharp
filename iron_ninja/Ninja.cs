using System.Collections.Generic;
using System.Diagnostics;

public abstract class Ninja {
    protected int calorieIntake;
    public List<iConsumable> ConsumptionHistory;

    public Ninja(){
        calorieIntake = 0;
        ConsumptionHistory = new List<iConsumable>();
    }

    // public abstract bool isFull {
    //     get
    //     {
    //         if (calorieIntake >= 1200) {
    //             return true;
    //         } else {
    //             return false;
    //         }
    //     }
    // }
    public abstract bool IsFull {get;}
    public abstract void Consume(iConsumable item);
    // public void Eat(iConsumable item){
    //     bool AppetiteOrNoAppetite = this.isFull;
    //     if ( AppetiteOrNoAppetite == false ) {
    //         calorieIntake = calorieIntake + item.calories;
    //         ConsumptionHistory.Add(item);
    //     }
    //     if ( AppetiteOrNoAppetite == true ) {
    //         Debug.WriteLine("Is full!!!!!!!");
    //     }
    // }
}