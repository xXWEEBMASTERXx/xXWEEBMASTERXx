class Program
{
    static void Main(string[] args)
    {
        CashRegister cashRegister = new CashRegister();

        while (true)
        {
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
                    cashRegister.StartNewShopping();
                    Console.WriteLine("Bevásárlás elkezdve.");
                    break;
                case "2":
                    Console.WriteLine("Termék neve: ");
                    string item = Console.ReadLine();
                    cashRegister.ScanItem(item);
                    Console.WriteLine("Termék hozzáadva a kosárhoz.");
                    break;
                case "3":
                    Console.WriteLine("Termék neve: ");
                    string itemToRemove = Console.ReadLine();
                    cashRegister.RemoveItem(itemToRemove);
                    Console.WriteLine("Termék eltávolítva a kosárból.");
                    break;
                case "4":
                    double total = cashRegister.CalculateTotal();
                    Console.WriteLine($"Végösszeg: {total} Ft");
                    break;
                case "5":
                    Console.WriteLine("Kosár tartalma:");
                    foreach (var purchasedItem in cashRegister.GetPurchasedItems())
                    {
                        Console.WriteLine(purchasedItem);
                    }
                    break;
                case "6":
                    cashRegister.EndShopping();
                    Console.WriteLine("Fizetés elfogadva. Bevásárlás befejezve.");
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
