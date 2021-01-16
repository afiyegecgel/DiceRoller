using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRoller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Game diceGame = new Game();

        private void Form1_Load(object sender, EventArgs e)
        {
            // When the game start, both players have 100TL
            diceGame.FirstPlayer = new Player();
            diceGame.FirstPlayer.Name = "Player 1";
            diceGame.FirstPlayer.Money = 100;
            lblFirstPlayerMoney.Text = diceGame.FirstPlayer.Money.ToString();

            diceGame.SecondPlayer = new Player();
            diceGame.SecondPlayer.Name = "Player 2";
            diceGame.SecondPlayer.Money = 100;
            lblSecondPlayerMoney.Text = diceGame.SecondPlayer.Money.ToString();
        }


        private void btnFirstPlayerPlay_Click(object sender, EventArgs e)
        {
            diceGame.FirstPlayer.PlayersDice = new Dice();
            diceGame.FirstPlayerRollDice();
            lblFirstPlayerDiceValue.Text = diceGame.FirstPlayer.PlayersDice.Value.ToString();

        }

        private void btnSecondPlayerPlay_Click(object sender, EventArgs e)
        {
            diceGame.SecondPlayer.PlayersDice = new Dice();
            diceGame.SecondPlayerRollDice();
            lblSecondPlayerDiceValue.Text = diceGame.SecondPlayer.PlayersDice.Value.ToString();

            Player winner = diceGame.GameResult();
            if (diceGame.FirstPlayer.Money < 0 || diceGame.SecondPlayer.Money < 0)
            {
               MessageBox.Show("End of the game");
            }
            else if(winner != null)
            {
                lblGameResult.Text = $" Winner {winner.Name} with {winner.PlayersDice.Value}";
            }
            else
            {
                lblGameResult.Text = "Draw!";
            }


            lblFirstPlayerMoney.Text = diceGame.FirstPlayer.Money.ToString();
            lblSecondPlayerMoney.Text = diceGame.SecondPlayer.Money.ToString();
        }

        private void btnFirstPlayerConfirmBet_Click(object sender, EventArgs e)
        {
            diceGame.FirstPlayer.Bet = Convert.ToInt32(txtFirsPlayerBet.Text);

            if (diceGame.FirstPlayer.Money < diceGame.FirstPlayer.Bet)
            {
                MessageBox.Show("Paranızdan fazla bahiste bulunamazsınız");
            }
        }

        private void btnSecondPlayerConfirmBet_Click(object sender, EventArgs e)
        {
            diceGame.SecondPlayer.Bet = Convert.ToInt32(txtSecondPlayerBet.Text);

            if (diceGame.SecondPlayer.Money < diceGame.SecondPlayer.Bet)
            {
                MessageBox.Show("Paranızdan fazla bahiste bulunamazsınız");
            }
        }
    }
}
