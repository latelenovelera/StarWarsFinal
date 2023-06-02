using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsFinal
{
    //Inherits from Round 
    public class Round2: Round
    {
        //Round2 constructors and Round constructors
        public Round2(Players C1, Players C2) : base(C1, C2)
        {
            Compete1 = C1;
            Compete2 = C2;
        }

        //Second round of players to compete is it determines both players height
        //to see who has the tallest whoever that player is, is the winner.
        public override Players Compete()
        {
            if (Convert.ToInt32(Compete1.height) > Convert.ToInt32(Compete2.height))
            {
                return Compete1;
            }
            else
            {
                return Compete2;
            }
        }

    }
}
