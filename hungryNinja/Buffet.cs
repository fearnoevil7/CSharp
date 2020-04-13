using System.Collections.Generic;
using System.Diagnostics;
public class Buffet {
    public List <Food> menu;
    
    public Buffet () {
        menu = new List<Food>() {
            new Food("HotWings", 700, true, false),
            new Food("JerkChicken", 500, true, true),
            new Food("Waffles", 600, false, true),
            new Food("FishNChips", 600, false, false),
            new Food("Fried Mackerel", 700, false, false),
            new Food("Vegetable Soup", 300, false, false),
            new Food("Ice Cream", 500, false, true),
        };
    }
    public Food serve(int randomNumber) {
        return menu[randomNumber];
    }

    public void printMenu(){
        for ( int i = 0; i < this.menu.Count; i++) {
            Debug.WriteLine(menu[i]);
        }
    }
}