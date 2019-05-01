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
        Player1 player1;
        Player2 player2;
        string roundWinner;



        //Constructor (BUILDS OBJECT)

        public Battlefield()
        {
            player1 = new Player1();
            player2 = new Player2();
            roundWinner = DoBattle();
        }



        //member methods(CAN DO)
        public string DoBattle()
        { if (player1.wep == "Rock" && player2.wep == "Rock")
            {               
               return "Tie!";

            } else if (player1.wep == "rock" && player2.wep == "Paper")
            {
                return "Player 2 wins!";
                    
            }else if (player1.wep == "rock" && player2.wep == "Scissors")
            {
                return "Player 1 wins!";
                    
            } else if (player1.wep == "Rock" && player2.wep == "Lizard")
            {
                return "Player 1 wins!";
                    
            } else if (player1.wep == "Rock" && player2.wep == "Spock")
            {
                return "Player2  wins!";
                    
            }
            //-------------------------------------------------------------
            else if (player1.wep == "Paper" && player2.wep == "Paper")
            {
                return "Tie!";
            }
            else if (player1.wep == "Paper" && player2.wep == "Rock")
            {
                return "Player 1 wins!";
                    
            }
            else if (player1.wep == "Paper" && player2.wep == "Scissors")
            {
                return "Player 2 wins!";

            }
            else if (player1.wep == "Paper" && player2.wep == "Lizard")
            {
                return "Player 2 wins!";
                    
            }
            else if (player1.wep == "Paper" && player2.wep == "Spock")
            {
                return "Player 1  wins!";
                    
            }
            //-----------------------------------------------------------------
            else if (player1.wep == "Scissors" && player2.wep == "Scissors")
            {
                return "Tie!";
            }
            else if (player1.wep == "Sissors" && player2.wep == "Rock")
            {
                return "Player 2 wins!";


            }
            else if (player1.wep == "Scissors" && player2.wep == "Paper")
            {
                return "Player 1 wins!";

            }
            else if (player1.wep == "Scissors" && player2.wep == "Lizard")
            {
                return "Player 1 wins!";

            }
            else if (player1.wep == "Scissors" && player2.wep == "Spock")
            {
                return "Player 2  wins!";


            }
            //-----------------------------------------------------------------------------
            else if (player1.wep == "Lizard" && player2.wep == "Lizard")
            {
                return "Tie!";

            }
            else if (player1.wep == "Lizard" && player2.wep == "Rock")
            {
                return "Player 2 wins!";

            }
            else if (player1.wep == "Lizard" && player2.wep == "Paper")
            {
                return "Player 1 wins!";

            }
            else if (player1.wep == "Lizard" && player2.wep == "Scissors")
            {
                return "Player 2 wins!";

            }
            else if (player1.wep == "Lizard" && player2.wep == "Spock")
            {
                return "Player 1  wins!";


            }
            //-------------------------------------------------------------------
            else if (player1.wep == "Spock" && player2.wep == "Spock")
            {
                return "Tie!";

            }
            else if (player1.wep == "Spock" && player2.wep == "Rock")
            {
                return "Player 1 wins!";

            }
            else if (player1.wep == "Spock" && player2.wep == "Paper")
            {
                return "Player 2 wins!";

            }
            else if (player1.wep == "Spock" && player2.wep == "Scissors")
            {
                return "Player 1 wins!";

            }
            else if (player1.wep == "Spock" && player2.wep == "Lizard")
            {
                return "Player 2  wins!";


            } else
            {
                return "Something went wrong....";
            };
        }   







    }
}
