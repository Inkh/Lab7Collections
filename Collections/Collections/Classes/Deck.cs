using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections.Classes
{
    public class Deck<T> : IEnumerable
    {
        T[] cards = new T[5];
        int count = 0;

        /// <summary>
        /// Adds card to Deck
        /// </summary>
        /// <param name="card">Card object</param>
        public void Add(T card)
        {
            if (count == cards.Length)
            {
                Array.Resize(ref cards, cards.Length * 2);
            }
            cards[count++] = card;
        }

        /// <summary>
        /// Returns a list of cards of the same suit from deck.
        /// </summary>
        /// <param name="suit">Name of suit (Spades, Hearts, Diamonds, Clovers)</param>
        /// <returns>Array of cards of same suit</returns>
        public Card[] ReturnSuit(Suit suit)
        {
            Card[] cardsOfSameSuit = new Card[cards.Length];
            int sizeOfList = 0;
            for (int i = 0; i < count; i++)
            {
                Card cardOfSuit = (Card)Convert.ChangeType(cards[i], typeof(Card));

                if(cardOfSuit.Suit == suit)
                {
                    cardsOfSameSuit[i] = cardOfSuit;
                    sizeOfList++;
                }
            }
            Array.Resize(ref cardsOfSameSuit, sizeOfList - 1);

            return cardsOfSameSuit;
        }


        //magic don't touch
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return cards[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
