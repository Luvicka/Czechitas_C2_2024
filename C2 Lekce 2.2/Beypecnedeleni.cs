using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Lekce_2._2
{
    public class Beypecnedeleni
    {
        public double PodelCisla(double a, double b)
        {
            // kdyz podelim 0, chci skoncit chybou

            if (b == 0.0)
            {
                throw new ArgumentException("Nulou nelze delit.");
            }
        return a/ b;
        }
    }
}
