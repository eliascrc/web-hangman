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

        public GameForm()
        {
            InitializeComponent();
            Bitmap headBitmap = new Bitmap(headPicBox.Image);
            headBitmap.MakeTransparent(System.Drawing.Color.White);
            headPicBox.Image = headBitmap;
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            headPicBox.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            arm1PicBox.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            arm2PicBox.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bodyPicBox.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            leg1PicBox.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            leg2PicBox.Visible = true;
        }
    }
}
