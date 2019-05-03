using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {


        //member variables (HAS A)
        
        


        //Constructor (BUILDS OBJECT)

        public Human()
        {
            
         
        }


        //member methods(CAN DO)
           
        

        

        public override string ChooseWeapon()
        {
            Console.WriteLine("Please choose your weapon. 'Rock', 'Paper', 'Scissors', 'Lizard', or 'Spock'.");
            string WeaponChoice = Console.ReadLine();
            switch (WeaponChoice)
            {
                case "Rock":
                    weapon = "Rock";
                    Console.WriteLine("You Chose Rock. Please Press Enter");
                    Console.ReadLine();
                    break;
                case "Paper":
                    weapon = "Paper";
                    Console.WriteLine("You Chose Paper. Please Press Enter");
                    Console.ReadLine();
                    break;
                case "Scissors":
                    weapon = "Scissors";
                    Console.WriteLine("You Chose Scissors. Please Press Enter");
                    Console.ReadLine();
                    break;
                case "Lizard":
                    weapon = "Lizard";
                    Console.WriteLine("You Chose Lizard. Please Press Enter");
                    Console.ReadLine();
                    break;
                case "Spock":
                    weapon = "Spock";
                    Console.WriteLine("You Chose Spock. Please Press Enter");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("That wasnt an option, please try again");         
                    ChooseWeapon();
                    break;
            } return weapon;
        }





    }
}
