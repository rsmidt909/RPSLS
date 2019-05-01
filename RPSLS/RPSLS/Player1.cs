using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Player1
    {


        //member variables (HAS A)
        public bool turn;
        public string wep;


        //Constructor (BUILDS OBJECT)

        public Player1()
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
        { Console.WriteLine("Please choose your weapon. /'Rock/', /'Paper/', /'Scissors/', /'Lizard/', or /'Spock/'.");
            string WepChoice = Console.ReadLine();
            switch (WepChoice)
            {
                case "Rock":
                    wep = "Rock";
                    Console.WriteLine("You Chose Rock");
                    Console.ReadLine();
                    break;
                case "Paper":
                    wep = "Paper";
                    Console.WriteLine("You Chose Rock");
                    Console.ReadLine();
                    break;
                case "Scissors":
                    wep = "Scissors";
                    Console.WriteLine("You Chose Scissors");
                    Console.ReadLine();
                    break;
                case "Lizard":
                    wep = "Lizard";
                    Console.WriteLine("You Chose Lizard");
                    Console.ReadLine();
                    break;
                case "Spock":
                    wep = "Spock";
                    Console.WriteLine("You Chose Spock");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("That wasnt an option, please try again");
                    Console.ReadLine();
                    ChooseWep();
                    break;
            } return wep;
        }





    }
}
