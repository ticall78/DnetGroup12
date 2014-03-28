using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CardBox
{
    public partial class CardBox: UserControl
    {
        #region FIELDS AND PROPERTIES

        private PlayingCard myCard;
        public PlayingCard Card
        {
            set
            {
                myCard = value;
                pbMyPictureBox.Image = myCard.GetCardImage();
            }
            get { return myCard; }
        }

        public CardSuit Suit
        {
            set
            {
                Card.Suit = value;
            }
            get { return Card.Suit; }
        }

        public CardRank Rank
        {
            set
            {
                Card.Rank = value;
            }
            get { return Card.Rank; }
        }

        public bool FaceUp
        {
            set
            {
                myCard.FaceUp = value;
            }
            get { return Card.FaceUp; }
        }
        #endregion


        private Orientation myOrientation;
        public Orientation CardOrientation
        {
            set
            { (myOrientation != value)
                {
                    myOrientation = value;
                    this.Size = new Size(Size.Height, Size.Width);
                    UpdateCardImage();
                }
            }
            get (return myOrientation)
        }

        private void UpdateCardImage()
        {
            pbMyPictureBox.Image = myCard.GetCardImage();
            if (myOrientation == Orientation.Horizontal)
            {
                pbMyPictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
        }


        public CardBox()
        {
            InitializeComponent();
            myOrientation = Orientation.Vertical;
            myCard = new PlayingCard();
        }

    
}
}
