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
                    Console.WriteLine("Buktad köcsög");
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
                    Console.WriteLine("jézus fasza, mennyit alszol mán");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Adj meg egy számot 0 és 24 között");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
