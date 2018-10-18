using System;
using System.Collections.Generic;
using Collections.Classes;

namespace Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Deck();
        }

        /// <summary>
        /// Tests in console of Add, Remove, ReturnSuits method
        /// </summary>
        static void Deck()
        {
            Card aceOfSpades = new Card(Suit.Spades, Value.Ace);
            Card twoOfDiamonds = new Card(Suit.Diamonds, Value.Two);
            Card kingOfHearts = new Card(Suit.Hearts, Value.King);
            Card queenOfDiamonds = new Card(Suit.Diamonds, Value.Queen);
            Card sixOfClovers = new Card(Suit.Clovers, Value.Six);
            Card fourOfDiamonds = new Card(Suit.Diamonds, Value.Four);
            Card fiveOfSpades = new Card(Suit.Spades, Value.Five);
            Card tenOfHearts = new Card(Suit.Hearts, Value.Ten);
            Card aceOfDiamonds = new Card(Suit.Diamonds, Value.Ace);
            Card aceOfHearts = new Card(Suit.Hearts, Value.Ace);

            List<Card> myCards = new List<Card>
            {
                aceOfSpades,
                twoOfDiamonds,
                kingOfHearts,
                queenOfDiamonds,
                sixOfClovers,
                fourOfDiamonds,
                fiveOfSpades,
                tenOfHearts,
                aceOfDiamonds,
                aceOfHearts
            };


            Deck<Card> myDeck = new Deck<Card>();

            //Add cards to list
            foreach (Card card in myCards)
            {
                myDeck.Add(card);
            }


            Console.WriteLine("Showing Current Deck");
            foreach (Card card in myDeck)
            {
                Console.WriteLine($"{card.Value} of {card.Suit}");
            }

            Console.WriteLine("======================");

            Console.WriteLine("Showing cards with Hearts suit");
            Card[] cardsOfSuit = myDeck.ReturnSuit(Suit.Hearts);
            foreach (Card card in cardsOfSuit)
            {
                Console.WriteLine($"{card.Value} of {card.Suit}");
            }
            Console.WriteLine("======================");


            Console.WriteLine("Removing Ace of Spades, Two of Diamonds, and Ten of Hearts");
            myDeck.Remove(aceOfSpades);
            myDeck.Remove(twoOfDiamonds);
            myDeck.Remove(new Card(Suit.Hearts, Value.Ten));

            Console.WriteLine("Updated Deck");
            Console.WriteLine("======================");

            foreach (Card card in myDeck)
            {
                Console.WriteLine($"{card.Value} of {card.Suit}");
            }

        }
    }
}
