using System;
using System.Collections.Generic;

namespace kosar
{
    class Program
    {
        static void Main(string[] args)
        {
            CashRegister cashRegister = new CashRegister();
            bool shoppingActive = false;
            Dictionary<string, double> itemPrices = new Dictionary<string, double>();

            while (true)
            {
                double objectPrice;
                Console.WriteLine("1. Új bevásárlás kezdése");
                Console.WriteLine("2. Termék beolvasása");
                Console.WriteLine("3. Termék törlése");
                Console.WriteLine("4. Végösszeg kiszámítása");
                Console.WriteLine("5. Tárolt tételek kilistázása");
                Console.WriteLine("6. Fizetés");
                Console.WriteLine("0. Kilépés");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        if (!shoppingActive)
                        {
                            cashRegister.StartNewShopping();
                            shoppingActive = true;
                            Console.WriteLine("Bevásárlás elkezdve.");
                        }
                        else
                        {
                            Console.WriteLine("Már aktív bevásárlás van.");
                        }

                        break;
                    case "2":
                        if (shoppingActive)
                        {
                            Console.WriteLine("Termék neve: ");
                            string item = Console.ReadLine();
                            cashRegister.ScanItem(item);
                            Console.WriteLine("Termék hozzáadva a kosárhoz.");
                        }
                        else
                        {
                            Console.WriteLine("Nincs aktív bevásárlás. Kérlek kezdj el egyet.");
                        }

                        break;
                    case "3":
                        if (shoppingActive)
                        {
                            Console.WriteLine("Termék neve: ");
                            string itemToRemove = Console.ReadLine();
                            cashRegister.RemoveItem(itemToRemove);
                            Console.WriteLine("Termék eltávolítva a kosárból.");
                        }
                        else
                        {
                            Console.WriteLine("Nincs aktív bevásárlás. Kérlek kezdj el egyet.");
                        }

                        break;
                    case "4":
                        if (shoppingActive)
                        {
                            Console.WriteLine("Termék neve: ");
                            string item = Console.ReadLine();
                            double price;
                            if (itemPrices.TryGetValue(item, out price))
                            {
                                cashRegister.ScanItem(item);
                                objectPrice = price;
                                Console.WriteLine("Termék hozzáadva a kosárhoz.");
                            }
                            else
                            {
                                Console.WriteLine("Nincs ilyen termék az árlistán.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nincs aktív bevásárlás. Kérlek kezdj el egyet.");
                        }

                        break;
                    case "5":
                        if (shoppingActive)
                        {
                            Console.WriteLine("Kosár tartalma:");
                            foreach (var purchasedItem in cashRegister.GetPurchasedItems())
                            {
                                Console.WriteLine(purchasedItem);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nincs aktív bevásárlás. Kérlek kezdj el egyet.");
                        }

                        break;
                    case "6":
                        if (shoppingActive)
                        {
                            cashRegister.EndShopping();
                            shoppingActive = false;
                            Console.WriteLine("Fizetés elfogadva. Bevásárlás befejezve.");
                        }
                        else
                        {
                            Console.WriteLine("Nincs aktív bevásárlás. Kérlek kezdj el egyet.");
                        }

                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Érvénytelen választás.");
                        break;
                }
            }
        }
    }
}