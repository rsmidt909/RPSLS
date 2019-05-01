using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Battlefield
    {



        //member variables (HAS A)
        





        //Constructor (BUILDS OBJECT)

        public Battlefield()
        {
            player1 = new Player1();
            player2 = new Player2();
        }



        //member methods(CAN DO)
        public string DoBattle()
        { if (player1.wep == "Rock" && player2.wep == "Rock")
            {
                Console.WriteLine("Tie!");
            } else if (player1.wep == "rock" && player2.wep == "Paper")
            {
                Console.WriteLine("Player 2 wins!");
                    
            }else if (player1.wep == "rock" && player2.wep == "Scissors")
            {
                Console.WriteLine("Player 1 wins!");
                    
            } else if (player1.wep == "Rock" && player2.wep == "Lizard")
            {
                Console.WriteLine("Player 1 wins!");
                    
            } else if (player1.wep == "Rock" && player2.wep == "Spock")
            {
                Console.WriteLine("Player2  wins!");
                    
            }
            //-------------------------------------------------------------
            else if (player1.wep == "Paper" && player2.wep == "Paper")
            {
                Console.WriteLine("Tie!");
            }
            else if (player1.wep == "Paper" && player2.wep == "Rock")
            {
                Console.WriteLine("Player 1 wins!");
                    
            }
            else if (player1.wep == "Paper" && player2.wep == "Scissors")
            {
                Console.WriteLine("Player 2 wins!");

            }
            else if (player1.wep == "Paper" && player2.wep == "Lizard")
            {
                Console.WriteLine("Player 2 wins!");
                    
            }
            else if (player1.wep == "Paper" && player2.wep == "Spock")
            {
                Console.WriteLine("Player 1  wins!");
                    
            }
            //-----------------------------------------------------------------
            else if (player1.wep == "Scissors" && player2.wep == "Scissors")
            {
                Console.WriteLine("Tie!");
            }
            else if (player1.wep == "Sissors" && player2.wep == "Rock")
            {
                Console.WriteLine("Player 2 wins!");


            }
            else if (player1.wep == "Scissors" && player2.wep == "Paper")
            {
                Console.WriteLine("Player 1 wins!");

            }
            else if (player1.wep == "Scissors" && player2.wep == "Lizard")
            {
                Console.WriteLine("Player 1 wins!");

            }
            else if (player1.wep == "Scissors" && player2.wep == "Spock")
            {
                Console.WriteLine("Player 2  wins!");


            }
            //-----------------------------------------------------------------------------
            else if (player1.wep == "Lizard" && player2.wep == "Lizard")
            {
                Console.WriteLine("Tie!");

            }
            else if (player1.wep == "Lizard" && player2.wep == "Rock")
            {
                Console.WriteLine("Player 2 wins!");

            }
            else if (player1.wep == "Lizard" && player2.wep == "Paper")
            {
                Console.WriteLine("Player 1 wins!");

            }
            else if (player1.wep == "Lizard" && player2.wep == "Scissors")
            {
                Console.WriteLine("Player 2 wins!");

            }
            else if (player1.wep == "Lizard" && player2.wep == "Spock")
            {
                Console.WriteLine("Player 1  wins!");


            }
            //-------------------------------------------------------------------
            else if (player1.wep == "Spock" && player2.wep == "Spock")
            {
                Console.WriteLine("Tie!");

            }
            else if (player1.wep == "Spock" && player2.wep == "Rock")
            {
                Console.WriteLine("Player 1 wins!");

            }
            else if (player1.wep == "Spock" && player2.wep == "Paper")
            {
                Console.WriteLine("Player 2 wins!");

            }
            else if (player1.wep == "Spock" && player2.wep == "Scissors")
            {
                Console.WriteLine("Player 1 wins!");

            }
            else if (player1.wep == "Spock" && player2.wep == "Lizard")
            {
                Console.WriteLine("Player 2  wins!");


            } else
            {
                Console.WriteLine("Something went wrong....");
            };
        }   







    }
}
