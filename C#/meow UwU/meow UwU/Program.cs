using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meow_UwU
{
    class teglalap
    {
        double a;
        double b;

        public teglalap()
        {
            a = 1;
            b = 2;
        }
        public teglalap(double aa, double bb)
        {
            a = aa;
            b = bb;
        }
        public double A
        {
            get { return a; }
            set
            {
                if (value >= 0)
                {
                    a = value;
                }
            }
        }
        public double B
        {
            get { return b; }
            set
            {
                if (value >= 0)
                {
                    b = value;
                }
            }
        }
        public void kerulet()
        {
            Console.WriteLine(2 * (a + b));
        }
        public void terulet()
        {
            Console.WriteLine(a * b);
        }
    }
    class termek
    {
        string Nev;
        int EgyseggAr;
        int Kedvezmeny;
        int RaktarKeszlet;

        public termek(string nev, int egyseggAr)
        {
            Nev = nev;
            EgyseggAr = egyseggAr;
            Kedvezmeny = 0;
            RaktarKeszlet = 1;
        }
        public termek(string nev, int egyseggAr, int raktarKeszlet)
        {
            Nev = nev;
            EgyseggAr = egyseggAr;
            Kedvezmeny = 0;
            RaktarKeszlet = raktarKeszlet;
        }

        public string nev
        {
            get { return Nev; }
        }
        public int egyseggAr
        {
            get { return EgyseggAr; }
            set
            {
                if (value >= 0)
                {
                    EgyseggAr = value;
                }
            }
        }
        public int kedvezmeny
        {
            get { return Kedvezmeny; }
            set
            {
                if (value >= 0)
                {
                    Kedvezmeny = value;
                }
            }
        }
        public int raktarKeszlet
        {
            get { return RaktarKeszlet; }
            set
            {
                if (value >= 0)
                {
                    RaktarKeszlet = value;
                }
            }
        }
        public void informacio() 
        {
            Console.WriteLine($"A neve: {Nev}");
            Console.WriteLine($"Az ára: {EgyseggAr}");
            Console.WriteLine($"A raktárkészlet: {RaktarKeszlet}");
        }

        public void eladas(int eladott) 
        {
            if (eladott >=0)
            {
                RaktarKeszlet -= eladott;
            }
        }
        public void beszerzes(int megvett)
        {
            if (megvett >= 0)
            {
                RaktarKeszlet += megvett;
            }
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            teglalap t1 = new teglalap();
            termek t2 = new termek("padlizsán",69420);
            t1.kerulet();
            t1.terulet();
            t2.informacio();
            t2.beszerzes(2);
            t2.eladas(2);
        }
    }
}
