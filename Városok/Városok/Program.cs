using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Városok
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader fbe = new StreamReader("varosok.csv");
            
            string sor = fbe.ReadLine();
            int varosdb = 0;
            double indiadb = 0;
            string[] adatok;
            string varos;
            string orszag;
            double nberek;

            while (!fbe.EndOfStream)
            {
                sor = fbe.ReadLine();
                adatok = sor.Split(';');
                varos = adatok[0];
                orszag = adatok[1];
                nberek = double.Parse(adatok[2]);
                varosdb++;
            }
            int i = 0;
            while (true)
            {
                i++;
                if (orszag[i] == "magyarország")
                {
                    Console.WriteLine("Van magyar város az adatok között");
                }
                else
                {
                    Console.WriteLine("Nincs magyar város az adatok között");
                }
            }
            
            Console.WriteLine($"Városok száma: {varosdb} db");
            Console.WriteLine($"indiai nagyvárosok lakosságának összeg: {indiadb} fő");
            Console.ReadKey();
        }
    }
}
