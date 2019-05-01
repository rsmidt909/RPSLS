using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Player2
    {
        //member variables (HAS A)
        public bool turn;
        public string wep;


        //Constructor (BUILDS OBJECT)

        public Player2()
        {
            turn = false;
            wep = null;
        }


        //member methods(CAN DO)

        public bool IsTurn()
        {
            turn = true;
            return turn;
        }

        public bool IsNotTurn()
        {
            turn = false;
            return turn;
        }

        public string ChooseWep()
        {
            Console.WriteLine("Player 2 Please choose your weapon. 'Rock', 'Paper', 'Scissors', 'Lizard', or 'Spock'.");
            string WepChoice = Console.ReadLine();
          switch (WepChoice)
            {
                case "Rock":
                    wep = "Rock";
                    Console.WriteLine("You Chose Rock. Please Press Enter");
                    Console.ReadLine();
                    break;
                case "Paper":
                    wep = "Paper";
                    Console.WriteLine("You Chose Paper. Please Press Enter");
                    Console.ReadLine();
                    break;
                case "Scissors":
                    wep = "Scissors";
                    Console.WriteLine("You Chose Scissors. Please Press Enter");
                    Console.ReadLine();
                    break;
                case "Lizard":
                    wep = "Lizard";
                    Console.WriteLine("You Chose Lizard. Please Press Enter");
                    Console.ReadLine();
                    break;
                case "Spock":
                    wep = "Spock";
                    Console.WriteLine("You Chose Spock. Please Press Enter");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("That wasnt an option, please try again");
                    ChooseWep();
                    break;
            }
            return wep;
        }






    }
}
