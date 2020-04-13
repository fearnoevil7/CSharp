using System;

namespace deckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Deck myDeck = new Deck();
            myDeck.addCards();
            Console.WriteLine(myDeck.allCards.Count);
            myDeck.shuffle(myDeck);
            for (int i = 0; i < myDeck.allCards.Count; i++) {
                Console.WriteLine(myDeck.allCards[i].suit + "-" + myDeck.allCards[i].stringValue + "-" + myDeck.allCards[i].value);
            }
            Console.WriteLine(myDeck.allCards.Count);
            Console.WriteLine(myDeck.drawCard);
            myDeck.reset(myDeck);
            for (int x = 0; x < myDeck.allCards.Count; x++) {
                Console.WriteLine(myDeck.allCards[x].suit + "-" + myDeck.allCards[x].stringValue + "-" + myDeck.allCards[x].value);
            }
            Player Jonathon = new Player("Jonathon", myDeck);
            Jonathon.takeCard(myDeck);
            Console.WriteLine(Jonathon.discardCard(1));
            Console.WriteLine(Jonathon.discardCard(2));
            Console.WriteLine(Jonathon.discardCard(7));
            Console.WriteLine(Jonathon.getName);
            for (int q = 0; q < Jonathon.hand.Count; q++) {
                Console.WriteLine(Jonathon.hand[q].suit + "-" + Jonathon.hand[q].stringValue + "-" + Jonathon.hand[q].value);
            }

        }
    }
}
