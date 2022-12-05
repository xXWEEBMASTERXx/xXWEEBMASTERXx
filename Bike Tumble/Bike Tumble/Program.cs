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
            string[] Products = File.ReadAllLines("gyumolcsok 1.txt");
            string[] Product_weight_string = File.ReadAllLines("gyumolcsok 2.txt");
            int[] Product_weight = new int[100];

            //2. Feladat
            for (int i = 0; i < Product_weight_string.Length; i++)
            {

                Product_weight = new int[] { i };
            }
            for (int i = 0; i < Products.Length; i++)
            {
                Console.WriteLine(Products[1]);
            }
            for (int i = 0; i < Product_weight.Length; i++)
            {
                Console.WriteLine(Product_weight[i]);
            }
            Console.ReadKey();

            //3. Feladat
            Console.WriteLine(Product_weight.Sum());
            Console.ReadKey();

            //4. Feladat
            int atlag = Product_weight.Sum() / Product_weight.Length;
            Console.WriteLine(atlag);
            Console.ReadKey();

            //5. Feladat
            for (int i = 0; i < Product_weight.Length; i++)
            {
                if (Product_weight[i] == 10)
                {
                    Console.WriteLine(Products[i]);
                }
            }
            Console.ReadKey();

            //6. Feladat
            int legtobb = 0;
            int legtobb_neve = 0;

            for (int i = 0; i < Product_weight.Length; i++)
            {
                if (legtobb < Product_weight[i])
                {
                    legtobb = Product_weight[i];
                    legtobb_neve = i;
                }
            }
            Console.WriteLine(legtobb);
            Console.WriteLine(Products[legtobb_neve]);
            Console.ReadKey();

            //7. Feladat
            for (int i = 0; i < Product_weight.Length; i++)
            {
                if (Product_weight[i] >= 30)
                {
                    Console.WriteLine(Products[i]);
                }
            }
            Console.ReadKey();

            //8. Feladat
            int legkevesebb = 10;
            int legkevesebb_neve = 0;

            for (int i = 0; i < Product_weight.Length; i++)
            {
                if (legkevesebb < Product_weight[i])
                {
                    legtobb_neve = i;
                    break;
                }
            }
        }
    }
}