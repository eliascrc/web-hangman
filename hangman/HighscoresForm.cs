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
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.welcomeForm.Show();
            this.Close();
        }
    }
}
