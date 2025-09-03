using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe.Properties;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string GetCurrentPlayer()
        {
            if(lblTurn.Tag.ToString() == "Player 1")
            {
                lblTurn.Tag = "Player 2";
                return "Player 2";
            } else
            {
                lblTurn.Tag = "Player 1";
                return "Player 1";
            }
        }

        void UpdatePlayer()
        {
            string CurrentPlayer = GetCurrentPlayer();
            lblTurn.Text = CurrentPlayer;
        }

        void UpdateWinner(string Winner)
        {
            lblWinner.Text = Winner;
        }

        void GameOver(string Winner)
        {
            if(Winner == "Player 1")
            {
                MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (Winner == "Player 2")
            {
                MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (Winner == "Draw")
            {
                MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        string GetTheWinner()
        {
            if(lblTurn.Tag.ToString() == "Player 1")
            {
                if(pictureBox1.Tag.ToString() == "Player1" && pictureBox2.Tag.ToString() == "Player1" && pictureBox3.Tag.ToString() == "Player1")
                {
                    pictureBox1.BackColor = Color.GreenYellow;
                    pictureBox2.BackColor = Color.GreenYellow;
                    pictureBox3.BackColor = Color.GreenYellow;
                    return "Player 1";
                }

                if (pictureBox4.Tag.ToString() == "Player1" && pictureBox5.Tag.ToString() == "Player1" && pictureBox6.Tag.ToString() == "Player1")
                {
                    pictureBox4.BackColor = Color.GreenYellow;
                    pictureBox5.BackColor = Color.GreenYellow;
                    pictureBox6.BackColor = Color.GreenYellow;
                    return "Player 1";
                }

                if (pictureBox7.Tag.ToString() == "Player1" && pictureBox8.Tag.ToString() == "Player1" && pictureBox9.Tag.ToString() == "Player1")
                {
                    pictureBox7.BackColor = Color.GreenYellow;
                    pictureBox8.BackColor = Color.GreenYellow;
                    pictureBox9.BackColor = Color.GreenYellow;
                    return "Player 1";
                }

                if (pictureBox1.Tag.ToString() == "Player1" && pictureBox4.Tag.ToString() == "Player1" && pictureBox7.Tag.ToString() == "Player1")
                {
                    pictureBox1.BackColor = Color.GreenYellow;
                    pictureBox4.BackColor = Color.GreenYellow;
                    pictureBox7.BackColor = Color.GreenYellow;
                    return "Player 1";
                }

                if (pictureBox2.Tag.ToString() == "Player1" && pictureBox5.Tag.ToString() == "Player1" && pictureBox8.Tag.ToString() == "Player1")
                {
                    pictureBox2.BackColor = Color.GreenYellow;
                    pictureBox5.BackColor = Color.GreenYellow;
                    pictureBox8.BackColor = Color.GreenYellow;
                    return "Player 1";
                }

                if (pictureBox3.Tag.ToString() == "Player1" && pictureBox6.Tag.ToString() == "Player1" && pictureBox9.Tag.ToString() == "Player1")
                {
                    pictureBox3.BackColor = Color.GreenYellow;
                    pictureBox6.BackColor = Color.GreenYellow;
                    pictureBox9.BackColor = Color.GreenYellow;
                    return "Player 1";
                }

                if (pictureBox1.Tag.ToString() == "Player1" && pictureBox5.Tag.ToString() == "Player1" && pictureBox9.Tag.ToString() == "Player1")
                {
                    pictureBox1.BackColor = Color.GreenYellow;
                    pictureBox5.BackColor = Color.GreenYellow;
                    pictureBox9.BackColor = Color.GreenYellow;
                    return "Player 1";
                }

                if (pictureBox3.Tag.ToString() == "Player1" && pictureBox5.Tag.ToString() == "Player1" && pictureBox7.Tag.ToString() == "Player1")
                {
                    pictureBox3.BackColor = Color.GreenYellow;
                    pictureBox5.BackColor = Color.GreenYellow;
                    pictureBox7.BackColor = Color.GreenYellow;
                    return "Player 1";
                }
            }

            if(lblTurn.Tag.ToString() == "Player 2")
            {
                if (pictureBox1.Tag.ToString() == "Player2" && pictureBox2.Tag.ToString() == "Player2" && pictureBox3.Tag.ToString() == "Player2")
                {
                    pictureBox1.BackColor = Color.GreenYellow;
                    pictureBox2.BackColor = Color.GreenYellow;
                    pictureBox3.BackColor = Color.GreenYellow;
                    return "Player 2";
                }

                if (pictureBox4.Tag.ToString() == "Player2" && pictureBox5.Tag.ToString() == "Player2" && pictureBox6.Tag.ToString() == "Player2")
                {
                    pictureBox4.BackColor = Color.GreenYellow;
                    pictureBox5.BackColor = Color.GreenYellow;
                    pictureBox6.BackColor = Color.GreenYellow;
                    return "Player 2";
                }

                if (pictureBox7.Tag.ToString() == "Player2" && pictureBox8.Tag.ToString() == "Player2" && pictureBox9.Tag.ToString() == "Player2")
                {
                    pictureBox7.BackColor = Color.GreenYellow;
                    pictureBox8.BackColor = Color.GreenYellow;
                    pictureBox9.BackColor = Color.GreenYellow;
                    return "Player 2";
                }

                if (pictureBox1.Tag.ToString() == "Player2" && pictureBox4.Tag.ToString() == "Player2" && pictureBox7.Tag.ToString() == "Player2")
                {
                    pictureBox1.BackColor = Color.GreenYellow;
                    pictureBox4.BackColor = Color.GreenYellow;
                    pictureBox7.BackColor= Color.GreenYellow;
                    return "Player 2";
                }

                if (pictureBox2.Tag.ToString() == "Player2" && pictureBox5.Tag.ToString() == "Player2" && pictureBox8.Tag.ToString() == "Player2")
                {
                    pictureBox2.BackColor = Color.GreenYellow;
                    pictureBox5.BackColor = Color.GreenYellow;
                    pictureBox8.BackColor = Color.GreenYellow;
                    return "Player 2";
                }

                if (pictureBox3.Tag.ToString() == "Player2" && pictureBox6.Tag.ToString() == "Player2" && pictureBox9.Tag.ToString() == "Player2")
                {
                    pictureBox3.BackColor = Color.GreenYellow;
                    pictureBox6.BackColor = Color.GreenYellow;
                    pictureBox9.BackColor = Color.GreenYellow;
                    return "Player 2";
                }

                if (pictureBox1.Tag.ToString() == "Player2" && pictureBox5.Tag.ToString() == "Player2" && pictureBox9.Tag.ToString() == "Player2")
                {
                    pictureBox1.BackColor = Color.GreenYellow;
                    pictureBox5.BackColor = Color.GreenYellow;
                    pictureBox9.BackColor = Color.GreenYellow;
                    return "Player 2";
                }

                if (pictureBox3.Tag.ToString() == "Player2" && pictureBox5.Tag.ToString() == "Player2" && pictureBox7.Tag.ToString() == "Player2")
                {
                    pictureBox3.BackColor = Color.GreenYellow;
                    pictureBox5.BackColor = Color.GreenYellow;
                    pictureBox7.BackColor = Color.GreenYellow;
                    return "Player 2";
                }
            }

            if(pictureBox1.Tag.ToString() != "0" && pictureBox2.Tag.ToString() != "0" && pictureBox3.Tag.ToString() != "0" && pictureBox4.Tag.ToString() != "0" && pictureBox5.Tag.ToString() != "0" && pictureBox6.Tag.ToString() != "0" && pictureBox7.Tag.ToString() != "0" && pictureBox8.Tag.ToString() != "0" && pictureBox9.Tag.ToString() != "0")
            {
                return "Draw";
            }

            return "In Progress";
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.White);
            pen.Width = 10;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            // Horizontal lines
            e.Graphics.DrawLine(pen, 210, 180, 700, 180);
            e.Graphics.DrawLine(pen, 210, 300, 700, 300);

            // Vertical lines
            e.Graphics.DrawLine(pen, 360, 80, 360, 400);
            e.Graphics.DrawLine(pen, 535, 80, 535, 400);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Tag.ToString() != "Player1" && pictureBox1.Tag.ToString() != "Player2") {

                if (lblTurn.Tag.ToString() == "Player 1")
                {
                    pictureBox1.Image = Resources.X;
                    pictureBox1.Tag = "Player1";
                }
                else
                {
                    pictureBox1.Image = Resources.O;
                    pictureBox1.Tag = "Player2";
                }
                string Winner = GetTheWinner();
                UpdateWinner(Winner);
                GameOver(Winner);
                UpdatePlayer();
            } else
            {
                MessageBox.Show("Wrong Choice!", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Tag.ToString() != "Player1" && pictureBox2.Tag.ToString() != "Player2")
            {

                if (lblTurn.Text == "Player 1")
                {
                    pictureBox2.Image = Resources.X;
                    pictureBox2.Tag = "Player1";
                }
                else
                {
                    pictureBox2.Image = Resources.O;
                    pictureBox2.Tag = "Player2";
                }
                string Winner = GetTheWinner();
                UpdateWinner(Winner);
                GameOver(Winner);
                UpdatePlayer();
            }
            else
            {
                MessageBox.Show("Wrong Choice!", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Tag.ToString() != "Player1" && pictureBox3.Tag.ToString() != "Player2")
            {

                if (lblTurn.Tag.ToString() == "Player 1")
                {
                    pictureBox3.Image = Resources.X;
                    pictureBox3.Tag = "Player1";
                }
                else
                {
                    pictureBox3.Image = Resources.O;
                    pictureBox3.Tag = "Player2";
                }
                string Winner = GetTheWinner();
                UpdateWinner(Winner);
                GameOver(Winner);
                UpdatePlayer();
            }
            else
            {
                MessageBox.Show("Wrong Choice!", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox4.Tag.ToString() != "Player1" && pictureBox4.Tag.ToString() != "Player2")
            {

                if (lblTurn.Tag.ToString() == "Player 1")
                {
                    pictureBox4.Image = Resources.X;
                    pictureBox4.Tag = "Player1";
                }
                else
                {
                    pictureBox4.Image = Resources.O;
                    pictureBox4.Tag = "Player2";
                }
                string Winner = GetTheWinner();
                UpdateWinner(Winner);
                GameOver(Winner);
                UpdatePlayer();
            }
            else
            {
                MessageBox.Show("Wrong Choice!", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox5.Tag.ToString() != "Player1" && pictureBox5.Tag.ToString() != "Player2")
            {

                if (lblTurn.Tag.ToString() == "Player 1")
                {
                    pictureBox5.Image = Resources.X;
                    pictureBox5.Tag = "Player1";
                }
                else
                {
                    pictureBox5.Image = Resources.O;
                    pictureBox5.Tag = "Player2";
                }
                string Winner = GetTheWinner();
                UpdateWinner(Winner);
                GameOver(Winner);
                UpdatePlayer();
            }
            else
            {
                MessageBox.Show("Wrong Choice!", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox6.Tag.ToString() != "Player1" && pictureBox6.Tag.ToString() != "Player2")
            {

                if (lblTurn.Tag.ToString() == "Player 1")
                {
                    pictureBox6.Image = Resources.X;
                    pictureBox6.Tag = "Player1";
                }
                else
                {
                    pictureBox6.Image = Resources.O;
                    pictureBox6.Tag = "Player2";
                }
                string Winner = GetTheWinner();
                UpdateWinner(Winner);
                GameOver(Winner);
                UpdatePlayer();
            }
            else
            {
                MessageBox.Show("Wrong Choice!", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (pictureBox7.Tag.ToString() != "Player1" && pictureBox7.Tag.ToString() != "Player2")
            {

                if (lblTurn.Tag.ToString() == "Player 1")
                {
                    pictureBox7.Image = Resources.X;
                    pictureBox7.Tag = "Player1";
                }
                else
                {
                    pictureBox7.Image = Resources.O;
                    pictureBox7.Tag = "Player2";
                }
                string Winner = GetTheWinner();
                UpdateWinner(Winner);
                GameOver(Winner);
                UpdatePlayer();
            }
            else
            {
                MessageBox.Show("Wrong Choice!", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (pictureBox8.Tag.ToString() != "Player1" && pictureBox8.Tag.ToString() != "Player2")
            {

                if (lblTurn.Tag.ToString() == "Player 1")
                {
                    pictureBox8.Image = Resources.X;
                    pictureBox8.Tag = "Player1";
                }
                else
                {
                    pictureBox8.Image = Resources.O;
                    pictureBox8.Tag = "Player2";
                }
                string Winner = GetTheWinner();
                UpdateWinner(Winner);
                GameOver(Winner);
                UpdatePlayer();
            }
            else
            {
                MessageBox.Show("Wrong Choice!", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (pictureBox9.Tag.ToString() != "Player1" && pictureBox9.Tag.ToString() != "Player2")
            {
                if (lblTurn.Tag.ToString() == "Player 1")
                {
                    pictureBox9.Image = Resources.X;
                    pictureBox9.Tag = "Player1";
                }
                else
                {
                    pictureBox9.Image = Resources.O;
                    pictureBox9.Tag = "Player2";
                }

                string Winner = GetTheWinner();
                UpdateWinner(Winner);
                GameOver(Winner);
                UpdatePlayer();
            }
            else
            {
                MessageBox.Show("Wrong Choice!", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void PlayGame()
        {
            lblTurn.Text = "Player 1";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PlayGame();
        }

        void ResetPlayerTurn()
        {
            lblTurn.Text = "Player 1";
            lblTurn.Tag = "Player 1";
        }

        void ResetWinner()
        {
            lblWinner.Text = "In Progress";
        }

        void ResetPictures()
        {
            pictureBox1.Image = Resources.question_mark_96;
            pictureBox1.Tag = "0";
            pictureBox1.BackColor = Color.Black;
            pictureBox2.Image = Resources.question_mark_96;
            pictureBox2.Tag = "0";
            pictureBox2.BackColor = Color.Black;
            pictureBox3.Image = Resources.question_mark_96;
            pictureBox3.Tag = "0";
            pictureBox3.BackColor = Color.Black;
            pictureBox4.Image = Resources.question_mark_96;
            pictureBox4.Tag = "0";
            pictureBox4.BackColor = Color.Black;
            pictureBox5.Image = Resources.question_mark_96;
            pictureBox5.Tag = "0";
            pictureBox5.BackColor = Color.Black;
            pictureBox6.Image = Resources.question_mark_96;
            pictureBox6.Tag = "0";
            pictureBox6.BackColor = Color.Black;
            pictureBox7.Image = Resources.question_mark_96;
            pictureBox7.Tag = "0";
            pictureBox7.BackColor = Color.Black;
            pictureBox8.Image = Resources.question_mark_96;
            pictureBox8.Tag = "0";
            pictureBox8.BackColor = Color.Black;
            pictureBox9.Image = Resources.question_mark_96;
            pictureBox9.Tag = "0";
            pictureBox9.BackColor = Color.Black;
        }

        void RestartGame()
        {
            ResetPlayerTurn();
            ResetWinner();
            ResetPictures();
        }

        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
    }
}
