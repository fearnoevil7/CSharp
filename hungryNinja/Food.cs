public class Food {
    public string name;
    public int calories;

    public bool IsSpicy;
    public bool IsSweet;

    public Food(string name, int calories, bool spicy, bool sweet) {
        this.name = name;
        this.calories = calories;
        IsSpicy = spicy;
        IsSweet = sweet;
        
    }
}