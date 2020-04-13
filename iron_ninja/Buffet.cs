using System.Collections.Generic;
using System.Diagnostics;
public class Buffet {
    public List <iConsumable> menu;
    
    public Buffet () {
        menu = new List<iConsumable>() {
            new Food("HotWings", 700, true, false),
            new Food("JerkChicken", 500, true, true),
            new Food("Waffles", 600, false, true),
            new Drink("Mango Smoothie", 600),
            new Drink("Agua de Pina", 700),
            new Drink("Sweet Ice Tea", 300),
            new Drink("Milkshake", 500),
        };
    }
    public iConsumable serve(int randomNumber) {
        return menu[randomNumber];
    }

    public void printMenu(){
        for ( int i = 0; i < this.menu.Count; i++) {
            Debug.WriteLine(menu[i]);
        }
    }
}