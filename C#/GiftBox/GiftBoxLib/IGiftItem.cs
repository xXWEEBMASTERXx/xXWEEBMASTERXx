namespace GiftBoxLib
{
    public interface IGiftItem
    {
        string Name { get; set; }
        decimal Price { get; set; }
        string Category { get; set; }
        void DisplayDetails();
    }
}