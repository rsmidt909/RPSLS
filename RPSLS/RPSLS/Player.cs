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

        public string weapon;
        public int pCounter;



        //Constructor (BUILDS OBJECT)


        public Player()
        {
            pCounter = 0;
            weapon = null;

        }




        //member methods(CAN DO)

        public abstract string ChooseWeapon();


    }
}
