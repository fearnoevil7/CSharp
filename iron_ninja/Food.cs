public class Food : iConsumable {
    public string name {get; set;}
    public int calories {get; set;}

    public bool IsSpicy {get; set;}
    public bool IsSweet {get; set;}

    public Food(string name, int calories, bool spicy, bool sweet) {
        this.name = name;
        this.calories = calories;
        IsSpicy = spicy;
        IsSweet = sweet;
        
    }
    public Food(string name, int calories) {
        this.name = name;
        this.calories = calories;
    }
    public string getInfo() {
        return $"{name} (Food).  Calories: {calories}.  Spicy?: {IsSpicy}, Sweet?: {IsSweet}";
    }
}