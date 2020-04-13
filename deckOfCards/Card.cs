public class Card {
    public string suit;
    public string stringValue;
    public int value;
    public Card (string suit, string stringValue, int value) {
        this.suit = suit;
        this.stringValue = stringValue;
        this.value = value;
    }
    public string showCard() {
        return $"this card is......        { suit }; { stringValue }; { value }";
    }
}