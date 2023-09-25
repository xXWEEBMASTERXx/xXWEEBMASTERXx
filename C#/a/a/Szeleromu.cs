public class Szeleromu
{
    public string Regio { get; set; }
    public string Megye { get; set; }
    public string Telepules { get; set; }
    public int Darab { get; set; }
    public int Teljesitmeny { get; set; }
    public int Ev { get; set; }

    public Szeleromu(string regio, string megye, string telepules, int darab, int teljesitmeny, int ev)
    {
        Regio = regio;
        Megye = megye;
        Telepules = telepules;
        Darab = darab;
        Teljesitmeny = teljesitmeny;
        Ev = ev;
    }
}
