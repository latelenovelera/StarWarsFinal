using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StarWarsFinal
{
    public class Round
    {
        //Round attributes
        private Players compete1;
        private Players compete2;
        private Players winner;

        //Getters and setters for the private attribute compete1
        public Players Compete1   // property
        {
            get { return compete1; }   // get method
            set { compete1 = value; }  // set method
        }

        //Getters and setters for the private attribute compete2
        public Players Compete2   
        {
            get { return compete2; }   
            set { compete2 = value; }  
        }

        //Constructors of Compete1 and Compete2
        public Round(Players C1, Players C2)
        {
            Compete1 = C1;
            Compete2 = C2;
        }

        //If first competitor and second competitor equal each other 
        //then the first competitor will win.
        //If they're not the same then takes first competitor which acts as one and second competitor
        //as two to display the winner. 
        public virtual Players Winner()
        {
            if (Compete1.name == Compete2.name)
            {
                return Compete1;
            }
            else
            {

                Random rnd = new Random();
                int win = rnd.Next(1, 2);
                if(win == 1)
                {
                    return Compete1;
                }
                else
                {
                    return Compete2;
                }
            }

        }


        //Virtual function used to determine which player one or two wins overall
        public virtual Players Compete()
        {
           return new Players();
        }

        
    }
}
