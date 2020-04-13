public class Drink : Food, iConsumable{
    public string name {get; set;}
    public int calories {get; set;}
    public bool IsSpicy {get; set;}
    public bool IsSweet {get; set;}

    public Drink(string name, int calories) : base(name, calories){
        this.name = name;
        this.calories = calories;
    }
    public string getInfo() {
        return $"{name} (Drink).  Calories: {calories}.  Spicy?: {IsSpicy}, Sweet?: {IsSweet}";
    }
}