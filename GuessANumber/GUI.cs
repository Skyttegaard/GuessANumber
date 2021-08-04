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
            Console.Write("Lav et gæt: ");
            Spiller.Guess();
        }
        public static void GetName()
        {
            Console.WriteLine("Skriv dit navn");
            Spiller.GetName();
        }
        public static void GetDiceSize()
        {
            Console.WriteLine("Hvor mange sider skal terningen have?");
            Dice.ChooseDiceSize();
        }
        public static bool Restart()
        {
            Console.WriteLine("Tast y for at prøve igen.");
            if (Console.ReadLine() == "y")
            {
                Console.Clear();
                return true;
            }
            return false;
        }
    }
}
