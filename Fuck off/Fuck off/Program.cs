using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fuck_off
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nevek = new string[100];
            int[] teruletek = new int[100];

            StreamReader fbe = new StreamReader("orszagok.txt");
            int orszDB = 0;
            while (!fbe.EndOfStream)
            {
                nevek[orszDB] = fbe.ReadLine();
                teruletek[orszDB] = int.Parse(fbe.ReadLine());
                orszDB++;
            }

            int osszTer = 0;
            for (int i = 0; i < orszDB; i++)
            {
                osszTer += teruletek[i];
            }
            Console.WriteLine($"Az összterület: {osszTer} km2");


            Console.ReadKey();

            int minTer = teruletek[0];
            int minHely = 0;

            for (int i = 0; i < orszDB; i++)
            {
                if (minTer > teruletek[i])
                {
                    minTer = teruletek[i];
                    minHely = i;
                }
            }
            Console.WriteLine($"A legkissebb területű ország {nevek[minHely]}, területe: {minTer} km2");

            Console.ReadKey();

            int atlag = (teruletek.Sum() / teruletek.Count());

            int atlagnal_nagyobb = atlag;
            string atlagnal_nagyobbHely = "";

            for (int i = 0; i < orszDB; i++)
            {
                if (teruletek[i] > atlag)
                {
                    atlagnal_nagyobb = teruletek[i];
                    atlagnal_nagyobbHely = nevek[i];
                }
            }

            int atlagnal_kisebb = atlag;
            string atlagnal_kisebbHely = "";

            for (int i = 0; i < orszDB; i++)
            {
                if (teruletek[i] < atlag)
                {
                    atlagnal_kisebb = teruletek[i];
                    atlagnal_kisebbHely = nevek[i];
                }
            }

            int legrovidebb = 999999999;
            string legrovidebbnev = "";
            int leghosszabb = 0;
            string leghosszabbnev = "";
            int[] hossz = new int [100];

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
