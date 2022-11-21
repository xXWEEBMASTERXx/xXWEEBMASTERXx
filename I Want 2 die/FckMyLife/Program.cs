using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FckMyLife
{
    class Program
    {
        static void Piramis(int height) //eljaras 1.
        {
            for (int i = 1; i <= height; i++)
            {
                string text = string.Join(" ", Enumerable.Repeat("*", i));
                Console.WriteLine(text.PadLeft(height - i + text.Length));
            }
        }
        public static int[] oszto(int n) //eljaras 2.
        {
            if (n <= 0)
            {
                return null;
            }
            List<int> divisors = new List<int>();
            for (int i = 1; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    divisors.Add(i);
                    if (i != n / i)
                    {
                        divisors.Add(n / i);
                    }
                }
            }
            divisors.Sort();
            return divisors.ToArray();
        }
        static int kerulet(int a,int b)
        {
            return 2 * (a + b);
        }
        static void Main(string[] args)
        {
            int fasz = int.Parse(Console.ReadLine());
            Piramis(fasz);
            int Nigga = int.Parse(Console.ReadLine());
            Console.WriteLine(oszto(Nigga));
            int geci = int.Parse(Console.ReadLine());
            int petesejt = int.Parse(Console.ReadLine());
            kerulet(geci, petesejt);
        }
    }
}
