using System.Collections.Generic;
using System;
public class Deck {
    public List <Card> allCards;
    public List <string> deckSuits;
    public List <string> DeckStringValues;

    public List <int> DeckValues;

    public Card drawCard {
        get
        {
            Card temp = this.allCards[allCards.Count-1];
            this.allCards.Remove(this.allCards[allCards.Count-1]);
            return temp;
        }
    }

    public Object checkDeck {
        get
        {
            return this.allCards;
        }
    }

    public Deck () {
        deckSuits = new List<string>() {
            "Clubs",
            "Spades",
            "Hearts",
            "Diamonds",
        };
        DeckStringValues = new List<string>() {
            "Ace",
            "Two",
            "Three",
            "Four",
            "Five",
            "Six",
            "Seven",
            "Eigth",
            "Nine",
            "Ten",
            "Jack",
            "Queen",
            "King",
        };
        DeckValues = new List<int> {
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10,
            11,
            12,
            13,
        };
        allCards = new List<Card>();
    }
    public void addCards() {
        for ( int i = 0; i < deckSuits.Count; i++ ){
            for ( int x = 0; x < DeckStringValues.Count; x++ ) {
                Card newCard = new Card(deckSuits[i], DeckStringValues[x], DeckValues[x]);
                allCards.Add(newCard);
            }
        }
    }

    public void shuffle(Deck deck) {
        Card temp;
        Random rando = new Random();
        int n = deck.allCards.Count;
        while (n > 1) {
            n--;
            int k = rando.Next(n + 1);
            temp = deck.allCards[k];
            deck.allCards[k] = deck.allCards[n];
            deck.allCards[n] = temp;
        }
    }
    public void reset(Deck deck) {
        for ( int i = 0; i < deck.allCards.Count; i++ ) {
            deck.allCards.Remove(deck.allCards[i]);
        }
        Console.WriteLine("Successfully removed all cards from deck current deck count is        " + deck.allCards.Count);
        deck.addCards();
    }
}