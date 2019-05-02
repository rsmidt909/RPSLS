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
        Player player1;
        Player player2;
        public Referee referee;
        int p1Counter;
        int p2Counter;
        string gameCheck;
        string battleResult;
        

        //Constructor (BUILDS OBJECT)

        public Battlefield()
        {
            player1 = new Human();
            player2 = null;
            referee = new Referee();
            p1Counter = 0;
            p2Counter = 0;            
            gameCheck = null;
            battleResult = null;
            
            
        }



        //member methods(CAN DO)
        public string DoBattle()
        { if (player1.wep == "Rock" & player2.wep == "Rock")
            {               
               return battleResult = "Tie!";

            } else if (player1.wep == "Rock" & player2.wep == "Paper")
            {
                
                return battleResult = "Player 2 wins!";
                    
            }else if (player1.wep == "rock" & player2.wep == "Scissors")
            {
                return battleResult = "Player 1 wins!";
                    
            } else if (player1.wep == "Rock" & player2.wep == "Lizard")
            {
                return battleResult = "Player 1 wins!";
                    
            } else if (player1.wep == "Rock" & player2.wep == "Spock")
            {
                return battleResult = "Player 2 wins!";
                    
            }
            //-------------------------------------------------------------
            else if (player1.wep == "Paper" & player2.wep == "Paper")
            {
                return battleResult = "Tie!";
            }
            else if (player1.wep == "Paper" & player2.wep == "Rock")
            {
                return battleResult = "Player 1 wins!";
                    
            }
            else if (player1.wep == "Paper" & player2.wep == "Scissors")
            {
                return battleResult = "Player 2 wins!";

            }
            else if (player1.wep == "Paper" & player2.wep == "Lizard")
            {
                return "Player 2 wins!";
                    
            }
            else if (player1.wep == "Paper" & player2.wep == "Spock")
            {
                return battleResult = "Player 1 wins!";
                    
            }
            //-----------------------------------------------------------------
            else if (player1.wep == "Scissors" & player2.wep == "Scissors")
            {
                return battleResult = "Tie!";
            }
            else if (player1.wep == "Scissors" & player2.wep == "Rock")
            {
                return battleResult = "Player 2 wins!";


            }
            else if (player1.wep == "Scissors" & player2.wep == "Paper")
            {
                return battleResult = "Player 1 wins!";

            }
            else if (player1.wep == "Scissors" & player2.wep == "Lizard")
            {
                return battleResult = "Player 1 wins!";

            }
            else if (player1.wep == "Scissors" & player2.wep == "Spock")
            {
                return battleResult = "Player 2 wins!";


            }
            //-----------------------------------------------------------------------------
            else if (player1.wep == "Lizard" & player2.wep == "Lizard")
            {
                return battleResult = "Tie!";

            }
            else if (player1.wep == "Lizard" & player2.wep == "Rock")
            {
                return battleResult = "Player 2 wins!";

            }
            else if (player1.wep == "Lizard" & player2.wep == "Paper")
            {
                return battleResult = "Player 1 wins!";

            }
            else if (player1.wep == "Lizard" & player2.wep == "Scissors")
            {
                return battleResult = "Player 2 wins!";

            }
            else if (player1.wep == "Lizard" & player2.wep == "Spock")
            {
                return battleResult = "Player 1 wins!";


            }
            //-------------------------------------------------------------------
            else if (player1.wep == "Spock" & player2.wep == "Spock")
            {
                return battleResult = "Tie!";

            }
            else if (player1.wep == "Spock" & player2.wep == "Rock")
            {
                return battleResult = "Player 1 wins!";

            }
            else if (player1.wep == "Spock" & player2.wep == "Paper")
            {
                return battleResult = "Player 2 wins!";

            }
            else if (player1.wep == "Spock" & player2.wep == "Scissors")
            {
                return battleResult = "Player 1 wins!";

            }
            else if (player1.wep == "Spock" & player2.wep == "Lizard")
            {
                return battleResult = "Player 2 wins!";


            } else
            {
                return battleResult = "Something went wrong....";
            };
        }   

        public int AddCounter()
        {
            if (battleResult == "Player 1 wins!")
            {
                p1Counter++;
                return p1Counter;
            }
            else if (battleResult == "Player 2 wins!")
            {
                p2Counter++;
                return p2Counter;
            } 
            else
            {
                return 0;
            }
            
        }


        public string CheckCounter()
        {
            if (p1Counter == 2)
            {
                return gameCheck = "Player 1 Wins The Game!";
            }
             else if (p2Counter == 2)
            {
                return gameCheck = "Player 2 Wins The Game!";
            } 
             else
            {
                return gameCheck = "Next Round!";
            }
        }

        public void GameCheck()
        {
            if(gameCheck == "Next Round!")
            {
                MasterMeth();
            }
        }

        public void Mode()
        {
            if (referee.gameMode == "PvP")
            {
                player2 = new Human();
            }
            else if (referee.gameMode == "PvC")
            {
                player2 = new Computer();
            }
        }

        public void MasterMeth()
        {

            Console.WriteLine("Player 1 Turn. Press Enter");
            Console.ReadLine();
            player1.ChooseWep();
            Console.Clear();
            Console.WriteLine("Player 2 Turn. Press Enter");
            Console.ReadLine();
            player2.ChooseWep();
            Console.Clear();
            DoBattle();
            AddCounter();
            Console.WriteLine(battleResult);
            CheckCounter();
            Console.WriteLine(gameCheck);
            Console.ReadLine();
            GameCheck();
       
            
        }

       

        
        



    }
}
