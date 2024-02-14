namespace GiftBoxLib
{
    public class CosmeticItem : IGiftItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        public string Volume { get; set; }
        public string SkinType { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}, Category: {Category}, Price: {Price}");
            Console.WriteLine($"Brand: {Brand}, Volume: {Volume}, SkinType: {SkinType}");
        }
    }
}