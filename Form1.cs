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
        enum enPlayer
        {
            Player1, Player2
        }
        enum enWinner {
            Player1,
            Player2,
            Draw,
            InProgress
        };
        struct stGameStatus
        {
            public enWinner Winner;
            public bool IsGameOver;
            public int NumberOfPlay;
        };

         stGameStatus GameStatus;
        enPlayer PlayerTurn = enPlayer.Player1;

        public Form1()
        {
            InitializeComponent();
        }

        void EndGame()
        {

            lblTurn.Text = "Game Over";
            switch (GameStatus.Winner)
            {

                case enWinner.Player1:

                    lblWinner.Text = "Player 1";
                    break;

                case enWinner.Player2:

                    lblWinner.Text = "Player 2";
                    break;

                default:

                    lblWinner.Text = "Draw";
                    break;

            }

            MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        bool CheckValues(PictureBox pBox1, PictureBox pBox2, PictureBox pBox3)
        {
            if (pBox1.Tag.ToString() != "?" && pBox1.Tag.ToString() == pBox2.Tag.ToString() && pBox1.Tag.ToString() == pBox3.Tag.ToString())
            {
                pBox1.BackColor = Color.GreenYellow;
                pBox2.BackColor = Color.GreenYellow;
                pBox3.BackColor = Color.GreenYellow;

                if (pBox1.Tag.ToString() == "X") {
                    GameStatus.Winner = enWinner.Player1;
                    GameStatus.IsGameOver = true;
                    EndGame();
                    return true;
                } else
                {
                    GameStatus.Winner = enWinner.Player2;
                    GameStatus.IsGameOver = true;
                    EndGame();
                    return true;
                }

            }

            GameStatus.Winner = enWinner.InProgress;
            GameStatus.IsGameOver = false;
            return false;
        }

        void CheckWinner()
        {
            //checked rows
            //check Row1
            if (CheckValues(pictureBox1, pictureBox2, pictureBox3))
                return;

            //check Row2
            if (CheckValues(pictureBox4, pictureBox5, pictureBox6))
                return;

            //check Row3
            if (CheckValues(pictureBox7, pictureBox8, pictureBox9))
                return;

            //checked cols
            //check col1
            if (CheckValues(pictureBox1, pictureBox4, pictureBox7))
                return;

            //check col2
            if (CheckValues(pictureBox2, pictureBox5, pictureBox8))
                return;

            //check col3
            if (CheckValues(pictureBox3, pictureBox6, pictureBox9))
                return;

            //check Diagonal

            //check Diagonal1
            if (CheckValues(pictureBox1, pictureBox5, pictureBox9))
                return;

            //check Diagonal2
            if (CheckValues(pictureBox3, pictureBox5, pictureBox7))
                return;
        }

        void CheckDraw()
        {
            if (GameStatus.NumberOfPlay == 9 && GameStatus.Winner == enWinner.InProgress)
            {
                GameStatus.IsGameOver = true;
                GameStatus.Winner = enWinner.Draw;
                EndGame();
            }
        }

        void ChangeImage(PictureBox pBox)
        {
            if(GameStatus.IsGameOver)
            {
                string Winner;
                switch (GameStatus.Winner)
                {
                    case enWinner.Player1:
                        Winner = "Player 1";
                        break;
                    case enWinner.Player2:
                        Winner = "Player 2";
                        break;
                    default:
                        Winner = "Draw";
                        break;
                }
                string Message = "The Game is over and the winner is: " + Winner + Environment.NewLine + "Restart the game to play again.";
                MessageBox.Show(Message, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(pBox.Tag.ToString() == "?")
            {
                switch(PlayerTurn)
                {
                    case enPlayer.Player1:
                        pBox.Tag = "X";
                        pBox.Image = Resources.X;
                        PlayerTurn = enPlayer.Player2;
                        lblTurn.Text = "Player 2";
                        GameStatus.NumberOfPlay++;
                        CheckWinner();
                        CheckDraw();
                        break;

                    case enPlayer.Player2:
                        pBox.Tag = "O";
                        pBox.Image = Resources.O;
                        PlayerTurn = enPlayer.Player1;
                        lblTurn.Text = "Player 1";
                        GameStatus.NumberOfPlay++;
                        CheckWinner();
                        CheckDraw();
                        break;
                }
            } else
            {
                MessageBox.Show("Wrong Choice", "Worng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void OnPictureClick(object sender, EventArgs e)
        {
            ChangeImage((PictureBox)sender);
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

        void ResetPictureBox(PictureBox pBox)
        {
            pBox.Tag = "?";
            pBox.BackColor = Color.Transparent;
            pBox.Image = Resources.question_mark_96;
        }

        void RestartGame()
        {
            ResetPictureBox(pictureBox1);
            ResetPictureBox(pictureBox2);
            ResetPictureBox(pictureBox3);
            ResetPictureBox(pictureBox4);
            ResetPictureBox(pictureBox5);
            ResetPictureBox(pictureBox6);
            ResetPictureBox(pictureBox7);
            ResetPictureBox(pictureBox8);
            ResetPictureBox(pictureBox9);

            PlayerTurn = enPlayer.Player1;
            GameStatus.Winner = enWinner.InProgress;
            GameStatus.NumberOfPlay = 0;
            GameStatus.IsGameOver = false;
            lblWinner.Text = "In Progress";
        }
        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
    }
}
