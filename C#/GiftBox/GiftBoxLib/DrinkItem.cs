namespace GiftBoxLib
{
    public class DrinkItem : IGiftItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public double AlcoholContent { get; set; }
        public string BeverageType { get; set; }
        public string Origin { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}, Category: {Category}, Price: {Price}");
            Console.WriteLine($"AlcoholContent: {AlcoholContent}, BeverageType: {BeverageType}, Origin: {Origin}");
        }
    }
}