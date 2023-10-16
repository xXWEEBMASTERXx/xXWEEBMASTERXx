public class Liftek
{
    private List<Lift> liftek;

    public Liftek(IEnumerable<Lift> liftek)
    {
        this.liftek = new List<Lift>(liftek);
    }

    public Lift this[int index]
    {
        get
        {
            if (index < 1 || index > liftek.Count)
            {
                throw new IndexOutOfRangeException("Nincs ilyen sorszámú lift!");
            }
            return liftek[index - 1];
        }
    }
}
