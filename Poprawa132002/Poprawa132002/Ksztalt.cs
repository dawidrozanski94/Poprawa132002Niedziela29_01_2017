using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poprawa132002
{
    abstract class Ksztalt
    {
        protected double a=0;
        protected double b=0;
        protected double c=0;
        protected double d=0;

        public Ksztalt()
        {

        }

        abstract public double ObliczPole();

        abstract public double ObliczObwod();

        public override string ToString()
        {
            return "Obwod:" + this.ObliczObwod() + ", Pole: " + this.ObliczObwod();
        }
        

        
    }
}
