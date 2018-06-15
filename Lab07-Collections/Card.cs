using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07_Collections
{
    public enum Suit
    {
        Hearts = 0,
        Diamonds,
        Clubs,
        Spades
    }

    public enum CardFace
    {
        two = 2,
        three,
        four,
        five,
        six,
        seven,
        eight,
        nine,
        ten,
        jack,
        queen,
        king,
        ace
    }

    public class Card
    {

        public CardFace CardFace { get; set; }

        public Suit Suit { get; set; }

        public Card(CardFace cardFace , Suit suit)
        {
            CardFace = cardFace;
            Suit = suit;
        }

    }

}
