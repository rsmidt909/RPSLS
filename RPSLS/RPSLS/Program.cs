using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Battlefield RPSLS = new Battlefield();
            RPSLS.referee.GameType();
            RPSLS.Mode();
            Console.Clear();
            RPSLS.referee.tellOptions();
            Console.ReadLine();
            Console.Clear();
            RPSLS.MasterMeth();

        }
    }
}
