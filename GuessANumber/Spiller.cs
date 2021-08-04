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
        
        public static void GetName()
        {
            Name = Console.ReadLine();
        }
        public static void Guess()
        {
            int.TryParse(Console.ReadLine(), out PlayerGuess);
            
        }        
    }
}
