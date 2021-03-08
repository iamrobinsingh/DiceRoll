using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRolls
{
    public static class Dice
    {
        public static int RollOutcome()
        {
            Random _random = new Random();
            return _random.Next(1, 7);
        }
    }
}
