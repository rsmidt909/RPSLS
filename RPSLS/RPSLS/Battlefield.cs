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
        string gameCheck;
        string battleResult;
        

        //Constructor (BUILDS OBJECT)

        public Battlefield()
        {
            player1 = new Human();
            player2 = null;
            referee = new Referee();           
            gameCheck = null;
            battleResult = null;
            
            
        }



        //member methods(CAN DO)
        public string DoBattle()
        { if (player1.weapon == "Rock" & player2.weapon == "Rock")
            {               
               return battleResult = "Tie!";

            } else if (player1.weapon == "Rock" & player2.weapon == "Paper")
            {
                
                return battleResult = "Player 2 wins!";
                    
            }else if (player1.weapon == "Rock" & player2.weapon == "Scissors")
            {
                return battleResult = "Player 1 wins!";
                    
            } else if (player1.weapon == "Rock" & player2.weapon == "Lizard")
            {
                return battleResult = "Player 1 wins!";
                    
            } else if (player1.weapon == "Rock" & player2.weapon == "Spock")
            {
                return battleResult = "Player 2 wins!";
                    
            }
            //-------------------------------------------------------------
            else if (player1.weapon == "Paper" & player2.weapon == "Paper")
            {
                return battleResult = "Tie!";
            }
            else if (player1.weapon == "Paper" & player2.weapon == "Rock")
            {
                return battleResult = "Player 1 wins!";
                    
            }
            else if (player1.weapon == "Paper" & player2.weapon == "Scissors")
            {
                return battleResult = "Player 2 wins!";

            }
            else if (player1.weapon == "Paper" & player2.weapon == "Lizard")
            {
                return "Player 2 wins!";
                    
            }
            else if (player1.weapon == "Paper" & player2.weapon == "Spock")
            {
                return battleResult = "Player 1 wins!";
                    
            }
            //-----------------------------------------------------------------
            else if (player1.weapon == "Scissors" & player2.weapon == "Scissors")
            {
                return battleResult = "Tie!";
            }
            else if (player1.weapon == "Scissors" & player2.weapon == "Rock")
            {
                return battleResult = "Player 2 wins!";


            }
            else if (player1.weapon == "Scissors" & player2.weapon == "Paper")
            {
                return battleResult = "Player 1 wins!";

            }
            else if (player1.weapon == "Scissors" & player2.weapon == "Lizard")
            {
                return battleResult = "Player 1 wins!";

            }
            else if (player1.weapon == "Scissors" & player2.weapon == "Spock")
            {
                return battleResult = "Player 2 wins!";


            }
            //-----------------------------------------------------------------------------
            else if (player1.weapon == "Lizard" & player2.weapon == "Lizard")
            {
                return battleResult = "Tie!";

            }
            else if (player1.weapon == "Lizard" & player2.weapon == "Rock")
            {
                return battleResult = "Player 2 wins!";

            }
            else if (player1.weapon == "Lizard" & player2.weapon == "Paper")
            {
                return battleResult = "Player 1 wins!";

            }
            else if (player1.weapon == "Lizard" & player2.weapon == "Scissors")
            {
                return battleResult = "Player 2 wins!";

            }
            else if (player1.weapon == "Lizard" & player2.weapon == "Spock")
            {
                return battleResult = "Player 1 wins!";


            }
            //-------------------------------------------------------------------
            else if (player1.weapon == "Spock" & player2.weapon == "Spock")
            {
                return battleResult = "Tie!";

            }
            else if (player1.weapon == "Spock" & player2.weapon == "Rock")
            {
                return battleResult = "Player 1 wins!";

            }
            else if (player1.weapon == "Spock" & player2.weapon == "Paper")
            {
                return battleResult = "Player 2 wins!";

            }
            else if (player1.weapon == "Spock" & player2.weapon == "Scissors")
            {
                return battleResult = "Player 1 wins!";

            }
            else if (player1.weapon == "Spock" & player2.weapon == "Lizard")
            {
                return battleResult = "Player 2 wins!";


            } else
            {
                return battleResult = "Something went wrong....";
            };
        }   

        public void AddCounter()
        {
            if (battleResult == "Player 1 wins!")
            {
                player1.pCounter++;
                
            }
            else if (battleResult == "Player 2 wins!")
            {
                player2.pCounter++;
               
            } 
            
        }


        public string CheckCounter()
        {
            if (player1.pCounter == 2)
            {
                return gameCheck = "Player 1 Wins The Game!";
            }
             else if (player2.pCounter == 2)
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
            player1.ChooseWeapon();
            Console.Clear();
            Console.WriteLine("Player 2 Turn. Press Enter");
            Console.ReadLine();
            player2.ChooseWeapon();
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
