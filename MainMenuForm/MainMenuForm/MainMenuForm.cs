using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MainMenuForm
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            frmRules f2 = new frmRules();
            f2.ShowDialog(); // Shows Form2

        }

        private void About_Click(object sender, EventArgs e)
        {
            frmAbout f3 = new frmAbout();
            f3.ShowDialog(); // Shows Form2
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettings f4 = new frmSettings();
            f4 .ShowDialog(); // Shows Form2
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            frmPlayGame f5 = new frmPlayGame();
            f5.ShowDialog(); // Shows Form2

        }
    }
}
