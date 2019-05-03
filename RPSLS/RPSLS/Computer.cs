using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {



        //member variables (HAS A)






        //Constructor (BUILDS OBJECT)






        //member methods(CAN DO)


        public override string ChooseWeapon()
        {
            int WeaponChoice = RandomNumber(1, 5);
            switch (WeaponChoice)
            {
                case 1:
                    weapon = "Rock";
                    Console.WriteLine("The Computer Chose Rock. Please Press Enter");
                    Console.ReadLine();
                    break;
                case 2:
                    weapon = "Paper";
                    Console.WriteLine("The Computer Chose Paper. Please Press Enter");
                    Console.ReadLine();
                    break;
                case 3:
                    weapon = "Scissors";
                    Console.WriteLine("The Computer Chose Scissors. Please Press Enter");
                    Console.ReadLine();
                    break;
                case 4:
                    weapon = "Lizard";
                    Console.WriteLine("The Computer Chose Lizard. Please Press Enter");
                    Console.ReadLine();
                    break;
                case 5:
                    weapon = "Spock";
                    Console.WriteLine("The Computer Chose Spock. Please Press Enter");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Something Went Wrong.....");
                    break;
            }
            return weapon;
        }

        public int RandomNumber(int min, int max)
        {
            Random rando = new Random();
            return rando.Next(1, 5);
        }


    }
}
