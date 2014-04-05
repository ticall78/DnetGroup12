/* Lab Name:       Lab 4- Windows Form Control
  * File Name:     PlayingCard.cs 
  * Name:          Peter Kalo 
  * Student ID:    100503976
  * Date:          March 17th 2014
  * Description:   Creating a windows class the Playing Card which contains fields and properties for the Suit, Rank,
  *                Face up, value and alternate value fields.  A card constructor which will initialize
  *                the card object.  Various Public methods such as CompareTo(), Clone(), ToString(), Equals() 
  *                GetCardImage(), Debug().  Also determines relational operators for any card situation that may 
  *                arise within a control or when used in a card gameplay.
  *                All areas contained in this class are referenced by both the PictureBox as well as the Demo Tester
  *                form.
  *        
  *        ATTRIBUTION    
  *        ***********
  *    The card images used in this class were created by V.H Smith. These card images are distributed as 
  *    freeware, meaning you can use and distribute the deck as you wish, provided that you do not charge
  *    anything for doing so. Downloaded from http://freeware-esoterica.narod.ru/html/freecards.html on 
  *    March 7th 2014.
  */ 
using System;
using System.Drawing;

namespace PeterCardLibrary // Name of the class
{
    public class PlayingCard : ICloneable,
                                IComparable


