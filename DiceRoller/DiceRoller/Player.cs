using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
   public  class Player
    {
        public string Name { get; set; }
        public int Money { get; set; }
        public int Bet { get; set; }
        public Dice PlayersDice { get; set; }

        public void Play()
        {
            PlayersDice.Roll();
        }

        public Player()
        {

        }

        public Player(string name)
        {
            Name = name;
        }

        public Player(int bet)
        {
            Bet = bet;
        }

        public Player(string name, int bet)
        {
            Name = name;
            Bet = bet;
        }
    }
}
