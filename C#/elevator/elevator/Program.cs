using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Helló!");

            Console.WriteLine("Add meg a neved! ");
            string nev = Console.ReadLine();
            Console.WriteLine("Szia"+nev+"!");

            kettokerek k1 = new kettokerek();
            Bringa b1 = new Bringa(1.8);

            b1.Jelez();

            Console.ReadKey();
        }
    }
}
