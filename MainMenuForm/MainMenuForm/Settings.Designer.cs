namespace MainMenuForm
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.lblCards = new System.Windows.Forms.Label();
            this.rad20 = new System.Windows.Forms.RadioButton();
            this.rad36 = new System.Windows.Forms.RadioButton();
            this.rad52 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblCards
            // 
            this.lblCards.BackColor = System.Drawing.Color.Transparent;
            this.lblCards.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCards.Location = new System.Drawing.Point(12, 72);
            this.lblCards.Name = "lblCards";
            this.lblCards.Size = new System.Drawing.Size(226, 18);
            this.lblCards.TabIndex = 0;
            this.lblCards.Text = "How many cards would you like to play with?";
            // 
            // rad20
            // 
            this.rad20.AutoSize = true;
            this.rad20.BackColor = System.Drawing.Color.Transparent;
            this.rad20.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rad20.Location = new System.Drawing.Point(12, 93);
            this.rad20.Name = "rad20";
            this.rad20.Size = new System.Drawing.Size(37, 17);
            this.rad20.TabIndex = 1;
            this.rad20.Text = "20";
            this.rad20.UseVisualStyleBackColor = false;
            // 
            // rad36
            // 
            this.rad36.AutoSize = true;
            this.rad36.BackColor = System.Drawing.Color.Transparent;
            this.rad36.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rad36.Location = new System.Drawing.Point(112, 93);
            this.rad36.Name = "rad36";
            this.rad36.Size = new System.Drawing.Size(37, 17);
            this.rad36.TabIndex = 2;
            this.rad36.Text = "36";
            this.rad36.UseVisualStyleBackColor = false;
            // 
            // rad52
            // 
            this.rad52.AutoSize = true;
            this.rad52.BackColor = System.Drawing.Color.Transparent;
            this.rad52.Checked = true;
            this.rad52.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rad52.Location = new System.Drawing.Point(201, 93);
            this.rad52.Name = "rad52";
            this.rad52.Size = new System.Drawing.Size(37, 17);
            this.rad52.TabIndex = 3;
            this.rad52.TabStop = true;
            this.rad52.Tag = "";
            this.rad52.Text = "52";
            this.rad52.UseVisualStyleBackColor = false;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.rad52);
            this.Controls.Add(this.rad36);
            this.Controls.Add(this.rad20);
            this.Controls.Add(this.lblCards);
            this.DoubleBuffered = true;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCards;
        private System.Windows.Forms.RadioButton rad20;
        private System.Windows.Forms.RadioButton rad36;
        private System.Windows.Forms.RadioButton rad52;
    }
}