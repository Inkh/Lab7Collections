using System;
using Xunit;
using Collections.Classes;
using static Collections.Program;
using System.Collections.Generic;

namespace CollectionsTest
{
    public class UnitTest1
    {

        /// <summary>
        /// Tests if card will be deleted.
        /// </summary>
        [Fact]
        public void WillDeleteCardTest()
        {
            Deck<Card> myDeck = new Deck<Card>();
            Card aceOfSpades = new Card(Suit.Spades, Value.Ace);
            Card twoOfDiamonds = new Card(Suit.Diamonds, Value.Two);
            myDeck.Add(aceOfSpades);
            myDeck.Add(twoOfDiamonds);
            Assert.True(myDeck.Remove(new Card(Suit.Spades, Value.Ace)));
        }

        /// <summary>
        /// Tests if card will be added.
        /// </summary>
        [Fact]
        public void WillAddCardTest()
        {
            Deck<Card> myDeck = new Deck<Card>();
            Card aceOfSpades = new Card(Suit.Spades, Value.Ace);
            Card twoOfDiamonds = new Card(Suit.Diamonds, Value.Two);
            myDeck.Add(aceOfSpades);
            myDeck.Add(twoOfDiamonds);

            Assert.True(myDeck.Count == 2);
        }

        /// <summary>
        /// Tests if cards of same suit will be returned as an array
        /// </summary>
        [Fact]
        public void WillReturnCardsOfSameSuitTest()
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

            foreach (Card card in myCards)
            {
                myDeck.Add(card);
            }

            Card[] cardsOfSuit = myDeck.ReturnSuit(Suit.Hearts);
            Assert.True(cardsOfSuit.Length == 3);
        }
    }
}
