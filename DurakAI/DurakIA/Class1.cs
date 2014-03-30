using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch11CardLib; //Will change to our card library in later use. 
namespace DurakAI
{
    public class AI
    {
        /// <summary>
        /// Not done, will have to work on logic involving what the computer does when there is a stack of attacks and defends still in play.
        /// Plus have to comment this better overall later, just a startup pretty much I guess. 
        /// </summary>
        /// <param name="trump"></param>
        /// <param name="hand"></param>
        /// <returns></returns>
        public static bool CanAttack(Suit trump, Card[] hand)
        {
            bool allowable = True;

            return allowable;
        }

        public static bool CanDefend(Suit trump, Card[] hand, Card attackedBy)//Later hand will be correctly used for hand library
        {
            bool allowable = false;
            int count = 0;

            foreach (Card card in hand)
            {
                count += 1;
                if (attackedBy.suit == trump)
                {
                    if (card.suit == trump && card.rank > attackedBy.rank)
                    {
                        allowable = true;
                    }
                }

                else if (card.suit == trump)
                {

                    allowable = true;

                }

                else if (card.rank > attackedBy.rank && card.suit == attackedBy.suit)
                {

                    allowable = true;

                }
            }

            return allowable;
        }

        public static Card Attack(Suit trump, Card[] hand)//Later hand will be correctly used for hand library
        {

            Card[] playable = new Card[hand.Length];
            int count = 0;
          
            Card useCard;
            useCard = playable[0];
            count = 0;
            foreach (Card usable in playable)
            {
                count += 1;
                if (useCard.rank > playable[count].rank && playable[count].suit != trump)
                {
                    useCard = playable[count];
                }

                if (useCard.suit == trump && playable[count].suit != trump)
                {
                    useCard = playable[count];
                }

                if (useCard.suit == trump && playable[count].rank < useCard.rank)
                {
                    useCard = playable[count];
                }
            }

            return useCard;
            
        }

        public static Card Defend(Suit trump, Card[] hand, Card attackedBy)//Later hand will be correctly used for hand library
        {
            Card[] playable = new Card[hand.Length];
            int count = 0;
            int playables = 0;
            Card useCard;

            foreach (Card card in hand)
            {
                count += 1;

                if (attackedBy.suit == trump)
                {
                    if (card.suit == trump && card.rank > attackedBy.rank)
                    {
                        playable[playables] = hand[count];
                        playables += 1;
                    }
                }

                else if (card.suit == trump)
                {
                    playable[playables] = hand[count];
                    playables += 1;

                }

                else if (card.rank > attackedBy.rank && card.suit == attackedBy.suit)
                {
                    playable[playables] = hand[count];
                    playables += 1;
                }

            }
            useCard = playable[0];
            count = 0;
            foreach (Card usable in playable)
            {
                count += 1;
                if (useCard.rank > playable[count].rank && playable[count].suit != trump)
                {
                    useCard = playable[count];
                }

                if (useCard.suit == trump && playable[count].suit != trump)
                {
                    useCard = playable[count];
                }

                if (useCard.suit == trump && playable[count].rank < useCard.rank)
                {
                    useCard = playable[count];
                }
            }

            return useCard;

        }
    }
}
