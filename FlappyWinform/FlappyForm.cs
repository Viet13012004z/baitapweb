using System;
using System.Windows.Forms;

namespace WinFormTest
{
    public partial class FlappyForm : Form
    {
        int gravity = 8;
        int score = 0;
        int pipeSpeed = 5;

        public FlappyForm()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = "Score: " + score;

            if (pipeBottom.Left < -80)
            {
                pipeBottom.Left = 400;
                score++;
            }

            if (pipeTop.Left < -80)
            {
                pipeTop.Left = 400;
                score++;
            }

            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds))
            {
                gameTimer.Stop();
                scoreText.Text += "   Game Over!";
            }
        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -8;
            }
        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 8;
            }
        }
    }
}
