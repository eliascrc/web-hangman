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
    public partial class GameForm : Form
    {

        private WelcomeForm welcomeForm;
        private ECCI_Hangman.ECCI_HangmanPortClient hangmanClient;
        private int remainingAttempts;
        private int misses;
        private int seconds;
        private int minutes;
        private String playerName;
        private PictureBox[] pictures;
        private Button[] buttons;

        public GameForm(WelcomeForm welcomeForm, String playerName)
        {
            InitializeComponent();
            this.welcomeForm = welcomeForm;
            this.playerName = playerName;
            this.hangmanClient = new ECCI_Hangman.ECCI_HangmanPortClient(); ;

            this.playerLbl.Text += "  " + playerName;
            this.seconds = this.minutes = this.misses = 0;
            this.remainingAttempts = 7;
            this.remAttemptsLbl.Text = "Le quedan " + this.remainingAttempts + " intentos";
            this.wordTextBox.Text = this.beautifyWord(this.hangmanClient.startGame(this.playerName));
            this.pictures = new PictureBox[] { headPicBox, bodyPicBox, arm1PicBox, arm2PicBox, leg1PicBox, leg2PicBox };
            this.buttons = new Button[] { ABtn, BBtn, CBtn, DBtn, EBtn, FBtn, GBtn, HBtn, IBtn, JBtn, KBtn, LBtn, MBtn, NBtn,
                                            OBtn, PBtn, QBtn, RBtn, SBtn, TBtn, UBtn, VBtn, WBtn, XBtn, YBtn, ZBtn };
        }

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

        private void LetterButton_Click(object sender, EventArgs e)
        {
            Button pressedBtn = (Button)sender;

            String[] returnedValues = this.hangmanClient.playLetter(pressedBtn.Text.ToLower()).Split('-');

            if (remainingAttempts > 1)
            {
                if (Int32.Parse(returnedValues[0]) < remainingAttempts)
                {
                    this.pictures[this.misses].Visible = true;
                    this.misses++;
                    this.remainingAttempts = Int32.Parse(returnedValues[0]);
                    this.remAttemptsLbl.Text = "Le quedan " + this.remainingAttempts + " intentos";
                }
                else if (!returnedValues[1].Contains('*'))
                {
                    this.remAttemptsLbl.Text = "¡Has ganado!";
                    this.disableAllBtns();
                    this.backBtn.Visible = true;
                    this.backBtn.Enabled = true;
                }
                pressedBtn.Enabled = false;
            }
            else
            {
                this.headPicBox.Visible = false;
                this.deadHeadPicBox.Visible = true;
                this.disableAllBtns();
                this.remAttemptsLbl.Text = "¡Ha perdido!";
                this.backBtn.Visible = true;
                this.backBtn.Enabled = true;
            }

            Console.WriteLine(returnedValues[1] + "Hola");
            this.wordTextBox.Text = this.beautifyWord(returnedValues[1]);
        }

        private void disableAllBtns()
        {
            foreach (Button button in this.buttons)
            {
                button.Enabled = false;
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void letterBtn_Disabled(object sender, EventArgs e)
        {
            if (!((Button)sender).Enabled)
            {
                ((Button)sender).FlatAppearance.BorderColor = Color.DimGray;
            }
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.welcomeForm.Show();
        }
    }
}
