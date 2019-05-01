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
        int p1Counter;
        int p2Counter;
        int cCounter;
        string gameCheck;
        List<string> options = new List<string>();
        string battleResult;



        //Constructor (BUILDS OBJECT)

        public Battlefield()
        {
            player1 = new Player1();
            player2 = new Player2();
            
            p1Counter = 0;
            p2Counter = 0;
            cCounter = 0;
            gameCheck = null;
            options.Add("Remember, Your Choices Are As Listed Below");
            options.Add("Rock");
            options.Add("Paper");
            options.Add("Scissors");
            options.Add("Lizard");
            options.Add("Spock");
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
            }else if (battleResult == "Player 2 wins!")
            {
                p2Counter++;
                return p2Counter;
            }else if (battleResult == "Computer wins!")
            {
                cCounter++;
                return cCounter;
            } else
            {
                return 0;
            }
            
        }


        public string CheckCounter()
        {
            if (p1Counter == 3)
            {
                return gameCheck = "Player 1 Wins The Game!";
            } else if (p2Counter == 3)
            {
                return gameCheck = "Player 2 Wins The Game!";
            } else if (cCounter == 3)
            {
                return gameCheck = "Computer Wins The Game!";
            } else
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

        public void tellOptions()
        {
            foreach (string option in options)
            {
                Console.WriteLine(option);
            }
        }

        public void MasterMeth()
        {
            Console.Clear();
            tellOptions();
            Console.ReadLine();
            Console.Clear();
            player1.ChooseWep();
            Console.Clear();
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
