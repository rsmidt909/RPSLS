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
        string player1;
        string player2;
        string computer;





        //Constructor (BUILDS OBJECT)

        public Battlefield()
        {
            player1 = new Player1();
            player2 = new Player2();
        }



        //member methods(CAN DO)
        public string DoBattle()
        { if (player1.wep == "Rock" && player2.wep == "Rock") {
            }
        }






    }
}
