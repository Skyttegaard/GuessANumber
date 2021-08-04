using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessANumber
{
    class GUI
    {
        public static bool HighLowOrWin(int input, int number, string name, int guesses)
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
                Console.WriteLine($"Tillykke {name}, det er rigtigt!\nDu brugte {guesses} forsøg!");
                return true;
            }
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
            Console.WriteLine(message);
            int.TryParse(Console.ReadLine(), out int input);
            return input;
        }

        public static string GetStringFromUser(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
    }
}
