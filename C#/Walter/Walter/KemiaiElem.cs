class KemiaiElem : IReakcioKepes
{
    public string Vegyjel { get; }
    public int Rendszam { get; }
    public int Focsoport { get; }

    public KemiaiElem(string vegyjel, int rendszam, int focsoport)
    {
        Vegyjel = vegyjel;
        Rendszam = rendszam;
        Focsoport = focsoport;
    }

    public bool ReakciobaLephet()
    {
        return true;
    }

    public bool ReakciobaLephet(IReakcioKepes masik)
    {
        return ReakciobaLephet() && masik.ReakciobaLephet();
    }
}

interface IReakcioKepes
{
    bool ReakciobaLephet();
    bool ReakciobaLephet(IReakcioKepes masik);
}
