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
            Spiller.Name = GUI.GetStringFromUser("Skriv dit navn");
            Dice.ChooseDiceSize(GUI.GetIntFromUser("Hvor mange sider skal terningen have?"));
            Game();
        }

        public static void Game()
        {
            GuessTheNumber = Dice.RollDice();
            while (GuessedRight == false)
            {
                Spiller.Guess(GUI.GetIntFromUser("Lav et gæt: "));
                GuessedRight = GUI.HighLowOrWin(Spiller.PlayerGuess, GuessTheNumber, Spiller.Name, Spiller.NumberOfGuesses);
            }
            Restart();
        }
        public static void Restart()
        {
            if (GUI.Restart())
            {
                Spiller.NumberOfGuesses = 0;
                Dice.ChooseDiceSize(GUI.GetIntFromUser("Hvor mange sider skal terningen have?"));
                GuessedRight = false;
                Game();
                
            }
            
        }
    }
}
