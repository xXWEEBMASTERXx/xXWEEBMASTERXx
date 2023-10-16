public class Szemely
{
    public string Nev { get; }

    private DateTime szuletesiDatum;

    public int Kor
    {
        get
        {
            TimeSpan age = DateTime.Now - szuletesiDatum;
            return (int)(age.TotalDays / 365.25);
        }
    }

    public Szemely(string nev, DateTime szuletesiDatum)
    {
        Nev = nev;
        this.szuletesiDatum = szuletesiDatum;
        if (Kor < 14)
            throw new HibasEletkorException();
    }

    public override string ToString()
    {
        return $"{Nev} ({Kor} éves)";
    }
}
