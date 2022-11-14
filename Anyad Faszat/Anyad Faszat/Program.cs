using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Anyad_Faszat
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nevek = new string[100];
            int[] lakossag = new int[100];

            StreamReader fbe = new StreamReader("orszagok.txt");
            int orszDB = 0;
            while (!fbe.EndOfStream)
            {
                nevek[orszDB] = fbe.ReadLine();
                lakossag[orszDB] = int.Parse(fbe.ReadLine());
                orszDB++;
            }
            
            Console.ReadKey();
            int OsszNigga = lakossag.Sum();
            int atlag = lakossag.Sum() / lakossag.Count();
            Console.WriteLine(OsszNigga);
            Console.WriteLine(atlag);
            Console.ReadLine();

            int atlagnal_nagyobb = atlag;

            for (int i = 0; i < orszDB; i++)
            {
                if (lakossag[i] > atlag)
                {
                    atlagnal_nagyobb = lakossag[i];
                }
            }
            
            int Meg_a_faszodnal_is_kisebb = 999999999;

            for (int i = 0; i < orszDB; i++)
            {
                if (lakossag[i] > Meg_a_faszodnal_is_kisebb)
                {
                    Meg_a_faszodnal_is_kisebb = lakossag[i];
                }
            }

            int legrovidebb = 999999999;
            string legrovidebbnev = "";
            int leghosszabb = 0;
            string leghosszabbnev = "";
            int[] hossz = new int[100];

            for (int i = 0; i < orszDB; i++)
            {
                if (legrovidebb > nevek[i].Length)
                {
                    legrovidebb = nevek[i].Length;
                    legrovidebbnev = nevek[i];
                }
            }

            for (int i = 0; i < orszDB; i++)
            {
                if (leghosszabb < nevek[i].Length)
                {
                    leghosszabb = nevek[i].Length;
                    leghosszabbnev = nevek[i];
                }

            }
        }
    }
}
