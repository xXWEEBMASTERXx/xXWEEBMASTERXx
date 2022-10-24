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
            string szoveg = Console.ReadLine();
            int stringLenght = szoveg.Length;
            Console.WriteLine(stringLenght);
            Console.ReadLine();

            //b)
            for (int i = 0; i <= szoveg.Length - 1; i++)
            {
                Console.WriteLine(szoveg[i]);
            }
            Console.ReadLine();
            
            //c)
            for (int i = szoveg.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(szoveg[i]);
            }
            Console.ReadLine();
            
            //d)
            string nagybetu = szoveg.ToUpper();
            Console.WriteLine();

            //e)
            string kisbetu = szoveg.ToLower();
            Console.WriteLine();

            //f)
            // idfk

            //2. Feladat
            //a)
            Console.WriteLine("adj meg egy szöveget: ");
            string szoveg2 = Console.ReadLine();
            Console.WriteLine("adj meg még egy szöveget: ");
            string szoveg3 = Console.ReadLine();
            string ossze = string.Format(szoveg2+szoveg3);
            Console.WriteLine(ossze);
            Console.ReadLine();

            //b)
            int hossz2 = szoveg2.Length;
            int hossz3 = szoveg3.Length;
            if (hossz2 > hossz3)
            {
                Console.WriteLine("az 1. a hosszabb. https://i.kym-cdn.com/entries/icons/original/000/037/848/cover2.jpg");
                Console.ReadLine();
            }
            else if (hossz3 > hossz2)
            {
                Console.WriteLine("a 2. a hosszabb. https://i.kym-cdn.com/entries/icons/original/000/037/848/cover2.jpg");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("a 2 szöveg egyenlő hoszú. https://i.kym-cdn.com/entries/icons/original/000/037/848/cover2.jpg");
                Console.ReadLine();
            }

            //c)
            string ossze2 = string.Format(szoveg2+szoveg3);
            Console.WriteLine(ossze2);
            Console.ReadLine();

            //d)

        }
    }
}
