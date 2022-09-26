using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // 1. Feladat
            Console.Write("Adj meg egy számot");
            int num = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            
            // 2. Feladat
            for (int i = 0; i < num; i++)
            {
                int o = i * i;
                Console.WriteLine(o);
            }
            Console.ReadLine();
            
            // 3. Feladat
            for (int i = num; 0 < i; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            // 4. Feladat
            for (int i = 0; i < num; i=i+2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();*/

            // 5. Feladat
            Console.Write("Adj meg egy számot");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Adj meg egy kisebb számot");
            int num3 = int.Parse(Console.ReadLine());
            for (int i = num3; i < num2; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
