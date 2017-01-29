using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poprawa132002
{
    class Trojkat : Ksztalt
    {
        public Trojkat()
        {

        }

        public Trojkat(double a, double b, double c)
        {
            base.a = a;
            base.b = b;
            base.c = c;
        }

        override public double ObliczObwod()
        {
            return base.a + base.b + base.c;
        }

        override public double ObliczPole()
        {
            return Math.Sqrt((this.ObliczObwod() / 2) * ((this.ObliczObwod() / 2) - base.a) * ((this.ObliczObwod() / 2) - b) * ((this.ObliczObwod() / 2)-c));
        }
    }
}
