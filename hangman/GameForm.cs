using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hangman
{
    public partial class GameForm : Form
    {

        private int tries;
        private PictureBox[] pictures;

        public GameForm(String playerName)
        {
            InitializeComponent();
            this.playerLbl.Text = this.playerLbl.Text + "  " + playerName;
            this.tries = 0;
            this.pictures = new PictureBox[] { headPicBox, bodyPicBox, arm1PicBox, arm2PicBox, leg1PicBox, leg2PicBox };
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LetterButton_Click(object sender, EventArgs e)
        {
            if (this.tries < 6)
            {
                this.pictures[this.tries].Visible = true;
                this.tries++;
                ((Button)sender).Enabled = false;
            }
            else if (this.tries == 6)
            {
                this.headPicBox.Visible = false;
                this.deadHeadPicBox.Visible = true;
                this.tries++;
                ((Button)sender).Enabled = false;
            }
        }
    }
}
