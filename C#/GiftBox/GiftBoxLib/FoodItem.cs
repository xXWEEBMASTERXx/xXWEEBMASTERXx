namespace GiftBoxLib
{
    public class FoodItem : IGiftItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public DateTime ExpiryDate { get; set; }
        public double Weight { get; set; }
        public bool IsVegetarian { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}, Category: {Category}, Price: {Price}");
            Console.WriteLine($"ExpiryDate: {ExpiryDate}, Weight: {Weight}, IsVegetarian: {IsVegetarian}");
        }
    }
}