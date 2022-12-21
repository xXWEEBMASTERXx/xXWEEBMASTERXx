using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace World_Replacement
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Feladat
            string[] Products = File.ReadAllLines("tortak 1.txt");
            string[] Product_price_string = File.ReadAllLines("tortak 2.txt");
            int[] Product_price = new int[100];


            for (int i = 0; i < Product_price_string.Length; i++)
            {
                
                Product_price = new int[] { i };
            }
            for (int i = 0; i < Products.Length; i++)
            {
                Console.WriteLine(Products[1]);
            }
            for (int i = 0; i < Product_price.Length; i++)
            {
                Console.WriteLine(Product_price);
            }
            Console.ReadKey();

            //2. Feladat
            for (int i = 0; i < Products.Length; i++)
            {
                Console.WriteLine(Products[i]);
            }
            Console.ReadKey();
            for (int i = 0; i < Product_price.Length; i++)
            {
                Console.WriteLine(Product_price[i]);
            }
            Console.ReadKey();

            //3. Feladat
            int atlag = Product_price.Sum() / Product_price.Length;
            Console.WriteLine(atlag);
            Console.ReadKey();

            //4. Feladat
            int legdragabb = 0;
            int legdragabb_neve = 0;
            
            for (int i = 0; i < Product_price.Length; i++)
            {
                if (legdragabb < Product_price[i])
                {
                    legdragabb = Product_price[i];
                    legdragabb_neve = i;
                }
            }
            Console.WriteLine(legdragabb);
            Console.WriteLine(Products[legdragabb_neve]);
            Console.ReadKey();

            //5. Feladat
            for (int i = 0; i < Product_price.Length; i++)
            {
                if (Product_price[i] > 4500)
                {
                    Console.WriteLine(Products[i]);
                }
            }
            Console.ReadKey();

            //6. Feladat
            Console.WriteLine("Adj meg egy tortát");
            string torta = Console.ReadLine();
            int indeksz = Array.IndexOf(Products, torta);
            if (Products.Contains(torta))
            {
                Console.WriteLine("A torta rendelhető ára:"+Product_price[indeksz]);
            }
            else
            {
                Console.WriteLine("A torta nem rendelhető");
            }
            Console.ReadKey();
        }
    }
}
