using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Properties;

namespace TicTacToe
{
    public partial class Form1 : Form
    {

        stGameStatus GameStatus;
        enPlayer PlayerTurn = enPlayer.PlayerX;

        enum enPlayer
        {
            PlayerX, PlayerO,
        }
        enum enWinner
        {
            PlayerX,
            PlayerO,
            Draw,
            GameInProgress
        }

        struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public short PlayCount;
            public short XWins;
            public short OWins;
        }

        public bool CheckValues(Button btn1, Button btn2, Button btn3)
        {
            if (btn1.Tag.ToString() != "?" && btn1.Tag.ToString() == btn2.Tag.ToString()
                && btn2.Tag.ToString() == btn3.Tag.ToString())
            {
                btn1.BackColor = Color.Lime;
                btn2.BackColor = Color.Lime;
                btn3.BackColor = Color.Lime;
                
                if (btn1.Tag.ToString() == "X")
                {
                    GameStatus.Winner = enWinner.PlayerX;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
                else
                {
                    GameStatus.Winner = enWinner.PlayerO;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
            }
            GameStatus.GameOver = false;
            return false;
        }
        public void EndGame()
        {
            lblTurn.Text = "Game Over";
            lblTurn.ForeColor = Color.Red;
            lblWinner.ForeColor = Color.Cyan;
            switch (GameStatus.Winner)
            {
                case enWinner.PlayerX:
                    lblWinner.Text = "Player X";
                    GameStatus.XWins++;
                    lblXWins.Text = $"X Wins: {GameStatus.XWins}";
                    break;
                case enWinner.PlayerO:
                    lblWinner.Text = "Player O";
                    GameStatus.OWins++;
                    lblOWins.Text = $"O Wins: {GameStatus.OWins}";
                    break;
                default:
                    lblWinner.Text = "Draw";
                    break;
            }

            //if (button1.Tag.ToString() == "?")
                button1.Enabled = false;
            //if (button2.Tag.ToString() == "?")
                button2.Enabled = false;
            //if (button3.Tag.ToString() == "?")
                button3.Enabled = false;
            //if (button4.Tag.ToString() == "?")
                button4.Enabled = false;
            //if (button5.Tag.ToString() == "?")
                button5.Enabled = false;
            //if (button6.Tag.ToString() == "?")
                button6.Enabled = false;
            //if (button7.Tag.ToString() == "?")
                button7.Enabled = false;
            //if (button8.Tag.ToString() == "?")
                button8.Enabled = false;
            //if (button9.Tag.ToString() == "?")
                button9.Enabled = false;

            string Winner;
            if (GameStatus.Winner != enWinner.Draw)

                Winner = $"Winner: {lblWinner.Text}";

            else
                Winner = "No Winner\nDraw!";

                MessageBox.Show(Winner, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public bool CheckWinner()
        {
            // rows
            if (CheckValues(button1, button2, button3))
                return true;
            if (CheckValues(button4, button5, button6))
                return true;
            if (CheckValues(button7, button8, button9))
                return true;

            // columns
            if (CheckValues(button1, button4, button7))
                return true;
            if (CheckValues(button2, button5, button8))
                return true;
            if (CheckValues(button3, button6, button9))
                return true;

            // diagonals
            if (CheckValues(button1, button5, button9))
                return true;
            if (CheckValues(button3, button5, button7))
                return true;
            return false;

        }
        public void ChangeImage(Button btn)
        {
            GameStatus.Winner = enWinner.GameInProgress;
            if (btn.Tag.ToString() == "?")
            {
                switch (PlayerTurn)
                {
                    case enPlayer.PlayerX:
                        btn.Image = Resources.X;
                        PlayerTurn = enPlayer.PlayerO;
                        lblTurn.Text = "Player O";
                        btn.Tag = "X";
                        GameStatus.PlayCount++;
                        if (CheckWinner())
                        {
                            GameStatus.Winner = enWinner.PlayerX;
                        }
                        break;

                    case enPlayer.PlayerO:
                        btn.Image = Resources.O;
                        PlayerTurn = enPlayer.PlayerX;
                        lblTurn.Text = "Player X";
                        btn.Tag = "O";
                        GameStatus.PlayCount++;
                        if (CheckWinner())
                        {
                            GameStatus.Winner = enWinner.PlayerO;
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (GameStatus.PlayCount == 9 && GameStatus.Winner != enWinner.PlayerO
                && GameStatus.Winner != enWinner.PlayerX)
            {
                GameStatus.GameOver = true;
                GameStatus.Winner = enWinner.Draw;
                EndGame();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color white = Color.FromArgb(255, 255, 255, 255);
            Pen whitePen = new Pen(white, 15);

            whitePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            whitePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            // draw horizontal lines
            e.Graphics.DrawLine(whitePen, 330, 230, 830, 230);
            e.Graphics.DrawLine(whitePen, 330, 370, 830, 370);

            // draw vertical lines
            e.Graphics.DrawLine(whitePen, 475, 120, 475, 480);
            e.Graphics.DrawLine(whitePen, 660, 120, 660, 480);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            ChangeImage((Button)sender);
        }

        private void ResetButton(Button btn)
        {
            btn.Image = Resources.question_mark_96;
            btn.Tag = "?";
            btn.BackColor = Color.Transparent;
            btn.Enabled = true;

        }
        private void RestartGame()
        {

            ResetButton(button1);
            ResetButton(button2);
            ResetButton(button3);
            ResetButton(button4);
            ResetButton(button5);
            ResetButton(button6);
            ResetButton(button7);
            ResetButton(button8);
            ResetButton(button9);

            PlayerTurn = enPlayer.PlayerX;
            lblTurn.Text = "Player X";
            lblTurn.ForeColor = Color.Lime;
            GameStatus.PlayCount = 0;
            GameStatus.GameOver = false;
            GameStatus.Winner = enWinner.GameInProgress;
            lblWinner.ForeColor = Color.White;
            lblWinner.Text = "In Progress";

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void btnResetWinsCounters_Click(object sender, EventArgs e)
        {
            GameStatus.XWins = 0;
            GameStatus.OWins = 0;
            lblXWins.Text = $"X wins: 0";
            lblOWins.Text = $"O wins: 0";
        }
    }
}
