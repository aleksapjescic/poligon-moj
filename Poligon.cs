using poligon_3_9b_2026;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poligon_3_9_2026b
{
    internal class Poligon
    {
        public int broj_temena;
        public Tacka[] teme;
        public Poligon(int n)
        {
            broj_temena = n;
            teme = new Tacka[n];
        }
        public static Poligon unos()
        {
            Console.WriteLine("Koliko temena?");
            int n = Convert.ToInt32(Console.ReadLine());
            Poligon novi = new Poligon(n);
            for (int i = 0; i < n; i++)
            {
                novi.teme[i] = new Tacka();
                Console.WriteLine("A[{0}].x:", i + 1);
                novi.teme[i].x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("A[{0}].y:", i + 1);
                novi.teme[i].y = Convert.ToDouble(Console.ReadLine());
            }
            return novi;
        }
        public static void stampa(Poligon novi)
        {
            for (int i = 0; i < novi.broj_temena; i++)
            {
                Console.WriteLine($"a[{i + 1}].x = {novi.teme[i].x}");
                Console.WriteLine($"a[{i + 1}].y = {novi.teme[i].y}");
            }
        }
        public void snimi()
        {
            StreamWriter izlaz = new StreamWriter("poligon.txt");
            izlaz.WriteLine(broj_temena);
            for (int i = 0; i < broj_temena; i++)
            {
                izlaz.WriteLine(teme[i].x);
                izlaz.WriteLine(teme[i].y);
            }
            izlaz.Close();
        }
        public static Poligon ucitaj()
        {
            using (StreamReader ulaz = new StreamReader("poligon.txt"))
            {
                int n = Convert.ToInt32(ulaz.ReadLine());
                Poligon p = new Poligon(n);

                for (int i = 0; i < n; i++)
                {
                    p.teme[i] = new Tacka();
                    p.teme[i].x = Convert.ToInt32(ulaz.ReadLine());
                    p.teme[i].y = Convert.ToInt32(ulaz.ReadLine());
                }

                return p;
            }
        }
        public double Obim()
        {
            double obim = 0;
            Vektor a;
            for (int i = 0; i < broj_temena - 1; i++)
            {
                a = new Vektor(teme[i], teme[i + 1]);
                obim += a.duzina();
            }
            a = new Vektor(teme[broj_temena - 1], teme[0]);
            obim += a.duzina();
            return obim;
        }
        public bool prost()
        {
            bool prost = true;
            for (int i = 0; i < broj_temena - 1; i++)
            {
                for (int j = 0; j < broj_temena - 1; j++)
                {
                    if (Tacka.jednake(teme[i], teme[j]))
                    {
                        return false;
                    }
                }
            }
            Vektor[] stranica = new Vektor[broj_temena];
            for (int i = 0; i < broj_temena - 1; i++)
            {
                stranica[i] = new Vektor(teme[i], teme[i + 1]);
            }
            stranica[broj_temena - 1] = new Vektor(teme[broj_temena - 1], teme[0]);
            for (int i = 0; i < broj_temena; i++)
            {
                int kraj;
                if (i == 0) kraj = broj_temena - 1;
                else kraj = broj_temena;
                for (int j = i + 2; j < kraj; j++)
                {
                    if (Vektor.seku_se(stranica[i], stranica[j]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public bool konveksan()
        {
            int brojac = 0;
            for (int i = 0; i < broj_temena; i++)
            {
                Vektor prvi = new Vektor(teme[i], teme[(i + 1) % broj_temena]);
                Vektor drugi = new Vektor(teme[(i + 1) % broj_temena], teme[(i + 2) % broj_temena]);
                if (Vektor.VP(prvi, drugi) > 0) brojac++;
            }
            if ((brojac == broj_temena) || (brojac == 0)) return true;
            return false;
        }
        public double povrsina()
        {
            double plus = 0, minus = 0;
            for (int i = 0; i < broj_temena; i++)
            {
                plus += teme[i].x * teme[(i + 1) % broj_temena].y;
                minus += teme[i].y * teme[(i + 1) % broj_temena].x;
            }
            return Math.Abs(plus - minus) / 2;
        }
        public bool tacka_u()
        {
            Tacka t = new Tacka();
            Console.Write("Unesite x koordinatu tacke: ");
            t.x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Unesite y koordinatu tacke: ");
            t.y = Convert.ToDouble(Console.ReadLine());

            bool unutra = false;
            int j = broj_temena - 1;

            for (int i = 0; i < broj_temena; i++)
            {
                double x1 = teme[i].x, y1 = teme[i].y;
                double x2 = teme[j].x, y2 = teme[j].y;

                bool uslovY = (y1 > t.y) != (y2 > t.y);
                bool uslovX = t.x < (x2 - x1) * (t.y - y1) / (y2 - y1) + x1;

                if (uslovY && uslovX)
                    unutra = !unutra;

                j = i;
            }
            if (unutra)
                Console.WriteLine($"Tacka ({t.x}, {t.y}) je u poligu.");
            else
                Console.WriteLine($"Tacka ({t.x}, {t.y}) nije u poligu.");
            return unutra;
        }
    }
}