using System;
using System.Collections.Generic;

public class Player {
    public string name;
    public List <Card> hand;

    public string getName {
        get
        {
            return this.name;
        }
        set
        {
            name = value;
        }
    }

    public Player(string name, Deck deck) {
        this.name = name;
        this.hand = drawHand(deck);
    }

    private List<Card> drawHand(Deck deck) {
        Random rando = new Random();
        List<Card> playersHand = new List<Card>();
        for ( int cardsdealt = 0; cardsdealt < 7; cardsdealt++ ) {
            int currentNumCardsInDeck = deck.allCards.Count - 1;
            Card cardToAddToHand = deck.allCards[rando.Next(1, currentNumCardsInDeck)];
            playersHand.Add(cardToAddToHand);
            deck.allCards.Remove(cardToAddToHand);
        }
        return playersHand;
    }

    public void takeCard(Deck deck){
        Card drawnCard = deck.drawCard;
        this.hand.Add(drawnCard);
    }

    public Card discardCard(int index){
        if ( index <= this.hand.Count - 1 ) {
            Card cardToDelete = this.hand[index];
            this.hand.RemoveAt(index);
            return cardToDelete;
        } else
        return null;
    }
}