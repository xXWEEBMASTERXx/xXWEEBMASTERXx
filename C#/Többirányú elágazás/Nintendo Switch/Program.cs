using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nintendo_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adj meg egy érdemjegyet");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 5:
                    Console.WriteLine("Jeles");
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Jó");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Közepes");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Elegendő");
                    Console.ReadLine();
                    break;
                case 1:
                    Console.WriteLine("bukta");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Ez nem egy érdemjeg");
                    Console.ReadLine();
                    break;
            }
            Console.Write("Add meg a hónap nevét");
            var month = Console.ReadLine();
            switch (month)
            {
                case "Január":
                case "Február":
                case "Március":
                    Console.WriteLine("1. Negyedév");
                    Console.ReadLine();
                    break;
                case "Április":
                case "Május":
                case "Június":
                    Console.WriteLine("2. Negyedév");
                    Console.ReadLine();
                    break;
                case "Július":
                case "Augusztus":
                case "Szeptember":
                    Console.WriteLine("3. Negyedév");
                    Console.ReadLine();
                    break;
                case "Október":
                case "November":
                case "December":
                    Console.WriteLine("4. Negyedév");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Ez nem egy hónap!");
                    Console.ReadLine();
                    break;
            }
            Console.Write("Add meg a hónap sorszámát");
            int monthnum = int.Parse(Console.ReadLine());
            switch (monthnum)
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("Tél");
                    Console.ReadLine();
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Tavasz");
                    Console.ReadLine();
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Nyár");
                    Console.ReadLine();
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Ősz");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Ez nem egy hónap sorszáma!");
                    Console.ReadLine();
                    break;
            }
            Console.Write("Add meg hogy mennyit alszol");
            int sleepnum = int.Parse(Console.ReadLine());
            switch (sleepnum)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("kevés");
                    Console.ReadLine();
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("átlagos");
                    Console.ReadLine();
                    break;
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("sok");
                    Console.ReadLine();
                    break;
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                case 21:
                case 22:
                case 23:
                case 24:
                    Console.WriteLine("nagyon sok");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Adj meg egy számot 0 és 24 között");
                    Console.ReadLine();
                    break;
            }
            Console.Write("Adj meg egy számot 1 és 30 között");
            int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("");
                    Console.ReadLine();
                case 2:
                    Console.WriteLine("");
                    Console.ReadLine();
                case 3:
                    Console.WriteLine("");
                    Console.ReadLine();
                case 4:
                    Console.WriteLine("");
                    Console.ReadLine();
                case 5:
                    Console.WriteLine("");
                    Console.ReadLine();
                case 6:
                    Console.WriteLine("");
                    Console.ReadLine();
                case 7:
                    Console.WriteLine("");
                    Console.ReadLine();
                case 8:
                    Console.WriteLine("");
                    Console.ReadLine();
                case 9:
                    Console.WriteLine("");
                    Console.ReadLine();
                case 10:
                    Console.WriteLine("");
                    Console.ReadLine();
                case 11:
                    Console.WriteLine("");
                    Console.ReadLine();
                case 12:
                    Console.WriteLine("");
                    Console.ReadLine();
                case 13:
                    Console.WriteLine("");
                    Console.ReadLine();
                case 14:
                    Console.WriteLine("");
                    Console.ReadLine();
                case 15:
                    Console.WriteLine("");
                    Console.ReadLine();
                case 16:
                    Console.WriteLine("");
                    Console.ReadLine();
                case 17:
                    Console.WriteLine("");
                    Console.ReadLine();
                case 18:
                    Console.WriteLine("");
                    Console.ReadLine();
                case 19:
                    Console.WriteLine("");
                    Console.ReadLine();
                case 20:
                    Console.WriteLine("");
                    Console.ReadLine();
                case 21:
                    Console.WriteLine("");
                    Console.ReadLine();
                case 22:
                    Console.WriteLine("");
                    Console.ReadLine();
                case 23:
                    Console.WriteLine("");
                    Console.ReadLine();
                case 24:
                    Console.WriteLine("");
                    Console.ReadLine();
                case 25:
                    Console.WriteLine("");
                    Console.ReadLine();
                case 26:
                    Console.WriteLine("");
                    Console.ReadLine();
                case 27:
                    Console.WriteLine("");
                    Console.ReadLine();
                case 28:
                    Console.WriteLine("");
                    Console.ReadLine();
                case 29:
                    Console.WriteLine("");
                    Console.ReadLine();
                case 30:
                    Console.WriteLine("");
                    Console.ReadLine();
                default:
                    Console.WriteLine("Adj meg egy számot 1 és 30 között");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
