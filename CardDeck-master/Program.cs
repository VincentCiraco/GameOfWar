using System;
using System.Collections.Generic;

namespace CardDeck
{
    class Program
    {


        static void Main(string[] args)
        {

            Console.WriteLine("Hello and welcome to War");
            Console.WriteLine("");
            Console.WriteLine("Make a choice from the menu below.");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("    -type in 1 to Start new Game");
            Console.WriteLine("    -type in 2 to quit");
            string userinput = Console.ReadLine();
            if (userinput == "1")
            {
                PlayerStartGame();
            }
            else if (userinput == "2")
            {
                return;
            }
            else
            {
                Main(args);
            }

            //code needed to draw top card from decks
            /* while (d.NumCards > 0)
            {
                System.Console.WriteLine(d.RemoveTopCard());
            }*/




            //testing numbr of cards in player decks
            //System.Console.WriteLine($"The number of cards in deck is {P1Deck.Count}");
            //System.Console.WriteLine($"The number of cards in deck is {P2Deck.Count}");

            //PrintPlayerDeck(P1Deck,P2Deck);
            //test to show the cards in each player deck









        }

        
        public static void PlayerStartGame()
        {
            Battle B = new Battle();
            B.StartGame();




        }

    }
}
