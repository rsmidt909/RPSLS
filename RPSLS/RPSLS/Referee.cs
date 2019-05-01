using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Referee
    {


        //member variables (HAS A)
        List<string> options = new List<string>();





        //Constructor (BUILDS OBJECT)
        public Referee()
        {
            options.Add("Remember, Your Choices Are As Listed Below");
            options.Add("Rock");
            options.Add("Paper");
            options.Add("Scissors");
            options.Add("Lizard");
            options.Add("Spock");
            options.Add("Press Enter...");


        }





        //member methods(CAN DO)

        public void tellOptions()
        {
            foreach (string option in options)
            {
                Console.WriteLine(option);
            }
        }

        /*public string GameType()
        {
            Console.WriteLine("What Kind of Game Would You Like To Play? PvP or PvC?");
               return gameMode = Console.ReadLine();

        };*/

    }
}
