using poligon_3_9b_2026;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poligon_3_9_2026b
{
    internal class Vektor
    {
        public Tacka pocetak, kraj;
        public Vektor(Tacka a, Tacka b)
        {
            pocetak = a;
            kraj = b;
        }
        public Tacka Centriraj()
        {
            Tacka nova = new Tacka(kraj.x - pocetak.x, kraj.y - pocetak.y);
            return nova;
        }
        public static double SP(Vektor a, Vektor b)
        {
            Tacka ac = a.Centriraj();
            Tacka bc = b.Centriraj();
            return ac.x * bc.x + ac.y * bc.y;
        }
        public static double VP(Vektor a, Vektor b)
        {
            Tacka ac = a.Centriraj();
            Tacka bc = b.Centriraj();
            return ac.x * bc.y - bc.x * ac.y;
        }
        public double duzina()
        {
            Tacka A = this.Centriraj();
            double duzina = A.d();
            return duzina;
        }
        public static bool seku_se(Vektor a, Vektor b)
        {
            int a_b = Ravan.sis(a, b.pocetak, b.kraj);
            int b_a = Ravan.sis(b, a.pocetak, a.kraj);
            if ((a_b != 0) && (b_a != 0))
            {
                return true;
            }
            return false;

        }
    }
}