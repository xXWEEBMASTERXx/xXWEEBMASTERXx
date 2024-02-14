namespace GiftBoxLib
{
    public class GiftBox<T> where T : IGiftItem
    {
        public List<T> Items { get; set; }

        public GiftBox()
        {
            Items = new List<T>();
        }

        public void AddItem(T item)
        {
            Items.Add(item);
        }

        public decimal CalculateTotalPrice()
        {
            return Items.Sum(item => item.Price);
        }

        public void DisplayItems()
        {
            foreach (var item in Items)
            {
                item.DisplayDetails();
                Console.WriteLine("--------");
            }
        }
    }
}