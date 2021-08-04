using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessANumber
{
    class Spiller
    {
        public static int PlayerGuess = 0;
        public static string Name;
        public static int NumberOfGuesses = 0;
        
        public static void GetName(string input)
        {
            Name = input;
        }
        public static void Guess(int input)
        {
            PlayerGuess = input;
            NumberOfGuesses++;
        }        
    }
}
