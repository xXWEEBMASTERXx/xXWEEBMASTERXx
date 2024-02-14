using GiftBoxLib;

var cosmeticItem = new CosmeticItem
{
    Name = "Luxury Cream",
    Price = 29.99m,
    Category = "Cosmetics",
    Brand = "Glamour",
    Volume = "50ml",
    SkinType = "Sensitive"
};

var foodItem = new FoodItem
{
    Name = "Chocolate Bar",
    Price = 5.99m,
    Category = "Food",
    ExpiryDate = DateTime.Now.AddMonths(6),
    Weight = 200,
    IsVegetarian = false
};

var drinkItem = new DrinkItem
{
    Name = "Red Wine",
    Price = 19.99m,
    Category = "Drink",
    AlcoholContent = 13.5,
    BeverageType = "Wine",
    Origin = "France"
};

var giftBox = new GiftBox<IGiftItem>();
giftBox.AddItem(cosmeticItem);
giftBox.AddItem(foodItem);
giftBox.AddItem(drinkItem);

Console.WriteLine("Gift Box Contents:");
giftBox.DisplayItems();
Console.WriteLine($"Total Price: {giftBox.CalculateTotalPrice():C}");