using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarWarsFinal
{
    //Inherits from Round
    public class Round1 : Round
    {
        //Round1 constructors and Round constructors
        public Round1(Players C1, Players C2) : base(C1, C2)
        {
            Compete1 = C1;
            Compete2 = C2;
        }

        //First round of players to compete is it determines both players mass (weight)
        //to see who has the highest mass whoever that player is, is the winner.
        public override Players Compete()
        {
            if(Convert.ToInt32(Compete1.mass) > Convert.ToInt32(Compete2.mass))
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