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
     * Form for showing the highscores that are stored in the game server
     */
    public partial class HighscoresForm : Form
    {

        private WelcomeForm welcomeForm;

        /**
         * Constructor that initializes the web service, creates a list of highscores and fills it with the
         * highscores returned by the server. Finally shows the highscores in the data grid view.
         */
        public HighscoresForm(WelcomeForm welcomeForm)
        {
            InitializeComponent();
            this.welcomeForm = welcomeForm;
            ECCI_Hangman.ECCI_HangmanPortClient hangmanClient = new ECCI_Hangman.ECCI_HangmanPortClient();

            String[] splitedHighscore;
            List<Highscore> highscoreStructs = new List<Highscore>();

            String[] highscores = hangmanClient.listHighscores();
            foreach (String highscore in highscores)
            {
                splitedHighscore = highscore.Split(':');
                highscoreStructs.Add(new Highscore(splitedHighscore[0], splitedHighscore[1], splitedHighscore[2], splitedHighscore[3]));
            }

            var source = new BindingSource();
            source.DataSource = highscoreStructs;
            highscoreDataGrid.DataSource = source;

            highscoreDataGrid.Columns[0].HeaderText = "Nombre";
            highscoreDataGrid.Columns[1].HeaderText = "Palabra Resuelta";
            highscoreDataGrid.Columns[2].HeaderText = "Tiempo en segundos";
            highscoreDataGrid.Columns[3].HeaderText = "Intentos";
        }

        /**
         * When the back button is pressed, it closes the form
         */
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
        /**
         * When the highscore form is closed, show the welcome form
         */
        private void HighscoresForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.welcomeForm.Show();
        }
    }

    /**
     * Class that represents a Highscore within the game
     */
    class Highscore
    {
        public String name { get; set; }
        public String solvedWord { get; set; }
        public String seconds { get; set; }
        public String tries { get; set; }

        /**
         * Basic Constructor
         */
        public Highscore(String name, String solvedWord, String seconds, String tries)
        {
            this.name = name;
            this.solvedWord = solvedWord;
            this.seconds = seconds;
            this.tries = tries;
        }
    }

}
