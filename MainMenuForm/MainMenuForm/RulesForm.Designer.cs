namespace MainMenuForm
{
    partial class frmRules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRules));
            this.lblRules = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRules
            // 
            this.lblRules.BackColor = System.Drawing.Color.Transparent;
            this.lblRules.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRules.Location = new System.Drawing.Point(0, 100);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(634, 451);
            this.lblRules.TabIndex = 0;
            this.lblRules.Text = resources.GetString("lblRules.Text");
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.LightGreen;
            this.BtnExit.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(544, 555);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(90, 31);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "Close";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // frmRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(646, 591);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.lblRules);
            this.Name = "frmRules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RulesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.Button BtnExit;
    }
}