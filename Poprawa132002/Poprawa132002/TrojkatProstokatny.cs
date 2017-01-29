using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poprawa132002
{
    class TrojkatProstokatny : Trojkat
    {
        public TrojkatProstokatny()
        {

        }

        public TrojkatProstokatny(double a, double b)
        {
            base.a = a;
            base.b = b;
            c = Math.Sqrt(a * a + b * b);
        }
    }
}
