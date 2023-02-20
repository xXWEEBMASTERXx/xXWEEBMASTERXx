using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Település
{
    public class Telepules
    {
        public string telepulesNev { get; }
        public double bevetel { get; set; }
        public double kiadas { get; set; }
        public string kategoria { get; }

        public Telepules(string telepulesNev, double bevetel, double kiadas, string kategoria)
        {
            this.telepulesNev = telepulesNev;
            this.bevetel = bevetel;
            this.kiadas = kiadas;
            this.kategoria = kategoria;
        }

        public bool Szufficites()
        {
            return bevetel > kiadas;
        }

        public void Befizetes(double osszeg)
        {
            bevetel += osszeg;
        }

        public string MindenAdat()
        {
            return $"Település neve: {telepulesNev}, Bevétel: {bevetel}, Kiadás: {kiadas}, Kategória: {kategoria}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Telepules> telepulesek = new List<Telepules>();

            // A felhasználótól kérjük meg az adatokat és tároljuk őket a listában
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Adja meg a(z) {i + 1}. település nevét: ");
                string nev = Console.ReadLine();
                Console.Write($"Adja meg a(z) {i + 1}. település bevételeit: ");
                double bevetel = double.Parse(Console.ReadLine());
                Console.Write($"Adja meg a(z) {i + 1}. település kiadásait: ");
                double kiadas = double.Parse(Console.ReadLine());
                Console.Write($"Adja meg a(z) {i + 1}. település kategóriáját (falu/község/város): ");
                string kategoria = Console.ReadLine();
                telepulesek.Add(new Telepules(nev, bevetel, kiadas, kategoria));
            }

            // Kiírjuk az összes település adatait
            foreach (Telepules telepules in telepulesek)
            {
                Console.WriteLine(telepules.MindenAdat());
            }

            // Megkeressük a legnagyobb szufficittel és a legnagyobb deficittel rendelkező települést
            Telepules legnagyobbSzufficit = telepulesek[0];
            Telepules legnagyobbDeficit = telepulesek[0];
            foreach (Telepules telepules in telepulesek)
            {
                if (telepules.Szufficites() && telepules.bevetel > legnagyobbSzufficit.bevetel)
                {
                    legnagyobbSzufficit = telepules;
                }

                if (telepules.Szufficites() && telepules.bevetel - telepules.kiadas > legnagyobbSzufficit.bevetel - legnagyobbSzufficit.kiadas)
                {
                    legnagyobbSzufficit = telepules;
                }

                if (telepules.Szufficites() && telepules.bevetel - telepules.kiadas < legnagyobbDeficit.bevetel - legnagyobbDeficit.kiadas)
                {
                    legnagyobbDeficit = telepules;
                }


                Console.WriteLine("Legnagyobb szufficittel rendelkező település:");
                Console.WriteLine(legnagyobbSzufficit.MindenAdat());
            }
        }
    }
}
