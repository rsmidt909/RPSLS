using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {


        //member variables (HAS A)

        public string wep;




        //Constructor (BUILDS OBJECT)


        public Player()
        {

            wep = null;

        }




        //member methods(CAN DO)

        public abstract string ChooseWep();


    }
}
