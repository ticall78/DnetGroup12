namespace PictureBox
{
    partial class PictureBox
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPictureBox
            // 
            this.pbPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPictureBox.Location = new System.Drawing.Point(0, 0);
            this.pbPictureBox.Name = "pbPictureBox";
            this.pbPictureBox.Size = new System.Drawing.Size(106, 169);
            this.pbPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPictureBox.TabIndex = 0;
            this.pbPictureBox.TabStop = false;
            this.pbPictureBox.Click += new System.EventHandler(this.pbPictureBox_Click);
            // 
            // PictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbPictureBox);
            this.Name = "PictureBox";
            this.Size = new System.Drawing.Size(106, 169);
            this.Load += new System.EventHandler(this.PictureBox_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pbPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPictureBox;

    }
}
