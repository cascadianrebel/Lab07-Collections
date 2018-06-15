using System;
using Lab07_Collections;




namespace Lab07_Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            HomeDisplay();
            
            //DisplayDeck(Deck<Card>.CreateDeck());
            //Deck<Card>.Shuffle();
            //DisplayDeck(Deck<Card>.CreateDeck());

        }
        public static void HomeDisplay()
        {
            Console.WriteLine("Please Select an option below");
            Console.WriteLine("1. Deal Cards");
            Console.WriteLine("2. Shuffle Deck");
            Console.WriteLine("3. Add to the Deck");
            Console.WriteLine("4. Remove from the deck");


            //Added by fellow studend to replace Deck<Card> that was throwing errors.
            Deck<Card> deck = new Deck<Card>();


            int userResponse = Convert.ToInt32(Console.ReadLine());
            if(userResponse == 1)
            {
                Deal();
            }
            if (userResponse == 2)
            {
                deck.Shuffle();
                DisplayDeck(deck.CreateDeck());
            }
            if (userResponse == 3)
            {
                deck.CreateDeck();
                deck.Add(new Card(CardFace.two, Suit.Clubs));
                DisplayDeck(deck.CreateDeck());
            }
        }
        public static void Deal()
        {
            //Added by fellow studend to replace Deck<Card> that was throwing errors.
            //I don't understand why it is needed. 
            Deck<Card> deck = new Deck<Card>();

            DisplayDeck(deck.CreateDeck());
            deck.Shuffle();
            DisplayDeck(deck.CreateDeck());
        }

        public static void DisplayDeck(Deck<Card> deck)
        {
            foreach(Card card in deck)
            {
                Console.WriteLine($"{card.CardFace} of {card.Suit}");
            }
            Console.WriteLine($"{deck.count} number of cards in the deck");
        }

    }
}
