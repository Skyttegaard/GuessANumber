using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessANumber
{
    class Dice
    {
        public static int Sides = 6;
        public static int RollDice()
        {
            Random rnd = new Random();
            return rnd.Next(Sides) + 1;
        }
        public static void ChooseDiceSize(int input)
        {
            Sides = input;
        }
    }
}
