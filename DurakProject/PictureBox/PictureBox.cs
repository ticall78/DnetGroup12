/* Lab Name:       Lab 4- Windows Form Control
  * File Name:     PictureBox.cs 
  * Name:          Peter Kalo 
  * Student ID:    100503976
  * Date:          March 17th 2014
  * Description:   Creating a windows form control project.  Within the user creates Constructors(default &
  *                 Parameterized.  Fields and properties for the Playing Card, Suit, Rank, Face Up, Orientation
  *                 and Update card Image fields.  Event Handlers for Click and Card Flipped as well as the Form Load.
  *                 Also within other methods region the overriding of the ToString() method.  
  *                 The PictureBox is used to test the various actions the card will be able to handle.
  *                 Will also be referenced by the Car library class and will be passed to the Demo Tester Form for final
  *                 demonstartion purposes.
  */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PeterCardLibrary; // Referenced card library used

namespace PictureBox // Name of the project
{
    // A control to use in a windows forms application that will display a playing card
    public partial class PictureBox : UserControl
    {
        #region FIELDS AND PROPERTIES
        // Card Property: sets and gets underlying card objet
        private PlayingCard myCard;
        public PlayingCard Card
        {
            set
            {
                myCard = value;
                UpdateCardImage(); // updates the card image
            }

            get { return myCard; }
        }

        // Suit Property: sets and gets the underlying Card suit
        public Suit Suit
        {
            set
            {
                Card.Suit = value;
                UpdateCardImage(); // updates the card image
            }

            get { return Card.Suit; }
        }

        // Rank Property: sets and gets the underlying Card Rank
        public Rank Rank
        {
            set
            {
                myCard.Rank = value;
                UpdateCardImage(); // updates the card image
            }

            get { return Card.Rank; }
        }

        // FaceUp Property: sets and gets the underlying card faceup property
        public bool FaceUp
        {
            set
            {
                // if the value is different than the underlying card's faceup property
               if (myCard.FaceUp != value)  // Card is flipping over
                {
                    myCard.FaceUp = value; // change the card's FaceUp property

                    UpdateCardImage(); // update the card image(front or back)

                    // If there is a event handler for CardFlipped in the client program
                    if (CardFlipped != null)
                        CardFlipped(this, new EventArgs()); //Call it
                }
            }

            get { return Card.FaceUp; }
        }

        // Card Orientation Property: sets and gets the oreintation of the card
        private Orientation myOrientation;
        public Orientation CardOrientation
        {
            set
            {
                // if the value is different than myOrientation
                if (myOrientation != value)
                {
                    myOrientation = value; // Will change the orientation(swaps height and width)
                    this.Size = new Size(Size.Height, Size.Width);
                    UpdateCardImage(); //Update the card image
                }
            }
            get { return myOrientation; }
        }

        // UpdateCardImage Method: sets the picture box image using the underlying
        // card and orientation
        private void UpdateCardImage()
        {
            pbPictureBox.Image = myCard.GetCardImage();

            // if the orientation is horizontal
            if (myOrientation == Orientation.Horizontal)
            {
                // rotate the image
                pbPictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
        }

        #endregion

        #region CONSTRUCTORS
        // Default constructor: constructs the control with a new card, oriented vertically
        public PictureBox()
        {
            InitializeComponent();  // required method for designer support
            myOrientation = Orientation.Vertical; // set Orientation to vertical
            Card = new PlayingCard(); // create a new underlying card
        }

        // Parameterized constructor that has a playing card and orientation parameters to constructs the control
        public PictureBox(PlayingCard card, Orientation orientation = Orientation.Vertical)
        {
            InitializeComponent();
            myOrientation = orientation; // set the orientation
            myCard = card; // set underlying card
        }

        #endregion

        #region EVENTS AND EVENT HANDLERS

        // Event handler for the load event
       private void PictureBox_Load_1(object sender, EventArgs e)
        {
            UpdateCardImage();  // Updates the card image
        }

        // An event in the program can handle when the card flips face up or down
        public event EventHandler CardFlipped;

        // An event the client program can handle when the user clicks the control
        new public event EventHandler Click;


        // Event handler for the click of the picture box control
        private void pbPictureBox_Click(object sender, EventArgs e)
        {
            if (Click != null) // if there is a handler clicking the control in the client program
                Click(this, e); // Call it
        }

        #endregion

        #region OTHER METHODS

        // Control that returns the name of the card as a string
        public override string ToString()
        {
            return myCard.ToString();
        }

        #endregion   
       
             
    }
}

