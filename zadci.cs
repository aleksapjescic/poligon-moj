using poligon_3_9_2026b;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poligon_3_9b_2026
{
    internal class zadci
    {
        public bool deltoid(Tacka a, Tacka b, Tacka c, Tacka d)
        {
            Vektor AB = new Vektor(a, b);
            Vektor CD = new Vektor(c, d);
            Vektor CB = new Vektor(c, b);
            Vektor AD = new Vektor(a, d);

            if (AB.duzina() == CD.duzina() && CB.duzina() == AD.duzina())
            {
                return true;
            }
            else if(AB.duzina() == AD.duzina() && CD.duzina() != AD  .duzina())
            {
                return true;
            }
            else
            {
                return false;
            }
                
        }

    }
}
