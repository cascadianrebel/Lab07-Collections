using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab07_Collections
{
    public class Deck<T> : IEnumerable<T>
    {

        public  T[] cardDeck = new T[15];

        public int count = 0;

        //TODO: Add Card
        //Troubleshooting... nothing is being added.
        public void Add(T newCard)
        {
            if (count == cardDeck.Length)
            {
                Array.Resize(ref cardDeck, cardDeck.Length * 2);
            }

            cardDeck[count++] = newCard;
        }


        //TODO: shuffle
        //troubleshoot: cardDeck has duplicates and doubles the deck. 
        public  T[] Shuffle()
        {

            for (int i = 0; i < count; i++)
            {
                Random randomNum = new Random();
                int randomIndexNum = randomNum.Next(0, count);
 
                cardDeck[i] = cardDeck[randomIndexNum];

            }

            return cardDeck;
        }

        //TODO: remove card
        public void RemoveCard()
        {

        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return cardDeck[i];
            }
        }

        //Don't Touch
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public  Deck<Card> CreateDeck()
        {
            Deck<Card> newDeck = new Deck<Card>
            {
                new Card(CardFace.ace, Suit.Clubs),
                new Card(CardFace.king, Suit.Clubs),
                new Card(CardFace.queen, Suit.Clubs),
                new Card(CardFace.jack, Suit.Clubs),
                new Card(CardFace.ace, Suit.Hearts),
                new Card(CardFace.king, Suit.Hearts),
                new Card(CardFace.queen, Suit.Hearts),
                new Card(CardFace.jack, Suit.Hearts),
                new Card(CardFace.ace, Suit.Spades),
                new Card(CardFace.king, Suit.Spades),
                new Card(CardFace.queen, Suit.Spades),
                new Card(CardFace.jack, Suit.Spades),
                new Card(CardFace.ace, Suit.Diamonds),
                new Card(CardFace.king, Suit.Diamonds),
                new Card(CardFace.queen, Suit.Diamonds),
                new Card(CardFace.jack, Suit.Diamonds)
            };
            return newDeck;
        }




    }
}
