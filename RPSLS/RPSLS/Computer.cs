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


        public override string ChooseWep()
        {
            Console.WriteLine("");
            int WepChoice = RandomNumber(1, 5);
            switch (WepChoice)
            {
                case 1:
                    wep = "Rock";
                    Console.WriteLine("The Computer Chose Rock. Please Press Enter");
                    Console.ReadLine();
                    break;
                case 2:
                    wep = "Paper";
                    Console.WriteLine("The Computer Chose Paper. Please Press Enter");
                    Console.ReadLine();
                    break;
                case 3:
                    wep = "Scissors";
                    Console.WriteLine("The Computer Chose Scissors. Please Press Enter");
                    Console.ReadLine();
                    break;
                case 4:
                    wep = "Lizard";
                    Console.WriteLine("The Computer Chose Lizard. Please Press Enter");
                    Console.ReadLine();
                    break;
                case 5:
                    wep = "Spock";
                    Console.WriteLine("The Computer Chose Spock. Please Press Enter");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Something Went Wrong.....");
                    break;
            }
            return wep;
        }

        public int RandomNumber(int min, int max)
        {
            Random rando = new Random();
            return rando.Next(1, 5);
        }


    }
}
