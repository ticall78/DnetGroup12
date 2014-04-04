namespace DemoTester
{
    partial class frmDemoTester
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDemoTester));
            this.cboSuit = new System.Windows.Forms.ComboBox();
            this.cboRank = new System.Windows.Forms.ComboBox();
            this.btnFlipCard = new System.Windows.Forms.Button();
            this.lblClicked = new System.Windows.Forms.Label();
            this.lblFlipped = new System.Windows.Forms.Label();
            this.cbxTestCard = new PictureBox.PictureBox();
            this.SuspendLayout();
            // 
            // cboSuit
            // 
            this.cboSuit.FormattingEnabled = true;
            this.cboSuit.Location = new System.Drawing.Point(214, 25);
            this.cboSuit.Name = "cboSuit";
            this.cboSuit.Size = new System.Drawing.Size(101, 21);
            this.cboSuit.TabIndex = 0;
            this.cboSuit.SelectedIndexChanged += new System.EventHandler(this.cboSuit_SelectedIndexChanged);
            // 
            // cboRank
            // 
            this.cboRank.FormattingEnabled = true;
            this.cboRank.Location = new System.Drawing.Point(214, 52);
            this.cboRank.Name = "cboRank";
            this.cboRank.Size = new System.Drawing.Size(101, 21);
            this.cboRank.TabIndex = 1;
            this.cboRank.SelectedIndexChanged += new System.EventHandler(this.cboRank_SelectedIndexChanged);
            // 
            // btnFlipCard
            // 
            this.btnFlipCard.Location = new System.Drawing.Point(214, 92);
            this.btnFlipCard.Name = "btnFlipCard";
            this.btnFlipCard.Size = new System.Drawing.Size(93, 23);
            this.btnFlipCard.TabIndex = 2;
            this.btnFlipCard.Text = "Flip Card";
            this.btnFlipCard.UseVisualStyleBackColor = true;
            this.btnFlipCard.Click += new System.EventHandler(this.btnFlipCard_Click);
            // 
            // lblClicked
            // 
            this.lblClicked.Location = new System.Drawing.Point(12, 192);
            this.lblClicked.Name = "lblClicked";
            this.lblClicked.Size = new System.Drawing.Size(204, 23);
            this.lblClicked.TabIndex = 3;
            this.lblClicked.Text = "Card Not Clicked Yet";
            // 
            // lblFlipped
            // 
            this.lblFlipped.Location = new System.Drawing.Point(12, 215);
            this.lblFlipped.Name = "lblFlipped";
            this.lblFlipped.Size = new System.Drawing.Size(204, 23);
            this.lblFlipped.TabIndex = 4;
            this.lblFlipped.Text = "Card Not Flipped Yet.";
            // 
            // cbxTestCard
            // 
            this.cbxTestCard.CardOrientation = System.Windows.Forms.Orientation.Vertical;
            this.cbxTestCard.FaceUp = false;
            this.cbxTestCard.Location = new System.Drawing.Point(15, 12);
            this.cbxTestCard.Name = "cbxTestCard";
            this.cbxTestCard.Rank = PeterCardLibrary.Rank.King;
            this.cbxTestCard.Size = new System.Drawing.Size(106, 169);
            this.cbxTestCard.Suit = PeterCardLibrary.Suit.Spades;
            this.cbxTestCard.TabIndex = 5;
            this.cbxTestCard.CardFlipped += new System.EventHandler(this.cbxTestCard_CardFlipped);
            this.cbxTestCard.Click += new System.EventHandler(this.cbxTestCard_Click);
            // 
            // frmDemoTester
            // 
            this.AcceptButton = this.btnFlipCard;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 247);
            this.Controls.Add(this.cbxTestCard);
            this.Controls.Add(this.lblFlipped);
            this.Controls.Add(this.lblClicked);
            this.Controls.Add(this.btnFlipCard);
            this.Controls.Add(this.cboRank);
            this.Controls.Add(this.cboSuit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDemoTester";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PictureBox Test";
            this.Load += new System.EventHandler(this.frmDemoTester_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSuit;
        private System.Windows.Forms.ComboBox cboRank;
        private System.Windows.Forms.Button btnFlipCard;
        private System.Windows.Forms.Label lblClicked;
        private System.Windows.Forms.Label lblFlipped;
        private PictureBox.PictureBox cbxTestCard;
    }
}

