using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections.Classes
{
    public class Deck<T> : IEnumerable
    {
        T[] Cards = new T[5];
        public int Count = 0;

        /// <summary>
        /// Adds card to Deck
        /// </summary>
        /// <param name="card">Card object</param>
        public void Add(T card)
        {
            if (Count == Cards.Length)
            {
                Array.Resize(ref Cards, Cards.Length * 2);
            }
            Cards[Count++] = card;
        }

        /// <summary>
        /// Returns a list of cards of the same suit from deck.
        /// </summary>
        /// <param name="suit">Name of suit (Spades, Hearts, Diamonds, Clovers)</param>
        /// <returns>Array of cards of same suit</returns>
        public T[] ReturnSuit(Suit suit)
        {
            T[] cardsOfSameSuit = new T[Count];
            int sizeOfList = 0;
            for (int i = 0; i < Count; i++)
            {
                Card cardOfSuit = (Card)Convert.ChangeType(Cards[i], typeof(Card));

                if(cardOfSuit.Suit == suit)
                {
                    cardsOfSameSuit[sizeOfList++] = (T)(object)cardOfSuit;
                }
            }
            Array.Resize(ref cardsOfSameSuit, sizeOfList);

            return cardsOfSameSuit;
        }

        /// <summary>
        /// Removes specific card from deck
        /// </summary>
        /// <param name="card">Card object</param>
        /// <returns>True if something is removed, false if not</returns>
        public bool Remove(T card)
        {
            Card toBeRemoved = (Card)(object)card;
            for (int i = 0; i < Count; i++)
            {
                Card cardInDeck = (Card)Convert.ChangeType(Cards[i], typeof(Card));
                if (cardInDeck.Value == toBeRemoved.Value && cardInDeck.Suit == toBeRemoved.Suit)
                {
                    Cards[i] = Cards[--Count];
                    
                    return true;
                }
            }
            return false;
        }


        //magic don't touch
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return Cards[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
