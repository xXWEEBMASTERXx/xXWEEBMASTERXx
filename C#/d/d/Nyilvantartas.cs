public class Nyilvantartas
{
    private List<Szemely> szemelyek = new List<Szemely>();

    public Szemely this[int index]
    {
        get
        {
            if (index >= 0 && index < szemelyek.Count)
            {
                return szemelyek[index];
            }
            return null;
        }
    }

    public List<Diak> Diakok
    {
        get
        {
            return szemelyek.OfType<Diak>().ToList();
        }
    }

    public List<Tanar> Tanarok
    {
        get
        {
            return szemelyek.OfType<Tanar>().ToList();
        }
    }

    public void AddSzemely(Szemely szemely)
    {
        szemelyek.Add(szemely);
    }
}