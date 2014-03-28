using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;



namespace Tutorial07ClassLibrary
{



    #region FIELDS AND PROPERTIES

    public class PlayingCard : ICloneable, IComparable
    {
        protected CardSuit mySuit;
        public CardSuit Suit
        {
            get { return mySuit; }
            set { mySuit = value; }
        }

        protected CardRank myRank;
        public CardRank Rank
        {
            get { return myRank; }
            set { myRank = value; }
        }


        protected int myValue;
        public int CardValue
        {
            get { return myValue; }
            set { myValue = value; }
        }

        
        protected int? altValue = null;
        public int? AlternateValue
        {
            get { return altValue; }
            set { altValue = value; }
        }

        protected bool faceUp = false;
        public bool FaceUp
        {
            get { return faceUp; }
            set { faceUp = value; }
        }

    #endregion
        
        #region CONSTRUCTORS
        //Card Constructor, initializing the playing cad object.
        //By default, the card is face down, with no alternate value.
        //Card rank defaults to Ace, suit of hearts


        public PlayingCard(CardRank rank = CardRank.Ace, CardSuit suit = CardSuit.Hearts)
        {
            this.myRank = rank;
            this.mySuit = suit;
            this.myValue = (int)rank;
        }

        #endregion

        #region RELATIONAL OPERATOR


        public static bool operator ==(PlayingCard left, PlayingCard right)
        {
            return (left.CardValue == right.CardValue);
        }

        public static bool operator !=(PlayingCard left, PlayingCard right)
        {
            return (left.CardValue != right.CardValue);
        }

        public static bool operator <(PlayingCard left, PlayingCard right)
        {
            return (left.CardValue < right.CardValue);
        }

        public static bool operator <=(PlayingCard left, PlayingCard right)
        {
            return (left.CardValue <= right.CardValue);
        }

        public static bool operator >(PlayingCard left, PlayingCard right)
        {
            return (left.CardValue > right.CardValue);
        }

        public static bool operator >=(PlayingCard left, PlayingCard right)
        {
            return (left.CardValue >= right.CardValue);
        }

        #endregion

        #region PUBLIC METHOD

        public virtual int CompareTo(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("Unable to compare a Card to a null object.");
            }
            PlayingCard compareCard = obj as PlayingCard;

            if (compareCard != null)
            {
                int thisSort = this.myValue * 10 + (int)this.mySuit;
                int compareCardSort = compareCardSort.myValue * 10 + (int)compareCardSort.mySuit;
                return (thisSort.CompareTo(compareCardSort));
            }
            else
            {
                throw new ArgumentException("Object being compare cannot be converted to a Card.");
            }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }


        public override string ToString()
        {

            string cardString;

            if (faceUp)
            {
                if (myRank == CardRank.Joker)
                {
                    
                    if(mySuit == CardSuit.Clubs || mySuit == CardSuit.Spades)
                    {
                        cardString = "Black Joker";
                    }
                    else
                    {
                        cardString = "Red Joker";
                    }
                }
                else
                {
                    cardString = myRank.ToString() + " of " + mySuit.ToString();

                }
            }
            else
            {
                cardString = "Face Down";
            }
            //return appropriate card string name
            return cardString;
        }
        
}
        public override bool Equals(object obj)
        {
            return (this.CardValue == ((PlayingCard)obj).CardValue);
        }

        

        public Image GetCardImage()
        {
            string image;
            string imageName;
            Image cardImage;

            if(!faceUp)
            {
                imageName = "Back";
            }
            else if (myRank == CardRank.Joker)
            {
                if (mySuit == CardSuit.Clubs || mySuit == CardSuit.Spades)
                {
                    imageName = "Joker_Black";
                }
                else
                {
                    imageName = "Joker_Red";
                }
            }
            else
            {
                imageName = mySuit.ToString() + "_" + myRank.ToString();

            }
            cardImage = Properties.Resources.RecourceManager.GetObject(imageName) as Image;
        
            return cardImage;
        }
    

        public string DebugString()
        {
            string cardState = (string)(myRank.ToString() + " of " + mySuit.ToString()).PadLeft(20);
            cardState += (string)((FaceUp) ? "(Face Up)" : "(Face Down)").PadLeft(12);
            cardState += " Value: " +myValue.ToString().PadLeft(2);
            cardState += ((altValue != null) ? "/" + altValue.ToString() : "");
            return cardState;
        }
    #endregion

    }
