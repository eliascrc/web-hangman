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

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            playBtn.Enabled = trimmedPlayerName().Length > 0;
        }

        private String trimmedPlayerName()
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

        private void playBtn_Click(object sender, EventArgs e)
        {
            (new GameForm(this, trimmedPlayerName())).Show();
            this.nameTextBox.Clear();
            this.Hide();
        }

        private void highscores_Click(object sender, EventArgs e)
        {
            (new HighscoresForm(this)).Show();
            this.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
