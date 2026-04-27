using poligon_3_9b_2026;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poligon_3_9_2026b
{
    internal class Ravan
    {
        public static int sis(Vektor a, Tacka b, Tacka c)
        {
            //0 ista strana
            //-1 rezne strane
            //1 bar jedna kolinearna sa a

            Vektor pb = new Vektor(a.pocetak, b);
            Vektor pc = new Vektor(a.pocetak, c);

            double pkpb = Vektor.VP(a, pb);
            double pkpc = Vektor.VP(a, pc);

            if (pkpb * pkpc > 0)
            {
                return 0;
            }
            if (pkpb * pkpc < 0)
            {
                return -1;
            }
            return 1;
        }
    }
}