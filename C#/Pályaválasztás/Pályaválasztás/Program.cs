using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pályaválasztás
{
    class Program
    {
        static void Main(string[] args)
        {
            // a)
            StreamReader strím = new StreamReader("tanulok.txt", Encoding.Default);
            string[] nev = new string[100];
            string[] kar = new string[100];
            string[] szak = new string[100];
            int[] pont = new int[100];

            int num = 0;

            while (!strím.EndOfStream)
            {
                num++;
                string sor = strím.ReadLine();
                string[] data = sor.Split(';');
                nev[num] = data[0];
                kar[num] = data[1];
                szak[num] = data[2];
                pont[num] = int.Parse(data[3]);
            }
            for (int i = 0; i < nev.Length; i++)
            {
                Console.WriteLine(nev[i]);
            }

            for (int i = 0; i < pont.Length; i++)
            {
                Console.WriteLine(pont[i]);
            }
            Console.ReadKey();

            // b)
            for (int i = 0; i < kar.Length; i++)
            {
                if (kar[i] == "ELTE-IK")
                {
                    int student = Array.IndexOf(kar,i);
                    Console.WriteLine(nev[student]);
                    Console.WriteLine(szak[student]);
                    break;
                }
            }

            // c)
            int anglisztika = 0;
            for (int i = 0; i < szak.Length; i++)
            {
                if (szak[i] == "anglisztika")
                {
                    anglisztika++;
                }
            }
            Console.WriteLine(anglisztika+"diák ment anglisztika szakra.");
            Console.ReadKey();

            // d)
            int atlag_pont = pont.Sum() / pont.Length;
            Console.WriteLine("Az Átlag"+atlag_pont+"pont.");

            // e)

        }
    }
}
