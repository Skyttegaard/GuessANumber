using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessANumber
{
    class Spillet
    {
        public static int GuessTheNumber = 0;
        public static bool GuessedRight;
        public static void StartGame()
        {
            GUI.GetName();
            GUI.GetDiceSize();
            Game();
        }

        public static void Game()
        {
            GuessTheNumber = Dice.RollDice();
            while (GuessedRight == false)
            {
                GUI.MakeAGuess();
                GuessedRight = GUI.HighLowOrWin(Spiller.PlayerGuess, GuessTheNumber);
            }
            Restart();
        }
        public static void Restart()
        {
            if (GUI.Restart())
            {
                Spiller.NumberOfGuesses = 0;
                GUI.GetDiceSize();
                GuessedRight = false;
                Game();
                
            }
            
        }
    }
}
