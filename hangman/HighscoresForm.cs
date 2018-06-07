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
    public partial class HighscoresForm : Form
    {

        private WelcomeForm welcomeForm;

        public HighscoresForm(WelcomeForm welcomeForm)
        {
            InitializeComponent();
            this.welcomeForm = welcomeForm;
            ECCI_Hangman.ECCI_HangmanPortClient hangmanClient = new ECCI_Hangman.ECCI_HangmanPortClient();

            String[] splitedHighscore;
            List<HighscoreStruct> highscoreStructs = new List<HighscoreStruct>();

            String[] highscores = hangmanClient.listHighscores();
            foreach (String highscore in highscores)
            {
                splitedHighscore = highscore.Split(':');
                highscoreStructs.Add(new HighscoreStruct(splitedHighscore[0], splitedHighscore[1], splitedHighscore[2], splitedHighscore[3]));
            }

            var source = new BindingSource();
            source.DataSource = highscoreStructs;
            highscoreDataGrid.DataSource = source;

            highscoreDataGrid.Columns[0].HeaderText = "Nombre";
            highscoreDataGrid.Columns[1].HeaderText = "Palabra Resuelta";
            highscoreDataGrid.Columns[2].HeaderText = "Tiempo en segundos";
            highscoreDataGrid.Columns[3].HeaderText = "Intentos";
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HighscoresForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.welcomeForm.Show();
        }
    }

    class HighscoreStruct
    {
        public String name { get; set; }
        public String solvedWord { get; set; }
        public String seconds { get; set; }
        public String tries { get; set; }

        public HighscoreStruct(String name, String solvedWord, String seconds, String tries)
        {
            this.name = name;
            this.solvedWord = solvedWord;
            this.seconds = seconds;
            this.tries = tries;
        }
    }

}
