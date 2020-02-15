using System;
using System.Collections.Generic;
using System.Text;

namespace CardDeck
{
    class Battle
    {
        Deck d = new Deck();
        Deck playerDeck = new Deck();
        Deck computerDeck = new Deck();
        Deck table = new Deck();

        public void StartGame()
        {
            foreach (CardSuit cs in Enum.GetValues(typeof(CardSuit)))
            {
                foreach (CardValue cv in Enum.GetValues(typeof(CardValue)))
                {
                    d.AddCard(new Card(cs, cv));
                }
            }
            System.Console.WriteLine($"The number of cards in deck is {d.NumCards}");
            d.ShuffleDeck();
            Deal();
            System.Console.WriteLine($"The number of cards in deck is {playerDeck.NumCards}");
            System.Console.WriteLine($"The number of cards in deck is {computerDeck.NumCards}");
            comparisonEval();



        }


        public void Deal()
        {



            while (d.NumCards > 0)
            {


                playerDeck.AddCard(d.RemoveTopCard());
                computerDeck.AddCard(d.RemoveTopCard());

            }


        }
        public void comparisonEval()
        {


            while(playerDeck.NumCards > 0 && computerDeck.NumCards > 0)
            {
                Console.ReadLine();
                Card pCard = playerDeck.RemoveTopCard();
                Card cCard = computerDeck.RemoveTopCard();
                table.AddCard(cCard);
                table.AddCard(pCard);
                Console.WriteLine($"player card is {pCard}");
                Console.WriteLine($"computer card is {cCard}");
                if (pCard > cCard)
                {
                    Console.WriteLine("player is winner");
                    while (table.NumCards > 0)
                    {
                        playerDeck.AddCard(table.RemoveTopCard());
                    }
                    Console.WriteLine($"player deck number of cards {playerDeck.NumCards}");
                    Console.WriteLine($"computer deck number of cards is {computerDeck.NumCards}");
                }
                else if (pCard < cCard)
                {
                    Console.WriteLine("computer wins the hand");
                    while (table.NumCards > 0)
                    {
                        computerDeck.AddCard(table.RemoveTopCard());
                    }
                    Console.WriteLine($"player deck number of cards {playerDeck.NumCards}");
                    Console.WriteLine($"computer deck number of cards is {computerDeck.NumCards}");
                }
                else if(pCard == cCard)
                {
                    Console.WriteLine("******************WARRR***********************");
                    Console.WriteLine("press enter to play war");
                    Console.ReadLine();
                    war();

                }
            }
            Console.WriteLine("game over");
            if (playerDeck.NumCards == 0)
            {
                Console.WriteLine($"player is loser, number of cards is {playerDeck.NumCards}");
                Console.WriteLine($"computer is winner, number of cards is {computerDeck.NumCards}");
                Console.ReadLine();
            }
            else if (computerDeck.NumCards==0)
            {
                Console.WriteLine($"computer is loser, number of cards is {computerDeck.NumCards} ");
                Console.WriteLine($"player is winner, number of cards is {playerDeck.NumCards}");
                Console.ReadLine();
            }
        }
        public void war()
        {
            while (playerDeck.NumCards > 0 && computerDeck.NumCards > 0)
            {
                Card temp1p = playerDeck.RemoveTopCard();
                //Console.WriteLine(temp1p);
                Card temp2p = playerDeck.RemoveTopCard();
                //Console.WriteLine(temp2p);
                Card temp3p = playerDeck.RemoveTopCard();
                //Console.WriteLine(temp3p);
                table.AddCard(temp1p);
                table.AddCard(temp2p);
                table.AddCard(temp3p);
                Card temp4c = computerDeck.RemoveTopCard();
                Card temp5c = computerDeck.RemoveTopCard();
                Card temp6c = computerDeck.RemoveTopCard();
                table.AddCard(temp4c);
                //Console.WriteLine(temp4c);
                table.AddCard(temp5c);
                //Console.WriteLine(temp5c);
                table.AddCard(temp6c);
                // Console.WriteLine(temp6c);
                Console.WriteLine($"player card is {temp3p}");
                Console.WriteLine($"computer card is {temp6c}");
                Console.ReadLine();
                
                if (temp3p > temp6c)
                {
                    while (table.NumCards > 0)
                    {
                        playerDeck.AddCard(table.RemoveTopCard());
                        
                    }
                    Console.WriteLine("player is winnner");
                }
                else if (temp3p < temp6c)
                {
                    while (table.NumCards > 0)
                    {
                        computerDeck.AddCard(table.RemoveTopCard());
                        
                    }
                    Console.WriteLine("computer is winner");
                }
                else if (temp3p == temp6c)
                {
                    Console.WriteLine("**************WARRR***************");
                    Console.WriteLine("press enter to continue");
                    Console.ReadLine();
                    war();
                }
                Console.WriteLine($"player deck number of cards {playerDeck.NumCards}");
                Console.WriteLine($"computer deck number of cards is {computerDeck.NumCards}");
                return;
            }

        }
 

    }

}
