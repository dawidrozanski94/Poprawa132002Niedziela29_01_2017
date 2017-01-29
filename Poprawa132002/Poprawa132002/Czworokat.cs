using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poprawa132002
{
    abstract class Czworokat : Ksztalt
    {
        public Czworokat()
        {

        }

        public Czworokat(double a, double b, double c, double d)
        {
            base.a = a;
            base.b = b;
            base.c = c;
            base.d = d;
        }

        override public double ObliczObwod()
        {
            return base.a + base.b + base.c + base.d;
        }

        override public double ObliczPole()
        {
           return Math.Sqrt((ObliczObwod() / 2 - base.a) * (ObliczObwod() / 2 - base.b) * (ObliczObwod() / 2 - base.c) * (ObliczObwod() / 2 - base.d));
        }

        
    }
}
