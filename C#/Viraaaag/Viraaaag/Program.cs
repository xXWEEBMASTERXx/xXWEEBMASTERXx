using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Viraaaag
{
    class Program
    {
        class Viraaaag
        {
            string naem;
            int priec;
            int szaaaal;

            public Viraaaag(string sor)
            {
                string[] helper = sor.Split(';');
                naem = helper[0];
                priec = int.Parse(helper[1]);
                szaaaal = int.Parse(helper[2]);
            }
            public string Naem { get { return naem; } private set { } }
            public int Priec { get { return priec; } private set { } }
            public int Szaaaal { get { return szaaaal; } private set { } }

            public override string ToString()
            {
                return $"{naem} ({priec} Ft) {szaaaal} szál";
            }
        }
        static void Main(string[] args)
        {
            StreamReader fbe = new StreamReader("viragok.txt");
            List<Viraaaag> viraaaagLista = new List<Viraaaag>();

            while (!fbe.EndOfStream)
            {
                viraaaagLista.Add(new Viraaaag(fbe.ReadLine()));
            }
            foreach (Viraaaag item in viraaaagLista)
            {
                Console.WriteLine(item);
            }
            
            double atlag = 0;
            double atlag2 = 0;
            int osszDB = 0;
            foreach (var item in viraaaagLista)
            {
                atlag += item.Priec;
                atlag2 += item.Priec;
                osszDB++;
            }
            Console.WriteLine($"átlagár: {atlag / viraaaagLista.Count}");
            Console.WriteLine($"átlagár2: {atlag2 / osszDB}");
            int max = int.MinValue;
            string drágaszágom = "";
            foreach (var item in viraaaagLista)
            {
                if (max < item.Priec)
                {
                    max = item.Priec;
                    drágaszágom = item.Naem;
                }
            }
            Console.WriteLine($"legdrágább: {drágaszágom}, ára {max}");
            int over1Thousand = 0;
            foreach (var item in viraaaagLista)
            {
                if (item.Priec > 1000)
                {
                    over1Thousand++;
                }
            }
            Console.WriteLine("add meg virág! ");
            string hol = Console.ReadLine();
            bool wayne = false;
            foreach (var item in viraaaagLista)
            {
                if (item.Naem == hol)
                {
                    Console.WriteLine(item.Priec);
                    wayne = true;
                    break;
                }
                if (!wayne)
                {
                    Console.WriteLine("Nincs ilyen");
                    break;
                }
            }
            StreamWriter fki = new StreamWriter("rendeles.txt");
            foreach (var item in viraaaagLista)
            {
                if (item.Priec > 5)
                {
                    fki.WriteLine(item.Naem);
                }
            }
            fki.Close();
        }
    }
}