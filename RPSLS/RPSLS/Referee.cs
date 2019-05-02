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
        string gameMode;




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
            gameMode = null;

        }





        //member methods(CAN DO)

        public void tellOptions()
        {
            foreach (string option in options)
            {
                Console.WriteLine(option);
            }
        }

        public string GameType()
        {
            Console.WriteLine("What Kind of Game Would You Like To Play? PvP or PvC?");
               string gameMode = Console.ReadLine();
                switch (gameMode)
            {   case "PvP":
                    gameMode = "PvP";
                    Console.WriteLine("You Chose PvP. Please Press Enter");
                    Console.ReadLine();
                    break;
                case "PvC":
                    gameMode = "PvC";
                    Console.WriteLine("You Chose PvC. Please Press Enter");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Please Choose A Valid Game Mode.");
                    GameType();
                    break;

            }return gameMode;
        }

    }
}
