using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekszt
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Feladat
            //a)
            Console.WriteLine("adj meg egy szöveget: ");
            string hossz = Console.ReadLine();
            int stringLenght = hossz.Length;
            Console.WriteLine(stringLenght);
            Console.ReadLine();
            
            //b)
            for (int i = hossz.Length-1; i >= 0; i--)
            {
                Console.WriteLine(hossz[i]);
            }
            Console.ReadLine();
        }
    }
}
