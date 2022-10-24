using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace triggered
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Bevetelek = new int[5] { 1, 5, 2, 3, 4 };
            int BeCount = 5;
            int[] Libak = new int[5] { 1, 5, 2, 3, 4 };
            int LCount = 5;

            int osszes = 0;
            for (int i = 0; i < BeCount; i++)
            {
                osszes += Bevetelek[i];
            }
            Console.WriteLine("Napi bevétel {0} picula", osszes);

            int osszes2 = 0;
            foreach (int ez in Bevetelek)
            {
                osszes2 += ez;
            }
            Console.WriteLine("Napi bevétel {0} picula", osszes2);

            int osszes3 = 0;
            int j = 0;
            while (j < BeCount)
            {
                osszes += Bevetelek[j];
                j++;
            }
            Console.WriteLine("Napi bevétel {0} picula", osszes3);

            Console.WriteLine("Napi bevétel {0} picula", Bevetelek.Sum());

            int osszes4 = 0;
            for (int i = 0; i < LCount; i++)
            {
                if (Libak[i] <= 3)
                {
                    osszes4 += Libak[i];
                }
            }
            Console.WriteLine("A rókának {0} kilogramm liba maradt", osszes4);

            int osszes5 = 0;
            for (int i = 0; i < LCount; i++)
                if (Libak[i] < 3 || Libak[i] == 5)
                    osszes += Libak[i];
            Console.WriteLine("A rókának {0} kilogramm liba maradt", osszes);

            int osszes6 = 0;
            for (int i = 0; i < Bevetelek.Count(); i++)
                osszes += Bevetelek[i];
            int atlag = osszes6 / Bevetelek.Count();
            Console.WriteLine("Az átlagos bevétel {0} picula", osszes);

            int osszes7 = 0;
            int db = 0;
            foreach (int ez in Libak)
                if (ez <= 3)
                {
                    osszes += ez;
                    db++;
                }
            Console.WriteLine("A róka libái átlagosan {0} kilósak", atlag);

            bool Van5()
            {
                bool vanilyen = false;
                for (int i = 0; i < Bevetelek.Count(); i++)
                    if (Bevetelek[i] == 5)
                        vanilyen = true;
                return vanilyen;
            }

            if (Van5())
                Console.WriteLine("Volt 5 piculás bevétel.");
            else
                Console.WriteLine("Nem volt 5 piculás bevétel.");

            bool Van6()
            {
                bool vanilyen = false;
                for (int i = 0; i < Bevetelek.Count() && !vanilyen; i++)
                    if (Bevetelek[i] == 5)
                        vanilyen = true;
                return vanilyen;
            }
            bool Van7()
            {
                bool vanilyen = false;
                int i = 0;
                while (i < Bevetelek.Count() && !vanilyen)
                {
                    if (Bevetelek[i] == 5)
                        vanilyen = true;
                    i++;
                }
                return vanilyen;
            }

            bool Van8()
            {
                int i = 0;
                while (i < Bevetelek.Count() && !(Bevetelek[i] == 5))
                    i++;
                return i < Bevetelek.Count();
            }
            bool Van9()
            {
                int i;
                for (i = 0; i < Bevetelek.Count() && Bevetelek[i] != 5; i++) ;
                return i < Bevetelek.Count();
            }

            bool Van10()
            {
                bool vanilyen = false;
                for (int i = 0; i < Bevetelek.Count(); i++)
                    if (Bevetelek[i] == 5)
                    {
                        vanilyen = true;
                        break;
                    }
                return vanilyen;
            }

                if (Van10())
                    Console.WriteLine("Volt 5 piculás bevétel.");
                else
                    Console.WriteLine("Nem volt 5 piculás bevétel.");

                bool Van11()
                {
                    for (int i = 0; i < Bevetelek.Count(); i++)
                        if (Bevetelek[i] == 5)
                            return true;
                    return false;
                }

                bool Voltnagy()
                {
                    bool vanilyen2 = false;
                    int i = 0;
                    while (i < Libak.Count() && !vanilyen2)
                    {
                        if (Libak[i] >= 5)
                            vanilyen2 = true;
                        i++;
                    }
                    return vanilyen2;
                }
                bool Elozonelkisebb()
                {
                    int i = 1;
                    while (i < Libak.Count() && !(Libak[i] < Libak[i - 1]))
                        i++;
                    return i < Libak.Count()
                ;
                }
                if (Bevetelek.Contains(5))
                    Console.WriteLine("Volt 5 piculás bevétel.");
                else
                    Console.WriteLine("Nem volt 5 piculás bevétel.");

                int HolVan5()
                {
                    int i = 0;
                    while (!(Bevetelek[i] == 5))
                        i++;
                    return i;
                }
                Console.WriteLine("Az ötpiculás fuvar sorszáma: {0}", HolVan5() + 1);

                int Elsonagy()
                {
                    int i;
                    for (i = 0; Libak[i] < 3; i++) ;
                    return i;
                }

                void Hol5()
                {
                    int i = 0;
                    while (i < Bevetelek.Count() && !(Bevetelek[i] == 5))
                        i++;
                    if (i < Bevetelek.Count())
                        Console.WriteLine("Az 5 piculás fuvar sorszáma: {0}", i + 1);
                    else
                        Console.WriteLine("Nem volt 5 piculás fuvar.");
                }

                void Hol6()
                {
                    int ez;
                    for (ez = 0; ez < Bevetelek.Count(); ez++)
                        if (Bevetelek[ez] == 5)
                            break;
                    if (ez < Bevetelek.Count())
                        Console.WriteLine("Az 5 piculás fuvar sorszáma: {0}", ez + 1);
                    else
                        Console.WriteLine("Nem volt 5 piculás fuvar.");
                }

                int db2 = 0;
                for (int i = 0; i < Libak.Count(); i++)
                    if (Libak[i] <= 3)
                        db++;
                Console.WriteLine("A rókának {0} libája marad.", db);

                int db3 = 0;
                List<int> rokae = new List<int>();
                for (int i = 0; i < LCount; i++)
                    if (Libak[i] <= 3)
                    {
                        rokae.Add(Libak[i]);
                        db++;
                    }
                Console.WriteLine("A rókának ez a {0} liba jutott.", db);
                foreach (int liba in rokae)
                    Console.Write("{0} kilós, ", liba);
                Console.WriteLine("\b\b.");

                Console.WriteLine("Az legnagyobb érték {0}", Bevetelek.Max());

                int legtobb = Bevetelek[0];
                foreach (int ez in Bevetelek)
                    if (ez > legtobb)
                        legtobb = ez;
                Console.WriteLine("A legdrágább fuvar {0} piculát ért.", legtobb);

                int legtobb2 = Bevetelek[0];
                for (int i = 1; i < Bevetelek.Count(); i++)
                    if (Bevetelek[i] > legtobb)
                        legtobb = Bevetelek[i];
                Console.WriteLine("A legdrágább fuvar {0} piculát ért.", legtobb);


                int maxhely = 0;
                for (int i = 1; i < Bevetelek.Count(); i++)
                    if (Bevetelek[i] > Bevetelek[maxhely])
                        maxhely = i;
                Console.WriteLine("A legdrágább fuvar az {0}.", maxhely);
                Console.WriteLine("Ezért {0} piculát fizettek.", Bevetelek[maxhely]);
                int Maxh()
                {
                    int maxhely2 = 0;
                    for (int i = 1; i < Bevetelek.Count(); i++)
                        if (Bevetelek[i] > Bevetelek[maxhely])
                            maxhely = i;
                    return maxhely
                ;
                }
                int maxindex = Maxh();
                Console.WriteLine("A legdrágább fuvar az {0}.", maxindex);
                Console.WriteLine("Ezért {0} piculát fizettek.", Bevetelek[maxindex]);

                int farkasmin = 1000;
                foreach (int ez in Libak)
                    if (ez > 3 && ez < farkasmin)
                        farkasmin = ez;
                if (farkasmin == 1000)
                    Console.WriteLine("A farkas nem vitt el egy libát sem.");
                else
                    Console.WriteLine("A farkas legkisebb libája {0} kg.", farkasmin);
                void FarkasLegkisebbLibaja()
                {
                    int i = 0;
                    while (i < Libak.Count() && !(Libak[i] > 3))
                        i++;
                    if (i == LCount)
                        Console.WriteLine("A farkas nem vitt el egy libát sem.");
                    else
                    {
                        int minid = i;
                        while (i < LCount)
                        {
                            if (Libak[i] > 3 && Libak[i] < Libak[minid])
                                minid = i;
                            i++;
                        }
                        Console.Write("A farkas legkisebb libája {0} kg.", Libak[minid]);
                    }
                }
            }
        }
    }