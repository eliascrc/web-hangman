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
    public partial class WelcomeForm : Form
    {

        public WelcomeForm()
        {
            InitializeComponent();
            this.AcceptButton = playBtn;
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            (new GameForm(trimmedPlayerName())).Show();
            this.Hide();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

            playBtn.Enabled = trimmedPlayerName().Length > 0;
        }

        private String trimmedPlayerName()
        {
            int i;
            for (i = 0; i < nameTextBox.TextLength && nameTextBox.Text[i] == ' '; i++);

            return nameTextBox.Text.Substring(i);
        }

        private void highscores_Click(object sender, EventArgs e)
        {
            (new HighscoresForm(this)).Show();
            this.Hide();
        }
    }
}
