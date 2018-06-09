using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hangman
{
    /**
     * Form in charge of presenting and managing the game logic.
     */
    public partial class GameForm : Form
    {

        private WelcomeForm welcomeForm;

        // SOAP Web Service
        private ECCI_Hangman.ECCI_HangmanPortClient hangmanClient;

        // The player's remaining attempts
        private int remainingAttempts;

        // The player's misses
        private int misses;

        // The player's name
        private String playerName;

        // The hangman picture boxes
        private PictureBox[] pictures;

        // The game's letter buttons
        private Button[] buttons;

        /**
         * Constructor that creates the web service instance, initializes the labels, misses, remaining attempts
         * and sets the player's name and remaining attempts in the form.
         */
        public GameForm(WelcomeForm welcomeForm, String playerName)
        {
            InitializeComponent();
            this.welcomeForm = welcomeForm;
            this.playerName = playerName;
            this.hangmanClient = new ECCI_Hangman.ECCI_HangmanPortClient(); ;

            this.playerLbl.Text += "  " + playerName;
            this.misses = 0;
            this.remainingAttempts = 7;
            this.remAttemptsLbl.Text = "Le quedan " + this.remainingAttempts + " intentos";
            this.wordTextBox.Text = this.beautifyWord(this.hangmanClient.startGame(this.playerName));
            this.pictures = new PictureBox[] { headPicBox, bodyPicBox, arm1PicBox, arm2PicBox, leg1PicBox, leg2PicBox };
            this.buttons = new Button[] { ABtn, BBtn, CBtn, DBtn, EBtn, FBtn, GBtn, HBtn, IBtn, JBtn, KBtn, LBtn, MBtn, NBtn,
                                            OBtn, PBtn, QBtn, RBtn, SBtn, TBtn, UBtn, VBtn, WBtn, XBtn, YBtn, ZBtn };
        }

        /**
         * Receives the word returned by the web service and makes it prettier for the view
         */
        private string beautifyWord(string word)
        {
            word = word.Replace('*', '_');
            String beautifiedWord = "";

            for (int i = 0; i < word.Length; i++)
            {
                beautifiedWord += word[i] + "   ";
            }

            return beautifiedWord;
        }

        /**
         * Contains all the logic when the player clicks a letter button.
         */
        private void LetterButton_Click(object sender, EventArgs e)
        {
            Button pressedBtn = (Button)sender;

            // Sends the request to the Web Service. 
            // It returns a string containing the new remaining attempts a dash and the masked word.
            String[] returnedValues = this.hangmanClient.playLetter(pressedBtn.Text.ToLower()).Split('-');

            if (remainingAttempts > 1)
            {
                // If the word was a miss, it shows a new part of the hangman.
                if (Int32.Parse(returnedValues[0]) < remainingAttempts)
                {
                    this.pictures[this.misses].Visible = true;
                    this.misses++;
                    this.remainingAttempts = Int32.Parse(returnedValues[0]);
                    this.remAttemptsLbl.Text = "Le quedan " + this.remainingAttempts + " intentos";
                }
                // If it was not a miss and the masked word is not masked anymore, then the player won.
                else if (!returnedValues[1].Contains('*'))
                {
                    this.remAttemptsLbl.Text = "¡Has ganado!";
                    this.disableAllBtns();
                    this.backBtn.Visible = true;
                    this.backBtn.Enabled = true;
                }
                // Disables the played button.
                pressedBtn.Enabled = false;
            }
            // If there are none remaining attempts, then the player lost.
            else
            {
                this.headPicBox.Visible = false;
                this.deadHeadPicBox.Visible = true;
                this.disableAllBtns();
                this.remAttemptsLbl.Text = "¡Ha perdido!";
                this.backBtn.Visible = true;
                this.backBtn.Enabled = true;
            }
            
            // Shows the masked word
            this.wordTextBox.Text = this.beautifyWord(returnedValues[1]);
        }

        /**
         * Utility for disabling all letter buttons.
         */
        private void disableAllBtns()
        {
            foreach (Button button in this.buttons)
            {
                button.Enabled = false;
            }
        }

        /**
         * Close the form with the back button.
         */
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**
         * Change the letter button border when disabled
         */
        private void letterBtn_Disabled(object sender, EventArgs e)
        {
            if (!((Button)sender).Enabled)
            {
                ((Button)sender).FlatAppearance.BorderColor = Color.DimGray;
            }
        }

        /**
         * When the form is closed, show the welcome form
         */
        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.welcomeForm.Show();
        }
    }
}
