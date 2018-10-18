using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.Classes
{
    public class Card
    {
        public Suit Suit { get; set; }
        public Value Value { get; set; }

        public Card(Suit suit, Value value)
        {
            Suit = suit;
            Value = value;
        }
    }

    public enum Suit
    {
        Spades,
        Hearts,
        Diamonds,
        Clovers
    }

    public enum Value
    {
        Ace = 1,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }
}
