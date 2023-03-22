using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Charlie_és_a
{
    class Program
    {
        public interface IEtelgyar
        {
            string[] mibolKeszul();
            bool megfeleloMinoseg { get; }
        }

        public class SilanyMinosegException : Exception
        {
            public SilanyMinosegException() : base("Nem igazi csoki!")
            {
            }
        }

        public class Csokigyar : IEtelgyar
        {
            public string fajta;
            public string[] alapanyagok;
            public int kakaotartalom;

            public Csokigyar(string fajta, int kakaotartalom, string[] alapanyagok)
            {
                this.fajta = fajta;
                this.kakaotartalom = kakaotartalom;
                this.alapanyagok = alapanyagok;
            }

            public string[] mibolKeszul()
            {
                return alapanyagok;
            }

            public bool megfeleloMinoseg
            {
                get
                {
                    if (kakaotartalom > 50)
                    {
                        return true;
                    }
                    else if (kakaotartalom >= 0 && kakaotartalom <= 50)
                    {
                        return false;
                    }
                    else
                    {
                        throw new SilanyMinosegException();
                    }
                }
            }

            public override string ToString()
            {
                return $"Csokigyar fajta: {fajta}, kakaotartalom: {kakaotartalom}%, alapanyagok: {string.Join(", ", alapanyagok)}";
            }
        }

        public sealed class PremiumCsokiGyar : Csokigyar
        {
            public PremiumCsokiGyar(string fajta, int kakaotartalom, string[] alapanyagok)
                : base(fajta, kakaotartalom, alapanyagok)
            {
            }

            public bool megfeleloMinoseg
            {
                get
                {
                    if (kakaotartalom > 80)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }


        static void Main(string[] args)
        {
            try
            {
                // Fájl megnyitása
                StreamReader sr = new StreamReader("input.txt");

                // Az első sor beolvasása, ami tartalmazza a sorok számát
                int numLines = int.Parse(sr.ReadLine());

                // Csokigyártás
                List<Csokigyar> chocolates = new List<Csokigyar>();
                for (int i = 0; i < numLines; i++)
                {
                    string line = sr.ReadLine();
                    string[] parts = line.Split(';');

                    // Csoki típusának és kakaótartalmának beolvasása
                    string type = parts[0];
                    int cocoa = int.Parse(parts[1]);

                    // Alapanyagok beolvasása
                    List<string> ingredients_raw = new List<string>();
                    for (int j = 2; j < parts.Length - 1; j++)
                    {
                        ingredients_raw.Add(parts[j]);
                    }

                    string[] ingredients = ingredients_raw.ToArray();

                    // Premium csoki ellenőrzése
                    bool premium = false;
                    if (parts[parts.Length - 1] == "prémium")
                    {
                        premium = true;
                    }

                    // Objektum létrehozása
                    if (premium)
                    {
                        chocolates.Add(new PremiumCsokiGyar(type, cocoa, ingredients));
                    }
                    else
                    {
                        chocolates.Add(new Csokigyar(type, cocoa, ingredients));
                    }
                }

                // Csokigyárak adatainak kiírása
                foreach (Csokigyar chocolate in chocolates)
                {
                    Console.WriteLine(chocolate.ToString());
                    if (chocolate.megfeleloMinoseg)
                    {
                        Console.WriteLine("Jó minőségű csokit gyártanak.");
                    }
                    else
                    {
                        Console.WriteLine("Rossz minőségű csokit gyártanak.");
                    }
                }

                // Fájl bezárása
                sr.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("A fájl nem található!");
            }
            catch (FormatException)
            {
                Console.WriteLine("A fájl formátuma nem megfelelő!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hiba történt: " + ex.Message);
            }

            Console.ReadLine();
        }
    }

}
