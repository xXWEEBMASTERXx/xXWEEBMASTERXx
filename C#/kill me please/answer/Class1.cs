using System;
using System.Collections.Generic;
using System.Linq;

namespace kosar
{
    public class CashRegister
    {
        private List<string> purchasedItems = new List<string>();

        public void StartNewShopping()
        {
            purchasedItems.Clear();
        }

        public void ScanItem(string item)
        {
            if (string.IsNullOrWhiteSpace(item))
            {
                throw new ArgumentException("Item name cannot be empty or null.");
            }

            purchasedItems.Add(item);
        }

        public void RemoveItem(string item)
        {
            purchasedItems.Remove(item);
        }

        public double CalculateTotal(Dictionary<string, double> itemPrices)
        {
            double total = 0.0;
            foreach (string item in purchasedItems)
            {
                if (itemPrices.ContainsKey(item))
                {
                    total += itemPrices[item];
                }
                else
                {
                    throw new ArgumentException($"Item '{item}' is not in the price list.");
                }
            }

            return total;
        }

        public List<string> GetPurchasedItems()
        {
            return purchasedItems.ToList();
        }

        public void EndShopping()
        {
            Console.WriteLine("Shopping has ended. Thank you for your purchase!");
        }
    }
}