using System.Collections.Generic;
using System.Diagnostics;

public class Ninja {
    private int calorieIntake;
    public List<Food> FoodHistory;

    public Ninja(){
        calorieIntake = 0;
        FoodHistory = new List<Food>();
    }

    public bool isFull {
        get
        {
            if (calorieIntake >= 1200) {
                return true;
            } else {
                return false;
            }
        }
    }

    public void Eat(Food item){
        bool AppetiteOrNoAppetite = this.isFull;
        if ( AppetiteOrNoAppetite == false ) {
            calorieIntake = calorieIntake + item.calories;
            FoodHistory.Add(item);
        }
        if ( AppetiteOrNoAppetite == true ) {
            Debug.WriteLine("Is full!!!!!!!");
        }
    }
}