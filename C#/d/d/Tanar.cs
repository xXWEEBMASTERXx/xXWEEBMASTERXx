public class Tanar : Szemely, IVizsgalat
{
    public double EvvegiJegyekAtlag { get; }

    public Tanar(string nev, DateTime szuletesiDatum, double evvegiJegyekAtlag) : base(nev, szuletesiDatum)
    {
        EvvegiJegyekAtlag = evvegiJegyekAtlag;
    }

    public bool JoAlanyE()
    {
        return Kor < 30 && EvvegiJegyekAtlag >= 3.5;
    }

    public override string ToString()
    {
        return base.ToString() + (JoAlanyE() ? " (jó alany)" : " (rossz alany)");
    }
}
