using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poligon_3_9b_2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Milos Pusic
            // Tacka prva = new Tacka();
            // Console.WriteLine(prva.d());
            /* Tacka A = new Tacka(1,2);
            Tacka B = new Tacka(2,3);
            Vektor AB = new Vektor(A,B);
            Tacka C = AB.Centriraj();
            Console.WriteLine(C.d());
            */
            /*
            Tacka A = new Tacka(3, 2);
            Tacka B = new Tacka(-2, 3);
            Tacka O = new Tacka();
            Vektor OA = new Vektor(O, A);
            Vektor OB = new Vektor(O, B);
            Console.WriteLine(Vektor.SP(OA, OB));
            Console.WriteLine(Vektor.VP(OB, OA));
            */
            /* Tacka A = new Tacka(5, 3);
            Tacka B = new Tacka(5, 5);
            Tacka prva = new Tacka(3, 2);
            Tacka druga = new Tacka(7, 6);
            Vektor a = new Vektor(prva, druga);
            Console.WriteLine(Ravan.SIS(a, A, B));
            */
            // Poligon prvi = Poligon.unos();
            Poligon prvi = Poligon.ucitaj();
            // prvi.snimi();
            prvi.stampa();
            Console.WriteLine("obim={0}", prvi.obim());
        }
    }
}
