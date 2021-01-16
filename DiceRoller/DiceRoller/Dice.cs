using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    public class Dice
    {
        public int Value { get; set; }

        public void Roll()
        {
            Random random = new Random();
            Value = random.Next(1, 7);
        }
    }
}
