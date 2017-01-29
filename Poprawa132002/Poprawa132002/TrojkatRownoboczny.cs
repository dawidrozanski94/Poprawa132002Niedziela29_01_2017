using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poprawa132002
{
    class TrojkatRownoboczny : Trojkat
    {
        public TrojkatRownoboczny()
        {

        }

        public TrojkatRownoboczny(double a)
        {
            base.a = base.b = base.c = a;
        }
    }
}
