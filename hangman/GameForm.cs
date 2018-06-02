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

        private int remainingAttempts;
        private int misses;
        private int seconds;
        private int minutes;
        private PictureBox[] pictures;

        public GameForm(String playerName)
        {
            InitializeComponent();
            this.playerLbl.Text += "  " + playerName;
            this.seconds = this.minutes = this.misses = 0;
            this.remainingAttempts = 7;
            this.remAttemptsLbl.Text = "Le quedan " + this.remainingAttempts + " intentos";
            this.wordTextBox.Text = "_ _ _ _ _ _ _ _";
            this.pictures = new PictureBox[] { headPicBox, bodyPicBox, arm1PicBox, arm2PicBox, leg1PicBox, leg2PicBox };
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LetterButton_Click(object sender, EventArgs e)
        {
            if (this.remainingAttempts > 0)
            {
                if (this.remainingAttempts > 1)
                {
                    this.pictures[this.misses].Visible = true;
                }
                else
                {
                    this.headPicBox.Visible = false;
                    this.deadHeadPicBox.Visible = true;
                    this.gameTimer.Stop();
                }
                this.misses++;
                this.remainingAttempts--;
                this.remAttemptsLbl.Text = "Le quedan " + this.remainingAttempts + " intentos";
                ((Button)sender).Enabled = false;
            }
        }

        private void secondEllapsed(object sender, EventArgs e)
        {
            this.seconds++;
            if (this.seconds >= 60)
            {
                this.minutes++;
                this.seconds = 0;
            }

            this.timerLbl.Text = ((this.minutes < 10) ? "0" : "") + this.minutes.ToString() + ":" 
                + ((this.seconds < 10) ? "0" : "") + this.seconds.ToString();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            this.gameTimer.Start();
        }
    }
}
