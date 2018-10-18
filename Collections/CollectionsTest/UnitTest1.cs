using System;
using Xunit;
using Collections.Classes;
using static Collections.Program;

namespace CollectionsTest
{
    public class UnitTest1
    {
        [Fact]
        public void WillDeleteCardTest()
        {
            Deck<Card> myDeck = new Deck<Card>();
            Card aceOfSpades = new Card(Suit.Spades, Value.Ace);
            Card twoOfDiamonds = new Card(Suit.Diamonds, Value.Two);
            myDeck.Add(aceOfSpades);
            myDeck.Add(twoOfDiamonds);
            Assert.True(myDeck.Remove(aceOfSpades));
        }

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
    }
}
