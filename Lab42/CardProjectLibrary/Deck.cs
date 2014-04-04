// Deck Class ** Not used in this particular lab, but for final project- please disregard

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using PeterCardLibrary;

namespace PeterCardLibrary
{
    // Make a enum for the different deck sizes(20, 36, 52)

    public class Deck
    {
        private PlayingCard[] cards; 


        public Deck(int numOfCards = 52)
        {
            if (numOfCards == 52)
            {
                cards = new PlayingCard[52];
                for (int suitVal = 0; suitVal < 4; suitVal++)
                {
                    for (int rankVal = 1; rankVal < 14; rankVal++)
                    {
                        cards[suitVal * 13 + rankVal - 1] = new PlayingCard((Rank)suitVal,
                                                                    (Suit)rankVal);
                    }
                }
            }
            
            else if (numOfCards == 36)
            {
                 cards = new PlayingCard[36];
                for (int suitVal = 0; suitVal < 4; suitVal++)
                {
                    for (int rankVal = 6; rankVal < 14; rankVal++)
                    {
                        cards[suitVal * 8 + rankVal - 6] = new PlayingCard((Rank)suitVal,
                                                                    (Suit)rankVal);
                    }
                }
             }
                
                else if (numOfCards == 20)
                {
                     cards = new PlayingCard[20];
                    for (int suitVal = 0; suitVal < 4; suitVal++)
                    {
                        for (int rankVal = 10; rankVal < 14; rankVal++)
                        {
                            cards[suitVal * 5 + rankVal - 10] = new PlayingCard((Rank)suitVal,
                                                                        (Suit)rankVal);
                        }
                     }
                 }
    
                else
                {
                    Console.Write("Please enter a : ");
                }
                
          }       
       

        public PlayingCard GetCard(int cardNum)
        {
            if (cardNum >= 0 && cardNum < cards.Length)
                return cards[cardNum];
             
            else
                throw (new System.ArgumentOutOfRangeException("cardNum", cardNum,
                          "Value must be between 0 and 51."));
        }

        public void Shuffle()
        {
            PlayingCard[] newDeck = new PlayingCard[cards.Length];
            bool[] assigned = new bool[cards.Length];
            Random sourceGen = new Random();
            for (int i = 0; i < 52; i++)
            {
                int destCard = 0;
                bool foundCard = false;
                while (foundCard == false)
                {
                    destCard = sourceGen.Next(cards.Length);
                    if (assigned[destCard] == false)
                        foundCard = true;
                }
                assigned[destCard] = true;
                newDeck[destCard] = cards[i];
            }
            newDeck.CopyTo(cards, 0);
        }

        // Clone Method
        // Supports the IClonable interface.  Used for deep copying in card collection classes
        public object Clone()
        {
            return this.MemberwiseClone();// Return a memberwise clone
        } // End of Clone

    }

}