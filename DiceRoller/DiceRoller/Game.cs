using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    public class Game
    {
        public Player FirstPlayer { get; set; }
        public Player SecondPlayer { get; set; }

        public void FirstPlayerRollDice()
        {
            FirstPlayer.Play();
        }
        public void SecondPlayerRollDice()
        {
            SecondPlayer.Play();
        }

        public Player GameResult()
        {
            int gameBet;
            if(FirstPlayer.Bet < SecondPlayer.Bet)
            {
                gameBet = SecondPlayer.Bet;
            }
            else
            {
                gameBet = FirstPlayer.Bet;
            }

            if (FirstPlayer.PlayersDice.Value > SecondPlayer.PlayersDice.Value)
            {
                FirstPlayer.Money = FirstPlayer.Money + gameBet;
                SecondPlayer.Money = SecondPlayer.Money - gameBet;
                return FirstPlayer;
            }
            else if (FirstPlayer.PlayersDice.Value < SecondPlayer.PlayersDice.Value)
            {
                FirstPlayer.Money = FirstPlayer.Money - gameBet;
                SecondPlayer.Money = SecondPlayer.Money + gameBet;
                return SecondPlayer;
            }
            else
            {
                return null;
            }

        }
    }
}
