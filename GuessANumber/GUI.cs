using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessANumber
{
    class GUI
    {
        public static bool HighLowOrWin(int input, int number)
        {
            if(input > number)
            {
                Console.WriteLine("Det er for højt");
                return false;
            }
            else if(input < number)
            {
                Console.WriteLine("Det er for lavt");
                return false;
            }
            else
            {
                Console.WriteLine($"Tillykke {Spiller.Name}, det er rigtigt!\nDu brugte {Spiller.NumberOfGuesses} forsøg!");
                return true;
            }
        }
        public static void MakeAGuess()
        {
            Spiller.Guess(GetIntFromUser("Lav et gæt: "));
        }
        public static void GetName()
        {
            Spiller.GetName(GetStringFromUser("Skriv dit navn")) ;
        }
        public static void GetDiceSize()
        {
            Dice.ChooseDiceSize(GetIntFromUser("Hvor mange sider skal terningen have ?"));
        }
        public static bool Restart()
        {
            if (GetStringFromUser("Tast y for at prøve igen.") == "y")
            {
                Console.Clear();
                return true;
            }
            return false;
        }
        public static int GetIntFromUser(string message)
        {
            Console.Write(message);
            int.TryParse(Console.ReadLine(), out int input);
            return input;
        }

        public static string GetStringFromUser(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
    }
}
