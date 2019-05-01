using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class CCounter
    {



        //member variables (HAS A)

        int value;


        //Constructor (BUILDS OBJECT)

        public CCounter()
        {
            value = 0;
        }


        //member methods(CAN DO)

        public int AddCCounter()
        {
            value++;
            return value;
        }


    }
}
