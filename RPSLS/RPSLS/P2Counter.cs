using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class P2Counter
    {



        //member variables (HAS A)
        int value;




        //Constructor (BUILDS OBJECT)

        public P2Counter()
        {
            value = 0;
        }



        //member methods(CAN DO)

        public int AddP2Counter()
        {
            value++;
            return value;
        }


    }
}
