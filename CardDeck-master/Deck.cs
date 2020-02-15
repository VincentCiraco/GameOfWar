using System;
using System.Collections.Generic;

namespace CardDeck
{
    class Deck
    {
        List<Card> Cards { get; set; }
        public int NumCards { get => Cards.Count; }
        public Deck()
        {
            Cards = new List<Card>();
        }
        public Deck(List<Card> cards)
        {
            Cards = cards;
        }


        public void AddCard(Card newCard)
        {
            Cards.Add(newCard);
        }

        public Card RemoveTopCard()
        {
            
            
            
            Card cardToRemove = Cards[0];
            Cards.RemoveAt(0);
            return cardToRemove;
        }

        public void PrintDeck()
        {
            foreach(Card c in Cards)
            {
                System.Console.WriteLine(c);
            }
        }


        public void SortDeck()
        {
            Cards.Sort();
        }
        
        
        public  void ShuffleDeck()
        { 
                List<Card> DeckShuffled = new List<Card>();

                Random r = new Random();
                int randomIndex = 0;
                for (int i = 0; i < 52; i++)
                {
                    randomIndex = r.Next(0, Cards.Count); //Choose a random object in the list
                    DeckShuffled.Add(Cards[randomIndex]); //add it to the new, random list
                    Cards.RemoveAt(randomIndex); //remove to avoid duplicates
                }
            Cards = DeckShuffled;
                
        }

        
       /* public void PrintPlayerDeck()
        //method to print the decks of each player
        {
            Console.WriteLine("Player 1 deck is ---");
            foreach (Card c in playerDeck)
            {
                System.Console.WriteLine(c);
            }

            Console.WriteLine("Player 2 deck is -----");
            foreach (Card c in computerDeck)
            {
                System.Console.WriteLine(c);
            }
        }
        */
    }
}