using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kereskedes
{
    public class Auto
    {
        private string marka;
        private string tipus;
        private int evjarat;
        private int kilometer;
        private int ar;

        public Auto(string marka, string tipus, int evjarat, int kilometer, int ar)
        {
            marka = marka;
            tipus = tipus;
            evjarat = evjarat;
            kilometer = kilometer;
            ar = ar;
        }

        public string Marka
        {
            get { return marka; }
        }

        public string Tipus
        {
            get { return tipus; }
        }

        public int Evjarat
        {
            get { return evjarat; }
        }

        public int Kilometer
        {
            get { return kilometer; }
        }

        public int Ar
        {
            get { return ar; }
        }

        public int ForintAr(int napiArfolyam)
        {
            int euroAr = 10000; 
            int arfolyam = euroAr * napiArfolyam;
            int ertek = arfolyam * Evjarat;

            if (Kilometer <= 10000)
            {
                ertek += arfolyam * 5000;
            }
            else if (Kilometer <= 20000)
            {
                ertek += arfolyam * 3000;
            }
            else
            {
                ertek += arfolyam * 1000;
            }

            return ertek;
        }

        public void Kiir()
        {
            string futott = Kilometer >= 200000 ? "sokat futott" : "alig használt";
            string oldtimer = Evjarat < 1993 ? "oldtimer" : "";

            Console.WriteLine($"{Marka} {Tipus}: {Ar} euro, {futott} {oldtimer}");
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            StreamReader fbe = new StreamReader("auto.txt");
            List<Auto> autok = new List<Auto>();
            string sor = fbe.ReadLine();
            int autodb = 0;
            
            while (!fbe.EndOfStream)
            {
                sor = fbe.ReadLine();
                autodb++;
                string[] adatok = sor.Split(';');
                string marka = adatok[0];
                string tipus = adatok[1];
                int evjarat = int.Parse(adatok[2]);
                int kilometer = int.Parse(adatok[3]);
                int ar = int.Parse(adatok[4]);

                Auto auto = new Auto(marka, tipus, evjarat, kilometer, ar);
                autok.Add(auto);
            }
            Console.WriteLine($"{autodb} autó adata van eltárolva.");
            
            int forint = 0;

            foreach (Auto auto in autok)
            {
                forint += auto.ForintAr(378);
            }

            Console.WriteLine($"{forint} Ft a cég készletének értéke forintban.");

            foreach (Auto auto in autok)
            {
                if (auto.Ar > 100000)
                {
                    auto.Kiir();
                }
            }

            int volvoCount = 0;
            foreach (Auto auto in autok)
            {
                if (auto.Marka == "Volvo")
                {
                    volvoCount++;
                }
            }

            Console.WriteLine($"{volvoCount} a készleten lévő Volvo-k száma.");

            List<Auto> legfiatalabbAutok = new List<Auto>();
            int legfiatalabbEvjarat = 9999;

            foreach (Auto auto in autok)
            {
                if (auto.Evjarat < legfiatalabbEvjarat)
                {
                    legfiatalabbEvjarat = auto.Evjarat;
                    legfiatalabbAutok.Clear();
                    legfiatalabbAutok.Add(auto);
                }
                else if (auto.Evjarat == legfiatalabbEvjarat)
                {
                    legfiatalabbAutok.Add(auto);
                }
            }

            Console.WriteLine($"A készleten lévő legfiatalabb autó(k):");
            foreach (Auto auto in legfiatalabbAutok)
            {
                Console.WriteLine($"{auto.Marka} {auto.Tipus}: {auto.Ar} euro, {auto.Kilometer} km, {auto.Evjarat} év");
            }

            Console.WriteLine("Kérem, adja meg a keresett márka nevét:");
            string keresettMarka = Console.ReadLine();

            List<Auto> keresettAutok = autok.Where(a => a.Marka == keresettMarka).Select(a => new Auto(a.Tipus, a.Marka, a.Evjarat, a.Kilometer, a.Ar * 378)).ToList();

            string kimenetiFajlNev = keresettMarka + ".txt";
            using (StreamWriter sw = new StreamWriter(kimenetiFajlNev))
            {
                foreach (Auto auto in keresettAutok)
                {
                    sw.WriteLine($"{auto.Tipus};{auto.Evjarat};{auto.Kilometer};{auto.Ar}");
                }
            }
            Console.ReadKey();
        }
    }
}
