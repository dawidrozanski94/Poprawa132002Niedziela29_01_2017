using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poprawa132002
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ksztalt> figury = new List<Ksztalt>();
            figury.Add(new Trojkat(2, 3, 4));
            figury.Add(new Trojkat(2, 1, 3));
            figury.Add(new Trojkat(2, 1, 5));
            figury.Add(new Trojkat(11, 15, 18));
            figury.Add(new Trojkat(9, 3, 4));
            figury.Add(new TrojkatProstokatny(1,2));
            figury.Add(new TrojkatProstokatny(3,1));
            figury.Add(new TrojkatProstokatny(5,8));
            figury.Add(new TrojkatProstokatny(5,10));
            figury.Add(new TrojkatRownoboczny(2));
            figury.Add(new Kwadrat(2));
            figury.Add(new Kwadrat(4));
            figury.Add(new Kwadrat(5));
            figury.Add(new Kwadrat(1));
            figury.Add(new Kwadrat(8));
            figury.Add(new Prostokat(2, 4));
            figury.Add(new Prostokat(3, 4));
            figury.Add(new Prostokat(2, 7));
            figury.Add(new Prostokat(6, 11));
            figury.Add(new Prostokat(12, 14));

           
            Console.ReadKey();

            

        }
    }
}
