public interface iConsumable {
    string name {get; set;}
    int calories {get; set;}
    bool IsSpicy {get; set;}
    bool IsSweet {get; set;}

    string getInfo();

}