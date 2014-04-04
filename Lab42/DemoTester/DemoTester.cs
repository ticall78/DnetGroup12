/* Lab Name:       Lab 4- Windows Form Control
  * File Name:     DemoTester.cs 
  * Name:          Peter Kalo 
  * Student ID:    100503976
  * Date:          March 17th 2014
  * Description:   Creating a windows form project that goes hand in hand with a card library
  *                as well as a card box, both of which are referenced so they can be accessible.
  *                With the aid of event handlers, functionality of the forms Card can be clicked
  *                so that it has the orientation required as well as ensuring wehter it is faced up
  *                or down.  There are also two comboboxes that work with the cardbox to determine
  *                the rank and suit selected by the user. Once the button is clicked after selection
  *                is made, the appropriate card is dispalyed with the proper orientation when clicked,
  *                as well as two labels which display the state of the card and also the number of
  *                times the card is flipped in total increaseing with each selection.  
  */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PeterCardLibrary; // Referenced card library used

namespace DemoTester // Name of the project
{
    public partial class frmDemoTester : Form
    {
        // Default constructor
        public frmDemoTester()
        {
            InitializeComponent();
        }

        // Generates a click event so when program runs the text for the label 
        // Populates a specific action when clicked upon
        private void cbxTestCard_Click(object sender, EventArgs e)
        {
             lblClicked.Text = cbxTestCard.ToString() + " was clicked last.";  
           
            // If else statement to show the orientation of the card when clicked upon
            // Will show vertically
            if (cbxTestCard.CardOrientation == Orientation.Horizontal)
                cbxTestCard.CardOrientation = Orientation.Vertical;

            else
                // Else will show Horizontally when clicked
                cbxTestCard.CardOrientation = Orientation.Horizontal;

           
        }
        

        // Event handler for the button when clicked to make the card face up or show the rank and suit
        private void btnFlipCard_Click(object sender, EventArgs e)
        {
            cbxTestCard.FaceUp = !cbxTestCard.FaceUp;
        }

        // Changes the suit of the card control to the selected index for the Enum suit.
        private void cboSuit_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxTestCard.Suit = (PeterCardLibrary.Suit)cboSuit.SelectedIndex;
        }

        // Changes the suit of the card control to the selected index for the Enum rank.
        private void cboRank_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxTestCard.Rank = (PeterCardLibrary.Rank)cboRank.SelectedIndex + 1;
        }

        // Counter for how many times the card flips
        private int flipCount = 0;        
        // Event handler for the card to flip 
        private void cbxTestCard_CardFlipped(object sender, EventArgs e)
        {
            flipCount++; // increases the counter
    
            lblFlipped.Text = "Card flip: " + flipCount.ToString(); //output to the label the amount of times the card flips

        }

        // 
        private void frmDemoTester_Load(object sender, EventArgs e)
        {
            // Will populated the combo box witht he values in the enum for Rank
            cboRank.DataSource = Enum.GetValues(typeof(Rank));
            // Will populated the combo box witht he values in the enum for Suit
            cboSuit.DataSource = Enum.GetValues(typeof(Suit));

            // Will specify the cards rank and suit on form load
            PlayingCard theCard = new PeterCardLibrary.PlayingCard(Rank.Ace, Suit.Spades);
            //  Card will be face up on form load
            theCard.FaceUp = true;
            // Will set the Test card to the control of the new playing card attributes
            this.cbxTestCard.Card = theCard;

        }   
             
    }
}