    //Suit Property which gets or sets the card suit value
    {
        #region FIELDS AND PROPERTIES

        protected Suit mySuit;
        public Suit Suit
        {
            get { return mySuit; }   // Gets the suit
            set { mySuit = value; } // Sets the suit value
        }

        // Rank Property which gets or sets the rank value
        protected Rank myRank;
        public Rank Rank
        {
            get { return myRank; }
            set { myRank = value; }
        }

        // Card value property used to get or set the card value
        protected int myValue;
        public int CardValue
        {
            get { return myValue; }
            set { myValue = value; }
        }

        // Alternate value property which gets or sets the value for different games, 
        // Set to null by default
        protected int? altValue = null;
        public int? AlternateValue
        {
            get { return altValue; }
            set { altValue = value; }
        }

        // Faceup Propety used to get or set if the card is face up
        // Set to false or down by default
        protected bool faceUp = false;
        public bool FaceUp
        {
            get { return faceUp; }
            set { faceUp = value; }
        }

        #endregion

         #region CONSTRUCTOR
        //Card Constructor
        // Initializes the playing card object.  By default, card is face down, with no altenate value
        public PlayingCard(Rank rank = Rank.Ace, Suit suit = Suit.Spades)
        {
            // Set the rank, suit
            this.myRank = rank;
            this.mySuit = suit;
            // Set the default card value
            this.myValue = (int)rank;
        }
        #endregion

        #region PUBLIC METHODS
        // CompareTo method
        // Card specific comparison method used to sort card instances.
        public virtual int CompareTo(object obj)
        {
            // If object is null
            if (obj == null)
            {
                // throws a argument null exception.
                throw new ArgumentNullException("Unable to compare a Card to a null object.");
            }

            // Convert an argument to a Card
            PlayingCard compareCard = obj as PlayingCard;
            // If the conversion works
            if (compareCard != null)
            {
                // compares based on value first, then Suit
                int thisSort = this.myValue * 10 + (int)this.Suit;
                int compareCardSort = compareCard.myValue * 10 + (int)compareCard.mySuit;
                return (thisSort.CompareTo(compareCardSort));
            }

            else // Conversion has failed
            {
                // throw and argument exception
                throw new ArgumentException("Object being compared cannot be converted to a Card.");
            }
        } // End of CompareTo

        // Clone Method
        // Supports the IClonable interface.  Used for deep copying in card collection classes
        public object Clone()
        {
            return this.MemberwiseClone();// Return a memberwise clone
        } // End of Clone

        // ToString, overrides System.Object.ToString()
        public override string ToString()
        {
            string cardString; // holds the playing card name

            // if the card is face up
            if (faceUp)
            {
                // if the card is a Joker
                if (myRank == Rank.Joker)
                {
                    // set card name string to (Red|Black) Joker
                    // if suit is black
                    if (mySuit == Suit.Clubs || mySuit == Suit.Spades)
                    {
                        // Set the name string to black joker
                        cardString = "Joker_Black";
                    }

                    else // suit must be red
                    {
                        // set the name string to red joker
                        cardString = "Joker_Red";
                    }
                }

                // Otherwise, the card is a face up but not a Joker
                else
                {
                   // set the card name to {Rank} of {Suit}
                    cardString = myRank.ToString() + " of " + mySuit.ToString();
                }
            }

            // Or the card is face down
            else
            {
                // set the card name to face down
                cardString = "Face Down";
            }

            // return the appropriate card name string
            return cardString;
        } 

        // Equals: overrides System.Object.Equals()
        // true if the card values are equal
        public override bool Equals(object obj)
        {
            return (this.CardValue == ((PlayingCard)obj).CardValue);
        }

        // Equals: overrides System.Object.GetHashCode()
        // returns Card Value * 10 + Suit number
        public override int GetHashCode()
        {
            return this.myValue * 100 + (int)this.mySuit * 10 + ((this.faceUp)?1:0);
        }

        // GetCardImage Method
        // Gets the image associated with the card from the resource file
        // an image corresponding to the playing card

        public Image GetCardImage()
        {
            string imageName; // holds the name of the image in the file
            Image cardImage; // holds the image
            // if the card is face up
            if (!faceUp)
            {
                // set image name to "Back"
                imageName = "Back";
            }

                // if the card is a Joker
                else if (myRank == Rank.Joker)
                {
                    // set card name string to (Red|Black) Joker
                    // if suit is black
                    if (mySuit == Suit.Clubs || mySuit == Suit.Spades)
                    {
                        // Set the image to black joker
                        imageName = "Joker_Black";
                    }

                    else // suit must be red
                    {
                        // set the name string to red joker
                        imageName = "Joker_Red";
                    }
                }

                // Otherwise, the card is a face up but not a Joker
                else
                {
                    // set the card name to {Rank} of {Suit}
                   imageName = myRank.ToString() + "_" + mySuit.ToString();
                }

            // Set the image to the appropriate object we get from the resources files
            cardImage = Properties.Resources.ResourceManager.GetObject(imageName) as Image;
                  
            // return the image
            return cardImage;
        } 

        // DebugString
        // Generates a string showing state of the card object
        // Gives a breakdown of problems or a rundown of the program after running it
        public string DebugString()
        {
            string cardState = (string)(myRank.ToString() + " of " + mySuit.ToString().PadLeft(20));
            cardState += (string)((FaceUp ? "(Face Up)" : "(Face Down)").PadLeft(12));
            cardState += " Value: " + myValue.ToString().PadLeft(2);
            cardState += ((altValue != null) ? "/" + altValue.ToString() : "");
            return cardState;
        }

        #endregion

        #region RELATIONAL OPERATORS

        // Comparing the values for the equal to operator
        public static bool operator ==(PlayingCard left, PlayingCard right)
        {
            // Returns the result of the operation on the Card value
            return (left.CardValue == right.CardValue);
        }

        // Comparing the values for the not equal to operator
        public static bool operator !=(PlayingCard left, PlayingCard right)
        {
            // Returns the result of the operation on the Card value
            return (left.CardValue != right.CardValue);
        }

        // Comparing the values for the less than operator
        public static bool operator <(PlayingCard left, PlayingCard right)
        {
            // Returns the result of the operation on the Card value
            return (left.CardValue < right.CardValue);
        }

        // Comparing the values for the less than or equal to operator
        public static bool operator <=(PlayingCard left, PlayingCard right)
        {
            // Returns the result of the operation on the Card value
            return (left.CardValue <= right.CardValue);
        }

        // Comparing the values for the greater than operator
        public static bool operator >(PlayingCard left, PlayingCard right)
        {
            // Returns the result of the operation on the Card value
            return (left.CardValue > right.CardValue);
        }

        // Comparing the values for the greater than or equal to operator
        public static bool operator >=(PlayingCard left, PlayingCard right)
        {
            // Returns the result of the operation on the Card value
            return (left.CardValue >= right.CardValue);
        }
        
        #endregion
    }
    
}
