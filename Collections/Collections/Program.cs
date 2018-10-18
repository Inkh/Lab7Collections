using System;
using Collections.Classes;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Test();
        }

        static void Test()
        {
            Card ace = new Card(Suit.Spades, Value.Ace);
            Deck<Card> myDeck = new Deck<Card>();
            myDeck.Add(ace);
            
            Console.WriteLine($"{(int)ace.Value} of {ace.Suit}");
            
            
        }
    }
}
