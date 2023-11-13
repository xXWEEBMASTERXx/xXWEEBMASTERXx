using kosar;

[TestClass]
public class CashRegisterTests
{
    [TestMethod]
    public void StartNewShopping_Should_ClearPurchasedItems()
    {
        CashRegister cashRegister = new CashRegister();
        cashRegister.ScanItem("Item 1");
        cashRegister.ScanItem("Item 2");

        cashRegister.StartNewShopping();

        if (cashRegister.GetPurchasedItems().Count == 0)
        {
            Console.WriteLine("StartNewShopping_Should_ClearPurchasedItems: PASSED");
        }
        else
        {
            Console.WriteLine("StartNewShopping_Should_ClearPurchasedItems: FAILED");
        }
    }

    [TestMethod]
    public void ScanItem_Should_AddItemToPurchasedItems()
    {
        CashRegister cashRegister = new CashRegister();
        string item = "Item 1";

        cashRegister.ScanItem(item);

        if (cashRegister.GetPurchasedItems().Contains(item))
        {
            Console.WriteLine("ScanItem_Should_AddItemToPurchasedItems: PASSED");
        }
        else
        {
            Console.WriteLine("ScanItem_Should_AddItemToPurchasedItems: FAILED");
        }
    }

    [TestMethod]
    public void RemoveItem_Should_RemoveItemFromPurchasedItems()
    {
        CashRegister cashRegister = new CashRegister();
        string itemToRemove = "Item 1";
        cashRegister.ScanItem(itemToRemove);

        cashRegister.RemoveItem(itemToRemove);

        if (!cashRegister.GetPurchasedItems().Contains(itemToRemove))
        {
            Console.WriteLine("RemoveItem_Should_RemoveItemFromPurchasedItems: PASSED");
        }
        else
        {
            Console.WriteLine("RemoveItem_Should_RemoveItemFromPurchasedItems: FAILED");
        }
    }

    [TestMethod]
    public void CalculateTotal_Should_ReturnCorrectTotal()
    {
        CashRegister cashRegister = new CashRegister();
        Dictionary<string, double> itemPrices = new Dictionary<string, double>
        {
            { "Item 1", 10.0 },
            { "Item 2", 20.0 }
        };
        cashRegister.ScanItem("Item 1");
        cashRegister.ScanItem("Item 2");

        double expectedTotal = 0.0;
        foreach (string item in cashRegister.GetPurchasedItems())
        {
            if (itemPrices.ContainsKey(item))
            {
                expectedTotal += itemPrices[item];
            }
        }

        // Calculate the actual total
        double actualTotal = cashRegister.CalculateTotal(itemPrices);

        if (expectedTotal == actualTotal)
        {
            Console.WriteLine("CalculateTotal_Should_ReturnCorrectTotal: PASSED");
        }
        else
        {
            Console.WriteLine("CalculateTotal_Should_ReturnCorrectTotal: FAILED");
        }
    }

    [TestMethod]
    public void GetPurchasedItems_Should_ReturnPurchasedItemsList()
    {
        CashRegister cashRegister = new CashRegister();
        cashRegister.ScanItem("Item 1");
        cashRegister.ScanItem("Item 2");

        List<string> purchasedItems = cashRegister.GetPurchasedItems();

        List<string> expectedItems = new List<string> { "Item 1", "Item 2" };

        if (expectedItems.SequenceEqual(purchasedItems))
        {
            Console.WriteLine("GetPurchasedItems_Should_ReturnPurchasedItemsList: PASSED");
        }
        else
        {
            Console.WriteLine("GetPurchasedItems_Should_ReturnPurchasedItemsList: FAILED");
        }
    }

    [TestMethod]
    public void EndShopping_Should_PerformEndShoppingActions()
    {
        CashRegister cashRegister = new CashRegister();
        cashRegister.ScanItem("Item 1");
        cashRegister.ScanItem("Item 2");

        cashRegister.EndShopping();

        if (cashRegister.GetPurchasedItems().Count == 0)
        {
            Console.WriteLine("EndShopping_Should_PerformEndShoppingActions: PASSED");
        }
        else
        {
            Console.WriteLine("EndShopping_Should_PerformEndShoppingActions: FAILED");
        }
    }
}
