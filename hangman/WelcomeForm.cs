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
    /**
     * Initial form where the user starts the hangman game
     */
    public partial class WelcomeForm : Form
    {

        //Indicates if the play button is enabled
        private bool playBtnEnabled = false;

        /**
         * Constructor that assigns playBtn as the main button and sets its border color to gray.
         */
        public WelcomeForm()
        {
            InitializeComponent();
            this.AcceptButton = playBtn;
            this.playBtn.FlatAppearance.BorderColor = Color.DimGray;
        }

        /**
         * Trimms the player name by removing initial blank spaces and any ':' characters.
         */
        private String getTrimmedPlayerName()
        {
            int i;
            for (i = 0; i < nameTextBox.TextLength && nameTextBox.Text[i] == ' '; i++);

            String trimmedName =  nameTextBox.Text.Substring(i);
            if (trimmedName.Contains(":"))
            {
                trimmedName = trimmedName.Replace(":", "");
            }

            return trimmedName;
        }

        /**
         * Enables the name text box if the player name has any content
         */
        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            playBtn.Enabled = getTrimmedPlayerName().Length > 0;
        }

        /**
         * Go to the Game form when play is clicked
         */
        private void playBtn_Click(object sender, EventArgs e)
        {
            (new GameForm(this, getTrimmedPlayerName())).Show();
            this.nameTextBox.Clear();
            this.Hide();
        }

        /**
         * Go to highscores when highscore button is clicked
         */
        private void highscores_Click(object sender, EventArgs e)
        {
            (new HighscoresForm(this)).Show();
            this.Hide();
        }

        /**
         * Close the application with the exit button
         */
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**
         * Changes the play button border color when enabled/disabled
         */
        private void playBtn_EnabledChanged(object sender, EventArgs e)
        {
            this.playBtnEnabled = !this.playBtnEnabled;
            playBtn.FlatAppearance.BorderColor = this.playBtnEnabled ? Color.FromArgb(239, 164, 47) : Color.DimGray;
        }
    }
}
