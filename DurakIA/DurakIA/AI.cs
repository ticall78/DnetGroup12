using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeterCardLibrary; //Will change to our card library in later use. 
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
        /// 

        //Right now this is automatically true due to the fact that if its the first attack you can always put anything.
        //I haven't gotten to the logic of what to do if its a rebound attack, like when one person already defended, but you can attack again.
        public static bool CanAttack(Suit trump, Card[] hand)
        {
            bool allowable = true;

            return allowable;
        }

        public static bool CanDefend(Suit trump, Card[] hand, Card attackedBy)//Later hand will be correctly used for hand library
        {
            bool allowable = false;
            int count = 0;

            //This loop goes through every card in the hand
            foreach (Card card in hand)
            {
                count += 1;
                //if the suit that was put down for attack was a trump, check if you have a higher valued trump, otherwise you can't defend.
                if (attackedBy.suit == trump)
                {
                    if (card.suit == trump && card.rank > attackedBy.rank)
                    {
                        allowable = true;
                    }
                }

                //Else if you have a trump, then you can always defend no matter what non trump was put as attack
                else if (card.suit == trump)
                {

                    allowable = true;

                }
              
                //Else if the card is a higher value and the same suit, you can defend, since you have to defend with the same suit with a higher value or a trump.
                else if (card.rank > attackedBy.rank && card.suit == attackedBy.suit)
                {

                    allowable = true;

                }
            }

            return allowable;
        }

        //This is logic to decide which card should be used on attack.
        public static Card Attack(Suit trump, Card[] hand)//Later hand will be correctly used for hand library
        {
            //Just made a array of playable cards that will be stored, making the max size the size of the hand.
            Card[] playable = new Card[hand.Length];
            int count = 0;
          
            Card useCard;//Card that will be used to attack.
            useCard = playable[0];
            count = 0;

            //It goes through a loop of the cards in the hand, looking for the least valued playable card possible to attack with
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

            //Returns least valued card for attack.
            return useCard;
            
        }


        //Logic to find out which card to defend with.
        public static Card Defend(Suit trump, Card[] hand, Card attackedBy)//Later hand will be correctly used for hand library
        {
            Card[] playable = new Card[hand.Length];//Array that will hold playable cards, made the max size of the array the number of cards in hand.
            
            int count = 0;
            int playables = 0;//Counter stored to store how many playable cards were found in the hand
            Card useCard;

            //It goes through every card in hand
            foreach (Card card in hand)
            {
                count += 1;

                //If the attack card that must be defended agaisnt is a trump
                if (attackedBy.suit == trump)
                {
                    //Checks for if the card is a higher level trunk, if so it stores that card in the array of options
                    if (card.suit == trump && card.rank > attackedBy.rank)
                    {
                        playable[playables] = hand[count];
                        playables += 1;
                    }
                }

                //If the card defended agaisnt isnt a trump, and this card being checked in comps hand is a trump, then it stores the trump as an option.
                else if (card.suit == trump)
                {
                    playable[playables] = hand[count];
                    playables += 1;

                }


                //If the card being checked is the same suit as the card being defended agaisnt, and a higher value, it is stored as an option.
                else if (card.rank > attackedBy.rank && card.suit == attackedBy.suit)
                {
                    playable[playables] = hand[count];
                    playables += 1;
                }

            }

            useCard = playable[0];//Automatically makes the usecard the first card in the array of playable cards


            count = 0;
            //Goes through a loop for as many times as there are playablecards from the counter of playable cards.
            do
            {  
                    count += 1;
                    //If statements to check if the card being read is a lower value than the currently stored usecard
                    //If the check being read is a lower value than the current usecard, that card becomes the new usecard
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
            while (count < playables);
            //Returns lowest value card
            return useCard;

        }
    }
}
